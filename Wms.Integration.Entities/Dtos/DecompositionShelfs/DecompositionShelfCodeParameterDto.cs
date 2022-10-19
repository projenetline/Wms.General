using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.DecompositionShelfs
{
    public class DecompositionShelfCodeParameterDto:ICodeParameterDto
    {
        public int Capacity { get; set; }
        public bool Descing { get; set; }
    }
}
