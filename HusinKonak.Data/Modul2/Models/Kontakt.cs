using HusinKonak.Data.Modul0_Autentifikacija.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HusinKonak.Data.Modul2.Models
{
    public class Kontakt
    {
        [Key]
        public int ID { get; set; }
        public string Ime { get; set; }
        public string Prezime { get; set; }
        public string Email { get; set; }
        public string Telefon { get; set; }
        public string Poruka { get; set; }

        [ForeignKey(nameof(korisnickiNalog))]
        public int korisnickiNalogID { get; set; }
        public KorisnickiNalog korisnickiNalog { get; set; }
    }
}
