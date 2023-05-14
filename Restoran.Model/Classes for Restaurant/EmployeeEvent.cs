namespace Restoran.Model
{
    public class EmployeeEvent
    {
        public int EmployeeId { get; set; }
        public Employee Employee { get; set; }

        public int EventId { get; set; }
        public Event Event { get; set; }
    }
}
