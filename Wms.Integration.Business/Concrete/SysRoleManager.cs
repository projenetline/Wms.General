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
    public class SysRoleManager : ISysRoleService
    {
        private readonly ISysRoleDal sysRoleDal;
        private readonly ILoggerDal loggerDal;
        public SysRoleManager(ISysRoleDal sysRoleDal, ILoggerDal loggerDal)
        {
            this.sysRoleDal = sysRoleDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysRole>> CreateAsync(SysRole entity)
        {
            try
            {
                return new SuccessDataResult<SysRole>(await sysRoleDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysRoleManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysRole>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysRole>> DeleteAsync(SysRole entity)
        {
            try
            {
                return new SuccessDataResult<SysRole>(await sysRoleDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysRoleManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysRole>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysRole>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysRole>(await sysRoleDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysRoleManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysRole>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysRole>> UpdateAsync(SysRole entity)
        {
            try
            {
                 return new SuccessDataResult<SysRole>(await sysRoleDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysRoleManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysRole>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
