namespace RestoranApp_HusinKonak.Classes_for_Restaurant
{
    public class Delivery
    {
        public int DeliveryId { get; set; }
        public int OrderID { get; set; }
        public DateTime DeliveryDate { get; set; }
        public TimeSpan DeliveryTime { get; set; }
        public string DeliveryAdress { get; set; }
        public virtual Order Order { get; set; }
    }
}
