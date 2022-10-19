using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ShiftManager : IShiftService
    {
        private readonly IShiftDal shiftDal;
        public ShiftManager(IShiftDal shiftDal)
        {
            this.shiftDal = shiftDal;
        }

        public Task<IDataResult<Shift>> CreateAsync(Shift entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Shift>> DeleteAsync(Shift entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Shift>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Shift>> UpdateAsync(Shift entity)
        {
            throw new NotImplementedException();
        }
    }
}
