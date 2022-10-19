using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class DriverManager : IDriverService
    {
        private readonly IDriverDal driverDal;
        public DriverManager(IDriverDal driverDal)
        {
            this.driverDal = driverDal;
        }
        public Task<IDataResult<Driver>> CreateAsync(Driver entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Driver>> DeleteAsync(Driver entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Driver>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<Driver>> UpdateAsync(Driver entity)
        {
            throw new NotImplementedException();
        }
    }
}
