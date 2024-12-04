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
using System.Drawing.Printing;

namespace FRAttendanceSystem
{
    public partial class AttendanceReport : Form
    {
        private PrintDocument printDocument = new PrintDocument();
        SqlDataReader rdr = null;
        DataTable dtable = new DataTable();
        //SqlConnection con = null;
        SqlCommand cmd = null;
        DataTable dt = new DataTable();
        SqlConnection cn = null;

        public AttendanceReport()
        {
            InitializeComponent();
            printDocument.PrintPage += Print;
            gridView();
            groupBox1.Visible = true;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            gridView();
            groupBox1.Visible = true;
        }

        #region fill to Datagrid view
        public void gridView()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(
                    @"SELECT Id, Name, UniqueID AS 'Unique ID', 
                    sDate AS 'Date', Day, 
                    TimeIn AS 'Time In', TimeOut AS 'Time Out' ,
                    CASE 
                        WHEN TimeIn IS NOT NULL AND TimeOut IS NOT NULL THEN
                            CONCAT(
                            DATEDIFF(MINUTE, 
                            CAST(LEFT(TimeIn, 5) AS TIME),
                            TRY_CAST(
                            CAST(LEFT(TimeOut, 5) AS TIME)
                            AS TIME
                    )
                    ) / 60, ' hours, ',
                    DATEDIFF(MINUTE, 
                    CAST(LEFT(TimeIn, 5) AS TIME),
                    TRY_CAST(
                    CAST(LEFT(TimeOut, 5) AS TIME)
                    AS TIME
                    )
                    ) % 60, ' minutes'
                    ) 
                    ELSE NULL
             END AS 'Working hours'
                    FROM Attendance 
                    WHERE CONVERT(DATE, sDate, 101) BETWEEN @DateFrom AND @DateTo", con);

            // Use parameters to avoid SQL injection
            cmd.Parameters.AddWithValue("@DateFrom", dtpDateFrom.Value.ToString("MM/dd/yyyy"));
            cmd.Parameters.AddWithValue("@DateTo", dtpDateTo.Value.ToString("MM/dd/yyyy"));
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                BindingSource bs = new BindingSource();
                bs.DataSource = dt;
                dataGridViewEmployee.DataSource = dt;
                da.Update(dt);
                con.Close();
                if (dataGridViewEmployee.Rows.Count > 0)
                {
                    printBTN.Enabled = true;
                }
                else
                {
                    printBTN.Enabled = false;
                }
                GetTotalours();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void GetTotalours()
        {
            // Assuming your DataGridView is named dataGridView1
            // Replace "YourColumnName" with the actual name or index of the column you want to sum
            int totalHours = 0, totalMinutes = 0;

            foreach (DataGridViewRow row in dataGridViewEmployee.Rows)
            {
                // Ensure the row is not a new row and the value is not null or DBNull
                if (!row.IsNewRow && row.Cells[7].Value != null && row.Cells[7].Value != DBNull.Value)
                {
                    // Try to parse the value to a number
                    var values = row.Cells[7].Value.ToString().Split(',');
                    int hours = Convert.ToInt32(values[0].Replace(" hours", ""));
                    int minutes = Convert.ToInt32(values[1].Replace(" minutes", ""));
                    totalHours += hours;
                    totalMinutes += minutes;
                }
            }

            // Display or use the total sum
            totalHoursLBL.Text = $"Hours : {totalHours}:{totalMinutes}";
        }
        #region print
        private void Print(object sender, PrintPageEventArgs e)
        {
            int currentPage = 1;
            int leftMargin = e.MarginBounds.Left;
            int topMargin = e.MarginBounds.Top;
            int pageWidth = e.PageBounds.Width; // Total width of the page

            // Font and other settings
            Font font = new Font("Arial", 10);
            Font titleFont = new Font("Arial", 14, FontStyle.Bold); // Title font
            Font footerFont = new Font("Arial", 14, FontStyle.Bold); // Footer font
            Font boldFont = new Font("Arial", 10, FontStyle.Bold);
            int rowHeight = 30; // Row height
            int cellPadding = 5; // Padding between cells

            string title = this.Text; // Set your title here
            SizeF titleSize = e.Graphics.MeasureString(title, titleFont); // Measure the title width
            float titleX = (pageWidth - titleSize.Width) / 2; // Center the title

            e.Graphics.DrawString(title, titleFont, Brushes.Black, titleX, topMargin);
            topMargin += 40; // Adjust to leave space for the title

            // Draw the header row
            int currentX = leftMargin;
            foreach (DataGridViewColumn column in dataGridViewEmployee.Columns)
            {
                if (column.Index == 0) continue;
                string headerText = column.HeaderText;
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(currentX, topMargin, column.Index == 7 ? column.Width + 30 : column.Width + 20, rowHeight));
                e.Graphics.DrawString(headerText, boldFont, Brushes.Black, currentX + cellPadding, topMargin + cellPadding);
                currentX += column.Index == 7 ? column.Width + 30 : column.Width + 20;
            }

            topMargin += rowHeight; // Move to the next row

            // Draw the data rows
            foreach (DataGridViewRow row in dataGridViewEmployee.Rows)
            {
                if (!row.IsNewRow) // Skip the new row
                {
                    currentX = leftMargin; // Reset horizontal position

                    // Draw each cell in the row
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        if (cell.ColumnIndex == 0) continue;
                        string cellValue = cell.Value?.ToString() ?? string.Empty;
                        e.Graphics.FillRectangle(Brushes.White, new Rectangle(currentX, topMargin, cell.ColumnIndex==7? cell.OwningColumn.Width + 30 : cell.OwningColumn.Width + 20, rowHeight));
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(currentX, topMargin, cell.ColumnIndex == 7 ? cell.OwningColumn.Width + 30 : cell.OwningColumn.Width + 20, rowHeight));
                        e.Graphics.DrawString(cellValue, font, Brushes.Black, currentX + cellPadding, topMargin + cellPadding);
                        currentX += cell.ColumnIndex == 7 ? cell.OwningColumn.Width + 30 : cell.OwningColumn.Width + 20; // Move to the next column
                    }

                    topMargin += rowHeight; // Move to the next row
                                            // Check if we need more pages
                    if (topMargin + rowHeight > e.MarginBounds.Bottom - 50) // Leave space for footer
                    {
                        e.HasMorePages = true;
                        currentPage++;
                        return;
                    }
                }
            }

            // Footer content
            string footer = totalHoursLBL.Text;
            SizeF footerSize = e.Graphics.MeasureString(footer, footerFont);
            float footerX = (pageWidth - footerSize.Width) / 2; // Center the footer
            float footerY = e.MarginBounds.Bottom + 20; // Position below content
            e.Graphics.DrawString(footer, footerFont, Brushes.Gray, footerX, footerY);
            // Check if we need more pages (if content exceeds one page)
            // Reset for the next page
            e.HasMorePages = false;
        }
        #endregion
        #endregion

        #region AutoComplete
        private void Autocomplete()
        {
            try
            {
                cn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True");
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT Name FROM Attendance", cn);
                DataSet ds = new DataSet();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(ds, "registration");
                AutoCompleteStringCollection col = new AutoCompleteStringCollection();
                int i = 0;
                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    col.Add(ds.Tables[0].Rows[i]["Name"].ToString());

                }
                txtName.AutoCompleteSource = AutoCompleteSource.CustomSource;
                txtName.AutoCompleteCustomSource = col;
                txtName.AutoCompleteMode = AutoCompleteMode.Suggest;

                cn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Facial Recognition Attendance System ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Calculate Attendance
        public void CalculateAttendance()
        {
            try
            {

                string constring = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True";
                using (SqlConnection cnn = new SqlConnection(constring))
                {
                    using (SqlCommand comd = new SqlCommand("SELECT COUNT(*) as Count FROM Attendance where sDate BETWEEN '" + dtpDateFrom.Text + "' AND '" + dtpDateTo.Text + "'", cnn))
                    {
                        comd.CommandType = CommandType.Text;
                        cnn.Open();
                        object o = comd.ExecuteScalar();
                        if (o != null)
                        {
                            lblNumCount.Text = o.ToString();
                            lblPercentage.Text = (float.Parse(lblNumCount.Text) / float.Parse(lblExpectAtten.Text) * 100).ToString() + "%";
                            panel1.Visible = true;

                        }
                        cnn.Close();

                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            CalculateAttendance();
        }

        private void AttendanceReport_Load(object sender, EventArgs e)
        {
            Autocomplete();

            lblExpectAtten.Text = "20";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            dtpDateFrom.Text = DateTime.Today.ToString();
            dtpDateTo.Text = DateTime.Today.ToString();
            dataGridViewEmployee.DataSource = "";
            lblNumCount.Text = "";
            lblPercentage.Text = "";
            txtName.Text = "";
            panel1.Visible = false;
            groupBox1.Visible = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void printBTN_Click(object sender, EventArgs e)
        {
            PrintDialog printDialog = new PrintDialog
            {
                Document = printDocument
            };

            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                printDocument.Print();
            }
        }
    }
}
