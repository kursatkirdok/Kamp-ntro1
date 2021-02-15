using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Product Urun1 = new Product();
            Urun1.Id = 157;
            Urun1.Price = 15;
            Urun1.UrunAdi = "Elma";
            Urun1.UrunDetayi = "Amasya Elması";

            Product Urun2 = new Product();
            Urun2.Id = 231;
            Urun2.Price = 25;
            Urun2.UrunAdi = "Karpuz";
            Urun2.UrunDetayi = "Diyarbakır Karpuzu";

            Product[] Urunler = new Product[] {Urun1,Urun2 };

            foreach (Product urun in Urunler)
            {
                Console.WriteLine(urun.UrunAdi);
                Console.WriteLine(urun.UrunDetayi);
                Console.WriteLine(urun.Price);
                Console.WriteLine("---------------");
            }

            Console.WriteLine("----------Metodlar---------");
            
            //ENCAPSULATİON

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(Urun1);
            sepetManager.Ekle(Urun2);

            sepetManager.Ekle2("Armut",12,"Yeşil",10);
            sepetManager.Ekle2("elma", 15, "Kırmızı",9);
            sepetManager.Ekle2("Karpuz", 20, "Diyarbakır Karpuzu",8);

        }
    }
}

//Do not repeat yourself - DRY - Clean Code - Best Practice