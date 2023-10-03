using AutoMapper;
using RealEstatePropertySearch.Entities.Concrete;
using RealEstatePropertySearch.Entities.Dtos;

namespace RealEstatePropertySearch.Business.Mappings.AutoMapper.Profiles
{
    public class ProductProfile : Profile
    {
        public ProductProfile()
        {
            CreateMap<List<Product>, ProductListDto>().ReverseMap();
            CreateMap<Product, ProductDto>().ReverseMap();
        }
    }
}
