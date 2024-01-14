using AutoMapper;
using BasketShop.Services.CouponAPI.Models;
using BasketShop.Services.CouponAPI.Models.Dto;

namespace BasketShop.Services.CouponAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<CouponDto, Coupon>();
                config.CreateMap<Coupon, CouponDto>();
            });
            return mappingConfig;
        }
    }
}
