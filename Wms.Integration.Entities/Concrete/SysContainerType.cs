using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public partial class SysContainerType:IBaseEntity
    {
        public SysContainerType()
        {
            Containers = new HashSet<Container>();
            SysContainerRelationChildren = new HashSet<SysContainerRelation>();
            SysContainerRelationParents = new HashSet<SysContainerRelation>();
        }

        public int Id { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public int? ItemId { get; set; }
        public string Lpnprefix { get; set; }
        public short Lpnlength { get; set; }
        public short LpncontainsDate { get; set; }
        public decimal? Width { get; set; }
        public decimal? Height { get; set; }
        public decimal? Length { get; set; }
        public decimal? Weight { get; set; }
        public decimal? Volume { get; set; }
        public decimal? DimensionWeight { get; set; }
        public string ItemsFilter { get; set; }
        public short Active { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public int? ModifiedBy { get; set; }

        public virtual ICollection<Container> Containers { get; set; }
        public virtual ICollection<SysContainerRelation> SysContainerRelationChildren { get; set; }
        public virtual ICollection<SysContainerRelation> SysContainerRelationParents { get; set; }
    }
}
