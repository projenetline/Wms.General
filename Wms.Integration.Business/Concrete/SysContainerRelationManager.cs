using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysContainerRelationManager : ISysContainerRelationService
    {
        private readonly ISysContainerRelationDal sysContainerRelationDal;
        private readonly ILoggerDal loggerDal;
        public SysContainerRelationManager(ISysContainerRelationDal sysContainerRelationDal, ILoggerDal loggerDal)
        {
            this.sysContainerRelationDal = sysContainerRelationDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysContainerRelation>> CreateAsync(SysContainerRelation entity)
        {
            try
            {
                return new SuccessDataResult<SysContainerRelation>(await sysContainerRelationDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
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
                return new ErrorDataResult<SysContainerRelation>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysContainerRelation>> DeleteAsync(SysContainerRelation entity)
        {
            try
            {
                return new SuccessDataResult<SysContainerRelation>(await sysContainerRelationDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
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
                return new ErrorDataResult<SysContainerRelation>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysContainerRelation>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysContainerRelation>(await sysContainerRelationDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
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
                return new ErrorDataResult<SysContainerRelation>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysContainerRelation>> UpdateAsync(SysContainerRelation entity)
        {
            try
            {
                return new SuccessDataResult<SysContainerRelation>(await sysContainerRelationDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
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
                return new ErrorDataResult<SysContainerRelation>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
