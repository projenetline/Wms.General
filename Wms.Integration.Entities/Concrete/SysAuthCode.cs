using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysAuthCode:IBaseEntity
    {
        public int Id { get; set; }
        public int? RoleId { get; set; }
        public int? UserId { get; set; }
        public short RecordType { get; set; }
        public string AuthCode { get; set; }
        public short Permission { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysRole Role { get; set; }
        public virtual SysUser User { get; set; }
    }
}
