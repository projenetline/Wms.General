using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysWarehouseManager : ISysWarehouseService
    {
        private readonly ISysWarehouseDal sysWarehouseDal;
        public SysWarehouseManager(ISysWarehouseDal sysWarehouseDal)
        {
            this.sysWarehouseDal = sysWarehouseDal;
        }
        public Task<IDataResult<SysWarehouse>> CreateAsync(SysWarehouse entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<SysWarehouse>> DeleteAsync(SysWarehouse entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<SysWarehouse>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<SysWarehouse>> UpdateAsync(SysWarehouse entity)
        {
            throw new NotImplementedException();
        }
    }
}
