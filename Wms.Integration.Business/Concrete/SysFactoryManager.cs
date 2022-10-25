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
    public class SysFactoryManager:ISysFactoryService
    {
        private readonly ISysFactoryDal sysFactoryDal;
        private readonly ILoggerDal loggerDal;
        public SysFactoryManager(ISysFactoryDal sysFactoryDal, ILoggerDal loggerDal)
        {
            this.sysFactoryDal = sysFactoryDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<SysFactory>> CreateAsync(SysFactory entity)
        {
            try
            {
                return new SuccessDataResult<SysFactory>(await sysFactoryDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysFactoryManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysFactory>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysFactory>> DeleteAsync(SysFactory entity)
        {
            try
            {
                return new SuccessDataResult<SysFactory>(await sysFactoryDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysFactoryManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysFactory>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysFactory>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysFactory>(await sysFactoryDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysFactoryManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysFactory>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysFactory>> GetCodeAsync(string Code)
        {
            try
            {
                return new SuccessDataResult<SysFactory>(await sysFactoryDal.GetAsync(s => s.Code == Code), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysFactoryManager.GetCodeAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysFactory>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysFactory>> UpdateAsync(SysFactory entity)
        {
            try
            {
                return new SuccessDataResult<SysFactory>(await sysFactoryDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysFactoryManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysFactory>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
