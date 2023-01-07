using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMetotDemo
{
    internal class MusteriManager
    {
        
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + "buraya eklendi\n");
        }
        public void Listele(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + "hakkındaki bilgiler:");
            Console.WriteLine("Müşteri ID : " + musteri.ID + "\n" + "Müşteri Adı : " + musteri.MusteriAdi + "\n" + "Müşteri Soyadı:" + musteri.MusteriSoyadi + "\n" + "Müşterinin Banka Planı:" + musteri.MusteriBilgi + "\n");
        }
        public void Kaldır(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriAdi + "sistemden kaldırıldı.\n");
            
        }
    }
}
