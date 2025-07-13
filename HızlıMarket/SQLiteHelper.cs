using System;
using System.Data;
using System.Data.SQLite;
using System.IO;

namespace HızlıMarket
{
    public static class SQLiteHelper
    {
        public static readonly string ConnectionString;

        static SQLiteHelper()
        {
            string klasor = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                "HizliMarket");

            if (!Directory.Exists(klasor))
                Directory.CreateDirectory(klasor);

            string dbYolu = Path.Combine(klasor, "veritabani.db");
            ConnectionString = $"Data Source={dbYolu};Version=3;";

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                string sql = @"CREATE TABLE IF NOT EXISTS Urunler (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                UrunAdi TEXT NOT NULL,
                                Barkod TEXT NOT NULL UNIQUE,
                                Adet INTEGER,
                                AlisFiyat REAL,
                                SatisFiyat REAL
                            );

                            CREATE TABLE IF NOT EXISTS Satislar (
                                Id INTEGER PRIMARY KEY AUTOINCREMENT,
                                UrunAdi TEXT,
                                Barkod TEXT,
                                Adet INTEGER,
                                SatisFiyat REAL,
                                Tarih DATETIME
                            );";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public class Urun
        {
            public string UrunAdi { get; set; }
            public string Barkod { get; set; }
            public int Adet { get; set; }
            public decimal AlisFiyat { get; set; }
            public decimal SatisFiyat { get; set; }
        }

        public static Urun UrunGetir(string barkod)
        {
            if (string.IsNullOrWhiteSpace(barkod))
                return null;

            barkod = barkod.Trim();

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = "SELECT * FROM Urunler WHERE Barkod = @Barkod";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Barkod", barkod);

                    using (var reader = cmd.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            return new Urun
                            {
                                UrunAdi = reader["UrunAdi"]?.ToString(),
                                Barkod = reader["Barkod"]?.ToString(),
                                Adet = reader["Adet"] != DBNull.Value ? Convert.ToInt32(reader["Adet"]) : 0,
                                AlisFiyat = reader["AlisFiyat"] != DBNull.Value ? Convert.ToDecimal(reader["AlisFiyat"]) : 0,
                                SatisFiyat = reader["SatisFiyat"] != DBNull.Value ? Convert.ToDecimal(reader["SatisFiyat"]) : 0
                            };
                        }
                    }
                }
            }

            return null;
        }

        public static void StokDus(string barkod, int adet)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = "UPDATE Urunler SET Adet = Adet - @Adet WHERE Barkod = @Barkod";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Adet", adet);
                    cmd.Parameters.AddWithValue("@Barkod", barkod);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void UrunSil(string barkod)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = "DELETE FROM Urunler WHERE Barkod = @Barkod";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Barkod", barkod);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void SatisEkle(string urunAdi, string barkod, int adet, double satisFiyat)
        {
            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = @"INSERT INTO Satislar (UrunAdi, Barkod, Adet, SatisFiyat, Tarih)
                               VALUES (@UrunAdi, @Barkod, @Adet, @SatisFiyat, @Tarih)";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@UrunAdi", urunAdi);
                    cmd.Parameters.AddWithValue("@Barkod", barkod);
                    cmd.Parameters.AddWithValue("@Adet", adet);
                    cmd.Parameters.AddWithValue("@SatisFiyat", satisFiyat);
                    cmd.Parameters.AddWithValue("@Tarih", DateTime.Now);
                    cmd.ExecuteNonQuery();
                }
            }
        }

        public static void InitializeDatabase()
        {
            // Sınıf ilk çağrıldığında static constructor zaten tablo oluşturuyor.
        }
        public static decimal ToplamKarHesapla()
        {
            decimal toplamKar = 0;

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = "SELECT (SatisFiyat - AlisFiyat) * Adet AS Kar FROM Urunler";

                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        if (reader["Kar"] != DBNull.Value)
                            toplamKar += Convert.ToDecimal(reader["Kar"]);
                    }
                }
            }

            return toplamKar;
        }
        public static DataTable SonSatislariGetir(int adet = 20)
        {
            DataTable table = new DataTable();

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();
                string sql = $"SELECT UrunAdi, Barkod, Adet, SatisFiyat, Tarih FROM Satislar ORDER BY Tarih DESC LIMIT @Adet";

                using (var cmd = new SQLiteCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@Adet", adet);

                    using (var adapter = new SQLiteDataAdapter(cmd))
                    {
                        adapter.Fill(table);
                    }
                }
            }

            return table;
        }
        public static decimal GunlukKarHesapla()
        {
            decimal toplamKar = 0;

            using (var conn = new SQLiteConnection(ConnectionString))
            {
                conn.Open();

                string sql = @"
            SELECT 
                s.Adet,
                s.SatisFiyat,
                u.AlisFiyat
            FROM Satislar s
            JOIN Urunler u ON s.Barkod = u.Barkod
            WHERE DATE(s.Tarih) = DATE('now')";

                using (var cmd = new SQLiteCommand(sql, conn))
                using (var reader = cmd.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        int adet = Convert.ToInt32(reader["Adet"]);
                        decimal satis = Convert.ToDecimal(reader["SatisFiyat"]);
                        decimal alis = Convert.ToDecimal(reader["AlisFiyat"]);

                        toplamKar += (satis - alis) * adet;
                    }
                }
            }

            return toplamKar;
        }


    }
}
