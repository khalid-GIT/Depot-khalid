using COMMON.DTO.Clients;
using COMMON.DTO.Clients.Familles;
using COMMON.DTO.Villes;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebArchives.Models.Clients
{
    public class VMListeClient
    {
        public int id { get; set; }
        [Required(ErrorMessage = "Le nom est obligatoire !"), MaxLength(50)]
        [StringLength(50)]
        [Display(Name = "Nom client")]
        public string Nom { get; set; }
        //[StringLength(150)]
        [Display(Name = "Adresse client")]
        public string Adresse { get; set; }
        [Required(ErrorMessage = "Please enter Email")]
        [RegularExpression(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$", ErrorMessage = "Email is not valid.")]
        [Display(Name = "Adresse Mail")]
        public string Mail { get; set; }
        [Display(Name = "Télèphone")]
        public string telephone1 { get; set; }
        [Display(Name = "Fax")]
        public string fax { get; set; }
        [Display(Name = "Date de Creation")]
        public Nullable<System.DateTime> DatedeCreation { get; set; }
        [Display(Name = "Identification fiscal")]
        public string idf { get; set; }
        [Display(Name = "CNSS")]
        public string Cnss { get; set; }
        [Display(Name = "ICE")]
        public string Ice { get; set; }
        [Display(Name = "GSM")]
        public string Gsm { get; set; }
        [Display(Name = "Télèphone 2")]
        public string Teleph { get; set; }
        
        public List<DtoListeClients> listeclients { get; set; }
        [Display(Name = "Famille client")]
        public int Tbl_Famille_Clt_Id { get; set; }
        [Display(Name = "Ville")]
        public int Tbl_Ville_id { get; set; }
        [Display(Name = "Contact")]
        public int IDContact{ get; set; }

        public List<DtoListeVilles> listeVilles { get; set; }
        public List<Dto_Familles_Clt> listeFamille { get; set; }
        public List<Dto_liste_Contact> ListeContact { get; set; }

        public string VilleName { get; set; }
        public string FamilleName { get; set; }
        public string ContactName { get; set; }

        //[Compare("NewUserName", ErrorMessage = "The new password and confirmation password do not match.")]
        //public string ConfirmUserName { get; set; }

        //public string Email { get; set; }

        //[Compare(nameof(Email), ErrorMessage = "The Email and Confirm Email fields do not match.")]
        //public string ConfirmEmail { get; set; }

        //[Display(Name = "Email")]
        //public string Email { get; set; }

        //[Display(Name = "Confirm Email")]
        //[Compare("Email", ErrorMessage = "The '{1}' and '{0}' fields do not match.")]
        //public string ConfirmEmail { get; set; }
    }
}