using Wms.Integration.Core.DataAccess.Abstract;
using Wms.Integration.Core.Entities.Concrete;

namespace Wms.Integration.DataAccess.Abstract
{
    public interface IUserDal:IEntityRepository<User>
    {
        Task<List<OperationClaim>> GetClaims(User user);
        Task<User> Get(string email);
    }
}
