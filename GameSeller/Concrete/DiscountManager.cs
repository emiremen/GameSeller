using GameSeller.Abstract;
using GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Concrete
{
    public class DiscountManager : IDiscountService
    {
        float defaultPrice;
        public void AddDiscount(Discount discount, GameProduct game)
        {
            if (discount.isValid)
            {
                defaultPrice = game.Price;
                game.Price = game.Price - discount.PercentOfDiscount * (game.Price / 100);
                Console.WriteLine(game.GameName + " İndirim eklendi. İndirimli fiyatı : TL" + game.Price);
            }
        }

        public void DeleteDiscount(Discount discount, GameProduct game)
        {
            if (discount.isValid)
            {
                discount.isValid = false;
                game.Price = defaultPrice;
                Console.WriteLine(game.GameName + " indirimi silinmiştir. İndirimsiz fiyat: TL" + game.Price);
            }
        }
    }
}
