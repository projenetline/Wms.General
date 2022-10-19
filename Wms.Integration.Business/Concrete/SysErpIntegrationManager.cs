using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysErpIntegrationManager : ISysErpIntegrationService
    {
        private readonly ISysErpIntegrationDal sysErpIntegrationDal;
        public SysErpIntegrationManager(ISysErpIntegrationDal sysErpIntegrationDal)
        {
            this.sysErpIntegrationDal = sysErpIntegrationDal;
        }

        public Task<IDataResult<SysErpIntegration>> CreateAsync(SysErpIntegration entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysErpIntegration>> DeleteAsync(SysErpIntegration entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysErpIntegration>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysErpIntegration>> UpdateAsync(SysErpIntegration entity)
        {
            throw new NotImplementedException();
        }
    }
}
