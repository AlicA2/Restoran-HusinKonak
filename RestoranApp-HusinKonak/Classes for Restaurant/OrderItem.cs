namespace RestoranApp_HusinKonak.Classes_for_Restaurant
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int OrderID { get; set; }
        public string Product { get; set; }
        public double Price { get; set; }
        public int Quantity { get; set; }
        public ICollection<OrderItemMenuItem> OrderItemMenuItems { get; set; }
        public ICollection<OrderItemReview> OrderItemReviews { get; set; }
        //public ICollection<Review> Reviews { get; set; } // Add this line
    }
}
