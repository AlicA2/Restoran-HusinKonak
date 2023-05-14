namespace RestoranApp_HusinKonak.Classes_for_Restaurant
{
    public class OrderItemMenuItem
    {
        public int MenuItemId { get; set; }
        public int OrderItemId { get; set; }

        public virtual MenuItem MenuItem { get; set; }
        public virtual OrderItem OrderItem { get; set; }
    }
}
