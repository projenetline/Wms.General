using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class ItemExtraManager : IItemExtraService
    {
        private readonly IItemExtraDal itemExtraDal;
        private readonly ILoggerDal loggerDal;  
        public ItemExtraManager(IItemExtraDal itemExtraDal, ILoggerDal loggerDal)
        {
            this.itemExtraDal = itemExtraDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<ItemExtra>> CreateAsync(ItemExtra entity)
        {
            try
            {
                return new SuccessDataResult<ItemExtra>(await itemExtraDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemExtraManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemExtra>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<ItemExtra>> DeleteAsync(ItemExtra entity)
        {
            try
            {
                return new SuccessDataResult<ItemExtra>(await itemExtraDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemExtraManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemExtra>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<ItemExtra>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<ItemExtra>(await itemExtraDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemExtraManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemExtra>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<ItemExtra>> UpdateAsync(ItemExtra entity)
        {
            try
            {
                return new SuccessDataResult<ItemExtra>(await itemExtraDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemExtraManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemExtra>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
