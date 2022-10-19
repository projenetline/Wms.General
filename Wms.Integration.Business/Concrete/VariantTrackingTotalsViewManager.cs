using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class VariantTrackingTotalsViewManager : IVariantTrackingTotalsViewService
    {
        private readonly IVariantTrackingTotalsViewDal _variantTrackingTotalsViewDal;
        public VariantTrackingTotalsViewManager(IVariantTrackingTotalsViewDal variantTrackingTotalsViewDal)
        {
            _variantTrackingTotalsViewDal = variantTrackingTotalsViewDal;
        }

        public Task<IDataResult<VariantTrackingTotalsView>> GetData(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<VariantTrackingTotalsView>>> GetListAsync(VariantTrackingTotalsView entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PagedResult<VariantTrackingTotalsView>>> GetPagedListAsync(VariantTrackingTotalsView entity)
        {
            throw new NotImplementedException();
        }
    }
}
