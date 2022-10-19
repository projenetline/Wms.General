using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysScript:IBaseEntity
    {
        public SysScript()
        {
            SysUsers = new HashSet<SysUser>();
        }

        public int Id { get; set; }
        public short ScriptType { get; set; }
        public string Name { get; set; }
        public string Content { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<SysUser> SysUsers { get; set; }
    }
}
