using System;

namespace YeniKampIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string KategpriEtiketi = "Kategori";
            int OgrenciSayisi = 32000;
            double FaizOrani = 1.45;
            bool SistemeGirisYapmisMi = false;
            double DolarDun = 7.55;
            double DolarBugun = 7.55;
            if (DolarDun>DolarBugun)
            {
                Console.WriteLine("Azalış Butonu");
            }
            else if (DolarDun<DolarBugun)
            {
                Console.WriteLine("Artış Butonu");
            }
            else
            {
                Console.WriteLine("Değişmedi");
            }
            if (SistemeGirisYapmisMi == false)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
        }
    }
}
