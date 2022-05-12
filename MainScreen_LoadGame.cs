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

            foreach (Gameboard savedGame in LogIn.SavedGamesList)
            {
                ListViewItem item = new ListViewItem(savedGame.ID.ToString());
                item.SubItems.Add(savedGame.DifficultyString);
                // add solved percentage!!!

                listView_loadGame.Items.Add(item);
            }
           
            
        }


        private bool closeApplication = true;
        

        private void listView_loadGame_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            button_startGame.Enabled = true;
        }

        private void button_startGame_Click(object sender, EventArgs e)
        {
            int selectedGameID = Convert.ToInt32(listView_loadGame.SelectedItems[0].SubItems[0].Text);
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
