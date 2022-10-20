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
    public class SalesPersonManager : ISalesPersonService
    {
        private readonly ISalesPersonDal salesPersonDal;
        private readonly ILoggerDal loggerDal;
        public SalesPersonManager(ISalesPersonDal salesPersonDal, ILoggerDal loggerDal)
        {
            this.salesPersonDal = salesPersonDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SalesPerson>> CreateAsync(SalesPerson entity)
        {
            try
            {
                return new SuccessDataResult<SalesPerson>(await salesPersonDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SalesPersonManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SalesPerson>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SalesPerson>> DeleteAsync(SalesPerson entity)
        {
            try
            {
                return new SuccessDataResult<SalesPerson>(await salesPersonDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SalesPersonManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SalesPerson>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SalesPerson>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SalesPerson>(await salesPersonDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SalesPersonManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SalesPerson>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SalesPerson>> UpdateAsync(SalesPerson entity)
        {
            try
            {
                  return new SuccessDataResult<SalesPerson>(await salesPersonDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SalesPersonManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SalesPerson>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
