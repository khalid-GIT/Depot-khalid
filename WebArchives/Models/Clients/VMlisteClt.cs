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
    public class VMlisteClt
    {
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

        public List<DtoListeClients> listeclients { get; set; }
       
        public int Tbl_Famille_Clt_Id { get; set; }
       
        public int Tbl_Ville_id { get; set; }
       
        public int IDContact { get; set; }

        public List<DtoListeVilles> listeVilles { get; set; }
        public List<Dto_Familles_Clt> listeFamille { get; set; }
        public List<Dto_liste_Contact> ListeContact { get; set; }

        public string VilleName { get; set; }
        public string FamilleName { get; set; }
        public string ContactName { get; set; }
    }
}