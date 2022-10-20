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
    public class ShipmentDayManager : IShipmentDayService
    {
        private readonly IShipmentDayDal shipmentDayDal;
        private readonly ILoggerDal loggerDal;
        public ShipmentDayManager(IShipmentDayDal shipmentDayDal, ILoggerDal loggerDal)
        {
            this.shipmentDayDal = shipmentDayDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<ShipmentDay>> CreateAsync(ShipmentDay entity)
        {
            try
            {
                return new SuccessDataResult<ShipmentDay>(await shipmentDayDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShipmentDayManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ShipmentDay>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<ShipmentDay>> DeleteAsync(ShipmentDay entity)
        {
            try
            {
                return new SuccessDataResult<ShipmentDay>(await shipmentDayDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShipmentDayManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ShipmentDay>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<ShipmentDay>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<ShipmentDay>(await shipmentDayDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShipmentDayManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ShipmentDay>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<ShipmentDay>> UpdateAsync(ShipmentDay entity)
        {
            try
            {
                return new SuccessDataResult<ShipmentDay>(await shipmentDayDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShipmentDayManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ShipmentDay>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
