using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apk_user
{
    public partial class daneuser : UserControl
    {
        public string user_name;
        public daneuser()
        {
            InitializeComponent();
            string username = Form1.username;
            string user_password = Form1.user_password;

            string command = "SELECT imie,nazwisko,email FROM users WHERE login_text = '" + username + "' AND haslo = '" + user_password + "'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(command, cn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            
            string user_name = "";
            string user_surname = "";
            string user_email = "";

            while (reader.Read())
            {
                user_name = reader["imie"].ToString();
                user_surname = reader["nazwisko"].ToString();
                user_email = reader["email"].ToString();

            }
            reader.Close();
            label1.Text = user_name;
            label2.Text = user_surname;
            label3.Text = user_email;
            label4.Text = user_password;
            label5.Text = username;
            
            cn.Close();
        }
        private SqlConnection cn = new SqlConnection(@"Server=tcp:projektprogramowanie.database.windows.net,1433;Initial Catalog=projekt;Persist Security Info=False;User ID=piso101;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void daneuser_Load(object sender, EventArgs e)
        {
            string username = Form1.username;
            string user_password = Form1.user_password;

            string command = "SELECT imie,nazwisko,email FROM users WHERE login_text = '" + username + "' AND haslo = '" + user_password + "'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(command, cn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();

            string user_name = "";
            string user_surname = "";
            string user_email = "";

            while (reader.Read())
            {
                user_name = reader["imie"].ToString();
                user_surname = reader["nazwisko"].ToString();
                user_email = reader["email"].ToString();

            }
            reader.Close();
            label1.Text = user_name;
            label2.Text = user_surname;
            label3.Text = user_email;
            label4.Text = user_password;
            label5.Text = username;

            cn.Close();
        }
    }   
}
