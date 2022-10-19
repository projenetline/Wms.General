using System.Linq.Expressions;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Core.DataAccess.Abstract
{
    public interface IEntityRepository<T>:IReadOnlyRepository<T> where T : class,IBaseEntity  
    {
        Task<T> GetAsync(Expression<Func<T,bool>> predicate=null,bool desc=false,params Expression<Func<T, object>>[] properties);
        Task<IList<T>> GetListAsync<TKey>(Expression<Func<T, bool>> predicate = null, Expression<Func<T, TKey>> orderBy = null,bool desc=false, params Expression<Func<T, object>>[] properties);
        Task<IList<T>> GetPagedListAsync<TKey>(int skipCount, int maxResultCount, Expression<Func<T, bool>> predicate = null, Expression<Func<T, TKey>> orderBy = null,bool desc=false, params Expression<Func<T, object>>[] properties);
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
