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

namespace Online_Market
{
    public partial class Form3 : Form
    {
        static string constring= ("Data Source =LAPTOP-GDI4675J;Initial Catalog=Market;Integrated Security= True");
        SqlConnection con = new SqlConnection(constring);
        public Form3()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (con.State==ConnectionState.Closed)
                {
                    con.Open();
                    string kayit = "insert into parola (Ad,Sifre,Email,Telefon)values(@kullaniciadi,@sifre,@email,@telefon)";
                    SqlCommand komut = new SqlCommand(kayit,con);

                    komut.Parameters.AddWithValue("@kullaniciadi", textBox1.Text);
                    komut.Parameters.AddWithValue("@sifre", textBox2.Text);
                    komut.Parameters.AddWithValue("@email", textBox3.Text);
                    komut.Parameters.AddWithValue("@telefon", textBox4.Text);

                    komut.ExecuteNonQuery();

                    MessageBox.Show("Başarıyla Kayıt Olundu. Giriş Yapabilirsiniz.");
                    Form1 fr = new Form1();
                    fr.Show();
                    this.Hide();
                    
                }
            }
            catch (Exception hata)
            {
                MessageBox.Show("Hatalı Kayıt Yaptınız.",hata.Message);
               
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
