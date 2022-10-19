using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SlipLine:IBaseEntity
    {
        public SlipLine()
        {
            TransactionDetails = new HashSet<TransactionDetail>();
        }

        public int Id { get; set; }
        public short SlipType { get; set; }
        public int SlipId { get; set; }
        public DateTime LineDate { get; set; }
        public int LineNumber { get; set; }
        public int? OrderSlipLineId { get; set; }
        public int? PlanningSlipLineId { get; set; }
        public int? ProdOrderLineId { get; set; }
        public int WorkOrderLineId { get; set; }
        public int WarehouseId { get; set; }
        public int? Warehouse2Id { get; set; }
        public int? DepartmentId { get; set; }
        public int? DivisionId { get; set; }
        public int? FactoryId { get; set; }
        public int? Department2Id { get; set; }
        public int? Division2Id { get; set; }
        public int? Factory2Id { get; set; }
        public int? ArpId { get; set; }
        public int? ItemId { get; set; }
        public int? VariantId { get; set; }
        public int? UnitId { get; set; }
        public int? ShipmentAddressId { get; set; }
        public int? AssignedTo { get; set; }
        public string Description { get; set; }
        public decimal Quantity { get; set; }
        public int AddressId { get; set; }
        public int? Address2Id { get; set; }
        public string PropertyBarcode { get; set; }
        public decimal ConvFactor1 { get; set; }
        public decimal ConvFactor2 { get; set; }
        public string CustomCode { get; set; }
        public int? ProjectId { get; set; }
        public int? ContainerId { get; set; }
        public int? ChildContainerId { get; set; }
        public int? Container2Id { get; set; }
        public int? ChildContainer2Id { get; set; }
        public int? InsuranceDuration { get; set; }
        public DateTime? InsuranceExpDate { get; set; }
        public int StateId { get; set; }
        public short Approval { get; set; }
        public string AuthCode { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysAddress Address { get; set; }
        public virtual SysAddress Address2 { get; set; }
        public virtual Arp Arp { get; set; }
        public virtual SysUser AssignedToNavigation { get; set; }
        public virtual Container ChildContainer { get; set; }
        public virtual Container ChildContainer2 { get; set; }
        public virtual Container Container { get; set; }
        public virtual Container Container2 { get; set; }
        public virtual Item Item { get; set; }
        public virtual OrderSlipLine OrderSlipLine { get; set; }
        public virtual PlanningSlipLine PlanningSlipLine { get; set; }
        public virtual ProductionOrderLine ProdOrderLine { get; set; }
        public virtual Project Project { get; set; }
        public virtual Slip Slip { get; set; }
        public virtual SysCustomState State { get; set; }
        public virtual ItemUnit Unit { get; set; }
        public virtual Item Variant { get; set; }
        public virtual SysWarehouse Warehouse { get; set; }
        public virtual SysWarehouse Warehouse2 { get; set; }
        public virtual WorkOrderLine WorkOrderLine { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
