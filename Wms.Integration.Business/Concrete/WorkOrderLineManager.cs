using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class WorkOrderLineManager : IWorkOrderLineService
    {
        private readonly IWorkOrderLineDal workOrderLineDal;
        private readonly ILoggerDal loggerDal;
        public WorkOrderLineManager(IWorkOrderLineDal workOrderLineDal, ILoggerDal loggerDal)
        {
            this.workOrderLineDal = workOrderLineDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<WorkOrderLine>> CreateAsync(WorkOrderLine entity)
        {
            try
            {
                return new SuccessDataResult<WorkOrderLine>(await workOrderLineDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "WorkOrderLineManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<WorkOrderLine>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<WorkOrderLine>> DeleteAsync(WorkOrderLine entity)
        {
            try
            {
                return new SuccessDataResult<WorkOrderLine>(await workOrderLineDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "WorkOrderLineManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<WorkOrderLine>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<WorkOrderLine>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<WorkOrderLine>(await workOrderLineDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "WorkOrderLineManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<WorkOrderLine>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<WorkOrderLine>> UpdateAsync(WorkOrderLine entity)
        {
            try
            {
                return new SuccessDataResult<WorkOrderLine>(await workOrderLineDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "WorkOrderLineManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<WorkOrderLine>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
