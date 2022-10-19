using Wms.Integration.Business.Abstract;
using Wms.Integration.Business.Messages;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class AddressItemManager : IAddressItemService
    {
        private readonly IAddressItemDal addressItemDal;
        private readonly ILoggerDal loggerDal;
        public AddressItemManager(IAddressItemDal addressItem, ILoggerDal loggerDal)
        {
            this.addressItemDal = addressItem;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<AddressItem>> CreateAsync(AddressItem entity)
        {
            try
            {
                return new SuccessDataResult<AddressItem>(await addressItemDal.CreateAsync(entity), MessagingHelper.WAICreate);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "AddressItemManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<AddressItem>(null, MessagingHelper.NWAICreate);
            }
        }

        public async Task<IDataResult<AddressItem>> DeleteAsync(AddressItem entity)
        {
            try
            {
                return new SuccessDataResult<AddressItem>(await addressItemDal.DeleteAsync(entity), MessagingHelper.WAIDelete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "AddressItemManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<AddressItem>(null, MessagingHelper.NWAIDelete);
            }
        }

        public async Task<IDataResult<AddressItem>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<AddressItem>(await addressItemDal.GetAsync(s=>s.Id==id), MessagingHelper.WAIGet);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "AddressItemManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<AddressItem>(null, MessagingHelper.NWAIGet);
            }
        }
        public async Task<IDataResult<AddressItem>> UpdateAsync(AddressItem entity)
        {
            try
            {
                return new SuccessDataResult<AddressItem>(await addressItemDal.UpdateAsync(entity), MessagingHelper.WAIUpdate);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "AddressItemManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<AddressItem>(null, MessagingHelper.NWAIUpdate);
            }
        }
    }
}
