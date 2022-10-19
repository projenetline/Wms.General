using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class ItemParameter:IBaseEntity
    {
        public int Id { get; set; }
        public int WarehouseId { get; set; }
        public int ItemId { get; set; }
        public decimal MinQuantity { get; set; }
        public decimal MaxQuantity { get; set; }
        public decimal SafeQuantity { get; set; }
        public string AbcCode { get; set; }
        public short MinLevelAction { get; set; }
        public short MaxLevelAction { get; set; }
        public short SafeLevelAction { get; set; }
        public short NegativeLevelAction { get; set; }
        public short InputAction { get; set; }
        public short OutputAction { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Item Item { get; set; }
        public virtual SysWarehouse Warehouse { get; set; }
    }
}
