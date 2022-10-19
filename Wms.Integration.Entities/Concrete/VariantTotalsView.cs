using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class VariantTotalsView:IBaseEntity
    {
        public int ItemId { get; set; }
        public int? VariantId { get; set; }
        public int WarehouseId { get; set; }
        public int? AddressId { get; set; }
        public decimal? ActualStock { get; set; }
    }
}
