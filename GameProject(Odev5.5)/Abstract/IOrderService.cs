using GameProject_Odev5._5_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Odev5._5_.Abstract
{
    public interface IOrderService
    {
        void Done(Order order, Gamer gamer);
        void Non(Order order, Gamer gamer);

    }
}
