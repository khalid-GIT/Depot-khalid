using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMMON.DTO.Clients
{
    public class DtoListeClients
    {
        public int id { get; set; }
        public string Nom { get; set; }
        public string Adresse { get; set; }
        public string Mail { get; set; }
        public string telephone1 { get; set; }
        public string fax { get; set; }
        public string idf { get; set; }
        public string Cnss { get; set; }
        public string Ice { get; set; }
        public string Gsm { get; set; }
        public string Teleph { get; set; }
        public string VilleName { get; set; }
        public string FamilleName { get; set; }
        public string DataColumn1 { get; set; }
        
        public DateTime DatedeCreation { get; set; }
        public int Tbl_Famille_Clt_Id { get; set; }
        public int Tbl_Ville_id { get; set; }
        public int IDContact { get; set; }
        public string ContactName { get; set; }
        
    }
}
