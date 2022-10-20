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
    public class SysCustomCodeManager : ISysCustomCodeService
    {
        private readonly ISysCustomCodeDal sysCustomCodeDal;
        private readonly ILoggerDal loggerDal;
        public SysCustomCodeManager(ISysCustomCodeDal sysCustomCodeDal, ILoggerDal loggerDal)
        {
            this.sysCustomCodeDal = sysCustomCodeDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<SysCustomCode>> CreateAsync(SysCustomCode entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomCode>(await sysCustomCodeDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomCodeManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomCode>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysCustomCode>> DeleteAsync(SysCustomCode entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomCode>(await sysCustomCodeDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomCodeManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomCode>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysCustomCode>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysCustomCode>(await sysCustomCodeDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomCodeManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomCode>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysCustomCode>> UpdateAsync(SysCustomCode entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomCode>(await sysCustomCodeDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomCodeManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomCode>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
