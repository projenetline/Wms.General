using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.Core.Entities.Dtos;

namespace Wms.Integration.Entities.Dtos.Decompositions
{
    public class DecompositionListParameterDto:PageListParameterDto
    {
        public bool IsCompleted { get; set; }
        public bool Descing { get; set; }
    }
}
