using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Core.DataAccess.Utilities.Results;
using Wms.Integration.Entities.Concrete;
using Wms.Integration.Entities.Dtos.PurchaseOrders;

namespace Wms.Integration.API.Controllers
{
    [Route("netlineapi/wms/[controller]")]
    [ApiController]
    public class PurchaseOrdersController : ControllerBase
    {
        private readonly IOrderSlipService orderSlipService;
        private readonly ISysWarehouseService warehouseService;
        private readonly IArpService arpService;
        private readonly ISysFactoryService factoryService;
        private readonly ISysDivisionService divisionService;
        private readonly ISysDepartmentService departmentService;
        private readonly IItemService itemService;
        private readonly IItemUnitService itemUnitService;
        private readonly IMapper objectMapper;
        private readonly ILoggerService loggerService;
        private readonly IOrderSlipLineService orderSlipLineService;
        public PurchaseOrdersController(IOrderSlipService orderSlipService, ISysWarehouseService warehouseService, IArpService arpService,
                                        IItemService itemService, ISysFactoryService factoryService, ISysDivisionService divisionService,
                                        ISysDepartmentService departmentService, IMapper objectMapper, ILoggerService loggerService,
                                        IItemUnitService itemUnitService,IOrderSlipLineService orderSlipLineService)
        {
            this.orderSlipLineService = orderSlipLineService;
            this.itemUnitService = itemUnitService;
            this.itemService = itemService;
            this.factoryService = factoryService;
            this.orderSlipService = orderSlipService;
            this.warehouseService = warehouseService;
            this.arpService = arpService;
            this.divisionService = divisionService;
            this.departmentService = departmentService;
            this.objectMapper = objectMapper;
            this.loggerService = loggerService;
        }
        [HttpPost("CreateOrder")]
        public async Task<IActionResult> CreateOrder([FromBody] CreatePurchaseOrdersDto dto)
        {
            try
            {
                IDataResult<SysWarehouse> warehouseResult = await warehouseService.GetCodeAsync(dto.WareHouseCode);
                if (warehouseResult.Success)
                {
                    IDataResult<Arp> arpResult = await arpService.GetCodeAsync(dto.ArpCode);
                    if (arpResult.Success)
                    {
                        IDataResult<SysFactory> factoryResult = await factoryService.GetCodeAsync(dto.FactoryCode);
                        if (factoryResult.Success)
                        {
                            IDataResult<SysDivision> divisionResult = await divisionService.GetCodeAsync(dto.DivisionCode);
                            if (divisionResult.Success)
                            {
                                IDataResult<SysDepartment> departmentResult = await departmentService.GetCodeAsync(dto.DepartmentCode);
                                if (departmentResult.Success)
                                {
                                    OrderSlip slip = objectMapper.Map<CreatePurchaseOrdersDto, OrderSlip>(dto);
                                    slip.Warehouse = warehouseResult.Data;
                                    slip.WarehouseId = warehouseResult.Data.Id;
                                    slip.Arp = arpResult.Data;
                                    slip.ArpId = arpResult.Data.Id;
                                    slip.Factory = factoryResult.Data;
                                    slip.FactoryId = factoryResult.Data.Id;
                                    slip.Division = divisionResult.Data;
                                    slip.DivisionId = divisionResult.Data.Id;
                                    slip.Department = departmentResult.Data;
                                    slip.DepartmentId = departmentResult.Data.Id;
                                    IDataResult<OrderSlip> slipResult = await orderSlipService.CreateAsync(slip);
                                    if (slipResult.Success)
                                    {
                                        IDataResult<Item> itemResult;
                                        IDataResult<ItemUnit> itemUnitResult;
                                        foreach (CreatePurchaseOrdersLineDto item in dto.createPurchaseOrdersLineDtos)
                                        {
                                            itemResult = await itemService.GetCodeAsync(item.ItemCode);
                                            if (itemResult.Success)
                                            {
                                                itemUnitResult = await itemUnitService.GetItemIdAsync(itemResult.Data.Id);
                                                if (itemUnitResult.Success)
                                                {
                                                    factoryResult = await factoryService.GetCodeAsync(dto.FactoryCode);
                                                    if (factoryResult.Success)
                                                    {
                                                        divisionResult = await divisionService.GetCodeAsync(dto.DivisionCode);
                                                        if (divisionResult.Success)
                                                        {
                                                            departmentResult = await departmentService.GetCodeAsync(dto.DepartmentCode);
                                                            if (departmentResult.Success)
                                                            {
                                                                warehouseResult = await warehouseService.GetCodeAsync(dto.WareHouseCode);
                                                                if (warehouseResult.Success)
                                                                {
                                                                    arpResult = await arpService.GetCodeAsync(dto.ArpCode);
                                                                    if (arpResult.Success)
                                                                    {
                                                                        OrderSlipLine line = objectMapper.Map<CreatePurchaseOrdersLineDto, OrderSlipLine>(item);
                                                                        line.Arp = arpResult.Data;
                                                                        line.ArpId = arpResult.Data.Id;
                                                                        line.Slip = slipResult.Data;
                                                                        line.SlipId = slipResult.Data.Id;
                                                                        line.Warehouse = warehouseResult.Data;
                                                                        line.WarehouseId = warehouseResult.Data.Id;
                                                                        line.Department = departmentResult.Data;
                                                                        line.DepartmentId = departmentResult.Data.Id;
                                                                        line.FactoryId = factoryResult.Data.Id;
                                                                        line.DivisionId = divisionResult.Data.Id;
                                                                        line.Item = itemResult.Data;
                                                                        line.ItemId = itemResult.Data.Id;
                                                                        line.Unit = itemUnitResult.Data;
                                                                        line.UnitId = itemUnitResult.Data.Id;
                                                                        IDataResult<OrderSlipLine> lineResult = await orderSlipLineService.CreateAsync(line);
                                                                        if (lineResult.Success)
                                                                        {
                                                                            slip.OrderSlipLines.Add(lineResult.Data);
                                                                        }
                                                                        return BadRequest(lineResult.Message);
                                                                    }
                                                                    return BadRequest(arpResult.Message);
                                                                }
                                                                return BadRequest(warehouseResult.Message);
                                                            }
                                                            return BadRequest(departmentResult.Message);
                                                        }
                                                        return BadRequest(factoryResult.Message);
                                                    }
                                                    return BadRequest(factoryResult.Message);
                                                }
                                                return BadRequest(itemUnitResult.Message);
                                            }
                                            return BadRequest(itemResult.Message);
                                        }
                                        return Ok(slip);
                                    }
                                    return BadRequest(slipResult.Message);
                                }
                                return BadRequest(departmentResult.Message);
                            }
                            return BadRequest(divisionResult.Message);
                        }
                        return BadRequest(factoryResult.Message);
                    }
                    return BadRequest(arpResult.Message);
                }
                return BadRequest(warehouseResult.Message);
            }
            catch (Exception ex)
            {
                Logger logger = await loggerService.CreateAsync(new Logger
                {
                    Message1 = ex.Message,
                    Message2 = ex.InnerException == null ?"":ex.InnerException.Message,
                    CreatedDate = DateTime.Now,
                    MethodName= " PurchaseOrdersController.CreateOrder",
                    ProjectName= "Wms.Integration.API",
                    Statu="Error"
                }) ;
                return BadRequest($"İstenilmeyen bir hata ile karşılaşıldı! Error Id:{logger.Id} "); 
            }
        }
    }
}
