using GameProject_Odev5._5_.Abstract;
using GameProject_Odev5._5_.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject_Odev5._5_.Concrete
{
    public class GamerManager : IGamerService
    {
        IUserValidationService _userValidationService;

        public GamerManager(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }

        public void Add(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer)==true)
            {
                Console.WriteLine("Kayıt Doğrulamıştır!!");                
            }
            else
            {
                Console.WriteLine("Geçersiz Kayıt!");
                
            }
        }

        public void Delete(Gamer gamer)
        {
            //if (_userValidationService.Validate(gamer) == true)
            //{
            //    Console.WriteLine("Geçerli Kayıt. Silme işleminiz Gerçekleştirildi!");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz Kayıt!");
            //}
            Console.WriteLine("Kayıt Silndi");
        }

        public void Update(Gamer gamer)
        {
            //if (_userValidationService.Validate(gamer) == true)
            //{
            //    Console.WriteLine("Geçerli Kayıt! Güncelleme İşlemimiz Gerçekleştirilmiştir!");
            //}
            //else
            //{
            //    Console.WriteLine("Geçersiz Kayıt!");
            //}
            Console.WriteLine("Kayıt güncellendi");
        }
    }
}
