using System;

namespace SifreKontrol
{
    class Program
    {
        static void Main(string[] args)
        {
            string kulAdi;
            string sifre;
            for (int i = 0; i <= 4; i++)
            {
                Console.WriteLine("Kullanıcı Adınızı Giriniz: ");
                kulAdi = Console.ReadLine();
                Console.WriteLine("Şifrenizi Giriniz: ");
                sifre = Console.ReadLine();

                if (kulAdi == "serkanecik" && sifre == "tldrokan68.")
                {
                    Console.WriteLine("Giriş Yapıldı...");
                    i += 3;
                }
                else
                {
                    Console.WriteLine("Hatalı Giriş Yaptınız. Lütfen Tekrar Deneyiniz.");
                    i += 1;
                }
            }

        }
    }
}
