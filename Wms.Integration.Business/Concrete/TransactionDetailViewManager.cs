using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class TransactionDetailViewManager:ITransactionDetailViewService
    {
        private readonly ITransactionDetailViewDal transactionDetailViewDal;
        private readonly ILoggerDal loggerDal;
        public TransactionDetailViewManager(ITransactionDetailViewDal transactionDetailViewDal, ILoggerDal loggerDal)
        {
            this.transactionDetailViewDal = transactionDetailViewDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<TransactionDetailView>> GetData(int Id)
        {
            try
            {
                return new SuccessDataResult<TransactionDetailView>(await transactionDetailViewDal.GetAsync(s=>s.AddressId==Id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "TransactionDetailViewManager.GetData",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<TransactionDetailView>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public Task<IDataResult<IList<TransactionDetailView>>> GetListAsync(TransactionDetailView entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<PagedResult<TransactionDetailView>>> GetPagedListAsync(TransactionDetailView entity)
        {
            throw new NotImplementedException();
        }
    }
}
