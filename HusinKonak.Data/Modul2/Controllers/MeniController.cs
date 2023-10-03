using HusinKonak.Data.Modul2.Models;
using HusinKonak.Data.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusinKonak.Data.Modul2.Controllers
{
    [Route("[controller]/[action]")]
    [ApiController]
    public class MeniController : ControllerBase
    {
        private readonly RestaurantDBContext _dbContext;

        public MeniController(RestaurantDBContext dbContext)
        {
            _dbContext = dbContext;
        }


        [HttpPost]
        public ActionResult DodajMeni([FromBody]MeniAddVM x)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Neispravni podaci za unos Meni-a.");
            }

            try
            {
                Meni meni = new Meni
                {
                    Ime = x.Ime,
                    Opis=x.Opis,
                    Cijena=x.Cijena,
                    slika=x.novaSlika
                };

                _dbContext.Meni.Add(meni);
                _dbContext.SaveChanges();

                return Ok(new { message = "Meni uspješno dodan." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Greška prilikom dodavanja Meni-a: {ex.Message}");
            }

        }
        [HttpGet]
        public ActionResult GetAll()
        {
            try
            {
                var meni = _dbContext.Meni
                    .Select(k => new MeniGetVM
                    {
                         Id=k.Id,
                         Ime=k.Ime,
                         Opis=k.Opis,
                         Cijena=k.Cijena,
                         slika=k.slika
                    })
                    .ToList();

                return Ok(meni);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Greška prilikom dohvatanja Meni-a: {ex.Message}");
            }
        }

    }
}
