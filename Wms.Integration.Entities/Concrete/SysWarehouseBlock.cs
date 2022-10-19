using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysWarehouseBlock:IBaseEntity
    {
        public int Id { get; set; }
        public int WarehouseId { get; set; }
        public int FloorId { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public short BlockType { get; set; }
        public short LocationZ { get; set; }
        public short LocationX { get; set; }
        public short LocationY { get; set; }
        public short Direction { get; set; }
        public decimal? Height { get; set; }
        public decimal? Width { get; set; }
        public decimal? Depth { get; set; }
        public short BlockCount { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysWarehouseFloor Floor { get; set; }
        public virtual SysWarehouse Warehouse { get; set; }
    }
}
