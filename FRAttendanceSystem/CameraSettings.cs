using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRAttendanceSystem
{
    public partial class CameraSettings : Form
    {
        private Configuration config;
        public CameraSettings()
        {
            InitializeComponent();
            config = ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
            InitializeUrls();
        }

        private void OK_Click(object sender, EventArgs e)
        {
            string timeInUrl = timeInUrlTXT.Text;
            string timeOutUrl = timeOutUrlTXT.Text;
            string captureUrl = captureUrlTXT.Text;
            if (string.IsNullOrEmpty(timeInUrl) || string.IsNullOrEmpty(timeOutUrl) || string.IsNullOrEmpty(captureUrl))
            {
                MessageBox.Show("Please enter all camera url", "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            #region timeIn
            config.AppSettings.Settings["timeInUrl"].Value = timeInUrl;
            config.AppSettings.Settings["timeInUser"].Value = timeInUserTXT.Text;
            config.AppSettings.Settings["timeInPass"].Value = timeInPassTXT.Text;
            #endregion

            #region timeIn
            config.AppSettings.Settings["timeOutUrl"].Value = timeOutUrl;
            config.AppSettings.Settings["timeOutUser"].Value = timeOutUserTXT.Text;
            config.AppSettings.Settings["timeOutPass"].Value = timeOutPassTXT.Text;
            #endregion

            #region timeIn
            config.AppSettings.Settings["captureUrl"].Value = captureUrl;
            config.AppSettings.Settings["captureUser"].Value = captureUserTXT.Text;
            config.AppSettings.Settings["capturePass"].Value = capturePassTXT.Text;
            #endregion

            config.Save(ConfigurationSaveMode.Modified);
            MessageBox.Show("Url updated successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            return;
        }

        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CameraSettings_Load(object sender, EventArgs e)
        {
            panel1.Height = 2;
            panel1.Width = this.Width - 90;
            panel1.BackColor = Color.Black;

            panel2.Height = 2;
            panel2.Width = this.Width - 90;
            panel2.BackColor = Color.Black;
        }
        private void InitializeUrls()
        {

            #region timeIn
            timeInUrlTXT.Text = config.AppSettings.Settings["timeInUrl"]?.Value;
            timeInUserTXT.Text = config.AppSettings.Settings["timeInUser"]?.Value;
            timeInPassTXT.Text = config.AppSettings.Settings["timeInPass"]?.Value;
            #endregion

            #region timeIn
            timeOutUrlTXT.Text = config.AppSettings.Settings["timeOutUrl"]?.Value;
            timeOutUserTXT.Text = config.AppSettings.Settings["timeOutUser"]?.Value;
            timeOutPassTXT.Text = config.AppSettings.Settings["timeOutPass"]?.Value;
            #endregion

            #region timeIn
            captureUrlTXT.Text = config.AppSettings.Settings["captureUrl"]?.Value;
            captureUserTXT.Text = config.AppSettings.Settings["captureUser"]?.Value;
            capturePassTXT.Text = config.AppSettings.Settings["capturePass"]?.Value;
            #endregion
        }
    }
}
