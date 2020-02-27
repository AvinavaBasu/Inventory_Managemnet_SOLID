namespace Inventory_Managemnet_SOLID
{
    public interface ITextiles
    {
        string TextileType { get; set; }
        double CalculateTotal(int amount);
    }
}