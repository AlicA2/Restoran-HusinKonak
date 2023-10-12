using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusinKonak.Data.Modul2.Models
{
    public class DetaljiDostave
    {
        [Key]
        public int Id { get; set; }

        [ForeignKey(nameof(Meni))]
        public int MeniId { get; set; }
        public Meni Meni { get; set; }

        [ForeignKey(nameof(Dostava))]
        public int DostavaId { get; set; }
        public Dostava Dostava { get; set; }
        public int Kolicina { get; set; }
        public decimal CijenaPoStavci { get; set; }
    }
}
