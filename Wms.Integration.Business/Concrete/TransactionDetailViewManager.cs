using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class TransactionDetailViewManager:ITransactionDetailViewService
    {
        private readonly ITransactionDetailViewDal transactionDetailViewDal;
        public TransactionDetailViewManager(ITransactionDetailViewDal transactionDetailViewDal)
        {
            this.transactionDetailViewDal = transactionDetailViewDal;
        }
        public Task<IDataResult<TransactionDetailView>> GetData(int Id)
        {
            throw new NotImplementedException();
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
