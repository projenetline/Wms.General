using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class CarrierManager:ICarrierService
    {
        private readonly ICarrierDal carrierDal;
        private readonly ILoggerDal loggerDal;
        public CarrierManager(ICarrierDal carrierDal, ILoggerDal loggerDal)
        {
            this.carrierDal = carrierDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<Carrier>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<Carrier>(await carrierDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "CarrierManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Carrier>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<Carrier>> CreateAsync(Carrier entity)
        {
            try
            {
                return new SuccessDataResult<Carrier>(await carrierDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "CarrierManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Carrier>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<Carrier>> UpdateAsync(Carrier entity)
        {
            try
            {
                return new SuccessDataResult<Carrier>(await carrierDal.UpdateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "CarrierManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Carrier>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<Carrier>> DeleteAsync(Carrier entity)
        {
            try
            {
                return new SuccessDataResult<Carrier>(await carrierDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "CarrierManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Carrier>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
    }
}
