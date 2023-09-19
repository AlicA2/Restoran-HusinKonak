namespace HusinKonak.Data
{
    public class Order
    {
        public int OrderId { get; set; }
        public DateTime Date { get; set; }
        public ICollection<OrderItem> OrderItems { get; set; }
        public virtual Delivery Delivery { get; set; }
        public ICollection<Payment> Payments { get; set; }
        //public ICollection<Customer> Customers { get; set; }

        public int TableId { get; set; } // foreign key
        public virtual Table Table { get; set; } // navigation property
    }
}
