using HusinKonak.Data;
using HusinKonak.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace RestoranApp_HusinKonak.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : Controller
    {
        private readonly RestaurantDBContext _context;

        public ContactController(RestaurantDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contact>>> GetContacts()
        {
            var contacts = await _context.Contacts.ToListAsync();
            return Ok(contacts);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContact(Contact contact)
        {
            if (ModelState.IsValid)
            {
                _context.Contacts.Add(contact);
                await _context.SaveChangesAsync();

                return CreatedAtAction(nameof(GetContacts), new { id = contact.ContactID }, contact);
            }

            return BadRequest(ModelState);
        }
    }
}
