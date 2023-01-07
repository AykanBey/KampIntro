using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
 

            Musteri musteri1 = new Musteri();
            musteri1.ID = 01;
            musteri1.MusteriAdi = "Ahmet";
            musteri1.MusteriSoyadi = "Usta";
            musteri1.MusteriBilgi = "Genç Bankacılık";

            Musteri musteri2 = new Musteri();
            musteri2.ID = 02;
            musteri2.MusteriAdi = "Sefa";
            musteri2.MusteriSoyadi = "Özer";
            musteri2.MusteriBilgi = "Emekli Bankacılık Uugulaması";

            Musteri[] musteriler = new Musteri[] { musteri1, musteri2 };
            foreach (var m in musteriler)
            {
                Console.WriteLine(m.ID);
                Console.WriteLine(m.MusteriAdi);
                Console.WriteLine(m.MusteriSoyadi);
                Console.WriteLine(m.MusteriBilgi);
                Console.WriteLine("[+-+]");
            }

            Console.WriteLine("Ekleme - Listeleme - Kaldırma İşlemleri");

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Ekle(musteri2);

            musteriManager.Listele(musteri1);
            musteriManager.Listele(musteri2);

            musteriManager.Kaldır(musteri1);
            musteriManager.Kaldır(musteri2);





        }
    }
}
