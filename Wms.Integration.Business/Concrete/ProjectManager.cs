using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        private readonly IProjectDal projectDal;
        public ProjectManager(IProjectDal projectDal)
        {
            this.projectDal = projectDal;
        }
        public Task<IDataResult<Project>> CreateAsync(Project entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Project>> DeleteAsync(Project entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Project>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<Project>>> GetListAsync(Project entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PagedResult<Project>>> GetPagedListAsync(Project entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Project>> UpdateAsync(Project entity)
        {
            throw new NotImplementedException();
        }
    }
}
