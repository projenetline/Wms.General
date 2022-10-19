using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.Business.Concrete
{
    public class LoggerManager : ILoggerService
    {
        private readonly ILoggerDal loggerDal;
        private readonly IHttpLoggerDal httpLoggerDal;
        public LoggerManager(ILoggerDal loggerDal,IHttpLoggerDal httpLoggerDal)
        {
            this.httpLoggerDal = httpLoggerDal;
            this.loggerDal = loggerDal;
        }
        public async Task<Logger> CreateAsync(Logger entity)
        {
            return await loggerDal.CreateAsync(entity);
        }

        public async Task<HttpLogger> CreateAsync(HttpLogger Entity)
        {
            return await httpLoggerDal.CreateAsync(Entity);
        }
    }
}
