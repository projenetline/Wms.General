using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ShiftPeriodManager : IShiftPeriodService
    {
        private readonly IShiftPeriodDal shiftPeriodDal;
        public ShiftPeriodManager(IShiftPeriodDal shiftPeriodDal)
        {
            this.shiftPeriodDal = shiftPeriodDal;
        }
        public Task<IDataResult<ShiftPeriod>> CreateAsync(ShiftPeriod entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ShiftPeriod>> DeleteAsync(ShiftPeriod entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ShiftPeriod>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ShiftPeriod>> UpdateAsync(ShiftPeriod entity)
        {
            throw new NotImplementedException();
        }
    }
}
