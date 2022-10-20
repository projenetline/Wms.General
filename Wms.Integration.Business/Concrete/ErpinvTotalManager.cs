using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class ErpinvTotalManager : IErpinvTotalService
    {
        private readonly IErpinvTotalDal erpinvTotalDal;
        private readonly ILoggerDal loggerDal;
        public ErpinvTotalManager(IErpinvTotalDal erpinvTotalDal, ILoggerDal loggerDal)
        {
            this.erpinvTotalDal = erpinvTotalDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<ErpinvTotal>> CreateAsync(ErpinvTotal entity)
        {
            try
            {
                return new SuccessDataResult<ErpinvTotal>(await erpinvTotalDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ErpinvTotalManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ErpinvTotal>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<ErpinvTotal>> DeleteAsync(ErpinvTotal entity)
        {
            try
            {
                return new SuccessDataResult<ErpinvTotal>(await erpinvTotalDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ErpinvTotalManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ErpinvTotal>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<ErpinvTotal>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<ErpinvTotal>(await erpinvTotalDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ErpinvTotalManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ErpinvTotal>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<ErpinvTotal>> UpdateAsync(ErpinvTotal entity)
        {
            try
            {
                return new SuccessDataResult<ErpinvTotal>(await erpinvTotalDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "ErpinvTotalManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<ErpinvTotal>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
