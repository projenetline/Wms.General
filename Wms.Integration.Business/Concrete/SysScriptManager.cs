using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysScriptManager : ISysScriptService
    {
        private readonly ISysScriptDal sysScriptDal;
        public SysScriptManager(ISysScriptDal sysScriptDal)
        {
            this.sysScriptDal = sysScriptDal;
        }

        public Task<IDataResult<SysScript>> CreateAsync(SysScript entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysScript>> DeleteAsync(SysScript entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysScript>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysScript>> UpdateAsync(SysScript entity)
        {
            throw new NotImplementedException();
        }
    }
}
