using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gun3Odev2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ref tipi kullandığımızda 140 sonucuna ulaşırız. Aşağıdaki örnek gibi:
            int sayi1 = 50;
            int sayi2 = 30;
            Console.WriteLine(Topla(sayi1, ref sayi2));
            Console.WriteLine($"1.Sayı : {sayi1} 2. Sayı: {sayi2} Toplam: {sayi1 + sayi2}");
        }

        static int Topla(int sayi1, ref int sayi2)
        {
            sayi2 = 90;
            return sayi1 + sayi2;
        }
    }
}

