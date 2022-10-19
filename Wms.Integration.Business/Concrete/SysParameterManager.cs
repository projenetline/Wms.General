using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysParameterManager : ISysParameterService
    {
        private readonly ISysParameterDal sysParameterDal;
        public SysParameterManager(ISysParameterDal sysParameterDal)
        {
            this.sysParameterDal =sysParameterDal;
        }
        public Task<IDataResult<SysParameter>> CreateAsync(SysParameter entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysParameter>> DeleteAsync(SysParameter entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysParameter>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysParameter>> UpdateAsync(SysParameter entity)
        {
            throw new NotImplementedException();
        }
    }
}
