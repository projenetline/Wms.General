
using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ContainerManager : IContainerService
    {
        private readonly IContainerDal containerDal;
        public ContainerManager(IContainerDal containerDal)
        {
            this.containerDal = containerDal;
        }
        public Task<IDataResult<Container>> CreateAsync(Container entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Container>> DeleteAsync(Container entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Container>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<Container>> UpdateAsync(Container entity)
        {
            throw new NotImplementedException();
        }
    }
}
