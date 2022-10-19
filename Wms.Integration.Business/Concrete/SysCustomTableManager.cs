using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysCustomTableManager : ISysCustomTableService
    {
        private readonly ISysCustomTableDal sysCustomTableDal;
        public SysCustomTableManager(ISysCustomTableDal sysCustomTableDal)
        {
            this.sysCustomTableDal = sysCustomTableDal;
        }
        public Task<IDataResult<SysCustomTable>> CreateAsync(SysCustomTable entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomTable>> DeleteAsync(SysCustomTable entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomTable>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysCustomTable>> UpdateAsync(SysCustomTable entity)
        {
            throw new NotImplementedException();
        }
    }
}
