using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysNetLockManager : ISysNetLockService
    {
        private readonly ISysNetLockDal sysNetLockDal;
        public SysNetLockManager(ISysNetLockDal sysNetLockDal)
        {
            this.sysNetLockDal = sysNetLockDal;
        }

        public Task<IDataResult<SysNetLock>> CreateAsync(SysNetLock entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysNetLock>> DeleteAsync(SysNetLock entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysNetLock>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysNetLock>> UpdateAsync(SysNetLock entity)
        {
            throw new NotImplementedException();
        }
    }
}
