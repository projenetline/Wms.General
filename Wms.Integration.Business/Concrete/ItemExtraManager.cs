using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ItemExtraManager : IItemExtraService
    {
        private readonly IItemExtraDal itemExtraDal;
        public ItemExtraManager(IItemExtraDal itemExtraDal)
        {
            this.itemExtraDal = itemExtraDal;
        }
        public Task<IDataResult<ItemExtra>> CreateAsync(ItemExtra entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ItemExtra>> DeleteAsync(ItemExtra entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ItemExtra>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<ItemExtra>>> GetListAsync(ItemExtra entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ItemExtra>> UpdateAsync(ItemExtra entity)
        {
            throw new NotImplementedException();
        }
    }
}
