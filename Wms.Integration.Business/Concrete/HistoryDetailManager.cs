using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class HistoryDetailManager : IHistoryDetailService
    {
        private readonly IHistoryDetailDal historyDetailDal;
        private readonly ILoggerDal loggerDal;
        public HistoryDetailManager(IHistoryDetailDal historyDetailDal, ILoggerDal loggerDal)
        {
            this.historyDetailDal = historyDetailDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<HistoryDetail>> CreateAsync(HistoryDetail entity)
        {
            try
            {
                return new SuccessDataResult<HistoryDetail>(await historyDetailDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "HistoryDetailManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<HistoryDetail>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<HistoryDetail>> DeleteAsync(HistoryDetail entity)
        {
            try
            {
                return new SuccessDataResult<HistoryDetail>(await historyDetailDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "HistoryDetailManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<HistoryDetail>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<HistoryDetail>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<HistoryDetail>(await historyDetailDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "HistoryDetailManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<HistoryDetail>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<HistoryDetail>> UpdateAsync(HistoryDetail entity)
        {
            try
            {
                return new SuccessDataResult<HistoryDetail>(await historyDetailDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "HistoryDetailManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<HistoryDetail>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
