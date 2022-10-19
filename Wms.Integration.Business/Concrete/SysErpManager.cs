using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysErpManager : ISysErpService
    {
        private readonly ISysErpDal sysErpDal;
        public SysErpManager(ISysErpDal sysErpDal)
        {
            this.sysErpDal = sysErpDal;
        }
        public Task<IDataResult<SysErp>> CreateAsync(SysErp entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<SysErp>> DeleteAsync(SysErp entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<SysErp>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<SysErp>> UpdateAsync(SysErp entity)
        {
            throw new NotImplementedException();
        }
    }
}
