using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class TransactionDetailManager : ITransactionDetailService
    {
        private readonly ITransactionDetailDal transactionDetailDal;
        public TransactionDetailManager(ITransactionDetailDal transactionDetailDal)
        {
            this.transactionDetailDal = transactionDetailDal;
        }

        public Task<IDataResult<TransactionDetail>> CreateAsync(TransactionDetail entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<TransactionDetail>> DeleteAsync(TransactionDetail entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<TransactionDetail>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<TransactionDetail>> UpdateAsync(TransactionDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
