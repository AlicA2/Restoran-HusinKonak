using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusinKonak.Data.Modul2.Models
{
    public class Dostava
    {
        [Key]
        public int Id { get; set; }
        public DateTime DatumKreiranja { get; set; }

        [ForeignKey(nameof(korisnik))]
        public int? korisnik_id { get; set; }
        public Korisnik korisnik { get; set; }
        public List<DostavaMeni> MeniDostava { get; set; }
    }
}
