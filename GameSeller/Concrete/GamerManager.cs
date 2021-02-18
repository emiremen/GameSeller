using GameSeller.Abstract;
using GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Concrete
{
    public class GamerManager : IGamerService
    {
        ICheckIdentityService _service;
        public GamerManager(ICheckIdentityService service)
        {
            _service = service;
        }
        public void Add(Gamer gamer)
        {
            if (_service.Check(gamer))
            {
                Console.WriteLine("Oyuncu Eklendi");
            }
            else
            {
                Console.WriteLine("Kimlik doğrulanamadığı için kullanıcı eklenemedi.");
            }
        }

        public void Delete(Gamer gamer)
        {
            if (_service.Check(gamer))
            {
                Console.WriteLine("Oyuncu Silindi");
            }
            else
            {
                Console.WriteLine("Kimlik doğrulanamadığı için kullanıcı silinemedi.");
            }
        }

        public void Update(Gamer gamer)
        {
            if (_service.Check(gamer))
            {
                Console.WriteLine("Oyuncu Güncellendi");
            }
            else
            {
                Console.WriteLine("Kimlik doğrulanamadığı için kullanıcı güncellenemedi.");
            }
        }
    }
}
