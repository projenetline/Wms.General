using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class ReservationSlipLine:IBaseEntity
    {
        public ReservationSlipLine()
        {
            TransactionDetails = new HashSet<TransactionDetail>();
        }

        public int Id { get; set; }
        public short SlipType { get; set; }
        public int SlipId { get; set; }
        public int WarehouseId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DivisionId { get; set; }
        public int? FactoryId { get; set; }
        public int LineNumber { get; set; }
        public DateTime LineDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int? OrderSlipLineId { get; set; }
        public int? PlanningSlipLineId { get; set; }
        public int? WorkOrderLineId { get; set; }
        public int? ProdOrderLineId { get; set; }
        public int? ArpId { get; set; }
        public int? ItemId { get; set; }
        public int? VariantId { get; set; }
        public int? UnitId { get; set; }
        public decimal? Quantity { get; set; }
        public string Description { get; set; }
        public int? AddressId { get; set; }
        public int? ContainerId { get; set; }
        public int? ChildContainerId { get; set; }
        public decimal ConvFactor1 { get; set; }
        public decimal ConvFactor2 { get; set; }
        public string CustomCode { get; set; }
        public int StateId { get; set; }
        public string AuthCode { get; set; }
        public int? BlockingTypeId { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysAddress Address { get; set; }
        public virtual Arp Arp { get; set; }
        public virtual SysBlockingType BlockingType { get; set; }
        public virtual Container ChildContainer { get; set; }
        public virtual Container Container { get; set; }
        public virtual Item Item { get; set; }
        public virtual OrderSlipLine OrderSlipLine { get; set; }
        public virtual PlanningSlipLine PlanningSlipLine { get; set; }
        public virtual ProductionOrderLine ProdOrderLine { get; set; }
        public virtual ReservationSlip Slip { get; set; }
        public virtual SysCustomState State { get; set; }
        public virtual ItemUnit Unit { get; set; }
        public virtual Item Variant { get; set; }
        public virtual SysWarehouse Warehouse { get; set; }
        public virtual WorkOrderLine WorkOrderLine { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
    }
}
