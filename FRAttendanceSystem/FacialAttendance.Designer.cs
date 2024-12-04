﻿namespace FRAttendanceSystem
{
    partial class FacialAttendance
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FacialAttendance));
            this.txtImage = new System.Windows.Forms.TextBox();
            this.txtTimeIN = new System.Windows.Forms.TextBox();
            this.txtParentMobileTwo = new System.Windows.Forms.TextBox();
            this.txtParentMobile = new System.Windows.Forms.TextBox();
            this.txtSchool = new System.Windows.Forms.TextBox();
            this.txtStaffname = new System.Windows.Forms.TextBox();
            this.lblmsg = new System.Windows.Forms.Label();
            this.txtStudentName = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.toggleCameraSource = new System.Windows.Forms.CheckBox();
            this.btnStop = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTimeOUT = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.timeInListBox = new System.Windows.Forms.ListBox();
            this.TotalUsersLBL = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.SuspendLayout();
            // 
            // txtImage
            // 
            this.txtImage.Location = new System.Drawing.Point(860, 686);
            this.txtImage.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtImage.Name = "txtImage";
            this.txtImage.Size = new System.Drawing.Size(224, 26);
            this.txtImage.TabIndex = 64;
            // 
            // txtTimeIN
            // 
            this.txtTimeIN.Location = new System.Drawing.Point(345, 686);
            this.txtTimeIN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimeIN.Name = "txtTimeIN";
            this.txtTimeIN.ReadOnly = true;
            this.txtTimeIN.Size = new System.Drawing.Size(228, 26);
            this.txtTimeIN.TabIndex = 62;
            // 
            // txtParentMobileTwo
            // 
            this.txtParentMobileTwo.Location = new System.Drawing.Point(856, 726);
            this.txtParentMobileTwo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtParentMobileTwo.Name = "txtParentMobileTwo";
            this.txtParentMobileTwo.ReadOnly = true;
            this.txtParentMobileTwo.Size = new System.Drawing.Size(228, 26);
            this.txtParentMobileTwo.TabIndex = 61;
            // 
            // txtParentMobile
            // 
            this.txtParentMobile.Location = new System.Drawing.Point(602, 726);
            this.txtParentMobile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtParentMobile.Name = "txtParentMobile";
            this.txtParentMobile.ReadOnly = true;
            this.txtParentMobile.Size = new System.Drawing.Size(228, 26);
            this.txtParentMobile.TabIndex = 60;
            // 
            // txtSchool
            // 
            this.txtSchool.Location = new System.Drawing.Point(345, 726);
            this.txtSchool.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSchool.Name = "txtSchool";
            this.txtSchool.ReadOnly = true;
            this.txtSchool.Size = new System.Drawing.Size(228, 26);
            this.txtSchool.TabIndex = 59;
            // 
            // txtStaffname
            // 
            this.txtStaffname.Location = new System.Drawing.Point(57, 726);
            this.txtStaffname.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStaffname.Name = "txtStaffname";
            this.txtStaffname.ReadOnly = true;
            this.txtStaffname.Size = new System.Drawing.Size(228, 26);
            this.txtStaffname.TabIndex = 58;
            // 
            // lblmsg
            // 
            this.lblmsg.AutoSize = true;
            this.lblmsg.Location = new System.Drawing.Point(42, 572);
            this.lblmsg.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblmsg.Name = "lblmsg";
            this.lblmsg.Size = new System.Drawing.Size(0, 20);
            this.lblmsg.TabIndex = 57;
            // 
            // txtStudentName
            // 
            this.txtStudentName.Location = new System.Drawing.Point(57, 686);
            this.txtStudentName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtStudentName.Name = "txtStudentName";
            this.txtStudentName.ReadOnly = true;
            this.txtStudentName.Size = new System.Drawing.Size(228, 26);
            this.txtStudentName.TabIndex = 56;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.TotalUsersLBL);
            this.groupBox1.Controls.Add(this.timeInListBox);
            this.groupBox1.Location = new System.Drawing.Point(542, 112);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(276, 410);
            this.groupBox1.TabIndex = 54;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Today Timed In Users : ";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(12, 305);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(164, 58);
            this.button1.TabIndex = 2;
            this.button1.Text = "Start Camera";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.toggleCameraSource);
            this.groupBox2.Controls.Add(this.btnStop);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Location = new System.Drawing.Point(826, 112);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox2.Size = new System.Drawing.Size(314, 372);
            this.groupBox2.TabIndex = 55;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Results: ";
            // 
            // toggleCameraSource
            // 
            this.toggleCameraSource.AutoSize = true;
            this.toggleCameraSource.Location = new System.Drawing.Point(19, 258);
            this.toggleCameraSource.Name = "toggleCameraSource";
            this.toggleCameraSource.Size = new System.Drawing.Size(142, 24);
            this.toggleCameraSource.TabIndex = 19;
            this.toggleCameraSource.Text = "Use Ip Camera";
            this.toggleCameraSource.UseVisualStyleBackColor = true;
            this.toggleCameraSource.CheckedChanged += new System.EventHandler(this.toggleCameraSource_CheckedChanged);
            // 
            // btnStop
            // 
            this.btnStop.BackColor = System.Drawing.Color.Crimson;
            this.btnStop.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStop.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.btnStop.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnStop.Location = new System.Drawing.Point(188, 305);
            this.btnStop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(104, 58);
            this.btnStop.TabIndex = 18;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = false;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(14, 35);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(277, 22);
            this.label5.TabIndex = 17;
            this.label5.Text = "Persons present in the scene:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Blue;
            this.label4.Location = new System.Drawing.Point(14, 82);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 26);
            this.label4.TabIndex = 16;
            this.label4.Text = "Nobody";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(244, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(24, 25);
            this.label3.TabIndex = 15;
            this.label3.Text = "0";
            this.label3.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(15, 142);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(251, 22);
            this.label2.TabIndex = 14;
            this.label2.Text = "Number of faces detected: ";
            this.label2.Visible = false;
            // 
            // txtTimeOUT
            // 
            this.txtTimeOUT.Location = new System.Drawing.Point(602, 686);
            this.txtTimeOUT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTimeOUT.Name = "txtTimeOUT";
            this.txtTimeOUT.ReadOnly = true;
            this.txtTimeOUT.Size = new System.Drawing.Size(228, 26);
            this.txtTimeOUT.TabIndex = 63;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(-6, 0);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(1210, 58);
            this.Label1.TabIndex = 345;
            this.Label1.Text = "Facial Recognition Attendance";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(46, 112);
            this.imageBoxFrameGrabber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(485, 410);
            this.imageBoxFrameGrabber.TabIndex = 53;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(46, 532);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(180, 28);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Visible = false;
            // 
            // timeInListBox
            // 
            this.timeInListBox.FormattingEnabled = true;
            this.timeInListBox.ItemHeight = 20;
            this.timeInListBox.Location = new System.Drawing.Point(7, 32);
            this.timeInListBox.Name = "timeInListBox";
            this.timeInListBox.Size = new System.Drawing.Size(262, 324);
            this.timeInListBox.TabIndex = 7;
            // 
            // TotalUsersLBL
            // 
            this.TotalUsersLBL.AutoSize = true;
            this.TotalUsersLBL.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalUsersLBL.ForeColor = System.Drawing.Color.Black;
            this.TotalUsersLBL.Location = new System.Drawing.Point(53, 371);
            this.TotalUsersLBL.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TotalUsersLBL.Name = "TotalUsersLBL";
            this.TotalUsersLBL.Size = new System.Drawing.Size(126, 22);
            this.TotalUsersLBL.TabIndex = 20;
            this.TotalUsersLBL.Text = "Total Users :";
            // 
            // FacialAttendance
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1197, 583);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.txtImage);
            this.Controls.Add(this.txtTimeIN);
            this.Controls.Add(this.txtParentMobileTwo);
            this.Controls.Add(this.txtParentMobile);
            this.Controls.Add(this.txtSchool);
            this.Controls.Add(this.txtStaffname);
            this.Controls.Add(this.lblmsg);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Controls.Add(this.txtStudentName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtTimeOUT);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "FacialAttendance";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Time-In";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtImage;
        public System.Windows.Forms.TextBox txtTimeIN;
        public System.Windows.Forms.TextBox txtParentMobileTwo;
        public System.Windows.Forms.TextBox txtParentMobile;
        public System.Windows.Forms.TextBox txtSchool;
        public System.Windows.Forms.TextBox txtStaffname;
        private System.Windows.Forms.Label lblmsg;
        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        public System.Windows.Forms.TextBox txtStudentName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.TextBox txtTimeOUT;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.CheckBox toggleCameraSource;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ListBox timeInListBox;
        private System.Windows.Forms.Label TotalUsersLBL;
    }
}