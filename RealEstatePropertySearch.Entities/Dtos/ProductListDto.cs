using RealEstatePropertySearch.Core.Entities;
using RealEstatePropertySearch.Entities.Concrete;

namespace RealEstatePropertySearch.Entities.Dtos
{
    public class ProductListDto : IDto
    {
        public List<Product>? Products { get; set; }
    }
}
