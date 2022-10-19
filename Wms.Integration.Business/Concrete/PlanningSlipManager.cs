using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class PlanningSlipManager : IPlanningSlipService
    {
        private readonly IPlanningSlipDal planningSlipDal;
        public PlanningSlipManager(IPlanningSlipDal planningSlipDal)
        {
            this.planningSlipDal = planningSlipDal;
        }
        public Task<IDataResult<PlanningSlip>> CreateAsync(PlanningSlip entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PlanningSlip>> DeleteAsync(PlanningSlip entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PlanningSlip>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PlanningSlip>> UpdateAsync(PlanningSlip entity)
        {
            throw new NotImplementedException();
        }
    }
}
