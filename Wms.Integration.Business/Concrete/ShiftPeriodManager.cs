using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class ShiftPeriodManager : IShiftPeriodService
    {
        private readonly IShiftPeriodDal shiftPeriodDal;
        private readonly ILoggerDal loggerDal;
        public ShiftPeriodManager(IShiftPeriodDal shiftPeriodDal, ILoggerDal loggerDal)
        {
            this.shiftPeriodDal = shiftPeriodDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<ShiftPeriod>> CreateAsync(ShiftPeriod entity)
        {
            try
            {
                return new SuccessDataResult<ShiftPeriod>(await shiftPeriodDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShiftPeriodManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ShiftPeriod>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<ShiftPeriod>> DeleteAsync(ShiftPeriod entity)
        {
            try
            {
                return new SuccessDataResult<ShiftPeriod>(await shiftPeriodDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShiftPeriodManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ShiftPeriod>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<ShiftPeriod>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<ShiftPeriod>(await shiftPeriodDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShiftPeriodManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ShiftPeriod>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<ShiftPeriod>> UpdateAsync(ShiftPeriod entity)
        {
            try
            {
                return new SuccessDataResult<ShiftPeriod>(await shiftPeriodDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShiftPeriodManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ShiftPeriod>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
