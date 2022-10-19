using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysPasswordPolicy:IBaseEntity
    {
        public SysPasswordPolicy()
        {
            SysRoles = new HashSet<SysRole>();
            SysUsers = new HashSet<SysUser>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public string PasswordExpression { get; set; }
        public short FailedAttempts { get; set; }
        public short RememberCount { get; set; }
        public short MinimumAge { get; set; }
        public short MaximumAge { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<SysRole> SysRoles { get; set; }
        public virtual ICollection<SysUser> SysUsers { get; set; }
    }
}
