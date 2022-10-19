using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class ArpManager : IArpService
    {
        private readonly IArpDal arpDal;
        public ArpManager(IArpDal arpDal)
        {
            this.arpDal = arpDal;
        }
        public Task<IDataResult<Arp>> CreateAsync(Arp entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<Arp>> DeleteAsync(Arp entity)
        {
            throw new NotImplementedException();
        }
        public Task<IDataResult<Arp>> GetAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IDataResult<Arp>> UpdateAsync(Arp entity)
        {
            throw new NotImplementedException();
        }
    }
}
