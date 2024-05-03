using AutoMapper;
using MVCDemo.Data;
using MVCDemo.Models;

namespace MVCDemo.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<ProductModel, Product>().ReverseMap();
            CreateMap<CategoryModel,Category>().ReverseMap();
        }
    }
}
