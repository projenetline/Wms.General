using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.Loggers;

namespace Wms.Integration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LoggerController : ControllerBase
    {
        private readonly ILoggerService loggerService;
        private readonly IMapper objectMapper;
        public LoggerController(ILoggerService loggerService,IMapper objectMapper)
        {
            this.objectMapper = objectMapper;
            this.loggerService = loggerService;
        }
        [HttpGet("GetById")]
        public async Task<IActionResult> GetById([FromQuery] Guid id)
        {
            IDataResult<Logger> result = await loggerService.GetLoggerById(id);
            if (result.Success)
            {
                return Ok(objectMapper.Map<Logger, LoggerInfoDto>(result.Data));
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetHttpById")]
        public async Task<IActionResult> GetHttpById([FromQuery] Guid id)
        {
            IDataResult<HttpLogger> result = await loggerService.GetHttpLoggerById(id);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] LoggerCodeParameterDto dto)
        {
            IDataResult<IList<Logger>> result = await loggerService.GetLoggerList(dto);
            if (result.Success)
            {
                return Ok(objectMapper.Map<IList<Logger>, IList<LoggerInfoDto>>(result.Data));
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetHttpList")]
        public async Task<IActionResult> GetHttpList([FromQuery] HttpLoggerCodeParameterDto dto)
        {
            IDataResult<IList<HttpLogger>> result = await loggerService.GetHttpLoggerList(dto);
            if (result.Success)
            {
                return Ok(result.Data);
            }
            return BadRequest(result.Message);
        }
    }
}
