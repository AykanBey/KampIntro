using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Gün2Odev6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun Urun1 = new Urun();
            Urun1.id = 100;
            Urun1.Adi = "Irmak Toz Şeker 5 Kg";
            Urun1.İndirimliFiyat = 107.90;
            Urun1.İndirimOrani = "%5 İndirim";


            Urun Urun2 = new Urun();
            Urun2.id = 101;
            Urun2.Adi = "Sinangil Un 2 Kg";
            Urun2.İndirimliFiyat = 24.90;
            Urun2.İndirimOrani = "%34 İndirim";


            Urun Urun3 = new Urun();
            Urun3.id = 102;
            Urun3.Adi = "Tamek Domates Salçası 830G";
            Urun3.İndirimliFiyat = 34.90;
            Urun3.İndirimOrani = "%22 İndirim";


            Console.WriteLine("Birlikten Berekete Ürünleri:");
            Console.WriteLine("------------- [->] Foreach döngüsü Başladı. --------------");

            Urun[] urunler = new Urun[] { Urun1, Urun2, Urun3 };
            {
                foreach (Urun urun in urunler)
                {
                    Console.WriteLine("URUN ID : " + urun.id + "\n" + urun.Adi + "\n" + "Ürün Fiyatı : " + urun.İndirimliFiyat + "\n");
                }

                Console.WriteLine("------------- [->] While döngüsü Başladı. -------------");

                int i = 0;
                while (i < urunler.Length)
                {
                    Console.WriteLine("URUN ID : " + urunler[i].id + "\n" + urunler[i].Adi + "\n" + "Ürün Fiyatı : " + urunler[i].İndirimliFiyat + "\n");
                    i++;
                }
                Console.WriteLine("------------- [->] For döngüsü Başladı. ---------------");

                for (int j = 0; j < urunler.Length; j++)
                    {
                        Console.WriteLine("URUN ID : " + urunler[j].id + "\n" + urunler[j].Adi + "\n" + "Ürün Fiyatı : " + urunler[j].İndirimliFiyat + "\n");

                    }
                }
            }
        }
    }

class Urun
{
    public string urun { get; set; }

    public string Adi { get; set; }

    public double id { get; set; }

    public double İndirimliFiyat { get; set; }

    public string İndirimOrani { get; set; }

}
