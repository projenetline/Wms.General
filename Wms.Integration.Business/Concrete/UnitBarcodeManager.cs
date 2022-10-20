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
    public class UnitBarcodeManager : IUnitBarcodeService
    {
        private readonly IUnitBarcodeDal unitBarcodeDal;
        private readonly ILoggerDal loggerDal;
        public UnitBarcodeManager(IUnitBarcodeDal unitBarcodeDal, ILoggerDal loggerDal)
        {
            this.unitBarcodeDal = unitBarcodeDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<UnitBarcode>> CreateAsync(UnitBarcode entity)
        {
            try
            {
                return new SuccessDataResult<UnitBarcode>(await unitBarcodeDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "UnitBarcodeManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<UnitBarcode>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<UnitBarcode>> DeleteAsync(UnitBarcode entity)
        {
            try
            {
                return new SuccessDataResult<UnitBarcode>(await unitBarcodeDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "UnitBarcodeManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<UnitBarcode>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<UnitBarcode>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<UnitBarcode>(await unitBarcodeDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "UnitBarcodeManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<UnitBarcode>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<UnitBarcode>> UpdateAsync(UnitBarcode entity)
        {
            try
            {
                return new SuccessDataResult<UnitBarcode>(await unitBarcodeDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "UnitBarcodeManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<UnitBarcode>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
