using RealEstatePropertySearch.Core.Entities;
using System.Linq.Expressions;

namespace RealEstatePropertySearch.Core.DataAccess
{
    public interface IEntityRepository<T> where T : class, IEntity, new()
    {
        List<T> GetList(Expression<Func<T, bool>> filter = null);
        T Get(Expression<Func<T, bool>> filter);
        T Add(T entity);
        T Update(T entity);
        bool Delete(T entity);
    }
}
