
using AutoMapper;
using COMMON.DTO.Clients.Familles;
using DAL.DbContext;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;

namespace BLL
{

    public class BusinessFamilleClients

    {
        ModelData contexts = new ModelData();

        public List<Dto_Familles_Clt> GetListFamilleClt()
        {
            var list = contexts.Tbl_Famille_Clt.ToList();

            var Dto_Familles = Mapper.Map<List<Dto_Familles_Clt>>(list);
            return Dto_Familles;
        }
      
        //public List<Dto_Familles_Clt> GetliseFamille_Clt()
        //{
        //    var list = Context.Tbl_Famille_Clt.ToList();
        //    var DtoListeVilles = Mapper.Map<List<Dto_Familles_Clt>>(list);
        //    return DtoListeVilles;
        //}
       
    }
}
