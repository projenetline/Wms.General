using System.ComponentModel.DataAnnotations;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public class DecompositionShelves:IBaseEntity
    {
        public DecompositionShelves()
        {
            DecompositionLines = new HashSet<DecompositionLine>();
        }
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid DecompositionShelfId { get; set; }
        public virtual DecompositionShelf DecompositionShelfs { get; set; }
        public virtual ICollection<DecompositionLine> DecompositionLines { get; set; }
    }
}
