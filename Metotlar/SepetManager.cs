using System;

namespace Metotlar
{
    class SepetManager
    {
        //naming convention - isimlendirme kuralı
        //syntax - yazım değişimi
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);
        }
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stockAdedi)
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }
    }
}
