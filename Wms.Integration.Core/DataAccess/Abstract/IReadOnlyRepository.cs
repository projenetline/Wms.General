using System.Linq.Expressions;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Core.DataAccess.Abstract
{
    public interface IReadOnlyRepository<T> :IRepository where  T : class,IBaseEntity
    {
        Task<bool> GetAnyAsync(Expression<Func<T, bool>> predicate = null);
        Task<int> CountAsync(Expression<Func<T, bool>> predicate = null);
    }
}
