using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class OrderSlipManager : IOrderSlipService
    {
        private readonly IOrderSlipDal orderSlipDal;
        private readonly ILoggerDal loggerDal;
        public OrderSlipManager(IOrderSlipDal orderSlipDal, ILoggerDal loggerDal)
        {
            this.orderSlipDal = orderSlipDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<OrderSlip>> CreateAsync(OrderSlip entity)
        {
            try
            {
                return new SuccessDataResult<OrderSlip>(await orderSlipDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "OrderSlipManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<OrderSlip>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<OrderSlip>> DeleteAsync(OrderSlip entity)
        {
            try
            {
                return new SuccessDataResult<OrderSlip>(await orderSlipDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "OrderSlipManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<OrderSlip>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public Task<IDataResult<OrderSlip>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<OrderSlip>> UpdateAsync(OrderSlip entity)
        {
            throw new NotImplementedException();
        }
    }
}
