using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysUserWarehouse:IBaseEntity
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int ErpId { get; set; }
        public int ErpFirmId { get; set; }
        public int WarehouseId { get; set; }
        public short IsDefault { get; set; }
        public short InputOutputRight { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysErpFirm ErpFirm { get; set; }
        public virtual SysUser User { get; set; }
        public virtual SysWarehouse Warehouse { get; set; }
    }
}
