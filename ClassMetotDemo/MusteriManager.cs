using System;
using System.Collections.Generic;
using System.Text;

namespace ClassMetotDemo
{
    class MusteriManager
    {
        public void add(Musteri musteri)
        {
            Console.WriteLine("Müşteri Eklendi. : "+musteri.MusteriAdi+" "+musteri.MusteriSoyadi);
        }
        public void remove(Musteri musteri)
        {
            Console.WriteLine("Müşteri Silindi. : " + musteri.MusteriAdi +" "+ musteri.MusteriSoyadi);
        }
        public void listing(Musteri musteri)
        {
            Console.WriteLine("Müşteri listelendi. : " + musteri.MusteriAdi +" "+ musteri.MusteriSoyadi);
        }
    }
}
