namespace FRAttendanceSystem.Users
{
    partial class UserAttendanceReport
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.DOB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Address = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TimeOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.WorkedHours = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.printBTN = new System.Windows.Forms.Button();
            this.dateTo = new System.Windows.Forms.DateTimePicker();
            this.dateFrom = new System.Windows.Forms.DateTimePicker();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Label1 = new System.Windows.Forms.Label();
            this.totalHoursLBL = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DOB,
            this.Address,
            this.TimeOut,
            this.WorkedHours});
            this.dataGridView1.Location = new System.Drawing.Point(123, 164);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(994, 446);
            this.dataGridView1.TabIndex = 367;
            // 
            // DOB
            // 
            this.DOB.HeaderText = "Date";
            this.DOB.MinimumWidth = 8;
            this.DOB.Name = "DOB";
            this.DOB.ReadOnly = true;
            this.DOB.Width = 150;
            // 
            // Address
            // 
            this.Address.HeaderText = "Time In";
            this.Address.MinimumWidth = 8;
            this.Address.Name = "Address";
            this.Address.ReadOnly = true;
            this.Address.Width = 150;
            // 
            // TimeOut
            // 
            this.TimeOut.HeaderText = "Time Out";
            this.TimeOut.MinimumWidth = 8;
            this.TimeOut.Name = "TimeOut";
            this.TimeOut.ReadOnly = true;
            this.TimeOut.Width = 150;
            // 
            // WorkedHours
            // 
            this.WorkedHours.HeaderText = "Worked Hours";
            this.WorkedHours.MinimumWidth = 8;
            this.WorkedHours.Name = "WorkedHours";
            this.WorkedHours.ReadOnly = true;
            this.WorkedHours.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.printBTN);
            this.groupBox1.Controls.Add(this.dateTo);
            this.groupBox1.Controls.Add(this.dateFrom);
            this.groupBox1.Controls.Add(this.btnClose);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(19, 68);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1235, 90);
            this.groupBox1.TabIndex = 369;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search";
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
            this.printBTN.Location = new System.Drawing.Point(1034, 32);
            this.printBTN.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.printBTN.Name = "printBTN";
            this.printBTN.Size = new System.Drawing.Size(92, 40);
            this.printBTN.TabIndex = 375;
            this.printBTN.Text = "Print";
            this.printBTN.UseVisualStyleBackColor = false;
            this.printBTN.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTo
            // 
            this.dateTo.Location = new System.Drawing.Point(601, 34);
            this.dateTo.Name = "dateTo";
            this.dateTo.Size = new System.Drawing.Size(304, 26);
            this.dateTo.TabIndex = 374;
            // 
            // dateFrom
            // 
            this.dateFrom.Location = new System.Drawing.Point(168, 32);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Size = new System.Drawing.Size(304, 26);
            this.dateFrom.TabIndex = 370;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Crimson;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnClose.Location = new System.Drawing.Point(1142, 30);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(83, 42);
            this.btnClose.TabIndex = 373;
            this.btnClose.Text = "&Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.btnSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnSearch.Font = new System.Drawing.Font("Palatino Linotype", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearch.Location = new System.Drawing.Point(924, 30);
            this.btnSearch.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(92, 40);
            this.btnSearch.TabIndex = 372;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(482, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 32);
            this.label3.TabIndex = 371;
            this.label3.Text = "To Date :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 32);
            this.label2.TabIndex = 369;
            this.label2.Text = "From Date :";
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(56)))), ((int)(((byte)(79)))));
            this.Label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(0, 0);
            this.Label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(1264, 58);
            this.Label1.TabIndex = 370;
            this.Label1.Text = "User Attendance Report";
            this.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // totalHoursLBL
            // 
            this.totalHoursLBL.AutoSize = true;
            this.totalHoursLBL.Font = new System.Drawing.Font("Palatino Linotype", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHoursLBL.Location = new System.Drawing.Point(958, 627);
            this.totalHoursLBL.Name = "totalHoursLBL";
            this.totalHoursLBL.Size = new System.Drawing.Size(94, 32);
            this.totalHoursLBL.TabIndex = 375;
            this.totalHoursLBL.Text = "Hours :";
            // 
            // UserAttendanceReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 680);
            this.Controls.Add(this.totalHoursLBL);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "UserAttendanceReport";
            this.Text = "User Attendance Report";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DOB;
        private System.Windows.Forms.DataGridViewTextBoxColumn Address;
        private System.Windows.Forms.DataGridViewTextBoxColumn TimeOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn WorkedHours;
        private System.Windows.Forms.GroupBox groupBox1;
        internal System.Windows.Forms.Button btnClose;
        internal System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTo;
        private System.Windows.Forms.DateTimePicker dateFrom;
        private System.Windows.Forms.Label Label1;
        private System.Windows.Forms.Label totalHoursLBL;
        internal System.Windows.Forms.Button printBTN;
    }
}