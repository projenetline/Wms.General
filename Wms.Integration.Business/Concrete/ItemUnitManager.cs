using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ItemUnitManager : IItemUnitService
    {
        private readonly IItemUnitService _itemUnitService;
        public ItemUnitManager(IItemUnitService itemUnitService)
        {
            _itemUnitService = itemUnitService;
        }
        public Task<IDataResult<ItemUnit>> CreateAsync(ItemUnit entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ItemUnit>> DeleteAsync(ItemUnit entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ItemUnit>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<ItemUnit>>> GetListAsync(ItemUnit entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PagedResult<ItemUnit>>> GetPagedListAsync(ItemUnit entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<ItemUnit>> UpdateAsync(ItemUnit entity)
        {
            throw new NotImplementedException();
        }
    }
}
