using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysUser:IBaseEntity
    {
        public SysUser()
        {
            Drivers = new HashSet<Driver>();
            FormLayouts = new HashSet<FormLayout>();
            InverseBoss = new HashSet<SysUser>();
            OrderSlipLines = new HashSet<OrderSlipLine>();
            PlanningSlipLines = new HashSet<PlanningSlipLine>();
            SlipLines = new HashSet<SlipLine>();
            SysAuthCodes = new HashSet<SysAuthCode>();
            SysNetLocks = new HashSet<SysNetLock>();
            SysPasswordHistories = new HashSet<SysPasswordHistory>();
            SysSessions = new HashSet<SysSession>();
            SysUserWarehouses = new HashSet<SysUserWarehouse>();
            WorkOrderLines = new HashSet<WorkOrderLine>();
        }

        public int Id { get; set; }
        public string UserName { get; set; }
        public string Idmusername { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Password { get; set; }
        public string CustomCode { get; set; }
        public string EnabledMenuCodes { get; set; }
        public string DisabledMenuCodes { get; set; }
        public int RoleId { get; set; }
        public int? PrinterId { get; set; }
        public int? ScriptId { get; set; }
        public int? BossId { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string Email { get; set; }
        public short? TerminalLanguage { get; set; }
        public int? DefaultErpId { get; set; }
        public int? DefaultErpFirmId { get; set; }
        public int? DefaultWarehouseId { get; set; }
        public int? PasswordPolicyId { get; set; }
        public short Sso { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysUser Boss { get; set; }
        public virtual SysErp DefaultErp { get; set; }
        public virtual SysErpFirm DefaultErpFirm { get; set; }
        public virtual SysWarehouse DefaultWarehouse { get; set; }
        public virtual SysPasswordPolicy PasswordPolicy { get; set; }
        public virtual SysPrinter Printer { get; set; }
        public virtual SysRole Role { get; set; }
        public virtual SysScript Script { get; set; }
        public virtual ICollection<Driver> Drivers { get; set; }
        public virtual ICollection<FormLayout> FormLayouts { get; set; }
        public virtual ICollection<SysUser> InverseBoss { get; set; }
        public virtual ICollection<OrderSlipLine> OrderSlipLines { get; set; }
        public virtual ICollection<PlanningSlipLine> PlanningSlipLines { get; set; }
        public virtual ICollection<SlipLine> SlipLines { get; set; }
        public virtual ICollection<SysAuthCode> SysAuthCodes { get; set; }
        public virtual ICollection<SysNetLock> SysNetLocks { get; set; }
        public virtual ICollection<SysPasswordHistory> SysPasswordHistories { get; set; }
        public virtual ICollection<SysSession> SysSessions { get; set; }
        public virtual ICollection<SysUserWarehouse> SysUserWarehouses { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLines { get; set; }
    }
}
