using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_Managemnet_SOLID
{
    public class LuxuryBrands : ITextiles
    {
        public double _tax;
        public double Tax { get => _tax = 0.20;}
        string ITextiles.TextileType { get; set; } = "Luxury";
        public double CalculateTotal(int amount)
        {
            return amount + amount * Tax;
        }
    }
}
