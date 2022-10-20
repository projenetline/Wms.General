using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class DriverManager : IDriverService
    {
        private readonly IDriverDal driverDal;
        private readonly ILoggerDal loggerDal;
        public DriverManager(IDriverDal driverDal, ILoggerDal loggerDal)
        {
            this.driverDal = driverDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<Driver>> CreateAsync(Driver entity)
        {
            try
            {
                return new SuccessDataResult<Driver>(await driverDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DriverManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Driver>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<Driver>> DeleteAsync(Driver entity)
        {
            try
            {
                return new SuccessDataResult<Driver>(await driverDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DriverManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Driver>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<Driver>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<Driver>(await driverDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DriverManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Driver>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<Driver>> UpdateAsync(Driver entity)
        {
            try
            {
                return new SuccessDataResult<Driver>(await driverDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DriverManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Driver>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
