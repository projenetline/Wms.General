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
    public class WorkOrderManager : IWorkOrderService
    {
        private readonly IWorkOrderDal workOrderDal;
        private readonly ILoggerDal loggerDal;
        public WorkOrderManager(IWorkOrderDal workOrderDal, ILoggerDal loggerDal)
        {
            this.workOrderDal = workOrderDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<WorkOrder>> CreateAsync(WorkOrder entity)
        {
            try
            {
                return new SuccessDataResult<WorkOrder>(await workOrderDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "WorkOrderManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<WorkOrder>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<WorkOrder>> DeleteAsync(WorkOrder entity)
        {
            try
            {
                return new SuccessDataResult<WorkOrder>(await workOrderDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "WorkOrderManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<WorkOrder>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<WorkOrder>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<WorkOrder>(await workOrderDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "WorkOrderManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<WorkOrder>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<WorkOrder>> UpdateAsync(WorkOrder entity)
        {
            try
            {
                return new SuccessDataResult<WorkOrder>(await workOrderDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "WorkOrderManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<WorkOrder>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
