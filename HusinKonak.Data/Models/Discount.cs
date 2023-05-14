namespace HusinKonak.Data
{
    public class Discount
    {
        public int DiscountId{ get; set; }
        public int OrderID { get; set; }
        public decimal Amount { get; set; }
        public string Reason { get; set; }
        public virtual Order Order { get; set; }
        public ICollection<DiscountMenuItem> DiscountMenuItems { get; set; }
    }
}
