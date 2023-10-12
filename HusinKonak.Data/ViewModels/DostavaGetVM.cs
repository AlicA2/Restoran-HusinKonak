
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
        public int KorisnikId { get; set; }
        public DateTime DatumNarudzbe { get; set; }
        public string AdresaDostave { get; set; }
        public decimal UkupnaCijena { get; set; }
        public List<DetaljiDostaveGetVM> StavkeDostave { get; set; }
    }
}
