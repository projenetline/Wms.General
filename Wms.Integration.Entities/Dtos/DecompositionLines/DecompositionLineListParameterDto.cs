using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.Core.Entities.Dtos;

namespace Wms.Integration.Entities.Dtos.DecompositionLines
{
    public class DecompositionLineListParameterDto:PageListParameterDto,IBaseDto
    {
        public int Amount { get; set; }
        public bool Descing { get; set; }
    }
}
