using System.Linq.Expressions;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Core.DataAccess.Abstract
{
    public interface IReadOnlyRepository<T> :IRepository where  T : class,IBaseEntity
    {
        Task<T> GetAsync(Expression<Func<T, bool>> predicate = null, bool desc = false, params Expression<Func<T, object>>[] properties);
        Task<IList<T>> GetListAsync<TKey>(Expression<Func<T, bool>> predicate = null, Expression<Func<T, TKey>> orderBy = null, bool desc = false, params Expression<Func<T, object>>[] properties);
        Task<IList<T>> GetPagedListAsync<TKey>(int skipCount, int maxResultCount, Expression<Func<T, bool>> predicate = null, Expression<Func<T, TKey>> orderBy = null, bool desc = false, params Expression<Func<T, object>>[] properties);
        Task<bool> GetAnyAsync(Expression<Func<T, bool>> predicate = null);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
    }
}
