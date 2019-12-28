using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Tbl_Service
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDService { get; set; }
        public string libelle { get; set; }
        public virtual ICollection<Tbl_Contact_Clt> Tbl_Contact_Clit { get; set; }
    }
}
