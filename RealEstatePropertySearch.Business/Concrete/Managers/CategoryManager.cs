using RealEstatePropertySearch.Business.Abstract;
using RealEstatePropertySearch.DataAccess.Abstract;
using RealEstatePropertySearch.Entities.Dtos;

namespace RealEstatePropertySearch.Business.Concrete.Managers
{
    public class CategoryManager : ICategoryService
    {
        private readonly ICategoryDal _categoryDal;

        public CategoryManager(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public CategoryListDto GetAll()
        {
            var categoryList = _categoryDal.GetList();
            var mappedCategory = new CategoryListDto { Categories = categoryList};
            return mappedCategory;
        }

        public CategoryDto GetById(int id)
        {
            var category = _categoryDal.Get(x => x.Id == id);
            var mappedCategory = new CategoryDto { Category = category };
            return mappedCategory;
        }
    }
}
