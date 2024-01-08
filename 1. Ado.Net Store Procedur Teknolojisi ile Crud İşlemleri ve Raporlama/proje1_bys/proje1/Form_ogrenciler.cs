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
    public partial class Form_ogrenciler : Form
    {
        public Form_ogrenciler()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Server=DESKTOP-SHR3BDU; Database=BYS; uid=sa; pwd=376914;");

        public void OgrListele()
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "ogrListele";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1_ogr.DataSource = dt;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            OgrListele();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand ekle = new SqlCommand();
            ekle.Connection = conn;
            ekle.CommandType = CommandType.StoredProcedure;
            ekle.CommandText = "ogrEkle";

            ekle.Parameters.AddWithValue("ogrNo", textBox4.Tag);
            ekle.Parameters.AddWithValue("ad", textBox4.Text);
            ekle.Parameters.AddWithValue("soyad", textBox3.Text);
            ekle.Parameters.AddWithValue("fakulte", textBox9.Text);
            ekle.Parameters.AddWithValue("bolum", textBox11.Text);
            ekle.Parameters.AddWithValue("sinif", textBox8.Text);
            ekle.Parameters.AddWithValue("danisman", textBox2.Text);
            ekle.Parameters.AddWithValue("mail", textBox5.Text);
            ekle.Parameters.AddWithValue("telefon", textBox6.Text);
            ekle.Parameters.AddWithValue("yas", textBox1.Text);
            ekle.ExecuteNonQuery();
            conn.Close();

            OgrListele();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand ekle = new SqlCommand();
            ekle.Connection = conn;
            ekle.CommandType = CommandType.StoredProcedure;
            ekle.CommandText = "ogrGüncelle";

            ekle.Parameters.AddWithValue("ogrNo", textBox4.Tag);

            ekle.Parameters.AddWithValue("ad", textBox4.Text);
            ekle.Parameters.AddWithValue("soyad", textBox3.Text);
            ekle.Parameters.AddWithValue("fakulte", textBox9.Text);
            ekle.Parameters.AddWithValue("bolum", textBox11.Text);
            ekle.Parameters.AddWithValue("sinif", textBox8.Text);
            ekle.Parameters.AddWithValue("danisman", textBox2.Text);
            ekle.Parameters.AddWithValue("mail", textBox5.Text);
            ekle.Parameters.AddWithValue("telefon", textBox6.Text);
            ekle.Parameters.AddWithValue("yas", textBox1.Text);
            ekle.ExecuteNonQuery();
            conn.Close();

            OgrListele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand sil = new SqlCommand();
            sil.Connection = conn;
            sil.CommandType = CommandType.StoredProcedure;
            sil.CommandText = "ogrSil";
            sil.Parameters.AddWithValue("ogrNo", textBox4.Tag);
            sil.ExecuteNonQuery();
            conn.Close();

            OgrListele();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "ogrAra";

            komut.Parameters.AddWithValue("ogrNo", textBox4.Tag);

            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1_ogr.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "ogrAraSinif";

            komut.Parameters.AddWithValue("sinif", textBox8.Text);

            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1_ogr.DataSource = dt;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "ogrListeleBolum";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1_ogr.DataSource = dt;
        }

        private void button2_anaDon_Click(object sender, EventArgs e)
        {
            Form_senecekler s1 = new Form_senecekler();
            s1.Show();
            this.Hide();
        }

        private void button_Click(object sender, EventArgs e)
        {
            Form1_giris g1 = new Form1_giris();
            g1.Show();
            this.Hide();
        }

        private void dataGridView1_ogr_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1_ogr.CurrentRow;

            textBox4.Tag = satir.Cells["ogrNo"].Value.ToString();
            textBox4.Text = satir.Cells["ad"].Value.ToString();
            textBox3.Text = satir.Cells["soyad"].Value.ToString();
            textBox9.Text = satir.Cells["fakulte"].Value.ToString();
            textBox11.Text = satir.Cells["bolum"].Value.ToString();
            textBox8.Text = satir.Cells["sinif"].Value.ToString();
            textBox2.Text = satir.Cells["danisman"].Value.ToString();
            textBox5.Text = satir.Cells["mail"].Value.ToString();
            textBox6.Text = satir.Cells["telefon"].Value.ToString();
            textBox1.Text = satir.Cells["yas"].Value.ToString();
        }

        private void dataGridView1_ogr_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1_ogr.CurrentRow;

            textBox4.Tag = satir.Cells["ogrNo"].Value.ToString();
            textBox4.Text = satir.Cells["ad"].Value.ToString();
            textBox3.Text = satir.Cells["soyad"].Value.ToString();
            textBox9.Text = satir.Cells["fakulte"].Value.ToString();
            textBox11.Text = satir.Cells["bolum"].Value.ToString();
            textBox8.Text = satir.Cells["sinif"].Value.ToString();
            textBox2.Text = satir.Cells["danisman"].Value.ToString();
            textBox5.Text = satir.Cells["mail"].Value.ToString();
            textBox6.Text = satir.Cells["telefon"].Value.ToString();
            textBox1.Text = satir.Cells["yas"].Value.ToString();
        }

        private void Form_ogrenciler_Load(object sender, EventArgs e)
        {

        }
    }
}
