﻿using System;
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
        

        public void zabukowaneuser_Load(object sender, EventArgs e)
        {
            // pobieramy username i password z głownego form1
            string username = Form1.username;
            string user_password = Form1.user_password;
            // wysyłamy zapytanie o ID usera
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
            reader.Close();
            id = int.Parse(userid);

            button1.PerformClick();
            conn.Close();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }
        public void przycisk()
        {
            // metoda odświerzania schowanym przyciskiem
            button1.PerformClick();
            

        }


        private void button1_Click(object sender, EventArgs e)
        {
            if(conn.State != ConnectionState.Open)
            {
                conn.Open();
            }
            
            //łączymy dwie tabele, zmieniamy nazwy column oraz chowamy niepotrzebne informacje
            SqlCommand cmdid = new SqlCommand();
            cmdid.Connection = conn;
            cmdid.CommandText = "SELECT * \r\nFROM zabukowane\r\n INNER JOIN loty ON zabukowane.idlotu = loty.idlotu WHERE userid = @id";
            
            cmdid.Parameters.AddWithValue("@id", id);

            DataTable data1 = new DataTable();
            SqlDataAdapter adapter1 = new SqlDataAdapter(cmdid);
            adapter1.Fill(data1);
            dataGridView2.DataSource = data1;
            this.dataGridView2.Columns["skad"].HeaderText = "Departure";
            this.dataGridView2.Columns["dokad"].HeaderText = "Destination";
            this.dataGridView2.Columns["dataodlotu"].HeaderText = "From";
            this.dataGridView2.Columns["dlugosclotu"].HeaderText = "Flight Lenght";
            this.dataGridView2.Columns["cenabiletu"].HeaderText = "Price";
            this.dataGridView2.Columns["miejsce"].HeaderText = "Seat Number";
            this.dataGridView2.Columns["dostepnemiejsca"].Visible = false;
            this.dataGridView2.Columns["idlotu1"].Visible = false;
            this.dataGridView2.Columns["idlotu"].Visible = false;
            this.dataGridView2.Columns["userid"].Visible = false;
            this.dataGridView2.Columns["cena"].Visible = false;
            this.dataGridView2.Columns["cenabagazu"].Visible = false;
            conn.Close();
        }
        
    }
}
