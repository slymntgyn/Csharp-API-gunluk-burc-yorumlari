using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;
using System.Data.SqlClient;
namespace burç_Yorumları
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void button1_Click(object sender, EventArgs e)
        {
            //string sehir = comboBox1.SelectedItem.ToString();
            string baglanti = "http://api.tavcan.com/xml/astroloji.xml";
            XDocument burclar = XDocument.Load(baglanti);
            var tarih = burclar.Descendants("tarih").ElementAt(0).Value;
            label1.Text = tarih;
            string burc = comboBox1.SelectedItem.ToString();
            var burcs = burclar.Descendants("adi").ElementAt(comboBox1.SelectedIndex).Value;
            label3.Text = burcs;
            var yorum = burclar.Descendants("yorum").ElementAt(comboBox1.SelectedIndex).Value;
            groupBox1.Text = yorum;
            if (comboBox1.SelectedIndex == 0)
            {
                pictureBox2.ImageLocation = "koç.jpg";
            }
            else if (comboBox1.SelectedIndex == 1)
            {
                pictureBox2.ImageLocation = "boğa.jpg";
            }
            else if (comboBox1.SelectedIndex == 2)
            {
                pictureBox2.ImageLocation = "ikizler.jpg";
            }
            else if (comboBox1.SelectedIndex == 3)
            {
                pictureBox2.ImageLocation = "yengeç.jpg";
            }
            else if (comboBox1.SelectedIndex == 4)
            {
                pictureBox2.ImageLocation = "aslan.jpg";
            }
            else if (comboBox1.SelectedIndex == 5)
            {
                pictureBox2.ImageLocation = "başak.jpg";
            }
            else if (comboBox1.SelectedIndex == 6)
            {
                pictureBox2.ImageLocation = "terazi.jpg";
            }
            else if (comboBox1.SelectedIndex == 7)
            {
                pictureBox2.ImageLocation = "akrep.jpg";
            }
            else if (comboBox1.SelectedIndex == 8)
            {
                pictureBox2.ImageLocation = "yay.jpg";
            }
            else if (comboBox1.SelectedIndex == 9)
            {
                pictureBox2.ImageLocation = "oğlak.jpg";
            }
            else if (comboBox1.SelectedIndex == 10)
            {
                pictureBox2.ImageLocation = "kova.jpg";
            }
            else
            {
                pictureBox2.ImageLocation = "balık.jpg";
            }
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
