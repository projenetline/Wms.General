using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Abstract
{
    public interface ILoggerService
    {
        Task<Logger> CreateAsync(Logger Entity);
        Task<HttpLogger> CreateAsync(HttpLogger Entity);
    }
}
