using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysSession:IBaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SessionCode { get; set; }
        public int SpId { get; set; }

        public virtual SysUser User { get; set; }
    }
}
