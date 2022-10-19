using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class OrderSlipLine:IBaseEntity
    {
        public OrderSlipLine()
        {
            ReservationSlipLines = new HashSet<ReservationSlipLine>();
            SlipLines = new HashSet<SlipLine>();
            TransactionDetails = new HashSet<TransactionDetail>();
            WorkOrderLines = new HashSet<WorkOrderLine>();
            DecompositionLines= new HashSet<DecompositionLine>();
        }

        public int Id { get; set; }
        public short SlipType { get; set; }
        public int SlipId { get; set; }
        public int LineNumber { get; set; }
        public DateTime LineDate { get; set; }
        public int ItemId { get; set; }
        public int? VariantId { get; set; }
        public int UnitId { get; set; }
        public int? ShipmentAddressId { get; set; }
        public decimal Quantity { get; set; }
        public string Description { get; set; }
        public string CustomCode { get; set; }
        public DateTime? DeliveryDate { get; set; }
        public string PropertyBarcode { get; set; }
        public int? ProjectId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DivisionId { get; set; }
        public int? FactoryId { get; set; }
        public int? Department2Id { get; set; }
        public int? Division2Id { get; set; }
        public int? Factory2Id { get; set; }
        public int? ArpId { get; set; }
        public int WarehouseId { get; set; }
        public int? Warehouse2Id { get; set; }
        public int? AssignedTo { get; set; }
        public short DocumentType { get; set; }
        public decimal? ConvFactor1 { get; set; }
        public decimal? ConvFactor2 { get; set; }
        public short Priority { get; set; }
        public short Closed { get; set; }
        public short ShipmentStatus { get; set; }
        public int StateId { get; set; }
        public string AuthCode { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public virtual Arp Arp { get; set; }
        public virtual SysUser AssignedToNavigation { get; set; }
        public virtual SysDepartment Department { get; set; }
        public virtual Item Item { get; set; }
        public virtual Project Project { get; set; }
        public virtual OrderSlip Slip { get; set; }
        public virtual SysCustomState State { get; set; }
        public virtual ItemUnit Unit { get; set; }
        public virtual Item Variant { get; set; }
        public virtual SysWarehouse Warehouse { get; set; }
        public virtual SysWarehouse Warehouse2 { get; set; }
        public virtual ICollection<DecompositionLine> DecompositionLines { get; set; }
        public virtual ICollection<ReservationSlipLine> ReservationSlipLines { get; set; }
        public virtual ICollection<SlipLine> SlipLines { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLines { get; set; }
    }
}
