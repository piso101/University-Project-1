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
        public static string username;
        public static string user_password;
        public static int id;
        
        public void Userd_id(string c, string d)
        {
            username = c.ToString();
            user_password = d.ToString();
            string command = "SELECT userid FROM users WHERE login_text = '" + username + "' AND haslo = '" + user_password + "'";
            cn.Open();
            SqlCommand cmd = new SqlCommand(command, cn);
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

        private void loadbtn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Columns.Count > 1)
            {
                dataGridView1.Columns.Remove("Buy");
            }
            try
            {
                //polaczenie z baza danych
                //tworze komende update by zaktualizowac kolumne cena biletu w bazie danych tabeli zabukowane
                cn.Open();


                //tworze komende select i odwoluje ja do bazy danych
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = cn;
                cmd.CommandText = "SELECT loty.idlotu, loty.skad,loty.dokad,loty.dataodlotu, loty.dlugosclotu, loty.cena,loty.dostepnemiejsca\r\nFROM loty\r\nWHERE loty.dostepnemiejsca>0 AND loty.skad = @skad AND loty.dokad = @dokad AND loty.dataodlotu BETWEEN @fromdate AND @todate";
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
                this.dataGridView1.Columns["idlotu"].Visible = false;
                this.dataGridView1.Columns["skad"].HeaderText = "Departure";
                this.dataGridView1.Columns["dokad"].HeaderText = "Destination";
                this.dataGridView1.Columns["dataodlotu"].HeaderText = "From";
                this.dataGridView1.Columns["dlugosclotu"].HeaderText = "Flight Lenght";
                this.dataGridView1.Columns["cena"].HeaderText = "Price";
                this.dataGridView1.Columns["dostepnemiejsca"].HeaderText = "Available Seats";
                DataGridViewButtonColumn zabukujbtn = new DataGridViewButtonColumn();
                zabukujbtn.Name = "Buy";
                zabukujbtn.Text = "Buy";
                zabukujbtn.UseColumnTextForButtonValue = true;
                int len = dataGridView1.Columns.Count;
                dataGridView1.Columns.Insert(len, zabukujbtn);
                
                
                
                cn.Close();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

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
            if (dataGridView1.Columns[e.ColumnIndex].Name == "Buy")
            {
                int cenabagazu = 0;
                bool cenatest = false;
                while(cenatest == false) 
                { 
                    if(cena_bag_box.Text=="")//sprawdza czy cena bagażu została wybrana
                    {
                        MessageBox.Show("Choose your luggage.");
                        return;//Trzeba jakoś zCancelować cały event ale nw jak atm :(
                        
                    }
                    else if(cena_bag_box.Text == "Small - 150 PLN")
                    {
                        cenabagazu = 150;
                        cenatest = true;
                    }
                    else if (cena_bag_box.Text == "Big - 200 PLN")
                    {
                        cenabagazu = 200;
                        cenatest = true;
                    }
                    
                }
                if (MessageBox.Show("Do you want to buy this flight?", "Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {

                    cn.Open();

                    if (e.RowIndex >= 0)
                    {
                        DataGridViewRow row = this.dataGridView1.Rows[e.RowIndex];//pobieramy row który chcemy zabukować
                        //pobieramy informacje z row które potrzebujemy
                        string idlotu = row.Cells["idlotu"].Value.ToString();
                        string cenabiletu = row.Cells["cena"].Value.ToString();
                        string iloscmiejsc = row.Cells["dostepnemiejsca"].Value.ToString();
                        int prc  = int.Parse(cenabiletu) + cenabagazu;
                        price = prc.ToString();
                        dest = row.Cells["skad"].Value.ToString();
                        arri = row.Cells["dokad"].Value.ToString();
                        date = row.Cells["dataodlotu"].Value.ToString();
                        int miejsce = int.Parse(iloscmiejsc);
                        seat = miejsce;

                        SqlCommand cmdinsert = new SqlCommand();
                        cmdinsert.Connection = cn;
                        cmdinsert.CommandText = "INSERT INTO zabukowane (userid,idlotu,miejsce,cenabagazu,cenabiletu) Values (@pam1,@pam2,@pam3,@pam4,@pam5)";
                        //dodajemy wartości do komendy sql
                        cmdinsert.Parameters.AddWithValue("@pam1", id);
                        cmdinsert.Parameters.AddWithValue("@pam2", idlotu);
                        cmdinsert.Parameters.AddWithValue("@pam3", miejsce);
                        cmdinsert.Parameters.AddWithValue("@pam4", cenabagazu);
                        cmdinsert.Parameters.AddWithValue("@pam5", cenabiletu);
                        cmdinsert.CommandType = CommandType.Text;
                        cmdinsert.ExecuteNonQuery();//wykonujemy komende dodania rekordu w tablicy zabukowane

                        miejsce -= 1;//odejmujemy miejsce
                        SqlCommand cmdupdate = new SqlCommand();//tworzymy nową komendę do obniżenia wartości ilości miejsc dla danego lotu
                        cmdupdate.Connection = cn;
                        cmdupdate.CommandText = "UPDATE loty SET dostepnemiejsca = @pam1 WHERE idlotu = @pam2";
                        cmdupdate.Parameters.AddWithValue("@pam1", miejsce);
                        cmdupdate.Parameters.AddWithValue("@pam2", idlotu);
                        cmdupdate.ExecuteNonQuery();// wykonujemy komende
                        podsumowanie1.Show();
                        podsumowanie1.BringToFront();

                        cn.Close();// trzeba zamknąć połączenie przed następną linijką kodu
                        loadbtn.PerformClick();//odświeżamy datagridview aby wyświetlił prawidłową ilość miejsc
                        apk_user.zabukowaneuser f2 = new apk_user.zabukowaneuser();
                        
                        f2.przycisk();

                    }
                }
            }


        }
        public static string price;
        public static string dest;
        public static string arri;
        public static string date;
        public static int seat;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void skadbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dokadbox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void fromdate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        
    }
}
