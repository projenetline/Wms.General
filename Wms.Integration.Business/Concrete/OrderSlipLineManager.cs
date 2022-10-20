using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class OrderSlipLineManager : IOrderSlipLineService
    {
        private readonly IOrderSlipLineDal orderSlipLineDal;
        private readonly ILoggerDal loggerDal;
        public OrderSlipLineManager(IOrderSlipLineDal orderSlipLineDal, ILoggerDal loggerDal)
        {
            this.orderSlipLineDal = orderSlipLineDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<OrderSlipLine>> CreateAsync(OrderSlipLine entity)
        {
            try
            {
                return new SuccessDataResult<OrderSlipLine>(await orderSlipLineDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "OrderSlipLineManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<OrderSlipLine>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<OrderSlipLine>> DeleteAsync(OrderSlipLine entity)
        {
            try
            {
                return new SuccessDataResult<OrderSlipLine>(await orderSlipLineDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "OrderSlipLineManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<OrderSlipLine>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<OrderSlipLine>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<OrderSlipLine>(await orderSlipLineDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "OrderSlipLineManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<OrderSlipLine>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<OrderSlipLine>> UpdateAsync(OrderSlipLine entity)
        {
            try
            {
                return new SuccessDataResult<OrderSlipLine>(await orderSlipLineDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "OrderSlipLineManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<OrderSlipLine>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
