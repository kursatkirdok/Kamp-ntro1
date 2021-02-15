using System;

namespace Odev6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product = new Product();
            product.name = "Ceket";
            product.id = 157;
            product.price = 120;

            Product product1 = new Product();
            product1.name = "Akıllı Telefon";
            product1.id = 777;
            product1.price = 5000;

            Product product2 = new Product();
            product2.name = "Saat";
            product2.id = 225;
            product2.price = 250;

            Product[] products = new Product[] { product, product1, product2 };
            string[] products1 = new string[] {"Ceket","Akıllı telefon","Saat" };
            for (int i = 0; i<products1.Length; i++)
            {
                Console.WriteLine(products1[i]);
            }
            foreach (var product_ in products)
            {
                Console.WriteLine(product_.name);
            }
            int p = 0;
            while (p<products1.Length)
            {
                Console.WriteLine(products1[p]);
                p++;
            }

        }
        class Product
        {
            public string name { get; set; }
            public int id { get; set; }
            public int price { get; set; }
        }
    }
    }

