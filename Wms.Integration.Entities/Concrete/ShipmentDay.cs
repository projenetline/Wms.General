using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class ShipmentDay:IBaseEntity
    {
        public int Id { get; set; }
        public int? ArpId { get; set; }
        public int? ShipmentAddressId { get; set; }
        public short ShipmentDay1 { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? FinishTime { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Arp Arp { get; set; }
        public virtual ShipmentAddress ShipmentAddress { get; set; }
    }
}
