using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysCustomRuleActionManager : ISysCustomRuleActionService
    {
        private readonly ISysCustomRuleActionDal sysCustomRuleActionDal;
        public SysCustomRuleActionManager(ISysCustomRuleActionDal sysCustomRuleActionDal)
        {
            this.sysCustomRuleActionDal = sysCustomRuleActionDal;
        }
        public Task<IDataResult<SysCustomRuleAction>> CreateAsync(SysCustomRuleAction entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<SysCustomRuleAction>> DeleteAsync(SysCustomRuleAction entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<SysCustomRuleAction>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<SysCustomRuleAction>> UpdateAsync(SysCustomRuleAction entity)
        {
            throw new NotImplementedException();
        }
    }
}
