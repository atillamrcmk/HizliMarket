using System;
using System.Windows.Forms;
using System.Data.SQLite;

namespace HızlıMarket
{
    public partial class FormUrunEkle : Form
    {
        public FormUrunEkle()
        {
            InitializeComponent();
        }

        
        private void buttonKaydet_Click_1(object sender, EventArgs e)
        {
            string urunAdi = textBoxUrunAdi.Text.Trim();
            string barkod = textBoxBarkod.Text.Trim();
            int.TryParse(textBoxAdet.Text, out int adet);
            decimal.TryParse(textBoxAlis.Text, out decimal alisFiyat);
            decimal.TryParse(textBoxSatis.Text, out decimal satisFiyat);

            if (string.IsNullOrWhiteSpace(urunAdi) || string.IsNullOrWhiteSpace(barkod) || adet <= 0)
            {
                MessageBox.Show("Lütfen tüm alanları geçerli şekilde doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                var mevcutUrun = SQLiteHelper.UrunGetir(barkod);

                using (var conn = new SQLiteConnection(SQLiteHelper.ConnectionString))
                {
                    conn.Open();

                    if (mevcutUrun != null)
                    {
                        // Ürün varsa: stok güncelle
                        string sqlUpdate = "UPDATE Urunler SET Adet = Adet + @Adet WHERE Barkod = @Barkod";

                        using (var cmd = new SQLiteCommand(sqlUpdate, conn))
                        {
                            cmd.Parameters.AddWithValue("@Adet", adet);
                            cmd.Parameters.AddWithValue("@Barkod", barkod);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Ürün zaten var. Stok artırıldı.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        // Ürün yoksa: yeni ürün ekle
                        string sqlInsert = @"INSERT INTO Urunler (UrunAdi, Barkod, Adet, AlisFiyat, SatisFiyat) 
                                     VALUES (@UrunAdi, @Barkod, @Adet, @AlisFiyat, @SatisFiyat)";

                        using (var cmd = new SQLiteCommand(sqlInsert, conn))
                        {
                            cmd.Parameters.AddWithValue("@UrunAdi", urunAdi);
                            cmd.Parameters.AddWithValue("@Barkod", barkod);
                            cmd.Parameters.AddWithValue("@Adet", adet);
                            cmd.Parameters.AddWithValue("@AlisFiyat", alisFiyat);
                            cmd.Parameters.AddWithValue("@SatisFiyat", satisFiyat);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Yeni ürün başarıyla eklendi.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                this.Close(); // Form kapanır
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hata: " + ex.Message, "Veritabanı Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
