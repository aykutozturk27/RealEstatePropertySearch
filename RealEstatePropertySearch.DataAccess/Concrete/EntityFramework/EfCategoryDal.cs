﻿using RealEstatePropertySearch.Core.DataAccess.EntityFramework;
using RealEstatePropertySearch.DataAccess.Abstract;
using RealEstatePropertySearch.DataAccess.Concrete.EntityFramework.Contexts;
using RealEstatePropertySearch.Entities.Concrete;

namespace RealEstatePropertySearch.DataAccess.Concrete.EntityFramework
{
    public class EfCategoryDal : EfEntityRepositoryBase<Category, RealEstatePropertySearchContext>, ICategoryDal
    {
    }
}
