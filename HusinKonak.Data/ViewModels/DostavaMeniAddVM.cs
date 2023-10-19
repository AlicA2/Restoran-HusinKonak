using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusinKonak.Data.ViewModels
{
    public class DostavaMeniAddVM
    {
        public int id { get; set; }
        public int kolicina { get; set; }
        public float cijena { get; set; }
        public int dostavaID { get; set; }
        public int meniID { get; set; }

    }
}
