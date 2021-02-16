using GameProject_Odev5._5_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Odev5._5_.Abstract
{
    public interface ICampainService
    {
        void Add(Campain campain, Gamer gamer);
        void Delete(Campain campain);
        void Update(Campain campain);

    }
}
