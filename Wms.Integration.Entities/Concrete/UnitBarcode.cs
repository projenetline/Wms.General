using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class UnitBarcode:IBaseEntity
    {
        public int Id { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public string Barcode { get; set; }
        public int? ArpId { get; set; }
        public short Active { get; set; }
        public short BarcodeType { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Arp Arp { get; set; }
        public virtual Item Item { get; set; }
        public virtual ItemUnit Unit { get; set; }
    }
}
