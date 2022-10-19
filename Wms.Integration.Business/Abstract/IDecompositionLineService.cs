using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.DecompositionLines;

namespace Wms.Integration.Business.Abstract
{
    public interface IDecompositionLineService:IEntityService<DecompositionLine,DecompositionLineListParameterDto,DecompositionLineCodeParameterDto> 
    {
    }
}
