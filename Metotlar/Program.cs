using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            Urun urun1 = new Urun();
            urun1.Id = 1;
            urun1.Adi = "Elma";
            urun1.UrunFiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.StockAdeti = 65;

            Urun urun2 = new Urun();
            urun2.Id = 2 ;
            urun2.Adi = "Karpuz";
            urun2.UrunFiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";
            urun2.StockAdeti = 75;

            Urun[] urunler = new Urun[] {urun1,urun2};

            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.UrunFiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("-------------------------");

            }
            Console.WriteLine("------------Metotlar--------------");

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2(urun1);
            sepetManager.Ekle2(urun2);
            






        }
    }
}
