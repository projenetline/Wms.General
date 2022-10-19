using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysDepartmentManager : ISysDepartmentService
    {
        private readonly  ISysDepartmentDal sysDepartmentDal;
        public SysDepartmentManager(ISysDepartmentDal sysDepartmentDal)
        {
            this.sysDepartmentDal = sysDepartmentDal;
        }
        public Task<IDataResult<SysDepartment>> CreateAsync(SysDepartment entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<SysDepartment>> DeleteAsync(SysDepartment entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<SysDepartment>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<SysDepartment>> UpdateAsync(SysDepartment entity)
        {
            throw new NotImplementedException();
        }
    }
}
