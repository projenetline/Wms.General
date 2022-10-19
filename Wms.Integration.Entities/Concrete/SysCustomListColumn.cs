using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysCustomListColumn:IBaseEntity
    {
        public int Id { get; set; }
        public string Description { get; set; }
        public int MenuNumber { get; set; }
        public int? ReportId { get; set; }
        public string ReportColumns { get; set; }
        public string ReportParameters { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysCustomReport Report { get; set; }
    }
}
