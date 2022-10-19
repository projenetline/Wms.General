using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class CarrierManager:ICarrierService
    {
        private readonly ICarrierDal carrierDal;
        public CarrierManager(ICarrierDal carrierDal)
        {
            this.carrierDal = carrierDal;
        }

        public Task<IDataResult<Carrier>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Carrier>> CreateAsync(Carrier entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Carrier>> UpdateAsync(Carrier entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Carrier>> DeleteAsync(Carrier entity)
        {
            throw new NotImplementedException();
        }
    }
}
