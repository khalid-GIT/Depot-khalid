using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.DTO.Clients
{
    public class Dto_liste_Contact
    {
        public int IDContact { get; set; }
        public string Nom { get; set; }
        public string Prenom { get; set; }

        //[Display(Name = "Full Name")]
        public string FullName
        {
            get
            {
                return Nom + ", " + Prenom;
            }
        }

    }
}
