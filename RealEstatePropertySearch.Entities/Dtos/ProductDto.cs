using RealEstatePropertySearch.Core.Entities;
using RealEstatePropertySearch.Entities.Concrete;

namespace RealEstatePropertySearch.Entities.Dtos
{
    public class ProductDto : IDto
    {
        public Product? Product { get; set; }
    }
}
