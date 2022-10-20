using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysWarehouseFloorManager : ISysWarehouseFloorService
    {
        private readonly ISysWarehouseFloorDal sysWarehouseFloorDal;
        private readonly ILoggerDal loggerDal;
        public SysWarehouseFloorManager(ISysWarehouseFloorDal sysWarehouseFloorDal, ILoggerDal loggerDal)
        {
            this.sysWarehouseFloorDal = sysWarehouseFloorDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysWarehouseFloor>> CreateAsync(SysWarehouseFloor entity)
        {
            try
            {
                return new SuccessDataResult<SysWarehouseFloor>(await sysWarehouseFloorDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseFloorManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouseFloor>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysWarehouseFloor>> DeleteAsync(SysWarehouseFloor entity)
        {
            try
            {
                return new SuccessDataResult<SysWarehouseFloor>(await sysWarehouseFloorDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseFloorManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouseFloor>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysWarehouseFloor>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysWarehouseFloor>(await sysWarehouseFloorDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseFloorManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouseFloor>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysWarehouseFloor>> UpdateAsync(SysWarehouseFloor entity)
        {
            try
            {
                return new SuccessDataResult<SysWarehouseFloor>(await sysWarehouseFloorDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysWarehouseFloorManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysWarehouseFloor>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
