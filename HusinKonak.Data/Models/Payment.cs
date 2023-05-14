namespace HusinKonak.Data
{
    public class Payment
    {
        public int PaymentId { get; set; }
        public int OrderId { get; set; }
        public string PaymentMethod { get; set; }
        public decimal Amount { get; set; }
        public virtual Order Order { get; set; }
        public int TransactionId { get; set; }
        public virtual Transaction Transaction { get; set; }
    }
}
