using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class ReservationSlipLineManager : IReservationSlipLineService
    {
        private readonly IReservationSlipLineDal reservationSlipLineDal;
        private readonly ILoggerDal loggerDal;
        public ReservationSlipLineManager(IReservationSlipLineDal reservationSlipLineDal, ILoggerDal loggerDal)
        {
            this.reservationSlipLineDal = reservationSlipLineDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<ReservationSlipLine>> CreateAsync(ReservationSlipLine entity)
        {
            try
            {
                return new SuccessDataResult<ReservationSlipLine>(await reservationSlipLineDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ReservationSlipLineManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ReservationSlipLine>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<ReservationSlipLine>> DeleteAsync(ReservationSlipLine entity)
        {
            try
            {
                return new SuccessDataResult<ReservationSlipLine>(await reservationSlipLineDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ReservationSlipLineManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ReservationSlipLine>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<ReservationSlipLine>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<ReservationSlipLine>(await reservationSlipLineDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ReservationSlipLineManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ReservationSlipLine>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<ReservationSlipLine>> UpdateAsync(ReservationSlipLine entity)
        {
            try
            {
                return new SuccessDataResult<ReservationSlipLine>(await reservationSlipLineDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ReservationSlipLineManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ReservationSlipLine>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
