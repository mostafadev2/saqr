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
    public partial class AdminReg : Form
    {
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        //SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True");
        public AdminReg()
        {
            InitializeComponent();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            register();
        }

        #region register admin
        public void register()
        {
            if (txtUsername.Text == "")
            {
                MessageBox.Show("Please enter username", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsername.Focus();
                return;
            }
            if (cmbUserType.Text == "")
            {
                MessageBox.Show("Please select user type", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmbUserType.Focus();
                return;
            }
            if (txtPassword.Text == "")
            {
                MessageBox.Show("Please enter password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtPassword.Focus();
                return;
            }
            if (txtName.Text == "")
            {
                MessageBox.Show("Please enter name", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtName.Focus();
                return;
            }
            if (txtContact_no.Text == "")
            {
                MessageBox.Show("Please enter contact no.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtContact_no.Focus();
                return;
            }
            if (txtEmail_Address.Text == "")
            {
                MessageBox.Show("Please enter email", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtEmail_Address.Focus();
                return;
            }
            try
            {
                SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True");
                con.Open();
                string ct = "select username from registration where username=@find";

                cmd = new SqlCommand(ct);
                cmd.Connection = con;
                cmd.Parameters.Add(new SqlParameter("@find", System.Data.SqlDbType.NChar, 30, "username"));
                cmd.Parameters["@find"].Value = txtUsername.Text;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Username Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtUsername.Text = "";
                    txtUsername.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True");
                con.Open();
                string ct1 = "select Email from registration where Email='" + txtEmail_Address.Text + "'";

                cmd = new SqlCommand(ct1);
                cmd.Connection = con;
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    MessageBox.Show("Email ID Already Exists", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtEmail_Address.Text = "";
                    txtEmail_Address.Focus();


                    if ((rdr != null))
                    {
                        rdr.Close();
                    }
                    return;
                }
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True");
                con.Open();

                string cb = "insert into Registration(Username,usertype,password,ContactNo,Email,Name,JoiningDate) VALUES ('" + txtUsername.Text + "','" + cmbUserType.Text + "','" + txtPassword.Text + "','" + txtContact_no.Text + "','" + txtEmail_Address.Text + "','" + txtName.Text + "','" + System.DateTime.Now + "')";

                cmd = new SqlCommand(cb);
                cmd.Connection = con;
                cmd.ExecuteReader();
                con.Close();
                MessageBox.Show("Successfully Registered", "User", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Autocomplete();
                //btnRegister.Enabled = false;
                reset();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region reset
        public void reset()
        {
            txtContact_no.Text = string.Empty;
            txtEmail_Address.Text = string.Empty;
            txtName.Text = string.Empty;
            txtPassword.Text = string.Empty;
            txtUsername.Text = string.Empty;
        }
        #endregion

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
