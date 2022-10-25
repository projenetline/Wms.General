using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Abstract
{
    public interface IItemService:IBaseEntityService<Item>
    {
        Task<IDataResult<Item>> GetCodeAsync(string code);
    }
}
