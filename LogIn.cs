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

        public static List<Gameboard> SavedGamesList = new List<Gameboard>();

        public LogIn()
        {
            InitializeComponent();

            FormList.Add(this); // index 0
            PlayerList = Player.GetPlayerList(Connection.conn);

        }
        private void button_login_Click(object sender, EventArgs e)
        {
            bool logIn = false;
            PlayerList = Player.GetPlayerList(Connection.conn);

            foreach (Player player in PlayerList)
            {
                if(player.Username == textBox_username.Text && player.Password == textBox_password.Text)
                {
                    Player = player;
                    SavedGamesList = LogIn.Player.GetSavedGameList(LogIn.Connection.conn);
                    logIn = true;
                    break;

                }
            }

            if (logIn)
            {
                this.Hide();
                new MainScreen().Show();
            }
            else
            {
                MessageBox.Show("Incorrect username or password!");
            }
            
        }

        private void button_signup_Click(object sender, EventArgs e)
        {
            this.Hide();
            CreateNewAccount createNewAccount = new CreateNewAccount();
            createNewAccount.Show(); 
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

            if(button == button_login)
            {
                button.ForeColor = Color.Aqua;
            }
            else { button.ForeColor = Color.White; }
                        
        }

    }
    
}
