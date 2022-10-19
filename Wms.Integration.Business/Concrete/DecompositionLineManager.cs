using Wms.Integration.Business.Abstract;
using Wms.Integration.Business.Messages;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.DecompositionLines;

namespace Wms.Integration.Business.Concrete
{
    public class DecompositionLineManager : IDecompositionLineService
    {
        private readonly IDecompositionLineDal decompositionLineDal;
        private readonly ILoggerDal loggerDal;
        public DecompositionLineManager(IDecompositionLineDal decompositionLineDal, ILoggerDal loggerDal)
        {
            this.loggerDal = loggerDal;
            this.decompositionLineDal = decompositionLineDal;
        }
        public async Task<IDataResult<bool>> AnyAsync(DecompositionLine entity)
        {
            try
            {
                return new SuccessDataResult<bool>(await decompositionLineDal.GetAnyAsync(s=>s.Id==entity.Id), MessagingHelper.DLineAny);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionLineManager.AnyAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<bool>(false, MessagingHelper.NDLineAny);
            }
        }
        public async Task<IDataResult<DecompositionLine>> CreateAsync(DecompositionLine entity)
        {
            try
            {
                return new SuccessDataResult<DecompositionLine>(await decompositionLineDal.CreateAsync(entity), MessagingHelper.DLineCreate);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionLineManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<DecompositionLine>(null, MessagingHelper.NDLineCreate);
            }
        }
        public async Task<IDataResult<DecompositionLine>> DeleteAsync(DecompositionLine entity)
        {
            try
            {
                return new SuccessDataResult<DecompositionLine>(await decompositionLineDal.DeleteAsync(entity), MessagingHelper.DLineDelete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionLineManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<DecompositionLine>(null, MessagingHelper.NDLineDelete);
            }
        }
        public async Task<IDataResult<DecompositionLine>> GetAsync(Guid id)
        {
            try
            {
                return new SuccessDataResult<DecompositionLine>(await decompositionLineDal.GetAsync(s => s.Id == id, false), MessagingHelper.DLineGet);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionLineManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<DecompositionLine>(null, MessagingHelper.NDLineGet);
            }
        }
        public async Task<IDataResult<IList<DecompositionLine>>> GetListAsync(DecompositionLineListParameterDto listDto)
        {
            try
            {
                return new SuccessDataResult<IList<DecompositionLine>>(await decompositionLineDal.GetListAsync(null, s => s.Id, listDto.Descing, null), MessagingHelper.DLineList);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionLineManager.GetListAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<IList<DecompositionLine>>(null, MessagingHelper.NDLineList);
            }
        }
        public async Task<IDataResult<PagedResult<DecompositionLine>>> GetPagedListAsync(DecompositionLineListParameterDto listDto)
        {
            try
            {
                return new SuccessDataResult<PagedResult<DecompositionLine>>(new PagedResult<DecompositionLine>
                {
                    Items = await decompositionLineDal.GetPagedListAsync(listDto.SkipCount, listDto.MaxResultCount, s => s.Amount == listDto.Amount, s => s.CreatedDate, listDto.Descing, null),
                    TotalCount = await decompositionLineDal.CountAsync()
                }, MessagingHelper.DLinePagedList);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionLineManager.GetPagedListAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<PagedResult<DecompositionLine>>(MessagingHelper.NDLinePagedList);
            }
        }
        public async Task<IDataResult<DecompositionLine>> GetParameterAsync(DecompositionLineCodeParameterDto parameterDto)
        {
            try
            {
                return new SuccessDataResult<DecompositionLine>(await decompositionLineDal.GetAsync(s=>s.Amount==parameterDto.Amount,parameterDto.Descing), MessagingHelper.DLineGetParameter);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionLineManager.GetParameterAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<DecompositionLine>(null, MessagingHelper.NDLineGetParameter);
            }
        }
        public async Task<IDataResult<DecompositionLine>> UpdateAsync(DecompositionLine entity)
        {
            try
            {
                return new SuccessDataResult<DecompositionLine>(await decompositionLineDal.UpdateAsync(entity), MessagingHelper.DLineUpdate);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionLineManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<DecompositionLine>(null, MessagingHelper.NDLineUpdate);
            }
        }
    }
}
