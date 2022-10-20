using System.Linq.Expressions;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Core.DataAccess.Abstract
{
    public interface IEntityRepository<T>:IReadOnlyRepository<T> where T : class,IBaseEntity  
    {
        Task<T> CreateAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task<T> DeleteAsync(T entity);
    }
}
