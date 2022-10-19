using Microsoft.EntityFrameworkCore;
using Wms.Integration.API.Middleware;
using Wms.Integration.Business.Abstract;
using Wms.Integration.Business.Concrete;
using Wms.Integration.DataAccess.Abstract;
using Wms.Integration.DataAccess.Concrete;
using Wms.Integration.DataAccess.Concrete.Contexts;
using Wms.Integration.Entities.Concrete;

var builder = WebApplication.CreateBuilder(args);
//builder.WebHost.UseDefaultServiceProvider(options =>
//            options.ValidateScopes = true);

builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());

#region Scoped Service - Manager
builder.Services.AddScoped<IAddressItemService, AddressItemManager>();
builder.Services.AddScoped<IArpService, ArpManager>();
builder.Services.AddScoped<IAuthService, AuthManager>();
builder.Services.AddScoped<ICarrierService, CarrierManager>();
builder.Services.AddScoped<IContainerService, ContainerManager>();
builder.Services.AddScoped<IDecompositionService, DecompositionManager>();
builder.Services.AddScoped<IDecompositionLineService, DecompositionLineManager>();
builder.Services.AddScoped<IDecompositionShelfService, DecompositionShelfManager>();
builder.Services.AddScoped<IDecompositionShelvesService, DecompositionShelvesManager>();
builder.Services.AddScoped<IDocumentService, DocumentManager>();
builder.Services.AddScoped<IDriverService, DriverManager>();
builder.Services.AddScoped<IErpinvTotalService, ErpinvTotalManager>();
builder.Services.AddScoped<IFormLayoutService, FormLayoutManager>();
builder.Services.AddScoped<IHistoryDetailService, HistoryDetailManager>();
builder.Services.AddScoped<IHistoryService, HistoryManager>();
builder.Services.AddScoped<IItemClassRelationService, ItemClassRelationManager>();
builder.Services.AddScoped<IItemContentService, ItemContentManager>();
builder.Services.AddScoped<IItemExtraService, ItemExtraManager>();
builder.Services.AddScoped<IItemParameterService, ItemParameterManager>();
builder.Services.AddScoped<IItemService, ItemManager>();
builder.Services.AddScoped<IItemTotalsReportViewService, ItemTotalsReportViewManager>();
builder.Services.AddScoped<IItemTotalsViewService, ItemTotalsViewManager>();
builder.Services.AddScoped<IItemTrackingTotalsViewService, ItemTrackingTotalsViewManager>();
builder.Services.AddScoped<IItemUnitService, ItemUnitManager>();
builder.Services.AddScoped<ILoggerService, LoggerManager>();
builder.Services.AddScoped<ILoginHistoryService, LoginHistoryManager>();
builder.Services.AddScoped<IOrderSlipLineService, OrderSlipLineManager>();
builder.Services.AddScoped<IOrderSlipService, OrderSlipManager>();
builder.Services.AddScoped<IPlanningSlipLineService, PlanningSlipLineManager>();
builder.Services.AddScoped<IPlanningSlipService, PlanningSlipManager>();
builder.Services.AddScoped<IProductionOrderService, ProductionOrderManager>();
builder.Services.AddScoped<IProjectService, ProjectManager>();
builder.Services.AddScoped<IReservationSlipLineService, ReservationSlipLineManager>();
builder.Services.AddScoped<IReservationSlipService, ReservationSlipManager>();
builder.Services.AddScoped<ISalesPersonService, SalesPersonManager>();
builder.Services.AddScoped<IShiftPeriodService, ShiftPeriodManager>();
builder.Services.AddScoped<IShiftService, ShiftManager>();
builder.Services.AddScoped<IShipmentAddressService, ShipmentAddressManager>();
builder.Services.AddScoped<IShipmentDayService, ShipmentDayManager>();
builder.Services.AddScoped<ISlipService, SlipManager>();
builder.Services.AddScoped<ISysAddressService, SysAddressManager>();
builder.Services.AddScoped<ISysAuthCodeService, SysAuthCodeManager>();
builder.Services.AddScoped<ISysBlockingExceptionService, SysBlockingExceptionManager>();
builder.Services.AddScoped<ISysBlockingTypeService, SysBlockingTypeManager>();
builder.Services.AddScoped<ISysContainerRelationService, SysContainerRelationManager>();
builder.Services.AddScoped<ISysContainerTypeService, SysContainerTypeManager>();
builder.Services.AddScoped<ISysCustomCodeService, SysCustomCodeManager>();
builder.Services.AddScoped<ISysCustomListColumnService, SysCustomListColumnManager>();
builder.Services.AddScoped<ISysCustomReportService, SysCustomReportManager>();
builder.Services.AddScoped<ISysCustomRuleActionService, SysCustomRuleActionManager>();
builder.Services.AddScoped<ISysCustomRuleService, SysCustomRuleManager>();
builder.Services.AddScoped<ISysCustomSlipTypeService, SysCustomSlipTypeManager>();
builder.Services.AddScoped<ISysCustomStateService, SysCustomStateManager>();
builder.Services.AddScoped<ISysCustomTableService, SysCustomTableManager>();
builder.Services.AddScoped<ISysDepartmentService, SysDepartmentManager>();
builder.Services.AddScoped<ISysDivisionService, SysDivisionManager>();
builder.Services.AddScoped<ISysErpFirmService, SysErpFirmManager>();
builder.Services.AddScoped<ISysErpIntegrationService, SysErpIntegrationManager>();
builder.Services.AddScoped<ISysErpService, SysErpManager>();
builder.Services.AddScoped<ISysFactoryService, SysFactoryManager>();
builder.Services.AddScoped<ISysLogService, SysLogManager>();
builder.Services.AddScoped<ISysMenuRightService, SysMenuRightManager>();
builder.Services.AddScoped<ISysNetLockService, SysNetLockManager>();
builder.Services.AddScoped<ISysParameterService, SysParameterManager>();
builder.Services.AddScoped<ISysPasswordHistoryService, SysPasswordHistoryManager>();
builder.Services.AddScoped<ISysPasswordPolicyService, SysPasswordPolicyManager>();
builder.Services.AddScoped<ISysPrinterService, SysPrinterManager>();
builder.Services.AddScoped<ISysRoleService, SysRoleManager>();
builder.Services.AddScoped<ISysScriptService, SysScriptManager>();
builder.Services.AddScoped<ISysSessionService, SysSessionManager>();
builder.Services.AddScoped<ISysUserService, SysUserManager>();
builder.Services.AddScoped<ISysUserWarehouseService, SysUserWarehouseManager>();
builder.Services.AddScoped<ISysWarehouseBlockService, SysWarehouseBlockManager>();
builder.Services.AddScoped<ISysWarehouseFloorService, SysWarehouseFloorManager>();
builder.Services.AddScoped<ISysWarehouseZoneService, SysWarehouseZoneManager>();
builder.Services.AddScoped<ISysWarehouseService, SysWarehouseManager>();
builder.Services.AddScoped<ITransactionDetailService, TransactionDetailManager>();
builder.Services.AddScoped<ITransactionDetailViewService, TransactionDetailViewManager>();
builder.Services.AddScoped<IUnitBarcodeService, UnitBarcodeManager>();
builder.Services.AddScoped<IUserService, UserManager>();
builder.Services.AddScoped<IVariantTotalsViewService, VariantTotalsViewManager>();
builder.Services.AddScoped<IVariantTrackingTotalsViewService, VariantTrackingTotalsViewManager>();
builder.Services.AddScoped<IVehicleService, VehicleManager>();
builder.Services.AddScoped<IWorkOrderLineService, WorkOrderLineManager>();
builder.Services.AddScoped<IWorkOrderService, WorkOrderManager>();

#endregion
#region Dal - EfDal

builder.Services.AddScoped<ILoggerDal, EfLoggerDal>();
builder.Services.AddScoped<IHttpLoggerDal, EfHttpLoggerDal>();
builder.Services.AddScoped<IDecompositionDal, EfDecompositionDal>();
builder.Services.AddScoped<IDecompositionLineDal, EfDecompositionLineDal>();
builder.Services.AddScoped<IDecompositionShelfDal, EfDecompositionShelfDal>();
builder.Services.AddScoped<IDecompositionShelvesDal, EfDecompositionShelvesDal>();
builder.Services.AddScoped<IUserDal, EfUserDal>();
builder.Services.AddScoped<IAddressItemDal, EfAddressItemDal>();
builder.Services.AddScoped<IArpDal, EfArpDal>();
builder.Services.AddScoped<ICarrierDal, EfCarrierDal>();
builder.Services.AddScoped<IContainerDal, EfContainerDal>();
builder.Services.AddScoped<IDocumentDal, EfDocumentDal>();
builder.Services.AddScoped<IDriverDal, EfDriverDal>();
builder.Services.AddScoped<IErpinvTotalDal, EfErpinvTotalDal>();
builder.Services.AddScoped<IFormLayoutDal, EfFormLayoutDal>();
builder.Services.AddScoped<IHistoryDetailDal, EfHistoryDetailDal>();
builder.Services.AddScoped<IHistoryDal, EfHistoryDal>();
builder.Services.AddScoped<IItemClassRelationDal, EfItemClassRelationDal>();
builder.Services.AddScoped<IItemContentDal, EfItemContentDal>();
builder.Services.AddScoped<IItemExtraDal, EfItemExtraDal>();
builder.Services.AddScoped<IItemParameterDal, EfItemParameterDal>();
builder.Services.AddScoped<IItemDal, EfItemDal>();
builder.Services.AddScoped<IItemTotalsReportViewDal, EfItemTotalsReportViewDal>();
builder.Services.AddScoped<IItemTotalsViewDal, EfItemTotalsViewDal>();
builder.Services.AddScoped<IItemTrackingTotalsViewDal, EfItemTrackingTotalsViewDal>();
builder.Services.AddScoped<IItemUnitDal, EfItemUnitDal>();
builder.Services.AddScoped<ILoginHistoryDal, EfLoginHistoryDal>();
builder.Services.AddScoped<IOrderSlipLineDal, EfOrderSlipLineDal>();
builder.Services.AddScoped<IOrderSlipDal, EfOrderSlipDal>();
builder.Services.AddScoped<IPlanningSlipLineDal, EfPlanningSlipLineDal>();
builder.Services.AddScoped<IPlanningSlipDal, EfPlanningSlipDal>();
builder.Services.AddScoped<IProductionOrderDal, EfProductionOrderDal>();
builder.Services.AddScoped<IProjectDal, EfProjectDal>();
builder.Services.AddScoped<IReservationSlipLineDal, EfReservationSlipLineDal>();
builder.Services.AddScoped<IReservationSlipDal, EfReservationSlipDal>();
builder.Services.AddScoped<ISalesPersonDal, EfSalesPersonDal>();
builder.Services.AddScoped<IShiftPeriodDal, EfShiftPeriodDal>();
builder.Services.AddScoped<IShiftDal, EfShiftDal>();
builder.Services.AddScoped<IShipmentAddressDal, EfShipmentAddressDal>();
builder.Services.AddScoped<IShipmentDayDal, EfShipmentDayDal>();
builder.Services.AddScoped<ISlipDal, EfSlipDal>();
builder.Services.AddScoped<ISysAddressDal, EfSysAddressDal>();
builder.Services.AddScoped<ISysAuthCodeDal, EfSysAuthCodeDal>();
builder.Services.AddScoped<ISysBlockingExceptionDal, EfSysBlockingExceptionDal>();
builder.Services.AddScoped<ISysBlockingTypeDal, EfSysBlockingTypeDal>();
builder.Services.AddScoped<ISysContainerRelationDal, EfSysContainerRelationDal>();
builder.Services.AddScoped<ISysContainerTypeDal, EfSysContainerTypeDal>();
builder.Services.AddScoped<ISysCustomCodeDal, EfSysCustomCodeDal>();
builder.Services.AddScoped<ISysCustomListColumnDal, EfSysCustomListColumnDal>();
builder.Services.AddScoped<ISysCustomReportDal, EfSysCustomReportDal>();
builder.Services.AddScoped<ISysCustomRuleActionDal, EfSysCustomRuleActionDal>();
builder.Services.AddScoped<ISysCustomRuleDal, EfSysCustomRuleDal>();
builder.Services.AddScoped<ISysCustomSlipTypeDal, EfSysCustomSlipTypeDal>();
builder.Services.AddScoped<ISysCustomStateDal, EfSysCustomStateDal>();
builder.Services.AddScoped<ISysCustomTableDal, EfSysCustomTableDal>();
builder.Services.AddScoped<ISysDepartmentDal, EfSysDepartmentDal>();
builder.Services.AddScoped<ISysDivisionDal, EfSysDivisionDal>();
builder.Services.AddScoped<ISysErpFirmDal, EfSysErpFirmDal>();
builder.Services.AddScoped<ISysErpIntegrationDal, EfSysErpIntegrationDal>();
builder.Services.AddScoped<ISysErpDal, EfSysErpDal>();
builder.Services.AddScoped<ISysFactoryDal, EfSysFactoryDal>();
builder.Services.AddScoped<ISysLogDal, EfSysLogDal>();
builder.Services.AddScoped<ISysMenuRightDal, EfSysMenuRightDal>();
builder.Services.AddScoped<ISysNetLockDal, EfSysNetLockDal>();
builder.Services.AddScoped<ISysParameterDal, EfSysParameterDal>();
builder.Services.AddScoped<ISysPasswordHistoryDal, EfSysPasswordHistoryDal>();
builder.Services.AddScoped<ISysPasswordPolicyDal, EfSysPasswordPolicyDal>();
builder.Services.AddScoped<ISysPrinterDal, EfSysPrinterDal>();
builder.Services.AddScoped<ISysRoleDal, EfSysRoleDal>();
builder.Services.AddScoped<ISysScriptDal, EfSysScriptDal>();
builder.Services.AddScoped<ISysSessionDal, EfSysSessionDal>();
builder.Services.AddScoped<ISysUserDal, EfSysUserDal>();
builder.Services.AddScoped<ISysUserWarehouseDal, EfSysUserWarehouseDal>();
builder.Services.AddScoped<ISysWarehouseBlockDal, EfSysWarehouseBlockDal>();
builder.Services.AddScoped<ISysWarehouseFloorDal, EfSysWarehouseFloorDal>();
builder.Services.AddScoped<ISysWarehouseZoneDal, EfSysWarehouseZoneDal>();
builder.Services.AddScoped<ISysWarehouseDal, EfSysWarehouseDal>();
builder.Services.AddScoped<ITransactionDetailDal, EfTransactionDetailDal>();
builder.Services.AddScoped<ITransactionDetailViewDal, EfTransactionDetailViewDal>();
builder.Services.AddScoped<IUnitBarcodeDal, EfUnitBarcodeDal>();
builder.Services.AddScoped<IVariantTotalsViewDal, EfVariantTotalsViewDal>();
builder.Services.AddScoped<IVariantTrackingTotalsViewDal, EfVariantTrackingTotalsViewDal>();
builder.Services.AddScoped<IVehicleDal, EfVehicleDal>();
builder.Services.AddScoped<IWorkOrderLineDal, EfWorkOrderLineDal>();
builder.Services.AddScoped<IWorkOrderDal, EfWorkOrderDal>();
#endregion
// Add services to the container.
//------------------------------------------------------



//------------------------------------------------------

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();



builder.Services.AddDbContext<WMSContext>(options => options.UseSqlServer("Server=NETLINE;Database=WMS;user id=sa;password=net_123"));

var app = builder.Build();


// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseHttpsRedirection();

app.UseAuthorization();

app.UseHttpLoggingMiddleware();

app.MapControllers();

app.Run();