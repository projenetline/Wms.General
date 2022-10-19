using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Core.Core.Abstract
{
    public interface IBaseEntityService<T> where T : class,IBaseEntity
    {
        Task<IDataResult<T>> GetAsync(int id);
        Task<IDataResult<T>> CreateAsync(T entity);
        Task<IDataResult<T>> UpdateAsync(T entity);
        Task<IDataResult<T>> DeleteAsync(T entity);
    }
}
