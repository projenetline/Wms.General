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
    public class SysAuthCodeManager : ISysAuthCodeService
    {
        private readonly ISysAuthCodeDal sysAuthCodeDal;
        private readonly ILoggerDal loggerDal;  
        public SysAuthCodeManager(ISysAuthCodeDal sysAuthCodeDal, ILoggerDal loggerDal)
        {
            this.sysAuthCodeDal = sysAuthCodeDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysAuthCode>> CreateAsync(SysAuthCode entity)
        {
            try
            {
                return new SuccessDataResult<SysAuthCode>(await sysAuthCodeDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysAuthCodeManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysAuthCode>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysAuthCode>> DeleteAsync(SysAuthCode entity)
        {
            try
            {
                return new SuccessDataResult<SysAuthCode>(await sysAuthCodeDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysAuthCodeManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysAuthCode>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysAuthCode>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysAuthCode>(await sysAuthCodeDal.GetAsync(S=>S.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysAuthCodeManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysAuthCode>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysAuthCode>> UpdateAsync(SysAuthCode entity)
        {
            try
            {
                return new SuccessDataResult<SysAuthCode>(await sysAuthCodeDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysAuthCodeManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysAuthCode>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
