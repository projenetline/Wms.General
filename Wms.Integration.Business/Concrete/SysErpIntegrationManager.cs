using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysErpIntegrationManager : ISysErpIntegrationService
    {
        private readonly ISysErpIntegrationDal sysErpIntegrationDal;
        private readonly ILoggerDal loggerDal;
        public SysErpIntegrationManager(ISysErpIntegrationDal sysErpIntegrationDal, ILoggerDal loggerDal)
        {
            this.sysErpIntegrationDal = sysErpIntegrationDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysErpIntegration>> CreateAsync(SysErpIntegration entity)
        {
            try
            {
                return new SuccessDataResult<SysErpIntegration>(await sysErpIntegrationDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysErpIntegrationManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysErpIntegration>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysErpIntegration>> DeleteAsync(SysErpIntegration entity)
        {
            try
            {
                return new SuccessDataResult<SysErpIntegration>(await sysErpIntegrationDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysErpIntegrationManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysErpIntegration>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysErpIntegration>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysErpIntegration>(await sysErpIntegrationDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysErpIntegrationManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysErpIntegration>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysErpIntegration>> UpdateAsync(SysErpIntegration entity)
        {
            try
            {
                return new SuccessDataResult<SysErpIntegration>(await sysErpIntegrationDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysErpIntegrationManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysErpIntegration>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
