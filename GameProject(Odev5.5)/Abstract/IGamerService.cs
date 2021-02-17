using GameProject_Odev5._5_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Odev5._5_.Abstract
{
    public interface IGamerService
    {
        bool Add(Gamer gamer);
        void Delete(Gamer gamer);
        void Update(Gamer gamer);
    }
}
