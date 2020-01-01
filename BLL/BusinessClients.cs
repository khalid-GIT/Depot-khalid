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
        public int AjouterClient(DtoListeClients dto)
        {
            var Entity = new Tbl_Client();
            Entity.Nom = dto.Nom;
            Entity.Adresse = dto.Nom;
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

        public  List<DtoListeClients> BusinessliseClient()
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

        public void SupprimerClients(int id)
        {
            var Entity = new Tbl_Client();
            Entity = context.Tbl_Client.Find(id);
            context.Tbl_Client.Remove(Entity);
            context.SaveChanges();
        }

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

        public void MdifierClient(DtoListeClients dto)
        {

            var Entity = context.Tbl_Client.Find(dto.id);
            Entity.Nom = dto.Nom;
            Entity.Adresse = dto.Nom;
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
