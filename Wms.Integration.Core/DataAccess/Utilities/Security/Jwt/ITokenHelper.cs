using Wms.Integration.Core.Entities.Concrete;

namespace Wms.Integration.Core.DataAccess.Utilities.Security.Jwt
{
    public interface ITokenHelper
    {
        AccessToken CreateToken(User user, List<OperationClaim> operationClaims);
    }
}
