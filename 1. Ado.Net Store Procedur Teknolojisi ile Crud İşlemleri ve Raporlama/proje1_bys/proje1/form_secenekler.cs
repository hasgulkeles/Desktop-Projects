using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proje1
{
    public partial class Form_senecekler : Form
    {
        public Form_senecekler()
        {
            InitializeComponent();
        }

        

        private void button_akademisyen_Click(object sender, EventArgs e)
        {
            akademisyen_form a1 = new akademisyen_form();
            a1.Show();
            this.Hide();
        }

        private void button_cikis_Click(object sender, EventArgs e)
        {
            //Application.Exit();
            Form1_giris don = new Form1_giris();
            don.Show();
            this.Hide();
        }

        private void button_ogr_Click(object sender, EventArgs e)
        {
            Form_ogrenciler o1 = new Form_ogrenciler();
            o1.Show();
            this.Hide();
        }

        private void button_ders_Click(object sender, EventArgs e)
        {
            Form_dersler d1 = new Form_dersler();
            d1.Show();
            this.Hide();
        }
    }
}
