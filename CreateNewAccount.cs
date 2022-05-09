using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace SudokuApplication
{
    public partial class CreateNewAccount : Form
    {
        public CreateNewAccount()
        {
            InitializeComponent();
            toolTip_passwordInfo.SetToolTip(label2, "Password can contain only letters and numbers!" +
                "\nIt must be at least 5 characters long" +
                "\nand needs to contain at least 1 number and 1 upper case letter!");
        }

        private void button_signUp_Click(object sender, EventArgs e)
        {
            label_wrongUsername.Visible = false;
            label_passwordRule.Visible = false;
            label_username.ForeColor = Color.Black;
            label_password.ForeColor = Color.Black;
            label_repeatPassword.ForeColor = Color.Black;
            

            Regex regex = new Regex("((\\w*[A-Z]+?\\w*)(\\w*\\d+?\\w*))|((\\w*\\d+?\\w*)(\\w*[A-Z]+?\\w*))");

            if(textBox_name.Text == String.Empty || textBox_username.Text == String.Empty
                || textBox_password.Text == String.Empty || textBox_repeatPassword.Text == String.Empty)
            {
                MessageBox.Show("All fields must be filled in!");
            }
            else if (!LogIn.Player.IsUsernameValid(textBox_username.Text, LogIn.PlayerList))
            {
                label_wrongUsername.Visible = true;
                label_username.ForeColor = Color.Red;
                MessageBox.Show("This username is already used!");
            }
            else if(textBox_password.Text.Length < 5)
            {
                MessageBox.Show("Password must be at least 5 characters long!");
                label_password.ForeColor= Color.Red;
                label_passwordRule.Text = "Password must be at least 5 characters long!";
                label_passwordRule.Visible = true;
            }
            else if (!regex.IsMatch(textBox_password.Text))
            {
                MessageBox.Show("Password must contain at least 1 number and 1 upper case letter!");
                label_password.ForeColor = Color.Red;
                label_passwordRule.Text = "Password must contain at least 1 number and 1 upper case letter!";
                label_passwordRule.Visible = true;
            }
            else if (textBox_password.Text != textBox_repeatPassword.Text)
            {
                MessageBox.Show("Repeated password doesn't match! Please try again");
                label_repeatPassword.ForeColor = Color.Red;
                               
            }
            else
            {
                LogIn.Player.CreateNewPlayer(LogIn.Connection.conn, textBox_name.Text, textBox_username.Text,
                    textBox_password.Text);

                MessageBox.Show("New account created successfully! Please log in!");
                this.Close();
                LogIn.FormList[0].Show();
            }

        }

        private bool closeApplication = true;
        private void button_back_Click(object sender, EventArgs e)
        {
            closeApplication = false;
            this.Close();
            LogIn.FormList[0].Show();

        }

        private void CreateNewAccount_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(closeApplication) { Application.Exit(); }
        }
    }
}
