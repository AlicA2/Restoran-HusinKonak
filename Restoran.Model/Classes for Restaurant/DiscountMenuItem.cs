namespace Restoran.Model
{
    public class DiscountMenuItem
    {
        public int DiscountID { get; set; }
        public Discount Discount { get; set; }
        public int MenuItemID { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
