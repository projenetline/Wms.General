using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class WorkOrderManager : IWorkOrderService
    {
        private readonly IWorkOrderDal workOrderDal;
        public WorkOrderManager(IWorkOrderDal workOrderDal)
        {
            this.workOrderDal = workOrderDal;
        }
        public Task<IDataResult<WorkOrder>> CreateAsync(WorkOrder entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<WorkOrder>> DeleteAsync(WorkOrder entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<WorkOrder>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<WorkOrder>> UpdateAsync(WorkOrder entity)
        {
            throw new NotImplementedException();
        }
    }
}
