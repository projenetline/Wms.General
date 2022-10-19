using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysCustomReport:IBaseEntity
    {
        public SysCustomReport()
        {
            SysCustomListColumns = new HashSet<SysCustomListColumn>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short ReportType { get; set; }
        public string QueryContent { get; set; }
        public string DesignContent { get; set; }
        public short TemplateNumber { get; set; }
        public int MenuNumber { get; set; }
        public short IsDefault { get; set; }
        public string AuthCode { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<SysCustomListColumn> SysCustomListColumns { get; set; }
    }
}
