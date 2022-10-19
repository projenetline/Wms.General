using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class ItemUnit:IBaseEntity
    {
        public ItemUnit()
        {
            ItemContents = new HashSet<ItemContent>();
            OrderSlipLines = new HashSet<OrderSlipLine>();
            PlanningSlipLines = new HashSet<PlanningSlipLine>();
            ProductionOrderLines = new HashSet<ProductionOrderLine>();
            ProductionOrders = new HashSet<ProductionOrder>();
            ReservationSlipLines = new HashSet<ReservationSlipLine>();
            SlipLines = new HashSet<SlipLine>();
            UnitBarcodes = new HashSet<UnitBarcode>();
            WorkOrderLines = new HashSet<WorkOrderLine>();
        }

        public int Id { get; set; }
        public int ItemId { get; set; }
        public string Code { get; set; }
        public short IsMasterUnit { get; set; }
        public decimal ConvFactor1 { get; set; }
        public decimal ConvFactor2 { get; set; }
        public string OldBarcode { get; set; }
        public short UnitNumber { get; set; }
        public decimal? Width { get; set; }
        public decimal? GrossWeight { get; set; }
        public decimal? Height { get; set; }
        public decimal? Length { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public decimal? GrossVolume { get; set; }
        public string CustomCode { get; set; }
        public short SlipPriority { get; set; }
        public short ReceivePriority { get; set; }
        public short ShipmentPriority { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Item Item { get; set; }
        public virtual ICollection<ItemContent> ItemContents { get; set; }
        public virtual ICollection<OrderSlipLine> OrderSlipLines { get; set; }
        public virtual ICollection<PlanningSlipLine> PlanningSlipLines { get; set; }
        public virtual ICollection<ProductionOrderLine> ProductionOrderLines { get; set; }
        public virtual ICollection<ProductionOrder> ProductionOrders { get; set; }
        public virtual ICollection<ReservationSlipLine> ReservationSlipLines { get; set; }
        public virtual ICollection<SlipLine> SlipLines { get; set; }
        public virtual ICollection<UnitBarcode> UnitBarcodes { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLines { get; set; }
    }
}
