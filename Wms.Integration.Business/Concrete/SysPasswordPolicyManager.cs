using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysPasswordPolicyManager : ISysPasswordPolicyService
    {
        private readonly ISysPasswordPolicyDal sysPasswordPolicyDal;
        private readonly ILoggerDal loggerDal;
        public SysPasswordPolicyManager(ISysPasswordPolicyDal sysPasswordPolicyDal, ILoggerDal loggerDal)
        {
            this.sysPasswordPolicyDal = sysPasswordPolicyDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysPasswordPolicy>> CreateAsync(SysPasswordPolicy entity)
        {
            try
            {
                return new SuccessDataResult<SysPasswordPolicy>(await sysPasswordPolicyDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysPasswordPolicyManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysPasswordPolicy>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysPasswordPolicy>> DeleteAsync(SysPasswordPolicy entity)
        {
            try
            {
                return new SuccessDataResult<SysPasswordPolicy>(await sysPasswordPolicyDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysPasswordPolicyManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysPasswordPolicy>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysPasswordPolicy>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysPasswordPolicy>(await sysPasswordPolicyDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysPasswordPolicyManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysPasswordPolicy>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysPasswordPolicy>> UpdateAsync(SysPasswordPolicy entity)
        {
            try
            {
                return new SuccessDataResult<SysPasswordPolicy>(await sysPasswordPolicyDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysPasswordPolicyManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysPasswordPolicy>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
