using System;

namespace Inventory_Managemnet_SOLID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to SOLID's inventory management system!");
            double tatalExpenseIncurred = 0;
            InventoryExpenses inventoryExpenses = new InventoryExpenses();
            tatalExpenseIncurred+=inventoryExpenses.ExpenseCalculator("Imported", 1500);

            Console.WriteLine("Total expenses incurred textiles {0}", tatalExpenseIncurred); //1650
        }
    }
}
