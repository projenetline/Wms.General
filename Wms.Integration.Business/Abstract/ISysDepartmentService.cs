using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Abstract
{
    public interface ISysDepartmentService:IBaseEntityService<SysDepartment>
    {
        Task<IDataResult<SysDepartment>> GetCodeAsync(string Code);
    }
}
