using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.DataAccess.Utilities.Security.Jwt;
using Wms.Integration.Core.Entities.Concrete;
using Wms.Integration.Core.Entities.Dtos;

namespace Wms.Integration.Business.Abstract
{
    public interface IAuthService
    {
        Task<IDataResult<User>> Register(UserForRegisterDto userForRegisterDto, string password);
        Task<IDataResult<User>> Login(UserForLoginDto userForLoginDto);
        Task<IResult> UserExists(string email);
        Task<IDataResult<AccessToken>> CreateAccessToken(User user);
    }
}
