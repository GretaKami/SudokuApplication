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
            LoadItemsToListView();    
            
        }

        private void LoadItemsToListView()
        {
            LogIn.SavedGamesList = LogIn.Player.GetSavedGameList(LogIn.Connection.conn);

            foreach (Gameboard savedGame in LogIn.SavedGamesList)
            {
                ListViewItem item = new ListViewItem(savedGame.ID.ToString());
                item.SubItems.Add(savedGame.DifficultyString);
                item.SubItems.Add(savedGame.SolvedPart);

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
            LogIn.Player.selectedGameID = selectedGameID;
            closeApplication = false;

            new Form1().Show();
            this.Close();
            
        }

        private void button_delete_Click(object sender, EventArgs e)
        {
            int selectedGameID = Convert.ToInt32(listView_loadGame.SelectedItems[0].SubItems[0].Text);

            foreach(Gameboard savedGame in LogIn.SavedGamesList)
            {
                if(selectedGameID == savedGame.ID)
                {
                    savedGame.DeleteSavedGame(LogIn.Connection.conn);
                    MessageBox.Show("Game deleted successfully!");
                }
            }

            listView_loadGame.Items.Clear();
            LoadItemsToListView();
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
