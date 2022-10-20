using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysUserWarehouseManager : ISysUserWarehouseService
    {
        private readonly ISysUserWarehouseDal sysUserWarehouseDal;
        private readonly ILoggerDal loggerDal;
        public SysUserWarehouseManager(ISysUserWarehouseDal sysUserWarehouseDal, ILoggerDal loggerDal)
        {
            this.sysUserWarehouseDal = sysUserWarehouseDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysUserWarehouse>> CreateAsync(SysUserWarehouse entity)
        {
            try
            {
                return new SuccessDataResult<SysUserWarehouse>(await sysUserWarehouseDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysUserWarehouse.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysUserWarehouse>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysUserWarehouse>> DeleteAsync(SysUserWarehouse entity)
        {
            try
            {
                return new SuccessDataResult<SysUserWarehouse>(await sysUserWarehouseDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysUserWarehouse.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysUserWarehouse>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysUserWarehouse>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysUserWarehouse>(await sysUserWarehouseDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysUserWarehouse.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysUserWarehouse>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysUserWarehouse>> UpdateAsync(SysUserWarehouse entity)
        {
            try
            {
                return new SuccessDataResult<SysUserWarehouse>(await sysUserWarehouseDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysUserWarehouse.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysUserWarehouse>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
