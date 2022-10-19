using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysLogManager : ISysLogService
    {
        private readonly ISysLogDal sysLogDal;
        public SysLogManager(ISysLogDal sysLogDal)
        {
            this.sysLogDal = sysLogDal;
        }

        public Task<IDataResult<SysLog>> CreateAsync(SysLog entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysLog>> DeleteAsync(SysLog entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysLog>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysLog>> UpdateAsync(SysLog entity)
        {
            throw new NotImplementedException();
        }
    }
}
