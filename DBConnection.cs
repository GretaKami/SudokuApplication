using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SudokuApplication
{
    public class DBConnection
    {
        string datasource { get; set; }
        string database { get; set; }
        string connString { get; set; }
        public SqlConnection conn { get; set; }

        public DBConnection()
        {
            Console.WriteLine("Getting Connection ...");
            datasource = @"LAPTOP-S139V69N";
            database = "Sudoku";
            connString = $@"Server={datasource};Database={database};Trusted_Connection=True;";
            conn = new SqlConnection(connString);
            try
            {
                conn.Open();
                Console.WriteLine("Connection created");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error : " + ex.Message);
            }
        }
    }
}

