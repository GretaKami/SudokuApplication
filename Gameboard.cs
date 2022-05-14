using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuApplication
{
    public class Gameboard
    {
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public int Difficulty { get; set; }
        public string DifficultyString { get; set; }
        public int [,] OriginalGridValues { get; set; }
        public int [,] OriginalShownGridNumbers { get; set; }
        public int [,] EnteredGridNumbers { get; set; }
        public string SolvedPart { get; set; }

        public Gameboard()
        {
            OriginalGridValues = new int[9, 9];
            OriginalShownGridNumbers = new int[9, 9];
            EnteredGridNumbers = new int[9, 9];
        }
        public Gameboard(Player player, int[,] OriginalGridValues, int[,] OriginalShownGridNumbers) // for saving a game
        {
            this.PlayerID = player.ID;
            this.Difficulty = player.GameDifficulty;
            this.OriginalGridValues = OriginalGridValues;
            this.OriginalShownGridNumbers = OriginalShownGridNumbers;

            EnteredGridNumbers = new int[9, 9];
            GetDifficultyString();
        }
        public Gameboard(int ID, int PlayerID, int Difficulty, int[,] OriginalGridValues, int[,] OriginalShownGridNumbers,
            int[,] EnteredGridNumbers) // for loading a game
        {
            this.ID = ID;
            this.PlayerID = PlayerID;
            this.Difficulty = Difficulty;

            GetDifficultyString();

            this.OriginalGridValues = OriginalGridValues;
            this.OriginalShownGridNumbers = OriginalShownGridNumbers;
            this.EnteredGridNumbers = EnteredGridNumbers;

            CalulateSolvedPart();
        }
        

        public void GetEnteredGridNumbers(Button[,] cells)
        {
            for(int row=0; row < 9; row++)
            {
                for(int col = 0; col < 9; col++)
                {
                    if(cells[row, col].Text != OriginalShownGridNumbers[row, col].ToString() && 
                        cells[row,col].Text != String.Empty)
                    {
                        EnteredGridNumbers[row, col] = Convert.ToInt32(cells[row, col].Text);
                    }
                }
            }
        }
        private void GetDifficultyString()
        {
            switch (Difficulty)
            {
                case 1:
                    this.DifficultyString = "Easy";
                    break;
                case 2:
                    this.DifficultyString = "Medium";
                    break;
                case 3:
                    this.DifficultyString = "Hard";
                    break;
            }
        }
        private void CalulateSolvedPart()
        {
            int numbersToBeEnteredCounter = 0;
            int correctlyEnteredNumbersCounter = 0;
            
            for(int row=0; row<9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    if (OriginalShownGridNumbers[row, col] == 0) numbersToBeEnteredCounter++;
                    if (EnteredGridNumbers[row, col] == OriginalGridValues[row, col]) correctlyEnteredNumbersCounter++;
                }    
            }

            double solvedPart = (double)correctlyEnteredNumbersCounter / numbersToBeEnteredCounter * 100;
            
            SolvedPart = Math.Round(solvedPart).ToString() + "%";
            
        }

        public void SaveGame(SqlConnection connection)
        {
           
            string originalShownGridNumbersString = "";
            string originalGridValuesString = "";
            string enteredGridValuesString = "";

            for (int row = 0; row < 9; row++)
            {
                for (int col = 0; col < 9; col++)
                {
                    originalShownGridNumbersString += OriginalShownGridNumbers[row, col].ToString();
                    originalGridValuesString += OriginalGridValues[row, col].ToString();
                    enteredGridValuesString += EnteredGridNumbers[row, col].ToString();
                }
            }

            //MessageBox.Show("original grid values: " + originalGridValuesString);
            //MessageBox.Show("shown grid values: " + originalShownGridNumbersString);
            //MessageBox.Show("entered grid values: " + enteredGridValuesString);

            string query = "INSERT INTO dbo.saved_games (playerID, difficulty, numbers_string, originalShownGridNumbers_string, enteredGridNumbers_string ) " +
                $"VALUES ({PlayerID}, {Difficulty}, '{originalGridValuesString}', '{originalShownGridNumbersString}', '{enteredGridValuesString}')";

            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                cmd.ExecuteNonQuery();
                MessageBox.Show("Game saved");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error - " + ex.Message);
            }
            
        }

        public void DeleteSavedGame(SqlConnection connection)
        {
            string query = $"DELETE FROM dbo.saved_games WHERE ID={ID}";

            SqlCommand cmd = new SqlCommand(query, connection);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error - " + ex.Message);
            }
        }

        


    }
}
