using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] kurslar = { "Yazılım Geliştirici Yetiştirme Kampı" , "Programlamaya başlangıç için temel kurs" , "Java" , "Python" , "C#" , "C++" };

            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("For Burada bitiyor");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);

            }

            Console.WriteLine("Sayfa Sonu - Footer");

        }
    }
}
