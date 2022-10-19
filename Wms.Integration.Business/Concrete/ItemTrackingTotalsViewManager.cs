using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ItemTrackingTotalsViewManager : IItemTrackingTotalsViewService
    {
        private readonly IItemTrackingTotalsViewDal itemTrackingTotalsViewDal;
        public ItemTrackingTotalsViewManager(IItemTrackingTotalsViewDal itemTrackingTotalsViewDal)
        {
            this.itemTrackingTotalsViewDal = itemTrackingTotalsViewDal;
        }
        public Task<IDataResult<ItemTrackingTotalsView>> GetData(int Id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<ItemTrackingTotalsView>>> GetListAsync(ItemTrackingTotalsView entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PagedResult<ItemTrackingTotalsView>>> GetPagedListAsync(ItemTrackingTotalsView entity)
        {
            throw new NotImplementedException();
        }
    }
}
