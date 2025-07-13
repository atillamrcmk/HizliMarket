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
    public partial class FormSonSatislar : Form
    {
        public FormSonSatislar()
        {
            InitializeComponent();
            Yukle();
        }

        private void dataGridViewSonSatislar_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void Yukle()
        {
            var dt = SQLiteHelper.SonSatislariGetir();
            dataGridViewSonSatislar.DataSource = dt;
        }
    }
}
