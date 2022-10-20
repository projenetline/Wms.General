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
    public class SysScriptManager : ISysScriptService
    {
        private readonly ISysScriptDal sysScriptDal;
        private readonly ILoggerDal loggerDal;
        public SysScriptManager(ISysScriptDal sysScriptDal, ILoggerDal loggerDal)
        {
            this.sysScriptDal = sysScriptDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysScript>> CreateAsync(SysScript entity)
        {
            try
            {
                return new SuccessDataResult<SysScript>(await sysScriptDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysScriptManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysScript>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysScript>> DeleteAsync(SysScript entity)
        {
            try
            {
                return new SuccessDataResult<SysScript>(await sysScriptDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysScriptManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysScript>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysScript>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysScript>(await sysScriptDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysScriptManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysScript>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysScript>> UpdateAsync(SysScript entity)
        {
            try
            {
                return new SuccessDataResult<SysScript>(await sysScriptDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysScriptManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysScript>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
