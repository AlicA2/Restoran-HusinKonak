using HusinKonak.Data.Modul2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusinKonak.Data.ViewModels
{
    public class DostavaGetVM
    {
        public int Id { get; set; }
        public float Cijena { get; set; }
        public int Kolicina { get; set; }
        public string Adresa { get; set; }
        public string BrojTelefona { get; set; }
        public int? korisnik_id { get; set; }
        public int? meni_id { get; set; }
    }
}
