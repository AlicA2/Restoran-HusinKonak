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
        [ForeignKey(nameof(Korisnik))]
        public int KorisnikId { get; set; }
        public Korisnik Korisnik { get; set; }

        public DateTime DatumNarudzbe { get; set; }
        public string AdresaDostave { get; set; }
        public decimal UkupnaCijena { get; set; }
        public List<DetaljiDostave> StavkeDostave { get; set; }

    }
}
