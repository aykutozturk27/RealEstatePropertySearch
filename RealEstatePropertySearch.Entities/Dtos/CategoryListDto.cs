using RealEstatePropertySearch.Core.Entities;
using RealEstatePropertySearch.Entities.Concrete;

namespace RealEstatePropertySearch.Entities.Dtos
{
    public class CategoryListDto : IDto
    {
        public List<Category>? Categories { get; set; }
    }
}
