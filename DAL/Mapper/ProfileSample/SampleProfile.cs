using DAL.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Contract.DTO;

namespace DAL.Mapper.ProfileSample
{
    public class SampleProfile : Profile
    {

        public SampleProfile()
        {
            CreateMap<SampleDTO, SampleEntity>().ReverseMap();
            CreateMap<SampleEntity, SampleDTO>().ReverseMap();
        }
    }
}
