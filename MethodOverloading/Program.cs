using System;
using System.Linq; //sum fonksiyonunu kullanmak için

namespace MethodOverloading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Multiply(2, 4));
            Console.WriteLine(Multiply2(2, 4, 5)); //metotların aşırı yüklenmesi
            Console.WriteLine(Toplam(1, 2, 3, 4, 5, 6));
        }
        static int Multiply(int number1, int number2) //int Multiply(int number1, int number2 = metotun imzası
        {
            return number1 * number2;
        }
        static int Multiply2(int number1, int number2, int number3)
        {
            return number1 * number2 * number3;
        }
        static int Toplam(int number1, params int[] numbers) // istediğimiz kadar parametre gönderebiliriz--- number1' e 1 sayısı yerleşir
        {
            return numbers.Sum(); //gelen tüm değerleri toplar
        }
    }
}
