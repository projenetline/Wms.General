using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysAddressManager : ISysAddressService
    {
        private readonly ISysAddressDal sysAddressDal;
        private readonly ILoggerDal loggerDal;  
        public SysAddressManager(ISysAddressDal sysAddressDal, ILoggerDal loggerDal)
        {
            this.sysAddressDal = sysAddressDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<SysAddress>> CreateAsync(SysAddress entity)
        {
            try
            {
                return new SuccessDataResult<SysAddress>(await sysAddressDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysAddressManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysAddress>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysAddress>> DeleteAsync(SysAddress entity)
        {
            try
            {
                return new SuccessDataResult<SysAddress>(await sysAddressDal.CreateAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysAddressManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysAddress>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysAddress>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysAddress>(await sysAddressDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysAddressManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysAddress>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysAddress>> UpdateAsync(SysAddress entity)
        {
            try
            {
                return new SuccessDataResult<SysAddress>(await sysAddressDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysAddressManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysAddress>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
