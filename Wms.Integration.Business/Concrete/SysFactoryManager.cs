using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysFactoryManager:ISysFactoryService
    {
        private readonly ISysFactoryDal sysFactoryDal;
        public SysFactoryManager(ISysFactoryDal sysFactoryDal)
        {
            this.sysFactoryDal = sysFactoryDal;
        }
        public Task<IDataResult<SysFactory>> CreateAsync(SysFactory entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysFactory>> DeleteAsync(SysFactory entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysFactory>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysFactory>> UpdateAsync(SysFactory entity)
        {
            throw new NotImplementedException();
        }
    }
}
