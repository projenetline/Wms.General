using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysErpManager : ISysErpService
    {
        private readonly ISysErpDal sysErpDal;
        private readonly ILoggerDal loggerDal;
        public SysErpManager(ISysErpDal sysErpDal, ILoggerDal loggerDal)
        {
            this.sysErpDal = sysErpDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<SysErp>> CreateAsync(SysErp entity)
        {
            try
            {
                return new SuccessDataResult<SysErp>(await sysErpDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysErpManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysErp>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<SysErp>> DeleteAsync(SysErp entity)
        {
            try
            {
                return new SuccessDataResult<SysErp>(await sysErpDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysErpManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysErp>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<SysErp>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysErp>(await sysErpDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysErpManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysErp>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<SysErp>> UpdateAsync(SysErp entity)
        {
            try
            {
                return new SuccessDataResult<SysErp>(await sysErpDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysErpManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysErp>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
