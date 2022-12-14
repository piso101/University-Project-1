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
    public partial class wyszlotow : UserControl
    {
        private SqlConnection cn = new SqlConnection(@"Server=tcp:projektprogramowanie.database.windows.net,1433;Initial Catalog=projekt;Persist Security Info=False;User ID=piso101;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");
        public wyszlotow()
        {
            InitializeComponent();
            cn.Open();
            SqlDataAdapter da1 = new SqlDataAdapter("SELECT DISTINCT loty.skad \r\nFROM loty", cn);
            SqlDataAdapter da2 = new SqlDataAdapter("SELECT DISTINCT loty.dokad \r\nFROM loty", cn);
            DataTable dt_skad = new DataTable();
            DataTable dt_dokad = new DataTable();
            da1.Fill(dt_skad);
            da2.Fill(dt_dokad);
            skadbox.DataSource = dt_skad;
            skadbox.DisplayMember = "skad";
            dokadbox.DataSource = dt_dokad;
            dokadbox.DisplayMember = "dokad";
            cn.Close();

        }

        private void loadbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count > 1)
            {
                dataGridView1.Columns.Remove("Zabukuj");
            }
            try
            {
                //polaczenie z baza danych
                //tworze komende update by zaktualizowac kolumne cena biletu w bazie danych tabeli zabukowane
                cn.Open();


                //tworze komende select i odwoluje ja do bazy danych
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT loty.skad,loty.dokad,loty.dataodlotu, loty.dlugosclotu, loty.cena,loty.dostepnemiejsca\r\nFROM loty\r\nWHERE loty.dostepnemiejsca>0 AND loty.skad = @skad AND loty.dokad = @dokad AND loty.dataodlotu BETWEEN @fromdate AND @todate";
                cmd.Parameters.AddWithValue("@fromdate", fromdate.Value);
                cmd.Parameters.AddWithValue("@todate", todate.Value);
                cmd.Parameters.AddWithValue("@skad", skadbox.Text);
                cmd.Parameters.AddWithValue("@dokad", dokadbox.Text);
                //tworze baze danych wewnetrzna zeby miec gdzie tymczasowo przetrzymac te informacje od bazy danych
                DataTable data = new DataTable();
                //adapter uzupelnia tymczasowa baze danych
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(data);
                //pokazuje baze danych w datagridview
                dataGridView1.DataSource = data;
                
                DataGridViewButtonColumn zabukujbtn = new DataGridViewButtonColumn();
                zabukujbtn.Name = "Zabukuj";
                zabukujbtn.Text = "Zabukuj";
                int len = dataGridView1.Columns.Count;
                dataGridView1.Columns.Insert(len, zabukujbtn);
                cn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void todate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if(dataGridView1.Columns[e.ColumnIndex].Name == "Zabukuj")
            {
                       if(MessageBox.Show("Czy chcesz zabukować ten lot?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question)==DialogResult.Yes)
                       {
                          
                       }
            }
        }
    }
}
