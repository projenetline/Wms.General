using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.DecompositionLines;
using Wms.Integration.Entities.Dtos.Decompositions;

namespace Wms.Integration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecompositionsController : ControllerBase
    {
        private readonly IDecompositionService decompositionService;
        private readonly ILoggerService loggerService;
        private readonly IMapper objectMapper;
        public DecompositionsController(ILoggerService loggerService,IDecompositionService decompositionService,IMapper objectMapper)
        {
            this.loggerService = loggerService;
            this.decompositionService = decompositionService;
            this.objectMapper = objectMapper;
        }
        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] DecompositionListParameterDto dto)
        {
            IDataResult<IList<Decomposition>> result = await decompositionService.GetListAsync(dto);
            if (result.Success)
            {
                return Ok(objectMapper.Map<IList<Decomposition>, IList<ListDecompositionDto>>(result.Data));
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetPagedList")]
        public async Task<IActionResult> GetPagedList([FromQuery] DecompositionListParameterDto dto)
        {
            IDataResult<PagedResult<Decomposition>> result = await decompositionService.GetPagedListAsync(dto);
            if (result.Success)
            {
                return Ok(objectMapper.Map<PagedResult<Decomposition>, PagedResult<ListDecompositionDto>>(result.Data));
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetParameter")]
        public async Task<IActionResult> GetParameter([FromQuery] DecompositionCodeParameterDto dto)
        {
            IDataResult<Decomposition> result = await decompositionService.GetParameterAsync(dto);
            if (result.Success)
            {
                return Ok(new DataResult<SelectDecompositionDto>(objectMapper.Map<Decomposition, SelectDecompositionDto>(result.Data), result.Message, true));
            }
            return BadRequest(result.Message);
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            IDataResult<Decomposition> dataResult = await decompositionService.GetAsync(id);
            if (dataResult.Success)
            {
                return Ok(new DataResult<SelectDecompositionDto>(objectMapper.Map<Decomposition, SelectDecompositionDto>(dataResult.Data), dataResult.Message, true));
            }
            return BadRequest(dataResult.Message);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateDecompositionDto dto)
        {
            IDataResult<Decomposition> dataResult = await decompositionService.CreateAsync(objectMapper.Map<CreateDecompositionDto, Decomposition>(dto));
            if (dataResult.Success)
            {
                return Ok(new DataResult<SelectDecompositionDto>(objectMapper.Map<Decomposition, SelectDecompositionDto>(dataResult.Data), dataResult.Message, true));
            }
            return BadRequest(dataResult.Message);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateDecompositionDto dto)
        {
            IDataResult<Decomposition> dataResult = await decompositionService.CreateAsync(objectMapper.Map<UpdateDecompositionDto, Decomposition>(dto));
            if (dataResult.Success)
            {
                return Ok(new DataResult<SelectDecompositionDto>(objectMapper.Map<Decomposition, SelectDecompositionDto>(dataResult.Data), dataResult.Message, true));
            }
            return BadRequest(dataResult.Message);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteDecompositionShelf([FromQuery] Guid id)
        {
            IDataResult<Decomposition> dataResult = await decompositionService.GetAsync(id);
            if (dataResult.Success)
            {
                IDataResult<Decomposition> result = await decompositionService.DeleteAsync(dataResult.Data);
                if (result.Success)
                {
                    return Ok(new DataResult<SelectDecompositionDto>(objectMapper.Map<Decomposition, SelectDecompositionDto>(dataResult.Data), dataResult.Message, true));
                }
                return BadRequest(result.Message);
            }
            return BadRequest(dataResult.Message);
        }
    }
}
