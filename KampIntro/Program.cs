using System;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            //type safety = tip güvenliği
            //değer tutucu, alias

            string kategoriEtiketi = "Kategori";
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            Console.WriteLine(kategoriEtiketi);
            //do not repeat yourself = kendini tekrarlama

            Console.WriteLine("Kategori");
            Console.WriteLine("Kategori");
            Console.WriteLine("Kategori");
            Console.WriteLine("Kategori");

#pragma warning disable CS0219 // 'ogrenciSayisi' değişkeni atanır ancak değeri hiçbir zaman kullanılmaz
            int ogrenciSayisi = 32000;
#pragma warning restore CS0219 // 'ogrenciSayisi' değişkeni atanır ancak değeri hiçbir zaman kullanılmaz
#pragma warning disable CS0219 // 'faizOrani' değişkeni atanır ancak değeri hiçbir zaman kullanılmaz
            double faizOrani = 1.45;
#pragma warning restore CS0219 // 'faizOrani' değişkeni atanır ancak değeri hiçbir zaman kullanılmaz
            bool sistemeGirisYapmisMi = false;
            double dolarDun = 7.35;
            double dolarBugun = 7.45;
            //şart blokları
            if (dolarDun > dolarBugun)
            {
                Console.WriteLine("Azalış");
            }
            else if (dolarDun < dolarBugun)
            {
                Console.WriteLine("Artış");
            }
            else
            {
                Console.WriteLine("Eşittir");
            }

            if (sistemeGirisYapmisMi == true)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }

            int number = 1;
            if (number == 1)
            {
                Console.WriteLine("Durum 1");
            }
            else if (number == 2)
            {
                Console.WriteLine("Durum 2");
            }
            else
            {
                Console.WriteLine("Varsayılan durum");
            }

#pragma warning disable CS0219 // 'number2' değişkeni atanır ancak değeri hiçbir zaman kullanılmaz
            int number2 = 1;
#pragma warning restore CS0219 // 'number2' değişkeni atanır ancak değeri hiçbir zaman kullanılmaz
            switch (number)
            {
                case 1:
                    Console.WriteLine("Durum 1");
                    break;
                case 2:
                    Console.WriteLine("Durum 2");
                    break;
                default:
                    Console.WriteLine("Varsayılan durum");
                    break;
            }

#pragma warning disable CS0219 // 'number3' değişkeni atanır ancak değeri hiçbir zaman kullanılmaz
            int number3 = 1;
#pragma warning restore CS0219 // 'number3' değişkeni atanır ancak değeri hiçbir zaman kullanılmaz
            string sonuc = (number == 1) ? "Durum 1" : "Varsayılan Durum";
            Console.WriteLine(sonuc);
        }
    }
}
