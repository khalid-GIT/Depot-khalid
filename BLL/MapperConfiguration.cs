using AutoMapper;
using COMMON.DTO.Clients;
using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLL
{
    public class MapperConfiguration
    {
        public static void initial()
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Tbl_Client, DtoListeClients>());

        }
    }
}
