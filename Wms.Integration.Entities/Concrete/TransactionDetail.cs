using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class TransactionDetail:IBaseEntity
    {
        public int Id { get; set; }
        public short IoCode { get; set; }
        public short LineType { get; set; }
        public short TrCode { get; set; }
        public int? ParentLineId { get; set; }
        public int? OrderSlipId { get; set; }
        public int? PlanningSlipId { get; set; }
        public int? ProductionOrderId { get; set; }
        public int? WorkOrderId { get; set; }
        public int? SlipId { get; set; }
        public int? ReservationSlipId { get; set; }
        public int? OrderSlipLineId { get; set; }
        public int? PlanningSlipLineId { get; set; }
        public int? ProdOrderLineId { get; set; }
        public int? WorkOrderLineId { get; set; }
        public int? SlipLineId { get; set; }
        public int? ReservationLineId { get; set; }
        public DateTime LineDate { get; set; }
        public DateTime LineDay { get; set; }
        public int WarehouseId { get; set; }
        public int? ArpId { get; set; }
        public int ItemId { get; set; }
        public int? VariantId { get; set; }
        public int UnitId { get; set; }
        public decimal Quantity { get; set; }
        public int? AddressId { get; set; }
        public decimal ConvFactor1 { get; set; }
        public decimal ConvFactor2 { get; set; }
        public DateTime? ExpirationDate { get; set; }
        public DateTime? ProductionDate { get; set; }
        public string TrackingNumber { get; set; }
        public int? ContainerId { get; set; }
        public int? ChildContainerId { get; set; }
        public short Active { get; set; }

        public virtual OrderSlipLine OrderSlipLine { get; set; }
        public virtual PlanningSlipLine PlanningSlipLine { get; set; }
        public virtual ProductionOrderLine ProdOrderLine { get; set; }
        public virtual ReservationSlipLine ReservationLine { get; set; }
        public virtual SlipLine SlipLine { get; set; }
        public virtual WorkOrderLine WorkOrderLine { get; set; }
    }
}
