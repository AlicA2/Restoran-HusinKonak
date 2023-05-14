using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Restoran.Model;
using RestoranApp_HusinKonak.Data;

namespace RestoranApp_HusinKonak.Controllers
{ 

        [ApiController]
        [Route("api/[controller]")]

        public class OrdersController : ControllerBase
        {
            private readonly RestaurantDBContext _context;

            public OrdersController(RestaurantDBContext context)
            {
                _context = context;
            }

            // GET: api/orders
            [HttpGet]
            public ActionResult<IEnumerable<Order>> GetOrders()
            {
                var orders = _context.Orders
                    .Include(o => o.OrderItems)
                    .Include(o => o.Customers)
                    .Include(o => o.Delivery)
                    .Include(o => o.Payments)
                    .Include(o => o.Table)
                    .ToList();
                return orders;
            }

            // GET: api/orders/5
            [HttpGet("{id}")]
            public ActionResult<Order> GetOrder(int id)
            {
                var order = _context.Orders
                    .Include(o => o.OrderItems)
                    .Include(o => o.Customers)
                    .Include(o => o.Delivery)
                    .Include(o => o.Payments)
                    .Include(o => o.Table)
                    .FirstOrDefault(o => o.OrderId == id);

                if (order == null)
                {
                    return NotFound();
                }

                return order;
            }

            // POST: api/orders
            [HttpPost]
            public ActionResult<Order> PostOrder(Order order)
            {
                _context.Orders.Add(order);
                _context.SaveChanges();

                return CreatedAtAction(nameof(GetOrder), new { id = order.OrderId }, order);
            }

            // PUT: api/orders/5
            [HttpPut("{id}")]
            public IActionResult PutOrder(int id, Order order)
            {
                if (id != order.OrderId)
                {
                    return BadRequest();
                }

                _context.Entry(order).State = EntityState.Modified;
                _context.SaveChanges();

                return NoContent();
            }

            // DELETE: api/orders/5
            [HttpDelete("{id}")]
            public IActionResult DeleteOrder(int id)
            {
                var order = _context.Orders.Find(id);
                if (order == null)
                {
                    return NotFound();
                }

                _context.Orders.Remove(order);
                _context.SaveChanges();

                return NoContent();
            }
        }
    }
