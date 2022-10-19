using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysWarehouseFloorManager : ISysWarehouseFloorService
    {
        private readonly ISysWarehouseFloorDal sysWarehouseFloorDal;
        public SysWarehouseFloorManager(ISysWarehouseFloorDal sysWarehouseFloorDal)
        {
            this.sysWarehouseFloorDal = sysWarehouseFloorDal;
        }

        public Task<IDataResult<SysWarehouseFloor>> CreateAsync(SysWarehouseFloor entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysWarehouseFloor>> DeleteAsync(SysWarehouseFloor entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysWarehouseFloor>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysWarehouseFloor>> UpdateAsync(SysWarehouseFloor entity)
        {
            throw new NotImplementedException();
        }
    }
}
