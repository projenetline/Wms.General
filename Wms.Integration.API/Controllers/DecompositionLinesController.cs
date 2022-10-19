using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.DecompositionLines;

namespace Wms.Integration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DecompositionLinesController : ControllerBase
    {
        private readonly ILoggerDal loggerDal;
        private readonly IDecompositionLineService decompositionLineService;
        private readonly IMapper objectMapper;
        public DecompositionLinesController(IDecompositionLineService decompositionLineService,ILoggerDal loggerDal,IMapper objectMapper)
        {
            this.objectMapper=objectMapper;
            this.loggerDal = loggerDal;
            this.decompositionLineService = decompositionLineService;
        }
        [HttpGet("GetList")]
        public async Task<IActionResult> GetList([FromQuery] DecompositionLineListParameterDto dto)
        {
            IDataResult<IList<DecompositionLine>> result = await decompositionLineService.GetListAsync(dto);
            if (result.Success)
            {
                return Ok(objectMapper.Map<IList<DecompositionLine>, IList<ListDecompositionLineDto>>(result.Data));
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetPagedList")]
        public async Task<IActionResult> GetPagedList([FromQuery] DecompositionLineListParameterDto dto)
        {
            IDataResult<PagedResult<DecompositionLine>> result = await decompositionLineService.GetPagedListAsync(dto);
            if (result.Success)
            {
                return Ok(objectMapper.Map<PagedResult<DecompositionLine>, PagedResult<ListDecompositionLineDto>>(result.Data));
            }
            return BadRequest(result.Message);
        }
        [HttpGet("GetParameter")]
        public async Task<IActionResult> GetParameter([FromQuery] DecompositionLineCodeParameterDto dto)
        {
            IDataResult<DecompositionLine> result = await decompositionLineService.GetParameterAsync(dto);
            if (result.Success)
            {
                return Ok(new DataResult<SelectDecompositionLineDto>(objectMapper.Map<DecompositionLine, SelectDecompositionLineDto>(result.Data), result.Message, true));
            }
            return BadRequest(result.Message);
        }
        [HttpGet("Get")]
        public async Task<IActionResult> Get([FromQuery] Guid id)
        {
            IDataResult<DecompositionLine> dataResult = await decompositionLineService.GetAsync(id);
            if (dataResult.Success)
            {
                return Ok(new DataResult<SelectDecompositionLineDto>(objectMapper.Map<DecompositionLine, SelectDecompositionLineDto>(dataResult.Data), dataResult.Message, true));
            }
            return BadRequest(dataResult.Message);
        }
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] CreateDecompositionLineDto dto)
        {
            IDataResult<DecompositionLine> dataResult = await decompositionLineService.CreateAsync(objectMapper.Map<CreateDecompositionLineDto, DecompositionLine>(dto));
            if (dataResult.Success)
            {
                return Ok(new DataResult<SelectDecompositionLineDto>(objectMapper.Map<DecompositionLine, SelectDecompositionLineDto>(dataResult.Data), dataResult.Message, true));
            }
            return BadRequest(dataResult.Message);
        }
        [HttpPut("Update")]
        public async Task<IActionResult> Update([FromBody] UpdateDecompositionLineDto dto)
        {
            IDataResult<DecompositionLine> dataResult = await decompositionLineService.UpdateAsync(objectMapper.Map<UpdateDecompositionLineDto, DecompositionLine>(dto));
            if (dataResult.Success)
            {
                return Ok(new DataResult<SelectDecompositionLineDto>(objectMapper.Map<DecompositionLine, SelectDecompositionLineDto>(dataResult.Data), dataResult.Message, true));
            }
            return BadRequest(dataResult.Message);
        }
        [HttpDelete("Delete")]
        public async Task<IActionResult> DeleteDecompositionShelf([FromQuery] Guid id)
        {
            IDataResult<DecompositionLine> dataResult = await decompositionLineService.GetAsync(id);
            if (dataResult.Success)
            {
                IDataResult<DecompositionLine> result = await decompositionLineService.DeleteAsync(dataResult.Data);
                if (result.Success)
                {
                    return Ok(new DataResult<SelectDecompositionLineDto>(objectMapper.Map<DecompositionLine, SelectDecompositionLineDto>(dataResult.Data), dataResult.Message, true));
                }
                return BadRequest(result.Message);
            }
            return BadRequest(dataResult.Message);
        }
    }
}
