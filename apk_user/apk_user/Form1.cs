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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace apk_user
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            
        }
        private SqlConnection conn = new SqlConnection(@"Server=tcp:projektprogramowanie.database.windows.net,1433;Initial Catalog=projekt;Persist Security Info=False;User ID=piso101;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public static string username;
        public static string user_password;

        public void userdisplay(string a, string b)
        {
            username = a.ToString();
            user_password = b.ToString();
            logindisplay.Text = "Witaj, " + username;
            
            


        }
        public void Form1_Load(object sender, EventArgs e)
        {
        
        }
        

        private void logindisplay_Click(object sender, EventArgs e)
        {

        }

        private void searchbtn_Click(object sender, EventArgs e)
        {
            zabukowaneuser1.Hide();
            wyszlotow1.Show();
            wyszlotow1.BringToFront(); // czeba bedzie zrobic hide dla innyhc okienek 
        }

        private void wyszlotow1_Load(object sender, EventArgs e)
        {
            
        }

        public void mojelotybtn_Click(object sender, EventArgs e)
        {
            wyszlotow1.Hide();
            zabukowaneuser1.Show();
            zabukowaneuser1.BringToFront();
            apk_user.zabukowaneuser f2 = new apk_user.zabukowaneuser();
            string a = username;
            string b = user_password;
            if (a != null)
            {
                f2.userdid(a.ToString(), b.ToString());
            }
            else
            {
                Console.WriteLine("Brak użytkownika");

            }

        }

        private void mojedanebtn_Click(object sender, EventArgs e)
        {

        }

        private void zabukowaneuser1_Load(object sender, EventArgs e)
        {

        }
    }
}
