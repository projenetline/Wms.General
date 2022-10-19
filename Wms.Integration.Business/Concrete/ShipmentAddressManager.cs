using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ShipmentAddressManager : IShipmentAddressService
    {
        private readonly IShipmentAddressDal shipmentAddressDal;
        public ShipmentAddressManager(IShipmentAddressDal shipmentAddressDal)
        {
            this.shipmentAddressDal = shipmentAddressDal;
        }
        public Task<IDataResult<ShipmentAddress>> CreateAsync(ShipmentAddress entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ShipmentAddress>> DeleteAsync(ShipmentAddress entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ShipmentAddress>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ShipmentAddress>> UpdateAsync(ShipmentAddress entity)
        {
            throw new NotImplementedException();
        }
    }
}
