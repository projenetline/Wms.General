using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysErpFirmManager : ISysErpFirmService
    {
        private readonly ISysErpFirmDal sysErpFirmDal;
        public SysErpFirmManager(ISysErpFirmDal sysErpFirmDal)
        {
            this.sysErpFirmDal = sysErpFirmDal;
        }

        public Task<IDataResult<SysErpFirm>> CreateAsync(SysErpFirm entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysErpFirm>> DeleteAsync(SysErpFirm entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysErpFirm>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysErpFirm>> UpdateAsync(SysErpFirm entity)
        {
            throw new NotImplementedException();
        }
    }
}
