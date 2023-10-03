using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusinKonak.Data.ViewModels
{
    public class MeniAddVM
    {
        public string Ime { get; set; }
        public string Opis { get; set; }
        public decimal Cijena { get; set; }
        public byte[] novaSlika { get; set; }
    }
}
