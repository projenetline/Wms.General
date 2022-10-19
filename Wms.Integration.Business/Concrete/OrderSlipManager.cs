using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class OrderSlipManager : IOrderSlipService
    {
        private readonly IOrderSlipService _orderSlipService;
        public OrderSlipManager(IOrderSlipService orderSlipService)
        {
            _orderSlipService = orderSlipService;
        }
        public Task<IDataResult<OrderSlip>> CreateAsync(OrderSlip entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<OrderSlip>> DeleteAsync(OrderSlip entity)
        {
            throw new NotImplementedException();
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
