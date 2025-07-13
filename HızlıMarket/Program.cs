using System;
using System.Windows.Forms;
using HızlıMarket;

namespace HizliMarket
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            SQLiteHelper.InitializeDatabase(); // ✅ Veritabanını başta kur
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
