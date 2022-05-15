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
    public partial class MainScreen_StartNewGame : Form
    {
        public MainScreen_StartNewGame()
        {
            InitializeComponent();
        }

        private bool closeApplication = true;

        private void button_startGame_Click(object sender, EventArgs e)
        {
            closeApplication = false;
            new GameScreen().Show();
            this.Close();
            // add functionality to generate new game
        }

        private Button button_selectedDifficultyLevel = new Button();
        private void button_gameDifficulty_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            button_selectedDifficultyLevel.BackColor = Color.White;
            button_selectedDifficultyLevel.ForeColor = Color.Black;

            if (button == button_difficultyEasy)
            {
                LogIn.Player.GameDifficulty = 1;
                button_selectedDifficultyLevel = button_difficultyEasy;
            }
            else if(button == button_difficultyMedium)
            {
                LogIn.Player.GameDifficulty = 2;
                button_selectedDifficultyLevel = button_difficultyMedium;
            }
            else if(button == button_difficultyHard)
            {
                LogIn.Player.GameDifficulty = 3;
                button_selectedDifficultyLevel = button_difficultyHard;
            }

            button_selectedDifficultyLevel.BackColor = Color.DimGray;
            button_selectedDifficultyLevel.ForeColor = Color.White;

            button_startGame.Enabled = true;

        }


        private void buttonBack_Click(object sender, EventArgs e)
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

        private void MainScreen_StartNewGame_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(closeApplication) { Application.Exit(); }
        }
    }
}
