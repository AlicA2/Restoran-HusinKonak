namespace HusinKonak.Data
{
    public class Reward
    {
        public int RewardId { get; set; }
        public int EmployeeID { get; set; }
        public string Description { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }

        public virtual Employee Employee { get; set; }
        public ICollection<CustomerReward> CustomerRewards { get; set; }
    }

}
