using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysContainerRelationManager : ISysContainerRelationService
    {
        private readonly ISysContainerRelationDal sysContainerRelationDal;
        public SysContainerRelationManager(ISysContainerRelationDal sysContainerRelationDal)
        {
            this.sysContainerRelationDal = sysContainerRelationDal;
        }

        public Task<IDataResult<SysContainerRelation>> CreateAsync(SysContainerRelation entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysContainerRelation>> DeleteAsync(SysContainerRelation entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysContainerRelation>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysContainerRelation>> UpdateAsync(SysContainerRelation entity)
        {
            throw new NotImplementedException();
        }
    }
}
