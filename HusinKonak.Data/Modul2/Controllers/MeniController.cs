using FIT_Api_Examples.Helper;
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
                return BadRequest("Neispravni podaci za unos meni-a.");
            }

            try
            {
                Meni meni = new Meni
                {
                    Naziv = x.Naziv,
                    Opis=x.Opis,
                    Cijena=x.Cijena,
                    kategorija_id=x.kategorija_id

                };
                _dbContext.Meni.Add(meni);
                _dbContext.SaveChanges();

                return Ok(new { message = "Meni uspješno dodan." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Greška prilikom dodavanja meni-a: {ex.Message}");
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
                        Id = k.Id,
                        Naziv=k.Naziv,
                        Opis = k.Opis,
                        Cijena = k.Cijena,
                        kategorija_id = k.kategorija_id
                    })
                    .ToList();

                return Ok(meni);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Greška prilikom dohvatanja meni-a: {ex.Message}");
            }
        }

    }
}
