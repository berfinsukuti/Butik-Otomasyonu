using System;
using System.Windows.Forms;
using System.IO;
using System.Drawing;

namespace Proje
{
    public partial class UrunIslemleriForm : Form
    {
        VeriTabani db = new VeriTabani();

        string resim;

        public UrunIslemleriForm()
        {
            InitializeComponent();
        }

        private void UrunIslemleriForm_Load(object sender, EventArgs e)
        {
            db.Listele("SELECT urunadi,fiyat,stok,satilan FROM urunler", urunListeleView2);
            db.ComboBoxDoldur("SELECT urunadi FROM Urunler", "urunadi", urunAdiGuncelleBox);
            db.ComboBoxDoldur("SELECT urunadi FROM Urunler", "urunadi", urunAdiCombo);
        }

        private void urunEkleButton_Click(object sender, EventArgs e)
        {
            db.KayitEkle("INSERT INTO Urunler(urunadi,fiyat,stok,resim) VALUES('" + ekleAdiBox.Text+ "'," + ekleFiyatBox.Text + "," + ekleAdetBox.Text + ",'"+resim+"')");
            db.Listele("SELECT urunadi,fiyat,stok,satilan FROM urunler", urunListeleView2);
        }

        private void urunGuncelleButton_Click(object sender, EventArgs e)
        {
            db.KayitEkle("UPDATE Urunler set fiyat="+guncelleFiyatBox.Text+", stok ="+guncelleAdetBox.Text+" where urunadi='"+urunAdiGuncelleBox.Text+"'");
            db.Listele("SELECT urunadi,fiyat,stok,satilan FROM urunler", urunListeleView2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void UrunIslemleriForm_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void urunSilButton_Click(object sender, EventArgs e)
        {
            db.KayitSil("DELETE FROM Urunler WHERE urunadi ='" + urunAdiCombo.Text+"'");
            db.Listele("SELECT urunadi,fiyat,stok,satilan FROM urunler", urunListeleView2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog1.FileName = "Ürün";
            openFileDialog1.Multiselect = false;
            openFileDialog1.ShowDialog();
            resim = openFileDialog1.FileName;
            pictureBox1.Image = Image.FromFile(resim);


        }
    }
}
