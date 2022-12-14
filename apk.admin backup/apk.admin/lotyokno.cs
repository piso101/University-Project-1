using System;
using System.Windows.Forms;

namespace apk.admin
{
    public partial class lotypoprawa2 : UserControl
    {
        public lotypoprawa2()
        {
            InitializeComponent();
        }

        private void lotyBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.lotyBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.projektDataSet);//uzupelnia najnowszymi danymi od bazy danych
        }

        private void lotypoprawa2_Load(object sender, EventArgs e)
        {
            this.lotyTableAdapter.Fill(this.projektDataSet.loty);
        }

        private void odswiezbtn_Click(object sender, EventArgs e)
        {
            this.lotyTableAdapter.Fill(this.projektDataSet.loty);// przycisk odswiez odswieza dane z baazy danych
            this.lotyTableAdapter.Fill(this.projektDataSet.loty);
        }
    }
}