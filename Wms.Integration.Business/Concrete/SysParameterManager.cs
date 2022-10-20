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
    public class SysParameterManager : ISysParameterService
    {
        private readonly ISysParameterDal sysParameterDal;
        private readonly ILoggerDal loggerDal;  
        public SysParameterManager(ISysParameterDal sysParameterDal, ILoggerDal loggerDal)
        {
            this.sysParameterDal = sysParameterDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<SysParameter>> CreateAsync(SysParameter entity)
        {
            try
            {
                return new SuccessDataResult<SysParameter>(await sysParameterDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysParameterManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysParameter>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysParameter>> DeleteAsync(SysParameter entity)
        {
            try
            {
                return new SuccessDataResult<SysParameter>(await sysParameterDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysParameterManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysParameter>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysParameter>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysParameter>(await sysParameterDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysParameterManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysParameter>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysParameter>> UpdateAsync(SysParameter entity)
        {
            try
            {
                return new SuccessDataResult<SysParameter>(await sysParameterDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysParameterManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysParameter>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
