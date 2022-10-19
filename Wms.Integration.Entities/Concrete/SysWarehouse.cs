using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysWarehouse:IBaseEntity
    {
        public SysWarehouse()
        {
            AddressItems = new HashSet<AddressItem>();
            ItemParameters = new HashSet<ItemParameter>();
            OrderSlipLineWarehouse2s = new HashSet<OrderSlipLine>();
            OrderSlipLineWarehouses = new HashSet<OrderSlipLine>();
            OrderSlipWarehouse2s = new HashSet<OrderSlip>();
            OrderSlipWarehouses = new HashSet<OrderSlip>();
            PlanningSlipLineWarehouse2s = new HashSet<PlanningSlipLine>();
            PlanningSlipLineWarehouses = new HashSet<PlanningSlipLine>();
            PlanningSlipWarehouse2s = new HashSet<PlanningSlip>();
            PlanningSlipWarehouses = new HashSet<PlanningSlip>();
            ReservationSlipLines = new HashSet<ReservationSlipLine>();
            Shifts = new HashSet<Shift>();
            SlipLineWarehouse2s = new HashSet<SlipLine>();
            SlipLineWarehouses = new HashSet<SlipLine>();
            SlipWarehouse2s = new HashSet<Slip>();
            SlipWarehouses = new HashSet<Slip>();
            SysAddresses = new HashSet<SysAddress>();
            SysUserWarehouses = new HashSet<SysUserWarehouse>();
            SysUsers = new HashSet<SysUser>();
            SysWarehouseBlocks = new HashSet<SysWarehouseBlock>();
            SysWarehouseFloors = new HashSet<SysWarehouseFloor>();
            SysWarehouseZones = new HashSet<SysWarehouseZone>();
            Vehicles = new HashSet<Vehicle>();
            WorkOrderLineWarehouse2s = new HashSet<WorkOrderLine>();
            WorkOrderLineWarehouses = new HashSet<WorkOrderLine>();
            WorkOrderWarehouse2s = new HashSet<WorkOrder>();
            WorkOrderWarehouses = new HashSet<WorkOrder>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string Fax { get; set; }
        public string Description { get; set; }
        public int? DivisionId { get; set; }
        public int? DepartmentId { get; set; }
        public int? FactoryId { get; set; }
        public string CostGroup { get; set; }
        public string CustomCode { get; set; }
        public decimal? Width { get; set; }
        public decimal? Depth { get; set; }
        public decimal? Height { get; set; }
        public string AuthCode { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysDepartment Department { get; set; }
        public virtual SysDivision Division { get; set; }
        public virtual SysFactory Factory { get; set; }
        public virtual ICollection<AddressItem> AddressItems { get; set; }
        public virtual ICollection<ItemParameter> ItemParameters { get; set; }
        public virtual ICollection<OrderSlipLine> OrderSlipLineWarehouse2s { get; set; }
        public virtual ICollection<OrderSlipLine> OrderSlipLineWarehouses { get; set; }
        public virtual ICollection<OrderSlip> OrderSlipWarehouse2s { get; set; }
        public virtual ICollection<OrderSlip> OrderSlipWarehouses { get; set; }
        public virtual ICollection<PlanningSlipLine> PlanningSlipLineWarehouse2s { get; set; }
        public virtual ICollection<PlanningSlipLine> PlanningSlipLineWarehouses { get; set; }
        public virtual ICollection<PlanningSlip> PlanningSlipWarehouse2s { get; set; }
        public virtual ICollection<PlanningSlip> PlanningSlipWarehouses { get; set; }
        public virtual ICollection<ReservationSlipLine> ReservationSlipLines { get; set; }
        public virtual ICollection<Shift> Shifts { get; set; }
        public virtual ICollection<SlipLine> SlipLineWarehouse2s { get; set; }
        public virtual ICollection<SlipLine> SlipLineWarehouses { get; set; }
        public virtual ICollection<Slip> SlipWarehouse2s { get; set; }
        public virtual ICollection<Slip> SlipWarehouses { get; set; }
        public virtual ICollection<SysAddress> SysAddresses { get; set; }
        public virtual ICollection<SysUserWarehouse> SysUserWarehouses { get; set; }
        public virtual ICollection<SysUser> SysUsers { get; set; }
        public virtual ICollection<SysWarehouseBlock> SysWarehouseBlocks { get; set; }
        public virtual ICollection<SysWarehouseFloor> SysWarehouseFloors { get; set; }
        public virtual ICollection<SysWarehouseZone> SysWarehouseZones { get; set; }
        public virtual ICollection<Vehicle> Vehicles { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLineWarehouse2s { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLineWarehouses { get; set; }
        public virtual ICollection<WorkOrder> WorkOrderWarehouse2s { get; set; }
        public virtual ICollection<WorkOrder> WorkOrderWarehouses { get; set; }
    }
}
