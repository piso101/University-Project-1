using System;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace apk.admin
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            lotyokno.Hide();
            //lotyoknopoprawa.Hide();
            usersokno.Hide();
            zabukowaneokno1.Show();
            zabukowaneokno1.BringToFront();
            zabukowanebtn.Refresh();
        }

        private void lotybtn_Click(object sender, EventArgs e)
        {
            usersokno.Hide();
            zabukowaneokno1.Hide();
            //dzialanie przyciskow ktore zmieniaja widok wyswietlanej aktualnie bazydanych
            lotyokno.Show();                                        //poprzez przesuwanie ich na spód
            lotyokno.BringToFront();
            //lotyoknopoprawa.Show();
            //lotyoknopoprawa.BringToFront();
        }

        private void usersbtn_Click(object sender, EventArgs e)
        {
            lotyokno.Hide();
            zabukowaneokno1.Hide();
            usersokno.Show();
            usersokno.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //polaczenie z baza danych:
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=tcp:projektprogramowanie.database.windows.net,1433;Initial Catalog=projekt;Persist Security Info=False;User ID=piso101;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //tworze komende update by zaktualizowac kolumne cena biletu w bazie danych tabeli zabukowane
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "UPDATE zabukowane\r\nSET cenabiletu = zabukowane.cenabagazu + loty.cena\r\nFROM zabukowane \r\nINNER JOIN loty on  zabukowane.idlotu = loty.idlotu\r\nINNER JOIN users on zabukowane.userid = users.userid";
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
        }

        private void usersokno_Load(object sender, EventArgs e)
        {
        }

        private void odswiezbtn_Click(object sender, EventArgs e)
        {
        }
    }
}