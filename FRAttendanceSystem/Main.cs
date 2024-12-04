using FRAttendanceSystem.Users;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRAttendanceSystem
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            #region for Time
            day.Text = System.DateTime.Now.ToString("dddd");
            date.Text = System.DateTime.Now.ToString("MM/dd/yyyy");
            timeNow.Text = System.DateTime.Now.ToString("HH:mm:ss");
            #endregion
        }

        private void Main_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void RegistertoolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AdminReg adminregg = new AdminReg();
            adminregg.Show();
        }

        private void CaptureFaceToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CaptureFace capturefac = new CaptureFace();
            capturefac.Show();
        }

        private void studentAttendanceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FacialAttendance fa = new FacialAttendance();
            fa.Show();
        }

        private void timeoutToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            AttendanceOut attenOut = new AttendanceOut();
            attenOut.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Search seach = new Search();
            seach.Show();
        }

        private void attendanceReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AttendanceReport attenreport = new AttendanceReport();
            attenreport.Show();
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            Login adminlog = new Login();
            adminlog.Show();
        }

        private void cameraSettingsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CameraSettings camera =new CameraSettings();
            camera.Show();
        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var allUsers = new AllUsers();
            allUsers.Show();
        }
    }
}
