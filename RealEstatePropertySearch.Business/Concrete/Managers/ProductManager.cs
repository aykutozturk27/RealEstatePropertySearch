using AutoMapper;
using RealEstatePropertySearch.Business.Abstract;
using RealEstatePropertySearch.DataAccess.Abstract;
using RealEstatePropertySearch.Entities.Dtos;

namespace RealEstatePropertySearch.Business.Concrete.Managers
{
    public class ProductManager : IProductService
    {
        private readonly IProductDal _productDal;
        private readonly IMapper _mapper;

        public ProductManager(IProductDal productDal, IMapper mapper)
        {
            _productDal = productDal;
            _mapper = mapper;
        }

        public ProductListDto GetAll()
        {
            var productList = _productDal.GetList();
            var mappedProduct = new ProductListDto { Products = productList};
            return mappedProduct;
        }

        public ProductDto GetById(int id)
        {
            var product = _productDal.Get(x => x.Id == id);
            var mappedProduct = new ProductDto { Product = product };
            return mappedProduct;   
        }

        public ProductDto GetByTitle(string title)
        {
            var product = _productDal.Get(x => x.Title.ToLower().Contains(title));
            var mappedProduct = new ProductDto { Product = product };
            return mappedProduct;
        }
    }
}
