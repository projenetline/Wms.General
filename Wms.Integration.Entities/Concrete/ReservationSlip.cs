using System;
using System.Collections.Generic;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class ReservationSlip:IBaseEntity
    {
        public ReservationSlip()
        {
            ReservationSlipLines = new HashSet<ReservationSlipLine>();
        }

        public int Id { get; set; }
        public short SlipType { get; set; }
        public DateTime SlipDate { get; set; }
        public string SlipNumber { get; set; }
        public int? OrderSlipId { get; set; }
        public int? PlanningSlipId { get; set; }
        public int? ProductionOrderId { get; set; }
        public int? WorkOrderId { get; set; }
        public int WarehouseId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DivisionId { get; set; }
        public int? FactoryId { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public string Description1 { get; set; }
        public string Description2 { get; set; }
        public string Description3 { get; set; }
        public string Description4 { get; set; }
        public string CustomCode { get; set; }
        public int StateId { get; set; }
        public short Active { get; set; }
        public string AuthCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual OrderSlip OrderSlip { get; set; }
        public virtual PlanningSlip PlanningSlip { get; set; }
        public virtual ProductionOrder ProductionOrder { get; set; }
        public virtual SysCustomState State { get; set; }
        public virtual WorkOrder WorkOrder { get; set; }
        public virtual ICollection<ReservationSlipLine> ReservationSlipLines { get; set; }
    }
}
