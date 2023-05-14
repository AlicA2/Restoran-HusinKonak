using System.ComponentModel.DataAnnotations;

namespace HusinKonak.Data
{
    public class OrderItemReview
    {
        [Key]
        public int OrderItemReviewId { get; set; }
        public int OrderItemId { get; set; }
        public OrderItem OrderItem { get; set; }
        public int ReviewId { get; set; }
        public Review Review { get; set; }
    }
}
