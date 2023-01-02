using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

//biblioteki^^

namespace login
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //ustalamy kod poloczenia z baza danych
        private SqlConnection conn = new SqlConnection(@"Server=tcp:projektprogramowanie.database.windows.net,1433;Initial Catalog=projekt;Persist Security Info=False;User ID=piso101;Password=Password1!;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;");

        public void check_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            progresladowania.Value = 0;
            login.Focus();  //nie wiemy o conb
            String username, user_password;
            Boolean admincheck;
            username = login.Text;
            user_password = password.Text;
            admincheck = true;
            progresladowania.Value = 50;
            try//tutaj uzywamy try poniewaz poloczenie baza danych moze sie nie udac gdy nie ma internetu albo gdy nie mozna wybrac z bazy danych odpowienich komponentow
            {   //tutaj komenda querry bierze z bazy danych login i haslo
                String querry = "SELECT * FROM users WHERE login_text = '" + login.Text + "' AND haslo = '" + password.Text + "' AND czyadmin ='" + admincheck + "'";
                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);//tworzymy adapter by pozniej stworzyc baze danych i wypchac ją danymi pobranymi z komendy powyzej
                DataTable dtable = new DataTable();
                sda.Fill(dtable);
                progresladowania.Value =75;
                if (admincheck == true)//sprawdzamy czy dany uzytkownik ma usera
                {
                    if (dtable.Rows.Count > 0)//sprawdzamy czy w bazie danych utworzonej przez nas jest cokolwiek
                    {
                        progresladowania.Value = 100;
                        username = login.Text;
                        user_password = password.Text;
                        admincheck = true;
                        Cursor.Current = Cursors.Default;
                        apk.admin.Form1 f1 = new apk.admin.Form1();
                        f1.Show();//otwiramy baze danych admina poprzez odnosnik f1
                    }
                    else
                    {
                        admincheck = false;
                        querry = "SELECT * FROM users WHERE login_text = '" + login.Text + "' AND haslo = '" + password.Text + "' AND czyadmin ='" + admincheck + "'";//tworzymy kolejne zapytanie do bazy danych tylko teraz szuka linijki z admincheck = false
                        sda = new SqlDataAdapter(querry, conn);
                        dtable = new DataTable();
                        sda.Fill(dtable);
                        progresladowania.Value =50;
                        if (dtable.Rows.Count > 0)//jezeli w nowo zrobionej database jest cokolwiek to idz dalej
                        {
                            username = login.Text;
                            user_password = password.Text;
                            admincheck = false;
                            Cursor.Current = Cursors.Default;
                            progresladowania.Value = 100;
                            apk_user.Form1 f2 = new apk_user.Form1();
                            string a = username;
                            string b = user_password;
                            f2.userdisplay(a.ToString(), b.ToString());
                            f2.Show();//otwiramy user apk poprzez odnosnik f2
                        }
                        else//jezeli nie to blad
                        {
                            MessageBox.Show("nieprawidłowy login lub hasło", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            login.Clear();
                            password.Clear();
                            login.Focus();
                            Cursor.Current = Cursors.Default;
                            progresladowania.Value = 0;
                        }
                    }
                }
            }

            catch//jezeli sie nie udalo to pokaz blad
            {
                MessageBox.Show("nieprawidłowy login lub hasło");
                Cursor.Current = Cursors.Default;
            }
            finally//zamknij polaczenie z baza danych
            {
                conn.Close();
            }
        }
        

        private void password_MouseHover(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = false;//pokaz haslo zastepujac kropki haslem
        }

        private void registeruser_Click(object sender, EventArgs e)
        {
            register_ui.Show();//pokaz okno register
            register_ui.BringToFront();
        }

        private void Form1_Load(object sender, EventArgs e)//program laduje sie i ukrywa wszystkie kontrolki register i aplikacje uzytkownika ktora powinna byc przez chlopakow potem zastaapiona i nie powinno sie jej tutaj uzywac...
        {
            register_ui.Hide();
            userapk1.Hide();
        }

        private void password_MouseLeave(object sender, EventArgs e)
        {
            password.UseSystemPasswordChar = true;//ukryj haslo kropkami
        }

        private void register_ui_Load(object sender, EventArgs e)
        {
        }

        private void userapk1_Load(object sender, EventArgs e)
        {
        }

        private void login_TextChanged(object sender, EventArgs e)
        {

        }
    }
}