using System;

namespace E_TicaretUrunListeleme
{
    class Program
    {
        class UrunBilgi
        {
            public string marka { get; set; }
            public string ozellik { get; set; }
            public int fiyat { get; set; }
            public int indirim { get; set; }
            public int yeniFiyat { get; set; }
            public string stokBilgi { get; set; }
        }
        static void Main(string[] args)
        {
            UrunBilgi urun1 = new UrunBilgi();
            urun1.marka = "Asus";
            urun1.ozellik = "INTEL Core i3, 16GB Ram, 4GB Ekran Kartı, 500GB HDD";
            urun1.fiyat = 5200;
            urun1.indirim = 1000;
            urun1.yeniFiyat = urun1.fiyat - urun1.indirim;
            urun1.stokBilgi = "Stokta";

            UrunBilgi urun2 = new UrunBilgi();
            urun2.marka = "HP";
            urun2.ozellik = "INTEL Core i3, 16GB Ram, 4GB Ekran Kartı, 500GB HDD";
            urun2.fiyat = 5499;
            urun2.indirim = 1500;
            urun2.yeniFiyat = urun2.fiyat - urun2.indirim;
            urun2.stokBilgi = "Stokta Değil";

            UrunBilgi urun3 = new UrunBilgi();
            urun3.marka = "Acer";
            urun3.ozellik = "INTEL Core i3, 16GB Ram, 4GB Ekran Kartı, 500GB HDD";
            urun3.fiyat = 5600;
            urun3.indirim = 600;
            urun3.yeniFiyat = urun3.fiyat - urun3.indirim;
            urun3.stokBilgi = "Stokta";

            UrunBilgi urun4 = new UrunBilgi();
            urun4.marka = "Casper";
            urun4.ozellik = "INTEL Core i3, 16GB Ram, 4GB Ekran Kartı, 500GB HDD";
            urun4.fiyat = 3450;
            urun4.indirim = 750;
            urun4.yeniFiyat = urun4.fiyat - urun4.indirim;
            urun4.stokBilgi = "Stokta";

            UrunBilgi urun5 = new UrunBilgi();
            urun5.marka = "MSI";
            urun5.ozellik = "INTEL Core i3, 16GB Ram, 4GB Ekran Kartı, 500GB HDD";
            urun5.fiyat = 5499;
            urun5.stokBilgi = "Stokta Değil";

            UrunBilgi urun6 = new UrunBilgi();
            urun6.marka = "Monster";
            urun6.ozellik = "INTEL Core i3, 16GB Ram, 4GB Ekran Kartı, 500GB HDD";
            urun6.fiyat = 5499;
            urun6.stokBilgi = "Stokta Değil";

            UrunBilgi[] urunler = new UrunBilgi[] { urun1, urun2, urun3, urun4, urun5, urun6 };
            for (int i = 0; i < urunler.Length; i++)
            {
                Console.WriteLine("Marka: " + urunler[i].marka + "\nÖzellik: " + urunler[i].ozellik + "\nFiyat: " + urunler[i].fiyat + "\nİndirim: " + urunler[i].indirim + "\nİndirimli Fiyat = " + urunler[i].yeniFiyat + "\nStok Bilgisi: " + urunler[i].stokBilgi + "\n\n");
            }

            Console.WriteLine("For Döngüsü Bitişi\n\n");

            foreach (var urunListe in urunler)
            {
                Console.WriteLine(urunListe.marka + "\n" + urunListe.ozellik + "\n" + urunListe.fiyat + "\n" + urunListe.indirim + "\n" + urunListe.yeniFiyat + "\n" + urunListe.stokBilgi + "\n\n");
            }

            Console.WriteLine("Foreach Döngüsü Bitişi\n\n");

            int x = 0;
            while (x < urunler.Length)
            {
                Console.WriteLine("Marka: " + urunler[x].marka + "\nÖzellik: " + urunler[x].ozellik + "\nFiyat: " + urunler[x].fiyat + "\nİndirim: " + urunler[x].indirim + "\nİndirimli Fiyat = " + urunler[x].yeniFiyat + "\nStok Bilgisi: " + urunler[x].stokBilgi + "\n\n");
                x += 1;
            }

            Console.WriteLine("While Döngüsü Bitişi\n\n");
        }
    }
}
