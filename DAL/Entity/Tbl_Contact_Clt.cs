using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Tbl_Contact_Clt
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int IDContact { get; set; }
        public string  Nom { get; set; }
        public string Prenom { get; set; }
        public string Gsm { get; set; }
        public string Email { get; set; }

        [ForeignKey("Tbl_Service")]
        public int IDService { get; set; }
        
        public virtual Tbl_Service Tbl_Service { get; set; }
        public virtual ICollection<Tbl_Client> Tbl_Client { get; set; }

    }
}
