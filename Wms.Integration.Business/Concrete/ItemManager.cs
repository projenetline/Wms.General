using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class ItemManager : IItemService
    {
        private readonly IItemDal itemDal;
        private readonly ILoggerDal loggerDal;
        public ItemManager(IItemDal itemDal, ILoggerDal loggerDal)
        {
            this.itemDal = itemDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<Item>> CreateAsync(Item entity)
        {
            try
            {
                return new SuccessDataResult<Item>(await itemDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Item>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<Item>> DeleteAsync(Item entity)
        {
            try
            {
                return new SuccessDataResult<Item>(await itemDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Item>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<Item>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<Item>(await itemDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Item>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<Item>> UpdateAsync(Item entity)
        {
            try
            {
                return new SuccessDataResult<Item>(await itemDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Item>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
