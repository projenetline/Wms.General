using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ReservationSlipLineManager : IReservationSlipLineService
    {
        private readonly IReservationSlipLineDal reservationSlipLineDal;
        public ReservationSlipLineManager(IReservationSlipLineDal reservationSlipLineDal)
        {
            this.reservationSlipLineDal = reservationSlipLineDal;
        }
        public Task<IDataResult<ReservationSlipLine>> CreateAsync(ReservationSlipLine entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ReservationSlipLine>> DeleteAsync(ReservationSlipLine entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ReservationSlipLine>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<IList<ReservationSlipLine>>> GetListAsync(ReservationSlipLine entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<PagedResult<ReservationSlipLine>>> GetPagedListAsync(ReservationSlipLine entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ReservationSlipLine>> UpdateAsync(ReservationSlipLine entity)
        {
            throw new NotImplementedException();
        }
    }
}
