using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class PlanningSlipLineManager : IPlanningSlipLineService
    {
        private readonly IPlanningSlipLineDal planningSlipLineDal;
        private readonly ILoggerDal loggerDal;
        public PlanningSlipLineManager(IPlanningSlipLineDal planningSlipLineDal, ILoggerDal loggerDal)
        {
            this.planningSlipLineDal = planningSlipLineDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<PlanningSlipLine>> CreateAsync(PlanningSlipLine entity)
        {
            try
            {
                return new SuccessDataResult<PlanningSlipLine>(await planningSlipLineDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "PlanningSlipLineManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<PlanningSlipLine>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<PlanningSlipLine>> DeleteAsync(PlanningSlipLine entity)
        {
            try
            {
                return new SuccessDataResult<PlanningSlipLine>(await planningSlipLineDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "PlanningSlipLineManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<PlanningSlipLine>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<PlanningSlipLine>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<PlanningSlipLine>(await planningSlipLineDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "PlanningSlipLineManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<PlanningSlipLine>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<PlanningSlipLine>> UpdateAsync(PlanningSlipLine entity)
        {
            try
            {
                return new SuccessDataResult<PlanningSlipLine>(await planningSlipLineDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "PlanningSlipLineManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<PlanningSlipLine>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
