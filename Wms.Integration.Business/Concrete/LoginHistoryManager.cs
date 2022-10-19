using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class LoginHistoryManager : ILoginHistoryService
    {
        private readonly ILoginHistoryDal loginHistoryDal;
        public LoginHistoryManager(ILoginHistoryDal loginHistoryDal)
        {
            this.loginHistoryDal = loginHistoryDal;
        }
        public Task<IDataResult<LoginHistory>> CreateAsync(LoginHistory entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<LoginHistory>> DeleteAsync(LoginHistory entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<LoginHistory>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<LoginHistory>>> GetListAsync(LoginHistory entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PagedResult<LoginHistory>>> GetPagedListAsync(LoginHistory entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<LoginHistory>> UpdateAsync(LoginHistory entity)
        {
            throw new NotImplementedException();
        }
    }
}
