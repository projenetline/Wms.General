using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class ItemTotalsReportViewManager : IItemTotalsReportViewService
    {
        private readonly IItemTotalsReportViewDal itemtotalsReportviewDal;
        private readonly ILoggerDal loggerDal;
        public ItemTotalsReportViewManager(IItemTotalsReportViewDal itemtotalsReportviewDal, ILoggerDal loggerDal)
        {
            this.itemtotalsReportviewDal = itemtotalsReportviewDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<ItemTotalsReportView>> GetData(int Id)
        {
            try
            {
                return new SuccessDataResult<ItemTotalsReportView>(await itemtotalsReportviewDal.GetAsync(s=>s.WarehouseId==Id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemParameterManager.GetData",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemTotalsReportView>(null, CustomJObject.Instance.General.NotUpdate);
            }
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
