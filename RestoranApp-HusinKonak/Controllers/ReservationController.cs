using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using HusinKonak.Data; // Dodajte odgovarajući namespace za pristup klasi Reservation

namespace HusinKonak.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ReservationController : ControllerBase
    {
        private readonly RestaurantDBContext _context; // Dodajte vaš DbContext, ovisno o vašem pristupu podacima

        public ReservationController(RestaurantDBContext context)
        {
            _context = context;
        }

        // GET: api/Reservation
        [HttpGet]
        public IActionResult GetReservations()
        {
            var reservations = _context.Reservations.ToList();
            return Ok(reservations);
        }

        // GET: api/Reservation/{id}
        [HttpGet("{id}")]
        public IActionResult GetReservation(int id)
        {
            var reservation = _context.Reservations.FirstOrDefault(r => r.ReservationId == id);

            if (reservation == null)
            {
                return NotFound();
            }

            return Ok(reservation);
        }

        // POST: api/Reservation
        [HttpPost]
        public IActionResult CreateReservation([FromBody] Reservation reservation)
        {
            if (reservation == null)
            {
                return BadRequest();
            }

            _context.Reservations.Add(reservation);
            _context.SaveChanges();

            return CreatedAtAction("GetReservation", new { id = reservation.ReservationId }, reservation);
        }

        // PUT: api/Reservation/{id}
        [HttpPut("{id}")]
        public IActionResult UpdateReservation(int id, [FromBody] Reservation reservationData)
        {
            var reservation = _context.Reservations.FirstOrDefault(r => r.ReservationId == id);

            if (reservation == null)
            {
                return NotFound();
            }

            // Ažurirajte svojstva rezervacije prema podacima iz reservationData objekta

            _context.SaveChanges();

            return NoContent();
        }

        // DELETE: api/Reservation/{id}
        [HttpDelete("{id}")]
        public IActionResult DeleteReservation(int id)
        {
            var reservation = _context.Reservations.FirstOrDefault(r => r.ReservationId == id);

            if (reservation == null)
            {
                return NotFound();
            }

            _context.Reservations.Remove(reservation);
            _context.SaveChanges();

            return NoContent();
        }
    }
}
