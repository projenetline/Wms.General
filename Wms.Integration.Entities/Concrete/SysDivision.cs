﻿using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysDivision:IBaseEntity
    {
        public SysDivision()
        {
            OrderSlips = new HashSet<OrderSlip>();
            PlanningSlips = new HashSet<PlanningSlip>();
            Slips = new HashSet<Slip>();
            SysFactories = new HashSet<SysFactory>();
            SysWarehouses = new HashSet<SysWarehouse>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<OrderSlip> OrderSlips { get; set; }
        public virtual ICollection<PlanningSlip> PlanningSlips { get; set; }
        public virtual ICollection<Slip> Slips { get; set; }
        public virtual ICollection<SysFactory> SysFactories { get; set; }
        public virtual ICollection<SysWarehouse> SysWarehouses { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}