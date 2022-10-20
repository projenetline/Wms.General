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
    public class SysMenuRightManager:ISysMenuRightService
    {
        private readonly ISysMenuRightDal sysMenuRightDal;
        private readonly ILoggerDal loggerDal;
        public SysMenuRightManager(ISysMenuRightDal sysMenuRightDal, ILoggerDal loggerDal)
        {
            this.sysMenuRightDal = sysMenuRightDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<SysMenuRight>> CreateAsync(SysMenuRight entity)
        {
            try
            {
                return new SuccessDataResult<SysMenuRight>(await sysMenuRightDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysMenuRightManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysMenuRight>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<SysMenuRight>> DeleteAsync(SysMenuRight entity)
        {
            try
            {
                return new SuccessDataResult<SysMenuRight>(await sysMenuRightDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysMenuRightManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysMenuRight>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<SysMenuRight>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysMenuRight>(await sysMenuRightDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysMenuRightManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysMenuRight>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<SysMenuRight>> UpdateAsync(SysMenuRight entity)
        {
            try
            {
                return new SuccessDataResult<SysMenuRight>(await sysMenuRightDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysMenuRightManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysMenuRight>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
