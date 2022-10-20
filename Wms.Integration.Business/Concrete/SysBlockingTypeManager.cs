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
    public class SysBlockingTypeManager : ISysBlockingTypeService
    {
        private readonly ISysBlockingTypeDal sysBlockingDal;
        private readonly ILoggerDal loggerDal;
        public SysBlockingTypeManager(ISysBlockingTypeDal sysBlockingDal, ILoggerDal loggerDal)
        {
            this.sysBlockingDal = sysBlockingDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysBlockingType>> CreateAsync(SysBlockingType entity)
        {
            try
            {
                return new SuccessDataResult<SysBlockingType>(await sysBlockingDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysBlockingTypeManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysBlockingType>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysBlockingType>> DeleteAsync(SysBlockingType entity)
        {
            try
            {
                return new SuccessDataResult<SysBlockingType>(await sysBlockingDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysBlockingTypeManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysBlockingType>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysBlockingType>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysBlockingType>(await sysBlockingDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysBlockingTypeManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysBlockingType>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysBlockingType>> UpdateAsync(SysBlockingType entity)
        {
            try
            {
                return new SuccessDataResult<SysBlockingType>(await sysBlockingDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysBlockingTypeManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysBlockingType>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
