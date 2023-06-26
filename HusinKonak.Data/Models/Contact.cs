using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HusinKonak.Data.Models
{
    public class Contact
    {
        public int ContactID { get; set; }
    
        public string Name { get; set; }
 
        public string Email { get; set; }


        public string Sadrzaj { get; set; }
    }
}
