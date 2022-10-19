using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysPasswordHistoryManager : ISysPasswordHistoryService
    {
        private readonly ISysPasswordHistoryDal sysPasswordHistoryDal;
        public SysPasswordHistoryManager(ISysPasswordHistoryDal sysPasswordHistoryDal)
        {
            this.sysPasswordHistoryDal = sysPasswordHistoryDal;
        }

        public Task<IDataResult<SysPasswordHistory>> CreateAsync(SysPasswordHistory entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysPasswordHistory>> DeleteAsync(SysPasswordHistory entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysPasswordHistory>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysPasswordHistory>> UpdateAsync(SysPasswordHistory entity)
        {
            throw new NotImplementedException();
        }
    }
}
