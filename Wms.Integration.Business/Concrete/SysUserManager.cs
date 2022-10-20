using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysUserManager : ISysUserService
    {
        private readonly ISysUserDal sysUserDal;
        private readonly ILoggerDal loggerDal;
        public SysUserManager(ISysUserDal sysUserDal, ILoggerDal loggerDal)
        {
            this.sysUserDal = sysUserDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysUser>> CreateAsync(SysUser entity)
        {
            try
            {
                return new SuccessDataResult<SysUser>(await sysUserDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysUserManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysUser>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysUser>> DeleteAsync(SysUser entity)
        {
            try
            {
                return new SuccessDataResult<SysUser>(await sysUserDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysUserManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysUser>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysUser>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysUser>(await sysUserDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysUserManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysUser>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysUser>> UpdateAsync(SysUser entity)
        {
            try
            {
                return new SuccessDataResult<SysUser>(await sysUserDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysUserManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysUser>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
