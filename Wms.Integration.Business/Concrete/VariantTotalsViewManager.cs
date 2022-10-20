using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class VariantTotalsViewManager : IVariantTotalsViewService
    {
        private readonly IVariantTotalsViewDal variantTotalsViewDal;
        private readonly ILoggerDal loggerDal;
        public VariantTotalsViewManager(IVariantTotalsViewDal variantTotalsViewDal, ILoggerDal loggerDal)
        {
            this.variantTotalsViewDal = variantTotalsViewDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<VariantTotalsView>> GetData(int Id)
        {
            try
            {
                return new SuccessDataResult<VariantTotalsView>(await variantTotalsViewDal.GetAsync(s=>s.ItemId==Id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "VariantTotalsViewManager.GetData",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<VariantTotalsView>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public Task<IDataResult<IList<VariantTotalsView>>> GetListAsync(VariantTotalsView entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<PagedResult<VariantTotalsView>>> GetPagedListAsync(VariantTotalsView entity)
        {
            throw new NotImplementedException();
        }
    }
}
