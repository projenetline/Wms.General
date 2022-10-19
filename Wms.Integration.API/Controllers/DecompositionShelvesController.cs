using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.DecompositionShelves;

namespace Wms.Integration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecompositionShelvesController : ControllerBase
    {
        private readonly ILoggerService loggerService;
        private readonly IDecompositionShelvesService decompositionShelvesService;
        private readonly IMapper objectMapper;
        public DecompositionShelvesController(ILoggerService loggerService, IMapper objectMapper,IDecompositionShelvesService decompositionShelvesService)
        {
            this.loggerService = loggerService;
            this.objectMapper = objectMapper;
            this.decompositionShelvesService = decompositionShelvesService;
        }
        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] DecompositionShelvesListParameterDto dto)
        {
            IDataResult<IList<DecompositionShelves>> result = await decompositionShelvesService.GetListAsync(dto);
            if (result.Success)
            {
                return Ok(objectMapper.Map<IList<DecompositionShelves>, IList<ListDecompositionShelvesDto>>(result.Data));
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetPagedList")]
        public async Task<IActionResult> GetPagedList([FromQuery] DecompositionShelvesListParameterDto dto)
        {
            IDataResult<PagedResult<DecompositionShelves>> result = await decompositionShelvesService.GetPagedListAsync(dto);
            if (result.Success)
            {
                return Ok(objectMapper.Map<PagedResult<DecompositionShelves>, PagedResult<ListDecompositionShelvesDto>>(result.Data));
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetParameter")]
        public async Task<IActionResult> GetParameter([FromQuery] DecompositionShelvesCodeParameterDto dto)
        {
            IDataResult<DecompositionShelves> result = await decompositionShelvesService.GetParameterAsync(dto);
            if (result.Success)
            {
                return Ok(new DataResult<SelectDecompositionShelvesDto>(objectMapper.Map<DecompositionShelves, SelectDecompositionShelvesDto>(result.Data), result.Message, true));
            }
            return BadRequest(result.Message);
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            IDataResult<DecompositionShelves> dataResult = await decompositionShelvesService.GetAsync(id);
            if (dataResult.Success)
            {
                return Ok(new DataResult<SelectDecompositionShelvesDto>(objectMapper.Map<DecompositionShelves, SelectDecompositionShelvesDto>(dataResult.Data), dataResult.Message, true));
            }
            return BadRequest(dataResult.Message);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateDecompositionShelvesDto dto)
        {
            IDataResult<DecompositionShelves> dataResult = await decompositionShelvesService.CreateAsync(objectMapper.Map<CreateDecompositionShelvesDto, DecompositionShelves>(dto));
            if (dataResult.Success)
            {
                return Ok(new DataResult<SelectDecompositionShelvesDto>(objectMapper.Map<DecompositionShelves, SelectDecompositionShelvesDto>(dataResult.Data), dataResult.Message, true));
            }
            return BadRequest(dataResult.Message);
        }
        [HttpPut("Update")]
        public async Task<ActionResult<DecompositionShelf>> Update([FromBody] UpdateDecompositionShelvesDto dto)
        {
            IDataResult<DecompositionShelves> dataResult = await decompositionShelvesService.CreateAsync(objectMapper.Map<UpdateDecompositionShelvesDto, DecompositionShelves>(dto));
            if (dataResult.Success)
            {
                return Ok(new DataResult<SelectDecompositionShelvesDto>(objectMapper.Map<DecompositionShelves, SelectDecompositionShelvesDto>(dataResult.Data), dataResult.Message, true));
            }
            return BadRequest(dataResult.Message);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteDecompositionShelf([FromQuery] Guid id)
        {
            IDataResult<DecompositionShelves> dataResult = await decompositionShelvesService.GetAsync(id);
            if (dataResult.Success)
            {
                IDataResult<DecompositionShelves> result = await decompositionShelvesService.DeleteAsync(dataResult.Data);
                if (result.Success)
                {
                    return Ok(new DataResult<SelectDecompositionShelvesDto>(objectMapper.Map<DecompositionShelves, SelectDecompositionShelvesDto>(dataResult.Data), dataResult.Message, true));
                }
                return BadRequest(result.Message);
            }
            return BadRequest(dataResult.Message);
        }
    }
}
