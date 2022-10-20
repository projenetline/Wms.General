using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class ReservationSlipManager : IReservationSlipService
    {
        private readonly IReservationSlipDal reservationSlipDal;
        private readonly ILoggerDal loggerDal;
        public ReservationSlipManager(IReservationSlipDal reservationSlipDal, ILoggerDal loggerDal)
        {
            this.reservationSlipDal = reservationSlipDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<ReservationSlip>> CreateAsync(ReservationSlip entity)
        {
            try
            {
                return new SuccessDataResult<ReservationSlip>(await reservationSlipDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ReservationSlipManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ReservationSlip>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<ReservationSlip>> DeleteAsync(ReservationSlip entity)
        {
            try
            {
                return new SuccessDataResult<ReservationSlip>(await reservationSlipDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ReservationSlipManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ReservationSlip>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<ReservationSlip>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<ReservationSlip>(await reservationSlipDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ReservationSlipManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ReservationSlip>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<ReservationSlip>> UpdateAsync(ReservationSlip entity)
        {
            try
            {
                return new SuccessDataResult<ReservationSlip>(await reservationSlipDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ReservationSlipManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ReservationSlip>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
