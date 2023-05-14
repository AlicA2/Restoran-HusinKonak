namespace Restoran.Model
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public bool IsLoyaltyMember { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<CustomerReward> CustomerRewards { get; set; }
    }
    
}
