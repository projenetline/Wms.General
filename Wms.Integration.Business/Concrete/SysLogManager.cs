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
    public class SysLogManager : ISysLogService
    {
        private readonly ISysLogDal sysLogDal;
        private readonly ILoggerDal loggerDal;
        public SysLogManager(ISysLogDal sysLogDal, ILoggerDal loggerDal)
        {
            this.sysLogDal = sysLogDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysLog>> CreateAsync(SysLog entity)
        {
            try
            {
                return new SuccessDataResult<SysLog>(await sysLogDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysLogManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysLog>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysLog>> DeleteAsync(SysLog entity)
        {
            try
            {
                return new SuccessDataResult<SysLog>(await sysLogDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysLogManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysLog>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysLog>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysLog>(await sysLogDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysLogManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysLog>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysLog>> UpdateAsync(SysLog entity)
        {
            try
            {
                return new SuccessDataResult<SysLog>(await sysLogDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysLogManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysLog>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
