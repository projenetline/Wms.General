using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.Decompositions;

namespace Wms.Integration.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PurchaseOrdersController : ControllerBase
    {
       
        [HttpPost("Create")]
        public async Task<IActionResult> Create([FromBody] OrderSlip dto)
        {
            return Ok();
        }
    }
}
