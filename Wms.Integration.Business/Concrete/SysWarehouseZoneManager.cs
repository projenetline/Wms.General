using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysWarehouseZoneManager : ISysWarehouseZoneService
    {
        private readonly ISysWarehouseZoneDal sysWarehouseZoneDal;
        public SysWarehouseZoneManager(ISysWarehouseZoneDal sysWarehouseZoneDal)
        {
            this.sysWarehouseZoneDal = sysWarehouseZoneDal;
        }

        public Task<IDataResult<SysWarehouseZone>> CreateAsync(SysWarehouseZone entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysWarehouseZone>> DeleteAsync(SysWarehouseZone entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysWarehouseZone>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysWarehouseZone>> UpdateAsync(SysWarehouseZone entity)
        {
            throw new NotImplementedException();
        }
    }
}
