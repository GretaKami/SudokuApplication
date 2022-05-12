using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuApplication
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();
            label_hi.Text = $"Hi, {LogIn.Player.Name}!\nWhat would you like to do?";
        }


        private bool closeApplication = true;       
        

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(closeApplication) { Application.Exit(); }
        }

        private void button_newGame_Click(object sender, EventArgs e)
        {
            new MainScreen_StartNewGame().Show();
            closeApplication = false;
            this.Close();            
        }

        private void button_loadGame_Click(object sender, EventArgs e)
        {
            closeApplication = false;
            new MainScreen_LoadGame().Show();
            this.Close();
                      
        }

        private void button_statistics_Click(object sender, EventArgs e)
        {
            closeApplication = false;
            new MainScreen_Statistics().Show();
            this.Close();
        }

        private void button_logOut_Click(object sender, EventArgs e)
        {
            closeApplication = false;
            LogIn.FormList[0].Show();
            this.Close();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.DimGray;
            button.ForeColor = Color.White;
            
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }

        
    }
}
