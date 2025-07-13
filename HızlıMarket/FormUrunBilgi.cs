using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HızlıMarket
{
    public partial class FormUrunBilgi : Form
    {
        public FormUrunBilgi()
        {
            InitializeComponent();
        }

        private void btnAra_Click(object sender, EventArgs e)
        {
            string barkod = textBoxBarkod.Text.Trim();
            if (string.IsNullOrEmpty(barkod))
            {
                MessageBox.Show("Barkod giriniz.");
                return;
            }

            var urun = SQLiteHelper.UrunGetir(barkod);

            if (urun == null)
            {
                MessageBox.Show("Ürün bulunamadı.");
            }
            else
            {
                labelUrunAdi.Text = $"Ürün Adı: {urun?.UrunAdi}";
                labelAdet.Text = $"Adet: {urun?.Adet}";
                labelAlis.Text = $"Alış Fiyatı: {urun?.AlisFiyat}";
                labelSatis.Text = $"Satış Fiyatı: {urun?.SatisFiyat}";
            }
        }

        private void labelAlis_Click(object sender, EventArgs e)
        {

        }

        private void labelUrunAdi_Click(object sender, EventArgs e)
        {

        }
    }
}
