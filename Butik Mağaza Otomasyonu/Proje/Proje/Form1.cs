using System;
using System.Drawing;
using System.Windows.Forms;

namespace Proje
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

     
        private void button1_Click(object sender, EventArgs e)
        {
            StokForm stokForm = new StokForm();
            stokForm.ShowDialog();
         
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MusterilerForm musteriler = new MusterilerForm();
            musteriler.ShowDialog();

        }

        private void button5_Click(object sender, EventArgs e)
        {
            UrunIslemleriForm urun = new UrunIslemleriForm();
            urun.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            KullanicilarForm kullanicilar = new KullanicilarForm();
            kullanicilar.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SatisForm satis = new SatisForm();
            satis.ShowDialog();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
