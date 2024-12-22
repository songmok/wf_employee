using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace employee_management
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void logout_btn_Click(object sender, EventArgs e)
        {
            DialogResult check = MessageBox.Show("로그아웃 하시겠습니까?", "Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (check == DialogResult.Yes)
            {
                LoginForm loginForm = new LoginForm();
                loginForm.Show();
                this.Hide();
            }
        }

        private void dashboard_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = true;
            addEmployee1.Visible = false;
            salaly1.Visible = false;
        }

        private void addEmployee_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = true;
            salaly1.Visible = false;
        }

        private void salary_Click(object sender, EventArgs e)
        {
            dashboard1.Visible = false;
            addEmployee1.Visible = false;
            salaly1.Visible = true;
        }

       
    }
}
