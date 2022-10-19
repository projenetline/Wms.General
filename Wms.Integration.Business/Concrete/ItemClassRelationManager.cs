using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ItemClassRelationManager : IItemClassRelationService
    {
        private readonly IItemClassRelationDal _itemClassRelationDal;
        public ItemClassRelationManager(IItemClassRelationDal itemClassRelationDal)
        {
            _itemClassRelationDal = itemClassRelationDal;
        }
        public Task<IDataResult<ItemClassRelation>> CreateAsync(ItemClassRelation entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ItemClassRelation>> DeleteAsync(ItemClassRelation entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ItemClassRelation>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<IList<ItemClassRelation>>> GetListAsync(ItemClassRelation entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<ItemClassRelation>> UpdateAsync(ItemClassRelation entity)
        {
            throw new NotImplementedException();
        }
    }
}
