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
    public partial class GameScreen : Form
    {
        private Button[,] cells;
        private bool closeApplication = true;

        private GameLogic gridNumbers;
        private Gameboard selectedSavedGame;

        public GameScreen()
        {
            InitializeComponent();

            cells = new SudokuCells[9, 9];          
            createCells();
            gridNumbers = new GameLogic(cells);

            if (LogIn.Player.selectedGameID == 0)
            {                 
                gridNumbers.loadValues();
                gridNumbers.showRandomValuesHints(GetHintsCount());
            }
            else {
                selectedSavedGame = new Gameboard();
                foreach(Gameboard game in LogIn.SavedGamesList)
                {
                    if (LogIn.Player.selectedGameID == game.ID)
                    {
                        selectedSavedGame = game;
                        LogIn.Player.GameDifficulty = game.Difficulty;
                        break;
                    }
                }
                gridNumbers.LoadValuesFromSavedGame(selectedSavedGame);
            }
            

        }       
        
        private int GetHintsCount()
        {
            int hintsCount = 79;
            Random random = new Random();

            switch (LogIn.Player.GameDifficulty)
            {
                case 1:
                    hintsCount = random.Next(65, 75);
                    break;
                case 2:
                    hintsCount = random.Next(45, 55);
                    break;
                case 3:
                    hintsCount = random.Next(30, 45);
                    break;
            }

            return hintsCount;
        }
        private void createCells()
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)
                {
                    // Create 81 cells for with styles and locations based on the index
                    cells[i, j] = new SudokuCells();
                    cells[i, j].Font = new Font(SystemFonts.DefaultFont.FontFamily, 20);
                    cells[i, j].Size = new Size(40, 40);
                    cells[i, j].ForeColor = Color.Black;
                    cells[i, j].Location = new Point(i * 40, j * 40);
                    cells[i, j].BackColor = ((i / 3) + (j / 3)) % 2 == 0 ? SystemColors.Control : Color.LightGray;
                    cells[i, j].FlatStyle = FlatStyle.Flat;
                    //cells[i, j].X = i;
                    //cells[i, j].Y = j;
                    cells[i, j].KeyPress += cell_keyPressed;
                    panelBoard.Controls.Add(cells[i, j]);
                }

            }

        }
        private void cell_keyPressed(object sender, KeyPressEventArgs e)
        {
            var cell = sender as SudokuCells;

            int value;

            // Add the pressed key value in the cell only if it is a number
            if (int.TryParse(e.KeyChar.ToString(), out value))
            {
                // Clear the cell value if pressed key is zero
                if (value == 0)
                    cell.Clear();
                else
                {
                    cell.ForeColor = Color.DeepSkyBlue;
                    cell.Text = value.ToString();
                }

            }
        }

        private void button_checkGame_Click(object sender, EventArgs e)
        {
            if (gridNumbers.isGameSolvedCorrectly(cells))
            {
                LogIn.Player.UpdateGameStatistics(LogIn.Connection.conn);

                if (LogIn.Player.selectedGameID != 0) // deletes finished game from saved games list
                {  
                    selectedSavedGame.DeleteSavedGame(LogIn.Connection.conn);
                    LogIn.Player.selectedGameID = 0;
                }
                
                panel_finishedGame.Visible = true;

                timer1.Start();
                pictureBox1.Visible = true;
                button_checkGame.Enabled = false;
                button_saveGame.Enabled = false;
                button_back.Enabled = false;

            }
            else { MessageBox.Show("There are some mistakes!"); }
        }

        private void button_saveGame_Click(object sender, EventArgs e)
        {
            closeApplication = false;

            if (LogIn.Player.selectedGameID != 0) // saves new game on top of the old save file
            {
                selectedSavedGame.UpdateSavedGame(LogIn.Connection.conn, cells);
                LogIn.Player.selectedGameID = 0;
            }
            else
            {
                Gameboard game = new Gameboard(LogIn.Player, gridNumbers.cellValues, gridNumbers.originalShownGridValues);
                game.SaveGame(LogIn.Connection.conn, cells);
            }
            

            new MainScreen().Show();
            this.Close();
        }

        private void button_back_Click(object sender, EventArgs e)
        {
            closeApplication = false;
            new MainScreen_StartNewGame().Show();
            this.Close();
        }
        private void button_playAgain_Click(object sender, EventArgs e)
        {
            closeApplication = false;
            new MainScreen_StartNewGame().Show();
            this.Close();
        }

        private void button_backToMainCreen_Click(object sender, EventArgs e)
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
            if(button == button_playAgain || button == button_backToMainScreen)
            {
                button.BackColor = Color.DimGray;
            }
            else button.BackColor = Color.Maroon;

            if (button == button_checkGame || button == button_playAgain)
            {
                button.ForeColor = Color.Aqua;
            }
            else button.ForeColor = Color.White;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(closeApplication) { Application.Exit(); }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            pictureBox1.Visible = false;
        }









        //private void radioButton1_CheckedChanged(object sender, EventArgs e)
        //{

        //}

        //private void button2_Click(object sender, EventArgs e)
        //{
        //    if (EasyButton.Checked == true)
        //    {
        //        EasyButton.PerformClick();
        //    }
        //    if (MediumButton.Checked == true)
        //    {
        //        MediumButton.PerformClick();
        //    }
        //    if (ButtonHard.Checked != true)
        //    {
        //        ButtonHard.PerformClick();

        //    }

        //}
    }
}
