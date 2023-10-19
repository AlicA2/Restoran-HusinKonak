using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using HusinKonak.Data;
using HusinKonak.Data.Modul2.Models;
using HusinKonak.Data.ViewModels;

namespace HusinKonak.Controllers
{
    [Route("api/dostava")]
    [ApiController]
    public class DostavaController : ControllerBase
    {
        private readonly RestaurantDBContext _dbContext;

        public DostavaController(RestaurantDBContext context)
        {
            _dbContext = context;
        }

        //[HttpGet("GetAll")]
        //public async Task<ActionResult<IEnumerable<DostavaGetVM>>> GetDostave()
        //{
        //    var dostave = await _context.Dostava
        //        .Select(d => new DostavaGetVM
        //        {
        //            Id = d.Id,
        //            Cijena = d.Cijena,
        //            Kolicina = d.Kolicina,
        //            Adresa = d.Adresa,
        //            BrojTelefona = d.BrojTelefona,
        //            korisnik_id = d.korisnik_id
        //        })
        //        .ToListAsync();

        //    return Ok(dostave);
        //}

        //[HttpGet("{id}")]
        //public async Task<ActionResult<DostavaGetVM>> GetDostava(int id)
        //{
        //    var dostava = await _context.Dostava.FirstOrDefaultAsync(d => d.Id == id);

        //    if (dostava == null)
        //        return NotFound();

        //    var dostavaGetVM = new DostavaGetVM
        //    {
        //        Id = dostava.Id,
        //        Cijena = dostava.Cijena,
        //        Kolicina = dostava.Kolicina,
        //        Adresa = dostava.Adresa,
        //        BrojTelefona = dostava.BrojTelefona,
        //        korisnik_id = dostava.korisnik_id
        //    };

        //    return Ok(dostavaGetVM);
        //}

        //[HttpPost]
        //public async Task<ActionResult<DostavaGetVM>> AddDostava(DostavaAddVM model)
        //{
        //    if (!ModelState.IsValid)
        //        return BadRequest(ModelState);

        //    var novaDostava = new Dostava
        //    {
        //        Cijena = model.Cijena,
        //        Kolicina = model.Kolicina,
        //        Adresa = model.Adresa,
        //        BrojTelefona = model.BrojTelefona,
        //        korisnik_id = model.korisnik_id
        //    };
        //    if (model.MeniItems != null && model.MeniItems.Any())
        //    {
        //        novaDostava.MeniItems = await _context.Meni.Where(m => model.MeniItems.Contains(m.Id)).ToListAsync();
        //    }

        //    _context.Dostava.Add(novaDostava);
        //    await _context.SaveChangesAsync();

        //    var dostavaGetVM = new DostavaGetVM
        //    {
        //        Id = novaDostava.Id,
        //        Cijena = novaDostava.Cijena,
        //        Kolicina = novaDostava.Kolicina,
        //        Adresa = novaDostava.Adresa,
        //        BrojTelefona = novaDostava.BrojTelefona,
        //        korisnik_id = novaDostava.korisnik_id,
        //        MeniItems = novaDostava.MeniItems.Select(m => m.Id).ToList()
        //    };

        //    return CreatedAtAction("GetDostava", new { id = novaDostava.Id }, dostavaGetVM);
        //}


        [HttpPost]
        public ActionResult<int> Snimi(int korisnikId)
        {
            Dostava korpa;
            var korpe = _dbContext.Dostava.Where(k => k.korisnik_id == korisnikId).ToList();

            if (korpe.Count == 0)
            {
                korpa = new Dostava();
                korpa.MeniDostava = new List<DostavaMeni>();
                _dbContext.Add(korpa);
            }
            else
            {
                korpa = _dbContext.Dostava.FirstOrDefault(k => k.korisnik_id == korisnikId);
            }

            korpa.DatumKreiranja = DateTime.Now;
            korpa.korisnik_id = korisnikId;

            _dbContext.SaveChanges();
            return korpa.Id;
        }
    }
    


}

