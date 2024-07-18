using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formuygörn8
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            double vize, final, proje;
            double ortalama;

            ad = textBoxad.Text;
            soyad = textBoxsoyad.Text;
            vize = Convert.ToDouble(textBoxvize.Text);
            final = Convert.ToDouble(textBoxfinal.Text);
            proje = Convert.ToDouble(textBoxproje.Text);

            ortalama = vize * 30 / 100 + final * 50 / 100 + proje * 20 / 100;

            listBox1.Items.Add(ad + " " + soyad + " " + "ortalama:" + " " + ortalama);
        }
    }
}
