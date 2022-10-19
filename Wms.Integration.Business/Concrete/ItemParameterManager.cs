using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ItemParameterManager : IItemParameterService
    {
        private readonly IItemParameterDal itemParameterDal;
        public ItemParameterManager(IItemParameterDal itemParameterDal)
        {
            this.itemParameterDal = itemParameterDal;
        }
        public Task<IDataResult<ItemParameter>> CreateAsync(ItemParameter entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ItemParameter>> DeleteAsync(ItemParameter entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ItemParameter>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<ItemParameter>>> GetListAsync(ItemParameter entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ItemParameter>> UpdateAsync(ItemParameter entity)
        {
            throw new NotImplementedException();
        }
    }
}
