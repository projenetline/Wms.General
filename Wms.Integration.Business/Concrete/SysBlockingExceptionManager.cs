using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysBlockingExceptionManager : ISysBlockingExceptionService
    {
        private readonly ISysBlockingExceptionDal sysBlockingExceptionDal;
        private readonly ILoggerDal loggerDal;  
        public SysBlockingExceptionManager(ISysBlockingExceptionDal sysBlockingExceptionDal, ILoggerDal loggerDal)
        {
            this.sysBlockingExceptionDal = sysBlockingExceptionDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<SysBlockingException>> CreateAsync(SysBlockingException entity)
        {
            try
            {
                return new SuccessDataResult<SysBlockingException>(await sysBlockingExceptionDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysBlockingExceptionManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysBlockingException>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysBlockingException>> DeleteAsync(SysBlockingException entity)
        {
            try
            {
                return new SuccessDataResult<SysBlockingException>(await sysBlockingExceptionDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysBlockingExceptionManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysBlockingException>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysBlockingException>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysBlockingException>(await sysBlockingExceptionDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysBlockingExceptionManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysBlockingException>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysBlockingException>> UpdateAsync(SysBlockingException entity)
        {
            try
            {
                return new SuccessDataResult<SysBlockingException>(await sysBlockingExceptionDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysBlockingExceptionManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysBlockingException>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
