using GameProject_Odev5._5_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Odev5._5_.Abstract
{
    public interface IGameService
    {
        void Add(Game game, Gamer gamer, Campain campain);
        void Delete(Game game, Gamer gamer, Campain campain);
        void Update(Game game, Gamer gamer, Campain campain);

    }
}
