using System.ComponentModel.DataAnnotations;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public class DecompositionShelf : IBaseEntity
    {
        public DecompositionShelf()
        {
            Decompositions=new HashSet<Decomposition>();
            DecompositionShelves = new HashSet<DecompositionShelves>();
        }
        [Key]
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public int Capacity { get; set; }
        public virtual ICollection<Decomposition> Decompositions { get; set; }
        public virtual ICollection<DecompositionShelves> DecompositionShelves { get; set; }
    }
}
