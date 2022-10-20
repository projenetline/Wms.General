using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class ItemContentManager : IItemContentService
    {
        private readonly IItemContentDal itemContentDal;
        private readonly ILoggerDal loggerDal;
        public ItemContentManager(IItemContentDal itemContentDal, ILoggerDal loggerDal)
        {
            this.itemContentDal = itemContentDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<ItemContent>> CreateAsync(ItemContent entity)
        {
            try
            {
                return new SuccessDataResult<ItemContent>(await itemContentDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemContentManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemContent>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<ItemContent>> DeleteAsync(ItemContent entity)
        {
            try
            {
                return new SuccessDataResult<ItemContent>(await itemContentDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemContentManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemContent>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<ItemContent>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<ItemContent>(await itemContentDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemContentManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemContent>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<ItemContent>> UpdateAsync(ItemContent entity)
        {
            try
            {
                return new SuccessDataResult<ItemContent>(await itemContentDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemContentManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemContent>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
