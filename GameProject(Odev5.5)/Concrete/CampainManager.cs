using GameProject_Odev5._5_.Abstract;
using GameProject_Odev5._5_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Odev5._5_.Concrete
{
    public class CampainManager : ICampainService
    {
        public void Add(Campain campain, Gamer gamer)
        {
            Console.WriteLine("Sn. " +gamer.FirstName+" "+gamer.LastName+"  "+campain.CampainName+ " "+campain.CampainDiscont+ " "+ " KAZANDINIZ!!");
        }

        public void Delete(Campain campain)
        {
            Console.WriteLine("Kampanya süresi olan : " + campain.CampainTime + " günün sonunda Kampanyanız silinmiştir!!");
        }

        public void Update(Campain campain)
        {
            Console.WriteLine("Kampanyanız Güncellenmiştir...");
        }
    }
}
