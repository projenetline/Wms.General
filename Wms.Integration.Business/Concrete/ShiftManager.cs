using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class ShiftManager : IShiftService
    {
        private readonly IShiftDal shiftDal;
        private readonly ILoggerDal loggerDal;
        public ShiftManager(IShiftDal shiftDal, ILoggerDal loggerDal)
        {
            this.shiftDal = shiftDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<Shift>> CreateAsync(Shift entity)
        {
            try
            {
                return new SuccessDataResult<Shift>(await shiftDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShiftManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Shift>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<Shift>> DeleteAsync(Shift entity)
        {
            try
            {
                return new SuccessDataResult<Shift>(await shiftDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShiftManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Shift>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<Shift>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<Shift>(await shiftDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShiftManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Shift>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<Shift>> UpdateAsync(Shift entity)
        {
            try
            {
                return new SuccessDataResult<Shift>(await shiftDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShiftManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Shift>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
