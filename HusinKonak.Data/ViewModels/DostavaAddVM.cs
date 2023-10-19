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
        public int id { get; set; }
        public DateTime datumKreiranja { get; set; }
        public int? korisnikId { get; set; }

    }
}
