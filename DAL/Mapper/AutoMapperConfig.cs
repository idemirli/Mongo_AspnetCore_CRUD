using AutoMapper;
using DAL.Mapper.ProfileSample;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Mapper
{
    public class AutoMapperConfig
    {
        public static IMapper Initialize()
        {
            var mapperConfig = new MapperConfiguration(mc =>
            {
                mc.AddProfile(new SampleProfile());
            });
            return mapperConfig.CreateMapper();
        }
    }
}
