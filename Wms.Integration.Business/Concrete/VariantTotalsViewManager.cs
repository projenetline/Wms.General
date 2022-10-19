using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class VariantTotalsViewManager : IVariantTotalsViewService
    {
        private readonly IVariantTotalsViewDal variantTotalsViewDal;
        public VariantTotalsViewManager(IVariantTotalsViewDal variantTotalsViewDal)
        {
            this.variantTotalsViewDal = variantTotalsViewDal;
        }

        public Task<IDataResult<VariantTotalsView>> GetData(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<VariantTotalsView>>> GetListAsync(VariantTotalsView entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PagedResult<VariantTotalsView>>> GetPagedListAsync(VariantTotalsView entity)
        {
            throw new NotImplementedException();
        }
    }
}
