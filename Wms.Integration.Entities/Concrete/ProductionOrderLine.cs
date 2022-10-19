using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class ProductionOrderLine:IBaseEntity
    {
        public ProductionOrderLine()
        {
            ReservationSlipLines = new HashSet<ReservationSlipLine>();
            SlipLines = new HashSet<SlipLine>();
            TransactionDetails = new HashSet<TransactionDetail>();
            WorkOrderLines = new HashSet<WorkOrderLine>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public int Id { get; set; }
        public int SlipId { get; set; }
        public short SlipType { get; set; }
        public string LineNumber { get; set; }
        public int ItemId { get; set; }
        public int? VariantId { get; set; }
        public int UnitId { get; set; }
        public decimal ConvFactor1 { get; set; }
        public decimal ConvFactor2 { get; set; }
        public int? FactoryId { get; set; }
        public int? ArpId { get; set; }
        public int? ProjectId { get; set; }
        public string CustomCode { get; set; }
        public string DocumentNumber { get; set; }
        public decimal PlannedQuantity { get; set; }
        public DateTime? PlannedStartDate { get; set; }
        public DateTime? PlannedEndDate { get; set; }
        public DateTime? PlannedTime { get; set; }
        public DateTime? ActualStartDate { get; set; }
        public DateTime? ActualEndDate { get; set; }
        public DateTime? ActualTime { get; set; }
        public short ProductionStatus { get; set; }
        public string AuthCode { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Arp Arp { get; set; }
        public virtual SysFactory Factory { get; set; }
        public virtual Item Item { get; set; }
        public virtual Project Project { get; set; }
        public virtual ProductionOrder Slip { get; set; }
        public virtual ItemUnit Unit { get; set; }
        public virtual Item Variant { get; set; }
        public virtual ICollection<ReservationSlipLine> ReservationSlipLines { get; set; }
        public virtual ICollection<SlipLine> SlipLines { get; set; }
        public virtual ICollection<TransactionDetail> TransactionDetails { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLines { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
