using System;
using System.Windows.Forms;

namespace Proje
{
    public partial class KullanicilarForm : Form
    {
        VeriTabani db = new VeriTabani();
        public KullanicilarForm()
        {
            InitializeComponent();
        }

        private void KullanicilarForm_Load(object sender, EventArgs e)
        {
            db.ListViewDoldur("SELECT kullaniciAdi From Kullanicilar", "kullaniciAdi", listView1);
            db.ComboBoxDoldur("SELECT kullaniciAdi From Kullanicilar", "kullaniciAdi",kullanicilarCombo );
            
        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void kullaniciEkleButton_Click(object sender, EventArgs e)
        {
            if (Kontrol.BosDegerKontrol(kullaniciEkleAdi, kullaniciEkleSifre))
            {

                if (db.KayitEkle("INSERT INTO Kullanicilar(kullaniciAdi,sifre)VALUES('" + kullaniciEkleAdi.Text + "','" + kullaniciEkleSifre.Text + "')"))
                {
                    MessageBox.Show("Kullanıcı Eklendi");
                    db.ListViewDoldur("SELECT kullaniciAdi From Kullanicilar", "kullaniciAdi", listView1);
                    db.ComboBoxDoldur("SELECT kullaniciAdi From Kullanicilar", "kullaniciAdi", kullanicilarCombo);
                    return;
                }
                else
                {
                    MessageBox.Show("Ekleme Başarısız, kullanıcı adı kayıtlı");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Tüm Alanları doldurun");
                return;
            }

        }

        private void kullaniciSilButton_Click(object sender, EventArgs e)
        {
            db.KayitSil("DELETE FROM Kullanicilar where kullaniciAdi = '" + kullanicilarCombo.Text + "'");
            db.ListViewDoldur("SELECT kullaniciAdi From Kullanicilar", "kullaniciAdi", listView1);
            db.ComboBoxDoldur("SELECT kullaniciAdi From Kullanicilar", "kullaniciAdi", kullanicilarCombo);
            kullanicilarCombo.Text="";
        }
    }
}
