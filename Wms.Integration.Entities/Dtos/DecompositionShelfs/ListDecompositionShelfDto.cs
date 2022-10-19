using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.Core.Entities.Dtos;

namespace Wms.Integration.Entities.Dtos.DecompositionShelfs
{
    public class ListDecompositionShelfDto: IBaseDto
    {
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public string CreatedUser { get; set; }
        public DateTime ModifiedDate { get; set; }
        public string ModifiedUser { get; set; }
        public int Capacity { get; set; }
    }
}
