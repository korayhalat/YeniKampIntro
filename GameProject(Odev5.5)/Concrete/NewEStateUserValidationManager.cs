using GameProject_Odev5._5_.Abstract;
using GameProject_Odev5._5_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Odev5._5_.Concrete
{
    public class NewEStateUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            return true;
        }
    }
}
