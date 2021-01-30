using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Yetiştirme Kursu";
            string kurs2 = "Programlamaya Başlangıç İçin Temel Kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);

            //array = dizi

            string[] kurslar = new string[] { "Yazılım Geliştirici Yetiştirme Kursu", "Programlamaya Başlangıç İçin Temel Kurs", "Java" };


            for (int i = 0; i < kurslar.Length; i++) //1"Programlamaya Başlangıç İçin Temel Kurs";' den başla, 3 ' dan küçük olduğu sürece i' yi bir artır i = i + 2 == i += 2, kurslar.Lenght = kurslar değişkenindeki eleman sayısı
            {
                Console.WriteLine(kurslar[i]);
            }
            Console.WriteLine("Sayfa Sonu - footer");

            Console.WriteLine("for Bitti");
            foreach (string kurs in kurslar) //diziler için kullanılır. dizinin içerisindeki her bir elemanı gezer.
            {
                Console.WriteLine(kurs);
            }

            int x = 1;
            while (x <= 10)
            {
                Console.WriteLine("Merhaba Dünya");
                x++;
            }
            Console.ReadKey();
        }
    }
}
