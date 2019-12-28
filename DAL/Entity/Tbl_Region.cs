using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Tbl_Region
    {
        public int Id { get; set; }
        public String Libelle { get; set; }
        //public virtual ICollection<Tbl_Ville> Tbl_Ville { get; set; }
    }
}
