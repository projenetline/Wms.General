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
    public class PlanningSlipManager : IPlanningSlipService
    {
        private readonly IPlanningSlipDal planningSlipDal;
        private readonly ILoggerDal loggerDal;
        public PlanningSlipManager(IPlanningSlipDal planningSlipDal, ILoggerDal loggerDal)
        {
            this.planningSlipDal = planningSlipDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<PlanningSlip>> CreateAsync(PlanningSlip entity)
        {
            try
            {
                return new SuccessDataResult<PlanningSlip>(await planningSlipDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "PlanningSlipManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<PlanningSlip>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<PlanningSlip>> DeleteAsync(PlanningSlip entity)
        {
            try
            {
                return new SuccessDataResult<PlanningSlip>(await planningSlipDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "PlanningSlipManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<PlanningSlip>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<PlanningSlip>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<PlanningSlip>(await planningSlipDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "PlanningSlipManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<PlanningSlip>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<PlanningSlip>> UpdateAsync(PlanningSlip entity)
        {
            try
            {
                return new SuccessDataResult<PlanningSlip>(await planningSlipDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "PlanningSlipManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<PlanningSlip>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
