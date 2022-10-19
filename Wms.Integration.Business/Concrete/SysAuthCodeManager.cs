using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysAuthCodeManager : ISysAuthCodeService
    {
        private readonly ISysAuthCodeDal sysAuthCodeDal;
        public SysAuthCodeManager(ISysAuthCodeDal sysAuthCodeDal)
        {
            this.sysAuthCodeDal = sysAuthCodeDal;
        }

        public Task<IDataResult<SysAuthCode>> CreateAsync(SysAuthCode entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysAuthCode>> DeleteAsync(SysAuthCode entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysAuthCode>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysAuthCode>> UpdateAsync(SysAuthCode entity)
        {
            throw new NotImplementedException();
        }
    }
}
