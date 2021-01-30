using System;

namespace ReturnKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Return toplamSayi = new Return();
            toplamSayi.Topla(3, 6);
            int toplamSonucu = toplamSayi.Topla(3, 6);
            Console.WriteLine(toplamSonucu * 2);
            Console.WriteLine(toplamSayi.Topla(3, 6) * 2);

            toplamSayi.Topla2(3, 6);
        }
    }
}
