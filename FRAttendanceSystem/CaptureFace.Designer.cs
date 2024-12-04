namespace FRAttendanceSystem
{
    partial class CaptureFace
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CaptureFace));
            this.imageBoxFrameGrabber = new Emgu.CV.UI.ImageBox();
            this.ddlDOB = new System.Windows.Forms.DateTimePicker();
            this.ddlGender = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.Panel4 = new System.Windows.Forms.Panel();
            this.nationalIpTXT = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.Label7 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.Label5 = new System.Windows.Forms.Label();
            this.Label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtUserID = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.imageBox1 = new Emgu.CV.UI.ImageBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.pth1 = new System.Windows.Forms.Label();
            this.pth5 = new System.Windows.Forms.Label();
            this.pth4 = new System.Windows.Forms.Label();
            this.pth3 = new System.Windows.Forms.Label();
            this.pth2 = new System.Windows.Forms.Label();
            this.toggleCameraSource = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).BeginInit();
            this.Panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // imageBoxFrameGrabber
            // 
            this.imageBoxFrameGrabber.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBoxFrameGrabber.Location = new System.Drawing.Point(13, 125);
            this.imageBoxFrameGrabber.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageBoxFrameGrabber.Name = "imageBoxFrameGrabber";
            this.imageBoxFrameGrabber.Size = new System.Drawing.Size(485, 410);
            this.imageBoxFrameGrabber.TabIndex = 347;
            this.imageBoxFrameGrabber.TabStop = false;
            // 
            // ddlDOB
            // 
            this.ddlDOB.CustomFormat = "dd/MM/yyyy";
            this.ddlDOB.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.ddlDOB.Location = new System.Drawing.Point(186, 254);
            this.ddlDOB.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlDOB.Name = "ddlDOB";
            this.ddlDOB.Size = new System.Drawing.Size(235, 28);
            this.ddlDOB.TabIndex = 29;
            // 
            // ddlGender
            // 
            this.ddlGender.FormattingEnabled = true;
            this.ddlGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.ddlGender.Location = new System.Drawing.Point(186, 208);
            this.ddlGender.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ddlGender.Name = "ddlGender";
            this.ddlGender.Size = new System.Drawing.Size(235, 30);
            this.ddlGender.TabIndex = 28;
            this.ddlGender.SelectedIndexChanged += new System.EventHandler(this.ddlGender_SelectedIndexChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(10, 75);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(117, 27);
            this.label14.TabIndex = 26;
            this.label14.Text = "Full Name :";
            // 
            // txtName
            // 
            this.txtName.BackColor = System.Drawing.Color.White;
            this.txtName.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(188, 65);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(392, 34);
            this.txtName.TabIndex = 27;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // Panel4
            // 
            this.Panel4.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Panel4.Controls.Add(this.nationalIpTXT);
            this.Panel4.Controls.Add(this.label8);
            this.Panel4.Controls.Add(this.txtEmail);
            this.Panel4.Controls.Add(this.label6);
            this.Panel4.Controls.Add(this.ddlDOB);
            this.Panel4.Controls.Add(this.ddlGender);
            this.Panel4.Controls.Add(this.label14);
            this.Panel4.Controls.Add(this.txtName);
            this.Panel4.Controls.Add(this.txtPhone);
            this.Panel4.Controls.Add(this.Label7);
            this.Panel4.Controls.Add(this.txtAddress);
            this.Panel4.Controls.Add(this.btnSubmit);
            this.Panel4.Controls.Add(this.Label5);
            this.Panel4.Controls.Add(this.Label4);
            this.Panel4.Controls.Add(this.label3);
            this.Panel4.Controls.Add(this.label9);
            this.Panel4.Controls.Add(this.txtUserID);
            this.Panel4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panel4.Location = new System.Drawing.Point(826, 125);
            this.Panel4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Panel4.Name = "Panel4";
            this.Panel4.Size = new System.Drawing.Size(597, 517);
            this.Panel4.TabIndex = 357;
            // 
            // nationalIpTXT
            // 
            this.nationalIpTXT.BackColor = System.Drawing.Color.White;
            this.nationalIpTXT.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nationalIpTXT.Location = new System.Drawing.Point(186, 394);
            this.nationalIpTXT.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nationalIpTXT.MaxLength = 14;
            this.nationalIpTXT.Name = "nationalIpTXT";
            this.nationalIpTXT.Size = new System.Drawing.Size(394, 34);
            this.nationalIpTXT.TabIndex = 33;
            this.nationalIpTXT.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nationalIpTXT_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(10, 396);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(126, 27);
            this.label8.TabIndex = 32;
            this.label8.Text = "National Id :";
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.White;
            this.txtEmail.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(186, 158);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(235, 34);
            this.txtEmail.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(9, 165);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 27);
            this.label6.TabIndex = 31;
            this.label6.Text = "Email :";
            // 
            // txtPhone
            // 
            this.txtPhone.BackColor = System.Drawing.Color.White;
            this.txtPhone.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhone.Location = new System.Drawing.Point(186, 112);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtPhone.MaxLength = 11;
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(235, 34);
            this.txtPhone.TabIndex = 5;
            // 
            // Label7
            // 
            this.Label7.AutoSize = true;
            this.Label7.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label7.Location = new System.Drawing.Point(9, 117);
            this.Label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label7.Name = "Label7";
            this.Label7.Size = new System.Drawing.Size(79, 27);
            this.Label7.TabIndex = 13;
            this.Label7.Text = "Phone :";
            // 
            // txtAddress
            // 
            this.txtAddress.BackColor = System.Drawing.Color.White;
            this.txtAddress.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddress.Location = new System.Drawing.Point(186, 305);
            this.txtAddress.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtAddress.Multiline = true;
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(394, 75);
            this.txtAddress.TabIndex = 14;
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btnSubmit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSubmit.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSubmit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSubmit.Location = new System.Drawing.Point(186, 445);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(178, 40);
            this.btnSubmit.TabIndex = 7;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // Label5
            // 
            this.Label5.AutoSize = true;
            this.Label5.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label5.Location = new System.Drawing.Point(9, 258);
            this.Label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label5.Name = "Label5";
            this.Label5.Size = new System.Drawing.Size(140, 27);
            this.Label5.TabIndex = 11;
            this.Label5.Text = "Date of birth :";
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.Location = new System.Drawing.Point(9, 211);
            this.Label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(91, 27);
            this.Label4.TabIndex = 6;
            this.Label4.Text = "Gender :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(10, 309);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(98, 27);
            this.label3.TabIndex = 5;
            this.label3.Text = "Address :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(10, 28);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(120, 27);
            this.label9.TabIndex = 0;
            this.label9.Text = "Unique ID :";
            // 
            // txtUserID
            // 
            this.txtUserID.BackColor = System.Drawing.Color.Gainsboro;
            this.txtUserID.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserID.Location = new System.Drawing.Point(188, 17);
            this.txtUserID.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUserID.Name = "txtUserID";
            this.txtUserID.ReadOnly = true;
            this.txtUserID.Size = new System.Drawing.Size(138, 34);
            this.txtUserID.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Crimson;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.button4.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Location = new System.Drawing.Point(533, 563);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(244, 43);
            this.button4.TabIndex = 356;
            this.button4.Text = "Stop";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Indigo;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Location = new System.Drawing.Point(533, 509);
            this.button2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(244, 45);
            this.button2.TabIndex = 346;
            this.button2.Text = "Capture Face";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // imageBox1
            // 
            this.imageBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageBox1.Location = new System.Drawing.Point(16, 29);
            this.imageBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imageBox1.Name = "imageBox1";
            this.imageBox1.Size = new System.Drawing.Size(244, 205);
            this.imageBox1.TabIndex = 5;
            this.imageBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.imageBox1);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(516, 125);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(288, 268);
            this.groupBox1.TabIndex = 348;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Training: ";
            // 
            // Label1
            // 
            this.Label1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(-4, -2);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(1525, 58);
            this.Label1.TabIndex = 344;
            this.Label1.Text = "Capture Face";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(533, 448);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(244, 52);
            this.button1.TabIndex = 345;
            this.button1.Text = "Start and Reoginize Face";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(28, 91);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 24);
            this.label2.TabIndex = 349;
            this.label2.Text = "Name";
            // 
            // pth1
            // 
            this.pth1.AutoSize = true;
            this.pth1.Location = new System.Drawing.Point(28, 560);
            this.pth1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pth1.Name = "pth1";
            this.pth1.Size = new System.Drawing.Size(51, 20);
            this.pth1.TabIndex = 350;
            this.pth1.Text = "Path1";
            this.pth1.Visible = false;
            // 
            // pth5
            // 
            this.pth5.AutoSize = true;
            this.pth5.Location = new System.Drawing.Point(38, 674);
            this.pth5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pth5.Name = "pth5";
            this.pth5.Size = new System.Drawing.Size(51, 20);
            this.pth5.TabIndex = 354;
            this.pth5.Text = "label3";
            this.pth5.Visible = false;
            // 
            // pth4
            // 
            this.pth4.AutoSize = true;
            this.pth4.Location = new System.Drawing.Point(33, 648);
            this.pth4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pth4.Name = "pth4";
            this.pth4.Size = new System.Drawing.Size(51, 20);
            this.pth4.TabIndex = 353;
            this.pth4.Text = "label1";
            this.pth4.Visible = false;
            // 
            // pth3
            // 
            this.pth3.AutoSize = true;
            this.pth3.Location = new System.Drawing.Point(28, 622);
            this.pth3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pth3.Name = "pth3";
            this.pth3.Size = new System.Drawing.Size(51, 20);
            this.pth3.TabIndex = 352;
            this.pth3.Text = "Path3";
            this.pth3.Visible = false;
            // 
            // pth2
            // 
            this.pth2.AutoSize = true;
            this.pth2.Location = new System.Drawing.Point(28, 591);
            this.pth2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.pth2.Name = "pth2";
            this.pth2.Size = new System.Drawing.Size(51, 20);
            this.pth2.TabIndex = 351;
            this.pth2.Text = "Path2";
            this.pth2.Visible = false;
            // 
            // toggleCameraSource
            // 
            this.toggleCameraSource.AutoSize = true;
            this.toggleCameraSource.Location = new System.Drawing.Point(533, 416);
            this.toggleCameraSource.Name = "toggleCameraSource";
            this.toggleCameraSource.Size = new System.Drawing.Size(142, 24);
            this.toggleCameraSource.TabIndex = 358;
            this.toggleCameraSource.Text = "Use Ip Camera";
            this.toggleCameraSource.UseVisualStyleBackColor = true;
            // 
            // CaptureFace
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1480, 723);
            this.Controls.Add(this.toggleCameraSource);
            this.Controls.Add(this.imageBoxFrameGrabber);
            this.Controls.Add(this.Panel4);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pth1);
            this.Controls.Add(this.pth5);
            this.Controls.Add(this.pth4);
            this.Controls.Add(this.pth3);
            this.Controls.Add(this.pth2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CaptureFace";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.CaptureFace_Load);
            ((System.ComponentModel.ISupportInitialize)(this.imageBoxFrameGrabber)).EndInit();
            this.Panel4.ResumeLayout(false);
            this.Panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imageBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Emgu.CV.UI.ImageBox imageBoxFrameGrabber;
        private System.Windows.Forms.DateTimePicker ddlDOB;
        private System.Windows.Forms.ComboBox ddlGender;
        internal System.Windows.Forms.Label label14;
        internal System.Windows.Forms.TextBox txtName;
        internal System.Windows.Forms.Panel Panel4;
        internal System.Windows.Forms.TextBox txtPhone;
        internal System.Windows.Forms.Label Label7;
        internal System.Windows.Forms.TextBox txtAddress;
        internal System.Windows.Forms.Button btnSubmit;
        internal System.Windows.Forms.Label Label5;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Label label9;
        internal System.Windows.Forms.TextBox txtUserID;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private Emgu.CV.UI.ImageBox imageBox1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label pth1;
        private System.Windows.Forms.Label pth5;
        private System.Windows.Forms.Label pth4;
        private System.Windows.Forms.Label pth3;
        private System.Windows.Forms.Label pth2;
        internal System.Windows.Forms.TextBox txtEmail;
        internal System.Windows.Forms.Label label6;
        private System.Windows.Forms.CheckBox toggleCameraSource;
        internal System.Windows.Forms.TextBox nationalIpTXT;
        internal System.Windows.Forms.Label label8;
    }
}