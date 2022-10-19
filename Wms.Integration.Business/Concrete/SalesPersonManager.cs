using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SalesPersonManager : ISalesPersonService
    {
        private readonly ISalesPersonDal salesPersonDal;
        public SalesPersonManager(ISalesPersonDal salesPersonDal)
        {
            this.salesPersonDal = salesPersonDal;
        }

        public Task<IDataResult<SalesPerson>> CreateAsync(SalesPerson entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SalesPerson>> DeleteAsync(SalesPerson entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SalesPerson>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SalesPerson>> UpdateAsync(SalesPerson entity)
        {
            throw new NotImplementedException();
        }
    }
}
