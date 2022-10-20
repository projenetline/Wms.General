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
    public class SysCustomListColumnManager : ISysCustomListColumnService
    {
        private readonly ISysCustomListColumnDal sysCustomListColumnDal;
        private readonly ILoggerDal loggerDal;
        public SysCustomListColumnManager(ISysCustomListColumnDal sysCustomListColumnDal, ILoggerDal loggerDal)
        {
            this.sysCustomListColumnDal = sysCustomListColumnDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysCustomListColumn>> CreateAsync(SysCustomListColumn entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomListColumn>(await sysCustomListColumnDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomListColumnManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomListColumn>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysCustomListColumn>> DeleteAsync(SysCustomListColumn entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomListColumn>(await sysCustomListColumnDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomListColumnManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomListColumn>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysCustomListColumn>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysCustomListColumn>(await sysCustomListColumnDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomListColumnManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomListColumn>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysCustomListColumn>> UpdateAsync(SysCustomListColumn entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomListColumn>(await sysCustomListColumnDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomListColumnManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomListColumn>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
