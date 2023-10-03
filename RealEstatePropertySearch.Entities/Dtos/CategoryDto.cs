using RealEstatePropertySearch.Core.Entities;
using RealEstatePropertySearch.Entities.Concrete;

namespace RealEstatePropertySearch.Entities.Dtos
{
    public class CategoryDto : IDto
    {
        public Category? Category { get; set; }
    }
}
