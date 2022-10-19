using Microsoft.IdentityModel.Tokens;
using System.Text;

namespace Wms.Integration.Core.DataAccess.Utilities.Security.Ecryption
{
    public class SecurityKeyHelper
    {
        public static SecurityKey CreateKey(string key)
        {
            return new SymmetricSecurityKey(Encoding.UTF8.GetBytes(key));
        }
    }
}
