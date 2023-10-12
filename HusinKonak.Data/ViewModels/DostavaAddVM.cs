using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusinKonak.Data.ViewModels
{
    public class DostavaAddVM
    {
        public int KorisnikId { get; set; }
        public string AdresaDostave { get; set; }
        public List<DetaljiDostaveAddVM> StavkeNarudzbe { get; set; }
    }
}
