using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class Arp:IBaseEntity
    {
        public Arp()
        {
            OrderSlipArps = new HashSet<OrderSlip>();
            OrderSlipDeliveryArps = new HashSet<OrderSlip>();
            OrderSlipLines = new HashSet<OrderSlipLine>();
            PlanningSlipArps = new HashSet<PlanningSlip>();
            PlanningSlipDeliveryArps = new HashSet<PlanningSlip>();
            PlanningSlipLines = new HashSet<PlanningSlipLine>();
            ProductionOrderLines = new HashSet<ProductionOrderLine>();
            ProductionOrders = new HashSet<ProductionOrder>();
            ReservationSlipLines = new HashSet<ReservationSlipLine>();
            ShipmentDays = new HashSet<ShipmentDay>();
            SlipArps = new HashSet<Slip>();
            SlipDeliveryArps = new HashSet<Slip>();
            SlipLines = new HashSet<SlipLine>();
            UnitBarcodes = new HashSet<UnitBarcode>();
            WorkOrderArps = new HashSet<WorkOrder>();
            WorkOrderDeliveryArps = new HashSet<WorkOrder>();
            WorkOrderLines = new HashSet<WorkOrderLine>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Title { get; set; }
        public string CustomCode { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string Town { get; set; }
        public string City { get; set; }
        public string Country { get; set; }
        public string PostCode { get; set; }
        public string PhoneNumber1 { get; set; }
        public string PhoneNumber2 { get; set; }
        public string FaxNumber1 { get; set; }
        public string FaxNumber2 { get; set; }
        public string TaxNumber { get; set; }
        public string TaxOffice { get; set; }
        public string TaxCode { get; set; }
        public string Contact { get; set; }
        public string Url { get; set; }
        public string Email { get; set; }
        public string CityCode { get; set; }
        public short CardType { get; set; }
        public decimal? Distance { get; set; }
        public string AuthCode { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<OrderSlip> OrderSlipArps { get; set; }
        public virtual ICollection<OrderSlip> OrderSlipDeliveryArps { get; set; }
        public virtual ICollection<OrderSlipLine> OrderSlipLines { get; set; }
        public virtual ICollection<PlanningSlip> PlanningSlipArps { get; set; }
        public virtual ICollection<PlanningSlip> PlanningSlipDeliveryArps { get; set; }
        public virtual ICollection<PlanningSlipLine> PlanningSlipLines { get; set; }
        public virtual ICollection<ProductionOrderLine> ProductionOrderLines { get; set; }
        public virtual ICollection<ProductionOrder> ProductionOrders { get; set; }
        public virtual ICollection<ReservationSlipLine> ReservationSlipLines { get; set; }
        public virtual ICollection<ShipmentDay> ShipmentDays { get; set; }
        public virtual ICollection<Slip> SlipArps { get; set; }
        public virtual ICollection<Slip> SlipDeliveryArps { get; set; }
        public virtual ICollection<SlipLine> SlipLines { get; set; }
        public virtual ICollection<UnitBarcode> UnitBarcodes { get; set; }
        public virtual ICollection<WorkOrder> WorkOrderArps { get; set; }
        public virtual ICollection<WorkOrder> WorkOrderDeliveryArps { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLines { get; set; }
    }
}
