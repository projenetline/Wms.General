using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class VariantTrackingTotalsViewManager : IVariantTrackingTotalsViewService
    {
        private readonly IVariantTrackingTotalsViewDal variantTrackingTotalsViewDal;
        private readonly ILoggerDal loggerDal;
        public VariantTrackingTotalsViewManager(IVariantTrackingTotalsViewDal variantTrackingTotalsViewDal, ILoggerDal loggerDal)
        {
            this.variantTrackingTotalsViewDal = variantTrackingTotalsViewDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<VariantTrackingTotalsView>> GetData(int Id)
        {
            try
            {
                return new SuccessDataResult<VariantTrackingTotalsView>(await variantTrackingTotalsViewDal.GetAsync(s=>s.AddressId==Id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "VariantTrackingTotalsViewManager.GetData",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<VariantTrackingTotalsView>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public Task<IDataResult<IList<VariantTrackingTotalsView>>> GetListAsync(VariantTrackingTotalsView entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PagedResult<VariantTrackingTotalsView>>> GetPagedListAsync(VariantTrackingTotalsView entity)
        {
            throw new NotImplementedException();
        }
    }
}
