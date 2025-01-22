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

namespace EmployeeManagementSystem
{
    public partial class Salary : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Nipun\Documents\employee2.mdf;Integrated Security=True;Connect Timeout=30");

        public Salary()
        {
            InitializeComponent();
            displayEmployees();
            disableFiled();
        }

        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }
            displayEmployees();
            disableFiled();
        }
        private void button1_Click(object sender, EventArgs e)
        {

        }

        public void disableFiled()
        {
            salaryEmpID.Enabled = false;
            salaryEmpName.Enabled = false;
            salaryEmpPosition.Enabled = false;
        }

        public void displayEmployees()
        {
            SalaryData ed = new SalaryData();

            List<SalaryData> listData = ed.salaryEmployeeListData();

            dataGridView1.DataSource = listData;
        }

        private void salaryUpdateBtn_Click(object sender, EventArgs e)
        { 

            if(salaryEmpID.Text == "" ||
                salaryEmpPosition.Text == "" ||
                salaryEmpSalary.Text == "")
            {
                MessageBox.Show("Please fill all the fields.", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                
            }
            else
            {
                DialogResult check = MessageBox.Show("Are you sure want to UPDATE Employee ID: " +
                    salaryEmpSalary.Text.Trim() + "?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if(check == DialogResult.Yes)
                {
                    try
                    {
                        DateTime today = DateTime.Today;
                        connect.Open();
                        string updateData = "UPDATE employee SET salary = @salary" +
                            ", update_date = @updateDate WHERE employee_id = @employeeID";

                        using(SqlCommand cmd = new SqlCommand(updateData, connect))
                        {
                            cmd.Parameters.AddWithValue("@salary", salaryEmpSalary.Text.Trim());
                            cmd.Parameters.AddWithValue("@updateDate", today);
                            cmd.Parameters.AddWithValue("@employeeID", salaryEmpID.Text.Trim());

                            cmd.ExecuteNonQuery();

                            displayEmployees();

                            MessageBox.Show("Updated Successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            clearFileds();
                        }
                    }
                    catch(Exception ex) 
                    {
                        MessageBox.Show("Error: " + ex , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                    finally
                    {
                        connect.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Cancelled.", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        public void clearFileds()
        {
            salaryEmpID.Text = "";
            salaryEmpName.Text = "";
            salaryEmpPosition.Text = "";
            salaryEmpSalary.Text = "";

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                salaryEmpID.Text = row.Cells[0].Value.ToString();
                salaryEmpName.Text = row.Cells[1].Value.ToString();
                salaryEmpPosition.Text = row.Cells[4].Value.ToString();
                salaryEmpSalary.Text = row.Cells[5].Value.ToString();
                

            }
        }

        private void salaryClearBtn_Click(object sender, EventArgs e)
        {
            clearFileds();
        }
    }
}
