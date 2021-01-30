using System;

namespace SgkKontrol
{
    class Program
    {
        class Kisiler
        {
            public string ad { get; set; }
            public string soyad { get; set; }
            public bool sgkKontrol { get; set; }
        }
        static void Main(string[] args)
        {
            Kisiler kisi1 = new Kisiler();
            kisi1.ad = "Serkan";
            kisi1.soyad = "Ecik";
            kisi1.sgkKontrol = true;

            Kisiler kisi2 = new Kisiler();
            kisi2.ad = "Ahmet";
            kisi2.soyad = "Sağlam";
            kisi2.sgkKontrol = false;

            Kisiler kisi3 = new Kisiler();
            kisi3.ad = "Ali";
            kisi3.soyad = "Keleş";
            kisi3.sgkKontrol = false;

            Kisiler kisi4 = new Kisiler();
            kisi4.ad = "Mehmet";
            kisi4.soyad = "Koç";
            kisi4.sgkKontrol = true;

            Kisiler kisi5 = new Kisiler();
            kisi5.ad = "Kadir";
            kisi5.soyad = "Soylu";
            kisi5.sgkKontrol = true;

            Kisiler kisi6 = new Kisiler();
            kisi6.ad = "Melih";
            kisi6.soyad = "Tek";
            kisi6.sgkKontrol = false;

            Kisiler[] kisiler = new Kisiler[] { kisi1, kisi2, kisi3, kisi4, kisi5, kisi6 };

            foreach (var kisi in kisiler)
            {
                Console.WriteLine(kisi.ad + " " + kisi.soyad + " " + kisi.sgkKontrol);
            }
        }
    }
}
