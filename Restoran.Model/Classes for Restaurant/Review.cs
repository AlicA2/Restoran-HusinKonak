namespace RestoranApp_HusinKonak.Classes_for_Restaurant
{
    public class Review
    {
        public int ReviewId { get; set; }
        public int CustomerID { get; set; }
        public DateTime Date { get; set; }
        public string Text { get; set; }
        public virtual Customer Customer { get; set; }
        public ICollection<OrderItemReview> OrderItemReviews { get; set; }
    }
}
