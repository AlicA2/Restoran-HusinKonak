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
    public class DetaljiDostaveController : ControllerBase
    {
        private readonly RestaurantDBContext _dbContext;

        public DetaljiDostaveController(RestaurantDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            try
            {
                var detaljiDostave = await _dbContext.DetaljiDostave
                    .ToListAsync();

                var detaljiDostaveVM = detaljiDostave.Select(d => new DetaljiDostaveGetVM
                {
                    Id = d.Id,
                    MeniId = d.MeniId,
                    Kolicina = d.Kolicina,
                    CijenaPoStavci = d.CijenaPoStavci
                }).ToList();

                return Ok(detaljiDostaveVM);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Greška prilikom dohvatanja detalja dostave: {ex.Message}");
            }
        }

        [HttpPost]
        public async Task<IActionResult> DodajDetaljeDostave([FromBody] DetaljiDostaveAddVM model)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Neispravni podaci za unos detalja dostave.");
            }

            try
            {
                var detaljiDostave = new DetaljiDostave
                {
                    MeniId = model.MeniId,
                    Kolicina = model.Kolicina,
                    CijenaPoStavci = model.CijenaPoStavci
                };

                _dbContext.DetaljiDostave.Add(detaljiDostave);
                await _dbContext.SaveChangesAsync();

                return Ok(new { message = "Detalji dostave uspješno dodani." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Greška prilikom dodavanja detalja dostave: {ex.Message}");
            }
        }
    }
}
