using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class Container:IBaseEntity
    {
        public Container()
        {
            ReservationSlipLineChildContainers = new HashSet<ReservationSlipLine>();
            ReservationSlipLineContainers = new HashSet<ReservationSlipLine>();
            SlipLineChildContainer2s = new HashSet<SlipLine>();
            SlipLineChildContainers = new HashSet<SlipLine>();
            SlipLineContainer2s = new HashSet<SlipLine>();
            SlipLineContainers = new HashSet<SlipLine>();
            WorkOrderLineChildContainer2s = new HashSet<WorkOrderLine>();
            WorkOrderLineChildContainers = new HashSet<WorkOrderLine>();
            WorkOrderLineContainer2s = new HashSet<WorkOrderLine>();
            WorkOrderLineContainers = new HashSet<WorkOrderLine>();
        }

        public int Id { get; set; }
        public int ContainerTypeId { get; set; }
        public string Lpn { get; set; }
        public string Description { get; set; }
        public int PrintCount { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysContainerType ContainerType { get; set; }
        public virtual ICollection<ReservationSlipLine> ReservationSlipLineChildContainers { get; set; }
        public virtual ICollection<ReservationSlipLine> ReservationSlipLineContainers { get; set; }
        public virtual ICollection<SlipLine> SlipLineChildContainer2s { get; set; }
        public virtual ICollection<SlipLine> SlipLineChildContainers { get; set; }
        public virtual ICollection<SlipLine> SlipLineContainer2s { get; set; }
        public virtual ICollection<SlipLine> SlipLineContainers { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLineChildContainer2s { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLineChildContainers { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLineContainer2s { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLineContainers { get; set; }
    }
}
