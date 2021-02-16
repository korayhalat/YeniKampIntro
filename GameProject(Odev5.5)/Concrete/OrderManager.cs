using GameProject_Odev5._5_.Abstract;
using GameProject_Odev5._5_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Odev5._5_.Concrete
{
    public class OrderManager : IOrderService
    {
        public void Done(Order order, Gamer gamer)
        {
            Console.WriteLine("Sn. " + gamer.FirstName + " " + gamer.LastName + ":  " +order.OrderPiece +". taksit Ödenmiştir!");
        }

        public void Non(Order order, Gamer gamer)
        {
            Console.WriteLine("Sn. " + gamer.FirstName + " " + gamer.LastName + ":  " + order.OrderPiece + ". taksit Ödemesi Başarısız!");
        }
    }
}
