using GameProject_Odev5._5_.Abstract;
using GameProject_Odev5._5_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Odev5._5_.Concrete
{
    public class NewEUserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.Id==1&&gamer.FirstName=="Koray"&&gamer.LastName=="Halat"&&gamer.BirthYear==1979&&gamer.TcNo=="123456")
            {                
                return true;
            }
            else
            {                
                return false;
            }
            
        }
    }
}
