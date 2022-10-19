using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Entities.Concrete;
using Wms.Integration.DataAccess.Abstract;

namespace Wms.Integration.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal userDal;
        public UserManager(IUserDal userDal)
        {
            this.userDal = userDal;
        }
        public async Task Add(User user)
        {
            await userDal.CreateAsync(user);
        }

        public async Task<User> GetByUserName(string userName)
        {
           return  await userDal.Get(userName);
        }

        public async Task<List<OperationClaim>> GetClaims(User user)
        {
            return await userDal.GetClaims(user);
        }
    }
}
