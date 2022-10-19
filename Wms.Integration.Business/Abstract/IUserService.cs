using Wms.Integration.Core.Entities.Concrete;

namespace Wms.Integration.Business.Abstract
{
    public interface IUserService
    {
        Task<List<OperationClaim>> GetClaims(User user);
        Task<User> GetByUserName(string userName);
        Task Add(User user);
    }
}
