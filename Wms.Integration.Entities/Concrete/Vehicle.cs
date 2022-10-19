using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class Vehicle:IBaseEntity
    {
        public Vehicle()
        {
            OrderSlips = new HashSet<OrderSlip>();
            PlanningSlips = new HashSet<PlanningSlip>();
            Slips = new HashSet<Slip>();
            WorkOrders = new HashSet<WorkOrder>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Name { get; set; }
        public string PlateNumber { get; set; }
        public string PlateNumber2 { get; set; }
        public string PlateNumber3 { get; set; }
        public string Model { get; set; }
        public string Year { get; set; }
        public string Brand { get; set; }
        public string Description { get; set; }
        public string CustomCode { get; set; }
        public string Owner { get; set; }
        public decimal? Volume { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Area { get; set; }
        public decimal? Width { get; set; }
        public decimal? Depth { get; set; }
        public decimal? Height { get; set; }
        public int? WarehouseId { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysWarehouse Warehouse { get; set; }
        public virtual ICollection<OrderSlip> OrderSlips { get; set; }
        public virtual ICollection<PlanningSlip> PlanningSlips { get; set; }
        public virtual ICollection<Slip> Slips { get; set; }
        public virtual ICollection<WorkOrder> WorkOrders { get; set; }
    }
}
