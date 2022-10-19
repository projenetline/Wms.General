using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ItemTotalsReportViewManager : IItemTotalsReportViewService
    {
        private readonly IItemTotalsReportViewDal itemtotalsReportviewDal;
        public ItemTotalsReportViewManager(IItemTotalsReportViewDal itemtotalsReportviewDal)
        {
            this.itemtotalsReportviewDal = itemtotalsReportviewDal;
        }
        public Task<IDataResult<ItemTotalsReportView>> GetData(int Id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<IList<ItemTotalsReportView>>> GetListAsync(ItemTotalsReportView entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<PagedResult<ItemTotalsReportView>>> GetPagedListAsync(ItemTotalsReportView entity)
        {
            throw new NotImplementedException();
        }
    }
}
