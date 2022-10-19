using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysSessionManager : ISysSessionService
    {
        private readonly ISysSessionDal sysSessionDal;
        public SysSessionManager(ISysSessionDal sysSessionDal)
        {
            this.sysSessionDal = sysSessionDal;
        }

        public Task<IDataResult<SysSession>> CreateAsync(SysSession entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysSession>> DeleteAsync(SysSession entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysSession>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysSession>> UpdateAsync(SysSession entity)
        {
            throw new NotImplementedException();
        }
    }
}
