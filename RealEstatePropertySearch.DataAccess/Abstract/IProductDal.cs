﻿using RealEstatePropertySearch.Core.DataAccess;
using RealEstatePropertySearch.Entities.Concrete;

namespace RealEstatePropertySearch.DataAccess.Abstract
{
    public interface IProductDal : IEntityRepository<Product>
    {
    }
}
