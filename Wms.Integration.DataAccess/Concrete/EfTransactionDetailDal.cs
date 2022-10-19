using Wms.Integration.Core.DataAccess.Abstract;
using Wms.Integration.Core.DataAccess.Concrete;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete.Contexts;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.DataAccess.Concrete
{
    public class EfTransactionDetailDal: EfEntityRepository<TransactionDetail, WMSContext>, ITransactionDetailDal
    {
    }
}
