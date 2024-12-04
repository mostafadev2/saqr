using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FRAttendanceSystem
{
    public partial class Login : Form
    {
        SqlDataReader rdr = null;
        SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();

        public Login()
        {
            InitializeComponent();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            LoginAdmin();
        }
        #region Login
        public void LoginAdmin()
        {
            if (txtUserName.Text == "")
            {
                MessageBox.Show("Please enter user name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUserName.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            try
            {
                SqlConnection myConnection = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True");
                //SqlConnection myConnection = default(SqlConnection);
                //myConnection = new SqlConnection(Properties.Settings.Default.warehousingConnectionString);

                //SqlCommand myCommand = default(SqlCommand);

                SqlCommand myCommand = new SqlCommand("SELECT Username,password FROM Registration WHERE Username = @username AND password = @UserPassword", myConnection);
                SqlParameter uName = new SqlParameter("@username", SqlDbType.VarChar);
                SqlParameter uPassword = new SqlParameter("@UserPassword", SqlDbType.VarChar);
                uName.Value = txtUserName.Text;
                uPassword.Value = txtPassword.Text;
                myCommand.Parameters.Add(uName);
                myCommand.Parameters.Add(uPassword);

                myCommand.Connection.Open();

                SqlDataReader myReader = myCommand.ExecuteReader();

                if (myReader.Read() == true)
                {

                    con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True");
                    con.Open();
                    string ct = "select usertype from Registration where Username='" + txtUserName.Text + "' and Password='" + txtPassword.Text + "'";
                    cmd = new SqlCommand(ct);
                    cmd.Connection = con;
                    rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        txtUserType.Text = (rdr.GetString(0));
                    }
                    if ((rdr != null))
                    {
                        rdr.Close();
                    }

                    if (txtUserType.Text.Trim() == "Administrator")
                    {
                        this.Hide();

                        Main main = new Main();
                        main.Show();
                        //frmMainMenu mm = new frmMainMenu();

                        //mm.Show();
                        main.lblUser.Text = txtUserName.Text;
                        main.lblUserType.Text = txtUserType.Text;

                    }
                    if (txtUserType.Text.Trim() == "User")
                    {
                        //this.Hide();

                        //SchoolAdminMain schoolAdmin = new SchoolAdminMain();
                        //schoolAdmin.Show();


                        //schoolAdmin.lblUser.Text = txtUserName.Text;
                        //schoolAdmin.lblUserType.Text = txtUserType.Text;
                    }

                }
                else
                {
                    MessageBox.Show("Login Failed...Try again !", "Facial Recognition Attendance System", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    txtUserName.Clear();
                    txtPassword.Clear();
                    txtUserName.Focus();

                }
                if (myConnection.State == ConnectionState.Open)
                {
                    myConnection.Dispose();
                }



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        #endregion

        private void Cancel_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
