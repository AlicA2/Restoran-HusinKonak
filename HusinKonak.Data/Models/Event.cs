namespace HusinKonak.Data
{
    public class Event
    {
        public int EventId { get; set; }
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public string Description { get; set; }
        public ICollection<EmployeeEvent> EmployeeEvents { get; set; }
    }
}
