using System.Linq.Expressions;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Core.Entities.Abstract;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.Loggers;
using Wms.Integration.Entities.JsonObjects;

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

        public async Task<IDataResult<HttpLogger>> GetHttpLoggerById(Guid id)
        {
            try
            {
                return new SuccessDataResult<HttpLogger>(await httpLoggerDal.GetAsync(s => s.Id == id),CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "LoggerManager.GetHttpLoggerById",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<HttpLogger>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<IList<HttpLogger>>> GetHttpLoggerList(HttpLoggerCodeParameterDto parameter)
        {
            try
            {
                return new SuccessDataResult<IList<HttpLogger>>(await httpLoggerDal.GetListAsync(
                                                                  s => parameter.StartDate == null ?
                                                                     (parameter.LocalIp == "" ?
                                                                     (parameter.LocalPort == -1 ?
                                                                     (parameter.RemoteIp == "" ?
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (true) : (s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.RemotePort == parameter.RemotePort) : (s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu))) :
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (s.RemoteIp == parameter.RemoteIp) : (s.RemoteIp == parameter.RemoteIp && s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort) : (s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu)))) :
                                                                     (parameter.RemoteIp == "" ?
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (s.LocalPort == parameter.LocalPort) : (s.LocalPort == parameter.LocalPort && s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.LocalPort == parameter.LocalPort && s.RemotePort == parameter.RemotePort) : (s.LocalPort == parameter.LocalPort && s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu))) :
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp) : (s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp && s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort) : (s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu))))) :
                                                                     (parameter.LocalPort == -1 ?
                                                                     (parameter.RemoteIp == "" ?
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (s.LocalIp == parameter.LocalIp) : (s.LocalIp == parameter.LocalIp && s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.LocalIp == parameter.LocalIp && s.RemotePort == parameter.RemotePort) : (s.LocalIp == parameter.LocalIp && s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu))) :
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (s.LocalIp == parameter.LocalIp && s.RemoteIp == parameter.RemoteIp) : (s.LocalIp == parameter.LocalIp && s.RemoteIp == parameter.RemoteIp && s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.LocalIp == parameter.LocalIp && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort) : (s.LocalIp == parameter.LocalIp && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu)))) :
                                                                     (parameter.RemoteIp == "" ?
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort) : (s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort && s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort && s.RemotePort == parameter.RemotePort) : (s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu))) :
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp) : (s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp && s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort) : (s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu
                                                                     )))))) :
                                                                    (parameter.LocalIp == "" ?
                                                                     (parameter.LocalPort == -1 ?
                                                                     (parameter.RemoteIp == "" ?
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate) : (s.CreatedDate >= parameter.StartDate && s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate && s.RemotePort == parameter.RemotePort) : (s.CreatedDate >= parameter.StartDate && s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu))) :
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate && s.RemoteIp == parameter.RemoteIp) : (s.CreatedDate >= parameter.StartDate && s.RemoteIp == parameter.RemoteIp && s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort) : (s.CreatedDate >= parameter.StartDate && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu)))) :
                                                                     (parameter.RemoteIp == "" ?
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate && s.LocalPort == parameter.LocalPort) : (s.CreatedDate >= parameter.StartDate && s.LocalPort == parameter.LocalPort && s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate && s.LocalPort == parameter.LocalPort && s.RemotePort == parameter.RemotePort) : (s.CreatedDate >= parameter.StartDate && s.LocalPort == parameter.LocalPort && s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu))) :
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate && s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp) : (s.CreatedDate >= parameter.StartDate && s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp && s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate && s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort) : (s.CreatedDate >= parameter.StartDate && s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu))))) :
                                                                     (parameter.LocalPort == -1 ?
                                                                     (parameter.RemoteIp == "" ?
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp) : (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp && s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp && s.RemotePort == parameter.RemotePort) : (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp && s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu))) :
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp && s.RemoteIp == parameter.RemoteIp) : (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp && s.RemoteIp == parameter.RemoteIp && s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort) : (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu)))) :
                                                                     (parameter.RemoteIp == "" ?
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort) : (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort && s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort && s.RemotePort == parameter.RemotePort) : (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu))) :
                                                                     (parameter.RemotePort == -1 ?
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp) : (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp && s.ResponseStatu == parameter.ResponseStatu)) :
                                                                     (parameter.ResponseStatu == -1 ? (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort) : (s.CreatedDate >= parameter.StartDate && s.LocalIp == parameter.LocalIp && s.LocalPort == parameter.LocalPort && s.RemoteIp == parameter.RemoteIp && s.RemotePort == parameter.RemotePort && s.ResponseStatu == parameter.ResponseStatu
                                                                     )))))), s=>s.CreatedDate,parameter.Desc), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "LoggerManager.GetHttpLoggerById",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<IList<HttpLogger>>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<Logger>> GetLoggerById(Guid id)
        {
            try
            {
                return new SuccessDataResult<Logger>(await loggerDal.GetAsync(s => s.Id == id), CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "LoggerManager.GetLoggerById",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<Logger>(null, CustomJObject.Instance.General.NotGet);
            }
        }

        public async Task<IDataResult<IList<Logger>>> GetLoggerList(LoggerCodeParameterDto parameter)
        {
            try
            {
                return new SuccessDataResult<IList<Logger>>(await loggerDal.GetListAsync(s=>parameter.StartDate == null  ? 
                (parameter.Statu==""?
                (parameter.MethodName==""?
                (parameter.ProjectName=="" ? (true):(s.ProjectName==parameter.ProjectName)):
                (parameter.ProjectName == "" ? (s.MethodName==parameter.MethodName):(s.MethodName==parameter.MethodName && s.ProjectName == parameter.ProjectName))):
                (parameter.MethodName == "" ?
                (parameter.ProjectName == "" ?(s.Statu==parameter.Statu):(s.Statu == parameter.Statu&& s.ProjectName == parameter.ProjectName)) :
                (parameter.ProjectName == "" ?(s.Statu == parameter.Statu && s.MethodName == parameter.MethodName) :(s.Statu == parameter.Statu && s.MethodName == parameter.MethodName && s.ProjectName == parameter.ProjectName)))):

                 (parameter.Statu == "" ?
                (parameter.MethodName == "" ?
                (parameter.ProjectName == "" ? (s.CreatedDate>=parameter.StartDate) : (s.CreatedDate >= parameter.StartDate && s.ProjectName == parameter.ProjectName)) :
                (parameter.ProjectName == "" ? (s.CreatedDate >= parameter.StartDate&&s.MethodName == parameter.MethodName) : (s.CreatedDate >= parameter.StartDate&&s.MethodName == parameter.MethodName && s.ProjectName == parameter.ProjectName))) :
                (parameter.MethodName == "" ?
                (parameter.ProjectName == "" ? (s.CreatedDate >= parameter.StartDate&&s.Statu == parameter.Statu) : (s.CreatedDate >= parameter.StartDate&&s.Statu == parameter.Statu && s.ProjectName == parameter.ProjectName)) :
                (parameter.ProjectName == "" ? (s.CreatedDate >= parameter.StartDate&&s.Statu == parameter.Statu && s.MethodName == parameter.MethodName) : (s.CreatedDate >= parameter.StartDate&&s.Statu == parameter.Statu && s.MethodName == parameter.MethodName && s.ProjectName == parameter.ProjectName))))
                , s=>s.CreatedDate,parameter.Desc),CustomJObject.Instance.General.Get);
            }
            catch (Exception ex)
            {
                await loggerDal.CreateAsync(new Logger
                {
                    CreatedDate = DateTime.Now,
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ? "" : ex.InnerException.Message,
                    MethodName = "LoggerManager.GetLoggerList",
                    ProjectName = "Wms.Integration.Business",
                    Statu = "Error",
                });
                return new ErrorDataResult<IList<Logger>>(null, CustomJObject.Instance.General.NotGet);
            }
        }
    }
}
