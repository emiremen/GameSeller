
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


            GameProduct game1 = new GameProduct { Id = 1, GameName = "Witcher 2", Price = 80 };

            Discount discount = new Discount {
                Id = 1,
                isValid = true,
                GameProduct = game1,
                PercentOfDiscount = 50
            };

            DiscountManager discountManager = new DiscountManager();
            discountManager.AddDiscount(discount,game1);
            discountManager.DeleteDiscount(discount,game1);

            BuyGameManager buyGameManager = new BuyGameManager();
            buyGameManager.BuyGame(gamer1, game1);


            Console.ReadKey();

        }
    }
}
