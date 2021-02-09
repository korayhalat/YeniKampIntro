using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager 
    {
        public void BasvuruYap(IKrediManager krediManager ,ILoggerService loggerService) // BasvuruYap ın içerisine hangi kredi parametresi yollarsam
        {                                                  //artık aşağıda onun Hesapla() methodu çalışır.
            
            //Baş vuran bilgilerini değerlendirme
            krediManager.Hesapla();
            loggerService.Log();
                      
            
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler) // 1 den fazla kredi için Liste oluşturmamız lazım
        {                                                                   // Listenin türede IKrediManager olmalı.
            foreach (var kredi in krediler) //Bütün krediler için yap.
            {
                kredi.Hesapla();
            }
        }
    }
}
