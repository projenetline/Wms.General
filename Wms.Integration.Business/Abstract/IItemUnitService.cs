using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Abstract
{
    public interface IItemUnitService:IBaseEntityService<ItemUnit>
    {
        Task<IDataResult<ItemUnit>> GetItemIdAsync(int itemId);
    }
}
