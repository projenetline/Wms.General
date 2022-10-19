using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysWarehouseFloor:IBaseEntity
    {
        public SysWarehouseFloor()
        {
            SysAddresses = new HashSet<SysAddress>();
            SysWarehouseBlocks = new HashSet<SysWarehouseBlock>();
            SysWarehouseZones = new HashSet<SysWarehouseZone>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int WarehouseId { get; set; }
        public string AuthCode { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysWarehouse Warehouse { get; set; }
        public virtual ICollection<SysAddress> SysAddresses { get; set; }
        public virtual ICollection<SysWarehouseBlock> SysWarehouseBlocks { get; set; }
        public virtual ICollection<SysWarehouseZone> SysWarehouseZones { get; set; }
    }
}
