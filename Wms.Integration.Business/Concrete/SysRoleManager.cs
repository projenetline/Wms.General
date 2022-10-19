using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysRoleManager : ISysRoleService
    {
        private readonly ISysRoleDal sysRoleDal;
        public SysRoleManager(ISysRoleDal sysRoleDal)
        {
            this.sysRoleDal = sysRoleDal;
        }

        public Task<IDataResult<SysRole>> CreateAsync(SysRole entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysRole>> DeleteAsync(SysRole entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysRole>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysRole>> UpdateAsync(SysRole entity)
        {
            throw new NotImplementedException();
        }
    }
}
