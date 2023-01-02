using System;
using System.Windows.Forms;

namespace apk.admin
{
    public partial class usersokno : UserControl
    {
        public usersokno()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            //this.tableAdapterManager.UpdateAll(this.projektDataSet);//ustawia na poczatku dane z bazy danych
            this.usersTableAdapter.Update(this.projektDataSet);
        }

        private void usersDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void usersokno_Load(object sender, EventArgs e)
        {
            //uzupelnia adapterem datagridview stworzony przez projektanta
            this.usersTableAdapter.Fill(this.projektDataSet.users);
            //string imie;
            //imie = projektDataSet.users[0]["imie",DataRowVersion.Original].ToString();
        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {
        }

        private void odswiezbtn_Click(object sender, EventArgs e)
        {
            this.usersTableAdapter.Fill(this.projektDataSet.users);
            this.usersTableAdapter.Fill(this.projektDataSet.users);//odsiweza dane z bazy danych
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //this.usersTableAdapter.Fill(this.projektDataSet.users);
            //this.usersTableAdapter.Fill(this.projektDataSet.users);
        }
    }
}