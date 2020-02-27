using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_Managemnet_SOLID
{
    public class LocalMerchandise : ITextiles
    {
        public double _tax;
        public double Tax { get => _tax=0.05;}
        string ITextiles.TextileType { get; set; } = "Local";
        public double CalculateTotal(int amount)
        {
            return amount + amount * Tax;
        }
    }
}
