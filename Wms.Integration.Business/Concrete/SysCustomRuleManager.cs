using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysCustomRuleManager : ISysCustomRuleService
    {
        private readonly ISysCustomRuleDal sysCustomRuleDal;
        public SysCustomRuleManager(ISysCustomRuleDal sysCustomRuleDal)
        {
            this.sysCustomRuleDal = sysCustomRuleDal;
        }
        public Task<IDataResult<SysCustomRule>> CreateAsync(SysCustomRule entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomRule>> DeleteAsync(SysCustomRule entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomRule>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomRule>> UpdateAsync(SysCustomRule entity)
        {
            throw new NotImplementedException();
        }
    }
}
