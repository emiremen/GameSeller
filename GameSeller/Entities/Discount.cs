using System;
using System.Collections.Generic;
using System.Text;

namespace GameSeller.Entities
{
    public class Discount
    {
        public int Id { get; set; }
        public bool isValid { get; set; }
        public int PercentOfDiscount { get; set; }
        public GameProduct GameProduct { get; set; }
    }
}
