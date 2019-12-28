using AutoMapper;
using COMMON.DTO.Villes;
using DAL.DbContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class BusinessVilles
    {
        ModelData context = new ModelData();
        public List<DtoListeVilles> GetListeVille()
        {
            var list = context.Tbl_Ville.ToList();
            
            var DtoListeVilles = Mapper.Map<List<DtoListeVilles>>(list);
            return DtoListeVilles;



        }

    }
}
