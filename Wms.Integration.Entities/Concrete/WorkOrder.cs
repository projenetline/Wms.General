using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class WorkOrder:IBaseEntity
    {
        public WorkOrder()
        {
            ReservationSlips = new HashSet<ReservationSlip>();
            Slips = new HashSet<Slip>();
            WorkOrderLines = new HashSet<WorkOrderLine>();
        }

        public int Id { get; set; }
        public short SlipType { get; set; }
        public int? CustomSlipTypeId { get; set; }
        public int? CarrierId { get; set; }
        public DateTime SlipDate { get; set; }
        public string SlipNumber { get; set; }
        public int? ArpId { get; set; }
        public int? DeliveryArpId { get; set; }
        public int? ShipmentAddressId { get; set; }
        public int WarehouseId { get; set; }
        public int? Warehouse2Id { get; set; }
        public int? OrderSlipId { get; set; }
        public int? PlanningSlipId { get; set; }
        public int? ProductionOrderId { get; set; }
        public int? ProdOrderLineId { get; set; }
        public int? ParentWorkOrderId { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string DocumentNumber { get; set; }
        public string DispatchNumber { get; set; }
        public string CustomCode { get; set; }
        public int? VehicleId { get; set; }
        public int? DriverId { get; set; }
        public string DeclarationNumber { get; set; }
        public string ShipmentNumber { get; set; }
        public DateTime? CompletedDate { get; set; }
        public int? CompletedBy { get; set; }
        public int? DepartmentId { get; set; }
        public int? DivisionId { get; set; }
        public int? FactoryId { get; set; }
        public int? Department2Id { get; set; }
        public int? Division2Id { get; set; }
        public int? Factory2Id { get; set; }
        public int? SalesPersonId { get; set; }
        public DateTime? DocumentDate { get; set; }
        public int? ProjectId { get; set; }
        public short Priority { get; set; }
        public int PrintCount { get; set; }
        public int StateId { get; set; }
        public string AuthCode { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Arp Arp { get; set; }
        public virtual SysCustomSlipType CustomSlipType { get; set; }
        public virtual Arp DeliveryArp { get; set; }
        public virtual SysDepartment Department { get; set; }
        public virtual SysDivision Division { get; set; }
        public virtual Driver Driver { get; set; }
        public virtual SysFactory Factory { get; set; }
        public virtual OrderSlip OrderSlip { get; set; }
        public virtual PlanningSlip PlanningSlip { get; set; }
        public virtual ProductionOrderLine ProdOrderLine { get; set; }
        public virtual ProductionOrder ProductionOrder { get; set; }
        public virtual Project Project { get; set; }
        public virtual SalesPerson SalesPerson { get; set; }
        public virtual ShipmentAddress ShipmentAddress { get; set; }
        public virtual SysCustomState State { get; set; }
        public virtual Vehicle Vehicle { get; set; }
        public virtual SysWarehouse Warehouse { get; set; }
        public virtual SysWarehouse Warehouse2 { get; set; }
        public virtual ICollection<ReservationSlip> ReservationSlips { get; set; }
        public virtual ICollection<Slip> Slips { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLines { get; set; }
    }
}
