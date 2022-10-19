using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysCustomCodeManager : ISysCustomCodeService
    {
        private readonly ISysCustomCodeDal sysCustomCodeDal;
        public SysCustomCodeManager(ISysCustomCodeDal sysCustomCodeDal)
        {
            this.sysCustomCodeDal = sysCustomCodeDal;
        }
        public Task<IDataResult<SysCustomCode>> CreateAsync(SysCustomCode entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomCode>> DeleteAsync(SysCustomCode entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomCode>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomCode>> UpdateAsync(SysCustomCode entity)
        {
            throw new NotImplementedException();
        }
    }
}
