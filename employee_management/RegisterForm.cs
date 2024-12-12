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

namespace employee_management
{
    public partial class RegisterForm : Form
    { 
        SqlConnection connect = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\PC_1\Desktop\songmok\wf_employee\employee_management\employee_management\employee.mdf;Integrated Security=True");


        public RegisterForm()
        {
            InitializeComponent();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void RegisterForm_Load(object sender, EventArgs e)
        {

        }

        private void login_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void signup_loginButton_Click(object sender, EventArgs e)
        {
            LoginForm loginForm = new LoginForm();
            loginForm.Show();
            this.Hide();
        }

        private void signup_showPassword_CheckedChanged(object sender, EventArgs e)
        {
            signup_password.PasswordChar = signup_showPassword.Checked ? '\0' : '*';
        }

        private void signup_username_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
