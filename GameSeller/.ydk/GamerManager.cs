using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller
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
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Oyuncu Kayıt Oldu");
            }
            else
            {
                throw new Exception("Gamer not valid");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Oyuncu Silindi");
            }
            else
            {
                throw new Exception("Gamer not valid");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_userValidationService.Validate(gamer))
            {
                Console.WriteLine("Oyuncu Güncellendi");
            }
            else
            {
                throw new Exception("Gamer not valid");
            }
        }
    }
}
