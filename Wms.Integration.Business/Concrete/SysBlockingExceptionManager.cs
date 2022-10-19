using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysBlockingExceptionManager : ISysBlockingExceptionService
    {
        private readonly ISysBlockingExceptionDal sysBlockingExceptionDal;
        public SysBlockingExceptionManager(ISysBlockingExceptionDal sysBlockingExceptionDal)
        {
            this.sysBlockingExceptionDal = sysBlockingExceptionDal;
        }
        public Task<IDataResult<SysBlockingException>> CreateAsync(SysBlockingException entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysBlockingException>> DeleteAsync(SysBlockingException entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysBlockingException>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysBlockingException>> UpdateAsync(SysBlockingException entity)
        {
            throw new NotImplementedException();
        }
    }
}
