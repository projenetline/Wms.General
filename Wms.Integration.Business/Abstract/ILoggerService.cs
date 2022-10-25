using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.Loggers;

namespace Wms.Integration.Business.Abstract
{
    public interface ILoggerService
    {
        Task<Logger> CreateAsync(Logger Entity);
        Task<HttpLogger> CreateAsync(HttpLogger Entity);
        Task<IDataResult<Logger>> GetLoggerById(Guid id);
        Task<IDataResult<HttpLogger>> GetHttpLoggerById(Guid id);
        Task<IDataResult<IList<Logger>>> GetLoggerList(LoggerCodeParameterDto parameter);
        Task<IDataResult<IList<HttpLogger>>> GetHttpLoggerList(HttpLoggerCodeParameterDto parameter);
    }
}
