using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SudokuApplication
{
    public class Player
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int NumberOfEasyGames { get; set; }
        public int NumberOfMediumGames { get; set; }
        public int NumberOfHardGames { get; set; }
        public int GameDifficulty { get; set; }
        public int selectedGameID { get; set; } // LAIKINAS!!!

        //how to describe saved games?
        public Player()
        {

        }
        public Player(int ID, string Name, string Username, string Password, int NumberOfEasyGames, 
            int NumberOfMediumGames, int NumberOfHardGames)
        {
            this.ID = ID;
            this.Name = Name;
            this.Username = Username;
            this.Password = Password;
            this.NumberOfEasyGames = NumberOfEasyGames;
            this.NumberOfMediumGames = NumberOfMediumGames;
            this.NumberOfHardGames = NumberOfHardGames; 
            GameDifficulty = 1;
            selectedGameID = 0;
        }

        public List<Player> GetPlayerList(SqlConnection connection)
        {
            List<Player> playerList = new List<Player>();

            string query = "SELECT * from dbo.player";
            SqlCommand cmd = new SqlCommand(query, connection);

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                try
                {
                    while (reader.Read())
                    {
                        Player player = new Player(
                            Convert.ToInt32(reader["ID"]),
                            reader["player_name"].ToString(),
                            reader["player_username"].ToString(),
                            reader["player_password"].ToString(),
                            Convert.ToInt32(reader["easy_games"]),
                            Convert.ToInt32(reader["medium_games"]),
                            Convert.ToInt32(reader["hard_games"]));

                        playerList.Add(player);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error - " + ex.Message);
                }
            }

           return playerList;
        }
        
        public void CreateNewPlayer (SqlConnection connection, string name, string username, string password)
        {

            string query = $"INSERT INTO dbo.player (player_name, player_username, player_password, easy_games, medium_games, hard_games) " +
                $"VALUES ('{name}', '{username}', '{password}', 0, 0, 0)";

            SqlCommand cmd = new SqlCommand (query, connection);

            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error - " + ex.Message);
            }
            
        }

        public bool IsUsernameValid(string username, List<Player> playerList)
        {
            bool isUsernameValid = true;

            foreach(Player player in playerList)
            {
                if(player.Username == username)
                {
                    isUsernameValid = false;
                    break;
                }
            }
            
            return isUsernameValid;
        }

        public List<Gameboard> GetSavedGameList (SqlConnection connection)
        {
            List<Gameboard> savedGamesList = new List<Gameboard>();

            string query = "SELECT * FROM dbo.saved_games";

            SqlCommand cmd = new SqlCommand (query, connection);

            try {
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if(Convert.ToInt32(reader["playerID"]) == ID)
                        {
                            int[,] OriginalGridValues = new int[9, 9];
                            int[,]  OriginalShownGridNumbers = new int[9, 9];
                            int[,]  EnteredGridNumbers = new int[9, 9];

                            int counter = 0;
                            for (int row = 0; row < 9; row++)
                            {
                                for (int col = 0; col < 9; col++)
                                {
                                    OriginalGridValues[row, col] = (int)Char.GetNumericValue(reader["numbers_string"].ToString(), counter);
                                    OriginalShownGridNumbers[row, col] = (int)Char.GetNumericValue(reader["originalShownGridNumbers_string"].ToString(), counter);
                                    EnteredGridNumbers[row, col] = (int)Char.GetNumericValue(reader["enteredGridNumbers_string"].ToString(), counter);
                                    counter++;
                                }
                            }

                            Gameboard gameboard = new Gameboard(
                                Convert.ToInt32(reader["ID"]),
                                Convert.ToInt32(reader["playerID"]),
                                Convert.ToInt32(reader["difficulty"]),
                                OriginalGridValues,
                                OriginalShownGridNumbers,
                                EnteredGridNumbers);

                            savedGamesList.Add(gameboard);
                        }
                    }
                    reader.Close();
                }

                
            }
            catch (Exception ex) { MessageBox.Show("Error - " + ex.Message); }

            return savedGamesList;
            
        }

        public void UpdateGameStatistics(SqlConnection connection)
        {
            switch (GameDifficulty)
            {
                case 1:
                    NumberOfEasyGames++;
                    break;
                case 2:
                    NumberOfMediumGames++;
                    break;
                case 3:
                    NumberOfHardGames++;
                    break;
            }

            string query = $"UPDATE dbo.player SET easy_games={NumberOfEasyGames}, medium_games={NumberOfMediumGames}, " +
                $"hard_games={NumberOfHardGames} WHERE ID={ID}";

            SqlCommand cmd = new SqlCommand(query, connection);

            try { cmd.ExecuteNonQuery(); }
            catch (Exception ex) { MessageBox.Show("Error - " + ex.Message); }

        }
    }
}
