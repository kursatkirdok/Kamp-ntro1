using System;

namespace ClassMetotDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();
            musteri.Id = 157;
            musteri.MusteriAdi = "Kürşat";
            musteri.MusteriSoyadi = "Kırdök";

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.add(musteri);
            musteriManager.remove(musteri);
            musteriManager.listing(musteri);

        }
    }
}
