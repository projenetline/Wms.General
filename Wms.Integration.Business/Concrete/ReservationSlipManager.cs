using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ReservationSlipManager : IReservationSlipService
    {
        private readonly IReservationSlipDal reservationSlipDal;
        public ReservationSlipManager(IReservationSlipDal reservationSlipDal)
        {
           this.reservationSlipDal = reservationSlipDal;
        }
        public Task<IDataResult<ReservationSlip>> CreateAsync(ReservationSlip entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ReservationSlip>> DeleteAsync(ReservationSlip entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ReservationSlip>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<ReservationSlip>>> GetListAsync(ReservationSlip entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PagedResult<ReservationSlip>>> GetPagedListAsync(ReservationSlip entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ReservationSlip>> UpdateAsync(ReservationSlip entity)
        {
            throw new NotImplementedException();
        }
    }
}
