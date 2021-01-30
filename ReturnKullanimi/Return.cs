using System;
using System.Collections.Generic;
using System.Text;

namespace ReturnKullanimi
{
    class Return
    {
        public int Topla(int sayi1, int sayi2) //topla programda başka bir yerde kullanılabilir
        {
            return sayi1 + sayi2;
        }
        public void Topla2(int sayi1, int sayi2) //Void = git yap bitir -- topla2 programda başka yerde kullanılaz
        {
            Console.WriteLine(sayi1 + sayi2);
        }
    }
}
