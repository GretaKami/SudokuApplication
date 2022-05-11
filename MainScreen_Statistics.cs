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
    public partial class MainScreen_Statistics : Form
    {
        public MainScreen_Statistics()
        {
            InitializeComponent();
            label1.Text = $"{LogIn.Player.Name}'s statistics";

            label_finishedGamesNR.Text = (LogIn.Player.NumberOfEasyGames + LogIn.Player.NumberOfMediumGames +
                LogIn.Player.NumberOfHardGames).ToString();

            label_easyGamesNR.Text = LogIn.Player.NumberOfEasyGames.ToString();
            label_mediumGamesNR.Text = LogIn.Player.NumberOfMediumGames.ToString();
            label_hardGamesNR.Text = LogIn.Player.NumberOfHardGames.ToString();

            // add label value for number of saved games!!!

        }

        private bool closeApplication = true;

        private void button_back_Click(object sender, EventArgs e)
        {
            closeApplication = false;
            new MainScreen().Show();
            this.Close();
        }

        private void button_back_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.DimGray;
            button.ForeColor = Color.White;
        }

        private void button_back_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }

        private void MainScreen_Statistics_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(closeApplication) { Application.Exit(); }
        }
    }
}
