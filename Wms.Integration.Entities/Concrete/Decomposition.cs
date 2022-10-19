using System.ComponentModel.DataAnnotations;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public class Decomposition:IBaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; } 
        public Guid DecompositionShelfId { get; set; }
        public bool IsCompleted { get; set; }
        public virtual DecompositionShelf DecompositionShelf { get; set; }
    }
}
