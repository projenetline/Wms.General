using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.IO;
using NuGet.Protocol;
using System.IO;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Business.Concrete;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.Entities.Concrete;

namespace Wms.Integration.API.Middleware
{
    // You may need to install the Microsoft.AspNetCore.Http.Abstractions package into your project
    public class HttpLoggingMiddleware
    {
        private readonly RequestDelegate _next;
        private readonly ILoggerService _loggerService;
        private readonly RecyclableMemoryStreamManager _recyclableMemoryStreamManager;
        private HttpLogger _logger;
        public HttpLoggingMiddleware(RequestDelegate next)
        {
            _logger = new HttpLogger();
            _recyclableMemoryStreamManager = new RecyclableMemoryStreamManager();
            _loggerService = new LoggerManager(new EfLoggerDal(),new EfHttpLoggerDal());
            _next = next;
        }
        public async Task Invoke(HttpContext httpContext)
        {
            _logger= new HttpLogger();
            await LogRequest(httpContext);
            await LogResponse(httpContext);

            IPAddress? localaddress = httpContext.Connection.LocalIpAddress;
            IPAddress? remoteaddress = httpContext.Connection.RemoteIpAddress;
            int localport = httpContext.Connection.LocalPort;
            int remoteport = httpContext.Connection.RemotePort;
            if (localaddress != null)
            {
                _logger.LocalIp = localaddress.ToString();
                _logger.LocalPort = localport;
            }
            if (remoteaddress != null)
            {
                _logger.RemoteIp = remoteaddress.ToString();
                _logger.RemotePort = remoteport;
            }
           _logger.FullUrl = $"{httpContext.Request.Scheme}://{httpContext.Request.Host}{httpContext.Request.Path}{httpContext.Request.QueryString.Value ?? ""}";
           _logger= await _loggerService.CreateAsync(_logger);
        }
        private async Task LogResponse(HttpContext context)
        {
            var originalBodyStream = context.Response.Body;
            await using var responseBody = _recyclableMemoryStreamManager.GetStream();
            context.Response.Body = responseBody;
            await _next(context);
            context.Response.Body.Seek(0, SeekOrigin.Begin);
            var text = await new StreamReader(context.Response.Body).ReadToEndAsync();
            context.Response.Body.Seek(0, SeekOrigin.Begin);
            _logger.ResponseStatu=context.Response.StatusCode;
            _logger.Response = text;
            await responseBody.CopyToAsync(originalBodyStream);
        }
        private async Task LogRequest(HttpContext context)
        {
            context.Request.EnableBuffering();
            await using var requestStream = _recyclableMemoryStreamManager.GetStream();
            await context.Request.Body.CopyToAsync(requestStream);
            _logger.Body=ReadStreamInChunks(requestStream);
            context.Request.Body.Position = 0;
        }
        private static string ReadStreamInChunks(Stream stream)
        {
            const int readChunkBufferLength = 4096;
            stream.Seek(0, SeekOrigin.Begin);
            using var textWriter = new StringWriter();
            using var reader = new StreamReader(stream);
            var readChunk = new char[readChunkBufferLength];
            int readChunkLength;
            do
            {
                readChunkLength = reader.ReadBlock(readChunk,  0,   readChunkBufferLength);
                textWriter.Write(readChunk, 0, readChunkLength);
            } while (readChunkLength > 0);
            return textWriter.ToString();
        }
    }

    // Extension method used to add the middleware to the HTTP request pipeline.
    public static class HttpLoggingMiddlewareExtensions
    {
        public static IApplicationBuilder UseHttpLoggingMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<HttpLoggingMiddleware>();
        }
    }
}
