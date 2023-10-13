using HusinKonak.Data.Modul2.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusinKonak.Data.ViewModels
{
    public class DostavaAddVM
    {
        [Required]
        public float Cijena { get; set; }
        [Required]
        public int Kolicina { get; set; }
        [Required]
        public string Adresa { get; set; }
        [Required]
        public string BrojTelefona { get; set; }

        public int? korisnik_id { get; set; }
        public int? meni_id { get; set; }
    }
}
