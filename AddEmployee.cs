using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using System.Data.SqlClient;
using System.IO;

namespace EmployeeManagementSystem
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nipun\Documents\employee2.mdf;Integrated Security=True;Connect Timeout=30");

        public AddEmployee()
        {
            InitializeComponent();

            displayEmployeeData();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployeeData();
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openFileDialog = new OpenFileDialog();
                openFileDialog.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                string imagePath = "";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    imagePath = openFileDialog.FileName;
                    addEmpPictureBox.ImageLocation = imagePath;
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show("Error !" + ex,
                                 "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }
        public void displayEmployeeData()
        {
            EmployeeDate ed = new EmployeeDate();
            List<EmployeeDate> listData = ed.employeeListData();

            dataGridView1.DataSource = listData;
        }
        private void addEmpAddBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addEmpID.Text) ||
                string.IsNullOrEmpty(addEmpName.Text) ||
                string.IsNullOrEmpty(addEmpGender.Text) ||
                string.IsNullOrEmpty(AddEmpPhoneNum.Text) ||
                string.IsNullOrEmpty(addEmpPosition.Text) ||
                string.IsNullOrEmpty(addEmpStatus.Text) ||
                addEmpPictureBox.ImageLocation == null)
            {
                MessageBox.Show("Please fill all the fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (connect.State == ConnectionState.Closed)
                    connect.Open();

                string checkEmID = "SELECT COUNT(*) FROM employee WHERE employee_id = @emID AND delete_date IS NULL";

                using (SqlCommand cmd = new SqlCommand(checkEmID, connect))
                {
                    cmd.Parameters.AddWithValue("@emID", addEmpID.Text.Trim());
                    int count = (int)cmd.ExecuteScalar();

                    if (count >= 1)
                    {
                        MessageBox.Show($"{addEmpID.Text.Trim()} is already taken.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                }

                string path = Path.Combine(@"D:\My_projects\C#-(.NET)\EmployeeManagementSystem\EmployeeManagementSystem\Directory\",
                    $"{addEmpID.Text.Trim()}.jpg");

                string directoryPath = Path.GetDirectoryName(path);

                if (!Directory.Exists(directoryPath))
                {
                    Directory.CreateDirectory(directoryPath);
                }

                File.Copy(addEmpPictureBox.ImageLocation, path, true);

                DateTime today = DateTime.Today;
                string insertData = "INSERT INTO employee (employee_id, full_name, gender, contact_number, position,salary, image, insert_date, status) " +
                                    "VALUES (@employee_id, @fullName, @gender, @contactNum, @position, @salary, @image, @insertDate, @status)";

                using (SqlCommand cmdd = new SqlCommand(insertData, connect))
                {
                    cmdd.Parameters.AddWithValue("@employee_id", addEmpID.Text.Trim());
                    cmdd.Parameters.AddWithValue("@fullName", addEmpName.Text.Trim());
                    cmdd.Parameters.AddWithValue("@gender", addEmpGender.Text.Trim());
                    cmdd.Parameters.AddWithValue("@contactNum", AddEmpPhoneNum.Text.Trim());
                    cmdd.Parameters.AddWithValue("@position", addEmpPosition.Text.Trim());
                    cmdd.Parameters.AddWithValue("@image", path);
                    cmdd.Parameters.AddWithValue("@salary", 0);
                    cmdd.Parameters.AddWithValue("@insertDate", today);
                    cmdd.Parameters.AddWithValue("@status", addEmpStatus.Text.Trim());

                    cmdd.ExecuteNonQuery();
                }

                displayEmployeeData();

                MessageBox.Show("Added Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                clearFileds();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (connect.State == ConnectionState.Open)
                    connect.Close();
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                addEmpID.Text = row.Cells[1].Value.ToString();
                addEmpName.Text = row.Cells[2].Value.ToString();
                addEmpGender.Text = row.Cells[3].Value.ToString();
                AddEmpPhoneNum.Text = row.Cells[4].Value.ToString();
                addEmpPosition.Text = row.Cells[5].Value.ToString();

                string imagePath = row.Cells[6].Value?.ToString();

                if (!string.IsNullOrEmpty(imagePath) && File.Exists(imagePath))
                {
                    try
                    {
                        using (FileStream stream = new FileStream(imagePath, FileMode.Open, FileAccess.Read))
                        {
                            addEmpPictureBox.Image = Image.FromStream(stream);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error loading image: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    addEmpPictureBox.Image = null; // Clear the PictureBox if the image is missing
                }
                addEmpStatus.Text =  row.Cells[8].Value.ToString();
            }
        }

        public void clearFileds()
        {
            addEmpID.Text = "";
            addEmpName.Text = "";
            addEmpGender.SelectedIndex = -1;
            AddEmpPhoneNum.Text = "";
            addEmpPosition.SelectedIndex = -1;
            addEmpStatus.SelectedIndex = -1;
            addEmpPictureBox.Image = null;
        }
        private void addEmpUpdateBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addEmpID.Text) ||
        string.IsNullOrEmpty(addEmpName.Text) ||
        string.IsNullOrEmpty(addEmpGender.Text) ||
        string.IsNullOrEmpty(AddEmpPhoneNum.Text) ||
        string.IsNullOrEmpty(addEmpPosition.Text) ||
        string.IsNullOrEmpty(addEmpStatus.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult check = MessageBox.Show("Are you sure you want to UPDATE " +
                "Employee ID: " + addEmpID.Text.Trim() + "?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (check == DialogResult.Yes)
            {
                try
                {
                    connect.Open();

                    DateTime today = DateTime.Today;
                    string updateData = "UPDATE employee SET full_name = @fullName, gender = @gender, " +
                                        "contact_number = @contactNum, position = @position, " +
                                        "update_date = @updateDate, status = @status, image = @image " +
                                        "WHERE employee_id = @employeeID";

                    string imagePath = addEmpPictureBox.ImageLocation ?? string.Empty;

                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        string path = Path.Combine(@"D:\My_projects\C#-(.NET)\EmployeeManagementSystem\EmployeeManagementSystem\Directory\",
                            $"{addEmpID.Text.Trim()}.jpg");

                        string directoryPath = Path.GetDirectoryName(path);

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        File.Copy(imagePath, path, true);
                        imagePath = path;
                    }

                    using (SqlCommand cmd = new SqlCommand(updateData, connect))
                    {
                        cmd.Parameters.AddWithValue("@fullName", addEmpName.Text.Trim());
                        cmd.Parameters.AddWithValue("@gender", addEmpGender.Text.Trim());
                        cmd.Parameters.AddWithValue("@contactNum", AddEmpPhoneNum.Text.Trim());
                        cmd.Parameters.AddWithValue("@position", addEmpPosition.Text.Trim());
                        cmd.Parameters.AddWithValue("@updateDate", today);
                        cmd.Parameters.AddWithValue("@status", addEmpStatus.Text.Trim());
                        cmd.Parameters.AddWithValue("@image", imagePath);
                        cmd.Parameters.AddWithValue("@employeeID", addEmpID.Text.Trim());

                        cmd.ExecuteNonQuery();

                        displayEmployeeData();

                        MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clearFileds();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                        connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void addEmpClearBtn_Click(object sender, EventArgs e)
        {
            clearFileds();
        }

        private void addEmpDeleteBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(addEmpID.Text) ||
        string.IsNullOrEmpty(addEmpName.Text) ||
        string.IsNullOrEmpty(addEmpGender.Text) ||
        string.IsNullOrEmpty(AddEmpPhoneNum.Text) ||
        string.IsNullOrEmpty(addEmpPosition.Text) ||
        string.IsNullOrEmpty(addEmpStatus.Text))
            {
                MessageBox.Show("Please fill all the fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult check = MessageBox.Show("Are you sure you want to DELETE " +
                "Employee ID: " + addEmpID.Text.Trim() + "?", "Confirmation Message",
                MessageBoxButtons.YesNo, MessageBoxIcon.Information);

            if (check == DialogResult.Yes)
            {
                try
                {
                    connect.Open();

                    DateTime today = DateTime.Today;
                    string updateData = "UPDATE employee SET delete_date = @deleteDate WHERE employee_id = @employeeID";


                    string imagePath = addEmpPictureBox.ImageLocation ?? string.Empty;

                    if (!string.IsNullOrEmpty(imagePath))
                    {
                        string path = Path.Combine(@"D:\My_projects\C#-(.NET)\EmployeeManagementSystem\EmployeeManagementSystem\Directory\",
                            $"{addEmpID.Text.Trim()}.jpg");

                        string directoryPath = Path.GetDirectoryName(path);

                        if (!Directory.Exists(directoryPath))
                        {
                            Directory.CreateDirectory(directoryPath);
                        }

                        File.Copy(imagePath, path, true);
                        imagePath = path;
                    }

                    using (SqlCommand cmd = new SqlCommand(updateData, connect))
                    {
                        cmd.Parameters.AddWithValue("deleteDate", today);
                        cmd.Parameters.AddWithValue("@employeeID", addEmpID.Text.Trim());

                        cmd.ExecuteNonQuery();

                        displayEmployeeData();

                        MessageBox.Show("Deleted Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        clearFileds();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error: {ex.Message}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                        connect.Close();
                }
            }
            else
            {
                MessageBox.Show("Cancelled", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
