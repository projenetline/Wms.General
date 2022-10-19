using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysPasswordHistory:IBaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string Password { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }

        public virtual SysUser User { get; set; }
    }
}
