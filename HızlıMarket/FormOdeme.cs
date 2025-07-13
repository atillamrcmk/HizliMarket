using System;
using System.Windows.Forms;

namespace HızlıMarket
{
    public partial class FormOdeme : Form
    {
        private double toplamTutar;

        public FormOdeme(double toplam)
        {
            InitializeComponent();
            toplamTutar = toplam;
            labelToplamTutar.Text = $"Toplam Tutar: ₺{toplam:0.00}";
        }

        private bool odemeTamamlandi = false;

        private void btnOdemeYap_Click(object sender, EventArgs e)
        {
            if (!odemeTamamlandi)
            {
                if (!double.TryParse(textBoxOdeme.Text.Trim(), out double verilen))
                {
                    MessageBox.Show("Lütfen geçerli bir ödeme miktarı girin.");
                    return;
                }

                if (verilen < toplamTutar)
                {
                    MessageBox.Show("Yetersiz ödeme yapıldı.");
                    return;
                }

                double paraUstu = verilen - toplamTutar;
                labelParaUstu.Text = $"Para Üstü: ₺{paraUstu:0.00}";

                // ✅ Sadece yazıyı değiştir, kapanma olmasın
                btnOdemeYap.Text = "TAMAMLANDI - KAPAT";
                odemeTamamlandi = true;

            }
            else
            {
                // ✅ Kullanıcı onayladıysa sonucu bildir ve formu kapat
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }




        private void FormOdeme_Load(object sender, EventArgs e)
        {
            textBoxOdeme.Focus();
        }

        private void labelToplamTutar_Click(object sender, EventArgs e) { }

        private void textBoxOdeme_TextChanged(object sender, EventArgs e) { }

        private void labelParaUstu_Click(object sender, EventArgs e) { }
    }
}
