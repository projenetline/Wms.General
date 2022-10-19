using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SysDivisionManager : ISysDivisionService
    {
        private readonly ISysDivisionDal sysDivisionDal;
        public SysDivisionManager(ISysDivisionDal sysDivisionDal)
        {
            this.sysDivisionDal = sysDivisionDal;
        }

        public Task<IDataResult<SysDivision>> CreateAsync(SysDivision entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysDivision>> DeleteAsync(SysDivision entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysDivision>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<SysDivision>> UpdateAsync(SysDivision entity)
        {
            throw new NotImplementedException();
        }
    }
}
