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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown1.Value + " Adet " + "Domates " + Convert.ToInt32(numericUpDown1.Value) * 2 + "TL" );
            
            int islem = Convert.ToInt32(textBox.Text)+ (Convert.ToInt32(numericUpDown1.Value) * 2);

            textBox.Text =islem.ToString();
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown2.Value + " Adet " + "Salatalık " + Convert.ToInt32(numericUpDown2.Value) * 2 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown2.Value) * 2);

            textBox.Text =islem.ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown3.Value + " Adet " + "Mantar " + Convert.ToInt32(numericUpDown3.Value) * 4 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown3.Value) * 4);

            textBox.Text = islem.ToString();
        }

        private void button4_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown4.Value + " Adet " + "Patates " + Convert.ToInt32(numericUpDown4.Value) * 3 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown4.Value) * 3);

            textBox.Text = islem.ToString();
        }

        private void button5_Click(object sender, EventArgs e)
        {


            listBox1.Items.Add(numericUpDown5.Value + " Adet " + "Çilek " + Convert.ToInt32(numericUpDown5.Value) * 5 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown5.Value) * 5);

            textBox.Text = islem.ToString();
        }

        private void button6_Click(object sender, EventArgs e)
        {
 
            listBox1.Items.Add(numericUpDown6.Value + " Adet " + "Elma " + Convert.ToInt32(numericUpDown6.Value) * 4 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown6.Value) * 4);

            textBox.Text = islem.ToString();
        }

        private void button7_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown7.Value + " Adet " + "Portakal " + Convert.ToInt32(numericUpDown7.Value) * 5 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown7.Value) * 5);

            textBox.Text = islem.ToString();
        }

        private void button8_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown8.Value + " Adet " + "Kivi " + Convert.ToInt32(numericUpDown8.Value) * 6 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown8.Value) * 6);

            textBox.Text = islem.ToString();
        }

        private void button16_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown9.Value + " Adet " + "Makarna " + Convert.ToInt32(numericUpDown9.Value) * 3 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown9.Value) * 3);

            textBox.Text = islem.ToString();
        }

        private void button15_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown10.Value + " Adet " + "Pirinç " + Convert.ToInt32(numericUpDown10.Value) * 5 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown10.Value) * 5);

            textBox.Text = islem.ToString();
        }

        private void button14_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown11.Value + " Adet " + "Çorba " + Convert.ToInt32(numericUpDown11.Value) * 2 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown11.Value) * 2);

            textBox.Text = islem.ToString();
        }

        private void button13_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown12.Value + " Adet " + "Salça " + Convert.ToInt32(numericUpDown12.Value) * 8 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown12.Value) * 8);

            textBox.Text = islem.ToString();
        }

        private void button12_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown13.Value + " Adet " + "Et " + Convert.ToInt32(numericUpDown13.Value) * 45 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown13.Value) * 45);

            textBox.Text = islem.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown14.Value + " Adet " + "Tavuk " + Convert.ToInt32(numericUpDown14.Value) * 30 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown14.Value) * 30);

            textBox.Text = islem.ToString();
        }

        private void button10_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown15.Value + " Adet " + "Un " + Convert.ToInt32(numericUpDown15.Value) * 13 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown15.Value) * 13);

            textBox.Text = islem.ToString();
        }

        private void button9_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown16.Value + " Adet " + "Yağ " + Convert.ToInt32(numericUpDown16.Value) * 80 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown16.Value) * 80);

            textBox.Text = islem.ToString();
        }

        private void button24_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(numericUpDown17.Value + " Adet " + "Su " + Convert.ToInt32(numericUpDown17.Value) * 1 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown17.Value) * 1);

            textBox.Text = islem.ToString();
        }

        private void button23_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown18.Value + " Adet " + "Meyve Suyu " + Convert.ToInt32(numericUpDown18.Value) * 3 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown18.Value) * 3);

            textBox.Text = islem.ToString();
        }

        private void button22_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown19.Value + " Adet " + "Süt " + Convert.ToInt32(numericUpDown19.Value) * 7 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown19.Value) * 7);

            textBox.Text = islem.ToString();
        }

        private void button21_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown20.Value + " Adet " + "Kola " + Convert.ToInt32(numericUpDown20.Value) * 9 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown20.Value) * 9);

            textBox.Text = islem.ToString();
        }

        private void button20_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown21.Value + " Adet " + "Enerji İçeceği " + Convert.ToInt32(numericUpDown21.Value) * 12 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown21.Value) * 12);

            textBox.Text = islem.ToString();
        }

        private void button19_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown22.Value + " Adet " + "Kahve " + Convert.ToInt32(numericUpDown22.Value) * 10 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown22.Value) * 10);

            textBox.Text = islem.ToString();
        }

        private void button18_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown23.Value + " Adet " + "Çay " + Convert.ToInt32(numericUpDown23.Value) * 18 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown23.Value) * 18);

            textBox.Text = islem.ToString();
        }

        private void button17_Click(object sender, EventArgs e)
        {

            listBox1.Items.Add(numericUpDown24.Value + " Adet " + "Maden Suyu " + Convert.ToInt32(numericUpDown24.Value) * 4 + "TL");

            int islem = Convert.ToInt32(textBox.Text) + (Convert.ToInt32(numericUpDown24.Value) * 4);

            textBox.Text = islem.ToString();
        }

        private void button25_Click(object sender, EventArgs e)
        {
            listBox1.Items.Remove(listBox1.SelectedItem);
        }

        private void button26_Click(object sender, EventArgs e)
        {
            MessageBox.Show("                                   Satın Alım işleminiz gerçekleşmiştir." +
                            "\n                                              Toplam Tutarınız: "+textBox.Text +" TL" + 
                            "\n\n--------------------------------------------------------------------------------------------" + 
                            "\n\n                                  Bizi tercih ettiğiniz için teşekkür ederiz. ");
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

        private void pictureBox28_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void pictureBox29_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

      
    }
}
