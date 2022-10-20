using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysCustomRuleActionManager : ISysCustomRuleActionService
    {
        private readonly ISysCustomRuleActionDal sysCustomRuleActionDal;
        private readonly ILoggerDal loggerDal;
        public SysCustomRuleActionManager(ISysCustomRuleActionDal sysCustomRuleActionDal, ILoggerDal loggerDal)
        {
            this.sysCustomRuleActionDal = sysCustomRuleActionDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<SysCustomRuleAction>> CreateAsync(SysCustomRuleAction entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomRuleAction>(await sysCustomRuleActionDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
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
                return new ErrorDataResult<SysCustomRuleAction>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<SysCustomRuleAction>> DeleteAsync(SysCustomRuleAction entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomRuleAction>(await sysCustomRuleActionDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomRuleActionManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomRuleAction>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<SysCustomRuleAction>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysCustomRuleAction>(await sysCustomRuleActionDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomRuleActionManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomRuleAction>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public Task<IDataResult<SysCustomRuleAction>> UpdateAsync(SysCustomRuleAction entity)
        {
            throw new NotImplementedException();
        }
    }
}
