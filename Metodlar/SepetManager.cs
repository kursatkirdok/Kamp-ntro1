using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {//naming Convention
        //Syntax
        public void Ekle(Product urun)
        {
            Console.WriteLine("Sepete eklendi: "+urun.UrunAdi);

        }

        public void Ekle2(string urunAdi,double Fiyati, string aciklama, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi! : "+urunAdi);
        }
    }
}
