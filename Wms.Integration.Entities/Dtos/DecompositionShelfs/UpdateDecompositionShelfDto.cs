using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.DecompositionShelfs
{
    public class UpdateDecompositionShelfDto:IBaseDto
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public int CreatedBy { get; set; }
        public DateTime ModifiedDate { get; set; }
        public int ModifiedBy { get; set; }
        public int Capacity { get; set; }
    }
}
