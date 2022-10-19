using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysCustomState:IBaseEntity
    {
        public SysCustomState()
        {
            OrderSlipLines = new HashSet<OrderSlipLine>();
            OrderSlips = new HashSet<OrderSlip>();
            PlanningSlipLines = new HashSet<PlanningSlipLine>();
            PlanningSlips = new HashSet<PlanningSlip>();
            ReservationSlipLines = new HashSet<ReservationSlipLine>();
            ReservationSlips = new HashSet<ReservationSlip>();
            SlipLines = new HashSet<SlipLine>();
            Slips = new HashSet<Slip>();
            WorkOrderLines = new HashSet<WorkOrderLine>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public int Id { get; set; }
        public short RecordType { get; set; }
        public short StateNumber { get; set; }
        public string StateName { get; set; }
        public short SystemEvent { get; set; }
        public short IsDefault { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<OrderSlipLine> OrderSlipLines { get; set; }
        public virtual ICollection<OrderSlip> OrderSlips { get; set; }
        public virtual ICollection<PlanningSlipLine> PlanningSlipLines { get; set; }
        public virtual ICollection<PlanningSlip> PlanningSlips { get; set; }
        public virtual ICollection<ReservationSlipLine> ReservationSlipLines { get; set; }
        public virtual ICollection<ReservationSlip> ReservationSlips { get; set; }
        public virtual ICollection<SlipLine> SlipLines { get; set; }
        public virtual ICollection<Slip> Slips { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLines { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
