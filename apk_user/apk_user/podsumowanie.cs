using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace apk_user
{
    public partial class podsumowanie : UserControl
    {
        public podsumowanie()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void podsumowanie_Load(object sender, EventArgs e)
        {
            

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.Visible = false;
            
        }

        private void podsumowanie_VisibleChanged(object sender, EventArgs e)
        {
            
            lb1.Text = wyszlotow.price + " PLN";
            lb2.Text = wyszlotow.dest;
            lb3.Text = wyszlotow.arri;
            lb4.Text = wyszlotow.date;
            lb5.Text = wyszlotow.seat.ToString();

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
