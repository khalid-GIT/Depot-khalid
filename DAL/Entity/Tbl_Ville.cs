using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
   public  class Tbl_Ville
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdVille { get; set; }
        public string libelle { get; set; }

        public virtual ICollection<Tbl_Client> Tbl_Clients { get; set; }
        //Relation avec la region
        //public virtual Tbl_Region Tbl_Region { get; set; }
    }
}
