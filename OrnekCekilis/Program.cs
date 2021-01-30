using System;

namespace OrnekCekilis
{
    class Cekilis
    {
        public string ad { get; set; }
        public string soyad { get; set; }
        public string kulAdi { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Cekilis kisi1 = new Cekilis();
            kisi1.ad = "Serkan";
            kisi1.soyad = "Ecik";
            kisi1.kulAdi = "serkanecik";

            Cekilis kisi2 = new Cekilis();
            kisi2.ad = "Ahmet";
            kisi2.soyad = "Sağlam";
            kisi2.kulAdi = "ahmetsag1";

            Cekilis kisi3 = new Cekilis();
            kisi3.ad = "Ali";
            kisi3.soyad = "Keleş";
            kisi3.kulAdi = "kelesali";

            Cekilis[] kisiler = new Cekilis[] { kisi1, kisi2, kisi3 };
            for (int i = 0; i < kisiler.Length; i++)
            {
                Console.WriteLine(kisiler[i].ad + " " + kisiler[i].soyad + " / " + kisiler[i].kulAdi);
            }
            Console.WriteLine("Katılan Kişi Sayısı = " + kisiler.Length);

            //foreach (var kisi in kisiler)
            //{
            //Console.WriteLine(kisi.ad + " " + kisi.soyad + " " + kisi.kulAdi);
            //}
        }
    }
}
