using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.DecompositionShelves
{
    public class DecompositionShelvesCodeParameterDto : ICodeParameterDto
    {
        public string Code { get; set; }
        public bool Descing { get; set; }
    }
}
