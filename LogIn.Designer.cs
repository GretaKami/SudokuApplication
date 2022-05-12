namespace SudokuApplication
{
    partial class LogIn
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
            this.label_welcome = new System.Windows.Forms.Label();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_username = new System.Windows.Forms.Label();
            this.label_password = new System.Windows.Forms.Label();
            this.button_login = new System.Windows.Forms.Button();
            this.button_signup = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_welcome
            // 
            this.label_welcome.Dock = System.Windows.Forms.DockStyle.Top;
            this.label_welcome.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_welcome.ForeColor = System.Drawing.Color.White;
            this.label_welcome.Location = new System.Drawing.Point(0, 0);
            this.label_welcome.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_welcome.Name = "label_welcome";
            this.label_welcome.Size = new System.Drawing.Size(346, 106);
            this.label_welcome.TabIndex = 0;
            this.label_welcome.Text = "Welcome!";
            this.label_welcome.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBox_username
            // 
            this.textBox_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_username.Location = new System.Drawing.Point(63, 166);
            this.textBox_username.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(218, 26);
            this.textBox_username.TabIndex = 1;
            this.textBox_username.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_password.Location = new System.Drawing.Point(63, 230);
            this.textBox_password.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(218, 26);
            this.textBox_password.TabIndex = 2;
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_username.ForeColor = System.Drawing.Color.White;
            this.label_username.Location = new System.Drawing.Point(136, 147);
            this.label_username.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(73, 17);
            this.label_username.TabIndex = 3;
            this.label_username.Text = "Username";
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.ForeColor = System.Drawing.Color.White;
            this.label_password.Location = new System.Drawing.Point(139, 211);
            this.label_password.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(69, 17);
            this.label_password.TabIndex = 4;
            this.label_password.Text = "Password";
            // 
            // button_login
            // 
            this.button_login.BackColor = System.Drawing.Color.Maroon;
            this.button_login.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_login.ForeColor = System.Drawing.Color.Aqua;
            this.button_login.Location = new System.Drawing.Point(63, 294);
            this.button_login.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_login.Name = "button_login";
            this.button_login.Size = new System.Drawing.Size(94, 32);
            this.button_login.TabIndex = 5;
            this.button_login.Text = "Log In";
            this.button_login.UseVisualStyleBackColor = false;
            this.button_login.Click += new System.EventHandler(this.button_login_Click);
            this.button_login.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_login.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // button_signup
            // 
            this.button_signup.FlatAppearance.BorderColor = System.Drawing.Color.Maroon;
            this.button_signup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_signup.ForeColor = System.Drawing.Color.White;
            this.button_signup.Location = new System.Drawing.Point(187, 294);
            this.button_signup.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button_signup.Name = "button_signup";
            this.button_signup.Size = new System.Drawing.Size(94, 32);
            this.button_signup.TabIndex = 6;
            this.button_signup.Text = "Sign Up";
            this.button_signup.UseVisualStyleBackColor = true;
            this.button_signup.Click += new System.EventHandler(this.button_signup_Click);
            this.button_signup.MouseEnter += new System.EventHandler(this.button_MouseEnter);
            this.button_signup.MouseLeave += new System.EventHandler(this.button_MouseLeave);
            // 
            // LogIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(346, 368);
            this.Controls.Add(this.button_signup);
            this.Controls.Add(this.button_login);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.label_username);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_username);
            this.Controls.Add(this.label_welcome);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.Name = "LogIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_welcome;
        private System.Windows.Forms.TextBox textBox_username;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Label label_username;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button button_login;
        private System.Windows.Forms.Button button_signup;
    }
}