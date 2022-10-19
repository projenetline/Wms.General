using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class Item:IBaseEntity
    {
        public Item()
        {
            AddressItems = new HashSet<AddressItem>();
            InverseParentItem = new HashSet<Item>();
            ItemClassRelationClasses = new HashSet<ItemClassRelation>();
            ItemClassRelationItems = new HashSet<ItemClassRelation>();
            ItemContentItems = new HashSet<ItemContent>();
            ItemContentParentItems = new HashSet<ItemContent>();
            ItemParameters = new HashSet<ItemParameter>();
            ItemUnits = new HashSet<ItemUnit>();
            OrderSlipLineItems = new HashSet<OrderSlipLine>();
            OrderSlipLineVariants = new HashSet<OrderSlipLine>();
            PlanningSlipLineItems = new HashSet<PlanningSlipLine>();
            PlanningSlipLineVariants = new HashSet<PlanningSlipLine>();
            ProductionOrderLineItems = new HashSet<ProductionOrderLine>();
            ProductionOrderLineVariants = new HashSet<ProductionOrderLine>();
            ProductionOrders = new HashSet<ProductionOrder>();
            ReservationSlipLineItems = new HashSet<ReservationSlipLine>();
            ReservationSlipLineVariants = new HashSet<ReservationSlipLine>();
            SlipLineItems = new HashSet<SlipLine>();
            SlipLineVariants = new HashSet<SlipLine>();
            UnitBarcodes = new HashSet<UnitBarcode>();
            WorkOrderLineItems = new HashSet<WorkOrderLine>();
            WorkOrderLineVariants = new HashSet<WorkOrderLine>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string ItemGroupCode { get; set; }
        public string Name2 { get; set; }
        public string CustomCode { get; set; }
        public short WarrantyPeriod { get; set; }
        public short TrackingType { get; set; }
        public decimal? VatRate { get; set; }
        public decimal? ShelfLife { get; set; }
        public string IsoNumber { get; set; }
        public string GroupCode { get; set; }
        public string ManufacturerCode { get; set; }
        public int? SuppWarrantyPeriod { get; set; }
        public short CardType { get; set; }
        public short? CriticalShelfLife { get; set; }
        public string AbcClass { get; set; }
        public short QualityControl { get; set; }
        public short ColdStorage { get; set; }
        public string CustomCode1 { get; set; }
        public string CustomCode2 { get; set; }
        public string CustomCode3 { get; set; }
        public string CustomCode4 { get; set; }
        public string CustomCode5 { get; set; }
        public short ShipmentLife { get; set; }
        public short CriticalShipLife { get; set; }
        public short SupplyPeriod { get; set; }
        public short TrackingMethod { get; set; }
        public short NearTracking { get; set; }
        public short NearTrackingDay { get; set; }
        public int? ParentItemId { get; set; }
        public string ExportClassNumber { get; set; }
        public short ErpTrackingType { get; set; }
        public short CanConfigure { get; set; }
        public short InputOverageType { get; set; }
        public decimal? InputOverageLimit { get; set; }
        public short OutputOverageType { get; set; }
        public decimal? OutputOverageLimit { get; set; }
        public string AuthCode { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public short CanDeduct { get; set; }
        public string DeductCode { get; set; }
        public short SaleDeductionPart1 { get; set; }
        public short SaleDeductionPart2 { get; set; }
        public short PurchDeductionPart1 { get; set; }
        public short PurchDeductionPart2 { get; set; }

        public virtual Item ParentItem { get; set; }
        public virtual ICollection<AddressItem> AddressItems { get; set; }
        public virtual ICollection<Item> InverseParentItem { get; set; }
        public virtual ICollection<ItemClassRelation> ItemClassRelationClasses { get; set; }
        public virtual ICollection<ItemClassRelation> ItemClassRelationItems { get; set; }
        public virtual ICollection<ItemContent> ItemContentItems { get; set; }
        public virtual ICollection<ItemContent> ItemContentParentItems { get; set; }
        public virtual ICollection<ItemParameter> ItemParameters { get; set; }
        public virtual ICollection<ItemUnit> ItemUnits { get; set; }
        public virtual ICollection<OrderSlipLine> OrderSlipLineItems { get; set; }
        public virtual ICollection<OrderSlipLine> OrderSlipLineVariants { get; set; }
        public virtual ICollection<PlanningSlipLine> PlanningSlipLineItems { get; set; }
        public virtual ICollection<PlanningSlipLine> PlanningSlipLineVariants { get; set; }
        public virtual ICollection<ProductionOrderLine> ProductionOrderLineItems { get; set; }
        public virtual ICollection<ProductionOrderLine> ProductionOrderLineVariants { get; set; }
        public virtual ICollection<ProductionOrder> ProductionOrders { get; set; }
        public virtual ICollection<ReservationSlipLine> ReservationSlipLineItems { get; set; }
        public virtual ICollection<ReservationSlipLine> ReservationSlipLineVariants { get; set; }
        public virtual ICollection<SlipLine> SlipLineItems { get; set; }
        public virtual ICollection<SlipLine> SlipLineVariants { get; set; }
        public virtual ICollection<UnitBarcode> UnitBarcodes { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLineItems { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLineVariants { get; set; }
    }
}
