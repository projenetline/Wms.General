using Microsoft.EntityFrameworkCore;
using Wms.Integration.Core.DataAccess.Concrete;
using Wms.Integration.Core.Entities.Concrete;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete.Contexts;

namespace Wms.Integration.DataAccess.Concrete
{
    public class EfUserDal : EfEntityRepository<User, WMSContext>, IUserDal
    {
        public async Task<User> Get(string userName)
        {
            using (WMSContext context = new WMSContext())
            {
                 return await context.Users.FirstOrDefaultAsync(s => s.UserName == userName);
                //return null;
            }
        }

        public async Task<List<OperationClaim>> GetClaims(User user)
        {
            using (WMSContext context = new WMSContext())
            {
                return await context.UserOperationClaims.Include(s => s.User).Include(z => z.OperationClaim).Where(z => z.UserId == user.Id).Select(s => s.OperationClaim).ToListAsync();
            }
        }
    }
}
