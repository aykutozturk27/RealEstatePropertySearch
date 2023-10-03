using RealEstatePropertySearch.Entities.Dtos;

namespace RealEstatePropertySearch.Business.Abstract
{
    public interface IProductService
    {
        ProductListDto GetAll();
        ProductDto GetById(int id);
        ProductDto GetByTitle(string title);
    }
}
