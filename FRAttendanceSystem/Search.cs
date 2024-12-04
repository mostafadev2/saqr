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
    public partial class Search : Form
    {
        DataTable dtable = new DataTable();
        //SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        SqlConnection con = null;
        SqlDataReader rdr = null;
        public Search()
        {
            InitializeComponent();
        }

        private void btnReset_Click(object sender, EventArgs e)
        {

        }

        #region Auto Complete
        private void AutoCompleteName()
        {
            try
            {
                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True");
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name FROM Staff", con);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "registration");
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["Name"].ToString());

                }
                txtAutoName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtAutoName.AutoCompleteCustomSource = col;
                txtAutoName.AutoCompleteMode = AutoCompleteMode.Suggest;

                con.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion
        private void Name_Of_User_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !(char.IsLetter(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == (char)Keys.Space);
        }
        #region Display Record on Textboxes
        public void DisplayRecord()
        {
            try
            {

                con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True");

                con.Open();
                cmd = con.CreateCommand();

                cmd.CommandText = "SELECT UniqueID,Name,Phone,Email,Gender,DOB,Address FROM Staff WHERE Name = '" + txtAutoName.Text.Trim() + "'";
                rdr = cmd.ExecuteReader();

                if (rdr.Read())
                {
                    txtUserID.Text = (rdr.GetString(0).Trim());
                    txtFname.Text = (rdr.GetString(1).Trim());
                    txtPhone.Text = (rdr.GetString(2).Trim());
                    txtEmail.Text = (rdr.GetString(3).Trim());
                    txtGender.Text = (rdr.GetString(4).Trim());
                    txtDOB.Text = (rdr.GetString(5).Trim());
                    txtAddress.Text = (rdr.GetString(6).Trim());

                    pic.ImageLocation = AppDomain.CurrentDomain.BaseDirectory + txtFname.Text + ".jpg";

                }

                if ((rdr != null))
                {
                    rdr.Close();
                }
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        private void txtAutoName_TextChanged(object sender, EventArgs e)
        {
            DisplayRecord();
        }

        private void Search_Load(object sender, EventArgs e)
        {
            AutoCompleteName();
        }
    }
}
