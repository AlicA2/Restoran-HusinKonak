using Microsoft.EntityFrameworkCore;

namespace Restoran.Model
{
    public class Admin
    {
        public int AdminId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        public ICollection<Employee> Employees { get; set; }
    }
}
