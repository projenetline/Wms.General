using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class Project:IBaseEntity
    {
        public Project()
        {
            OrderSlipLines = new HashSet<OrderSlipLine>();
            OrderSlips = new HashSet<OrderSlip>();
            ProductionOrderLines = new HashSet<ProductionOrderLine>();
            ProductionOrders = new HashSet<ProductionOrder>();
            SlipLines = new HashSet<SlipLine>();
            Slips = new HashSet<Slip>();
            WorkOrderLines = new HashSet<WorkOrderLine>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string CustomCode { get; set; }
        public string Responsible { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }
        public string AuthCode { get; set; }
        public string CustomCode2 { get; set; }
        public string CustomCode3 { get; set; }
        public string CustomCode4 { get; set; }
        public string CustomCode5 { get; set; }

        public virtual ICollection<OrderSlipLine> OrderSlipLines { get; set; }
        public virtual ICollection<OrderSlip> OrderSlips { get; set; }
        public virtual ICollection<ProductionOrderLine> ProductionOrderLines { get; set; }
        public virtual ICollection<ProductionOrder> ProductionOrders { get; set; }
        public virtual ICollection<SlipLine> SlipLines { get; set; }
        public virtual ICollection<Slip> Slips { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLines { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
