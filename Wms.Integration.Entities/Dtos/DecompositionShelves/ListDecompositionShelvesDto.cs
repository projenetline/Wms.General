using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.DecompositionShelves
{
    public class ListDecompositionShelvesDto:IBaseDto
    {
        public DateTime CreatedDate { get; set; }
        public string CreatedUser{ get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public string Code { get; set; }
        public string Description { get; set; }
        public string DecompositionShelfDescription { get; set; }
        public int DecompositionShelfCapacity { get; set; }
    }
}
