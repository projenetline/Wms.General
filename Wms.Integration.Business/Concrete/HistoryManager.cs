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
    public class HistoryManager : IHistoryService
    {
        private readonly IHistoryDal historyDal;
        private readonly ILoggerDal loggerDal;
        public HistoryManager(IHistoryDal historyDal, ILoggerDal loggerDal)
        {
            this.historyDal = historyDal;
            this.loggerDal = loggerDal;
        }
        public  async Task<IDataResult<History>> CreateAsync(History entity)
        {
            try
            {
                return new SuccessDataResult<History>(await historyDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "HistoryManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<History>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<History>> DeleteAsync(History entity)
        {
            try
            {
                return new SuccessDataResult<History>(await historyDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "HistoryManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<History>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<History>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<History>(await historyDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "HistoryManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<History>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<History>> UpdateAsync(History entity)
        {
            try
            {
                return new SuccessDataResult<History>(await historyDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "HistoryManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<History>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
