using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class ItemContent:IBaseEntity
    {
        public int Id { get; set; }
        public int ParentItemId { get; set; }
        public int ItemId { get; set; }
        public decimal Quantity { get; set; }
        public int UnitId { get; set; }
        public int LineNumber { get; set; }
        public decimal Percentage { get; set; }
        public decimal RateOfWaste { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Item Item { get; set; }
        public virtual Item ParentItem { get; set; }
        public virtual ItemUnit Unit { get; set; }
    }
}
