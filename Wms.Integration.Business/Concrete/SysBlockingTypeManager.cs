using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysBlockingTypeManager : ISysBlockingTypeService
    {
        private readonly ISysBlockingTypeService sysBlockingService;
        public SysBlockingTypeManager(ISysBlockingTypeService sysBlockingService)
        {
            this.sysBlockingService = sysBlockingService;
        }

        public Task<IDataResult<SysBlockingType>> CreateAsync(SysBlockingType entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysBlockingType>> DeleteAsync(SysBlockingType entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysBlockingType>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysBlockingType>> UpdateAsync(SysBlockingType entity)
        {
            throw new NotImplementedException();
        }
    }
}
