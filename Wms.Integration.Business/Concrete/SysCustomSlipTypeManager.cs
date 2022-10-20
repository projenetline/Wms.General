using AutoMapper.Execution;
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
    public class SysCustomSlipTypeManager : ISysCustomSlipTypeService
    {
        private readonly ISysCustomSlipTypeDal sysCustomSlipTypeDal;
        private readonly ILoggerDal loggerDal;
        public SysCustomSlipTypeManager(ISysCustomSlipTypeDal sysCustomSlipTypeDal, ILoggerDal loggerDal)
        {
            this.sysCustomSlipTypeDal = sysCustomSlipTypeDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<SysCustomSlipType>> CreateAsync(SysCustomSlipType entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomSlipType>(await sysCustomSlipTypeDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomSlipTypeManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomSlipType>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<SysCustomSlipType>> DeleteAsync(SysCustomSlipType entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomSlipType>(await sysCustomSlipTypeDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomSlipTypeManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomSlipType>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<SysCustomSlipType>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<SysCustomSlipType>(await sysCustomSlipTypeDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomSlipTypeManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomSlipType>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<SysCustomSlipType>> UpdateAsync(SysCustomSlipType entity)
        {
            try
            {
                return new SuccessDataResult<SysCustomSlipType>(await sysCustomSlipTypeDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SysCustomSlipTypeManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<SysCustomSlipType>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
