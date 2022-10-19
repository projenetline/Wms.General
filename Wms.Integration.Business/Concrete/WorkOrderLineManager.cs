using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class WorkOrderLineManager : IWorkOrderLineService
    {
        private readonly IWorkOrderLineDal workOrderLineDal;
        public WorkOrderLineManager(IWorkOrderLineDal workOrderLineDal)
        {
            this.workOrderLineDal = workOrderLineDal;
        }

        public Task<IDataResult<WorkOrderLine>> CreateAsync(WorkOrderLine entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<WorkOrderLine>> DeleteAsync(WorkOrderLine entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<WorkOrderLine>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<WorkOrderLine>> UpdateAsync(WorkOrderLine entity)
        {
            throw new NotImplementedException();
        }
    }
}
