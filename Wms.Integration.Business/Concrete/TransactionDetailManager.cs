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
    public class TransactionDetailManager : ITransactionDetailService
    {
        private readonly ITransactionDetailDal transactionDetailDal;
        private readonly ILoggerDal loggerDal;
        public TransactionDetailManager(ITransactionDetailDal transactionDetailDal, ILoggerDal loggerDal)
        {
            this.transactionDetailDal = transactionDetailDal;
            this.loggerDal = loggerDal;
        }

        public async Task<IDataResult<TransactionDetail>> CreateAsync(TransactionDetail entity)
        {
            try
            {
                return new SuccessDataResult<TransactionDetail>(await transactionDetailDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "TransactionDetailManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<TransactionDetail>(null, CustomJObject.Instance.General.NotCreate);
            }
        }

        public async Task<IDataResult<TransactionDetail>> DeleteAsync(TransactionDetail entity)
        {
            try
            {
                return new SuccessDataResult<TransactionDetail>(await transactionDetailDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "TransactionDetailManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<TransactionDetail>(null, CustomJObject.Instance.General.NotDelete);
            }
        }

        public async Task<IDataResult<TransactionDetail>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<TransactionDetail>(await transactionDetailDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "TransactionDetailManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<TransactionDetail>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<TransactionDetail>> UpdateAsync(TransactionDetail entity)
        {
            try
            {
                return new SuccessDataResult<TransactionDetail>(await transactionDetailDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "TransactionDetailManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<TransactionDetail>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
