using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Core.Entities.Concrete
{
    public class OperationClaim:IBaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public ICollection<UserOperationClaim> UserOperationClaims { get; set; }
    }
}
