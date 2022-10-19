using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ItemContentManager : IItemContentService
    {
        private readonly IItemContentDal itemContentDal;
        public ItemContentManager(IItemContentDal itemContentDal)
        {
            this.itemContentDal = itemContentDal;
        }
        public Task<IDataResult<ItemContent>> CreateAsync(ItemContent entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ItemContent>> DeleteAsync(ItemContent entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ItemContent>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<IList<ItemContent>>> GetListAsync(ItemContent entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ItemContent>> UpdateAsync(ItemContent entity)
        {
            throw new NotImplementedException();
        }
    }
}
