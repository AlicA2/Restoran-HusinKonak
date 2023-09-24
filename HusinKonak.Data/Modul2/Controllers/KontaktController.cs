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
    public class KontaktController : ControllerBase
    {
        private readonly RestaurantDBContext _dbContext;

        public KontaktController(RestaurantDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        [HttpPost]
        public ActionResult DodajKontakt([FromBody] KontaktAddVM kontaktVM)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest("Neispravni podaci za unos kontakta.");
            }

            try
            {
                Kontakt kontakt = new Kontakt
                {
                    Ime = kontaktVM.Ime,
                    Prezime = kontaktVM.Prezime,
                    Email = kontaktVM.Email,
                    Telefon = kontaktVM.Telefon,
                    Poruka = kontaktVM.Poruka,
                    korisnickiNalogID = kontaktVM.korisnickiNalogID
                };

                _dbContext.Kontakt.Add(kontakt);
                _dbContext.SaveChanges();

                return Ok(new { message = "Kontakt uspješno dodan." });
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Greška prilikom dodavanja kontakta: {ex.Message}");
            }
        }

        [HttpGet("{korisnickiNalogID}")]
        public ActionResult DohvatiKontakte(int korisnickiNalogID)
        {
            try
            {
                var kontakte = _dbContext.Kontakt
                    .Where(k => k.korisnickiNalogID == korisnickiNalogID)
                    .Select(k => new KontaktGetVM
                    {
                        ID = k.ID,
                        Ime = k.Ime,
                        Prezime = k.Prezime,
                        Email = k.Email,
                        Telefon = k.Telefon,
                        Poruka = k.Poruka,
                        korisnickiNalogID = k.korisnickiNalogID,
                        KorisnickoIme = k.korisnickiNalog.KorisnickoIme
                    })
                    .ToList();

                return Ok(kontakte);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Greška prilikom dohvatanja kontakata: {ex.Message}");
            }
        }
    }
}
