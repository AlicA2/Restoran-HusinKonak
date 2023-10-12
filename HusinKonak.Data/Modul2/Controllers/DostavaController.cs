using HusinKonak.Data.Modul2.Models;
using HusinKonak.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace HusinKonak.Data.Modul2.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class DostavaController : ControllerBase
    {
        private readonly RestaurantDBContext _dbContext;

        public DostavaController(RestaurantDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var dostave = await _dbContext.Dostava
                    .Include(d => d.StavkeDostave)
                    .ToListAsync();

                var dostaveVM = dostave.Select(dostava => new DostavaGetVM
                {
                    Id = dostava.Id,
                    KorisnikId = dostava.KorisnikId,
                    DatumNarudzbe = dostava.DatumNarudzbe,
                    AdresaDostave = dostava.AdresaDostave,
                    UkupnaCijena = dostava.UkupnaCijena,
                    StavkeDostave = dostava.StavkeDostave.Select(stavka => new DetaljiDostaveGetVM
                    {
                        Id = stavka.Id,
                        MeniId = stavka.MeniId,
                        Kolicina = stavka.Kolicina,
                        CijenaPoStavci = stavka.CijenaPoStavci
                    }).ToList()
                }).ToList();

                return Ok(dostaveVM);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Greška prilikom dohvatanja dostava: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> DodajDostavu([FromBody] DostavaAddVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Neispravni podaci za unos dostave.");
            }

            try
            {
                var dostava = new Dostava
                {
                    KorisnikId = model.KorisnikId,
                    AdresaDostave = model.AdresaDostave,
                    DatumNarudzbe = DateTime.Now,
                    UkupnaCijena = model.StavkeNarudzbe.Sum(s => s.Kolicina * s.CijenaPoStavci),
                    StavkeDostave = model.StavkeNarudzbe.Select(s => new DetaljiDostave
                    {
                        MeniId = s.MeniId,
                        Kolicina = s.Kolicina,
                        CijenaPoStavci = s.CijenaPoStavci
                    }).ToList()
                };

                _dbContext.Dostava.Add(dostava);
                await _dbContext.SaveChangesAsync();

                return Ok(new { message = "Dostava uspješno dodana." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Greška prilikom dodavanja dostave: {ex.Message}");
            }
        }
    }
}
