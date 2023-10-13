using Microsoft.AspNetCore.Mvc;
using HusinKonak.Data.Modul2.Models;
using HusinKonak.Data.ViewModels;
using System.Linq;
using HusinKonak.Data;

namespace HusinKonak.Controllers
{
    [Route("api/dostava")]
    [ApiController]
    public class DostavaController : ControllerBase
    {
        private readonly RestaurantDBContext _context;

        public DostavaController(RestaurantDBContext context)
        {
            _context = context;
        }

        [HttpGet]
        public ActionResult GetDostave()
        {
            var dostave = _context.Dostava
                .Select(d => new DostavaGetVM
                {
                    Id = d.Id,
                    Cijena = d.Cijena,
                    Kolicina = d.Kolicina,
                    Adresa = d.Adresa,
                    BrojTelefona=d.BrojTelefona,
                    korisnik_id = d.korisnik_id,
                    meni_id = d.meni_id
                })
                .ToList();

            return Ok(dostave);
        }

        [HttpGet("{id}")]
        public ActionResult<DostavaGetVM> GetDostava(int id)
        {
            var dostava = _context.Dostava.FirstOrDefault(d => d.Id == id);

            if (dostava == null)
                return NotFound();

            var dostavaGetVM = new DostavaGetVM
            {
                Id = dostava.Id,
                Cijena = dostava.Cijena,
                Kolicina = dostava.Kolicina,
                Adresa = dostava.Adresa,
                BrojTelefona = dostava.BrojTelefona,
                korisnik_id = dostava.korisnik_id,
                meni_id = dostava.meni_id
            };

            return Ok(dostavaGetVM);
        }

        [HttpPost]
        public ActionResult<DostavaGetVM> AddDostava(DostavaAddVM model)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var novaDostava = new Dostava
            {
                Cijena = model.Cijena,
                Kolicina = model.Kolicina,
                Adresa = model.Adresa,
                BrojTelefona=model.BrojTelefona,
                korisnik_id = model.korisnik_id,
                meni_id = model.meni_id
            };

            _context.Dostava.Add(novaDostava);
            _context.SaveChanges();

            return CreatedAtAction("GetDostava", new { id = novaDostava.Id }, novaDostava);
        }
    }
}
