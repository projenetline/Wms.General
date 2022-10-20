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
    public class ItemParameterManager : IItemParameterService
    {
        private readonly IItemParameterDal itemParameterDal;
        private readonly ILoggerDal loggerDal;
        public ItemParameterManager(IItemParameterDal itemParameterDal, ILoggerDal loggerDal)
        {
            this.itemParameterDal = itemParameterDal;
            this.loggerDal = loggerDal;
        }
        public  async Task<IDataResult<ItemParameter>> CreateAsync(ItemParameter entity)
        {
            try
            {
                return new SuccessDataResult<ItemParameter>(await itemParameterDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemParameterManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemParameter>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<ItemParameter>> DeleteAsync(ItemParameter entity)
        {
            try
            {
                return new SuccessDataResult<ItemParameter>(await itemParameterDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemParameterManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemParameter>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<ItemParameter>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<ItemParameter>(await itemParameterDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemParameterManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemParameter>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<ItemParameter>> UpdateAsync(ItemParameter entity)
        {
            try
            {
                return new SuccessDataResult<ItemParameter>(await itemParameterDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ItemParameterManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ItemParameter>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
