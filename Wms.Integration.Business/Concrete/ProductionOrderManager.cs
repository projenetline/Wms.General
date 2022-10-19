using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ProductionOrderManager : IProductionOrderService
    {
        private readonly IProductionOrderDal productionOrderDal;
        public ProductionOrderManager(IProductionOrderDal productionOrderDal)
        {
            this.productionOrderDal = productionOrderDal;
        }
        public Task<IDataResult<ProductionOrder>> CreateAsync(ProductionOrder entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ProductionOrder>> DeleteAsync(ProductionOrder entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ProductionOrder>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<IList<ProductionOrder>>> GetListAsync(ProductionOrder entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<PagedResult<ProductionOrder>>> GetPagedListAsync(ProductionOrder entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ProductionOrder>> UpdateAsync(ProductionOrder entity)
        {
            throw new NotImplementedException();
        }
    }
}
