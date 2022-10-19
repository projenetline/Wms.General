using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Core.Entities.Concrete
{
    public class User:IBaseEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public bool Status { get; set; }
        public ICollection<UserOperationClaim> OperationClaims { get; set; }
    }
}
