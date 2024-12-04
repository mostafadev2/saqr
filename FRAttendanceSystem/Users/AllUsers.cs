using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace FRAttendanceSystem.Users
{
    public partial class AllUsers : Form
    {
        private readonly string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\FRAttendance.mdf;Integrated Security=True";
        public AllUsers()
        {
            InitializeComponent();
            dataGridView1.Rows.Clear();
            dataGridView1.AllowUserToAddRows = false;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            Search();
        }

        private void txtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar) && e.KeyChar != '+')
            {
                e.Handled = true; // Prevent the character from being entered
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Ensure the click is not on the header row or out of bounds
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "EditButton")
            {
                // Perform edit action
                string name = dataGridView1.Rows[e.RowIndex].Cells["NameColumn"].Value.ToString();
                MessageBox.Show($"Edit action for: {name}");
                // Add code here to open an edit form or enable inline editing
            }
            // Check if the Delete button was clicked
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "DeleteBtn")
            {
                // Confirm deletion
                var confirmResult = MessageBox.Show("Are you sure to delete this user?",
                                                     "Confirm Delete",
                                                     MessageBoxButtons.YesNo);
                if (confirmResult == DialogResult.Yes)
                {
                    var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                    var userName = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                    DeleteUser(id, userName);
                    // Perform delete action
                    dataGridView1.Rows.RemoveAt(e.RowIndex);
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "UpdateBTN")
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                UpdateUser updateUser = new UpdateUser(id);
                updateUser.Show();
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "RTP")
            {
                var id = dataGridView1.Rows[e.RowIndex].Cells[0].Value?.ToString();
                var userName = dataGridView1.Rows[e.RowIndex].Cells[1].Value?.ToString();
                UserAttendanceReport rtp = new UserAttendanceReport(id, userName);
                rtp.Show();
            }
        }

        private void DeleteUser(string id, string userName)
        {
            string query = $"DELETE FROM Staff WHERE UniqueID = {id}";
            try
            {
                // Create connection
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    // Create command
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        // Open connection
                        connection.Open();

                        // Execute DELETE command
                        int rowsAffected = command.ExecuteNonQuery();

                        // Check if the record was deleted
                        if (rowsAffected > 0)
                        {
                            var imagePath = $"{AppDomain.CurrentDomain.BaseDirectory}{userName}.jpg";
                            if (File.Exists(imagePath))
                            {
                                // Delete the file
                                File.Delete(imagePath);
                            }
                            else
                            {
                                Console.WriteLine($"Image with name {userName} not found.");
                            }

                            ModifyFile(userName);
                            MessageBox.Show("Record deleted successfully.");
                        }
                        else
                        {
                            MessageBox.Show("No record found with the specified ID.");
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle errors (e.g., database connection issues)
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        public static void ModifyFile(string userName)
        {
            string filePath = $"{Application.StartupPath}/TrainedFaces/TrainedLabels.txt";
            try
            {
                // Read the content of the file
                string fileContent = File.ReadAllText(filePath);

                // Check if the file content is valid and follows the expected structure
                if (!string.IsNullOrEmpty(fileContent))
                {
                    // Split the content by '%'
                    string[] parts = fileContent.Split('%');

                    // The first part is the count of names
                    int nameCount = int.Parse(parts[0]);

                    // Extract the list of names
                    var names = parts.Skip(1).Take(nameCount).ToList(); // Skip the count part and take only the names

                    if (names.Count > 0)
                    {
                        var indexOfUser = names.IndexOf(userName);
                        // Remove the first name (or you could remove a specific name)
                        names.RemoveAt(indexOfUser); // Remove one name (you can change the logic here to remove a specific name)

                        // Update the count (decrease it by 1)
                        nameCount--;

                        // Reconstruct the content
                        string updatedContent = nameCount + "%" + string.Join("%", names) + "%";

                        // Write the modified content back to the file
                        File.WriteAllText(filePath, updatedContent);
                    }
                    else
                    {
                        Console.WriteLine("No names left to remove.");
                    }
                }
                else
                {
                    Console.WriteLine("File is empty.");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occurred: " + ex.Message);
            }
        }

        private void AllUsers_Load(object sender, EventArgs e)
        {
            Search();
        }

        private void Search()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                try
                {
                    // Open the connection
                    connection.Open();
                    string query = "SELECT TOP(100) UniqueID , Name as UserName , Phone , Email , Gender , DOB , Address FROM Staff";
                    if (!string.IsNullOrEmpty(txtUserName.Text))
                    {
                        query += $" where Name like N'%{txtUserName.Text}%'";
                    }
                    if (!string.IsNullOrEmpty(txtPhone.Text))
                    {
                        query += query.Contains("where") ? $" and Phone = '{txtPhone.Text}'" : $" where Phone = '{txtPhone.Text}'";
                    }
                    DataTable dataTable = new DataTable();
                    // Create the command
                    using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
                    {
                        // Fill the DataTable with the query results
                        adapter.Fill(dataTable);
                    }
                    dataGridView1.Rows.Clear();
                    dataGridView1.AutoGenerateColumns = false;
                    if (dataTable != null && dataTable.Rows.Count > 0)
                    {
                        for (int row = 0; row < dataTable.Rows.Count; row++)
                        {
                            dataGridView1.Rows.Add();
                            for (int col = 0; col < dataTable.Columns.Count; col++)
                            {
                                dataGridView1.Rows[row].Cells[col].Value = dataTable.Rows[row][col];
                            }
                        }
                    }
                    connection.Close();
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred: " + ex.Message);
                }
            }
        }
    }
}
