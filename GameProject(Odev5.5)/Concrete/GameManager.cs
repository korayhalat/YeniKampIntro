using GameProject_Odev5._5_.Abstract;
using GameProject_Odev5._5_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Odev5._5_.Concrete
{
    public class GameManager : IGameService
    {
        public void Add(Game game, Gamer gamer, Campain campain)
        {
            Console.WriteLine("Sn. "+gamer.FirstName+" "+gamer.LastName+ ":  "+game.GameName+"- Oyunu Kütüphanenize Eklenmiştir!");
        }

        public void Delete(Game game, Gamer gamer, Campain campain)
        {
            Console.WriteLine("Sn. " + gamer.FirstName + " " + gamer.LastName + ":  " + game.GameName + "- Oyunu Kütüphanenizden Silinmiştir!");
        }

        public void Update(Game game, Gamer gamer, Campain campain)
        {
            Console.WriteLine("Sn. " + gamer.FirstName + " " + gamer.LastName + ":  " + game.GameName + "- Oyunu Güncellenmiştir!");
        }
    }
}
