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

namespace employee_management
{
    public partial class AddEmployee : UserControl
    {
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\code\wf_employee\employee_management\employee_management\employee.mdf;Integrated Security=True");
        public AddEmployee()
        {
            InitializeComponent();

            // TO DISPLAY THE DATA FROM DATABASE TO YOUR DATA GRID VIEW
            displayEmployeeData();
        }

        public void displayEmployeeData()
        {
            EmployeeData ed = new EmployeeData();
            List<EmployeeData> listData = ed.employeeListData();

            dataGridView1.DataSource = listData;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void addEmployee_addBtn_Click(object sender, EventArgs e)
        {
            if (addEmployee_ID.Text == ""
                || addEmployee_fullName.Text == ""
                || addEmployee_gender.Text == ""
                || addEmployee_phoneNumber.Text == ""
                || addEmployee_position.Text == ""
                || addEmployee_status.Text == ""
                || addEmployee_picture.Image == null)
            {
                MessageBox.Show("Please fill all blank fields",
                    "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State == ConnectionState.Closed)
                {
                    try
                    {
                        connect.Open();
                        string checkEmID = "SELECT * FROM employees WHERE employee_id = @emID";

                        using (SqlCommand checkEm = new SqlCommand(checkEmID, connect))
                        {
                            int count = (int)checkEm.ExecuteNonQuery();

                            if (count >= 1)
                            {
                                MessageBox.Show(addEmployee_ID.Text.Trim() + "이미 있습니다"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                DateTime today = DateTime.Today;

                                string insertData = "INSERT INTO employees " +
                                  "(employee_id, full_name, gender, contact_number, position, image, salary, insert_date, status) " +
                                 "VALUES (@employeeID, @fullName, @gender, @contactNum, @position, @image, @salary, @insertDate, @status)";
                                
                                // DB
                                string path = Path.Combine(@"");

                                string directoryPath = Path.GetDirectoryName(path);

                                if(!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(addEmployee_picture.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@employeeID", addEmployee_ID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@fullName", addEmployee_fullName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@gender", addEmployee_gender.Text.Trim());
                                    cmd.Parameters.AddWithValue("@contactNum", addEmployee_phoneNumber.Text.Trim());
                                    cmd.Parameters.AddWithValue("@position", addEmployee_position.Text.Trim());
                                    cmd.Parameters.AddWithValue("@image", path);
                                    cmd.Parameters.AddWithValue("@insertDate", today);
                                    cmd.Parameters.AddWithValue("@status", addEmployee_status.Text.Trim());

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("추가했습니다", "Infomation Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error:" + ex, "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }
    }
