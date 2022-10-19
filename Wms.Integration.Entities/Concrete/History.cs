using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class History:IBaseEntity
    {
        public int Id { get; set; }
        public short ActionType { get; set; }
        public short RecordType { get; set; }
        public int RecordId { get; set; }
        public string TransactionGuid { get; set; }
        public string Description { get; set; }
        public string RecordContent { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
    }
}
