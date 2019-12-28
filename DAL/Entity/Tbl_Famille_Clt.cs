using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
   public  class Tbl_Famille_Clt
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IdFamille { get; set; }
 
        public string Libelle { get; set; }
        //relation client
        public virtual ICollection<Tbl_Client> Tbl_Client { get; set; }
    }
}
