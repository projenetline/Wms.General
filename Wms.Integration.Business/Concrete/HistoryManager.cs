using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class HistoryManager : IHistoryService
    {
        private readonly IHistoryDal _historyDal;
        public HistoryManager(IHistoryDal historyDal)
        {
            _historyDal = historyDal;
        }
        public Task<IDataResult<History>> CreateAsync(History entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<History>> DeleteAsync(History entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<History>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<History>> UpdateAsync(History entity)
        {
            throw new NotImplementedException();
        }
    }
}
