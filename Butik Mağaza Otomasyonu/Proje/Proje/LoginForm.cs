using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Proje
{
    public partial class LoginForm : Form
    {
        VeriTabani db = new VeriTabani();

        public LoginForm()
        {
            InitializeComponent();
        }

        static string kullanici;

        private void button1_Click(object sender, EventArgs e)
        {

            if (Kontrol.BosDegerKontrol(textBox1, textBox2))
            {
                if (db.GirisYap("SELECT * FROM Kullanicilar where kullaniciAdi ='" + textBox1.Text + "' AND sifre ='" + textBox2.Text + "'"))
                {
                    MessageBox.Show("Giriş Başarılı");

                    kullanici = textBox1.Text;
                    Form1 anaform = new Form1();
                    anaform.Visible = true;
                    this.Hide();
                    return;
                }
                else
                {
                    MessageBox.Show("Giriş Başarısız Hatalı kullanıcı adı veya şifre");
                    return;
                }

            }
            else
            {
                MessageBox.Show("Tüm alanları doldurun");
              
            }

            Kontrol.TextBoxTemizle(textBox1, textBox2);
        }


        public static string GetKullanici()
        {
            return kullanici;
        }


    }
}
