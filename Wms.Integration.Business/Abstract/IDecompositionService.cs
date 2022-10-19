using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.Decompositions;

namespace Wms.Integration.Business.Abstract
{
    public interface IDecompositionService:IEntityService<Decomposition,DecompositionListParameterDto,DecompositionCodeParameterDto>
    {
    }
}
