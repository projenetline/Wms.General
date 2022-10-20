using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysNetLockManager : ISysNetLockService
    {
        private readonly ISysNetLockDal sysNetLockDal;
        private readonly ILoggerDal loggerDal;
        public SysNetLockManager(ISysNetLockDal sysNetLockDal, ILoggerDal loggerDal)
        {
            this.sysNetLockDal = sysNetLockDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysNetLock>> CreateAsync(SysNetLock entity)
        {
            try
            {
                return new SuccessDataResult<SysNetLock>(await sysNetLockDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysNetLockManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysNetLock>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysNetLock>> DeleteAsync(SysNetLock entity)
        {
            try
            {
                return new SuccessDataResult<SysNetLock>(await sysNetLockDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysNetLockManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysNetLock>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysNetLock>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysNetLock>(await sysNetLockDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysNetLockManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysNetLock>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysNetLock>> UpdateAsync(SysNetLock entity)
        {
            try
            {
                return new SuccessDataResult<SysNetLock>(await sysNetLockDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysNetLockManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysNetLock>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
