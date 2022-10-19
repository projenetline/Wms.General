using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysCustomStateManager : ISysCustomStateService
    {
        private readonly ISysCustomStateDal sysCustomStateDal;
        public SysCustomStateManager(ISysCustomStateDal sysCustomStateDal)
        {
            this.sysCustomStateDal = sysCustomStateDal;
        }

        public Task<IDataResult<SysCustomState>> CreateAsync(SysCustomState entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomState>> DeleteAsync(SysCustomState entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomState>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomState>> UpdateAsync(SysCustomState entity)
        {
            throw new NotImplementedException();
        }
    }
}
