using Microsoft.IdentityModel.Tokens;

namespace Wms.Integration.Core.DataAccess.Utilities.Security.Ecryption
{
    public class SigningCredentialsHelper
    {
        public static SigningCredentials CreateSigningCredentials(SecurityKey securityKey)
        {
            return new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256Signature);
        }
    }
}
