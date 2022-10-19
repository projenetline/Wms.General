using Wms.Integration.Business.Abstract;
using Wms.Integration.Business.Messages;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.DecompositionShelves;

namespace Wms.Integration.Business.Concrete
{
    public class DecompositionShelvesManager : IDecompositionShelvesService
    {
        private readonly ILoggerDal loggerDal;
        private readonly IDecompositionShelvesDal decompositionShelvesDal;
        public DecompositionShelvesManager(ILoggerDal loggerDal, IDecompositionShelvesDal decompositionShelvesDal)
        {
            this.loggerDal = loggerDal;
            this.decompositionShelvesDal = decompositionShelvesDal;
        }
        public async Task<IDataResult<bool>> AnyAsync(DecompositionShelves entity)
        {
            try
            {
                return new SuccessDataResult<bool>(await decompositionShelvesDal.GetAnyAsync(s=>s.Id==entity.Id), MessagingHelper.DShelvesAny);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelvesManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<bool>(false,MessagingHelper.NDShelvesAny);
            }
        }
        public async Task<IDataResult<DecompositionShelves>> CreateAsync(DecompositionShelves entity)
        {
            try
            {
                return new SuccessDataResult<DecompositionShelves>(await decompositionShelvesDal.CreateAsync(entity), MessagingHelper.DShelvesCreate);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelvesManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<DecompositionShelves>(null, MessagingHelper.NDShelvesCreate);
            }
        }
        public async Task<IDataResult<DecompositionShelves>> DeleteAsync(DecompositionShelves entity)
        {
            try
            {
                return new SuccessDataResult<DecompositionShelves>(await decompositionShelvesDal.DeleteAsync(entity), MessagingHelper.DShelvesDelete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelvesManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<DecompositionShelves>(null, MessagingHelper.NDShelvesDelete);
            }
        }
        public async Task<IDataResult<DecompositionShelves>> GetAsync(Guid id)
        {
            try
            {
                return new SuccessDataResult<DecompositionShelves>(await decompositionShelvesDal.GetAsync(s=>s.Id==id,false), MessagingHelper.DShelvesGet);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelvesManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<DecompositionShelves>(null, MessagingHelper.NDShelvesGet);
            }
        }
        public async Task<IDataResult<IList<DecompositionShelves>>> GetListAsync(DecompositionShelvesListParameterDto listDto)
        {
            try
            {
                return new SuccessDataResult<IList<DecompositionShelves>>(await decompositionShelvesDal.GetListAsync((listDto.Code==""?null: s => s.Code == listDto.Code), s => s.CreatedDate,listDto.Descing), MessagingHelper.DShelvesList);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelves.GetListAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<IList<DecompositionShelves>>(null, MessagingHelper.NDShelvesList);
            }
        }
        public async Task<IDataResult<PagedResult<DecompositionShelves>>> GetPagedListAsync(DecompositionShelvesListParameterDto listDto)
        {
            try
            {
                return new SuccessDataResult<PagedResult<DecompositionShelves>>(new PagedResult<DecompositionShelves>
                    {
                        Items = await decompositionShelvesDal.GetListAsync((listDto.Code == "" ? null : s => s.Code == listDto.Code), s => s.CreatedDate, listDto.Descing),
                        TotalCount = await decompositionShelvesDal.CountAsync(listDto.Code == "" ? null : s => s.Code == listDto.Code)
                    }, MessagingHelper.DShelvesPagedList);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelves.GetPagedListAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<PagedResult<DecompositionShelves>>(null, MessagingHelper.NDShelvesPagedList);
            }
        }
        public  async Task<IDataResult<DecompositionShelves>> GetParameterAsync(DecompositionShelvesCodeParameterDto parameterDto)
        {
            try
            {
                return new SuccessDataResult<DecompositionShelves>(await decompositionShelvesDal.GetAsync(parameterDto.Code!=""?s=>s.Code==parameterDto.Code:s=>s.Code==s.Code,parameterDto.Descing), MessagingHelper.DShelvesGetParameter);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelvesManager.GetParameterAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<DecompositionShelves>(null, MessagingHelper.NDShelvesGetParameter);
            }
        }
        public async Task<IDataResult<DecompositionShelves>> UpdateAsync(DecompositionShelves entity)
        {
            try
            {
                return new SuccessDataResult<DecompositionShelves>(await decompositionShelvesDal.UpdateAsync(entity), MessagingHelper.DShelvesUpdate);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DecompositionShelvesManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<DecompositionShelves>(null, MessagingHelper.NDShelvesUpdate);
            }
        }
    }
}
