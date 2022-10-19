using Wms.Integration.Core.Core.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.DecompositionShelfs;

namespace Wms.Integration.Business.Abstract
{
    public interface IDecompositionShelfService:IEntityService<DecompositionShelf,DecompositionShelfListParameterDto,DecompositionShelfCodeParameterDto>
    {
    }
}
