using System;

namespace classİntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Kürşat";
            int yas = 21;

            Kurs kurs1 = new Kurs();
            kurs1.KursAdi = "c#";
            kurs1.egitmen = "Engin";
            kurs1.İzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();
            kurs2.KursAdi = "jAVa";
            kurs2.egitmen = "Berkay";
            kurs2.İzlenmeOrani = 88;

            Kurs kurs3 = new Kurs();
            kurs3.KursAdi = "Phyton";
            kurs3.egitmen = "Jale";
            kurs3.İzlenmeOrani = 77;

            //Console.WriteLine(kurs1.KursAdi + " " + kurs1.egitmen);
            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 };

            foreach (Kurs kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi);
            }
        }
    }

    class Kurs
    {
        public string KursAdi { get; set; }
        public string egitmen { get; set; }
        public int İzlenmeOrani { get; set; }
    }
}
