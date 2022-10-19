using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Concrete.Contexts;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.Decompositions;
using Wms.Integration.Entities.Dtos.DecompositionShelfs;

namespace Wms.Integration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecompositionShelfsController : ControllerBase
    {
        private readonly ILoggerService loggerService;
        private readonly IDecompositionShelfService decompositionShelfService;
        private readonly IMapper objectMapper;
        public DecompositionShelfsController(ILoggerService loggerService,IDecompositionShelfService decompositionShelfService,IMapper objectMapper)
        {
            this.loggerService = loggerService;
            this.decompositionShelfService = decompositionShelfService;
            this.objectMapper = objectMapper;
        }
        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] DecompositionShelfListParameterDto dto)
        {
            IDataResult<IList<DecompositionShelf>> result = await decompositionShelfService.GetListAsync(dto);
            if (result.Success)
            {
                return Ok(objectMapper.Map<IList<DecompositionShelf>, IList<ListDecompositionShelfDto>>(result.Data));
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetPagedList")]
        public async Task<IActionResult> GetPagedList([FromQuery] DecompositionShelfListParameterDto dto)
        {
            IDataResult<PagedResult<DecompositionShelf>> result = await decompositionShelfService.GetPagedListAsync(dto);
            if (result.Success)
            {
                return Ok(objectMapper.Map<PagedResult<DecompositionShelf>, PagedResult<ListDecompositionShelfDto>>(result.Data));
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetParameter")]
        public async Task<IActionResult> GetParameter([FromQuery] DecompositionShelfCodeParameterDto dto)
        {
            IDataResult<DecompositionShelf> result = await decompositionShelfService.GetParameterAsync(dto);
            if (result.Success)
            {
                return Ok(new DataResult<SelectDecompositionShelfDto>(objectMapper.Map<DecompositionShelf, SelectDecompositionShelfDto>(result.Data), result.Message, true));
            }
            return BadRequest(result.Message);
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            IDataResult<DecompositionShelf> dataResult = await decompositionShelfService.GetAsync(id);
            if (dataResult.Success)
            {
                return Ok(new DataResult<SelectDecompositionShelfDto>(objectMapper.Map<DecompositionShelf, SelectDecompositionShelfDto>(dataResult.Data), dataResult.Message, true));
            }
            return BadRequest(dataResult.Message);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateDecompositionShelfDto dto)
        {
            IDataResult<DecompositionShelf> dataResult = await decompositionShelfService.CreateAsync(objectMapper.Map<CreateDecompositionShelfDto, DecompositionShelf>(dto));
            if (dataResult.Success)
            {
                return Ok(new DataResult<SelectDecompositionShelfDto>(objectMapper.Map<DecompositionShelf, SelectDecompositionShelfDto>(dataResult.Data), dataResult.Message, true));
            }
            return BadRequest(dataResult.Message);
        }
        [HttpPut("Update")]
        public async Task<ActionResult<DecompositionShelf>> Update([FromBody] UpdateDecompositionShelfDto dto)
        {
            IDataResult<DecompositionShelf> dataResult = await decompositionShelfService.CreateAsync(objectMapper.Map<UpdateDecompositionShelfDto, DecompositionShelf>(dto));
            if (dataResult.Success)
            {
                return Ok(new DataResult<SelectDecompositionShelfDto>(objectMapper.Map<DecompositionShelf, SelectDecompositionShelfDto>(dataResult.Data), dataResult.Message, true));
            }
            return BadRequest(dataResult.Message);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteDecompositionShelf([FromQuery] Guid id)
        {
            IDataResult<DecompositionShelf> dataResult = await decompositionShelfService.GetAsync(id);
            if (dataResult.Success)
            {
                IDataResult<DecompositionShelf> result = await decompositionShelfService.DeleteAsync(dataResult.Data);
                if (result.Success)
                {
                    return Ok(new DataResult<SelectDecompositionShelfDto>(objectMapper.Map<DecompositionShelf, SelectDecompositionShelfDto>(dataResult.Data), dataResult.Message, true));
                }
                return BadRequest(result.Message);
            }
            return BadRequest(dataResult.Message);
        }
    }
}
