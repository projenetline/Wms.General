using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Abstract
{
    public interface ISysWarehouseService:IBaseEntityService<SysWarehouse>
    {
        Task<IDataResult<SysWarehouse>> GetCodeAsync(string code);   
    }
}
