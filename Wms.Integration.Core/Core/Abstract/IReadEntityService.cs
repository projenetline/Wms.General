using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Core.Core.Abstract
{
    public interface IReadEntityService<T> where T : class,IBaseEntity
    {
        Task<IDataResult<T>> GetData(int Id);
        Task<IDataResult<IList<T>>> GetListAsync(T entity);
        Task<IDataResult<PagedResult<T>>> GetPagedListAsync(T entity);
    }
}
