using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysUserWarehouseManager : ISysUserWarehouseService
    {
        private readonly ISysUserWarehouseDal sysUserWarehouseDal;
        public SysUserWarehouseManager(ISysUserWarehouseDal sysUserWarehouseDal)
        {
            this.sysUserWarehouseDal = sysUserWarehouseDal;
        }

        public Task<IDataResult<SysUserWarehouse>> CreateAsync(SysUserWarehouse entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysUserWarehouse>> DeleteAsync(SysUserWarehouse entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysUserWarehouse>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysUserWarehouse>> UpdateAsync(SysUserWarehouse entity)
        {
            throw new NotImplementedException();
        }
    }
}
