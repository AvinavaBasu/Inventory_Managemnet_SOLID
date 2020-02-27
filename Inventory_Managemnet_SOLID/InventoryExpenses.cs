using System;
using System.Collections.Generic;
using System.Text;

namespace Inventory_Managemnet_SOLID
{
    public class InventoryExpenses
    {
        List<ITextiles> _textileService;
        public InventoryExpenses()
        {
            _textileService = new List<ITextiles>
            {
                new ImportedTextiles(),
                new LuxuryBrands(),
                new LocalMerchandise()
            };
        }

        public double ExpenseCalculator(string textileType,int amount)
        {
            double total;
            total = _textileService.Find(x => x.TextileType == textileType).CalculateTotal(amount);
            return total;
        }
    }
}
