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
    public partial class Form4 : Form
    {
        static string constring = ("Data Source =LAPTOP-GDI4675J;Initial Catalog=Market;Integrated Security= True");
        SqlConnection con = new SqlConnection(constring);
        SqlCommand com;
        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            com = new SqlCommand();
            con.Open();

            string kayit = "update urunler set domatesFiyat=@df,domatesAdet=@da,salatalıkFiyat=@sf,salatalıkAdet=@sa,mantarFiyat=@mf,mantarAdet=@ma,patatesFiyat=@pf,patatesAdet=@pa,cilekFiyat=@cf,cilekAdet=@ca,elmaFiyat=@ef,elmaAdet=@ea,portakalFiyat=@pof,portakalAdet=@poa,kiviFiyat=@kf,kiviAdet=@ka,makarnaFiyat=@maf,makarnaAdet=@maa,pirincFiyat=@prf,pirincAdet=@pra,corbaFiyat=@cof,corbaAdet=@coa,salcaFiyat=@saf,salcaAdet=@saa,etFiyat=@etf,etAdet=@eta,tavukFiyat=@tf,tavukAdet=@ta,unFiyat=@uf,unAdet=@ua,yagFiyat=@yf,yagAdet=@ya,suFiyat=@suf,suAdet=@sua,meyveFiyat=@mef,meyveAdet=@mea,sutFiyat=@sutf,sutAdet=@suta,kolaFiyat=@kof,kolaAdet=@koa,enerjiFiyat=@enf,enerjiAdet=@ena,kahveFiyat=@kahf,kahveAdet=@kaha,cayFiyat=@cayf,cayAdet=@caya,madenFiyat=@madf,madenAdet=@mada";
            SqlCommand komut = new SqlCommand(kayit, con);

            komut.Parameters.AddWithValue("@df", textBox1.Text);
            komut.Parameters.AddWithValue("@da", textBox2.Text);
            komut.Parameters.AddWithValue("@sf", textBox3.Text);
            komut.Parameters.AddWithValue("@sa", textBox4.Text);
            komut.Parameters.AddWithValue("@mf", textBox5.Text);
            komut.Parameters.AddWithValue("@ma", textBox6.Text);
            komut.Parameters.AddWithValue("@pf", textBox7.Text);
            komut.Parameters.AddWithValue("@pa", textBox8.Text);
            komut.Parameters.AddWithValue("@cf", textBox9.Text);
            komut.Parameters.AddWithValue("@ca", textBox10.Text);
            komut.Parameters.AddWithValue("@ef", textBox11.Text);
            komut.Parameters.AddWithValue("@ea", textBox12.Text);
            komut.Parameters.AddWithValue("@pof", textBox13.Text);
            komut.Parameters.AddWithValue("@poa", textBox14.Text);
            komut.Parameters.AddWithValue("@kf", textBox15.Text);
            komut.Parameters.AddWithValue("@ka", textBox16.Text);
            komut.Parameters.AddWithValue("@maf", textBox17.Text);
            komut.Parameters.AddWithValue("@maa", textBox18.Text);
            komut.Parameters.AddWithValue("@prf", textBox19.Text);
            komut.Parameters.AddWithValue("@pra", textBox20.Text);
            komut.Parameters.AddWithValue("@cof", textBox21.Text);
            komut.Parameters.AddWithValue("@coa", textBox22.Text);
            komut.Parameters.AddWithValue("@saf", textBox23.Text);
            komut.Parameters.AddWithValue("@saa", textBox24.Text);
            komut.Parameters.AddWithValue("@etf", textBox25.Text);
            komut.Parameters.AddWithValue("@eta", textBox26.Text);
            komut.Parameters.AddWithValue("@tf", textBox27.Text);
            komut.Parameters.AddWithValue("@ta", textBox28.Text);
            komut.Parameters.AddWithValue("@uf", textBox29.Text);
            komut.Parameters.AddWithValue("@ua", textBox30.Text);
            komut.Parameters.AddWithValue("@yf", textBox31.Text);
            komut.Parameters.AddWithValue("@ya", textBox32.Text);
            komut.Parameters.AddWithValue("@suf", textBox33.Text);
            komut.Parameters.AddWithValue("@sua", textBox34.Text);
            komut.Parameters.AddWithValue("@mef", textBox35.Text);
            komut.Parameters.AddWithValue("@mea", textBox36.Text);
            komut.Parameters.AddWithValue("@sutf", textBox37.Text);
            komut.Parameters.AddWithValue("@suta", textBox38.Text);
            komut.Parameters.AddWithValue("@kof", textBox39.Text);
            komut.Parameters.AddWithValue("@koa", textBox40.Text);
            komut.Parameters.AddWithValue("@enf", textBox41.Text);
            komut.Parameters.AddWithValue("@ena", textBox42.Text);
            komut.Parameters.AddWithValue("@kahf", textBox43.Text);
            komut.Parameters.AddWithValue("@kaha", textBox44.Text);
            komut.Parameters.AddWithValue("@cayf", textBox45.Text);
            komut.Parameters.AddWithValue("@caya", textBox46.Text);
            komut.Parameters.AddWithValue("@madf", textBox47.Text);
            komut.Parameters.AddWithValue("@mada", textBox48.Text);
            
            komut.ExecuteNonQuery();
            con.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox26_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox25_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox27_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
