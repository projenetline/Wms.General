using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysCustomListColumnManager : ISysCustomListColumnService
    {
        private readonly ISysCustomListColumnDal sysCustomListColumnDal;
        public SysCustomListColumnManager(ISysCustomListColumnDal sysCustomListColumnDal)
        {
            this.sysCustomListColumnDal = sysCustomListColumnDal;
        }

        public Task<IDataResult<SysCustomListColumn>> CreateAsync(SysCustomListColumn entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomListColumn>> DeleteAsync(SysCustomListColumn entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomListColumn>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomListColumn>> UpdateAsync(SysCustomListColumn entity)
        {
            throw new NotImplementedException();
        }
    }
}
