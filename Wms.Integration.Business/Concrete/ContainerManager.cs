using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class ContainerManager : IContainerService
    {
        private readonly IContainerDal containerDal;
        private readonly ILoggerDal loggerDal;
        public ContainerManager(IContainerDal containerDal, ILoggerDal loggerDal)
        {
            this.containerDal = containerDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<Container>> CreateAsync(Container entity)
        {
            try
            {
                return new SuccessDataResult<Container>(await containerDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ContainerManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Container>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<Container>> DeleteAsync(Container entity)
        {
            try
            {
                return new SuccessDataResult<Container>(await containerDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ContainerManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Container>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<Container>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<Container>(await containerDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ContainerManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Container>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<Container>> UpdateAsync(Container entity)
        {
            try
            {
                return new SuccessDataResult<Container>(await containerDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ContainerManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Container>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
