using GameProject_Odev5._5_.Concrete;
using GameProject_Odev5._5_.Entities;
using System;

namespace GameProject_Odev5._5_
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEUserValidationManager());
            Gamer gamer = new Gamer() { Id = 1, FirstName = "Koray", LastName = "Halat", BirthYear = 1979, TcNo = "123456" };
            bool sonuc = gamerManager.Add(gamer);
            if (!sonuc)
                return;
            //gamerManager.Add(new Gamer { Id = 1, FirstName = "Koray", LastName = "Halat", BirthYear = 1979, TcNo = "123456" });

            Campain campain = new Campain() { Id = 1, CampainName = "Yeni Giriş Kampanyası", CampainTime = 45, CampainDiscont = "%25" };
            Game game = new Game() { Id = 1, GameName = "Last Of Us", Size = 52, GamePrice = 750 };
            Order order = new Order() { OrderPrice = 720, OrderPiece = 1 };


            GameManager gameManager1 = new GameManager();
            gameManager1.Add(game, gamer, campain);
            gameManager1.Delete(game, gamer, campain);
            gameManager1.Update(game, gamer, campain);

            Console.WriteLine("------------------------------------");

            CampainManager campain1 = new CampainManager();
            campain1.Add(campain, gamer);
            campain1.Delete(campain);
            campain1.Update(campain);

            Console.WriteLine("------------------------------------");

            OrderManager order1 = new OrderManager();
            order1.Done(order, gamer);
            order1.Non(order, gamer);


        }
    }
}
