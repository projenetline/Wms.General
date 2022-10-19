using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysParameter:IBaseEntity
    {
        public int Id { get; set; }
        public short ParameterType { get; set; }
        public string ParameterTypeId { get; set; }
        public int ParameterNumber { get; set; }
        public string ParameterValue { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
