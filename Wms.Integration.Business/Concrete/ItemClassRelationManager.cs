using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class ItemClassRelationManager : IItemClassRelationService
    {
        private readonly IItemClassRelationDal itemClassRelationDal;
        private readonly ILoggerDal loggerDal;
        public ItemClassRelationManager(IItemClassRelationDal itemClassRelationDal, ILoggerDal loggerDal)
        {
            this.itemClassRelationDal = itemClassRelationDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<ItemClassRelation>> CreateAsync(ItemClassRelation entity)
        {
            try
            {
                return new SuccessDataResult<ItemClassRelation>(await itemClassRelationDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemClassRelationManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemClassRelation>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<ItemClassRelation>> DeleteAsync(ItemClassRelation entity)
        {
            try
            {
                return new SuccessDataResult<ItemClassRelation>(await itemClassRelationDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemClassRelationManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemClassRelation>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<ItemClassRelation>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<ItemClassRelation>(await itemClassRelationDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemClassRelationManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemClassRelation>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<ItemClassRelation>> UpdateAsync(ItemClassRelation entity)
        {
            try
            {
                return new SuccessDataResult<ItemClassRelation>(await itemClassRelationDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemClassRelationManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemClassRelation>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
