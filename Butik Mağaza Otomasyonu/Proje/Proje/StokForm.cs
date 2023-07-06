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
    public partial class StokForm : Form
    {
        VeriTabani db = new VeriTabani();
        public StokForm()
        {
            InitializeComponent();
        }

        private void siralamaOlcutuCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (siralamaOlcutuCombo.SelectedIndex)
            {
                case 0:
                    db.Listele("SELECT urunadi,fiyat,stok,satilan FROM Urunler ORDER BY urunadi ASC", urunListeleView);
                    break;

                case 1:
                    db.Listele("SELECT urunadi,fiyat,stok,satilan FROM urunler ORDER BY fiyat ASC", urunListeleView);
                    break;

                case 2:
                    db.Listele("SELECT urunadi,fiyat,stok,satilan FROM Urunler ORDER BY fiyat DESC", urunListeleView);
                    break;

                case 3:
                    db.Listele("SELECT urunadi,fiyat,stok,satilan FROM Urunler ORDER BY satilan ASC", urunListeleView);
                    break;

                case 4:
                    db.Listele("SELECT urunadi,fiyat,stok,satilan FROM Urunler ORDER BY satilan DESC", urunListeleView);
                    break;

                case 5:
                    db.Listele("SELECT urunadi,fiyat,stok,satilan FROM Urunler ORDER BY stok DESC", urunListeleView);
                    break;

                case 6:
                    db.Listele("SELECT urunadi,fiyat,stok,satilan FROM Urunler ORDER BY stok asc", urunListeleView);
                    break;

                default:
                    break;
            }
        }

        private void araButton_Click(object sender, EventArgs e)
        {
            db.Listele("SELECT urunadi,fiyat,stok,satilan FROM Urunler WHERE urunadi LIKE '%" + urunAraBox.Text + "%'", urunListeleView);
        }

        private void StokForm_Load(object sender, EventArgs e)
        {
            db.Listele("SELECT urunadi,fiyat,stok,satilan FROM urunler", urunListeleView);
        }

        private void button1_Click(object sender, EventArgs e)
        {

            this.Close();

        }

        private void StokForm_FormClosing(object sender, FormClosingEventArgs e)
        {
         
        }
    }
}
