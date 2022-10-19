using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class AddressItem:IBaseEntity
    {
        public int Id { get; set; }
        public int AddressId { get; set; }
        public int WarehouseId { get; set; }
        public int ItemId { get; set; }
        public int UnitId { get; set; }
        public string CustomCode { get; set; }
        public decimal? MinQuantity { get; set; }
        public decimal? MaxQuantity { get; set; }
        public short ShipmentPriority { get; set; }
        public short PlacementPriority { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysAddress Address { get; set; }
        public virtual Item Item { get; set; }
        public virtual SysWarehouse Warehouse { get; set; }
    }
}
