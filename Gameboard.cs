using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuApplication
{
    public class Gameboard
    {
        public int ID { get; set; }
        public int PlayerID { get; set; }
        public int Difficulty { get; set; }
        public string DifficultyString { get; set; }
        public int [,] GameBoardNumbers { get; set; }
        public int SolvedPart { get; set; }


        public Gameboard(int ID, int PlayerID, int Difficulty)
        {
            this.ID = ID;
            this.PlayerID = PlayerID;
            this.Difficulty = Difficulty;

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
            GameBoardNumbers = new int[9, 9];
        }
        // add code that generates a new game board!!!
        // add function to calculate solved part!

        private void CalulateSolvedPart()
        {

        }

        public void SaveGame(SqlConnection connection)
        {
            string gameBoardNumbersString = "";

            foreach (int number in GameBoardNumbers)
            {
                gameBoardNumbersString += number.ToString();
            }

            string query = "INSERT INTO dbo.saved_games (playerID, difficulty, numbers_string) " +
                $"VALUES ({PlayerID}, {Difficulty}, {gameBoardNumbersString})";

            SqlCommand cmd = new SqlCommand(query, connection);
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - " + ex.Message);
            }
            
        }

        


    }
}
