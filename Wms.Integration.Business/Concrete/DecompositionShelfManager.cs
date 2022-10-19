using Wms.Integration.Business.Abstract;
using Wms.Integration.Business.Messages;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.DecompositionShelfs;

namespace Wms.Integration.Business.Concrete
{
    public class DecompositionShelfManager : IDecompositionShelfService
    {
        private readonly ILoggerDal loggerDal;
        private readonly IDecompositionShelfDal decompositionShelfDal;
        public DecompositionShelfManager(ILoggerDal loggerDal, IDecompositionShelfDal decompositionShelfDal)
        {
            this.loggerDal = loggerDal;
            this.decompositionShelfDal = decompositionShelfDal;
        }
        public async Task<IDataResult<bool>> AnyAsync(DecompositionShelf entity)
        {
            try
            {
                return new SuccessDataResult<bool>(await decompositionShelfDal.GetAnyAsync(s=>s.Id==entity.Id), MessagingHelper.DShelfAny);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelfManager.GetAnyAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<bool>(false, MessagingHelper.NDShelfAny);
            }
        }
        public async Task<IDataResult<DecompositionShelf>> CreateAsync(DecompositionShelf entity)
        {
            try
            {
                return new SuccessDataResult<DecompositionShelf>(await decompositionShelfDal.CreateAsync(entity), MessagingHelper.DShelfCreate);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelfManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<DecompositionShelf>(null, MessagingHelper.NDShelfCreate);
            }
        }
        public async Task<IDataResult<DecompositionShelf>> DeleteAsync(DecompositionShelf entity)
        {
            try
            {
                return new SuccessDataResult<DecompositionShelf>(await decompositionShelfDal.DeleteAsync(entity), MessagingHelper.DShelfDelete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelfManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<DecompositionShelf>(null, MessagingHelper.NDShelfDelete);
            }
        }
        public async Task<IDataResult<DecompositionShelf>> GetAsync(Guid id)
        {
            try
            {
                return new SuccessDataResult<DecompositionShelf>(await decompositionShelfDal.GetAsync(s=>s.Id==id,false), MessagingHelper.DShelfGet);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelfManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<DecompositionShelf>(null, MessagingHelper.NDShelfGet);
            }
        }
        public async Task<IDataResult<IList<DecompositionShelf>>> GetListAsync(DecompositionShelfListParameterDto listDto)
        {
            try
            {
                return new SuccessDataResult<IList<DecompositionShelf>>( await decompositionShelfDal.GetListAsync( listDto.Capacity == -1 ? null : s => s.Capacity == listDto.Capacity, s => s.Id, listDto.Descing, null) , MessagingHelper.DShelfList);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelfManager.GetListAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<IList<DecompositionShelf>>(null, MessagingHelper.NDShelfList);
            }
        }
        public async Task<IDataResult<PagedResult<DecompositionShelf>>> GetPagedListAsync(DecompositionShelfListParameterDto listDto)
        {
            try
            {
                return new SuccessDataResult<PagedResult<DecompositionShelf>>(new PagedResult<DecompositionShelf>
                {
                    Items= await decompositionShelfDal.GetPagedListAsync( listDto.SkipCount,listDto.MaxResultCount,listDto.Capacity==-1?null : s => s.Capacity == listDto.Capacity, s => s.Id, listDto.Descing, null),
                    TotalCount=await decompositionShelfDal.CountAsync()
                }, MessagingHelper.DShelfPagedList);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelfManager.GetPagedListAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<PagedResult<DecompositionShelf>>(null, MessagingHelper.NDShelfPagedList);
            }
        }
        public async Task<IDataResult<DecompositionShelf>> GetParameterAsync(DecompositionShelfCodeParameterDto parameterDto)
        {
            try
            {
                return new SuccessDataResult<DecompositionShelf>(await decompositionShelfDal.GetAsync(s=>s.Capacity==parameterDto.Capacity,parameterDto.Descing), MessagingHelper.DShelfGetParameter);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelfManager.GetParameterAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<DecompositionShelf>(null, MessagingHelper.NDShelfGetParameter);
            }
        }
        public async Task<IDataResult<DecompositionShelf>> UpdateAsync(DecompositionShelf entity)
        {
            try
            {
                return new SuccessDataResult<DecompositionShelf>(await decompositionShelfDal.UpdateAsync(entity), MessagingHelper.DShelfUpdate);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelfManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<DecompositionShelf>(null, MessagingHelper.NDShelfUpdate);
            }
        }
    }
}
