using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ItemManager : IItemService
    {
        private readonly IItemDal itemDal;
        public ItemManager(IItemDal itemDal)
        {
            this.itemDal = itemDal;
        }
        public Task<IDataResult<Item>> CreateAsync(Item entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<Item>> DeleteAsync(Item entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<Item>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<IList<Item>>> GetListAsync(Item entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Item>> UpdateAsync(Item entity)
        {
            throw new NotImplementedException();
        }
    }
}
