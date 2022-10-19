using Wms.Integration.Core.Entities.Dtos;

namespace Wms.Integration.Entities.Dtos.DecompositionShelves
{
    public class DecompositionShelvesListParameterDto:PageListParameterDto
    {
        public string Code { get; set; }
        public bool Descing { get; set; }
    }
}
