using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace apk_user
{
    public partial class zabukowaneuser : UserControl
    {
        public zabukowaneuser()
        {
            InitializeComponent();
            string command = "SELECT userid FROM users WHERE login_text = '" + username + "' AND haslo = '" + user_password + "'";//tworzymy kolejne zapytanie do bazy danych tylko teraz szuka linijki z admincheck = false
            SqlCommand cmd = new SqlCommand(command);
            
        }
        private SqlConnection conn = new SqlConnection(Properties.Settings.Default.projektConnectionString);
        public static string username;
        public static string user_password;
        public void userdid(string a, string b)
        {
            username = a.ToString();
            user_password = b.ToString();
            Console.WriteLine(username + " " + user_password);
            
        }

        private void zabukowaneuser_Load(object sender, EventArgs e)
        {
            userdisplay.Text = "ele" + username;
        }

        
    }
}
