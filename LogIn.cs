using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SudokuApplication;

namespace SudokuApplication
{
    public partial class LogIn : Form
    {
        public static DBConnection Connection = new DBConnection();

        public static List<Player> PlayerList = new List<Player>();

        public static Player Player = new Player();

        public static List<Form> FormList = new List<Form>();

        public LogIn()
        {
            InitializeComponent();

            FormList.Add(this); // index 0
            
        }

        private void LogIn_Load(object sender, EventArgs e)
        {
            

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            PlayerList = Player.GetPlayerList(Connection.conn);

            bool correctLoginInformation = false;

            foreach(Player player in PlayerList)
            {
                if(player.Username == textBox_username.Text && 
                    player.Password == textBox_password.Text)
                {
                    Player = player;
                    correctLoginInformation = true;
                    this.Hide();
                    new Form1().Show();
                    
                    break;

                    //add code to open a new window where player can start a new game or load
                    // an old game
                }
            }

            if (!correctLoginInformation)
            {
                MessageBox.Show("Incorrect username or password. Please try again");
            }

        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewAccount createNewAccount = new CreateNewAccount();
            createNewAccount.Show(); 
        }

        
    }
}
