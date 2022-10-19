using Wms.Integration.Core.Entities.Abstract;

namespace Wms.Integration.Entities.Dtos.DecompositionLines
{
    public class DecompositionLineCodeParameterDto:ICodeParameterDto
    {
        public int Amount { get; set; }
        public bool Descing { get; set; }
    }
}
