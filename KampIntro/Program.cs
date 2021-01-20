using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string kategoriEtiketi = "Kategoriler";
            int ogrenciSayisi = 32000;
            double faizOrani = 1.45;
            bool sistemeGirisYapmisMi = true;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;

            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }

            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }

            else
            {
                Console.WriteLine("Değişmedi Butonu");
            }



            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }

            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            Console.WriteLine(kategoriEtiketi);

            int sayi = 24;
            bool durum;

            if (sayi % 4 == 0)
            {
                durum = true;
                Console.WriteLine(durum);
            }

            else
            {
                durum = false;
                Console.WriteLine(durum);
            }

            durum = ((sayi % 4 == 0)) ? true : false;
            Console.WriteLine(durum);
            Console.WriteLine((sayi % 4 == 0) ? true : false);

            int a = 5, b = 8;
            string sonuc;

            if (a > b)
            {
                sonuc = "a, b'den büyüktür.";
            }

            else if (a < b)
            {
                sonuc = "b, a'dan büyüktür.";
            }

            else
            {
                sonuc = "a ve b birbirine eşittir.";
            }

            Console.WriteLine(sonuc);

            sonuc = (a > b) ? "b, a'dan büyüktür." : (a < b) ? "b, a'dan büyüktür." : "a ve b birbirine eşittir.";
            Console.WriteLine(sonuc);

            Console.WriteLine((a > b) ? "b, a'dan büyüktür." : (a < b) ? "b, a'dan büyüktür." : "a ve b birbirine eşittir.");

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Monday:
                case DayOfWeek.Tuesday:
                case DayOfWeek.Wednesday:
                case DayOfWeek.Thursday:
                case DayOfWeek.Friday:
                    Console.WriteLine("Haftaiçindeyiz çalışmaya devam...");
                    break;
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Dinlen şimdi pazartesi iş bizi bekler...");
                    break;
            }
            // daha kısa şekilde:

            switch (DateTime.Now.DayOfWeek)
            {
                case DayOfWeek.Saturday:
                case DayOfWeek.Sunday:
                    Console.WriteLine("Dinlen şimdi pazartesi iş bizi bekler...");
                    break;
                default:
                    Console.WriteLine("Haftaiçindeyiz çalışmaya devam...");
                    break;

            }

            Console.Write("Bir sayı giriniz:");
            int sayiGir = Convert.ToInt32(Console.ReadLine());
            while (sayiGir >= 0)
            {
                Console.WriteLine(sayiGir);
                System.Threading.Thread.Sleep(1000);
                sayiGir--;
            }
        }
    }
}

