using Wms.Integration.Core.DataAccess.Abstract;
using Wms.Integration.Core.DataAccess.Concrete;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete.Contexts;

namespace Wms.Integration.Entities.Concrete
{
    public class EfVehicleDal: EfEntityRepository<Vehicle, WMSContext>, IVehicleDal
    {
    }
}
