namespace Restoran.Model
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string ContactInfo { get; set; }
        public string JobTitle { get; set; }

        public int AdminId { get; set; }
        public Admin Admin { get; set; }
        public ICollection<EmployeeEvent> EmployeeEvents { get; set; }
    }
}
