using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace YSNODEVVİZE
{

    public class Kitap
    {
        public Kitap()
        {

        }

        public Kitap(string kitabinbasligi, string kitabinyazari, string kitapturu, DateTime kitabintarihi)
        {
            this.KitapTitle = kitabinbasligi;
            this.KitapYazar = kitabinyazari;
            this.KitapTur = kitapturu;
            this.KitapTarih = kitabintarihi;
        }
        public string KitapTitle { get; set; }
        public string KitapYazar { get; set; }
        public string KitapTur { get; set; }
        public DateTime KitapTarih { get; set; }
        public string BilgileriGetir() => $"KitabınAdı:{this.KitapTitle}\nYazarınAdı:{this.KitapYazar}\nKitabınTürü:{this.KitapTur}\nKitabınTarihi:{this.KitapTarih}";


        private static string dosyaYol = AppDomain.CurrentDomain.BaseDirectory + "Kitaplar.txt";
        public static void dosyaOku()
        {
            if (File.Exists(dosyaYol))
            {
                Console.WriteLine("Kitaplar listesi yükleniyor");
                string bilgileriOku = File.ReadAllText(dosyaYol);
                Console.WriteLine(bilgileriOku);
            }
            else
                Console.WriteLine("Herhangi bir kitap bilgisi eklenmemiş.");
        }

        public static void dosyaYaz(string kitabinbasligi, string kitabinyazari, DateTime kitabintarihi, string kitapturu)
        {
            string KitapBilgi = "Kitap adı: " + kitabinbasligi + "\nKitap Yazarı: " + kitabinyazari + "\nKitap Türü: " + kitapturu + "\nKitap Basım Tarihi: " + kitabintarihi;
            File.AppendAllText(dosyaYol, KitapBilgi + Environment.NewLine);
        }
    }
}