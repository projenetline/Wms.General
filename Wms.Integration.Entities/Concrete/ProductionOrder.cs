using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class ProductionOrder:IBaseEntity
    {
        public ProductionOrder()
        {
            ProductionOrderLines = new HashSet<ProductionOrderLine>();
            ReservationSlips = new HashSet<ReservationSlip>();
            Slips = new HashSet<Slip>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public int Id { get; set; }
        public short SlipType { get; set; }
        public string SlipNumber { get; set; }
        public DateTime SlipDate { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public short MaterialPull { get; set; }
        public int? FactoryId { get; set; }
        public string CustomCode { get; set; }
        public int? ArpId { get; set; }
        public int ItemId { get; set; }
        public int? VariantId { get; set; }
        public int UnitId { get; set; }
        public decimal ConvFactor1 { get; set; }
        public decimal ConvFactor2 { get; set; }
        public decimal Quantity { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public DateTime? DueDate { get; set; }
        public DateTime? PauseDate { get; set; }
        public DateTime? PlannedStartDate { get; set; }
        public DateTime? PlannedEndDate { get; set; }
        public DateTime? PlannedTime { get; set; }
        public short ProductionStatus { get; set; }
        public short Approval { get; set; }
        public int? ProjectId { get; set; }
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
        public virtual ItemUnit Unit { get; set; }
        public virtual ICollection<ProductionOrderLine> ProductionOrderLines { get; set; }
        public virtual ICollection<ReservationSlip> ReservationSlips { get; set; }
        public virtual ICollection<Slip> Slips { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
