using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class DocumentManager : IDocumentService
    {
        private readonly IDocumentDal documentDal;
        public DocumentManager(IDocumentDal documentDal)
        {
            this.documentDal = documentDal;
        }
        public Task<IDataResult<Document>> CreateAsync(Document entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<Document>> DeleteAsync(Document entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<Document>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<IList<Document>>> GetListAsync(Document entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<Document>> UpdateAsync(Document entity)
        {
            throw new NotImplementedException();
        }
    }
}
