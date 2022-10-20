using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysWarehouseZoneManager : ISysWarehouseZoneService
    {
        private readonly ISysWarehouseZoneDal sysWarehouseZoneDal;
        private readonly ILoggerDal loggerDal;
        public SysWarehouseZoneManager(ISysWarehouseZoneDal sysWarehouseZoneDal, ILoggerDal loggerDal)
        {
            this.sysWarehouseZoneDal = sysWarehouseZoneDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysWarehouseZone>> CreateAsync(SysWarehouseZone entity)
        {
            try
            {
                return new SuccessDataResult<SysWarehouseZone>(await sysWarehouseZoneDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseZoneManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouseZone>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysWarehouseZone>> DeleteAsync(SysWarehouseZone entity)
        {
            try
            {
                return new SuccessDataResult<SysWarehouseZone>(await sysWarehouseZoneDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseZoneManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouseZone>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysWarehouseZone>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysWarehouseZone>(await sysWarehouseZoneDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseZoneManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouseZone>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysWarehouseZone>> UpdateAsync(SysWarehouseZone entity)
        {
            try
            {
                return new SuccessDataResult<SysWarehouseZone>(await sysWarehouseZoneDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseZoneManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouseZone>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
