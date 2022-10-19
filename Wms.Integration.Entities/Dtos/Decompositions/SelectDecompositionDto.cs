using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.Decompositions
{
    public class SelectDecompositionDto:IBaseDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public Guid DecompositionShelfId { get; set; }
        public bool IsCompleted { get; set; }
        public string Description { get; set; }
        public string Capacity { get; set; }
    }
}
