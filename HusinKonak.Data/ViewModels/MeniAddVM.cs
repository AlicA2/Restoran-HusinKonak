using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations; // Import this namespace

namespace HusinKonak.Data.ViewModels
{
    public class MeniAddVM
    {
        public string Naziv { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }
        public string? novaSlika { get; set; }
    }
}
