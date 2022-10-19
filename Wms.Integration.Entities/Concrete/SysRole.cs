using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysRole:IBaseEntity
    {
        public SysRole()
        {
            FormLayouts = new HashSet<FormLayout>();
            SysAuthCodes = new HashSet<SysAuthCode>();
            SysMenuRights = new HashSet<SysMenuRight>();
            SysUsers = new HashSet<SysUser>();
        }

        public int Id { get; set; }
        public string Description { get; set; }
        public int? PasswordPolicyId { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysPasswordPolicy PasswordPolicy { get; set; }
        public virtual ICollection<FormLayout> FormLayouts { get; set; }
        public virtual ICollection<SysAuthCode> SysAuthCodes { get; set; }
        public virtual ICollection<SysMenuRight> SysMenuRights { get; set; }
        public virtual ICollection<SysUser> SysUsers { get; set; }
    }
}
