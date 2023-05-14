using System.ComponentModel.DataAnnotations;

namespace HusinKonak.Data
{
    public class CustomerReward
    {
        [Key]
        public int CustomerId { get; set; }
        [Key]
        public int RewardId { get; set; }
        public Customer Customer { get; set; }
        public Reward Reward { get; set; }
    }
}