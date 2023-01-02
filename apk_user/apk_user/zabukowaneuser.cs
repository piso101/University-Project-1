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
            

        }
        public static int id;
        private SqlConnection conn = new SqlConnection(@"Server=tcp:projektprogramowanie.database.windows.net,1433;Initial Catalog=projekt;Persist Security Info=False;User ID=piso101;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public static string username;
        public static string user_password;
        public void Userd_id(string a, string b)
        {
            Console.WriteLine("1");
            username = a.ToString();
            user_password = b.ToString();
            string command = "SELECT userid FROM users WHERE login_text = '" + username + "' AND haslo = '" + user_password + "'";
            conn.Open();
            SqlCommand cmd = new SqlCommand(command, conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            string userid = "";

            while (reader.Read())
            {
                userid = reader["userid"].ToString();
            }
            
            id = int.Parse(userid);
            reader.Close();
            

        }

        public void zabukowaneuser_Load(object sender, EventArgs e)
        {
            Console.WriteLine("2");
            

            SqlCommand cmdid = new SqlCommand();
            cmdid.Connection = conn;
            cmdid.CommandText = "SELECT *\r\nFROM zabukowane\r\n WHERE userid = @id ";
            Console.WriteLine(id);
            cmdid.Parameters.AddWithValue("@id", id);

            DataTable data1 = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmdid);
            adapter1.Fill(data1);
            dataGridView2.DataSource = data1;
            conn.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
    }
}
