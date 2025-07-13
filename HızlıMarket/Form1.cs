using System;
using System.Data.SQLite;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace HızlıMarket
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Shown += Form1_Shown;
            dataGridViewUrunler.AutoGenerateColumns = false;
            textBoxBarkod.Multiline = false;
            textBoxBarkod.AcceptsReturn = false;
            textBoxBarkod.AcceptsTab = false;
            labelToplam.Text = "0.00";
        }

        private void uruneklebtn_Click(object sender, EventArgs e)
        {
            FormUrunEkle urunEkleForm = new FormUrunEkle();
            urunEkleForm.ShowDialog();
        }

        private void urunckrbtn_Click(object sender, EventArgs e)
        {
            FormUrunCikar frm = new FormUrunCikar();
            frm.ShowDialog();
        }

        private void urunbilgibtn_Click(object sender, EventArgs e)
        {
            FormUrunBilgi form = new FormUrunBilgi();
            form.Show();
        }

        private void karzararbtn_Click(object sender, EventArgs e)
        {
            decimal bugunkuKar = SQLiteHelper.GunlukKarHesapla();
            MessageBox.Show($"Bugünkü toplam kar: ₺{bugunkuKar:0.00}", "Günlük Kar", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void sonsatısbtn_Click(object sender, EventArgs e)
        {
            FormSonSatislar form = new FormSonSatislar();
            form.ShowDialog();
        }

        private void odemeyapbtn_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(labelToplam.Text, out double toplam))
            {
                MessageBox.Show("Geçerli bir toplam tutar yok.");
                return;
            }

            if (dataGridViewUrunler.Rows.Count == 0)
            {
                MessageBox.Show("Sepet boş.");
                return;
            }

            FormOdeme odemeFormu = new FormOdeme(toplam);
            if (odemeFormu.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    foreach (DataGridViewRow row in dataGridViewUrunler.Rows)
                    {
                        if (row.IsNewRow) continue;

                        string barkod = row.Cells[1].Value?.ToString();
                        int adet = int.TryParse(row.Cells[0].Value?.ToString(), out int a) ? a : 1;

                        SQLiteHelper.StokDus(barkod, adet);

                        string urunAdi = row.Cells[2].Value?.ToString();
                        double satisFiyat = double.TryParse(row.Cells[3].Value?.ToString(), out double f) ? f : 0;

                        SQLiteHelper.SatisEkle(urunAdi, barkod, adet, satisFiyat);
                    }

                    // MessageBox.Show("Satış tamamlandı.");
                    dataGridViewUrunler.Rows.Clear();
                    labelToplam.Text = "0.00";
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Satış sırasında hata: " + ex.Message);
                }
            }
            textBoxBarkod.Focus();

        }

        private void textBoxBarkod_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string barkod = textBoxBarkod.Text.Trim();
                if (string.IsNullOrEmpty(barkod)) return;

                SepeteEkle(barkod);
                textBoxBarkod.Clear();
            }
        }

        private void SepeteEkle(string barkod)
        {
            var urun = SQLiteHelper.UrunGetir(barkod);

            if (urun == null)
            {
                MessageBox.Show("Ürün bulunamadı.");
                return;
            }

            dataGridViewUrunler.Rows.Add("1", barkod, urun.UrunAdi, urun.SatisFiyat.ToString("0.00"));

            if (double.TryParse(labelToplam.Text, out double mevcutToplam))
            {
                double fiyat = Convert.ToDouble(urun.SatisFiyat);
                labelToplam.Text = (mevcutToplam + fiyat).ToString("0.00");
            }
            else
            {
                labelToplam.Text = urun.SatisFiyat.ToString("0.00");
            }
        }

        private void labelToplam_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void textBoxBarkod_TextChanged(object sender, EventArgs e) { }

        private void label4_Click(object sender, EventArgs e)
        {
            SepeteEkle("5000112664980");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string barkod = textBoxBarkod.Text.Trim();
            var urun = SQLiteHelper.UrunGetir(barkod);

            if (urun == null)
                MessageBox.Show("Ürün veritabanında bulunamadı.");
            else
                MessageBox.Show($"Ad: {urun.UrunAdi}, Fiyat: {urun.SatisFiyat}");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            dataGridViewUrunler.Columns.Clear();

            dataGridViewUrunler.Columns.Add("Adet", "Adet");
            dataGridViewUrunler.Columns.Add("Barkod", "Barkod");
            dataGridViewUrunler.Columns.Add("UrunAdi", "Ürün Adı");
            dataGridViewUrunler.Columns.Add("Fiyat", "Fiyat");
            menuSepettenCikar.Click += menuSepettenCikar_Click;
            dataGridViewUrunler.DefaultCellStyle.Padding = new Padding(5);
            dataGridViewUrunler.DefaultCellStyle.Font = new Font("Segoe UI", 14);
            dataGridViewUrunler.RowTemplate.Height = 60;
            dataGridViewUrunler.DefaultCellStyle.Font = new Font("Segoe UI", 12);
            dataGridViewUrunler.ColumnHeadersDefaultCellStyle.Font = new Font("Segoe UI", 13, FontStyle.Bold);
            dataGridViewUrunler.RowTemplate.Height = 35;

            string logoYolu = Path.Combine(Application.StartupPath, "logo.png");
            if (File.Exists(logoYolu))
            {
                pictureBoxLogo.Image = Image.FromFile(logoYolu);
            }
            textBoxBarkod.Focus();

        }



        private void label5_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }

        /* private void ürünüSepettenÇıkarToolStripMenuItem_Opening(object sender, System.ComponentModel.CancelEventArgs e)
         {
             if (dataGridViewUrunler.SelectedRows.Count == 0)
                 return;

             var row = dataGridViewUrunler.SelectedRows[0];

             if (double.TryParse(row.Cells[3].Value?.ToString(), out double fiyat) &&
                 int.TryParse(row.Cells[0].Value?.ToString(), out int adet))
             {
                 if (double.TryParse(labelToplam.Text, out double mevcutToplam))
                 {
                     double yeniToplam = mevcutToplam - (fiyat * adet);
                     labelToplam.Text = Math.Max(0, yeniToplam).ToString("0.00");
                 }
             }

             dataGridViewUrunler.Rows.Remove(row);
         }*/
        private void dataGridViewUrunler_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                var hit = dataGridViewUrunler.HitTest(e.X, e.Y);
                if (hit.RowIndex >= 0)
                {
                    dataGridViewUrunler.ClearSelection();
                    dataGridViewUrunler.Rows[hit.RowIndex].Selected = true;

                    // Seçilen hücreyi aktif yap
                    dataGridViewUrunler.CurrentCell = dataGridViewUrunler.Rows[hit.RowIndex].Cells[0];
                }
            }
        }




        /*  private void toolStripMenuItem1_Click(object sender, EventArgs e)
          {
              if (dataGridViewUrunler.SelectedRows.Count > 0)
              {
                  var row = dataGridViewUrunler.SelectedRows[0];
                  double fiyat = double.TryParse(row.Cells[3].Value?.ToString(), out double f) ? f : 0;

                  // Toplamdan çıkar
                  if (double.TryParse(labelToplam.Text, out double mevcut))
                  {
                      double yeniToplam = mevcut - fiyat;
                      labelToplam.Text = Math.Max(yeniToplam, 0).ToString("0.00");
                  }

                  dataGridViewUrunler.Rows.Remove(row);
              }
          }*/
        private void menuSepettenCikar_Click(object sender, EventArgs e)
        {
            if (dataGridViewUrunler.SelectedRows.Count == 0)
            {
                // MessageBox.Show("Satır seçili değil.");
                return;
            }

            var row = dataGridViewUrunler.SelectedRows[0];

            if (row.Cells[3].Value != null && double.TryParse(row.Cells[3].Value.ToString(), out double fiyat) &&
                row.Cells[0].Value != null && int.TryParse(row.Cells[0].Value.ToString(), out int adet))
            {
                if (double.TryParse(labelToplam.Text, out double mevcut))
                {
                    double yeniToplam = mevcut - (fiyat * adet);
                    labelToplam.Text = Math.Max(0, yeniToplam).ToString("0.00");
                }
            }


            dataGridViewUrunler.Rows.Remove(row);
            if (dataGridViewUrunler.Rows.Count == 0)
            {
                labelToplam.Text = "0.00";
                textBoxBarkod.Focus();
            }
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            textBoxBarkod.Focus();
        }
    }
}
