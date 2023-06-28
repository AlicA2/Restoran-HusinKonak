using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using HusinKonak.Data;
using RestoranApp_HusinKonak.ViewModels;

namespace HusinKonak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomersController : ControllerBase
    {
        private readonly RestaurantDBContext _dbContext;

        public CustomersController(RestaurantDBContext context)
        {
            _dbContext = context;
        }





        [HttpPost("authenticate")]
        public async Task<IActionResult> Authenticate([FromBody] LoginModel custObj)
        {
            if (custObj == null)
                return BadRequest();

            var user = await _dbContext.Customers.
                FirstOrDefaultAsync(x => x.Name == custObj.Name && x.Password == custObj.Password);

            if (user == null)
                return NotFound(new { Message = "User not found!" });

            return Ok(new { Message = "Login success" });
        }

        [HttpPost("register")]
        public async Task<IActionResult> RegisterUser([FromBody] Customer custObj)
        {
            if (custObj == null)
                return BadRequest();

            await _dbContext.Customers.AddAsync(custObj);
            await _dbContext.SaveChangesAsync();

            return Ok(new { Message = "User Registered!" });
        }

        // GET: api/customers
        [HttpGet]
        public async Task<IActionResult> GetCustomers()
        {
            return this.Ok(await _dbContext.Customers.ToListAsync());
        }

        // GET: api/customers/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Customer>> GetCustomer(int id)
        {
            var customer = await _dbContext.Customers.FindAsync(id);

            if (customer == null)
            {
                return NotFound();
            }

            return customer;
        }

        // POST: api/customers
        [HttpPost]
        public async Task<ActionResult<Customer>> PostCustomer(Customer customer)
        {
            _dbContext.Customers.Add(customer);
            await _dbContext.SaveChangesAsync();

            return CreatedAtAction(nameof(GetCustomer), new { id = customer.CustomerId }, customer);
        }

        // PUT: api/customers/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCustomer(int id, Customer customer)
        {
            if (id != customer.CustomerId)
            {
                return BadRequest();
            }

            _dbContext.Entry(customer).State = EntityState.Modified;

            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CustomerExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // DELETE: api/customers/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCustomer(int id)
        {
            var customer = await _dbContext.Customers.FindAsync(id);
            if (customer == null)
            {
                return NotFound();
            }

            _dbContext.Customers.Remove(customer);
            await _dbContext.SaveChangesAsync();

            return NoContent();
        }

        private bool CustomerExists(int id)
        {
            return _dbContext.Customers.Any(e => e.CustomerId == id);
        }
    }
}