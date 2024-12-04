using Emgu.CV;
using Emgu.CV.CvEnum;
using Emgu.CV.Structure;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Net;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace FRAttendanceSystem.Users
{

    public partial class UpdateUser : Form
    {
        Image<Bgr, Byte> currentFrame;
        Capture grabber, RTSPCapture;
        HaarCascade face;
        string finalname;
        HaarCascade eye;
        MCvFont font = new MCvFont(FONT.CV_FONT_HERSHEY_TRIPLEX, 0.5d, 0.5d);
        Image<Gray, byte> result, TrainedFace = null;
        Image<Gray, byte> gray = null;
        List<Image<Gray, byte>> trainingImages = new List<Image<Gray, byte>>();
        List<string> labels = new List<string>();
        List<string> NamePersons = new List<string>();
        int ContTrain, NumLabels, t;
        string name, names = null;
        SqlConnection con;
        int count = 0;
        string filepath = "";

        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        //SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        SqlConnection cnn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True");
        private string captureUrl = "", captureUser = "", capturePass = "";
        private readonly string uniqueId;
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True";
        private string oldName;
        public UpdateUser(string uniqueId)
        {
            this.uniqueId = uniqueId;
            InitializeComponent();
            this.Width = 975;
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            captureUrl = config.AppSettings.Settings["captureUrl"].Value;
            captureUser = config.AppSettings.Settings["captureUser"].Value;
            capturePass = config.AppSettings.Settings["capturePass"].Value;
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True";
            con = new SqlConnection(constr);
            //Load haarcascades for face detection
            face = new HaarCascade("haarcascade_frontalface_default.xml");
            //eye = new HaarCascade("haarcascade_eye.xml");
            try
            {
                //Load of previus trainned faces and labels for each image
                string Labelsinfo = File.ReadAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt");
                string[] Labels = Labelsinfo.Split('%');
                NumLabels = Convert.ToInt16(Labels[0]);
                ContTrain = NumLabels;
                string LoadFaces;

                for (int tf = 1; tf < NumLabels + 1; tf++)
                {
                    LoadFaces = "face" + tf + ".bmp";
                    trainingImages.Add(new Image<Gray, byte>(Application.StartupPath + "/TrainedFaces/" + LoadFaces));
                    labels.Add(Labels[tf]);
                }

            }
            catch (Exception e)
            {
                //MessageBox.Show(e.ToString());
                MessageBox.Show("Nothing in binary database, please add at least a face(Simply train the prototype with the Add Face Button).", "Triained faces load", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!toggleCameraSource.Checked)
            {
                grabber = new Capture();
                grabber.QueryFrame();
            }
            else
            {
                // If credentials are provided, append them to the URL
                InitRTSPCam();
            }
            //Initialize the FrameGraber event
            Application.Idle += new EventHandler(FrameGrabber);
            button1.Enabled = false;
        }
        private void GetUser()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    string query = $"SELECT TOP(1) UniqueID , Name as UserName , Phone , Email , Gender , DOB , Address FROM Staff where UniqueID = {uniqueId}";
                    using (var command = new SqlCommand(query, connection))
                    {
                        connection.Open();

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read()) // Don't assume we have any rows.
                            {
                                txtUserID.Text = reader["UniqueID"].ToString();
                                txtName.Text = reader["UserName"].ToString();
                                txtPhone.Text = reader["Phone"].ToString();
                                txtEmail.Text = reader["Email"].ToString();
                                ddlGender.Text = reader["Gender"].ToString();
                                ddlDOB.Value = DateTime.ParseExact(reader["DOB"].ToString(), "dd/MM/yyyy", CultureInfo.InvariantCulture);
                                txtAddress.Text = reader["Address"].ToString();
                                oldName = txtName.Text;
                            }

                        }

                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }

        private void UpdateUser_Load(object sender, EventArgs e)
        {
            GetUser();
        }

        private void InitRTSPCam()
        {
            if (captureUrl.StartsWith("rtsp"))
            {
                var url = "";
                if (!string.IsNullOrEmpty(captureUser))
                {
                    string baseWithoutProtocol = captureUrl.Substring("rtsp://".Length);
                    url = $"rtsp://{captureUser}:{capturePass}@{baseWithoutProtocol}";
                }
                else
                {
                    url = captureUrl;
                }
                RTSPCapture = new Capture(url);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter Name", "Facial Recognition Attendance System", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }

            count++;
            try
            {
                //Trained face counter
                ContTrain = ContTrain + 1;

                //Get a gray frame from capture device
                if (toggleCameraSource.Checked)
                {
                    gray = GetFrameFromIpCamera(captureUrl).Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC)?.Convert<Gray, Byte>();
                }
                else
                {
                    gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                }

                if (gray == null)
                    return;

                //Face Detector
                MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
                face,
                1.2,
                10,
                Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                new Size(20, 20));

                //Action for each element detected
                foreach (MCvAvgComp f in facesDetected[0])
                {
                    TrainedFace = currentFrame.Copy(f.rect).Convert<Gray, byte>();
                    break;
                }

                //resize face detected image for force to compare the same size with the 
                //test image with cubic interpolation type method
                TrainedFace = result.Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                trainingImages.Add(TrainedFace);
                labels.Add(txtName.Text);

                //Show face added in gray scale
                imageBox1.Image = TrainedFace;

                //Write the number of triained faces in a file text for further load
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                //Write the labels of triained faces in a file text for further load
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    filepath = "" + Application.StartupPath + "/TrainedFaces/face" + i + ".bmp";
                    button2.Enabled = false;
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                }

                MessageBox.Show(txtName.Text + "´s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);

                txtName.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string query = $"update Staff set Name = N'{txtName.Text}',Phone='{txtPhone.Text}' ,Email=N'{txtEmail.Text}',Gender=N'{ddlGender.Text}',DOB='{ddlDOB.Text}',Address=N'{txtAddress.Text}' where UniqueID = '{uniqueId}'";
            using (SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True"))
            {
                con.Open();
                cmd = new SqlCommand(query);
                cmd.Connection = con;
                cmd.ExecuteReader();
                MessageBox.Show("Record Submitted Successfully", "Facial Recognition Attendance System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                imageBoxFrameGrabber.Image?.Save(AppDomain.CurrentDomain.BaseDirectory + txtName.Text + ".jpg");
                if(imageBoxFrameGrabber.Image!=null)
                {
                    var imagePath = $"{AppDomain.CurrentDomain.BaseDirectory}{oldName}.jpg";
                    if (File.Exists(imagePath))
                    {
                        File.Delete(imagePath);
                    }
                }
                con.Close();
            }

        }

        private Image<Bgr, Byte> GetFrameFromIpCamera(string url)
        {
            try
            {
                if (url.StartsWith("http"))
                {
                    return ConnectToWebCam(url);
                }
                else
                {
                    return ConnectToRTSP();
                }
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        private Image<Bgr, Byte> ConnectToWebCam(string url)
        {
            HttpWebRequest request = null;
            if (!string.IsNullOrEmpty(captureUser))
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(captureUser + ":" + capturePass));
                request.Headers[HttpRequestHeader.Authorization] = "Basic " + credentials;
            }

            using (HttpWebResponse response = (HttpWebResponse)request.GetResponse())
            {
                if (response.ContentType.StartsWith("image"))
                {
                    using (Stream stream = response.GetResponseStream())
                    {
                        Bitmap bitmap = new Bitmap(stream);
                        return new Image<Bgr, Byte>(bitmap);
                    }
                }
                return null;
            }
        }
        private Image<Bgr, Byte> ConnectToRTSP()
        {
            try
            {
                // Initialize the Capture object with the RTSP URL
                RTSPCapture.SetCaptureProperty(CAP_PROP.CV_CAP_PROP_FPS, 15);
                var frame = RTSPCapture.QueryFrame();
                if (frame == null)
                {
                    throw new Exception("Failed to retrieve frame from RTSP stream.");
                }

                // Convert the frame to an Image<Bgr, Byte>
                return frame;
            }
            catch (Exception ex)
            {
                // Handle exceptions
                Console.WriteLine($"Error: {ex.Message}");
                return null;
            }
        }
        private void toggleCameraSource_CheckedChanged(object sender, EventArgs e)
        {
            if (toggleCameraSource.Checked)
            {
                if (string.IsNullOrEmpty(captureUrl))
                {
                    toggleCameraSource.Checked = false;
                    MessageBox.Show("Error fetching IP camera feed: there is no ip camera in settings", "Camera Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                // Stop the local webcam if running
                if (grabber != null)
                {
                    Application.Idle -= FrameGrabber;
                    grabber.Dispose();
                    grabber = null;
                }
                InitRTSPCam();
            }
            else
            {
                // Restart the local webcam if selected
                if (grabber == null)
                {
                    grabber = new Capture();
                    Application.Idle += new EventHandler(FrameGrabber);
                }
                RTSPCapture.Dispose();
                grabber = null;
            }
        }
        void FrameGrabber(object sender, EventArgs e)
        {
            //label3.Text = "0";
            //label4.Text = "";
            NamePersons.Add("");

            if (!toggleCameraSource.Checked)
            {
                // Use local webcam
                currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
            }
            else
            {
                // Use IP camera
                currentFrame = GetFrameFromIpCamera(captureUrl)?.Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC).Copy();

                if (currentFrame == null)
                {
                    button4_Click(sender, e);
                    MessageBox.Show("Can't connect to the ip camera", "Ip Camera", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return; // Exit if frame retrieval fails
                }
            }
            //Convert it to Grayscale
            gray = currentFrame.Convert<Gray, Byte>();

            //Face Detector
            MCvAvgComp[][] facesDetected = gray.DetectHaarCascade(
          face,
          1.2,
          10,
          Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
          new Size(20, 20));

            //Action for each element detected
            foreach (MCvAvgComp f in facesDetected[0])
            {
                t = t + 1;
                result = currentFrame.Copy(f.rect).Convert<Gray, byte>().Resize(100, 100, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                //draw the face detected in the 0th (gray) channel with blue color
                currentFrame.Draw(f.rect, new Bgr(Color.Red), 2);


                if (trainingImages.ToArray().Length != 0)
                {

                    //TermCriteria for face recognition with numbers of trained images like maxIteration
                    MCvTermCriteria termCrit = new MCvTermCriteria(ContTrain, 0.001);

                    //Eigen face recognizer
                    EigenObjectRecognizer recognizer = new EigenObjectRecognizer(
                       trainingImages.ToArray(),
                       labels.ToArray(),
                       3000,
                       ref termCrit);

                    name = recognizer.Recognize(result);
                    // MessageBox.Show("" + name);
                    // textBox2.Text = name;
                    finalname = name;
                    finalname = "";
                    //Draw the label for each face detected and recognized
                    currentFrame.Draw(finalname, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

                }

                NamePersons[t - 1] = name;
                NamePersons.Add("");


                //Set the number of faces detected on the scene
                //label3.Text = facesDetected[0].Length.ToString();

                /*
                //Set the region of interest on the faces
                        
                gray.ROI = f.rect;
                MCvAvgComp[][] eyesDetected = gray.DetectHaarCascade(
                   eye,
                   1.1,
                   10,
                   Emgu.CV.CvEnum.HAAR_DETECTION_TYPE.DO_CANNY_PRUNING,
                   new Size(20, 20));
                gray.ROI = Rectangle.Empty;

                foreach (MCvAvgComp ey in eyesDetected[0])
                {
                    Rectangle eyeRect = ey.rect;
                    eyeRect.Offset(f.rect.X, f.rect.Y);
                    currentFrame.Draw(eyeRect, new Bgr(Color.Blue), 2);
                }
                 */

            }
            t = 0;

            //Names concatenation of persons recognized
            for (int nnn = 0; nnn < facesDetected[0].Length; nnn++)
            {
                names = names + NamePersons[nnn] + ", ";
            }
            //Show the faces procesed and recognized
            imageBoxFrameGrabber.Image = currentFrame;
            // label4.Text = names;
            names = "";
            //Clear the list(vector) of names
            NamePersons.Clear();

        }
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void button4_Click(object sender, EventArgs e)
        {
            //You'll want to unsubcribe from the event handler so this doesn't occur
            Application.Idle -= FrameGrabber;
            if (grabber != null)
            {
                grabber.Dispose();
                grabber = null;
            }

            button1.Enabled = true;
        }
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (grabber != null)
            {
                grabber.Dispose();
                grabber = null;
            }
            base.OnFormClosing(e);
            // Code
        }
        public static void ModifyFile(string oldName,string newName)
        {
            string filePath = $"{Application.StartupPath}/TrainedFaces/TrainedLabels.txt";
            try
            {
                // Read the content of the file
                string fileContent = File.ReadAllText(filePath);

                // Check if the file content is valid and follows the expected structure
                if (!string.IsNullOrEmpty(fileContent))
                {
                    // Split the content by '%'
                    string[] parts = fileContent.Split('%');

                    // The first part is the count of names
                    int nameCount = int.Parse(parts[0]);

                    // Extract the list of names
                    var names = parts.Skip(1).Take(nameCount).ToList(); // Skip the count part and take only the names

                    if (names.Count > 0)
                    {
                        var indexOfUser = names.IndexOf(oldName);
                        // Remove the first name (or you could remove a specific name)
                        names[indexOfUser]=newName; // Remove one name (you can change the logic here to remove a specific name)

                        // Reconstruct the content
                        string updatedContent = nameCount + "%" + string.Join("%", names) + "%";

                        // Write the modified content back to the file
                        File.WriteAllText(filePath, updatedContent);
                    }
                    else
                    {
                        Console.WriteLine("No names left to remove.");
                    }
                }
                else
                {
                    Console.WriteLine("File is empty.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

    }
}
