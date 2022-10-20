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
    public class SysContainerTypeManager : ISysContainerTypeService
    {
        private readonly ISysContainerTypeDal sysContainerTypeDal;
        private readonly ILoggerDal loggerDal;
        public SysContainerTypeManager(ISysContainerTypeDal sysContainerTypeDal, ILoggerDal loggerDal)
        {
            this.sysContainerTypeDal = sysContainerTypeDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<SysContainerType>> CreateAsync(SysContainerType entity)
        {
            try
            {
                return new SuccessDataResult<SysContainerType>(await sysContainerTypeDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysContainerRelationManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysContainerType>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysContainerType>> DeleteAsync(SysContainerType entity)
        {
            try
            {
                return new SuccessDataResult<SysContainerType>(await sysContainerTypeDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysContainerRelationManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysContainerType>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysContainerType>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysContainerType>(await sysContainerTypeDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysContainerRelationManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysContainerType>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysContainerType>> UpdateAsync(SysContainerType entity)
        {
            try
            {
                return new SuccessDataResult<SysContainerType>(await sysContainerTypeDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysContainerRelationManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysContainerType>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
