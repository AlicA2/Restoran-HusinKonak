namespace RestoranApp_HusinKonak.Classes_for_Restaurant
{
    public class DiscountMenuItem
    {
        public int DiscountID { get; set; }
        public Discount Discount { get; set; }
        public int MenuItemID { get; set; }
        public MenuItem MenuItem { get; set; }
    }
}
