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
    public partial class MainScreen_LoadGame : Form
    {
        public MainScreen_LoadGame()
        {
            InitializeComponent();

            // add function to put saved game list to list view
            //    string selectedGameInfo = listView_savedGames.SelectedItems[0].SubItems[1].Text;
            //    LogIn.Player.selectedGame = selectedGameInfo; // this part will need to be changed to select a game to load from the list
            
        }



        //int ID = 1;
        //string difficulty = "easy";
        //string solvedGamePercentage = "25%";

        //ListViewItem item = new ListViewItem(ID.ToString());
        //item.SubItems.Add(difficulty);
        //item.SubItems.Add(solvedGamePercentage);
        //listView_savedGames.Items.Add(item);

        //ID = 2;
        //difficulty = "medium";
        //solvedGamePercentage = "50%";
        //ListViewItem item2 = new ListViewItem(ID.ToString());
        //item2.SubItems.Add(difficulty);
        //item2.SubItems.Add(solvedGamePercentage);
        //listView_savedGames.Items.Add(item2);

        private bool closeApplication = true;
        private void button_startGame_Click(object sender, EventArgs e)
        {
            closeApplication = false;
            // add functionality to start a loaded game!!!
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            closeApplication = false;

            new MainScreen().Show();
            this.Close();
        }

        private void button_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.White;
            button.ForeColor = Color.Black;
        }

        private void button_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.BackColor = Color.Maroon;

            if (button == button_startGame)
            {
                button.ForeColor = Color.Aqua;
            }
            else { button.ForeColor = Color.White; }

        }

        private void MainScreen_LoadGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (closeApplication) { Application.Exit(); }
        }
    }
}
