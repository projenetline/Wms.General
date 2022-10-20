using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysCustomStateManager : ISysCustomStateService
    {
        private readonly ISysCustomStateDal sysCustomStateDal;
        private readonly ILoggerDal loggerDal;
        public SysCustomStateManager(ISysCustomStateDal sysCustomStateDal, ILoggerDal loggerDal)
        {
            this.sysCustomStateDal = sysCustomStateDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysCustomState>> CreateAsync(SysCustomState entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomState>(await sysCustomStateDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomStateManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomState>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysCustomState>> DeleteAsync(SysCustomState entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomState>(await sysCustomStateDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomStateManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomState>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysCustomState>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysCustomState>(await sysCustomStateDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomStateManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomState>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysCustomState>> UpdateAsync(SysCustomState entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomState>(await sysCustomStateDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomStateManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomState>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
