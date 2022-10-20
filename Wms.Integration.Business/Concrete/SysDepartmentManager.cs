using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysDepartmentManager : ISysDepartmentService
    {
        private readonly ISysDepartmentDal sysDepartmentDal;
        private readonly ILoggerDal loggerDal;
        public SysDepartmentManager(ISysDepartmentDal sysDepartmentDal,ILoggerDal loggerDal)
        {
            this.sysDepartmentDal = sysDepartmentDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<SysDepartment>> CreateAsync(SysDepartment entity)
        {
            try
            {
                return new SuccessDataResult<SysDepartment>(await sysDepartmentDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysDepartmentManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysDepartment>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<SysDepartment>> DeleteAsync(SysDepartment entity)
        {
            try
            {
                return new SuccessDataResult<SysDepartment>(await sysDepartmentDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysDepartmentManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysDepartment>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<SysDepartment>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysDepartment>(await sysDepartmentDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysDepartmentManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysDepartment>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<SysDepartment>> UpdateAsync(SysDepartment entity)
        {
            try
            {
                return new SuccessDataResult<SysDepartment>(await sysDepartmentDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysDepartmentManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysDepartment>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
