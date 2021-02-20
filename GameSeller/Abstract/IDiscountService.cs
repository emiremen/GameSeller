using GameSeller.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Abstract
{
    public interface IDiscountService
    {
        void AddDiscount(Discount discount, GameProduct game);
        void DeleteDiscount(Discount discount, GameProduct game);
    }
}
