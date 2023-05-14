namespace Restoran.Model
{ 
    public class Table
    {
        public int TableId { get; set; }
        public int NumberOfSeats { get; set; }
        public string Location { get; set; }

        public virtual Order Order { get; set; } // navigation property
        public virtual ICollection<TableReservation> TableReservations { get; set; }
    }
}
