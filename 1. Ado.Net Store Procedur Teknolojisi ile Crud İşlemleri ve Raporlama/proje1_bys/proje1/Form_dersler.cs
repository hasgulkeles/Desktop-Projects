using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace proje1
{
    public partial class Form_dersler : Form
    {
        public Form_dersler()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Server=DESKTOP-SHR3BDU; Database=BYS; uid=sa; pwd=376914;");

        public void DersListele()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "dersListele";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1_ders.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            DersListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand ekle = new SqlCommand();
            ekle.Connection = conn;
            ekle.CommandType = CommandType.StoredProcedure;
            ekle.CommandText = "dersEkle";

            ekle.Parameters.AddWithValue("dersNo", textBox4.Tag);
            ekle.Parameters.AddWithValue("dersAdi", textBox4.Text);
            ekle.Parameters.AddWithValue("kredi", textBox3.Text);
            ekle.Parameters.AddWithValue("zorunlu", textBox11.Text);
            ekle.Parameters.AddWithValue("dili", textBox8.Text);
            ekle.Parameters.AddWithValue("yil", textBox2.Text);
            ekle.Parameters.AddWithValue("donem", textBox9.Text);
            ekle.Parameters.AddWithValue("saat", textBox5.Text);
            ekle.Parameters.AddWithValue("ogrNo", textBox6.Text);
            ekle.Parameters.AddWithValue("akademisyenNo", textBox1.Text);
            ekle.ExecuteNonQuery();
            conn.Close();

            DersListele();
        }

        private void button3_Click(object sender, EventArgs e) //güncelle
        {
            conn.Open();

            SqlCommand ekle = new SqlCommand();
            ekle.Connection = conn;
            ekle.CommandType = CommandType.StoredProcedure;
            ekle.CommandText = "dersGüncelle";

            ekle.Parameters.AddWithValue("dersNo", textBox4.Tag);
            ekle.Parameters.AddWithValue("dersAdi", textBox4.Text);
            ekle.Parameters.AddWithValue("kredi", textBox3.Text);
            ekle.Parameters.AddWithValue("zorunlu", textBox11.Text);
            ekle.Parameters.AddWithValue("dili", textBox8.Text);
            ekle.Parameters.AddWithValue("yil", textBox2.Text);
            ekle.Parameters.AddWithValue("donem", textBox9.Text);
            ekle.Parameters.AddWithValue("saat", textBox5.Text);
            ekle.Parameters.AddWithValue("ogrNo", textBox6.Text);
            ekle.Parameters.AddWithValue("akademisyenNo", textBox1.Text);
            ekle.ExecuteNonQuery();
            conn.Close();

            DersListele();
        }

        private void button4_Click(object sender, EventArgs e) //sil
        {
            conn.Open();

            SqlCommand sil = new SqlCommand();
            sil.Connection = conn;
            sil.CommandType = CommandType.StoredProcedure;
            sil.CommandText = "dersSilme";
            sil.Parameters.AddWithValue("dersNo", textBox4.Tag);
            sil.ExecuteNonQuery();
            conn.Close();

            DersListele();
        }

        private void button3_anaDon_Click(object sender, EventArgs e)
        {
            Form_senecekler s1 = new Form_senecekler();
            s1.Show();
            this.Hide();
        }

        private void button88_Click(object sender, EventArgs e)
        {
            Form1_giris g1 = new Form1_giris();
            g1.Show();
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "dersAraAd";

            komut.Parameters.AddWithValue("dersAdi", textBox4.Text);

            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1_ders.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "dersAraYilveDonem";

            komut.Parameters.AddWithValue("yil", textBox2.Text);
            komut.Parameters.AddWithValue("donem", textBox9.Text);

            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1_ders.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "dersSiralaYilveDonem";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1_ders.DataSource = dt;
        }

        private void dataGridView1_ders_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1_ders.CurrentRow;

            textBox4.Tag = satir.Cells["dersNo"].Value.ToString();
            textBox4.Text = satir.Cells["dersAdi"].Value.ToString();
            textBox3.Text = satir.Cells["kredi"].Value.ToString();
            textBox11.Text = satir.Cells["zorunlu"].Value.ToString();
            textBox8.Text = satir.Cells["dili"].Value.ToString();
            textBox2.Text = satir.Cells["yil"].Value.ToString();
            textBox9.Text = satir.Cells["donem"].Value.ToString();
            textBox5.Text = satir.Cells["saat"].Value.ToString();
            textBox6.Text = satir.Cells["ogrNo"].Value.ToString();
            textBox1.Text = satir.Cells["akademisyenNo"].Value.ToString();
        }

        private void dataGridView1_ders_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1_ders.CurrentRow;

            textBox4.Tag = satir.Cells["dersNo"].Value.ToString();
            textBox4.Text = satir.Cells["dersAdi"].Value.ToString();
            textBox3.Text = satir.Cells["kredi"].Value.ToString();
            textBox11.Text = satir.Cells["zorunlu"].Value.ToString();
            textBox8.Text = satir.Cells["dili"].Value.ToString();
            textBox2.Text = satir.Cells["yil"].Value.ToString();
            textBox9.Text = satir.Cells["donem"].Value.ToString();
            textBox5.Text = satir.Cells["saat"].Value.ToString();
            textBox6.Text = satir.Cells["ogrNo"].Value.ToString();
            textBox1.Text = satir.Cells["akademisyenNo"].Value.ToString();
        }
    }
}
