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
    public partial class loty_wyszukiwarka : UserControl
    {
        
        public loty_wyszukiwarka()
        {
            InitializeComponent();
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = @"Server=tcp:projektprogramowanie.database.windows.net,1433;Initial Catalog=projekt;Persist Security Info=False;User ID=piso101;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
            cn.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT * FROM loty", cn);
            DataTable dt2 = new DataTable();
            da1.Fill(dt2);
            skadbox.DataSource = dt2;
            skadbox.DisplayMember = "skad";
            skadbox.ValueMember = "idlotu";
            dokadbox.DataSource = dt2;
            dokadbox.DisplayMember = "dokad";
            dokadbox.ValueMember = "idlotu";

        }
        
            
        

        private void loadbtn_Click(object sender, EventArgs e)
        {
            

            try
            {
                //polaczenie z baza danych:
                SqlConnection cn = new SqlConnection();
                cn.ConnectionString = @"Server=tcp:projektprogramowanie.database.windows.net,1433;Initial Catalog=projekt;Persist Security Info=False;User ID=piso101;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";
                //tworze komende update by zaktualizowac kolumne cena biletu w bazie danych tabeli zabukowane
                cn.Open();
                
                
                //tworze komende select i odwoluje ja do bazy danych
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT loty.idlotu,loty.skad,loty.dokad,loty.dataodlotu, loty.dlugosclotu, loty.cena,loty.dostepnemiejsca\r\nFROM loty\r\nWHERE loty.dostepnemiejsca>0 AND loty.dataodlotu BETWEEN @fromdate AND @todate";
                cmd.Parameters.AddWithValue("@fromdate", fromdate.Value);
                cmd.Parameters.AddWithValue("@todate", todate.Value);
                //tworze baze danych wewnetrzna zeby miec gdzie tymczasowo przetrzymac te informacje od bazy danych
                DataTable data = new DataTable();
                //adapter uzupelnia tymczasowa baze danych
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                //pokazuje baze danych w datagridview
                dataGridView1.DataSource = data;
                cn.Close();


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
    }
}
