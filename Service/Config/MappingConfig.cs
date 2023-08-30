using AutoMapper;
using WebApp.Service.Data.ValueObjects;
using WebApp.Service.Model;

namespace WebApp.Service.Config
{
    class MappingConfig
    {
        public static MapperConfiguration RegisterMaps()
        {
            var mappingConfig = new MapperConfiguration( config => {
                config.CreateMap<ProductVO, Product>();
                config.CreateMap<Product, ProductVO>();
            });
            return mappingConfig;
        }
    }
}