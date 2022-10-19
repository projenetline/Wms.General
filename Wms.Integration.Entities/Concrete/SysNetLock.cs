using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysNetLock:IBaseEntity
    {
        public int Id { get; set; }
        public string FormName { get; set; }
        public string RecordId { get; set; }
        public string SessionCode { get; set; }
        public int CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public short Active { get; set; }

        public virtual SysUser CreatedByNavigation { get; set; }
    }
}
