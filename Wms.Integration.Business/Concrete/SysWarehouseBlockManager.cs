using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysWarehouseBlockManager : ISysWarehouseBlockService
    {
        private readonly ISysWarehouseBlockDal sysWarehouseBlockDal;
        public SysWarehouseBlockManager(ISysWarehouseBlockDal sysWarehouseBlockDal)
        {
            this.sysWarehouseBlockDal = sysWarehouseBlockDal;
        }

        public Task<IDataResult<SysWarehouseBlock>> CreateAsync(SysWarehouseBlock entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysWarehouseBlock>> DeleteAsync(SysWarehouseBlock entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysWarehouseBlock>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysWarehouseBlock>> UpdateAsync(SysWarehouseBlock entity)
        {
            throw new NotImplementedException();
        }
    }
}
