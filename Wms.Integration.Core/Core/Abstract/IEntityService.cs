using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Core.Core.Abstract
{
    public interface IEntityService<T, TList, TCode>
        where T : class, IBaseEntity
        where TList : class, IListParameterDto
        where TCode : class, ICodeParameterDto
    {
        Task<IDataResult<T>> GetAsync(Guid id);
        Task<IDataResult<T>> CreateAsync(T entity);
        Task<IDataResult<T>> UpdateAsync(T entity);
        Task<IDataResult<T>> DeleteAsync(T entity);
        Task<IDataResult<IList<T>>> GetListAsync(TList listDto);
        Task<IDataResult<PagedResult<T>>> GetPagedListAsync(TList listDto);
        Task<IDataResult<T>> GetParameterAsync(TCode parameterDto);
        Task<IDataResult<bool>> AnyAsync(T entity);
    }
}
