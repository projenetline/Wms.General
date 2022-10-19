using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class FormLayoutManager : IFormLayoutService
    {
        private readonly IFormLayoutDal formLayoutDal;
        public FormLayoutManager(IFormLayoutDal formLayoutDal)
        {
            this.formLayoutDal = formLayoutDal;
        }
        public Task<IDataResult<FormLayout>> CreateAsync(FormLayout entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<FormLayout>> DeleteAsync(FormLayout entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<FormLayout>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<FormLayout>> UpdateAsync(FormLayout entity)
        {
            throw new NotImplementedException();
        }
    }
}
