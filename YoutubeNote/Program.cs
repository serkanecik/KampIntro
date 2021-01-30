using System;

namespace YoutubeNote
{
    class Program
    {
        static void Main(string[] args)
        {
            char character = 'A';
            //double + decimal , int + long
            Console.WriteLine("Character is {0}: ", (int)character);
            var number7 = 10;
            number7 = 'A';
            Console.WriteLine("Number 7 is : {0}", number7);

            int number = 11;
            Console.WriteLine(number == 10 ? "Number = 10" : "Number = not 10"); //koşul

            var result = Add(2, 3); //metot
            Console.WriteLine("Number1 + Number2 = {0}", result);

            int number1 = 20;
            int number2 = 100;
            var result2 = Add2(number1, number2);
            Console.WriteLine(result2);
            Console.WriteLine(number1); // sonuç 20 dir. Değer tip. Burdan metota gönderilirken number1 değil onun değeri yani 20 gönderilir orda değişen number1 ile burdakinin bir bağı yoktuur
                                        //değişiklik yapılması isteniyorsa metota ref int şeklinde tanımlanmalıdır. bu şekilde 20 den öte direkt number1 ile ilişki kurulmuş olurnur.
        }
        enum Gunler
        {
            Pazartesi, Salı, Çarşamba, Perşembe, Cuma, Cumartesi, Pazar
        }
        static int Add(int number1, int number2) //metot
        {
            return number1 + number2; //return metot döndürme
        }
        static int Add2(int number1, int number2)
        {
            number1 = 30;
            return number1 + number2;
        }
    }

}
