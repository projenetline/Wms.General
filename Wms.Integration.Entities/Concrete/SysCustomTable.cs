using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysCustomTable:IBaseEntity
    {
        public int Id { get; set; }
        public short RecordType { get; set; }
        public string TableName { get; set; }
        public string TableDetail { get; set; }
        public string Description { get; set; }
        public short Active { get; set; }
        public string AuthCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
    }
}
