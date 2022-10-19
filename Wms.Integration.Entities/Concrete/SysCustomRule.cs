using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysCustomRule:IBaseEntity
    {
        public SysCustomRule()
        {
            SysCustomRuleActions = new HashSet<SysCustomRuleAction>();
        }

        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public short Active { get; set; }
        public short AutoRun { get; set; }
        public short AutoRunObject { get; set; }
        public short AutoRunAction { get; set; }
        public short AutoRunEvent { get; set; }
        public short MenuBound { get; set; }
        public short MenuContext { get; set; }
        public short Scheduled { get; set; }
        public short ScheduleType { get; set; }
        public short ScheduleInterval { get; set; }
        public short SchedulePeriod { get; set; }
        public string ScheduleTime { get; set; }
        public string ScheduleWeekDay { get; set; }
        public string ScheduleDay { get; set; }
        public string ScheduleMonth { get; set; }
        public string AuthCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<SysCustomRuleAction> SysCustomRuleActions { get; set; }
    }
}
