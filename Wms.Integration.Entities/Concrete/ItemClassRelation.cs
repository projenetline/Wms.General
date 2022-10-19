using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class ItemClassRelation:IBaseEntity
    {
        public int Id { get; set; }
        public int ClassId { get; set; }
        public int ItemId { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual Item Class { get; set; }
        public virtual Item Item { get; set; }
    }
}
