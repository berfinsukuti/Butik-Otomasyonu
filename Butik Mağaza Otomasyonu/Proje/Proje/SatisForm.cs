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
    public partial class SatisForm : Form
    {
        int stok = 0;
        VeriTabani db = new VeriTabani();

        public SatisForm()
        {
            InitializeComponent();
            tarih.Text = DateTime.Now.ToString();
        }

        private void tarihTimer_Tick(object sender, EventArgs e)
        {
            tarih.Text = DateTime.Now.ToString();
           
        }

        private void SatisForm_Load(object sender, EventArgs e)
        {
            label27.Text = LoginForm.GetKullanici();


            db.ComboBoxDoldur("SELECT telefon FROM Musteriler","telefon", telefonBox);
            db.ComboBoxDoldur("SELECT urunadi FROM Urunler where stok > 0", "urunadi", urunSecCombo);


            

        }

        private void telefonBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            adiBox.Text = db.DegerOku("SELECT adi FROM Musteriler WHERE telefon='" + telefonBox.Text + "'", "adi");
            soyadiBox.Text = db.DegerOku("SELECT soyadi FROM Musteriler WHERE telefon='" + telefonBox.Text + "'", "soyadi");
        }

        private void listeyeEkleButton_Click(object sender, EventArgs e)
        {

            try
            {
                int a = int.Parse(miktarBox.Text);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Miktar sadece sayısal değer içerebilir");
                miktarBox.Clear();
                return;
                

            }




            if (!Kontrol.BosDegerKontrol(miktarBox) || urunSecCombo.Text.Length<1)
            {
                MessageBox.Show("Ürün ve Miktarını giriniz");
                return;
            }


            bool i = false;
           
            foreach (ListViewItem items in urunView.Items)
            {
                if (items.Text == urunSecCombo.Text)
                {
                    int temp = int.Parse(items.SubItems[1].Text);
                    temp += int.Parse(miktarBox.Text);
                    items.SubItems[1].Text = temp.ToString();
                    i = true;
                }
                
               

            }

            if (!i)
            {
                ListViewItem item = new ListViewItem(urunSecCombo.Text);
                item.SubItems.Add(miktarBox.Text);
                urunView.Items.Add(item);
            }
            

            int toplam = 0;
            foreach (ListViewItem val in urunView.Items)
            {

                toplam += int.Parse(val.SubItems[1].Text);

            }

            toplamTutarLabel.Text = toplam.ToString();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            urunView.Clear();
            toplamTutarLabel.Text = "0";
        }

        private void secileniKaldirButton_Click(object sender, EventArgs e)
        {
            if (urunView.Items.Count<1)
            {
                return;
            }
            urunView.SelectedItems[0].Remove();

            int toplam = 0;
            foreach (ListViewItem val in urunView.Items)
            {

                toplam += int.Parse(val.SubItems[1].Text);

            }

            toplamTutarLabel.Text = toplam.ToString();

        }

        private void urunSecCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            stok = int.Parse(db.DegerOku("SELECT stok FROM Urunler where urunadi='" + urunSecCombo.Text + "'","stok"));
            miktarBox.Text = stok.ToString();

            string resim = db.DegerOku("SELECT resim FROM Urunler where urunadi='" + urunSecCombo.Text + "'", "resim");
            pictureBox1.Image = Image.FromFile(resim);
        }

        private void miktarBox_TextChanged(object sender, EventArgs e)
        {
            if (miktarBox.Text.Length<1)
            {
                return;
            }
            if (int.Parse(miktarBox.Text)>stok)
            {
                MessageBox.Show("yeterli stok yok");
                miktarBox.Text = stok.ToString();
            }
        }

        private void OdemeYapButton_Click(object sender, EventArgs e)
        {


            foreach (ListViewItem item in urunView.Items)
            {
                db.KayitEkle("INSERT INTO SatinAlimlar(adi,soyadi,urun,telefon) VALUES('" + adiBox.Text + "','" + soyadiBox.Text + "','" + item.Text + "','" + telefonBox.Text+"')");
                db.KayitGüncelle("UPDATE Urunler set stok=stok-" + item.SubItems[1].Text + ",satilan =satilan+"+item.SubItems[1].Text+" where urunadi='" + item.Text + "'");
            }

            MessageBox.Show("Ödeme Başarılı");

        }
    }
}
