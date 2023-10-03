using RealEstatePropertySearch.Entities.Dtos;

namespace RealEstatePropertySearch.Business.Abstract
{
    public interface ICategoryService
    {
        CategoryListDto GetAll();
        CategoryDto GetById(int id);
    }
}
