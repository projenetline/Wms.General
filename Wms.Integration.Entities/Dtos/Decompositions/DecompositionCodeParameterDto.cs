using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.Decompositions
{
    public class DecompositionCodeParameterDto:ICodeParameterDto
    {
        public bool IsCompleted { get; set; }
        public bool Descing { get; set; }
    }
}
