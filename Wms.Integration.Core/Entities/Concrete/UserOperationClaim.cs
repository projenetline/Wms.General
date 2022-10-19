using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Core.Entities.Concrete
{
    public class UserOperationClaim:IBaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int OperationClaimId { get; set; }
        public virtual User User { get; set; }
        public virtual OperationClaim OperationClaim { get; set; }
    }
}
