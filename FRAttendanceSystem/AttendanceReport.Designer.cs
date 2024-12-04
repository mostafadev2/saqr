namespace FRAttendanceSystem
{
    partial class AttendanceReport
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
            this.Label1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNumCount = new System.Windows.Forms.Label();
            this.lblExpectAtten = new System.Windows.Forms.Label();
            this.txtExpectedAtten = new System.Windows.Forms.Label();
            this.lblPercentage = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnReset = new System.Windows.Forms.Button();
            this.dataGridViewEmployee = new System.Windows.Forms.DataGridView();
            this.GroupBox3 = new System.Windows.Forms.GroupBox();
            this.btnView = new System.Windows.Forms.Button();
            this.dtpDateTo = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dtpDateFrom = new System.Windows.Forms.DateTimePicker();
            this.GroupBox2 = new System.Windows.Forms.GroupBox();
            this.printBTN = new System.Windows.Forms.Button();
            this.totalHoursLBL = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).BeginInit();
            this.GroupBox3.SuspendLayout();
            this.GroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(-2, -5);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(1340, 58);
            this.Label1.TabIndex = 359;
            this.Label1.Text = "Attendance Report";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(87, 57);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(289, 32);
            this.txtName.TabIndex = 0;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 142);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 24);
            this.label5.TabIndex = 7;
            this.label5.Text = "Attendance Percentage:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 34);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(211, 24);
            this.label3.TabIndex = 6;
            this.label3.Text = "Total No of Attendance:";
            // 
            // lblNumCount
            // 
            this.lblNumCount.AutoSize = true;
            this.lblNumCount.Location = new System.Drawing.Point(250, 34);
            this.lblNumCount.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNumCount.Name = "lblNumCount";
            this.lblNumCount.Size = new System.Drawing.Size(0, 24);
            this.lblNumCount.TabIndex = 2;
            // 
            // lblExpectAtten
            // 
            this.lblExpectAtten.AutoSize = true;
            this.lblExpectAtten.Location = new System.Drawing.Point(250, 88);
            this.lblExpectAtten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExpectAtten.Name = "lblExpectAtten";
            this.lblExpectAtten.Size = new System.Drawing.Size(0, 24);
            this.lblExpectAtten.TabIndex = 5;
            // 
            // txtExpectedAtten
            // 
            this.txtExpectedAtten.AutoSize = true;
            this.txtExpectedAtten.Location = new System.Drawing.Point(33, 88);
            this.txtExpectedAtten.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtExpectedAtten.Name = "txtExpectedAtten";
            this.txtExpectedAtten.Size = new System.Drawing.Size(190, 24);
            this.txtExpectedAtten.TabIndex = 3;
            this.txtExpectedAtten.Text = "Expected Attendance:";
            // 
            // lblPercentage
            // 
            this.lblPercentage.AutoSize = true;
            this.lblPercentage.Font = new System.Drawing.Font("Palatino Linotype", 11F, System.Drawing.FontStyle.Bold);
            this.lblPercentage.ForeColor = System.Drawing.Color.Green;
            this.lblPercentage.Location = new System.Drawing.Point(250, 142);
            this.lblPercentage.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPercentage.Name = "lblPercentage";
            this.lblPercentage.Size = new System.Drawing.Size(0, 29);
            this.lblPercentage.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNumCount);
            this.panel1.Controls.Add(this.lblExpectAtten);
            this.panel1.Controls.Add(this.txtExpectedAtten);
            this.panel1.Controls.Add(this.lblPercentage);
            this.panel1.Location = new System.Drawing.Point(32, 118);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(344, 202);
            this.panel1.TabIndex = 342;
            this.panel1.Visible = false;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(152, 48);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(123, 42);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.panel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold);
            this.groupBox1.Location = new System.Drawing.Point(863, 231);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupBox1.Size = new System.Drawing.Size(395, 355);
            this.groupBox1.TabIndex = 363;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "View Attendance Percentage";
            this.groupBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 62);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 24);
            this.label2.TabIndex = 1;
            this.label2.Text = "Name:";
            // 
            // btnReset
            // 
            this.btnReset.BackColor = System.Drawing.Color.Indigo;
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReset.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReset.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnReset.Location = new System.Drawing.Point(15, 48);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(123, 42);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "&Reset";
            this.btnReset.UseVisualStyleBackColor = false;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // dataGridViewEmployee
            // 
            this.dataGridViewEmployee.AllowUserToAddRows = false;
            this.dataGridViewEmployee.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.DisplayedCells;
            this.dataGridViewEmployee.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridViewEmployee.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewEmployee.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridViewEmployee.ColumnHeadersHeight = 25;
            this.dataGridViewEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridViewEmployee.Location = new System.Drawing.Point(16, 231);
            this.dataGridViewEmployee.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dataGridViewEmployee.Name = "dataGridViewEmployee";
            this.dataGridViewEmployee.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridViewEmployee.RowHeadersWidth = 25;
            this.dataGridViewEmployee.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridViewEmployee.Size = new System.Drawing.Size(839, 424);
            this.dataGridViewEmployee.TabIndex = 360;
            // 
            // GroupBox3
            // 
            this.GroupBox3.Controls.Add(this.printBTN);
            this.GroupBox3.Controls.Add(this.btnClose);
            this.GroupBox3.Controls.Add(this.btnReset);
            this.GroupBox3.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox3.Location = new System.Drawing.Point(532, 78);
            this.GroupBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox3.Name = "GroupBox3";
            this.GroupBox3.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox3.Size = new System.Drawing.Size(443, 125);
            this.GroupBox3.TabIndex = 362;
            this.GroupBox3.TabStop = false;
            // 
            // btnView
            // 
            this.btnView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btnView.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnView.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnView.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnView.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnView.Location = new System.Drawing.Point(352, 58);
            this.btnView.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(129, 40);
            this.btnView.TabIndex = 3;
            this.btnView.Text = "View Report";
            this.btnView.UseVisualStyleBackColor = false;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // dtpDateTo
            // 
            this.dtpDateTo.CustomFormat = "dd/MM/yyyy";
            this.dtpDateTo.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateTo.Location = new System.Drawing.Point(183, 60);
            this.dtpDateTo.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateTo.Name = "dtpDateTo";
            this.dtpDateTo.Size = new System.Drawing.Size(148, 32);
            this.dtpDateTo.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(178, 31);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 24);
            this.label4.TabIndex = 13;
            this.label4.Text = "To :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 31);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 24);
            this.label6.TabIndex = 12;
            this.label6.Text = "From :";
            // 
            // dtpDateFrom
            // 
            this.dtpDateFrom.CustomFormat = "dd/MM/yyyy";
            this.dtpDateFrom.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpDateFrom.Location = new System.Drawing.Point(18, 60);
            this.dtpDateFrom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dtpDateFrom.Name = "dtpDateFrom";
            this.dtpDateFrom.Size = new System.Drawing.Size(145, 32);
            this.dtpDateFrom.TabIndex = 1;
            // 
            // GroupBox2
            // 
            this.GroupBox2.Controls.Add(this.btnView);
            this.GroupBox2.Controls.Add(this.dtpDateTo);
            this.GroupBox2.Controls.Add(this.label4);
            this.GroupBox2.Controls.Add(this.label6);
            this.GroupBox2.Controls.Add(this.dtpDateFrom);
            this.GroupBox2.Font = new System.Drawing.Font("Palatino Linotype", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GroupBox2.Location = new System.Drawing.Point(16, 78);
            this.GroupBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Name = "GroupBox2";
            this.GroupBox2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.GroupBox2.Size = new System.Drawing.Size(507, 125);
            this.GroupBox2.TabIndex = 361;
            this.GroupBox2.TabStop = false;
            this.GroupBox2.Text = "Search Attendance by Date Range";
            // 
            // printBTN
            // 
            this.printBTN.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.printBTN.BackColor = System.Drawing.Color.Blue;
            this.printBTN.Cursor = System.Windows.Forms.Cursors.Hand;
            this.printBTN.Enabled = false;
            this.printBTN.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.printBTN.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.printBTN.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.printBTN.Location = new System.Drawing.Point(295, 48);
            this.printBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.printBTN.Name = "printBTN";
            this.printBTN.Size = new System.Drawing.Size(112, 44);
            this.printBTN.TabIndex = 376;
            this.printBTN.Text = "Print";
            this.printBTN.UseVisualStyleBackColor = false;
            this.printBTN.Click += new System.EventHandler(this.printBTN_Click);
            // 
            // totalHoursLBL
            // 
            this.totalHoursLBL.AutoSize = true;
            this.totalHoursLBL.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHoursLBL.Location = new System.Drawing.Point(873, 600);
            this.totalHoursLBL.Name = "totalHoursLBL";
            this.totalHoursLBL.Size = new System.Drawing.Size(94, 32);
            this.totalHoursLBL.TabIndex = 376;
            this.totalHoursLBL.Text = "Hours :";
            // 
            // AttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1292, 669);
            this.Controls.Add(this.totalHoursLBL);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridViewEmployee);
            this.Controls.Add(this.GroupBox3);
            this.Controls.Add(this.GroupBox2);
            this.Controls.Add(this.Label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AttendanceReport";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facial Recognition Attendance System";
            this.Load += new System.EventHandler(this.AttendanceReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewEmployee)).EndInit();
            this.GroupBox3.ResumeLayout(false);
            this.GroupBox2.ResumeLayout(false);
            this.GroupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblNumCount;
        private System.Windows.Forms.Label lblExpectAtten;
        private System.Windows.Forms.Label txtExpectedAtten;
        private System.Windows.Forms.Label lblPercentage;
        private System.Windows.Forms.Panel panel1;
        internal System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        internal System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.DataGridView dataGridViewEmployee;
        internal System.Windows.Forms.GroupBox GroupBox3;
        internal System.Windows.Forms.Button btnView;
        internal System.Windows.Forms.DateTimePicker dtpDateTo;
        internal System.Windows.Forms.Label label4;
        internal System.Windows.Forms.Label label6;
        internal System.Windows.Forms.DateTimePicker dtpDateFrom;
        internal System.Windows.Forms.GroupBox GroupBox2;
        internal System.Windows.Forms.Button printBTN;
        private System.Windows.Forms.Label totalHoursLBL;
    }
}