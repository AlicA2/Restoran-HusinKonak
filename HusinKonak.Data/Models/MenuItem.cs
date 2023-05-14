namespace HusinKonak.Data
{
    public class MenuItem
    {
        public int MenuItemId { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string SpecialInstructions { get; set; }

        public int InventoryId { get; set; } // foreign key
        public virtual Inventory Inventory { get; set; } // navigation property

        public ICollection<DiscountMenuItem> DiscountMenuItems { get; set; }
        public ICollection<OrderItemMenuItem> OrderItemMenuItems { get; set; }
    }
}
