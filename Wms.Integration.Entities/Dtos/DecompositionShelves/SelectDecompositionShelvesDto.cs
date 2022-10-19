using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.DecompositionShelves
{
    public class SelectDecompositionShelvesDto:IBaseDto
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public string CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public string ModifiedUser { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public Guid DecompositionShelfId { get; set; }
        public string DecompositionShelfDescription { get; set; }
        public int DecompositionShelfCapacity { get; set; }
    }
}
