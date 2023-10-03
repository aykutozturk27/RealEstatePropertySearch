using Autofac;
using RealEstatePropertySearch.Business.Abstract;
using RealEstatePropertySearch.Business.Concrete.Managers;
using RealEstatePropertySearch.DataAccess.Abstract;
using RealEstatePropertySearch.DataAccess.Concrete.EntityFramework;

namespace RealEstatePropertySearch.Business.DependencyResolvers.Autofac
{
    public class BusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<ProductManager>().As<IProductService>();
            builder.RegisterType<EfProductDal>().As<IProductDal>();
        }
    }
}
