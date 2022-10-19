using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ErpinvTotalManager : IErpinvTotalService
    {
        private readonly IErpinvTotalDal erpinvTotalDal;
        public ErpinvTotalManager(IErpinvTotalDal erpinvTotalDal)
        {
            this.erpinvTotalDal = erpinvTotalDal;
        }
        public Task<IDataResult<ErpinvTotal>> CreateAsync(ErpinvTotal entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ErpinvTotal>> DeleteAsync(ErpinvTotal entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ErpinvTotal>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ErpinvTotal>> UpdateAsync(ErpinvTotal entity)
        {
            throw new NotImplementedException();
        }
    }
}
