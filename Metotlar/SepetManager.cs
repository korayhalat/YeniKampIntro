using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler , Sepete eklendi : " + urun.Adi);
        }
        public void Ekle2(Urun urun) 
        {
            Console.WriteLine("Stock Adeti : " + urun.StockAdeti);
        }
    }
}
