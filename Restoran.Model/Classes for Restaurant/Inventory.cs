namespace Restoran.Model
{
    public class Inventory
    {
        public int InventoryId { get; set; }
        public string Name { get; set; }
        public int Quantity { get; set; }
        public decimal PricePerUnit { get; set; }

        public ICollection<MenuItem> MenuItems { get; set; }
    }
}
