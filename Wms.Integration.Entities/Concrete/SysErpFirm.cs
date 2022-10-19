using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysErpFirm:IBaseEntity
    {
        public SysErpFirm()
        {
            SysErpIntegrations = new HashSet<SysErpIntegration>();
            SysUserWarehouses = new HashSet<SysUserWarehouse>();
            SysUsers = new HashSet<SysUser>();
        }

        public int Id { get; set; }
        public int ErpId { get; set; }
        public int? ParentFirmId { get; set; }
        public int ErpFirmNumber { get; set; }
        public string ErpFirmName { get; set; }
        public int? ErpBranchNumber { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysErp Erp { get; set; }
        public virtual ICollection<SysErpIntegration> SysErpIntegrations { get; set; }
        public virtual ICollection<SysUserWarehouse> SysUserWarehouses { get; set; }
        public virtual ICollection<SysUser> SysUsers { get; set; }
    }
}
