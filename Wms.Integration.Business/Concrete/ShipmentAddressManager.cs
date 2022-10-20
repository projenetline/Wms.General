using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class ShipmentAddressManager : IShipmentAddressService
    {
        private readonly IShipmentAddressDal shipmentAddressDal;
        private readonly ILoggerDal loggerDal;
        public ShipmentAddressManager(IShipmentAddressDal shipmentAddressDal, ILoggerDal loggerDal)
        {
            this.shipmentAddressDal = shipmentAddressDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<ShipmentAddress>> CreateAsync(ShipmentAddress entity)
        {
            try
            {
                return new SuccessDataResult<ShipmentAddress>(await shipmentAddressDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShipmentAddressManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ShipmentAddress>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<ShipmentAddress>> DeleteAsync(ShipmentAddress entity)
        {
            try
            {
                return new SuccessDataResult<ShipmentAddress>(await shipmentAddressDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShipmentAddressManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ShipmentAddress>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<ShipmentAddress>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<ShipmentAddress>(await shipmentAddressDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShipmentAddressManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ShipmentAddress>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<ShipmentAddress>> UpdateAsync(ShipmentAddress entity)
        {
            try
            {
                return new SuccessDataResult<ShipmentAddress>(await shipmentAddressDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ShipmentAddressManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ShipmentAddress>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
