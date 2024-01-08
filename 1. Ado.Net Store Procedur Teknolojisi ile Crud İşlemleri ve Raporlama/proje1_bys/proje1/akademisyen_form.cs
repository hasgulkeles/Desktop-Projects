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
    public partial class akademisyen_form : Form
    {
        public akademisyen_form()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Server=DESKTOP-SHR3BDU; Database=BYS; uid=sa; pwd=376914;");

        public void AkademisyenListele()
        {
            SqlCommand listele = new SqlCommand();
            listele.Connection = conn;
            listele.CommandType = CommandType.StoredProcedure;
            listele.CommandText = "akademisyenListele";
            SqlDataAdapter dr = new SqlDataAdapter(listele);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1_akademi.DataSource = dt;
        }

        private void akademisyen_form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AkademisyenListele();
        }

        private void button1_anaDon_Click(object sender, EventArgs e)
        {
            Form_senecekler s1 = new Form_senecekler();
            s1.Show();
            this.Hide();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form1_giris g1 = new Form1_giris();
            g1.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e) //ekle
        {
            conn.Open();

            SqlCommand ekle = new SqlCommand();
            ekle.Connection = conn;
            ekle.CommandType = CommandType.StoredProcedure;
            ekle.CommandText = "akademisyenEkle";

            ekle.Parameters.AddWithValue("sicilNo", textBox4.Tag);
            ekle.Parameters.AddWithValue("ad", textBox4.Text);
            ekle.Parameters.AddWithValue("soyad", textBox3.Text);
            ekle.Parameters.AddWithValue("unvan", textBox9.Text);
            ekle.Parameters.AddWithValue("fakulte", textBox11.Text);
            ekle.Parameters.AddWithValue("alan", textBox8.Text);
            ekle.Parameters.AddWithValue("mail", textBox5.Text);
            ekle.Parameters.AddWithValue("telefon", textBox6.Text);
            ekle.Parameters.AddWithValue("yas", textBox1.Text);
            ekle.ExecuteNonQuery();
            conn.Close();
                       
            AkademisyenListele();
        }

        private void button3_Click(object sender, EventArgs e) //güncelle
        {
            conn.Open();

            SqlCommand ekle = new SqlCommand();
            ekle.Connection = conn;
            ekle.CommandType = CommandType.StoredProcedure;
            ekle.CommandText = "akademisyenGüncelle";

            ekle.Parameters.AddWithValue("sicilNo", textBox4.Tag);

         
            ekle.Parameters.AddWithValue("ad", textBox4.Text);
            ekle.Parameters.AddWithValue("soyad", textBox3.Text);
            ekle.Parameters.AddWithValue("unvan", textBox9.Text);
            ekle.Parameters.AddWithValue("fakulte", textBox11.Text);
            ekle.Parameters.AddWithValue("alan", textBox8.Text);
            ekle.Parameters.AddWithValue("mail", textBox5.Text);
            ekle.Parameters.AddWithValue("telefon", textBox6.Text);
            ekle.Parameters.AddWithValue("yas", textBox1.Text);
            ekle.ExecuteNonQuery();
            conn.Close();

            AkademisyenListele();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            conn.Open();

            SqlCommand sil = new SqlCommand();
            sil.Connection = conn;
            sil.CommandType = CommandType.StoredProcedure;
            sil.CommandText = "akademisyenSil";
            sil.Parameters.AddWithValue("sicilNo", textBox4.Tag);
            sil.ExecuteNonQuery();
            conn.Close();

            AkademisyenListele();

        }

        private void dataGridView1_akademi_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1_akademi.CurrentRow;

            textBox4.Tag = satir.Cells["sicilNo"].Value.ToString();
            textBox4.Text = satir.Cells["ad"].Value.ToString();
            textBox3.Text = satir.Cells["soyad"].Value.ToString();
            textBox9.Text = satir.Cells["unvan"].Value.ToString();
            textBox11.Text = satir.Cells["fakulte"].Value.ToString();
            textBox8.Text = satir.Cells["alan"].Value.ToString();
            textBox5.Text = satir.Cells["mail"].Value.ToString();
            textBox6.Text = satir.Cells["telefon"].Value.ToString();
            textBox1.Text = satir.Cells["yas"].Value.ToString();
        }

        private void button7_Click(object sender, EventArgs e) //fakülte sırala asc
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "akademisyenSiralaFakulte";
            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1_akademi.DataSource = dt;
        }

        private void button6_Click(object sender, EventArgs e) // ad soyad ara
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "akademisyenAraAdSoyad";

            komut.Parameters.AddWithValue("ad", textBox4.Text);
            komut.Parameters.AddWithValue("soyad", textBox3.Text);

            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1_akademi.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand();
            komut.Connection = conn;
            komut.CommandType = CommandType.StoredProcedure;
            komut.CommandText = "akademisyenAraUnvan";

            komut.Parameters.AddWithValue("unvan", textBox9.Text);

            SqlDataAdapter dr = new SqlDataAdapter(komut);
            DataTable dt = new DataTable();
            dr.Fill(dt);
            dataGridView1_akademi.DataSource = dt;
        }

        private void dataGridView1_akademi_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1_akademi.CurrentRow;

            textBox4.Tag = satir.Cells["sicilNo"].Value.ToString();
            textBox4.Text = satir.Cells["ad"].Value.ToString();
            textBox3.Text = satir.Cells["soyad"].Value.ToString();
            textBox9.Text = satir.Cells["unvan"].Value.ToString();
            textBox11.Text = satir.Cells["fakulte"].Value.ToString();
            textBox8.Text = satir.Cells["alan"].Value.ToString();
            textBox5.Text = satir.Cells["mail"].Value.ToString();
            textBox6.Text = satir.Cells["telefon"].Value.ToString();
            textBox1.Text = satir.Cells["yas"].Value.ToString();
        }
    }
    }

