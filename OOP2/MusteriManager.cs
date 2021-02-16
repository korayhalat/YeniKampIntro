using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2  //Operasyon sınıfı.
{
    class MusteriManager 
    {
        public void Ekle(Musteri musteri)
        {
            Console.WriteLine(musteri.MusteriNo);


        }
        public void Ekle(TuzelMusteri musteri)
        {
            Console.WriteLine(musteri.VergiNo);
        }
    }
}
