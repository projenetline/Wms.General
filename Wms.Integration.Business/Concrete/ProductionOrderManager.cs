using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class ProductionOrderManager : IProductionOrderService
    {
        private readonly IProductionOrderDal productionOrderDal;
        private readonly ILoggerDal loggerDal;
        public ProductionOrderManager(IProductionOrderDal productionOrderDal, ILoggerDal loggerDal)
        {
            this.productionOrderDal = productionOrderDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<ProductionOrder>> CreateAsync(ProductionOrder entity)
        {
            try
            {
                return new SuccessDataResult<ProductionOrder>(await productionOrderDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ProductionOrderManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ProductionOrder>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<ProductionOrder>> DeleteAsync(ProductionOrder entity)
        {
            try
            {
                return new SuccessDataResult<ProductionOrder>(await productionOrderDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ProductionOrderManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ProductionOrder>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<ProductionOrder>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<ProductionOrder>(await productionOrderDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ProductionOrderManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ProductionOrder>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<ProductionOrder>> UpdateAsync(ProductionOrder entity)
        {
            try
            {
                return new SuccessDataResult<ProductionOrder>(await productionOrderDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ProductionOrderManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ProductionOrder>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
