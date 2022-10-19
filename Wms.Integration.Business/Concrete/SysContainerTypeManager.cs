using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysContainerTypeManager : ISysContainerTypeService
    {
        private readonly ISysContainerTypeDal sysContainerTypeDal;
        public SysContainerTypeManager(ISysContainerTypeDal sysContainerTypeDal)
        {
            this.sysContainerTypeDal = sysContainerTypeDal;
        }
        public Task<IDataResult<SysContainerType>> CreateAsync(SysContainerType entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysContainerType>> DeleteAsync(SysContainerType entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysContainerType>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysContainerType>> UpdateAsync(SysContainerType entity)
        {
            throw new NotImplementedException();
        }
    }
}
