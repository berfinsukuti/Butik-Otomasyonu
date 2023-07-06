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
    public partial class MusterilerForm : Form
    {

        VeriTabani db = new VeriTabani();

        public MusterilerForm()
        {
            InitializeComponent();
        }

        private void MusterilerForm_Load(object sender, EventArgs e)
        {
            db.Listele("SELECT adi,soyadi,telefon,adres FROM Musteriler", tumMusterilerView);
            new VeriTabani().Listele("SELECT adi,soyadi,urun FROM SatinAlimlar",dataGridView2);
            db.ComboBoxDoldur("SELECT telefon FROM Musteriler", "telefon", musteriAdiCombo);
        }

        private void musteriEkleButton_Click(object sender, EventArgs e)
        {
            if (musteriEkleTelefon.Text.Length!=11)
            {
                MessageBox.Show("Telefon Numarası 11 haneli olmalı");
                return;
            }



            if (Kontrol.BosDegerKontrol(musteriEkleAdi, musteriEkleSoyadi, musteriEkleTelefon, msuteriEkleAdres))
            {

                if (db.KayitEkle("INSERT INTO Musteriler(adi,soyadi,telefon,adres) VALUES('" + musteriEkleAdi.Text + "','" + musteriEkleSoyadi.Text + "','" + musteriEkleTelefon.Text + "','" + msuteriEkleAdres.Text + "')"))
                {
                    MessageBox.Show("Kayıt Başarılı");
                    db.Listele("SELECT adi,soyadi,telefon,adres FROM Musteriler", tumMusterilerView);
                    Kontrol.TextBoxTemizle(musteriEkleAdi, musteriEkleSoyadi, musteriEkleTelefon, msuteriEkleAdres);
                    return;
                }
                else
                {
                    MessageBox.Show("Başarısız...\nTelefon numarası zaten Kayıtlı");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Kayıt Alanlarını Doldurun");
                return;
            }
        }

        private void musteriSil_Click(object sender, EventArgs e)
        {


          db.KayitSil("DELETE FROM Musteriler WHERE telefon = '" + musteriAdiCombo.Text + "'");
          db.KayitSil("DELETE FROM SatinAlimlar WHERE telefon = '" + musteriAdiCombo.Text + "'");
         db.Listele("SELECT adi,soyadi,telefon,adres FROM Musteriler", tumMusterilerView);
            new VeriTabani().Listele("SELECT adi,soyadi,urun FROM SatinAlimlar",dataGridView2);
            db.ComboBoxDoldur("SELECT telefon FROM Musteriler", "telefon", musteriAdiCombo);

        }
    }
}
