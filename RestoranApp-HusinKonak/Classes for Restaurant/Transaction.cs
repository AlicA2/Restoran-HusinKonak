namespace RestoranApp_HusinKonak.Classes_for_Restaurant
{
    public class Transaction
    {
        public int TransactionId { get; set; }
        public DateTime Date { get; set; }
        public decimal Amount { get; set; }
        public ICollection<Payment> Payments { get; set; }
    }
}
