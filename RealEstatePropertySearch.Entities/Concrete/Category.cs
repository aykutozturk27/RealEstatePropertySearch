using RealEstatePropertySearch.Core.Entities;

namespace RealEstatePropertySearch.Entities.Concrete
{
    public class Category : BaseEntity
    {
        public string? Name { get; set; }

        public List<Product>? Products { get; set; }
    }
}
