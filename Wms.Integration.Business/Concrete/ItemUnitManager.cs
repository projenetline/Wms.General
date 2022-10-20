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
    public class ItemUnitManager : IItemUnitService
    {
        private readonly IItemUnitDal itemUnitDal;
        private readonly ILoggerDal loggerDal;
        public ItemUnitManager(IItemUnitDal itemUnitDal, ILoggerDal loggerDal)
        {
            this.itemUnitDal = itemUnitDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<ItemUnit>> CreateAsync(ItemUnit entity)
        {
            try
            {
                return new SuccessDataResult<ItemUnit>(await itemUnitDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemUnitManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemUnit>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<ItemUnit>> DeleteAsync(ItemUnit entity)
        {
            try
            {
                return new SuccessDataResult<ItemUnit>(await itemUnitDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemUnitManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemUnit>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<ItemUnit>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<ItemUnit>(await itemUnitDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemUnitManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemUnit>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<ItemUnit>> UpdateAsync(ItemUnit entity)
        {
            try
            {
                return new SuccessDataResult<ItemUnit>(await itemUnitDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemUnitManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemUnit>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
