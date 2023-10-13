using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusinKonak.Data.Modul2.Models
{
    public class Dostava
    {
        public int Id { get; set; }
        public float Cijena { get; set; }
        public int Kolicina { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        [ForeignKey(nameof(korisnik))]
        public int? korisnik_id { get; set; }
        public Korisnik korisnik { get; set; }
        [ForeignKey(nameof(meni))]
        public int? meni_id { get; set; }
        public Meni meni { get; set; }
    }
}
