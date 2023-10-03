using RealEstatePropertySearch.Core.Entities;

namespace RealEstatePropertySearch.Entities.Concrete
{
    public class Product : BaseEntity
    {
        public string? Title { get; set; }
        public string? Description { get; set; }
        public decimal Price { get; set; }
        public string? City { get; set; } //şehir
        public string? District { get; set; } //ilçe
        public string? ImageUrl { get; set; }
    }
}
