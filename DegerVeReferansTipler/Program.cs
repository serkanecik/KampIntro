namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ?? 30

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?? 999

            //int, devimal, float, double, bool = değer tip
            //array, class, interface = referans tip

            //değer tip = değer atandıktan sonra değişkenle irtibat kopar, stack' te gerçekleşir
            //referans tip = yukardaki şekilde değer atandığında sayilar1 artık sayilar2 nin adres numarasını tutuyor, böyle sayilar2 nin adres numarasında yapılan değişiklikler sayilar1'de de gerçekleşiyor heap' te gerçekleşir
        }
    }
}
