using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysMenuRightManager:ISysMenuRightService
    {
        private readonly ISysMenuRightDal sysMenuRightDal;
        public SysMenuRightManager(ISysMenuRightDal sysMenuRightDal)
        {
            this.sysMenuRightDal = sysMenuRightDal;
        }
        public Task<IDataResult<SysMenuRight>> CreateAsync(SysMenuRight entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<SysMenuRight>> DeleteAsync(SysMenuRight entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<SysMenuRight>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<SysMenuRight>> UpdateAsync(SysMenuRight entity)
        {
            throw new NotImplementedException();
        }
    }
}
