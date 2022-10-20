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
    public class SlipManager : ISlipService
    {
        private readonly ISlipDal slipDal;
        private readonly ILoggerDal loggerDal;
        public SlipManager(ISlipDal slipDal, ILoggerDal loggerDal)
        {
            this.slipDal = slipDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<Slip>> CreateAsync(Slip entity)
        {
            try
            {
                return new SuccessDataResult<Slip>(await slipDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SlipManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Slip>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<Slip>> DeleteAsync(Slip entity)
        {
            try
            {
                return new SuccessDataResult<Slip>(await slipDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SlipManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Slip>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<Slip>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<Slip>(await slipDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SlipManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Slip>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<Slip>> UpdateAsync(Slip entity)
        {
            try
            {
                return new SuccessDataResult<Slip>(await slipDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "SlipManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Slip>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
