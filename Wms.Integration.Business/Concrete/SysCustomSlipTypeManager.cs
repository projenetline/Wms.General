using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysCustomSlipTypeManager : ISysCustomSlipTypeService
    {
        private readonly ISysCustomSlipTypeDal sysCustomSlipTypeDal;
        public SysCustomSlipTypeManager(ISysCustomSlipTypeDal sysCustomSlipTypeDal)
        {
            this.sysCustomSlipTypeDal = sysCustomSlipTypeDal;
        }

        public Task<IDataResult<SysCustomSlipType>> CreateAsync(SysCustomSlipType entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomSlipType>> DeleteAsync(SysCustomSlipType entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomSlipType>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomSlipType>> UpdateAsync(SysCustomSlipType entity)
        {
            throw new NotImplementedException();
        }
    }
}
