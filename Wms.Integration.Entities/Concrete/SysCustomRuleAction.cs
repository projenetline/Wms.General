using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysCustomRuleAction:IBaseEntity
    {
        public int Id { get; set; }
        public int RuleId { get; set; }
        public short ActionNumber { get; set; }
        public short ActionType { get; set; }
        public short PreAction { get; set; }
        public short PreCondition { get; set; }
        public short IsRuleResult { get; set; }
        public string Template { get; set; }

        public virtual SysCustomRule Rule { get; set; }
    }
}
