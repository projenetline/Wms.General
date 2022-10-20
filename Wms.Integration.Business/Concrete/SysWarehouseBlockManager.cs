using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysWarehouseBlockManager : ISysWarehouseBlockService
    {
        private readonly ISysWarehouseBlockDal sysWarehouseBlockDal;
        private readonly ILoggerDal loggerDal;
        public SysWarehouseBlockManager(ISysWarehouseBlockDal sysWarehouseBlockDal, ILoggerDal loggerDal)
        {
            this.sysWarehouseBlockDal = sysWarehouseBlockDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysWarehouseBlock>> CreateAsync(SysWarehouseBlock entity)
        {
            try
            {
                return new SuccessDataResult<SysWarehouseBlock>(await sysWarehouseBlockDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseBlockManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouseBlock>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysWarehouseBlock>> DeleteAsync(SysWarehouseBlock entity)
        {
            try
            {
                return new SuccessDataResult<SysWarehouseBlock>(await sysWarehouseBlockDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseBlockManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouseBlock>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysWarehouseBlock>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysWarehouseBlock>(await sysWarehouseBlockDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseBlockManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouseBlock>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysWarehouseBlock>> UpdateAsync(SysWarehouseBlock entity)
        {
            try
            {
                return new SuccessDataResult<SysWarehouseBlock>(await sysWarehouseBlockDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseBlockManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouseBlock>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
