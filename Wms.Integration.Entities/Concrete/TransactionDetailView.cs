using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class TransactionDetailView:IBaseEntity
    {
        public int ItemId { get; set; }
        public int WarehouseId { get; set; }
        public int? VariantId { get; set; }
        public int? AddressId { get; set; }
        public string TrackingNumber { get; set; }
        public DateTime LineDay { get; set; }
        public decimal? ActualStock { get; set; }
        public decimal? ReserveStock { get; set; }
        public decimal? SalesOrder { get; set; }
        public decimal? PurchaseOrder { get; set; }
        public decimal? TotalInboundPlanning { get; set; }
        public decimal? TotalOutboundPlanning { get; set; }
        public decimal? TotalProductionPlanning { get; set; }
        public decimal? TotalInboundOrders { get; set; }
        public decimal? TotalOutboundOrders { get; set; }
        public decimal? TotalProductionOrders { get; set; }
        public long? Cnt { get; set; }
    }
}
