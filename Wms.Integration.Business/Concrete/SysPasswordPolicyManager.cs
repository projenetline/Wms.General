using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysPasswordPolicyManager : ISysPasswordPolicyService
    {
        private readonly ISysPasswordPolicyDal sysPasswordPolicyDal;
        public SysPasswordPolicyManager(ISysPasswordPolicyDal sysPasswordPolicyDal)
        {
            this.sysPasswordPolicyDal = sysPasswordPolicyDal;
        }

        public Task<IDataResult<SysPasswordPolicy>> CreateAsync(SysPasswordPolicy entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysPasswordPolicy>> DeleteAsync(SysPasswordPolicy entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysPasswordPolicy>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysPasswordPolicy>> UpdateAsync(SysPasswordPolicy entity)
        {
            throw new NotImplementedException();
        }
    }
}
