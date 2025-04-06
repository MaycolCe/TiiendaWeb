using AutoMapper;
using Mango.Services.CouponAPI.Models;
using Mango.Services.CouponAPI.Models.Dto;

namespace Mango.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps() 
        {
            var mappingConfig = new MapperConfiguration(ConfigurationBinder => 
            {
                ConfigurationBinder.CreateMap<CouponDto, Coupon>();
                ConfigurationBinder.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
