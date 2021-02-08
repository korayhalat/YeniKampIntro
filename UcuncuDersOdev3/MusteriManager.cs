using System;
using System.Collections.Generic;
using System.Text;

namespace UcuncuDersOdev3
{
    class MusteriManager
    {
        public void Ekle(Musteri musteri) 
        {
            Console.WriteLine("Tebrikler Müşteri Eklenmiştir!" + musteri.Adi);
        }
        public void Liste(Musteri musteri)
        {
            Console.WriteLine("Müşteri Listesi : " + musteri.Id);
        }
        public void Silme(Musteri musteri) 
        {
            Console.WriteLine("Silme İşlemi Gerçekleşti !!" + musteri.TcNo  );
        }
    }
}
