using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysCustomRuleManager : ISysCustomRuleService
    {
        private readonly ISysCustomRuleDal sysCustomRuleDal;
        private readonly ILoggerDal loggerDal;  
        public SysCustomRuleManager(ISysCustomRuleDal sysCustomRuleDal,ILoggerDal loggerDal)
        {
            this.loggerDal = loggerDal;
            this.sysCustomRuleDal = sysCustomRuleDal;
        }
        public async Task<IDataResult<SysCustomRule>> CreateAsync(SysCustomRule entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomRule>(await sysCustomRuleDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomRuleManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomRule>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysCustomRule>> DeleteAsync(SysCustomRule entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomRule>(await sysCustomRuleDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomRuleManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomRule>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysCustomRule>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysCustomRule>(await sysCustomRuleDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomRuleManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomRule>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysCustomRule>> UpdateAsync(SysCustomRule entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomRule>(await sysCustomRuleDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomRuleManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomRule>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
