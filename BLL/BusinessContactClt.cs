using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using COMMON.DTO.Clients;
using DAL.DbContext;
using AutoMapper;

namespace BLL
{
    public class BusinessContactClt
    {
        ModelData contexts = new ModelData();
        public List<Dto_liste_Contact> ListContact()
        {
            var Entity = contexts.Tbl_Contact_clt.ToList();
            var dtoContact = Mapper.Map<List<Dto_liste_Contact>>(Entity);
            return dtoContact;


        }
    }
}
