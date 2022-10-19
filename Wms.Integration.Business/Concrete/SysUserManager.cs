using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysUserManager : ISysUserService
    {
        private readonly ISysUserDal sysUserDal;
        public SysUserManager(ISysUserDal sysUserDal)
        {
            this.sysUserDal = sysUserDal;
        }

        public Task<IDataResult<SysUser>> CreateAsync(SysUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysUser>> DeleteAsync(SysUser entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysUser>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysUser>> UpdateAsync(SysUser entity)
        {
            throw new NotImplementedException();
        }
    }
}
