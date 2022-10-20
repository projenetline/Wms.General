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
    public class SysErpFirmManager : ISysErpFirmService
    {
        private readonly ISysErpFirmDal sysErpFirmDal;
        private readonly ILoggerDal loggerDal;
        public SysErpFirmManager(ISysErpFirmDal sysErpFirmDal, ILoggerDal loggerDal)
        {
            this.sysErpFirmDal = sysErpFirmDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<SysErpFirm>> CreateAsync(SysErpFirm entity)
        {
            try
            {
                return new SuccessDataResult<SysErpFirm>(await sysErpFirmDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysErpFirmManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysErpFirm>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<SysErpFirm>> DeleteAsync(SysErpFirm entity)
        {
            try
            {
                return new SuccessDataResult<SysErpFirm>(await sysErpFirmDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysErpFirmManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysErpFirm>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<SysErpFirm>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysErpFirm>(await sysErpFirmDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysErpFirmManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysErpFirm>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<SysErpFirm>> UpdateAsync(SysErpFirm entity)
        {
            try
            {
                return new SuccessDataResult<SysErpFirm>(await sysErpFirmDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysErpFirmManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysErpFirm>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
