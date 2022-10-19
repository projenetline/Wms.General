using System.ComponentModel.DataAnnotations;
using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Concrete
{
    public class DecompositionLine:IBaseEntity
    {
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public int Amount { get; set; }
        public int SlipLineId { get; set; }
        public Guid DecompositionShelvesId { get; set; }
        public virtual OrderSlipLine SlipLine { get; set; }
        public virtual DecompositionShelves DecompositionShelves { get; set; }
    }
}
