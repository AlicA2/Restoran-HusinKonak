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
    public class DostavaMeniController : ControllerBase
    {
        private readonly RestaurantDBContext _dbContext;

        public DostavaMeniController(RestaurantDBContext context)
        {
            _dbContext = context;
        }

        [HttpPost]
        public ActionResult Snimi([FromBody] DostavaMeniAddVM x)
        {

            DostavaMeni? kp;
            if (x.id == 0)
            {
                kp = new DostavaMeni();
                _dbContext.Add(kp);
            }
            else
            {
                kp = _dbContext.DostavaMeni.FirstOrDefault(p => p.Id == x.id);
                if (kp == null)
                    return BadRequest("Proizvod ne postoji");
            }

            kp.Kolicina = x.kolicina;
            kp.Cijena = x.cijena;
            kp.meni_id = x.meniID;
            kp.dostava_id = x.dostavaID;

            _dbContext.SaveChanges();
            return Ok(x);
        }

    }
}
