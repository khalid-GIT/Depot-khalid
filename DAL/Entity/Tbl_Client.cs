using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Entity
{
    public class Tbl_Client
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Mail { get; set; }
        public string telephone1 { get; set; }
        public string fax { get; set; }
        public Nullable<System.DateTime> DatedeCreation { get; set; }
        public string idf { get; set; }   
        public string Cnss { get; set; }
        public string Ice { get; set; }
        public string Gsm { get; set; }    
        public string Teleph { get; set; }
        public string CodePostal { get; set; }

        //Relation avec la ville
        [ForeignKey("Tbl_Ville")]
        public int IdVille { get; set; }
        
        public virtual Tbl_Ville Tbl_Ville { get; set; }
        //Relation avec la famille
        [ForeignKey("Tbl_Famille_Clt")]
        public int IdFamille { get; set; }
        public virtual Tbl_Famille_Clt  Tbl_Famille_Clt { get; set; }
        //relation contact
        [ForeignKey("Tbl_Contact_Clt")]
        public int IDContact { get; set; }
        public virtual Tbl_Contact_Clt Tbl_Contact_Clt { get; set; }


    }
}
