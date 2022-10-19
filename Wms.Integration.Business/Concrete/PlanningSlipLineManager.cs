using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class PlanningSlipLineManager : IPlanningSlipLineService
    {
        private readonly IPlanningSlipLineDal planningSlipLineDal;
        public PlanningSlipLineManager(IPlanningSlipLineDal planningSlipLineDal)
        {
            this.planningSlipLineDal = planningSlipLineDal;
        }

        public Task<IDataResult<PlanningSlipLine>> CreateAsync(PlanningSlipLine entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PlanningSlipLine>> DeleteAsync(PlanningSlipLine entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PlanningSlipLine>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PlanningSlipLine>> UpdateAsync(PlanningSlipLine entity)
        {
            throw new NotImplementedException();
        }
    }
}
