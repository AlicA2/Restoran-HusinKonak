namespace RestoranApp_HusinKonak.Classes_for_Restaurant
{
    public class EmployeeEvent
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
