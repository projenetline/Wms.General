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
    public class VehicleManager : IVehicleService
    {
        private readonly IVehicleDal vehicleDal;
        private readonly ILoggerDal loggerDal;
        public VehicleManager(IVehicleDal vehicleDal,ILoggerDal loggerDal)
        {
            this.loggerDal = loggerDal;
            this.vehicleDal = vehicleDal;
        }

        public async Task<IDataResult<Vehicle>> CreateAsync(Vehicle entity)
        {
            try
            {
                return new SuccessDataResult<Vehicle>(await vehicleDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "VehicleManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Vehicle>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<Vehicle>> DeleteAsync(Vehicle entity)
        {
            try
            {
                return new SuccessDataResult<Vehicle>(await vehicleDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "VehicleManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Vehicle>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<Vehicle>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<Vehicle>(await vehicleDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "VehicleManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Vehicle>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<Vehicle>> UpdateAsync(Vehicle entity)
        {
            try
            {
                return new SuccessDataResult<Vehicle>(await vehicleDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "VehicleManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Vehicle>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
