using Wms.Integration.Business.Abstract;
using Wms.Integration.Business.Messages;
using Wms.Integration.Core.DataAccess.Utilities.Hashing;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.DataAccess.Utilities.Security.Jwt;
using Wms.Integration.Core.Entities.Concrete;
using Wms.Integration.Core.Entities.Dtos;

namespace Wms.Integration.Business.Concrete
{
    public class AuthManager : IAuthService
    {
        private readonly IUserService _userService;
        private ITokenHelper _tokenHelper;
        public AuthManager(IUserService userService, ITokenHelper tokenHelper)
        {
            _userService = userService;
            _tokenHelper = tokenHelper;
        }
        public async Task<IDataResult<AccessToken>> CreateAccessToken(User user)
        {
            var claims = await _userService.GetClaims(user);
            var accessToken = _tokenHelper.CreateToken(user, claims);
            return new SuccessDataResult<AccessToken>(accessToken, MessagingHelper.AccessTokenCreated);
        }
        public async Task<IDataResult<User>> Login(UserForLoginDto userForLoginDto)
        {
            User userToCheck = await _userService.GetByUserName(userForLoginDto.UserName);
            if (userToCheck == null)
            {
                return new ErrorDataResult<User>(MessagingHelper.UserNotFound);
            }
            if (!HashingHelper.VerifyPasswordHash(userForLoginDto.Password, userToCheck.PasswordHash, userToCheck.PasswordSalt))
            {
                return new ErrorDataResult<User>(MessagingHelper.UserPasswordError);
            }
            return new SuccessDataResult<User>(userToCheck, MessagingHelper.UserSuccessLogin);
        }
        public async Task<IDataResult<User>> Register(UserForRegisterDto userForRegisterDto, string password)
        {
            byte[] passwordHash, passwordSalt;
            HashingHelper.CreatePasswordHash(password, out passwordHash, out passwordSalt);
            User user = new User
            {
                UserName = userForRegisterDto.UserName,
                FirstName = userForRegisterDto.FirstName,
                LastName = userForRegisterDto.LastName,
                PasswordHash = passwordHash,
                PasswordSalt = passwordSalt,
                Status = true
            };
            await _userService.Add(user);
            return new SuccessDataResult<User>(user, MessagingHelper.UserRegistered);
        }
        public async Task<IResult> UserExists(string email)
        {
            if (await _userService.GetByUserName(email) != null)
            {
                return new ErrorResult(MessagingHelper.UserAlreadyExists);
            }
            return new SuccessResult();
        }
    }
}
