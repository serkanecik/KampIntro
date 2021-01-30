using System;

namespace RefOut
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 20;
            int number2 = 100;
            var result2 = Add2(number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1); // sonuç 20 dir. Değer tip. Burdan metota gönderilirken number1 değil onun değeri yani 20 gönderilir orda değişen number1 ile burdakinin bir bağı yoktuur
                                        //değişiklik yapılması isteniyorsa metota ref int şeklinde tanımlanmalıdır. bu şekilde 20 den öte direkt number1 ile ilişki kurulmuş olurnur.

            int deger = 0;
            // deger değişkeninin kopyası gönderilecektir.
            // Ekran Çıktısı: metot1() çağrıldıktan sonra:0
            metot1(deger);
            Console.WriteLine("metot1() çağrıldıktan sonra:{0}", deger);

            // deger değişkeninin adresi gönderilecektir.
            // Ekran Çıktısı: metot2() çağrıldıktan sonra:1000
            metot2(ref deger);
            Console.WriteLine("metot2() çağrıldıktan sonra:{0}", deger);

            //ref-out arasındaki fark: ref' te ana değişkene değer atamak zorunludur, metotda kullanılmayabilir. out da tam tersi.
        }
        static int Add2(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
        private static void metot1(int sayi)
        {
            sayi = 1000;
        }
        private static void metot2(ref int sayi)
        {
            sayi = 1000;
        }
    }
}
