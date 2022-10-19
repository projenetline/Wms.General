using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysAddressManager : ISysAddressService
    {
        private readonly ISysAddressDal sysAddressDal;
        public SysAddressManager(ISysAddressDal sysAddressDal)
        {
            this.sysAddressDal = sysAddressDal;
        }
        public Task<IDataResult<SysAddress>> CreateAsync(SysAddress entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysAddress>> DeleteAsync(SysAddress entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysAddress>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysAddress>> UpdateAsync(SysAddress entity)
        {
            throw new NotImplementedException();
        }
    }
}
