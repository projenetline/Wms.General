using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class VehicleManager : IVehicleService
    {
        private readonly IVehicleDal vehicleDal;
        public VehicleManager(IVehicleDal vehicleDal)
        {
            this.vehicleDal = vehicleDal;
        }

        public Task<IDataResult<Vehicle>> CreateAsync(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Vehicle>> DeleteAsync(Vehicle entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Vehicle>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Vehicle>> UpdateAsync(Vehicle entity)
        {
            throw new NotImplementedException();
        }
    }
}
