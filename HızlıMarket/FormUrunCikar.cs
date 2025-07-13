using System;
using System.Windows.Forms;

namespace HızlıMarket
{
    public partial class FormUrunCikar : Form
    {
        private SQLiteHelper.Urun urun;

        public FormUrunCikar()
        {
            InitializeComponent();

            label2.Text = ""; // Ürün bilgisi etiketi
            numericUpDown1.Minimum = 1;
            numericUpDown1.Maximum = 1000;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string barkod = textBox1.Text.Trim();

            if (string.IsNullOrWhiteSpace(barkod))
            {
                label2.Text = "";
                urun = null;
                return;
            }

            urun = SQLiteHelper.UrunGetir(barkod);

            if (urun != null)
            {
                label2.Text = $"Ürün: {urun.UrunAdi} - Stok: {urun.Adet}";
            }
            else
            {
                label2.Text = "Ürün bulunamadı.";
            }
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            // Gerekirse burada stok miktarına göre kontrol eklenebilir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (urun == null)
            {
                MessageBox.Show("Lütfen geçerli bir ürün barkodu girin.");
                return;
            }

            int miktar = (int)numericUpDown1.Value;

            if (miktar > urun.Adet)
            {
                MessageBox.Show("Stokta bu kadar ürün yok.");
                return;
            }

            // Stok düşür
            SQLiteHelper.StokDus(urun.Barkod, miktar);

            // Kalan stok miktarını tekrar kontrol et
            var kalanUrun = SQLiteHelper.UrunGetir(urun.Barkod);
            if (kalanUrun != null && kalanUrun.Adet <= 0)
            {
                SQLiteHelper.UrunSil(urun.Barkod);
                MessageBox.Show($"'{urun.UrunAdi}' tamamen stoktan çıkarıldı ve veritabanından silindi.");
            }
            else
            {
                MessageBox.Show($"{miktar} adet '{urun.UrunAdi}' başarıyla çıkarıldı.");
            }

            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            // Bilgi etiketi için gerek yok ama olay boş kalmasın diye eklenebilir.
        }
    }
}
