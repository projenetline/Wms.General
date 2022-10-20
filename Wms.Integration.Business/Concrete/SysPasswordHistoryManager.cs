using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysPasswordHistoryManager : ISysPasswordHistoryService
    {
        private readonly ISysPasswordHistoryDal sysPasswordHistoryDal;
        private readonly ILoggerDal loggerDal;
        public SysPasswordHistoryManager(ISysPasswordHistoryDal sysPasswordHistoryDal, ILoggerDal loggerDal)
        {
            this.sysPasswordHistoryDal = sysPasswordHistoryDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysPasswordHistory>> CreateAsync(SysPasswordHistory entity)
        {
            try
            {
                return new SuccessDataResult<SysPasswordHistory>(await sysPasswordHistoryDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysPasswordHistoryManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysPasswordHistory>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysPasswordHistory>> DeleteAsync(SysPasswordHistory entity)
        {
            try
            {
                return new SuccessDataResult<SysPasswordHistory>(await sysPasswordHistoryDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysPasswordHistoryManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysPasswordHistory>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysPasswordHistory>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysPasswordHistory>(await sysPasswordHistoryDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysPasswordHistoryManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysPasswordHistory>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysPasswordHistory>> UpdateAsync(SysPasswordHistory entity)
        {
            try
            {
                return new SuccessDataResult<SysPasswordHistory>(await sysPasswordHistoryDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysPasswordHistoryManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysPasswordHistory>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
