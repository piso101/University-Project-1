using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace login
{
    public partial class register_ui : UserControl
    {
        //podstawowe poloczenie z baza danych
        private SqlConnection conn = new SqlConnection(@"Server=tcp:projektprogramowanie.database.windows.net,1433;Initial Catalog=projekt;Persist Security Info=False;User ID=piso101;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public register_ui()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {//chowamy okno register
            this.SendToBack();
            this.Hide();
        }

        private bool IsValidEmail(string email)
        {
            var trimmedEmail = email.Trim();//usuwa wszystkie white characters takie jak spacje etc. zeby program mogl zczytac mimo tego ze uzytkownik mogl sie pomylic i wstawic spacje
            if (trimmedEmail.EndsWith("."))//sprawdzamy czy koniec emaila jest rowny . bo wtedy na pewno to nie email
            {
                return false;
            }
            try
            {
                var addr = new System.Net.Mail.MailAddress(email);//system net mail mailadress sprawdza czy email ma charakter emailu czy jest zwyklym tekstem(wypluwa wartosc null jezeli to nie email)
                return addr.Address == trimmedEmail;//porownujemy mail sprawdzony do tego co podal uzytkownik
            }
            catch
            {
                return false;
            }
        }

        private void registernewuser_Click(object sender, EventArgs e)
        {
            String logint, passwordt, emailt, namet, surnamet;
            logint = logintxt.Text;
            passwordt = passwordtxt.Text;
            emailt = emailtxt.Text;
            namet = nametxt.Text;
            surnamet = surnametxt.Text;

            //otwieram polaczenie z serwerem by sprawdzic czy login jest juz w bazie danych czy nie
            conn.Open();
            SqlCommand command = conn.CreateCommand();
            command.CommandText = "Select login_text from users where login_text=@name";//wynbieram wszystkie wartosci ktore sa rowne loginowi
            command.Parameters.AddWithValue("@name", logint);//tutaj @name ustawiam na login
            SqlDataAdapter sda = new SqlDataAdapter(command);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            conn.Close();

            //tutaj sprawdzane jest czy wszystkie miejsca textowe sa zapelnione czy email to email a nie jakis tekst i czy login nie jest juz w bazie danych
            if ((passwordt != "") && (emailt != "") && (logint != "") && (namet != "") && (surnamet != "") && IsValidEmail(emailt) == true && dt.Rows.Count <= 0)
            {
                //ustalamy komende do wsadzenia do bazdy danych wszystkich tekstow z rejestracji
                SqlCommand cmd = new SqlCommand("INSERT INTO users(login_text,haslo,imie,nazwisko,email,czyadmin) VALUES('" + logint + "','" + passwordt + "','" + namet + "','" + surnamet + "','" + emailt + "'," + "0" + ")", conn);
                conn.Open();//otwieramy polaczenie

                var i = cmd.ExecuteNonQuery();//uruchamamy komende

                conn.Close();

                if (i != 0)
                {
                    MessageBox.Show("Zarejestrowano pomyślnie", "Zarejestrowano", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("nieprawidłowe dane logowanie", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void passwordtxt_MouseLeave(object sender, EventArgs e)
        {
            passwordtxt.UseSystemPasswordChar = true;//ustawiamy ukrywanie hasla ktore zamienia je na charakterystyczne kropki
        }

        private void passwordtxt_MouseHover(object sender, EventArgs e)
        {
            passwordtxt.UseSystemPasswordChar = false;//ustawiamy ukrywanie hasla ktore zamienia je na charakterystyczne kropki
        }
    }
}