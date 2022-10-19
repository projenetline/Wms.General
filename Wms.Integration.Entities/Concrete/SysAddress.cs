using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysAddress:IBaseEntity
    {
        public SysAddress()
        {
            AddressItems = new HashSet<AddressItem>();
            PlanningSlipLineAddress2s = new HashSet<PlanningSlipLine>();
            PlanningSlipLineAddresses = new HashSet<PlanningSlipLine>();
            ReservationSlipLines = new HashSet<ReservationSlipLine>();
            SlipLineAddress2s = new HashSet<SlipLine>();
            SlipLineAddresses = new HashSet<SlipLine>();
            WorkOrderLineAddress2s = new HashSet<WorkOrderLine>();
            WorkOrderLineAddresses = new HashSet<WorkOrderLine>();
        }

        public int Id { get; set; }
        public string Address { get; set; }
        public int WarehouseId { get; set; }
        public int? FloorId { get; set; }
        public int? ZoneId { get; set; }
        public int? BlockId { get; set; }
        public short AddressType { get; set; }
        public string GroupCode { get; set; }
        public string Aisle { get; set; }
        public int LineNumber { get; set; }
        public short Shelf { get; set; }
        public short Xcoord { get; set; }
        public short Ycoord { get; set; }
        public short Zcoord { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Length { get; set; }
        public decimal? Depth { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public string CustomCode { get; set; }
        public short ShipmentPriority { get; set; }
        public short PlacementPriority { get; set; }
        public string RfId { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public string GpsAddress { get; set; }
        public short Active { get; set; }
        public string AuthCode { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual SysWarehouseFloor Floor { get; set; }
        public virtual SysWarehouse Warehouse { get; set; }
        public virtual SysWarehouseZone Zone { get; set; }
        public virtual ICollection<AddressItem> AddressItems { get; set; }
        public virtual ICollection<PlanningSlipLine> PlanningSlipLineAddress2s { get; set; }
        public virtual ICollection<PlanningSlipLine> PlanningSlipLineAddresses { get; set; }
        public virtual ICollection<ReservationSlipLine> ReservationSlipLines { get; set; }
        public virtual ICollection<SlipLine> SlipLineAddress2s { get; set; }
        public virtual ICollection<SlipLine> SlipLineAddresses { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLineAddress2s { get; set; }
        public virtual ICollection<WorkOrderLine> WorkOrderLineAddresses { get; set; }
    }
}
