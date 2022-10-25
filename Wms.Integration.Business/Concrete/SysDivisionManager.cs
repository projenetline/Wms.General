using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class SysDivisionManager : ISysDivisionService
    {
        private readonly ISysDivisionDal sysDivisionDal;
        private readonly ILoggerDal loggerDal;
        public SysDivisionManager(ISysDivisionDal sysDivisionDal, ILoggerDal loggerDal)
        {
            this.sysDivisionDal = sysDivisionDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysDivision>> CreateAsync(SysDivision entity)
        {
            try
            {
                return new SuccessDataResult<SysDivision>(await sysDivisionDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysDivisionManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysDivision>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysDivision>> DeleteAsync(SysDivision entity)
        {
            try
            {
                return new SuccessDataResult<SysDivision>(await sysDivisionDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysDivisionManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysDivision>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysDivision>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysDivision>(await sysDivisionDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysDivisionManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysDivision>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysDivision>> GetCodeAsync(string Code)
        {
            try
            {
                return new SuccessDataResult<SysDivision>(await sysDivisionDal.GetAsync(s => s.Code == Code), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysDivisionManager.GetCodeAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysDivision>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysDivision>> UpdateAsync(SysDivision entity)
        {
            try
            {
                return new SuccessDataResult<SysDivision>(await sysDivisionDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysDivisionManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysDivision>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
