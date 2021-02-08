using System;

namespace UcuncuDersOdev3
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri1 = new Musteri();
            musteri1.Id = 1;
            musteri1.Adi = "Burcin";
            musteri1.SoyAdi = "Erkan";
            musteri1.TcNo = "123456789101";
            musteri1.SubeNo = 123456;

            Musteri musteri2 = new Musteri();
            musteri2.Id = 2;
            musteri2.Adi = "Koray";
            musteri2.SoyAdi = "Halat";
            musteri2.TcNo = "123456789101";
            musteri2.SubeNo = 123456;
            
            Musteri musteri3 = new Musteri();
            musteri3.Id = 3;
            musteri3.Adi = "Can";
            musteri3.SoyAdi = "Toygar";
            musteri3.TcNo = "123456789101";
            musteri3.SubeNo = 123456;

            Musteri musteri4 = new Musteri();
            musteri4.Id = 4;
            musteri4.Adi = "Batuhan";
            musteri4.SoyAdi = "Sezer";
            musteri4.TcNo = "123456789101";
            musteri4.SubeNo = 123456;

            Musteri[] musteriler = new Musteri[] {musteri1,musteri2,musteri3,musteri4};

            MusteriManager musteriManager = new MusteriManager();

            musteriManager.Ekle(musteri1);
            musteriManager.Liste(musteri1);
            musteriManager.Silme(musteri1);

















        }






    }
}
