using GameSeller.Abstract;
using GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Concrete
{
    public class BuyGameManager : IBuyGameService
    {
        public void BuyGame(Gamer buyer, GameProduct gameProduct)
        {
            Console.WriteLine(gameProduct.GameName + " Ürünü " + buyer.Name + buyer.Surname + " tarafından " + gameProduct.Price + " fiyatıyla satın alındı.");
        }
    }
}
