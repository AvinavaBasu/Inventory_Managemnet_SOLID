using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_Managemnet_SOLID
{
    public class ImportedTextiles: ITextiles
    {
        public double _tax;
        public double Tax { get=>_tax=0.10;}
        string ITextiles.TextileType { get; set; } = "Imported";
        public double CalculateTotal(int amount)
        {
            return amount+amount*Tax;
        }
    }
}
