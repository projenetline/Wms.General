using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.JsonObjects;

namespace Wms.Integration.Business.Concrete
{
    public class DocumentManager : IDocumentService
    {
        private readonly IDocumentDal documentDal;
        private readonly ILoggerDal loggerDal;
        public DocumentManager(IDocumentDal documentDal, ILoggerDal loggerDal)
        {
            this.documentDal = documentDal;
            this.loggerDal = loggerDal;
        }
        public async Task<IDataResult<Document>> CreateAsync(Document entity)
        {
            try
            {
                return new SuccessDataResult<Document>(await documentDal.CreateAsync(entity), CustomJObject.Instance.General.Create);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DocumentManager.CreateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Document>(null, CustomJObject.Instance.General.NotCreate);
            }
        }
        public async Task<IDataResult<Document>> DeleteAsync(Document entity)
        {
            try
            {
                return new SuccessDataResult<Document>(await documentDal.DeleteAsync(entity), CustomJObject.Instance.General.Delete);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DocumentManager.DeleteAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Document>(null, CustomJObject.Instance.General.NotDelete);
            }
        }
        public async Task<IDataResult<Document>> GetAsync(int id)
        {
            try
            {
                return new SuccessDataResult<Document>(await documentDal.GetAsync(s=>s.Id==id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DocumentManager.GetAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Document>(null, CustomJObject.Instance.General.NotGet);
            }
        }
        public async Task<IDataResult<Document>> UpdateAsync(Document entity)
        {
            try
            {
                return new SuccessDataResult<Document>(await documentDal.UpdateAsync(entity), CustomJObject.Instance.General.Update);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "DocumentManager.UpdateAsync",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Document>(null, CustomJObject.Instance.General.NotUpdate);
            }
        }
    }
}
