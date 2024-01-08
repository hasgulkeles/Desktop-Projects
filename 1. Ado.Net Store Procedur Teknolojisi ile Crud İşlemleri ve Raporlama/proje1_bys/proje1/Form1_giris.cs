using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient; //ADO.net kütüphaneleri eklendi (SQL'e erişmek için)

namespace proje1
{
    public partial class Form1_giris : Form
    {
        public Form1_giris()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection("Server=DESKTOP-SHR3BDU; Database=BYS; uid=sa; pwd=376914;");
               


        private void label4_Click(object sender, EventArgs e)
        {
            groupBox2_kayit.Visible = true;
        }

        private void Form1_giris_Load(object sender, EventArgs e)
        {
            label12.Visible = true;
            groupBox1_giris.Visible = true;
            groupBox2_kayit.Visible = false;

        }

        private void button1_Click(object sender, EventArgs e) //giriş button
        {
            
            SqlCommand kayit = new SqlCommand(); //ado.net içindeki classları kullanmak için ,sql komutları yazabilmek için nesne oluşturduk
            kayit.Connection = conn;  //conn ile sql'e bağlandık
            kayit.CommandType = CommandType.StoredProcedure; //komutumun tipi prosedür( prosedür çağırıp kullanacağım)

            kayit.CommandText = "Giris";  //Giris prosedürü çağırıldı

            //prosedürüm parametreli olduğu için altta parametre çağırıyorum

            kayit.Parameters.AddWithValue("username", textBox1.Text);  //username parametresi gönderildi
            kayit.Parameters.AddWithValue("password", textBox2.Text);  //password parametresi gönderildi

            conn.Open();  //database bağlantısı açıldı

            SqlDataReader dr; //sqldeki dataları oku ve dr'ye at
            dr = kayit.ExecuteReader(); //dataları çalıştırırken tek tek oku (satır satır oku)

            if (dr.Read())  //eğer okuduysa (sqldeki prosedürdeki dataları)
            {
                MessageBox.Show("Giriş başarılı");
                Form_senecekler git = new Form_senecekler();
                git.Show();
                this.Hide();
            }
            else //okuyamadıysa
            {
                MessageBox.Show("Kullanıcı adı ile parolayı eksik ya da hatalı girdiniz!");
                textBox1.Clear();
                textBox2.Clear();
            }

            conn.Close();
        }

        
        private void button2_Click(object sender, EventArgs e) //kayıt button
        {
            conn.Open();
            string query = "SELECT COUNT(*) FROM users WHERE username = @username";
            SqlCommand command = new SqlCommand(query, conn);
            command.Parameters.AddWithValue("@username", textBox9.Text);
            int count = (int)command.ExecuteScalar();

            if (count > 0)
            {
                MessageBox.Show("Girdiğiniz kullanıcı adı zaten kayıtlı.");
            }
            else
            {
                SqlCommand kayit = new SqlCommand();
                kayit.Connection = conn;
                kayit.CommandType = CommandType.StoredProcedure;
                kayit.CommandText = "userKayit";
                kayit.Parameters.AddWithValue("name", textBox4.Text);
                kayit.Parameters.AddWithValue("surname", textBox3.Text);
                kayit.Parameters.AddWithValue("mail", textBox5.Text);
                kayit.Parameters.AddWithValue("telefon", textBox6.Text);
                kayit.Parameters.AddWithValue("birthday", textBox7.Text);
                kayit.Parameters.AddWithValue("tcNo", textBox8.Text);
                kayit.Parameters.AddWithValue("username", textBox9.Text);
                kayit.Parameters.AddWithValue("password", textBox11.Text);
                kayit.ExecuteNonQuery();
                MessageBox.Show("Kayıt başarılı");
                textBox3.Clear();
                textBox4.Clear();
                textBox5.Clear();
                textBox6.Clear();
                textBox7.Clear();
                textBox8.Clear();
                textBox9.Clear();
                textBox11.Clear();
                groupBox2_kayit.Visible = false;
            }

            conn.Close();
        }        
    }
}
