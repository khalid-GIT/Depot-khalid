using AutoMapper;
using COMMON.DTO.Clients;
using DAL.DbContext;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;




namespace BLL
{
   public  class BusinessClients
    {
        ModelData context = new ModelData();

        public DtoListeClients GetClientById(int id)
        {
            var x = new Tbl_Client();
            x = context.Tbl_Client.Find(id);
            return new DtoListeClients
            {
                id = x.id,
                Nom = x.Nom,
                telephone1 = x.telephone1,
                Adresse = x.Adresse,
                fax = x.fax,
                Mail = x.Mail,
                Cnss = x.Cnss,
                idf = x.idf,
                Gsm = x.Gsm,
                // DatedeCreation = x.DatedeCreation,              
                Teleph = x.Teleph,
                Ice = x.Ice,
                Tbl_Famille_Clt_Id = x.IdFamille,
                Tbl_Ville_id = x.IdVille,
                IDContact = x.IDContact,

                //  VilleName = x.Tbl_Ville.libelle,
                FamilleName = x.Tbl_Famille_Clt.Libelle
            };

            //DtoClients = Mapper.Map<DtoListeClients>(x);
            // return DtoClients;
        }

        public int AjouterClient(DtoListeClients dto)
        {
            var Entity = new Tbl_Client();
            Entity.Nom = dto.Nom;
            Entity.Adresse = dto.Adresse;
            Entity.Mail = dto.Mail;
            Entity.telephone1 = dto.telephone1;
            Entity.fax = dto.fax;
            Entity.idf = dto.idf;
            Entity.Ice = dto.Ice;
            Entity.Gsm = dto.Gsm;
            Entity.Teleph = dto.Teleph;
            Entity.Cnss = dto.Cnss;
            Entity.IdFamille = dto.Tbl_Famille_Clt_Id;
            Entity.IdVille = dto.Tbl_Ville_id;
            Entity.IDContact = dto.IDContact;

            Entity.DatedeCreation = DateTime.Now;
            context.Tbl_Client.Add(Entity);
            context.SaveChanges();
            return Entity.id;
        }

        public List<DtoListeClients> BusinessliseViewClient()
        {

            //var list = context.Tbl_Client.ToList();
            //var list = context.Tbl_Client.Where(c => c.CodePostal == "82000").Select(x => new DtoListeClients

           var list = context.Tbl_Client.Select(x => new DtoListeClients
            {
                id = x.id,
                Nom = x.Nom,
                telephone1 = x.telephone1,
                Adresse = x.Adresse,
                fax = x.fax,
                Mail = x.Mail,
                Cnss = x.Cnss,
                idf = x.idf,
                Ice = x.Ice,
                Gsm = x.Gsm,
                Teleph = x.Teleph,

                DataColumn1 = x.Tbl_Ville.libelle,
                VilleName = x.Tbl_Ville.libelle,
                FamilleName = x.Tbl_Famille_Clt.Libelle,
                ContactName = x.Tbl_Contact_Clt.Nom + ", " + x.Tbl_Contact_Clt.Prenom,
                ContactGsm = x.Tbl_Contact_Clt.Gsm
            }).ToList();
            //list.Add(new DtoListeClients { Adresse = "hhhhhh"});
            //var c = list.FirstOrDefault();
            //foreach(var item in list)
            //{
            //    item.Adresse = "bbb";
            //}
        //}).ToList().OrderByDescending(c=>c.Adresse);
        //list = list.ToList();
        //context.Tbl_Clients.ToList();
        var DtoClients = Mapper.Map<List<DtoListeClients>>(list);
            return DtoClients;
        }


        public List<DtoListeClients> BusinessliseClient()
        {

            //var list = context.Tbl_Client.ToList();
            var list = context.Tbl_Client.Select(x => new DtoListeClients
            {
                id = x.id,
                Nom = x.Nom,
                telephone1 = x.telephone1,
                Adresse = x.Adresse,
                fax = x.fax,
                Mail = x.Mail,
                Cnss = x.Cnss,
                idf = x.idf,
                Ice = x.Ice,
                Gsm = x.Gsm,
                Teleph = x.Teleph,
                VilleName = x.Tbl_Ville.libelle,
                FamilleName = x.Tbl_Famille_Clt.Libelle,
                ContactName=x.Tbl_Contact_Clt.Nom + ", " + x.Tbl_Contact_Clt.Prenom
            }).ToList();
            list = list.ToList();
            //context.Tbl_Clients.ToList();
            var DtoClients = Mapper.Map<List<DtoListeClients>>(list);
            return DtoClients;
        }

        public List<DtoListeClients> ChercherClient(string chercher)
        {

            if (chercher != null && chercher != "")
            {
                var List = context.Tbl_Client.Where(y => y.Nom.Contains(chercher));
                var dto = Mapper.Map<List<DtoListeClients>>(List);
                return dto;
            }
            else
            {
                var List = context.Tbl_Client.ToList();
                var dto = Mapper.Map<List<DtoListeClients>>(List);
                return dto;
            }
            //var list = context.Tbl_Client()
            //if (!String.IsNullOrEmpty(ch))
            //{
            //    var list = context.Tbl_Client.Select(x => new DtoListeClients
            //    {
            //        id = x.id,
            //        Nom = x.Nom,
            //        telephone1 = x.telephone1,
            //        Adresse = x.Adresse,
            //        fax = x.fax,
            //        Mail = x.Mail,
            //        Cnss = x.Cnss,
            //        idf = x.idf,
            //        Ice = x.Ice,
            //        Gsm = x.Gsm,
            //        Teleph = x.Teleph,
            //        VilleName = x.Tbl_Ville.libelle,
            //        FamilleName = x.Tbl_Famille_Clt.Libelle,
            //        ContactName = x.Tbl_Contact_Clt.Nom + ", " + x.Tbl_Contact_Clt.Prenom
            //    }).Where(s => s.Nom.Contains(ch)).ToList();
            //}

            //context.Tbl_Clients.ToList();

            //return DtoClients;

    //        var DtoClients = Mapper.Map<List<DtoListeClients>>(list);
    //return DtoClients;    
               
            
         
        }
        public void SupprimerClients(int id)
        {
            var Entity = new Tbl_Client();
            Entity = context.Tbl_Client.Find(id);
            context.Tbl_Client.Remove(Entity);
            context.SaveChanges();
        }
      
        public void MdifierClient(DtoListeClients dto)
        {

            var Entity = context.Tbl_Client.Find(dto.id);
            Entity.Nom = dto.Nom;
            Entity.Adresse = dto.Adresse;
            Entity.Mail = dto.Mail;
            Entity.telephone1 = dto.telephone1;
            Entity.fax = dto.fax;
            Entity.idf = dto.idf;
            Entity.Ice = dto.Ice;
            Entity.Gsm = dto.Gsm;
            Entity.Cnss = dto.Cnss;
            Entity.Teleph = dto.Teleph;
            Entity.Gsm = dto.Gsm;
            Entity.IdFamille = dto.Tbl_Famille_Clt_Id;
            Entity.IdVille = dto.Tbl_Ville_id;
            Entity.IDContact = dto.IDContact;

            context.SaveChanges();

        }
    }
}
