using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class OrderSlipLineManager : IOrderSlipLineService
    {
        private readonly IOrderSlipLineDal orderSlipLineDal;
        public OrderSlipLineManager(IOrderSlipLineDal orderSlipLineDal)
        {
            this.orderSlipLineDal = orderSlipLineDal;
        }

        public Task<IDataResult<OrderSlipLine>> CreateAsync(OrderSlipLine entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<OrderSlipLine>> DeleteAsync(OrderSlipLine entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<OrderSlipLine>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<OrderSlipLine>> UpdateAsync(OrderSlipLine entity)
        {
            throw new NotImplementedException();
        }
    }
}
