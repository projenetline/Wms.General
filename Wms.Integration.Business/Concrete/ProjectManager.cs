using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class ProjectManager : IProjectService
    {
        private readonly IProjectDal projectDal;
        private readonly ILoggerDal loggerDal;
        public ProjectManager(IProjectDal projectDal, ILoggerDal loggerDal)
        {
            this.projectDal = projectDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<Project>> CreateAsync(Project entity)
        {
            try
            {
                return new SuccessDataResult<Project>(await projectDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ProjectManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Project>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<Project>> DeleteAsync(Project entity)
        {
            try
            {
                return new SuccessDataResult<Project>(await projectDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ProjectManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Project>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<Project>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<Project>(await projectDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ProjectManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Project>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public  async Task<IDataResult<Project>> UpdateAsync(Project entity)
        {
            try
            {
                return new SuccessDataResult<Project>(await projectDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ProjectManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Project>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
