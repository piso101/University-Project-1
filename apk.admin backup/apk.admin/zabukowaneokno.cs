using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace apk.admin
{
    public partial class zabukowaneokno : UserControl
    {
        public zabukowaneokno()
        {
            InitializeComponent();
        }

        private void zabukowaneokno_Load(object sender, EventArgs e)
        {
            //polaczenie z baza danych:
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Server=tcp:projektprogramowanie.database.windows.net,1433;Initial Catalog=projekt;Persist Security Info=False;User ID=piso101;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            //tworze komende update by zaktualizowac kolumne cena biletu w bazie danych tabeli zabukowane
            SqlCommand cmdd = new SqlCommand();
            con.Open();
            cmdd.Connection = con;
            cmdd.CommandText = "UPDATE zabukowane\r\nSET cenabiletu = zabukowane.cenabagazu + loty.cena\r\nFROM zabukowane \r\nINNER JOIN loty on  zabukowane.idlotu = loty.idlotu\r\nINNER JOIN users on zabukowane.userid = users.userid";
            //con.Open();
            cmdd.ExecuteNonQuery();
            con.Close();

            //tworze polaczenie z baza danych

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = @"Server=tcp:projektprogramowanie.database.windows.net,1433;Initial Catalog=projekt;Persist Security Info=False;User ID=piso101;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            conn.Open();
            //tworze komende select i odwoluje ja do bazy danych
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT users.imie,users.nazwisko, dbo.loty.skad,loty.dokad,loty.dataodlotu,loty.cena,zabukowane.cenabagazu,zabukowane.cenabiletu\r\nFROM users, loty,zabukowane\r\nWHERE zabukowane.idlotu = loty.idlotu AND zabukowane.userid = users.userid";
            //tworze baze danych wewnetrzna zeby miec gdzie tymczasowo przetrzymac te informacje od bazy danych
            DataTable data = new DataTable();
            //adapter uzupelnia tymczasowa baze danych
            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            adapter.Fill(data);
            //pokazuje baze danych w datagridview
            dataGridView1.DataSource = data;
            conn.Close();
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void odswiezbtn_Click(object sender, EventArgs e)
        {
            try
            {
                //odsiwezam baze danych w relacji o cene lotow ktora mogla byc zmieniona w czasie dzialania programu
                //polaczenie z baza danych:
                SqlConnection con = new SqlConnection();
                con.ConnectionString = @"Server=tcp:projektprogramowanie.database.windows.net,1433;Initial Catalog=projekt;Persist Security Info=False;User ID=piso101;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                //tworze komende update by zaktualizowac kolumne cena biletu w bazie danych tabeli zabukowane
                SqlCommand cmdd = new SqlCommand();
                con.Open();
                cmdd.Connection = con;
                cmdd.CommandText = "UPDATE zabukowane\r\nSET cenabiletu = zabukowane.cenabagazu + loty.cena\r\nFROM zabukowane \r\nINNER JOIN loty on  zabukowane.idlotu = loty.idlotu\r\nINNER JOIN users on zabukowane.userid = users.userid";
                cmdd.ExecuteNonQuery();
                con.Close();
            }
            catch
            {
                MessageBox.Show("Błąd połączenia");
            }

            //odswiezam baze danych..

            try
            {
                //tworze polaczenie z baza danych
                SqlConnection conn = new SqlConnection();
                conn.ConnectionString = @"Server=tcp:projektprogramowanie.database.windows.net,1433;Initial Catalog=projekt;Persist Security Info=False;User ID=piso101;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                //tworze komende select i odwoluje ja do bazy danych
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT users.imie,users.nazwisko, dbo.loty.skad,loty.dokad,loty.dataodlotu,loty.cena,zabukowane.cenabagazu,zabukowane.cenabiletu\r\nFROM users, loty,zabukowane\r\nWHERE zabukowane.idlotu = loty.idlotu AND zabukowane.userid = users.userid";
                //tworze baze danych wewnetrzna zeby miec gdzie tymczasowo przetrzymac te informacje od bazy danych
                DataTable data = new DataTable();
                //adapter uzupelnia tymczasowa baze danych
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                //pokazuje baze danych w datagridview
                dataGridView1.DataSource = data;
            }
            catch
            {
                MessageBox.Show("Błąd połączenia");
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}