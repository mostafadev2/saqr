using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Emgu.CV;
using Emgu.CV.Structure;
using Emgu.CV.CvEnum;
using System.IO;
using System.Diagnostics;
using System.Data.SqlClient;
using System.Configuration;
using System.Net;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Reflection;

namespace FRAttendanceSystem
{
    public partial class AttendanceOut : Form
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
        SqlConnection con, con2, con3, con4, con5;
        private string timeOutUrl = "", timeOutUser = "", timeOutPass = "";
        public string StaffName;

        public AttendanceOut()
        {
            InitializeComponent();
            todayTimedOutUsers();
            var config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            timeOutUrl = config.AppSettings.Settings["timeOutUrl"].Value;
            timeOutUser = config.AppSettings.Settings["timeOutUser"].Value;
            timeOutPass = config.AppSettings.Settings["timeOutPass"].Value;
            string constr = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True";
            con = new SqlConnection(constr);
            con2 = new SqlConnection(constr);
            con3 = new SqlConnection(constr);
            con4 = new SqlConnection(constr);
            con5 = new SqlConnection(constr);


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

        private void btnStop_Click(object sender, EventArgs e)
        {
            //You'll want to unsubcribe from the event handler so this doesn't occur
            Application.Idle -= FrameGrabber;
            if (grabber != null)
            {
                grabber.Dispose();
            }
            button1.Enabled = true;
            imageBoxFrameGrabber.Image = null;
            //picImage.Image = null;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                //Trained face counter
                ContTrain = ContTrain + 1;

                //Get a gray frame from capture device
                gray = grabber.QueryGrayFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);

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
                labels.Add(comboBox1.SelectedItem.ToString());

                //Show face added in gray scale
                //imageBox1.Image = TrainedFace;

                //Write the number of triained faces in a file text for further load
                File.WriteAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", trainingImages.ToArray().Length.ToString() + "%");

                //Write the labels of triained faces in a file text for further load
                for (int i = 1; i < trainingImages.ToArray().Length + 1; i++)
                {
                    trainingImages.ToArray()[i - 1].Save(Application.StartupPath + "/TrainedFaces/face" + i + ".bmp");
                    File.AppendAllText(Application.StartupPath + "/TrainedFaces/TrainedLabels.txt", labels.ToArray()[i - 1] + "%");
                }

                MessageBox.Show(comboBox1.SelectedItem.ToString() + "´s face detected and added :)", "Training OK", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Enable the face detection first", "Training Fail", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        void FrameGrabber(object sender, EventArgs e)
        {
            label3.Text = "0";
            //label4.Text = "";
            NamePersons.Add("");

            if (!toggleCameraSource.Checked)
            {
                // Use local webcam
                try
                {
                    currentFrame = grabber.QueryFrame().Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong : {ex}", "Error");
                }

            }
            else
            {
                // Use IP camera
                try
                {
                    currentFrame = GetFrameFromIpCamera(timeOutUrl).Resize(320, 240, Emgu.CV.CvEnum.INTER.CV_INTER_CUBIC);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Something went wrong : {ex}", "Error");
                }

                if (currentFrame == null)
                {
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
                    //Draw the label for each face detected and recognized
                    currentFrame.Draw(name, ref font, new Point(f.rect.X - 2, f.rect.Y - 2), new Bgr(Color.LightGreen));

                }

                NamePersons[t - 1] = name;
                NamePersons.Add("");


                //Set the number of faces detected on the scene
                label3.Text = facesDetected[0].Length.ToString();

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
            label4.Text = names;
            if (names != null)
            {
                //MessageBox.Show(NamePersons[0]);
                getdetails(NamePersons[0]);
            }
            names = "";
            //Clear the list(vector) of names
            NamePersons.Clear();

        }

        private string getdetails(string name)
        {
            string id = "";
            string querry = "select * from Staff where Name='" + name + "'";
            SqlCommand cmd = new SqlCommand(querry, con);
            con.Open();
            SqlDataReader dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                id = dr["UniqueID"].ToString();

                StaffName = dr["Name"].ToString();
                txtStaffname.Text = StaffName;

                //MessageBox.Show("" + id);
                //string currentdate = DateTime.Now.ToShortDateString();
                //string currenttime = DateTime.Now.ToString("HH:mm:tt");
                //string getval = checkalreadypresent(id, currentdate);

                string currentdate2 = DateTime.Now.ToShortDateString();
                string currenttime2 = DateTime.Now.ToString("HH:mm:tt");
                string getval2 = CheckTimeOut(id, currentdate2);

                if (getval2.Equals("no"))
                {
                    try
                    {
                        con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True");
                        con.Open();

                        string cb = "update Attendance set TimeOut=@d2 where UniqueID=@d1 AND sDate=@d3";

                        string CurrentTimeOut = DateTime.Now.ToString("HH:mm:tt");

                        cmd = new SqlCommand(cb);

                        cmd.Connection = con;
                        cmd.Parameters.AddWithValue("@d1", id);
                        cmd.Parameters.AddWithValue("@d2", CurrentTimeOut);
                        cmd.Parameters.AddWithValue("@d3", currentdate2);
                        cmd.ExecuteReader();

                        //You'll want to unsubcribe from the event handler so this doesn't occur
                        //Application.Idle -= FrameGrabber;
                        //grabber.Dispose();
                        //button1.Enabled = true;

                        //SendParentSMStimeout();
                        reset();
                        BackgroundWorker_DoWork();
                        //MessageBox.Show("Time-Out Attendance Added", "Facial Recognition Attendance System", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        todayTimedOutUsers();

                        if (con.State == ConnectionState.Open)
                        {
                            con.Close();
                        }

                        con.Close();

                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else if (getval2.Equals("yes"))
                {
                    // Attendance already taken for today
                    //MessageBox.Show("Your Attendance is complete", "Sorry", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    //Application.Idle -= FrameGrabber;
                    //grabber.Dispose();
                    //button1.Enabled = true;
                    //reset();

                }



            }
            else
            {
                // MessageBox.Show("No Names detected");

            }
            dr.Close();
            con.Close();
            return id;
        }
        private void BackgroundWorker_DoWork()
        {
            string projectPath = Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\"));
            string filePath = Path.Combine(projectPath, "Resources\\Sounds", "TimeInOutNotification.wav");

            System.Media.SoundPlayer player = new System.Media.SoundPlayer(filePath);
            player.Play();
        }
        private string CheckTimeOut(string id, string date)
        {
            string val2 = "";
            string querry4 = "select TimeOut from Attendance where UniqueID='" + id + "' AND sDate='" + date + "'";
            SqlCommand cmd4 = new SqlCommand(querry4, con4);
            con4.Open();
            SqlDataReader ddr = cmd4.ExecuteReader();

            if (ddr.Read())
            {
                txtTimeOUT.Text = ddr["TimeOut"].ToString();
                //txtTimeOUT.Text = TimeouT;

                if (txtTimeOUT.Text.Equals(""))
                {
                    val2 = "no";
                }
                else
                {
                    val2 = "yes";
                }
            }
            con4.Close();
            return val2;
        }

        public void reset()
        {
            //txtParentMobile.Text = "";
            //txtParentMobileTwo.Text = "";
            //txtname = "";
            txtSchool.Text = "";
            txtStudentName.Text = "";
            txtTimeIN.Text = "";
            txtTimeOUT.Text = "";
            //imageBox1.Image = null;
            imageBoxFrameGrabber.Image = null;
            //picImage.Image = null;
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
            if (!string.IsNullOrEmpty(timeOutUser))
            {
                request = (HttpWebRequest)WebRequest.Create(url);
                string credentials = Convert.ToBase64String(Encoding.ASCII.GetBytes(timeOutUser + ":" + timeOutPass));
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
                if (string.IsNullOrEmpty(timeOutUrl))
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
        private void InitRTSPCam()
        {
            if (timeOutUrl.StartsWith("rtsp"))
            {
                var url = "";
                if (!string.IsNullOrEmpty(timeOutUser))
                {
                    string baseWithoutProtocol = timeOutUrl.Substring("rtsp://".Length);
                    url = $"rtsp://{timeOutUser}:{timeOutPass}@{baseWithoutProtocol}";
                }
                else
                {
                    url = timeOutUrl;
                }
                RTSPCapture = new Capture(url);
            }
        }
        public void todayTimedOutUsers()
        {

            var todayDate = DateTime.Now.ToString("MM/dd/yyyy");

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(
                    $@"SELECT Name 
                    FROM Attendance 
                    WHERE CONVERT(DATE, sDate, 101) BETWEEN '{todayDate}' AND '{todayDate}' and TimeOut is not null ORDER BY id desc", con);

            try
            {
                timeOutListBox.Items.Clear();
                TotalUsersLBL.Text = "";
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int row = 0; row < dt.Rows.Count; row++)
                    {
                        timeOutListBox.Items.Add(dt.Rows[row][0]);
                    }
                    TotalUsersLBL.Text = $"Total Users : {dt.Rows.Count}";
                }
                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
