
namespace employee_management
{
    partial class RegisterForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterForm));
            this.lgoin_button = new System.Windows.Forms.Button();
            this.signup_showPassword = new System.Windows.Forms.CheckBox();
            this.signup_password = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.signup_username = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.exit = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.signup_loginButton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lgoin_button
            // 
            this.lgoin_button.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.lgoin_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.lgoin_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lgoin_button.FlatAppearance.BorderSize = 0;
            this.lgoin_button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(97)))));
            this.lgoin_button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(97)))));
            this.lgoin_button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lgoin_button.Font = new System.Drawing.Font("Ebrima", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lgoin_button.ForeColor = System.Drawing.Color.Snow;
            this.lgoin_button.Location = new System.Drawing.Point(287, 284);
            this.lgoin_button.Name = "lgoin_button";
            this.lgoin_button.Size = new System.Drawing.Size(92, 38);
            this.lgoin_button.TabIndex = 16;
            this.lgoin_button.Text = "REGISTER";
            this.lgoin_button.UseVisualStyleBackColor = false;
            this.lgoin_button.Click += new System.EventHandler(this.signup_btn_Click);
            // 
            // signup_showPassword
            // 
            this.signup_showPassword.AutoSize = true;
            this.signup_showPassword.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_showPassword.Location = new System.Drawing.Point(436, 250);
            this.signup_showPassword.Name = "signup_showPassword";
            this.signup_showPassword.Size = new System.Drawing.Size(112, 18);
            this.signup_showPassword.TabIndex = 15;
            this.signup_showPassword.Text = "Show Password";
            this.signup_showPassword.UseVisualStyleBackColor = true;
            this.signup_showPassword.CheckedChanged += new System.EventHandler(this.signup_showPassword_CheckedChanged);
            // 
            // signup_password
            // 
            this.signup_password.BackColor = System.Drawing.SystemColors.Window;
            this.signup_password.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_password.Location = new System.Drawing.Point(287, 214);
            this.signup_password.Multiline = true;
            this.signup_password.Name = "signup_password";
            this.signup_password.PasswordChar = '*';
            this.signup_password.Size = new System.Drawing.Size(261, 30);
            this.signup_password.TabIndex = 14;
            this.signup_password.TextChanged += new System.EventHandler(this.signup_password_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(284, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 16);
            this.label4.TabIndex = 13;
            this.label4.Text = "Password";
            // 
            // signup_username
            // 
            this.signup_username.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_username.Location = new System.Drawing.Point(287, 144);
            this.signup_username.Multiline = true;
            this.signup_username.Name = "signup_username";
            this.signup_username.Size = new System.Drawing.Size(261, 30);
            this.signup_username.TabIndex = 12;
            this.signup_username.TextChanged += new System.EventHandler(this.signup_username_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(284, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 16);
            this.label3.TabIndex = 11;
            this.label3.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Ebrima", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(282, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(163, 25);
            this.label2.TabIndex = 10;
            this.label2.Text = "Register Account";
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.exit.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(554, 6);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(17, 18);
            this.exit.TabIndex = 8;
            this.exit.Text = "X";
            this.exit.Click += new System.EventHandler(this.Exit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(71)))), ((int)(((byte)(171)))));
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.signup_loginButton);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(254, 400);
            this.panel1.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(77, 59);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 100);
            this.pictureBox1.TabIndex = 11;
            this.pictureBox1.TabStop = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(23, 177);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(209, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Employee Management System";
            // 
            // signup_loginButton
            // 
            this.signup_loginButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(51)))), ((int)(((byte)(102)))));
            this.signup_loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signup_loginButton.FlatAppearance.BorderSize = 0;
            this.signup_loginButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(97)))));
            this.signup_loginButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(111)))), ((int)(((byte)(97)))));
            this.signup_loginButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signup_loginButton.Font = new System.Drawing.Font("Arial Narrow", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signup_loginButton.ForeColor = System.Drawing.Color.White;
            this.signup_loginButton.Location = new System.Drawing.Point(12, 352);
            this.signup_loginButton.Name = "signup_loginButton";
            this.signup_loginButton.Size = new System.Drawing.Size(226, 32);
            this.signup_loginButton.TabIndex = 9;
            this.signup_loginButton.Text = "SIGN IN";
            this.signup_loginButton.UseVisualStyleBackColor = false;
            this.signup_loginButton.Click += new System.EventHandler(this.signup_loginButton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tahoma", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(54, 320);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(132, 18);
            this.label5.TabIndex = 8;
            this.label5.Text = "Login your Account";
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(575, 400);
            this.Controls.Add(this.lgoin_button);
            this.Controls.Add(this.signup_showPassword);
            this.Controls.Add(this.signup_password);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.signup_username);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.exit);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RegisterForm";
            this.Load += new System.EventHandler(this.RegisterForm_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button lgoin_button;
        private System.Windows.Forms.CheckBox signup_showPassword;
        private System.Windows.Forms.TextBox signup_password;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox signup_username;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button signup_loginButton;
        private System.Windows.Forms.Label label5;
    }
}