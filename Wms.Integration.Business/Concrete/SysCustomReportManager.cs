using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysCustomReportManager : ISysCustomReportService
    {
        private readonly ISysCustomReportDal sysCustomReportDal;
        private readonly ILoggerDal loggerDal;
        public SysCustomReportManager(ISysCustomReportDal sysCustomReportDal, ILoggerDal loggerDal)
        {
            this.sysCustomReportDal = sysCustomReportDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<SysCustomReport>> CreateAsync(SysCustomReport entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomReport>(await sysCustomReportDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomReportManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomReport>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysCustomReport>> DeleteAsync(SysCustomReport entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomReport>(await sysCustomReportDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomReportManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomReport>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysCustomReport>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysCustomReport>(await sysCustomReportDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomReportManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomReport>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysCustomReport>> UpdateAsync(SysCustomReport entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomReport>(await sysCustomReportDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomReportManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomReport>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
