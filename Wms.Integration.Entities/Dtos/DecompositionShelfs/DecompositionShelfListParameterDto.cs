using Wms.Integration.Core.Entities.Dtos;

namespace Wms.Integration.Entities.Dtos.DecompositionShelfs
{
    public class DecompositionShelfListParameterDto:PageListParameterDto
    {
        public int Capacity { get; set; }
        public bool Descing { get; set; }
    }
}
