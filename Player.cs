﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuApplication
{
    public class Player
    {
        public string Name { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public int NumberOfPlayedGames { get; set; }

        //how to describe saved games?
        public Player()
        {

        }
        public Player(string Name, string Username, string Password, int NumberOfPlayedGames)
        {
            this.Name = Name;
            this.Username = Username;
            this.Password = Password;
            this.NumberOfPlayedGames = NumberOfPlayedGames;
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
                            reader["player_name"].ToString(),
                            reader["player_username"].ToString(),
                            reader["player_password"].ToString(),
                            Convert.ToInt32(reader["finished_games"]));

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

            string query = $"INSERT INTO dbo.player (player_name, player_username, player_password, finished_games) " +
                $"VALUES ('{name}', '{username}', '{password}', 0)";

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
    }
}