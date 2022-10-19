using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ShipmentDayManager : IShipmentDayService
    {
        private readonly IShipmentDayDal shipmentDayDal;
        public ShipmentDayManager(IShipmentDayDal shipmentDayDal)
        {
            this.shipmentDayDal = shipmentDayDal;
        }

        public Task<IDataResult<ShipmentDay>> CreateAsync(ShipmentDay entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ShipmentDay>> DeleteAsync(ShipmentDay entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ShipmentDay>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ShipmentDay>> UpdateAsync(ShipmentDay entity)
        {
            throw new NotImplementedException();
        }
    }
}
