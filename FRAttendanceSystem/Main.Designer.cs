namespace FRAttendanceSystem
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.RegistertoolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.CaptureFaceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentAttendanceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timeoutToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.StudentsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendanceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cameraSettingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.LogoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3 = new System.Windows.Forms.MenuStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.day = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel5 = new System.Windows.Forms.ToolStripStatusLabel();
            this.date = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel7 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel8 = new System.Windows.Forms.ToolStripStatusLabel();
            this.timeNow = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolStripStatusLabel4 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel6 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUserType = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel9 = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip2 = new System.Windows.Forms.StatusStrip();
            this.usersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip3.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.statusStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegistertoolStripMenuItem1
            // 
            this.RegistertoolStripMenuItem1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RegistertoolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.RegistertoolStripMenuItem1.Name = "RegistertoolStripMenuItem1";
            this.RegistertoolStripMenuItem1.Size = new System.Drawing.Size(164, 30);
            this.RegistertoolStripMenuItem1.Text = "Registration";
            this.RegistertoolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RegistertoolStripMenuItem1.Click += new System.EventHandler(this.RegistertoolStripMenuItem1_Click);
            // 
            // CaptureFaceToolStripMenuItem1
            // 
            this.CaptureFaceToolStripMenuItem1.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptureFaceToolStripMenuItem1.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.CaptureFaceToolStripMenuItem1.Name = "CaptureFaceToolStripMenuItem1";
            this.CaptureFaceToolStripMenuItem1.Size = new System.Drawing.Size(178, 30);
            this.CaptureFaceToolStripMenuItem1.Text = "Capture Face";
            this.CaptureFaceToolStripMenuItem1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.CaptureFaceToolStripMenuItem1.Click += new System.EventHandler(this.CaptureFaceToolStripMenuItem1_Click);
            // 
            // attendanceToolStripMenuItem
            // 
            this.attendanceToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.studentAttendanceToolStripMenuItem,
            this.timeoutToolStripMenuItem1});
            this.attendanceToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 11.25F);
            this.attendanceToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.attendanceToolStripMenuItem.Name = "attendanceToolStripMenuItem";
            this.attendanceToolStripMenuItem.Size = new System.Drawing.Size(155, 30);
            this.attendanceToolStripMenuItem.Text = "Attendance";
            this.attendanceToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // studentAttendanceToolStripMenuItem
            // 
            this.studentAttendanceToolStripMenuItem.Name = "studentAttendanceToolStripMenuItem";
            this.studentAttendanceToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.studentAttendanceToolStripMenuItem.Text = "Time-In";
            this.studentAttendanceToolStripMenuItem.Click += new System.EventHandler(this.studentAttendanceToolStripMenuItem_Click);
            // 
            // timeoutToolStripMenuItem1
            // 
            this.timeoutToolStripMenuItem1.Name = "timeoutToolStripMenuItem1";
            this.timeoutToolStripMenuItem1.Size = new System.Drawing.Size(216, 34);
            this.timeoutToolStripMenuItem1.Text = "Time-out";
            this.timeoutToolStripMenuItem1.Click += new System.EventHandler(this.timeoutToolStripMenuItem1_Click);
            // 
            // StudentsToolStripMenuItem
            // 
            this.StudentsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchToolStripMenuItem,
            this.attendanceReportToolStripMenuItem,
            this.cameraSettingsToolStripMenuItem,
            this.usersToolStripMenuItem});
            this.StudentsToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StudentsToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.StudentsToolStripMenuItem.Name = "StudentsToolStripMenuItem";
            this.StudentsToolStripMenuItem.Size = new System.Drawing.Size(102, 30);
            this.StudentsToolStripMenuItem.Text = "Admin";
            this.StudentsToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // attendanceReportToolStripMenuItem
            // 
            this.attendanceReportToolStripMenuItem.Name = "attendanceReportToolStripMenuItem";
            this.attendanceReportToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
            this.attendanceReportToolStripMenuItem.Text = "Attendance Report";
            this.attendanceReportToolStripMenuItem.Click += new System.EventHandler(this.attendanceReportToolStripMenuItem_Click);
            // 
            // cameraSettingsToolStripMenuItem
            // 
            this.cameraSettingsToolStripMenuItem.Name = "cameraSettingsToolStripMenuItem";
            this.cameraSettingsToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
            this.cameraSettingsToolStripMenuItem.Text = "Ip Camera Settings";
            this.cameraSettingsToolStripMenuItem.Click += new System.EventHandler(this.cameraSettingsToolStripMenuItem_Click);
            // 
            // LogoutToolStripMenuItem
            // 
            this.LogoutToolStripMenuItem.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LogoutToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.LogoutToolStripMenuItem.Name = "LogoutToolStripMenuItem";
            this.LogoutToolStripMenuItem.Size = new System.Drawing.Size(105, 30);
            this.LogoutToolStripMenuItem.Text = "Logout";
            this.LogoutToolStripMenuItem.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.LogoutToolStripMenuItem.Click += new System.EventHandler(this.LogoutToolStripMenuItem_Click);
            // 
            // menuStrip3
            // 
            this.menuStrip3.BackColor = System.Drawing.Color.White;
            this.menuStrip3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStrip3.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip3.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.RegistertoolStripMenuItem1,
            this.CaptureFaceToolStripMenuItem1,
            this.attendanceToolStripMenuItem,
            this.StudentsToolStripMenuItem,
            this.LogoutToolStripMenuItem});
            this.menuStrip3.Location = new System.Drawing.Point(0, 0);
            this.menuStrip3.Name = "menuStrip3";
            this.menuStrip3.Size = new System.Drawing.Size(1456, 34);
            this.menuStrip3.TabIndex = 126;
            this.menuStrip3.Text = "menuStrip3";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(177, 43);
            this.toolStripStatusLabel1.Text = "Today is:";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.BackColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripStatusLabel2.Font = new System.Drawing.Font("Bookman Old Style", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel2.ForeColor = System.Drawing.Color.Maroon;
            this.toolStripStatusLabel2.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripStatusLabel2.ImageTransparentColor = System.Drawing.Color.White;
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(0, 43);
            this.toolStripStatusLabel2.TextDirection = System.Windows.Forms.ToolStripTextDirection.Vertical90;
            // 
            // day
            // 
            this.day.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.day.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.day.ForeColor = System.Drawing.Color.White;
            this.day.Name = "day";
            this.day.Size = new System.Drawing.Size(107, 43);
            this.day.Text = "Days";
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripStatusLabel3.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel3.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(41, 43);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel5
            // 
            this.toolStripStatusLabel5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripStatusLabel5.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel5.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel5.Name = "toolStripStatusLabel5";
            this.toolStripStatusLabel5.Size = new System.Drawing.Size(114, 43);
            this.toolStripStatusLabel5.Text = "Date:";
            // 
            // date
            // 
            this.date.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.date.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.date.ForeColor = System.Drawing.Color.White;
            this.date.Name = "date";
            this.date.Size = new System.Drawing.Size(95, 43);
            this.date.Text = "date";
            // 
            // toolStripStatusLabel7
            // 
            this.toolStripStatusLabel7.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripStatusLabel7.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel7.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel7.Name = "toolStripStatusLabel7";
            this.toolStripStatusLabel7.Size = new System.Drawing.Size(41, 43);
            this.toolStripStatusLabel7.Text = "|";
            // 
            // toolStripStatusLabel8
            // 
            this.toolStripStatusLabel8.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.toolStripStatusLabel8.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel8.ForeColor = System.Drawing.Color.White;
            this.toolStripStatusLabel8.Name = "toolStripStatusLabel8";
            this.toolStripStatusLabel8.Size = new System.Drawing.Size(117, 43);
            this.toolStripStatusLabel8.Text = "Time:";
            // 
            // timeNow
            // 
            this.timeNow.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timeNow.Font = new System.Drawing.Font("Bookman Old Style", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeNow.ForeColor = System.Drawing.Color.White;
            this.timeNow.Name = "timeNow";
            this.timeNow.Size = new System.Drawing.Size(97, 43);
            this.timeNow.Text = "time";
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.Color.Black;
            this.statusStrip1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2,
            this.day,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel5,
            this.date,
            this.toolStripStatusLabel7,
            this.toolStripStatusLabel8,
            this.timeNow});
            this.statusStrip1.Location = new System.Drawing.Point(0, 675);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.ManagerRenderMode;
            this.statusStrip1.Size = new System.Drawing.Size(1456, 50);
            this.statusStrip1.TabIndex = 125;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // toolStripStatusLabel4
            // 
            this.toolStripStatusLabel4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel4.Name = "toolStripStatusLabel4";
            this.toolStripStatusLabel4.Size = new System.Drawing.Size(130, 24);
            this.toolStripStatusLabel4.Text = "Logged in As :";
            // 
            // lblUser
            // 
            this.lblUser.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Image = ((System.Drawing.Image)(resources.GetObject("lblUser.Image")));
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(73, 24);
            this.lblUser.Text = "User";
            // 
            // toolStripStatusLabel6
            // 
            this.toolStripStatusLabel6.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripStatusLabel6.Name = "toolStripStatusLabel6";
            this.toolStripStatusLabel6.Size = new System.Drawing.Size(15, 24);
            this.toolStripStatusLabel6.Text = ":";
            // 
            // lblUserType
            // 
            this.lblUserType.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUserType.Name = "lblUserType";
            this.lblUserType.Size = new System.Drawing.Size(91, 24);
            this.lblUserType.Text = "UserType";
            // 
            // toolStripStatusLabel9
            // 
            this.toolStripStatusLabel9.Name = "toolStripStatusLabel9";
            this.toolStripStatusLabel9.Size = new System.Drawing.Size(1124, 24);
            this.toolStripStatusLabel9.Spring = true;
            // 
            // statusStrip2
            // 
            this.statusStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.statusStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel4,
            this.lblUser,
            this.toolStripStatusLabel6,
            this.lblUserType,
            this.toolStripStatusLabel9});
            this.statusStrip2.Location = new System.Drawing.Point(0, 644);
            this.statusStrip2.Name = "statusStrip2";
            this.statusStrip2.Padding = new System.Windows.Forms.Padding(2, 0, 21, 0);
            this.statusStrip2.Size = new System.Drawing.Size(1456, 31);
            this.statusStrip2.TabIndex = 127;
            this.statusStrip2.Text = "statusStrip2";
            // 
            // usersToolStripMenuItem
            // 
            this.usersToolStripMenuItem.Name = "usersToolStripMenuItem";
            this.usersToolStripMenuItem.Size = new System.Drawing.Size(329, 34);
            this.usersToolStripMenuItem.Text = "Users";
            this.usersToolStripMenuItem.Click += new System.EventHandler(this.usersToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FRAttendanceSystem.Properties.Resources.bg_FRAttendanceSystem;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1456, 725);
            this.Controls.Add(this.statusStrip2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip3);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facial Recognition Attendance System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Main_Load);
            this.menuStrip3.ResumeLayout(false);
            this.menuStrip3.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.statusStrip2.ResumeLayout(false);
            this.statusStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.ToolStripMenuItem RegistertoolStripMenuItem1;
        internal System.Windows.Forms.ToolStripMenuItem CaptureFaceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem attendanceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentAttendanceToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem StudentsToolStripMenuItem;
        internal System.Windows.Forms.ToolStripMenuItem LogoutToolStripMenuItem;
        internal System.Windows.Forms.MenuStrip menuStrip3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel day;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel5;
        private System.Windows.Forms.ToolStripStatusLabel date;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel7;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel8;
        private System.Windows.Forms.ToolStripStatusLabel timeNow;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Timer timer1;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel4;
        internal System.Windows.Forms.ToolStripStatusLabel lblUser;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel6;
        public System.Windows.Forms.ToolStripStatusLabel lblUserType;
        internal System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel9;
        internal System.Windows.Forms.StatusStrip statusStrip2;
        private System.Windows.Forms.ToolStripMenuItem timeoutToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendanceReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cameraSettingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem usersToolStripMenuItem;
    }
}