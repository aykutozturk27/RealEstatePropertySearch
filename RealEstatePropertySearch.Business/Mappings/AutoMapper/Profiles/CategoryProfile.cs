using AutoMapper;
using RealEstatePropertySearch.Entities.Concrete;
using RealEstatePropertySearch.Entities.Dtos;

namespace RealEstatePropertySearch.Business.Mappings.AutoMapper.Profiles
{
    public class CategoryProfile : Profile
    {
        public CategoryProfile()
        {
            CreateMap<List<Category>, CategoryListDto>().ReverseMap();
            CreateMap<Category, CategoryDto>().ReverseMap();
        }
    }
}
