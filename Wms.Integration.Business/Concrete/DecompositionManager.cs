using Wms.Integration.Business.Abstract;
using Wms.Integration.Business.Messages;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.Decompositions;

namespace Wms.Integration.Business.Concrete
{
    public class DecompositionManager : IDecompositionService
    {
        private readonly ILoggerDal loggerDal;
        private readonly IDecompositionDal decompositionDal;
        public DecompositionManager(ILoggerDal loggerDal,IDecompositionDal decompositionDal)
        {
            this.loggerDal = loggerDal;
            this.decompositionDal= decompositionDal;
        }
        public async Task<IDataResult<Decomposition>> GetAsync(Guid id)
        {
            try
            {
                return new SuccessDataResult<Decomposition>(await decompositionDal.GetAsync(s=>s.Id==id,false), MessagingHelper.DGet);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Decomposition>(null, MessagingHelper.NDGet);
            }
        }
        public async Task<IDataResult<Decomposition>> CreateAsync(Decomposition entity)
        {
            try    
            {
                return new SuccessDataResult<Decomposition>(await decompositionDal.CreateAsync(entity), MessagingHelper.DCreate);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Decomposition>(null, MessagingHelper.NDCreate);
            }
        }
        public async Task<IDataResult<Decomposition>> UpdateAsync(Decomposition entity)
        {
            try
            {
                return new SuccessDataResult<Decomposition>(await decompositionDal.UpdateAsync(entity), MessagingHelper.DUpdate);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Decomposition>(null, MessagingHelper.NDUpdate);
            }
        }
        public async Task<IDataResult<Decomposition>> DeleteAsync(Decomposition entity)
        {
            try
            {
                return new SuccessDataResult<Decomposition>(await decompositionDal.DeleteAsync(entity), MessagingHelper.DDelete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Decomposition>(null, MessagingHelper.NDDelete);
            }
        }
        public async Task<IDataResult<IList<Decomposition>>> GetListAsync(DecompositionListParameterDto listDto)
        {
            try
            {
                return new SuccessDataResult<IList<Decomposition>>(await decompositionDal.GetListAsync(s=>s.IsCompleted==listDto.IsCompleted,s=>s.CreatedDate,listDto.Descing), MessagingHelper.DList);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionManager.GetListAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<IList<Decomposition>>(null, MessagingHelper.NDList);
            }
        }
        public async Task<IDataResult<PagedResult<Decomposition>>> GetPagedListAsync(DecompositionListParameterDto listDto)
        {
            try
            {
                return new SuccessDataResult<PagedResult<Decomposition>>(new PagedResult<Decomposition> { 
                    Items = await decompositionDal.GetListAsync(s => s.IsCompleted == listDto.IsCompleted, s => s.CreatedDate, listDto.Descing),
                    TotalCount =await decompositionDal.CountAsync(s=>s.IsCompleted==listDto.IsCompleted)
                }, MessagingHelper.DPagedList);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionManager.GetPagedListAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<PagedResult<Decomposition>>(null, MessagingHelper.NDPagedList);
            }
        }
        public async Task<IDataResult<Decomposition>> GetParameterAsync(DecompositionCodeParameterDto parameterDto)
        {
            try
            {
                return new SuccessDataResult<Decomposition>(await decompositionDal.GetAsync(s=>s.IsCompleted==parameterDto.IsCompleted,parameterDto.Descing), MessagingHelper.DGetParameter);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionManager.GetParameterAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Decomposition>(null, MessagingHelper.NDGetParameter);
            }
        }
        public async Task<IDataResult<bool>> AnyAsync(Decomposition entity)
        {
            try
            {
                return new SuccessDataResult<bool>(await decompositionDal.GetAnyAsync(s => s.Id==entity.Id), MessagingHelper.DAny);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionManager.AnyAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<bool>(false, MessagingHelper.NDAny);
            }
        }
    }
}
