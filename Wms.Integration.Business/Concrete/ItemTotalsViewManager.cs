using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ItemTotalsViewManager : IItemTotalsViewService
    {
        private readonly IItemTotalsViewDal itemtotalsViewDal;
        public ItemTotalsViewManager(IItemTotalsViewDal itemtotalsViewDal)
        {
            this.itemtotalsViewDal = itemtotalsViewDal;
        }
        public Task<IDataResult<ItemTotalsView>> GetData(int Id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<IList<ItemTotalsView>>> GetListAsync(ItemTotalsView entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<PagedResult<ItemTotalsView>>> GetPagedListAsync(ItemTotalsView entity)
        {
            throw new NotImplementedException();
        }
    }
}
