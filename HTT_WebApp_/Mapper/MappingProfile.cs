using AutoMapper;
using HTT_WebApp_.Models;
using HTT_WebApp_DAL.Models;

namespace HTT_WebApp_.Mapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile() 
        {
            CreateMap<Product, ProductDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
