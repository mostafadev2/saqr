using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FRAttendanceSystem.Users
{
    public partial class UserAttendanceReport : Form
    {
        private readonly string uniqueId;
        private readonly string userName;
        private PrintDocument printDocument = new PrintDocument();
        public UserAttendanceReport(string uniqueId, string userName)
        {
            this.uniqueId = uniqueId;
            this.userName = userName;
            InitializeComponent();
            search();
            GetTotalours();
            printDocument.PrintPage += Print;
            this.Text += $" ({userName})";
            Label1.Text = this.Text;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search();
            GetTotalours();
        }
        public void search()
        {
            dataGridView1.Rows.Clear();
            var fromDate = dateFrom.Value.ToString("MM/dd/yyyy");
            var toDate = dateTo.Value.ToString("MM/dd/yyyy");
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand(
                    $@"SELECT sDate AS 'Date', 
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
             END AS TimeDifferenceInHours
             FROM Attendance 
             WHERE UniqueID ='{uniqueId}' and CONVERT(DATE, sDate, 101) BETWEEN @DateFrom AND @DateTo", con);

            // Use parameters to avoid SQL injection
            cmd.Parameters.AddWithValue("@DateFrom", fromDate);
            cmd.Parameters.AddWithValue("@DateTo", toDate);
            try
            {
                con.Open();
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.AutoGenerateColumns = false;
                if (dt != null && dt.Rows.Count > 0)
                {
                    for (int row = 0; row < dt.Rows.Count; row++)
                    {
                        dataGridView1.Rows.Add();
                        for (int col = 0; col < dt.Columns.Count; col++)
                        {
                            dataGridView1.Rows[row].Cells[col].Value = dt.Rows[row][col];
                        }
                    }
                }
                con.Close();
                if (dataGridView1.Rows.Count > 1)
                {
                    printBTN.Enabled = true;
                }
                else
                {
                    printBTN.Enabled = false;
                }
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
            int totalHours = 0,totalMinutes=0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Ensure the row is not a new row and the value is not null or DBNull
                if (!row.IsNewRow && row.Cells["WorkedHours"].Value != null && row.Cells["WorkedHours"].Value != DBNull.Value)
                {
                    // Try to parse the value to a number
                    var values = row.Cells["WorkedHours"].Value.ToString().Split(',');
                    int hours = Convert.ToInt32(values[0].Replace(" hours",""));
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
            foreach (DataGridViewColumn column in dataGridView1.Columns)
            {
                string headerText = column.HeaderText;
                e.Graphics.FillRectangle(Brushes.LightGray, new Rectangle(currentX, topMargin, column.Width, rowHeight));
                e.Graphics.DrawString(headerText, boldFont, Brushes.Black, currentX + cellPadding, topMargin + cellPadding);
                currentX += column.Width;
            }

            topMargin += rowHeight; // Move to the next row

            // Draw the data rows
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (!row.IsNewRow) // Skip the new row
                {
                    currentX = leftMargin; // Reset horizontal position

                    // Draw each cell in the row
                    foreach (DataGridViewCell cell in row.Cells)
                    {
                        string cellValue = cell.Value?.ToString() ?? string.Empty;
                        e.Graphics.FillRectangle(Brushes.White, new Rectangle(currentX, topMargin, cell.OwningColumn.Width, rowHeight));
                        e.Graphics.DrawRectangle(Pens.Black, new Rectangle(currentX, topMargin, cell.OwningColumn.Width, rowHeight));
                        e.Graphics.DrawString(cellValue, font, Brushes.Black, currentX + cellPadding, topMargin + cellPadding);
                        currentX += cell.OwningColumn.Width; // Move to the next column
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
        private void btnClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
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
