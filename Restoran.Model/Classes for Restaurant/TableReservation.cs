namespace RestoranApp_HusinKonak.Classes_for_Restaurant
{
    public class TableReservation
    {
        public int TableId { get; set; }
        public virtual Table Table { get; set; }

        public int ReservationId { get; set; }
        public virtual Reservation Reservation { get; set; }
    }
}
