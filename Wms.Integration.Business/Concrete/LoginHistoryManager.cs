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
    public class LoginHistoryManager : ILoginHistoryService
    {
        private readonly ILoginHistoryDal loginHistoryDal;
        private readonly ILoggerDal loggerDal;  
        public LoginHistoryManager(ILoginHistoryDal loginHistoryDal, ILoggerDal loggerDal)
        {
            this.loginHistoryDal = loginHistoryDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<LoginHistory>> CreateAsync(LoginHistory entity)
        {
            try
            {
                return new SuccessDataResult<LoginHistory>(await loginHistoryDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "LoginHistoryManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<LoginHistory>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<LoginHistory>> DeleteAsync(LoginHistory entity)
        {
            try
            {
                return new SuccessDataResult<LoginHistory>(await loginHistoryDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "LoginHistoryManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<LoginHistory>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<LoginHistory>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<LoginHistory>(await loginHistoryDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "LoginHistoryManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<LoginHistory>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<LoginHistory>> UpdateAsync(LoginHistory entity)
        {
            try
            {
                return new SuccessDataResult<LoginHistory>(await loginHistoryDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "LoginHistoryManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<LoginHistory>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
