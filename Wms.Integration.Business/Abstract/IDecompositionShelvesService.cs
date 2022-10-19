using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.DecompositionShelves;

namespace Wms.Integration.Business.Abstract
{
    public interface IDecompositionShelvesService:IEntityService<DecompositionShelves,DecompositionShelvesListParameterDto,DecompositionShelvesCodeParameterDto>
    {
    }
}
