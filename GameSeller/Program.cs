
using GameSeller.Abstract;
using GameSeller.Concrete;
using GameSeller.Entities;
using System;

namespace GameSeller
{
    class Program
    {
        static void Main(string[] args)
        {
            // Mernis ile kimlik doğrulaması yapıldığı için gerçek bilgiler verilmelidir.
            Gamer gamer1 = new Gamer { Id = 1, Name = "Muhammed", Surname = "EMEN", BirthYear = 1995, IdentityNumber = 12345 };
            GamerManager gamerService = new GamerManager(new CheckIdentityManager());
            gamerService.Add(gamer1);
            gamerService.Update(gamer1);
            Console.ReadKey();
        }
    }
}
