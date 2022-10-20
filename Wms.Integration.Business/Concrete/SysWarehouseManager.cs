using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysWarehouseManager : ISysWarehouseService
    {
        private readonly ISysWarehouseDal sysWarehouseDal;
        private readonly ILoggerDal loggerDal;  
        public SysWarehouseManager(ISysWarehouseDal sysWarehouseDal, ILoggerDal loggerDal)
        {
            this.sysWarehouseDal = sysWarehouseDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<SysWarehouse>> CreateAsync(SysWarehouse entity)
        {
            try
            {
                return new SuccessDataResult<SysWarehouse>(await sysWarehouseDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouse>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<SysWarehouse>> DeleteAsync(SysWarehouse entity)
        {
            try
            {
                return new SuccessDataResult<SysWarehouse>(await sysWarehouseDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouse>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<SysWarehouse>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysWarehouse>(await sysWarehouseDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouse>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<SysWarehouse>> UpdateAsync(SysWarehouse entity)
        {
            try
            {
                return new SuccessDataResult<SysWarehouse>(await sysWarehouseDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouse>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
