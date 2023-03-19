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
    public partial class Form1 : Form
    {
        SqlConnection con = new SqlConnection("Data Source =LAPTOP-GDI4675J;Initial Catalog=Market;Integrated Security= True");
        SqlDataReader dr;
        SqlCommand com;
        public Form1()
        {
            

            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form3 form3 = new Form3();
            form3.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String user = textBox1.Text;
            String password= textBox2.Text;
            com = new SqlCommand();
            con.Open();
            com.Connection = con;
            com.CommandText ="Select*From parola where Ad='"+textBox1.Text+"'And Sifre='" +textBox2.Text+"'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                Form2 fr = new Form2();
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı Giriş Yaptınız.");
            }
            con.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin")
            {
                button3.Enabled = true;
            }
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
            this.Hide();
        }
    }
}

