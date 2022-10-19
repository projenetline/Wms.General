using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class SlipManager : ISlipService
    {
        private readonly ISlipDal slipDal;
        public SlipManager(ISlipDal slipDal)
        {
            this.slipDal = slipDal;
        }
        public Task<IDataResult<Slip>> CreateAsync(Slip entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Slip>> DeleteAsync(Slip entity)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Slip>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Slip>> UpdateAsync(Slip entity)
        {
            throw new NotImplementedException();
        }
    }
}
