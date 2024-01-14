using AutoMapper;
using BasketShop.Services.ProductAPI.Models;
using BasketShop.Services.ProductAPI.Models.Dto;

namespace BasketShop.Services.ProductAPI
{
    public class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration(config =>
            {
                config.CreateMap<ProductDto, Product>().ReverseMap();
            });
            return mappingConfig;
        }
    }
}
