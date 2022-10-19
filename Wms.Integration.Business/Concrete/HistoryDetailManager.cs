using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class HistoryDetailManager : IHistoryDetailService
    {
        private readonly IHistoryDetailDal historyDetailDal;
        public HistoryDetailManager(IHistoryDetailDal historyDetailDal)
        {
            this.historyDetailDal = historyDetailDal;
        }
        public Task<IDataResult<HistoryDetail>> CreateAsync(HistoryDetail entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<HistoryDetail>> DeleteAsync(HistoryDetail entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<HistoryDetail>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<HistoryDetail>> UpdateAsync(HistoryDetail entity)
        {
            throw new NotImplementedException();
        }
    }
}
