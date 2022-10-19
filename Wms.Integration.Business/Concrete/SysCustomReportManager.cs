using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysCustomReportManager : ISysCustomReportService
    {
        private readonly ISysCustomReportDal sysCustomReportDal;
        public SysCustomReportManager(ISysCustomReportDal sysCustomReportDal)
        {
            this.sysCustomReportDal = sysCustomReportDal;
        }
        public Task<IDataResult<SysCustomReport>> CreateAsync(SysCustomReport entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomReport>> DeleteAsync(SysCustomReport entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomReport>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomReport>> UpdateAsync(SysCustomReport entity)
        {
            throw new NotImplementedException();
        }
    }
}
