using Microsoft.EntityFrameworkCore;
using System.Data;
using Wms.Integration.Core.Entities.Concrete;
using Wms.Integration.Entities.Concrete;
namespace Wms.Integration.DataAccess.Concrete.Contexts
{
    public partial class WMSContext : DbContext
    {
        public WMSContext()
        {
        }

        public WMSContext(DbContextOptions<WMSContext> options)
            : base(options)
        {
        }
        //User
        public virtual DbSet<OperationClaim> OperationClaims { get; set; }
        public virtual DbSet<User> Users { get; set; }
        public virtual DbSet<UserOperationClaim> UserOperationClaims { get; set; }

        //---------------------------------------------------------------
        public virtual DbSet<EfAddressItemDal> AddressItems { get; set; }
        public virtual DbSet<Arp> Arps { get; set; }
        public virtual DbSet<EfCarrierDal> Carriers { get; set; }
        public virtual DbSet<Container> Containers { get; set; }
        public virtual DbSet<Decomposition> Decompositions { get; set; }
        public virtual DbSet<DecompositionLine> DecompositionLines { get; set; }
        public virtual DbSet<DecompositionShelf> DecompositionShelfs { get; set; }
        public virtual DbSet<DecompositionShelves> DecompositionShelves { get; set; }
        public virtual DbSet<EfDocumentDal> Documents { get; set; }
        public virtual DbSet<IDriverDal> Drivers { get; set; }
        public virtual DbSet<EfErpinvTotalDal> ErpinvTotals { get; set; }
        public virtual DbSet<EfFormLayoutDal> FormLayouts { get; set; }
        public virtual DbSet<EfHistoryDal> Histories { get; set; }
        public virtual DbSet<EfHistoryDetailDal> HistoryDetails { get; set; }
        public virtual DbSet<EfItemDal> Items { get; set; }
        public virtual DbSet<EfItemClassRelationDal> ItemClassRelations { get; set; }
        public virtual DbSet<EfItemContentDal> ItemContents { get; set; }
        public virtual DbSet<EfItemExtraDal> ItemExtras { get; set; }
        public virtual DbSet<EfItemParameterDal> ItemParameters { get; set; }
        public virtual DbSet<EfItemTotalsReportViewDal> ItemTotalsReportViews { get; set; }
        public virtual DbSet<EfItemTotalsViewDal> ItemTotalsViews { get; set; }
        public virtual DbSet<EfItemTrackingTotalsViewDal> ItemTrackingTotalsViews { get; set; }
        public virtual DbSet<EfItemUnitDal> ItemUnits { get; set; }
        public virtual DbSet<Logger> Loggers { get; set; }
        public virtual DbSet<EfLoginHistoryDal> LoginHistories { get; set; }
        public virtual DbSet<EfOrderSlipDal> OrderSlips { get; set; }
        public virtual DbSet<EfOrderSlipLineDal> OrderSlipLines { get; set; }
        public virtual DbSet<EfPlanningSlipDal> PlanningSlips { get; set; }
        public virtual DbSet<EfPlanningSlipLineDal> PlanningSlipLines { get; set; }
        public virtual DbSet<EfProductionOrderDal> ProductionOrders { get; set; }
        public virtual DbSet<EfProductionOrderLineDal> ProductionOrderLines { get; set; }
        public virtual DbSet<EfProjectDal> Projects { get; set; }
        public virtual DbSet<EfReservationSlipDal> ReservationSlips { get; set; }
        public virtual DbSet<EfReservationSlipLineDal> ReservationSlipLines { get; set; }
        public virtual DbSet<EfSalesPersonDal> SalesPeople { get; set; }
        public virtual DbSet<EfShiftDal> Shifts { get; set; }
        public virtual DbSet<EfShiftPeriodDal> ShiftPeriods { get; set; }
        public virtual DbSet<EfShipmentAddressDal> ShipmentAddresses { get; set; }
        public virtual DbSet<EfShipmentDayDal> ShipmentDays { get; set; }
        public virtual DbSet<EfSlipDal> Slips { get; set; }
        public virtual DbSet<efSlipLineDal> SlipLines { get; set; }
        public virtual DbSet<EfSysAddressDal> SysAddresses { get; set; }
        public virtual DbSet<EfSysAuthCodeDal> SysAuthCodes { get; set; }
        public virtual DbSet<EfSysBlockingExceptionDal> SysBlockingExceptions { get; set; }
        public virtual DbSet<EfSysBlockingTypeDal> SysBlockingTypes { get; set; }
        public virtual DbSet<EfSysContainerRelationDal> SysContainerRelations { get; set; }
        public virtual DbSet<EfSysContainerTypeDal> SysContainerTypes { get; set; }
        public virtual DbSet<EfSysCustomCodeDal> SysCustomCodes { get; set; }
        public virtual DbSet<EfSysCustomListColumnDal> SysCustomListColumns { get; set; }
        public virtual DbSet<EfSysCustomReportDal> SysCustomReports { get; set; }
        public virtual DbSet<EfSysCustomRuleDal> SysCustomRules { get; set; }
        public virtual DbSet<efSysCustomRuleActionDal> SysCustomRuleActions { get; set; }
        public virtual DbSet<EfSysCustomSlipTypeDal> SysCustomSlipTypes { get; set; }
        public virtual DbSet<EfSysCustomStateDal> SysCustomStates { get; set; }
        public virtual DbSet<EfSysCustomTableDal> SysCustomTables { get; set; }
        public virtual DbSet<EfSysDepartmentDal> SysDepartments { get; set; }
        public virtual DbSet<EfSysDivisionDal> SysDivisions { get; set; }
        public virtual DbSet<EfSysErpDal> SysErps { get; set; }
        public virtual DbSet<EfSysErpFirmDal> SysErpFirms { get; set; }
        public virtual DbSet<EfSysErpIntegrationDal> SysErpIntegrations { get; set; }
        public virtual DbSet<EfSysFactoryDal> SysFactories { get; set; }
        public virtual DbSet<EfSysLogDal> SysLogs { get; set; }
        public virtual DbSet<EfSysMenuRightDal> SysMenuRights { get; set; }
        public virtual DbSet<EfSysNetLockDal> SysNetLocks { get; set; }
        public virtual DbSet<EfSysParameterDal> SysParameters { get; set; }
        public virtual DbSet<EfSysPasswordHistoryDal> SysPasswordHistories { get; set; }
        public virtual DbSet<EfSysPasswordPolicyDal> SysPasswordPolicies { get; set; }
        public virtual DbSet<EfSysPrinterDal> SysPrinters { get; set; }
        public virtual DbSet<EfSysRoleDal> SysRoles { get; set; }
        public virtual DbSet<EfSysScriptDal> SysScripts { get; set; }
        public virtual DbSet<EfSysSessionDal> SysSessions { get; set; }
        public virtual DbSet<EfSysUserDal> SysUsers { get; set; }
        public virtual DbSet<EfSysUserWarehouseDal> SysUserWarehouses { get; set; }
        public virtual DbSet<EfSysWarehouseDal> SysWarehouses { get; set; }
        public virtual DbSet<EfSysWarehouseBlockDal> SysWarehouseBlocks { get; set; }
        public virtual DbSet<EfSysWarehouseFloorDal> SysWarehouseFloors { get; set; }
        public virtual DbSet<EfSysWarehouseZoneDal> SysWarehouseZones { get; set; }
        public virtual DbSet<EfTransactionDetailDal> TransactionDetails { get; set; }
        public virtual DbSet<EfTransactionDetailViewDal> TransactionDetailViews { get; set; }
        public virtual DbSet<EfUnitBarcodeDal> UnitBarcodes { get; set; }
        public virtual DbSet<efVariantTotalsViewDal> VariantTotalsViews { get; set; }
        public virtual DbSet<EfVariantTrackingTotalsViewDal> VariantTrackingTotalsViews { get; set; }
        public virtual DbSet<EfVehicleDal> Vehicles { get; set; }
        public virtual DbSet<EfWorkOrderDal> WorkOrders { get; set; }
        public virtual DbSet<EfWorkOrderLineDal> WorkOrderLines { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=NETLINE;Database=WMS;user id=sa;password=net_123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EfAddressItemDal>(entity =>
            {
                entity.ToTable("AddressItem");

                entity.HasIndex(e => e.Active, "idx_AddressItem_Active");

                entity.HasIndex(e => new { e.AddressId, e.ItemId }, "idx_AddressItem_Item");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.MaxQuantity).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.MinQuantity).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.AddressItems)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("fk_AddressItem_AddressId");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.AddressItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk_AddressItem_ItemId");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.AddressItems)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_AddressItem_WarehouseId");
            });

            modelBuilder.Entity<Arp>(entity =>
            {
                entity.ToTable("Arp");

                entity.HasIndex(e => e.Active, "idx_Arp_Active");

                entity.HasIndex(e => e.Code, "idx_Arp_Code");

                entity.HasIndex(e => new { e.Code, e.Title }, "idx_Arp_Title");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CityCode).HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Contact).HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.Distance).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.FaxNumber1).HasMaxLength(50);

                entity.Property(e => e.FaxNumber2).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber1).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber2).HasMaxLength(50);

                entity.Property(e => e.PostCode).HasMaxLength(50);

                entity.Property(e => e.TaxCode).HasMaxLength(50);

                entity.Property(e => e.TaxNumber).HasMaxLength(50);

                entity.Property(e => e.TaxOffice).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.Town).HasMaxLength(51);

                entity.Property(e => e.Url).HasMaxLength(100);
            });

            modelBuilder.Entity<EfCarrierDal>(entity =>
            {
                entity.ToTable("Carrier");

                entity.HasIndex(e => e.Active, "idx_Carrier_Active");

                entity.HasIndex(e => new { e.Code, e.Description }, "idx_Carrier_Description");

                entity.HasIndex(e => e.Code, "uk_Carrier_Code")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Address1).HasMaxLength(50);

                entity.Property(e => e.Address2).HasMaxLength(50);

                entity.Property(e => e.Code)
                      .IsRequired()
                      .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.FaxNumber).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber1).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber2).HasMaxLength(50);

                entity.Property(e => e.Url).HasMaxLength(50);
            });

            modelBuilder.Entity<Container>(entity =>
            {
                entity.ToTable("Container");

                entity.HasIndex(e => e.Active, "idx_Container_Active");

                entity.HasIndex(e => e.ContainerTypeId, "idx_Container_Type");

                entity.HasIndex(e => e.Lpn, "uk_Container_LPN")
                      .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Lpn)
                      .IsRequired()
                      .HasMaxLength(50)
                      .HasColumnName("LPN");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ContainerType)
                      .WithMany(p => p.Containers)
                      .HasForeignKey(d => d.ContainerTypeId)
                      .OnDelete(DeleteBehavior.ClientSetNull)
                      .HasConstraintName("fk_Container_ContainerTypeId");
            });
          
            modelBuilder.Entity<Decomposition>(entity =>
            {
                entity.ToTable("Decomposition");
                entity.Property(s => s.CreatedDate)
                      .IsRequired()
                      .HasColumnType(SqlDbType.DateTime.ToString())
                      .HasDefaultValue(DateTime.Now);

                entity.Property(s => s.Id)
                      .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

                entity.HasKey(s => s.Id);

                entity.Property(s => s.CreatedBy)
                      .IsRequired()
                      .HasColumnType(SqlDbType.Int.ToString());

                entity.Property(s => s.ModifiedDate)
                      .HasColumnType(SqlDbType.DateTime.ToString());

                entity.Property(s => s.ModifiedBy)
                      .HasColumnType(SqlDbType.Int.ToString());

                entity.Property(s => s.IsCompleted)
                      .HasColumnType(SqlDbType.Bit.ToString());

                entity.Property(s => s.DecompositionShelfId)
                      .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

                entity.HasOne(s => s.DecompositionShelf)
                      .WithMany(s => s.Decompositions)
                      .HasForeignKey(s => s.DecompositionShelfId);
                // .HasConstraintName("fk_Decomposition_DecompositionShelfId");
            });
          
            modelBuilder.Entity<DecompositionLine>(entity =>
            {
                entity.ToTable("DecompositionLine");

                entity.Property(s => s.Id)
                      .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

                entity.HasKey(s => s.Id);

                entity.Property(s => s.SlipLineId)
                       .HasColumnType(SqlDbType.Int.ToString());

                entity.Property(s => s.DecompositionShelvesId)
                     .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

                entity.Property(s => s.Amount)
                     .HasColumnType(SqlDbType.Int.ToString());

                entity.Property(s => s.CreatedDate)
                      .IsRequired()
                      .HasColumnType(SqlDbType.DateTime.ToString())
                      .HasDefaultValue(DateTime.Now);

                entity.Property(s => s.CreatedBy)
                      .IsRequired()
                      .HasColumnType(SqlDbType.Int.ToString());

                entity.Property(s => s.ModifiedDate)
                      .HasColumnType(SqlDbType.DateTime.ToString());

                entity.Property(s => s.ModifiedBy)
                      .HasColumnType(SqlDbType.Int.ToString());

                entity.HasOne(s => s.SlipLine)
                      .WithMany(s => s.DecompositionLines)
                      .HasForeignKey(s => s.SlipLineId);
                //.HasConstraintName("fk_Decomposition_OrderSlipLineId");

                entity.HasOne(s => s.DecompositionShelves)
                     .WithMany(s => s.DecompositionLines)
                     .HasForeignKey(s => s.DecompositionShelvesId);
                //.HasConstraintName("fk_Decomposition_DecompositionShelvesId");
            });
          
            modelBuilder.Entity<DecompositionShelf>(entity =>
            {
                entity.ToTable("DecompositionShelf");

                entity.Property(s => s.Id)
                      .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

                entity.HasKey(s => s.Id);
                entity.Property(s => s.Description)
                      .HasColumnType(SqlDbType.NVarChar.ToString()).HasMaxLength(250);

                entity.Property(s => s.CreatedDate)
                      .IsRequired()
                      .HasColumnType(SqlDbType.DateTime.ToString())
                      .HasDefaultValue(DateTime.Now);

                entity.Property(s => s.CreatedBy)
                      .IsRequired()
                      .HasColumnType(SqlDbType.Int.ToString());

                entity.Property(s => s.ModifiedDate)
                      .HasColumnType(SqlDbType.DateTime.ToString());

                entity.Property(s => s.ModifiedBy)
                      .HasColumnType(SqlDbType.Int.ToString());
                entity.Property(s => s.Capacity)
                      .IsRequired()
                      .HasColumnType(SqlDbType.Int.ToString());

            });
         
            modelBuilder.Entity<DecompositionShelves>(entity =>
            {
                entity.ToTable("DecompositionShelves");

                entity.Property(s => s.Id)
                      .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

                entity.HasKey(s => s.Id);

                entity.Property(s => s.CreatedDate)
                      .IsRequired()
                      .HasColumnType(SqlDbType.DateTime.ToString())
                      .HasDefaultValue(DateTime.Now);

                entity.Property(s => s.CreatedBy)
                      .IsRequired()
                      .HasColumnType(SqlDbType.Int.ToString());

                entity.Property(s => s.ModifiedDate)
                      .HasColumnType(SqlDbType.DateTime.ToString());

                entity.Property(s => s.ModifiedBy)
                      .HasColumnType(SqlDbType.Int.ToString());

                entity.Property(s => s.DecompositionShelfId)
                      .HasColumnType(SqlDbType.UniqueIdentifier.ToString());

                entity.Property(s => s.Description)
                      .HasColumnType(SqlDbType.NVarChar.ToString())
                      .HasMaxLength(250);

                entity.HasOne(s => s.DecompositionShelfs)
                      .WithMany(s => s.DecompositionShelves)
                      .HasForeignKey(s => s.DecompositionShelfId);
                //.HasConstraintName("fk_Decomposition_DecompositionShelfId");
            });

            modelBuilder.Entity<EfDocumentDal>(entity =>
            {
                entity.ToTable("Document");

                entity.HasIndex(e => new { e.RecordType, e.RecordId, e.DocumentType }, "idx_Document_TypeId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.MimeType).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<IDriverDal>(entity =>
            {
                entity.ToTable("Driver");

                entity.HasIndex(e => e.Active, "idx_Driver_Active");

                entity.HasIndex(e => new { e.Name, e.Surname, e.UserId }, "idx_Driver_Name");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.EmailAddress).HasMaxLength(50);

                entity.Property(e => e.IdNumber).HasMaxLength(50);

                entity.Property(e => e.LicenseType).HasMaxLength(5);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber1).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber2).HasMaxLength(50);

                entity.Property(e => e.Surname).HasMaxLength(50);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Drivers)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_Driver_UserId");
            });

            modelBuilder.Entity<EfErpinvTotalDal>(entity =>
            {
                entity.ToTable("ERPInvTotal");

                entity.Property(e => e.Code)
                    .HasMaxLength(50)
                    .HasColumnName("CODE");

                entity.Property(e => e.Convfact1)
                    .HasColumnType("numeric(28, 8)")
                    .HasColumnName("CONVFACT1");

                entity.Property(e => e.Convfact2)
                    .HasColumnType("numeric(28, 8)")
                    .HasColumnName("CONVFACT2");

                entity.Property(e => e.Expdate)
                    .HasMaxLength(50)
                    .HasColumnName("EXPDATE");

                entity.Property(e => e.Lineexp)
                    .HasMaxLength(250)
                    .HasColumnName("LINEEXP");

                entity.Property(e => e.Onhand)
                    .HasColumnType("numeric(28, 8)")
                    .HasColumnName("ONHAND");

                entity.Property(e => e.Serilotn)
                    .HasMaxLength(50)
                    .HasColumnName("SERILOTN");

                entity.Property(e => e.Stockref).HasColumnName("STOCKREF");

                entity.Property(e => e.Unitcode)
                    .HasMaxLength(50)
                    .HasColumnName("UNITCODE");

                entity.Property(e => e.Unitref).HasColumnName("UNITREF");

                entity.Property(e => e.Variantcode)
                    .HasMaxLength(50)
                    .HasColumnName("VARIANTCODE");

                entity.Property(e => e.Variantref).HasColumnName("VARIANTREF");
            });

            modelBuilder.Entity<EfFormLayoutDal>(entity =>
            {
                entity.ToTable("FormLayout");

                entity.HasIndex(e => new { e.RoleId, e.UserId, e.FormId, e.ComponentId }, "uk_FormLayout_RoleUser")
                    .IsUnique();

                entity.Property(e => e.Code).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.FormLayouts)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_FormLayout_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.FormLayouts)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_FormLayout_UserId");
            });

            modelBuilder.Entity<EfHistoryDal>(entity =>
            {
                entity.ToTable("History");

                entity.HasIndex(e => new { e.ActionType, e.RecordType, e.RecordId }, "idx_History_TypeId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.RecordContent).IsRequired();

                entity.Property(e => e.TransactionGuid).HasMaxLength(255);
            });

            modelBuilder.Entity<EfHistoryDetailDal>(entity =>
            {
                entity.ToTable("HistoryDetail");

                entity.HasIndex(e => new { e.HistoryId, e.FieldName }, "idx_HistoryDetail_TypeId");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FieldName).HasMaxLength(50);

                entity.Property(e => e.FieldValue).IsRequired();
            });

            modelBuilder.Entity<EfItemDal>(entity =>
            {
                entity.ToTable("Item");

                entity.HasIndex(e => e.Active, "idx_Item_Active");

                entity.HasIndex(e => new { e.Code, e.Name }, "idx_Item_Code");

                entity.HasIndex(e => e.ParentItemId, "idx_Item_Parent");

                entity.Property(e => e.AbcClass).HasMaxLength(50);

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(160);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CriticalShelfLife).HasDefaultValueSql("((0))");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.CustomCode1).HasMaxLength(50);

                entity.Property(e => e.CustomCode2).HasMaxLength(50);

                entity.Property(e => e.CustomCode3).HasMaxLength(50);

                entity.Property(e => e.CustomCode4).HasMaxLength(50);

                entity.Property(e => e.CustomCode5).HasMaxLength(50);

                entity.Property(e => e.DeductCode).HasMaxLength(15);

                entity.Property(e => e.ExportClassNumber).HasMaxLength(50);

                entity.Property(e => e.GroupCode).HasMaxLength(50);

                entity.Property(e => e.InputOverageLimit).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.IsoNumber).HasMaxLength(50);

                entity.Property(e => e.ItemGroupCode).HasMaxLength(25);

                entity.Property(e => e.ManufacturerCode).HasMaxLength(101);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.Name2).HasMaxLength(200);

                entity.Property(e => e.OutputOverageLimit).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.ShelfLife).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.VatRate).HasColumnType("numeric(28, 8)");

                entity.HasOne(d => d.ParentItem)
                    .WithMany(p => p.InverseParentItem)
                    .HasForeignKey(d => d.ParentItemId)
                    .HasConstraintName("fk_Item_ParentItemId");
            });

            modelBuilder.Entity<EfItemClassRelationDal>(entity =>
            {
                entity.ToTable("ItemClassRelation");

                entity.HasIndex(e => e.Active, "idx_ItemClassRelation_Active");

                entity.HasIndex(e => new { e.ClassId, e.ItemId }, "uk_ItemClassRelation_ClassItem")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Class)
                    .WithMany(p => p.ItemClassRelationClasses)
                    .HasForeignKey(d => d.ClassId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ItemClassRelation_ClassId");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemClassRelationItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk_ItemClassRelation_ItemId");
            });

            modelBuilder.Entity<EfItemContentDal>(entity =>
            {
                entity.ToTable("ItemContent");

                entity.HasIndex(e => e.Active, "idx_ItemContent_Active");

                entity.HasIndex(e => e.ItemId, "idx_ItemContent_Item");

                entity.HasIndex(e => e.ParentItemId, "idx_ItemContent_Parent");

                entity.HasIndex(e => e.UnitId, "idx_ItemContent_Unit");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Percentage).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Quantity).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.RateOfWaste).HasColumnType("numeric(28, 8)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemContentItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk_ItemContent_ItemId");

                entity.HasOne(d => d.ParentItem)
                    .WithMany(p => p.ItemContentParentItems)
                    .HasForeignKey(d => d.ParentItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ItemContent_ParentItemId");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.ItemContents)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ItemContent_UnitId");
            });

            modelBuilder.Entity<EfItemExtraDal>(entity =>
            {
                entity.Property(s => s.Id)
                        .IsRequired()
                      .HasColumnType(SqlDbType.Int.ToString());
                entity.HasKey(s => s.Id);
                entity.Property(s => s.Skt)
                    .HasColumnType(SqlDbType.DateTime.ToString());
                entity.Property(s => s.Description)
                    .HasColumnType(SqlDbType.NVarChar.ToString())
                    .HasMaxLength(250);
                entity.Property(s => s.Description2)
                   .HasColumnType(SqlDbType.NVarChar.ToString())
                   .HasMaxLength(250);
            });
            
            modelBuilder.Entity<EfItemParameterDal>(entity =>
            {
                entity.ToTable("ItemParameter");

                entity.HasIndex(e => new { e.WarehouseId, e.ItemId }, "uk_ItemParameter_WhItem")
                    .IsUnique();

                entity.Property(e => e.AbcCode).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.MaxQuantity).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.MinQuantity).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SafeQuantity).HasColumnType("numeric(28, 8)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemParameters)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk_ItemParameter_ItemId");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.ItemParameters)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ItemParameter_WarehouseId");
            });

            modelBuilder.Entity<EfItemTotalsReportViewDal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemTotalsReportView");

                entity.Property(e => e.Adres)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DepoAdi)
                    .HasMaxLength(50)
                    .HasColumnName("Depo Adi");

                entity.Property(e => e.DepoKodu)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("Depo Kodu");

                entity.Property(e => e.MalzemeAdi)
                    .HasMaxLength(100)
                    .HasColumnName("Malzeme Adi");

                entity.Property(e => e.MalzemeKodu)
                    .IsRequired()
                    .HasMaxLength(160)
                    .HasColumnName("Malzeme Kodu");

                entity.Property(e => e.Rezerve).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.SonKullanimTarihi)
                    .HasMaxLength(4000)
                    .HasColumnName("Son Kullanim Tarihi");

                entity.Property(e => e.Stok).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.TakipNumarasi)
                    .HasMaxLength(100)
                    .HasColumnName("Takip Numarasi");

                entity.Property(e => e.TasimaKabiAciklamasi)
                    .HasMaxLength(200)
                    .HasColumnName("Tasima Kabi Aciklamasi");

                entity.Property(e => e.TasimaKabiNo)
                    .HasMaxLength(50)
                    .HasColumnName("Tasima Kabi No");

                entity.Property(e => e.VaryantAdı)
                    .HasMaxLength(100)
                    .HasColumnName("Varyant Adı");

                entity.Property(e => e.VaryantKodu)
                    .HasMaxLength(160)
                    .HasColumnName("Varyant Kodu");
            });

            modelBuilder.Entity<EfItemTotalsViewDal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemTotalsView");

                entity.Property(e => e.ActualStock).HasColumnType("numeric(38, 6)");
            });

            modelBuilder.Entity<EfItemTrackingTotalsViewDal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("ItemTrackingTotalsView");

                entity.Property(e => e.ActualStock).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.TrackingNumber).HasMaxLength(100);
            });

            modelBuilder.Entity<EfItemUnitDal>(entity =>
            {
                entity.ToTable("ItemUnit");

                entity.HasIndex(e => e.Active, "idx_ItemUnit_Active");

                entity.HasIndex(e => new { e.ItemId, e.Code }, "idx_ItemUnit_Code");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.ConvFactor1)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConvFactor2)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.GrossVolume).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.GrossWeight).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Height).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Length).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.OldBarcode).HasMaxLength(50);

                entity.Property(e => e.Volume).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Weight).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Width).HasColumnType("numeric(28, 8)");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ItemUnits)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk_ItemUnit_ItemId");
            });

            modelBuilder.Entity<Logger>(entity =>
            {
                entity.ToTable("Logger");
                entity.Property(s => s.Id)
                      .IsRequired()
                      .HasColumnType(SqlDbType.UniqueIdentifier.ToString());
                entity.HasKey(s => s.Id);
                entity.Property(s => s.MethodName)
                      .HasColumnType(SqlDbType.NVarChar.ToString())
                      .HasMaxLength(250);
                entity.Property(s => s.CreatedDate)
                      .IsRequired()
                      .HasColumnType(SqlDbType.DateTime.ToString());
                entity.Property(s => s.ProjectName)
                      .HasColumnType(SqlDbType.NVarChar.ToString())
                      .HasMaxLength(250);
                entity.Property(s => s.Message1)
                 .HasColumnType(SqlDbType.NVarChar.ToString())
                 .HasMaxLength(250);
                entity.Property(s => s.Message2)
                 .HasColumnType(SqlDbType.NVarChar.ToString())
                 .HasMaxLength(250);
                entity.Property(s => s.Statu)
                 .HasColumnType(SqlDbType.NVarChar.ToString())
                 .HasMaxLength(250);
            });

            modelBuilder.Entity<EfLoginHistoryDal>(entity =>
            {
                entity.ToTable("LoginHistory");

                entity.HasIndex(e => e.UserName, "idx_LoginHistory_UserName");

                entity.Property(e => e.Application)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EfOrderSlipDal>(entity =>
            {
                entity.ToTable("OrderSlip");

                entity.HasIndex(e => e.Active, "idx_OrderSlip_Active");

                entity.HasIndex(e => e.ShipmentAddressId, "idx_OrderSlip_Address");

                entity.HasIndex(e => e.ArpId, "idx_OrderSlip_Arp");

                entity.HasIndex(e => e.CarrierId, "idx_OrderSlip_Carrier");

                entity.HasIndex(e => e.DeliveryArpId, "idx_OrderSlip_DeliveryArp");

                entity.HasIndex(e => e.DepartmentId, "idx_OrderSlip_Department");

                entity.HasIndex(e => e.DivisionId, "idx_OrderSlip_Division");

                entity.HasIndex(e => e.FactoryId, "idx_OrderSlip_Factory");

                entity.HasIndex(e => e.ProjectId, "idx_OrderSlip_Project");

                entity.HasIndex(e => e.SalesPersonId, "idx_OrderSlip_SalesPerson");

                entity.HasIndex(e => e.StateId, "idx_OrderSlip_State");

                entity.HasIndex(e => new { e.SlipType, e.SlipNumber, e.SlipDate }, "idx_OrderSlip_TypeNumber");

                entity.HasIndex(e => e.VehicleId, "idx_OrderSlip_Vehicle");

                entity.HasIndex(e => e.WarehouseId, "idx_OrderSlip_Warehouse");

                entity.HasIndex(e => e.Warehouse2Id, "idx_OrderSlip_Warehouse2");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.CustomerOrderNumber).HasMaxLength(40);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.DeliveryType).HasMaxLength(16);

                entity.Property(e => e.Description1).HasMaxLength(50);

                entity.Property(e => e.Description2).HasMaxLength(50);

                entity.Property(e => e.Description3).HasMaxLength(50);

                entity.Property(e => e.Description4).HasMaxLength(50);

                entity.Property(e => e.DocTrackingNumber).HasMaxLength(50);

                entity.Property(e => e.DocumentNumber).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SlipDate).HasColumnType("datetime");

                entity.Property(e => e.SlipNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.TradingGroupCode).HasMaxLength(16);

                entity.HasOne(d => d.Arp)
                    .WithMany(p => p.OrderSlipArps)
                    .HasForeignKey(d => d.ArpId)
                    .HasConstraintName("fk_OrderSlip_ArpId");

                entity.HasOne(d => d.Carrier)
                    .WithMany(p => p.OrderSlips)
                    .HasForeignKey(d => d.CarrierId)
                    .HasConstraintName("fk_OrderSlip_CarrierId");

                entity.HasOne(d => d.DeliveryArp)
                    .WithMany(p => p.OrderSlipDeliveryArps)
                    .HasForeignKey(d => d.DeliveryArpId)
                    .HasConstraintName("fk_OrderSlip_DeliveryArpId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.OrderSlips)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("fk_OrderSlip_DepartmentId");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.OrderSlips)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("fk_OrderSlip_DivisionId");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.OrderSlips)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("fk_OrderSlip_FactoryId");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.OrderSlips)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_OrderSlip_ProjectId");

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.OrderSlips)
                    .HasForeignKey(d => d.SalesPersonId)
                    .HasConstraintName("fk_OrderSlip_SalesPersonId");

                entity.HasOne(d => d.ShipmentAddress)
                    .WithMany(p => p.OrderSlips)
                    .HasForeignKey(d => d.ShipmentAddressId)
                    .HasConstraintName("fk_OrderSlip_ShipmentAddressId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.OrderSlips)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OrderSlip_StateId");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.OrderSlips)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("fk_OrderSlip_VehicleId");

                entity.HasOne(d => d.Warehouse2)
                    .WithMany(p => p.OrderSlipWarehouse2s)
                    .HasForeignKey(d => d.Warehouse2Id)
                    .HasConstraintName("fk_OrderSlip_Warehouse2Id");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.OrderSlipWarehouses)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fk_OrderSlip_WarehouseId");
            });

            modelBuilder.Entity<EfOrderSlipLineDal>(entity =>
            {
                entity.ToTable("OrderSlipLine");

                entity.HasIndex(e => e.Active, "idx_OrderSlipLine_Active");

                entity.HasIndex(e => e.ArpId, "idx_OrderSlipLine_Arp");

                entity.HasIndex(e => e.DepartmentId, "idx_OrderSlipLine_Department");

                entity.HasIndex(e => e.ItemId, "idx_OrderSlipLine_Item");

                entity.HasIndex(e => e.ProjectId, "idx_OrderSlipLine_Project");

                entity.HasIndex(e => e.SlipId, "idx_OrderSlipLine_SlipId");

                entity.HasIndex(e => e.StateId, "idx_OrderSlipLine_State");

                entity.HasIndex(e => new { e.SlipType, e.LineDate }, "idx_OrderSlipLine_TypeDate");

                entity.HasIndex(e => e.UnitId, "idx_OrderSlipLine_Unit");

                entity.HasIndex(e => e.AssignedTo, "idx_OrderSlipLine_User");

                entity.HasIndex(e => e.VariantId, "idx_OrderSlipLine_Variant");

                entity.HasIndex(e => e.WarehouseId, "idx_OrderSlipLine_Warehouse");

                entity.HasIndex(e => e.Warehouse2Id, "idx_OrderSlipLine_Warehouse2");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.ConvFactor1)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConvFactor2)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.DeliveryDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.LineDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyBarcode).HasMaxLength(200);

                entity.Property(e => e.Quantity).HasColumnType("numeric(28, 8)");

                entity.HasOne(d => d.Arp)
                    .WithMany(p => p.OrderSlipLines)
                    .HasForeignKey(d => d.ArpId)
                    .HasConstraintName("fk_OrderSlipLine_ArpId");

                entity.HasOne(d => d.AssignedToNavigation)
                    .WithMany(p => p.OrderSlipLines)
                    .HasForeignKey(d => d.AssignedTo)
                    .HasConstraintName("fk_OrderSlipLine_AssignedTo");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.OrderSlipLines)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("fk_OrderSlipLine_DepartmentId");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.OrderSlipLineItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OrderSlipLine_ItemId");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.OrderSlipLines)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_OrderSlipLine_ProjectId");

                entity.HasOne(d => d.Slip)
                    .WithMany(p => p.OrderSlipLines)
                    .HasForeignKey(d => d.SlipId)
                    .HasConstraintName("fk_OrderSlipLine_SlipId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.OrderSlipLines)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OrderSlipLine_StateId");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.OrderSlipLines)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OrderSlipLine_UnitId");

                entity.HasOne(d => d.Variant)
                    .WithMany(p => p.OrderSlipLineVariants)
                    .HasForeignKey(d => d.VariantId)
                    .HasConstraintName("fk_OrderSlipLine_VariantId");

                entity.HasOne(d => d.Warehouse2)
                    .WithMany(p => p.OrderSlipLineWarehouse2s)
                    .HasForeignKey(d => d.Warehouse2Id)
                    .HasConstraintName("fk_OrderSlipLine_Warehouse2Id");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.OrderSlipLineWarehouses)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_OrderSlipLine_WarehouseId");
            });

            modelBuilder.Entity<EfPlanningSlipDal>(entity =>
            {
                entity.ToTable("PlanningSlip");

                entity.HasIndex(e => e.Active, "idx_PlanningSlip_Active");

                entity.HasIndex(e => e.ShipmentAddressId, "idx_PlanningSlip_Address");

                entity.HasIndex(e => e.ArpId, "idx_PlanningSlip_Arp");

                entity.HasIndex(e => e.DeliveryArpId, "idx_PlanningSlip_DeliveryArp");

                entity.HasIndex(e => e.DepartmentId, "idx_PlanningSlip_Department");

                entity.HasIndex(e => e.DivisionId, "idx_PlanningSlip_Division");

                entity.HasIndex(e => e.DriverId, "idx_PlanningSlip_Driver");

                entity.HasIndex(e => e.FactoryId, "idx_PlanningSlip_Factory");

                entity.HasIndex(e => e.SalesPersonId, "idx_PlanningSlip_SalesPerson");

                entity.HasIndex(e => e.StateId, "idx_PlanningSlip_State");

                entity.HasIndex(e => new { e.SlipType, e.SlipNumber, e.SlipDate }, "idx_PlanningSlip_TypeNumber");

                entity.HasIndex(e => e.VehicleId, "idx_PlanningSlip_Vehicle");

                entity.HasIndex(e => e.WarehouseId, "idx_PlanningSlip_Warehouse");

                entity.HasIndex(e => e.Warehouse2Id, "idx_PlanningSlip_Warehouse2");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.Description1).HasMaxLength(50);

                entity.Property(e => e.Description2).HasMaxLength(50);

                entity.Property(e => e.Description3).HasMaxLength(50);

                entity.Property(e => e.Description4).HasMaxLength(50);

                entity.Property(e => e.DocumentNumber).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentDate).HasColumnType("datetime");

                entity.Property(e => e.SlipDate).HasColumnType("datetime");

                entity.Property(e => e.SlipNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Arp)
                    .WithMany(p => p.PlanningSlipArps)
                    .HasForeignKey(d => d.ArpId)
                    .HasConstraintName("fk_PlanningSlip_ArpId");

                entity.HasOne(d => d.DeliveryArp)
                    .WithMany(p => p.PlanningSlipDeliveryArps)
                    .HasForeignKey(d => d.DeliveryArpId)
                    .HasConstraintName("fk_PlanningSlip_DeliveryArpId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.PlanningSlips)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("fk_PlanningSlip_DepartmentId");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.PlanningSlips)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("fk_PlanningSlip_DivisionId");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.PlanningSlips)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("fk_PlanningSlip_DriverId");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.PlanningSlips)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("fk_PlanningSlip_FactoryId");

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.PlanningSlips)
                    .HasForeignKey(d => d.SalesPersonId)
                    .HasConstraintName("fk_PlanningSlip_SalesPersonId");

                entity.HasOne(d => d.ShipmentAddress)
                    .WithMany(p => p.PlanningSlips)
                    .HasForeignKey(d => d.ShipmentAddressId)
                    .HasConstraintName("fk_PlanningSlip_ShipmentAddressId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.PlanningSlips)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PlanningSlip_StateId");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.PlanningSlips)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("fk_PlanningSlip_VehicleId");

                entity.HasOne(d => d.Warehouse2)
                    .WithMany(p => p.PlanningSlipWarehouse2s)
                    .HasForeignKey(d => d.Warehouse2Id)
                    .HasConstraintName("fk_PlanningSlip_Warehouse2Id");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.PlanningSlipWarehouses)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fk_PlanningSlip_WarehouseId");
            });

            modelBuilder.Entity<EfPlanningSlipLineDal>(entity =>
            {
                entity.ToTable("PlanningSlipLine");

                entity.HasIndex(e => e.Active, "idx_PlanningSlipLine_Active");

                entity.HasIndex(e => e.AddressId, "idx_PlanningSlipLine_Address");

                entity.HasIndex(e => e.Address2Id, "idx_PlanningSlipLine_Address2");

                entity.HasIndex(e => e.ArpId, "idx_PlanningSlipLine_Arp");

                entity.HasIndex(e => e.ItemId, "idx_PlanningSlipLine_Item");

                entity.HasIndex(e => e.SlipId, "idx_PlanningSlipLine_SlipId");

                entity.HasIndex(e => e.StateId, "idx_PlanningSlipLine_State");

                entity.HasIndex(e => new { e.SlipType, e.LineDate }, "idx_PlanningSlipLine_TypeDate");

                entity.HasIndex(e => e.UnitId, "idx_PlanningSlipLine_Unit");

                entity.HasIndex(e => e.AssignedTo, "idx_PlanningSlipLine_User");

                entity.HasIndex(e => e.VariantId, "idx_PlanningSlipLine_Variant");

                entity.HasIndex(e => e.WarehouseId, "idx_PlanningSlipLine_Warehouse");

                entity.HasIndex(e => e.Warehouse2Id, "idx_PlanningSlipLine_Warehouse2");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.ConvFactor1)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConvFactor2)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.LineDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("numeric(28, 8)");

                entity.HasOne(d => d.Address2)
                    .WithMany(p => p.PlanningSlipLineAddress2s)
                    .HasForeignKey(d => d.Address2Id)
                    .HasConstraintName("fk_PlanningSlipLine_Address2Id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.PlanningSlipLineAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("fk_PlanningSlipLine_AddressId");

                entity.HasOne(d => d.Arp)
                    .WithMany(p => p.PlanningSlipLines)
                    .HasForeignKey(d => d.ArpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PlanningSlipLine_ArpId");

                entity.HasOne(d => d.AssignedToNavigation)
                    .WithMany(p => p.PlanningSlipLines)
                    .HasForeignKey(d => d.AssignedTo)
                    .HasConstraintName("fk_PlanningSlipLine_AssignedTo");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.PlanningSlipLineItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PlanningSlipLine_ItemId");

                entity.HasOne(d => d.Slip)
                    .WithMany(p => p.PlanningSlipLines)
                    .HasForeignKey(d => d.SlipId)
                    .HasConstraintName("fk_PlanningSlipLine_SlipId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.PlanningSlipLines)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PlanningSlipLine_StateId");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.PlanningSlipLines)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PlanningSlipLine_UnitId");

                entity.HasOne(d => d.Variant)
                    .WithMany(p => p.PlanningSlipLineVariants)
                    .HasForeignKey(d => d.VariantId)
                    .HasConstraintName("fk_PlanningSlipLine_VariantId");

                entity.HasOne(d => d.Warehouse2)
                    .WithMany(p => p.PlanningSlipLineWarehouse2s)
                    .HasForeignKey(d => d.Warehouse2Id)
                    .HasConstraintName("fk_PlanningSlipLine_Warehouse2Id");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.PlanningSlipLineWarehouses)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_PlanningSlipLine_WarehouseId");
            });

            modelBuilder.Entity<EfProductionOrderDal>(entity =>
            {
                entity.ToTable("ProductionOrder");

                entity.HasIndex(e => e.Active, "idx_ProductionOrder_Active");

                entity.HasIndex(e => e.ArpId, "idx_ProductionOrder_Arp");

                entity.HasIndex(e => e.FactoryId, "idx_ProductionOrder_Factory");

                entity.HasIndex(e => e.ItemId, "idx_ProductionOrder_Item");

                entity.HasIndex(e => e.ProjectId, "idx_ProductionOrder_Project");

                entity.HasIndex(e => new { e.SlipType, e.SlipNumber, e.SlipDate }, "idx_ProductionOrder_TypeNumber");

                entity.HasIndex(e => e.UnitId, "idx_ProductionOrder_Unit");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.ConvFactor1)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConvFactor2)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.Description1).HasMaxLength(50);

                entity.Property(e => e.Description2).HasMaxLength(50);

                entity.Property(e => e.Description3).HasMaxLength(50);

                entity.Property(e => e.Description4).HasMaxLength(50);

                entity.Property(e => e.DueDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PauseDate).HasColumnType("datetime");

                entity.Property(e => e.PlannedEndDate).HasColumnType("datetime");

                entity.Property(e => e.PlannedStartDate).HasColumnType("datetime");

                entity.Property(e => e.PlannedTime).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.SlipDate).HasColumnType("datetime");

                entity.Property(e => e.SlipNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Arp)
                    .WithMany(p => p.ProductionOrders)
                    .HasForeignKey(d => d.ArpId)
                    .HasConstraintName("fk_ProductionOrder_ArpId");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.ProductionOrders)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("fk_ProductionOrder_FactoryId");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ProductionOrders)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProductionOrder_ItemId");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProductionOrders)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_ProductionOrder_ProjectId");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.ProductionOrders)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProductionOrder_UnitId");
            });

            modelBuilder.Entity<EfProductionOrderLineDal>(entity =>
            {
                entity.ToTable("ProductionOrderLine");

                entity.HasIndex(e => new { e.Id, e.LineNumber }, "idx_ProductionOrderLine1");

                entity.HasIndex(e => e.Active, "idx_ProductionOrderLine_Active");

                entity.HasIndex(e => new { e.ActualStartDate, e.SlipType }, "idx_ProductionOrderLine_Actual");

                entity.HasIndex(e => e.FactoryId, "idx_ProductionOrderLine_Factory");

                entity.HasIndex(e => e.ItemId, "idx_ProductionOrderLine_Item");

                entity.HasIndex(e => new { e.PlannedStartDate, e.SlipType }, "idx_ProductionOrderLine_Planned");

                entity.HasIndex(e => e.SlipId, "idx_ProductionOrderLine_SlipId");

                entity.HasIndex(e => e.UnitId, "idx_ProductionOrderLine_Unit");

                entity.HasIndex(e => e.VariantId, "idx_ProductionOrderLine_Variant");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ActualEndDate).HasColumnType("datetime");

                entity.Property(e => e.ActualStartDate).HasColumnType("datetime");

                entity.Property(e => e.ActualTime).HasColumnType("datetime");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.ConvFactor1)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConvFactor2)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.DocumentNumber).HasMaxLength(50);

                entity.Property(e => e.LineNumber).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PlannedEndDate).HasColumnType("datetime");

                entity.Property(e => e.PlannedQuantity).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.PlannedStartDate).HasColumnType("datetime");

                entity.Property(e => e.PlannedTime).HasColumnType("datetime");

                entity.HasOne(d => d.Arp)
                    .WithMany(p => p.ProductionOrderLines)
                    .HasForeignKey(d => d.ArpId)
                    .HasConstraintName("fk_ProductionOrderLine_ArpId");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.ProductionOrderLines)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("fk_ProductionOrderLine_FactoryId");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ProductionOrderLineItems)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProductionOrderLine_ItemId");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProductionOrderLines)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_ProductionOrderLine_ProjectId");

                entity.HasOne(d => d.Slip)
                    .WithMany(p => p.ProductionOrderLines)
                    .HasForeignKey(d => d.SlipId)
                    .HasConstraintName("fk_ProductionOrderLine_SlipId");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.ProductionOrderLines)
                    .HasForeignKey(d => d.UnitId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ProductionOrderLine_UnitId");

                entity.HasOne(d => d.Variant)
                    .WithMany(p => p.ProductionOrderLineVariants)
                    .HasForeignKey(d => d.VariantId)
                    .HasConstraintName("fk_ProductionOrderLine_VariantId");
            });

            modelBuilder.Entity<EfProjectDal>(entity =>
            {
                entity.ToTable("Project");

                entity.HasIndex(e => e.Active, "idx_Project_Active");

                entity.HasIndex(e => e.Code, "idx_Project_Code");

                entity.HasIndex(e => new { e.Code, e.Name }, "idx_Project_CodeName");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.CustomCode2).HasMaxLength(50);

                entity.Property(e => e.CustomCode3).HasMaxLength(50);

                entity.Property(e => e.CustomCode4).HasMaxLength(50);

                entity.Property(e => e.CustomCode5).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Responsible).HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EfReservationSlipDal>(entity =>
            {
                entity.ToTable("ReservationSlip");

                entity.HasIndex(e => e.Active, "idx_ReservationSlip_Active");

                entity.HasIndex(e => new { e.SlipNumber, e.SlipDate }, "idx_ReservationSlip_Date");

                entity.HasIndex(e => e.OrderSlipId, "idx_ReservationSlip_OrderSlip");

                entity.HasIndex(e => e.PlanningSlipId, "idx_ReservationSlip_PlanningSlip");

                entity.HasIndex(e => e.ProductionOrderId, "idx_ReservationSlip_ProdOrder");

                entity.HasIndex(e => e.StateId, "idx_ReservationSlip_State");

                entity.HasIndex(e => e.WorkOrderId, "idx_ReservationSlip_WorkOrder");

                entity.HasIndex(e => new { e.SlipType, e.SlipNumber }, "uk_ReservationSlip_TypeNumber")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.Description1).HasMaxLength(50);

                entity.Property(e => e.Description2).HasMaxLength(50);

                entity.Property(e => e.Description3).HasMaxLength(50);

                entity.Property(e => e.Description4).HasMaxLength(50);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SlipDate).HasColumnType("datetime");

                entity.Property(e => e.SlipNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.OrderSlip)
                    .WithMany(p => p.ReservationSlips)
                    .HasForeignKey(d => d.OrderSlipId)
                    .HasConstraintName("fk_ReservationSlip_OrderSlipId");

                entity.HasOne(d => d.PlanningSlip)
                    .WithMany(p => p.ReservationSlips)
                    .HasForeignKey(d => d.PlanningSlipId)
                    .HasConstraintName("fk_ReservationSlip_PlanningSlipId");

                entity.HasOne(d => d.ProductionOrder)
                    .WithMany(p => p.ReservationSlips)
                    .HasForeignKey(d => d.ProductionOrderId)
                    .HasConstraintName("fk_ReservationSlip_ProductionOrderId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.ReservationSlips)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ReservationSlip_StateId");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.ReservationSlips)
                    .HasForeignKey(d => d.WorkOrderId)
                    .HasConstraintName("fk_ReservationSlip_WorkOrderId");
            });

            modelBuilder.Entity<EfReservationSlipLineDal>(entity =>
            {
                entity.ToTable("ReservationSlipLine");

                entity.HasIndex(e => e.Active, "idx_ReservationSlipLine_Active");

                entity.HasIndex(e => e.AddressId, "idx_ReservationSlipLine_Address");

                entity.HasIndex(e => e.ArpId, "idx_ReservationSlipLine_Arp");

                entity.HasIndex(e => e.BlockingTypeId, "idx_ReservationSlipLine_BlockingType");

                entity.HasIndex(e => e.ChildContainerId, "idx_ReservationSlipLine_ChildContainer");

                entity.HasIndex(e => e.ContainerId, "idx_ReservationSlipLine_Container");

                entity.HasIndex(e => new { e.LineDate, e.SlipType }, "idx_ReservationSlipLine_DateType");

                entity.HasIndex(e => e.ItemId, "idx_ReservationSlipLine_Item");

                entity.HasIndex(e => e.OrderSlipLineId, "idx_ReservationSlipLine_OrderSlip");

                entity.HasIndex(e => e.PlanningSlipLineId, "idx_ReservationSlipLine_PlanningSlip");

                entity.HasIndex(e => e.ProdOrderLineId, "idx_ReservationSlipLine_ProdOrder");

                entity.HasIndex(e => e.SlipId, "idx_ReservationSlipLine_SlipId");

                entity.HasIndex(e => e.StateId, "idx_ReservationSlipLine_State");

                entity.HasIndex(e => e.UnitId, "idx_ReservationSlipLine_Unit");

                entity.HasIndex(e => e.VariantId, "idx_ReservationSlipLine_Variant");

                entity.HasIndex(e => e.WarehouseId, "idx_ReservationSlipLine_Warehouse");

                entity.HasIndex(e => e.WorkOrderLineId, "idx_ReservationSlipLine_WorkOrder");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.ConvFactor1)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConvFactor2)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.LineDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.ReservationSlipLines)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("fk_ReservationSlipLine_AddressId");

                entity.HasOne(d => d.Arp)
                    .WithMany(p => p.ReservationSlipLines)
                    .HasForeignKey(d => d.ArpId)
                    .HasConstraintName("fk_ReservationSlipLine_ArpId");

                entity.HasOne(d => d.BlockingType)
                    .WithMany(p => p.ReservationSlipLines)
                    .HasForeignKey(d => d.BlockingTypeId)
                    .HasConstraintName("fk_ReservationSlipLine_BlockingTypeId");

                entity.HasOne(d => d.ChildContainer)
                    .WithMany(p => p.ReservationSlipLineChildContainers)
                    .HasForeignKey(d => d.ChildContainerId)
                    .HasConstraintName("fk_ReservationSlipLine_ChildContainerId");

                entity.HasOne(d => d.Container)
                    .WithMany(p => p.ReservationSlipLineContainers)
                    .HasForeignKey(d => d.ContainerId)
                    .HasConstraintName("fk_ReservationSlipLine_ContainerId");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.ReservationSlipLineItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk_ReservationSlipLine_ItemId");

                entity.HasOne(d => d.OrderSlipLine)
                    .WithMany(p => p.ReservationSlipLines)
                    .HasForeignKey(d => d.OrderSlipLineId)
                    .HasConstraintName("fk_ReservationSlipLine_OrderSlipLineId");

                entity.HasOne(d => d.PlanningSlipLine)
                    .WithMany(p => p.ReservationSlipLines)
                    .HasForeignKey(d => d.PlanningSlipLineId)
                    .HasConstraintName("fk_ReservationSlipLine_PlanningSlipLineId");

                entity.HasOne(d => d.ProdOrderLine)
                    .WithMany(p => p.ReservationSlipLines)
                    .HasForeignKey(d => d.ProdOrderLineId)
                    .HasConstraintName("fk_ReservationSlipLine_ProdOrderLineId");

                entity.HasOne(d => d.Slip)
                    .WithMany(p => p.ReservationSlipLines)
                    .HasForeignKey(d => d.SlipId)
                    .HasConstraintName("fk_ReservationSlipLine_SlipId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.ReservationSlipLines)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ReservationSlipLine_StateId");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.ReservationSlipLines)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("fk_ReservationSlipLine_UnitId");

                entity.HasOne(d => d.Variant)
                    .WithMany(p => p.ReservationSlipLineVariants)
                    .HasForeignKey(d => d.VariantId)
                    .HasConstraintName("fk_ReservationSlipLine_VariantId");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.ReservationSlipLines)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_ReservationSlipLine_WarehouseId");

                entity.HasOne(d => d.WorkOrderLine)
                    .WithMany(p => p.ReservationSlipLines)
                    .HasForeignKey(d => d.WorkOrderLineId)
                    .HasConstraintName("fk_ReservationSlipLine_WorkOrderLineId");
            });

            modelBuilder.Entity<EfSalesPersonDal>(entity =>
            {
                entity.ToTable("SalesPerson");

                entity.HasIndex(e => e.Active, "idx_SalesPerson_Active");

                entity.HasIndex(e => e.Code, "idx_SalesPerson_Code");

                entity.HasIndex(e => new { e.Code, e.Name }, "idx_SalesPerson_CodeName");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<EfShiftDal>(entity =>
            {
                entity.ToTable("Shift");

                entity.HasIndex(e => e.Active, "idx_Shift_Active");

                entity.HasIndex(e => new { e.Code, e.Name }, "idx_Shift_CodeName");

                entity.HasIndex(e => e.Code, "uk_Shift_Code")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FinishTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.Shifts)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fk_Shift_WarehouseId");
            });

            modelBuilder.Entity<EfShiftPeriodDal>(entity =>
            {
                entity.ToTable("ShiftPeriod");

                entity.HasIndex(e => e.Active, "idx_ShiftPeriod_Active");

                entity.HasIndex(e => new { e.ShiftId, e.StartDate, e.EndDate }, "uk_ShiftPeriod_Date")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EfShipmentAddressDal>(entity =>
            {
                entity.ToTable("ShipmentAddress");

                entity.HasIndex(e => e.Active, "idx_ShipmentAddress_Active");

                entity.HasIndex(e => e.ArpId, "idx_ShipmentAddress_Arp");

                entity.HasIndex(e => new { e.Code, e.Title }, "idx_ShipmentAddress_Code");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Address1).HasMaxLength(200);

                entity.Property(e => e.Address2).HasMaxLength(200);

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.City).HasMaxLength(50);

                entity.Property(e => e.CityCode).HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Country).HasMaxLength(50);

                entity.Property(e => e.CountryCode).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.District).HasMaxLength(50);

                entity.Property(e => e.DistrictCode).HasMaxLength(50);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.FaxNumber1).HasMaxLength(50);

                entity.Property(e => e.FaxNumber2).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PhoneNumber1).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber2).HasMaxLength(50);

                entity.Property(e => e.PostCode).HasMaxLength(50);

                entity.Property(e => e.TaxCode).HasMaxLength(50);

                entity.Property(e => e.TaxNumber).HasMaxLength(50);

                entity.Property(e => e.TaxOffice).HasMaxLength(50);

                entity.Property(e => e.Title).HasMaxLength(200);

                entity.Property(e => e.Town).HasMaxLength(50);

                entity.Property(e => e.TownCode).HasMaxLength(50);

                entity.Property(e => e.TradingGroupCode).HasMaxLength(16);

                entity.Property(e => e.Url).HasMaxLength(100);
            });

            modelBuilder.Entity<EfShipmentDayDal>(entity =>
            {
                entity.ToTable("ShipmentDay");

                entity.HasIndex(e => new { e.ArpId, e.ShipmentAddressId }, "idx_ShipmentDay_ArpAddress");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FinishTime).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentDay1).HasColumnName("ShipmentDay");

                entity.Property(e => e.StartTime).HasColumnType("datetime");

                entity.HasOne(d => d.Arp)
                    .WithMany(p => p.ShipmentDays)
                    .HasForeignKey(d => d.ArpId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_ShipmentDay_ArpId");

                entity.HasOne(d => d.ShipmentAddress)
                    .WithMany(p => p.ShipmentDays)
                    .HasForeignKey(d => d.ShipmentAddressId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_ShipmentDay_ShipmentAddressId");
            });

            modelBuilder.Entity<EfSlipDal>(entity =>
            {
                entity.ToTable("Slip");

                entity.HasIndex(e => e.Active, "idx_Slip_Active");

                entity.HasIndex(e => e.ShipmentAddressId, "idx_Slip_Address");

                entity.HasIndex(e => e.ArpId, "idx_Slip_Arp");

                entity.HasIndex(e => e.CustomSlipTypeId, "idx_Slip_CustomType");

                entity.HasIndex(e => e.DeliveryArpId, "idx_Slip_DeliveryArp");

                entity.HasIndex(e => e.DepartmentId, "idx_Slip_Department");

                entity.HasIndex(e => e.DivisionId, "idx_Slip_Division");

                entity.HasIndex(e => e.DriverId, "idx_Slip_Driver");

                entity.HasIndex(e => e.FactoryId, "idx_Slip_Factory");

                entity.HasIndex(e => e.OrderSlipId, "idx_Slip_OrderSlip");

                entity.HasIndex(e => e.PlanningSlipId, "idx_Slip_PlanningSlip");

                entity.HasIndex(e => e.ProductionOrderId, "idx_Slip_ProductionOrder");

                entity.HasIndex(e => e.ProjectId, "idx_Slip_Project");

                entity.HasIndex(e => e.SalesPersonId, "idx_Slip_SalesPerson");

                entity.HasIndex(e => e.StateId, "idx_Slip_State");

                entity.HasIndex(e => new { e.SlipType, e.SlipDate }, "idx_Slip_TypeDate");

                entity.HasIndex(e => e.VehicleId, "idx_Slip_Vehicle");

                entity.HasIndex(e => e.WarehouseId, "idx_Slip_Warehouse");

                entity.HasIndex(e => e.Warehouse2Id, "idx_Slip_Warehouse2");

                entity.HasIndex(e => e.WorkOrderId, "idx_Slip_WorkOrder");

                entity.HasIndex(e => new { e.SlipType, e.SlipNumber }, "uk_Slip_TypeNumber")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.DeclarationNumber).HasMaxLength(20);

                entity.Property(e => e.Description1).HasMaxLength(50);

                entity.Property(e => e.Description2).HasMaxLength(50);

                entity.Property(e => e.Description3).HasMaxLength(50);

                entity.Property(e => e.Description4).HasMaxLength(50);

                entity.Property(e => e.DispatchNumber).HasMaxLength(10);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentNumber).HasMaxLength(20);

                entity.Property(e => e.SlipDate).HasColumnType("datetime");

                entity.Property(e => e.SlipNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.SlipSerialNumber).HasMaxLength(50);

                entity.HasOne(d => d.Arp)
                    .WithMany(p => p.SlipArps)
                    .HasForeignKey(d => d.ArpId)
                    .HasConstraintName("fk_Slip_ArpId");

                entity.HasOne(d => d.CustomSlipType)
                    .WithMany(p => p.Slips)
                    .HasForeignKey(d => d.CustomSlipTypeId)
                    .HasConstraintName("fk_Slip_CustomSlipTypeId");

                entity.HasOne(d => d.DeliveryArp)
                    .WithMany(p => p.SlipDeliveryArps)
                    .HasForeignKey(d => d.DeliveryArpId)
                    .HasConstraintName("fk_Slip_DeliveryArpId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Slips)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("fk_Slip_DepartmentId");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.Slips)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("fk_Slip_DivisionId");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.Slips)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("fk_Slip_DriverId");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.Slips)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("fk_Slip_FactoryId");

                entity.HasOne(d => d.OrderSlip)
                    .WithMany(p => p.Slips)
                    .HasForeignKey(d => d.OrderSlipId)
                    .HasConstraintName("fk_Slip_OrderSlipId");

                entity.HasOne(d => d.PlanningSlip)
                    .WithMany(p => p.Slips)
                    .HasForeignKey(d => d.PlanningSlipId)
                    .HasConstraintName("fk_Slip_PlanningSlipId");

                entity.HasOne(d => d.ProductionOrder)
                    .WithMany(p => p.Slips)
                    .HasForeignKey(d => d.ProductionOrderId)
                    .HasConstraintName("fk_Slip_ProductionOrderId");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Slips)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_Slip_ProjectId");

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.Slips)
                    .HasForeignKey(d => d.SalesPersonId)
                    .HasConstraintName("fk_Slip_SalesPersonId");

                entity.HasOne(d => d.ShipmentAddress)
                    .WithMany(p => p.Slips)
                    .HasForeignKey(d => d.ShipmentAddressId)
                    .HasConstraintName("fk_Slip_ShipmentAddressId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.Slips)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Slip_StateId");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.Slips)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("fk_Slip_VehicleId");

                entity.HasOne(d => d.Warehouse2)
                    .WithMany(p => p.SlipWarehouse2s)
                    .HasForeignKey(d => d.Warehouse2Id)
                    .HasConstraintName("fk_Slip_Warehouse2Id");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.SlipWarehouses)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Slip_WarehouseId");

                entity.HasOne(d => d.WorkOrder)
                    .WithMany(p => p.Slips)
                    .HasForeignKey(d => d.WorkOrderId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_Slip_WorkOrderId");
            });

            modelBuilder.Entity<efSlipLineDal>(entity =>
            {
                entity.ToTable("SlipLine");

                entity.HasIndex(e => e.Active, "idx_SlipLine_Active");

                entity.HasIndex(e => e.AddressId, "idx_SlipLine_Address");

                entity.HasIndex(e => e.Address2Id, "idx_SlipLine_Address2");

                entity.HasIndex(e => e.ArpId, "idx_SlipLine_Arp");

                entity.HasIndex(e => e.ChildContainerId, "idx_SlipLine_ChildContainer");

                entity.HasIndex(e => e.ChildContainer2Id, "idx_SlipLine_ChildContainer2");

                entity.HasIndex(e => e.ContainerId, "idx_SlipLine_Container");

                entity.HasIndex(e => e.Container2Id, "idx_SlipLine_Container2");

                entity.HasIndex(e => new { e.LineDate, e.SlipType }, "idx_SlipLine_DateType");

                entity.HasIndex(e => e.ItemId, "idx_SlipLine_Item");

                entity.HasIndex(e => e.OrderSlipLineId, "idx_SlipLine_OrderSlip");

                entity.HasIndex(e => e.PlanningSlipLineId, "idx_SlipLine_PlanningSlip");

                entity.HasIndex(e => e.ProdOrderLineId, "idx_SlipLine_ProdOrder");

                entity.HasIndex(e => e.ProjectId, "idx_SlipLine_Project");

                entity.HasIndex(e => e.SlipId, "idx_SlipLine_SlipId");

                entity.HasIndex(e => e.StateId, "idx_SlipLine_State");

                entity.HasIndex(e => e.UnitId, "idx_SlipLine_Unit");

                entity.HasIndex(e => e.AssignedTo, "idx_SlipLine_User");

                entity.HasIndex(e => e.VariantId, "idx_SlipLine_Variant");

                entity.HasIndex(e => e.WarehouseId, "idx_SlipLine_Warehouse");

                entity.HasIndex(e => e.Warehouse2Id, "idx_SlipLine_Warehouse2");

                entity.HasIndex(e => e.WorkOrderLineId, "idx_SlipLine_WorkOrder");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Approval).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.ConvFactor1)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConvFactor2)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.InsuranceExpDate).HasColumnType("datetime");

                entity.Property(e => e.LineDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyBarcode).HasMaxLength(200);

                entity.Property(e => e.Quantity).HasColumnType("numeric(28, 8)");

                entity.HasOne(d => d.Address2)
                    .WithMany(p => p.SlipLineAddress2s)
                    .HasForeignKey(d => d.Address2Id)
                    .HasConstraintName("fk_SlipLine_Address2Id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.SlipLineAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SlipLine_AddressId");

                entity.HasOne(d => d.Arp)
                    .WithMany(p => p.SlipLines)
                    .HasForeignKey(d => d.ArpId)
                    .HasConstraintName("fk_SlipLine_ArpId");

                entity.HasOne(d => d.AssignedToNavigation)
                    .WithMany(p => p.SlipLines)
                    .HasForeignKey(d => d.AssignedTo)
                    .HasConstraintName("fk_SlipLine_AssignedTo");

                entity.HasOne(d => d.ChildContainer2)
                    .WithMany(p => p.SlipLineChildContainer2s)
                    .HasForeignKey(d => d.ChildContainer2Id)
                    .HasConstraintName("fk_SlipLine_ChildContainer2Id");

                entity.HasOne(d => d.ChildContainer)
                    .WithMany(p => p.SlipLineChildContainers)
                    .HasForeignKey(d => d.ChildContainerId)
                    .HasConstraintName("fk_SlipLine_ChildContainerId");

                entity.HasOne(d => d.Container2)
                    .WithMany(p => p.SlipLineContainer2s)
                    .HasForeignKey(d => d.Container2Id)
                    .HasConstraintName("fk_SlipLine_Container2Id");

                entity.HasOne(d => d.Container)
                    .WithMany(p => p.SlipLineContainers)
                    .HasForeignKey(d => d.ContainerId)
                    .HasConstraintName("fk_SlipLine_ContainerId");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.SlipLineItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk_SlipLine_ItemId");

                entity.HasOne(d => d.OrderSlipLine)
                    .WithMany(p => p.SlipLines)
                    .HasForeignKey(d => d.OrderSlipLineId)
                    .HasConstraintName("fk_SlipLine_OrderSlipLineId");

                entity.HasOne(d => d.PlanningSlipLine)
                    .WithMany(p => p.SlipLines)
                    .HasForeignKey(d => d.PlanningSlipLineId)
                    .HasConstraintName("fk_SlipLine_PlanningSlipLineId");

                entity.HasOne(d => d.ProdOrderLine)
                    .WithMany(p => p.SlipLines)
                    .HasForeignKey(d => d.ProdOrderLineId)
                    .HasConstraintName("fk_SlipLine_ProdOrderLineId");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SlipLines)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_SlipLine_ProjectId");

                entity.HasOne(d => d.Slip)
                    .WithMany(p => p.SlipLines)
                    .HasForeignKey(d => d.SlipId)
                    .HasConstraintName("fk_SlipLine_SlipId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.SlipLines)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SlipLine_StateId");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.SlipLines)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("fk_SlipLine_UnitId");

                entity.HasOne(d => d.Variant)
                    .WithMany(p => p.SlipLineVariants)
                    .HasForeignKey(d => d.VariantId)
                    .HasConstraintName("fk_SlipLine_VariantId");

                entity.HasOne(d => d.Warehouse2)
                    .WithMany(p => p.SlipLineWarehouse2s)
                    .HasForeignKey(d => d.Warehouse2Id)
                    .HasConstraintName("fk_SlipLine_Warehouse2Id");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.SlipLineWarehouses)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SlipLine_WarehouseId");

                entity.HasOne(d => d.WorkOrderLine)
                    .WithMany(p => p.SlipLines)
                    .HasForeignKey(d => d.WorkOrderLineId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SlipLine_WorkOrderLineId");
            });

            modelBuilder.Entity<EfSysAddressDal>(entity =>
            {
                entity.ToTable("SysAddress");

                entity.HasIndex(e => e.Active, "idx_SysAddress_Active");

                entity.HasIndex(e => new { e.WarehouseId, e.FloorId, e.Address }, "uk_SysAddress_Address")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Aisle).HasMaxLength(10);

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.Depth).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.GpsAddress).HasMaxLength(500);

                entity.Property(e => e.GroupCode).HasMaxLength(25);

                entity.Property(e => e.Height).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Latitude).HasMaxLength(50);

                entity.Property(e => e.Length).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Longitude).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.RfId).HasMaxLength(300);

                entity.Property(e => e.Volume).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Weight).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Width).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Xcoord).HasColumnName("XCoord");

                entity.Property(e => e.Ycoord).HasColumnName("YCoord");

                entity.Property(e => e.Zcoord).HasColumnName("ZCoord");

                entity.HasOne(d => d.Floor)
                    .WithMany(p => p.SysAddresses)
                    .HasForeignKey(d => d.FloorId)
                    .HasConstraintName("fk_SysAddress_FloorId");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.SysAddresses)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SysAddress_WarehouseId");

                entity.HasOne(d => d.Zone)
                    .WithMany(p => p.SysAddresses)
                    .HasForeignKey(d => d.ZoneId)
                    .HasConstraintName("fk_SysAddress_ZoneId");
            });

            modelBuilder.Entity<EfSysAuthCodeDal>(entity =>
            {
                entity.ToTable("SysAuthCode");

                entity.HasIndex(e => new { e.RoleId, e.UserId, e.RecordType, e.AuthCode }, "uk_SysAuthCode_TypeCode")
                    .IsUnique();

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SysAuthCodes)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_SysAuthCode_RoleId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SysAuthCodes)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_SysAuthCode_UserId");
            });

            modelBuilder.Entity<EfSysBlockingExceptionDal>(entity =>
            {
                entity.ToTable("SysBlockingException");

                entity.HasIndex(e => new { e.BlockingTypeId, e.CustomSlipTypeId }, "idx_SysBlockingException_Type");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.BlockingType)
                    .WithMany(p => p.SysBlockingExceptions)
                    .HasForeignKey(d => d.BlockingTypeId)
                    .HasConstraintName("fk_SysBlockingException_Type");
            });

            modelBuilder.Entity<EfSysBlockingTypeDal>(entity =>
            {
                entity.ToTable("SysBlockingType");

                entity.HasIndex(e => e.Active, "idx_SysBlockingType_Active");

                entity.HasIndex(e => e.Code, "uk_SysBlockingType_Code")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EfSysContainerRelationDal>(entity =>
            {
                entity.ToTable("SysContainerRelation");

                entity.HasIndex(e => new { e.ParentId, e.ChildId }, "uk_SysContainerRelation_ParentChild")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Child)
                    .WithMany(p => p.SysContainerRelationChildren)
                    .HasForeignKey(d => d.ChildId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SysContainerRelation_ChildId");

                entity.HasOne(d => d.Parent)
                    .WithMany(p => p.SysContainerRelationParents)
                    .HasForeignKey(d => d.ParentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SysContainerRelation_ParentId");
            });

            modelBuilder.Entity<EfSysContainerTypeDal>(entity =>
            {
                entity.ToTable("SysContainerType");

                entity.HasIndex(e => e.Active, "idx_SysContainerType_Active");

                entity.HasIndex(e => e.Code, "uk_SysContainerType_Code")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.DimensionWeight).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Height).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.ItemsFilter).HasMaxLength(200);

                entity.Property(e => e.Length).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.LpncontainsDate).HasColumnName("LPNContainsDate");

                entity.Property(e => e.Lpnlength).HasColumnName("LPNLength");

                entity.Property(e => e.Lpnprefix)
                    .HasMaxLength(50)
                    .HasColumnName("LPNPrefix");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Volume).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Weight).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Width).HasColumnType("numeric(28, 8)");
            });

            modelBuilder.Entity<EfSysCustomCodeDal>(entity =>
            {
                entity.ToTable("SysCustomCode");

                entity.HasIndex(e => e.Active, "idx_SysCustomCode_Active");

                entity.HasIndex(e => new { e.Code, e.CodeType }, "idx_SysCustomCode_CodeType");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(100);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<EfSysCustomListColumnDal>(entity =>
            {
                entity.ToTable("SysCustomListColumn");

                entity.HasIndex(e => e.Active, "idx_SysCustomListColumn_Active");

                entity.HasIndex(e => e.MenuNumber, "idx_SysCustomListColumn_MenuNumber")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ReportColumns).IsRequired();

                entity.Property(e => e.ReportParameters).IsRequired();

                entity.HasOne(d => d.Report)
                    .WithMany(p => p.SysCustomListColumns)
                    .HasForeignKey(d => d.ReportId)
                    .HasConstraintName("fk_SysCustomListColumn_ReportId");
            });

            modelBuilder.Entity<EfSysCustomReportDal>(entity =>
            {
                entity.ToTable("SysCustomReport");

                entity.HasIndex(e => e.Active, "idx_SysCustomReport_Active");

                entity.HasIndex(e => e.ReportType, "idx_SysCustomReport_ReportType");

                entity.HasIndex(e => e.Name, "uk_SysCustomReport_Name")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EfSysCustomRuleDal>(entity =>
            {
                entity.ToTable("SysCustomRule");

                entity.HasIndex(e => e.Active, "idx_SysCustomRule_Active");

                entity.HasIndex(e => e.Name, "uk_SysCustomRule_Name")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ScheduleDay)
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduleMonth)
                    .HasMaxLength(12)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduleTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ScheduleWeekDay)
                    .HasMaxLength(8)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<efSysCustomRuleActionDal>(entity =>
            {
                entity.ToTable("SysCustomRuleAction");

                entity.HasIndex(e => new { e.RuleId, e.ActionNumber }, "uk_SysCustomRuleAction_IdNumber")
                    .IsUnique();

                entity.HasOne(d => d.Rule)
                    .WithMany(p => p.SysCustomRuleActions)
                    .HasForeignKey(d => d.RuleId)
                    .HasConstraintName("fk_SysCustomRuleAction_RuleId");
            });

            modelBuilder.Entity<EfSysCustomSlipTypeDal>(entity =>
            {
                entity.ToTable("SysCustomSlipType");

                entity.HasIndex(e => e.Active, "idx_SysCustomSlipType_Active");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ErpRecordTrCode).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EfSysCustomStateDal>(entity =>
            {
                entity.ToTable("SysCustomState");

                entity.HasIndex(e => e.Active, "idx_SysCustomState_Active");

                entity.HasIndex(e => new { e.RecordType, e.StateNumber }, "uk_SysCustomState_TypeNumber")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.StateName).IsRequired();
            });

            modelBuilder.Entity<EfSysCustomTableDal>(entity =>
            {
                entity.ToTable("SysCustomTable");

                entity.HasIndex(e => e.Active, "idx_SysCustomTable_Active");

                entity.HasIndex(e => new { e.TableName, e.RecordType }, "uk_SysCustomTable_TypeName")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.TableDetail).IsRequired();

                entity.Property(e => e.TableName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EfSysDepartmentDal>(entity =>
            {
                entity.ToTable("SysDepartment");

                entity.HasIndex(e => e.Active, "idx_SysDepartment_Active");

                entity.HasIndex(e => e.Code, "idx_SysDepartment_Code");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<EfSysDivisionDal>(entity =>
            {
                entity.ToTable("SysDivision");

                entity.HasIndex(e => e.Active, "idx_SysDivision_Active");

                entity.HasIndex(e => e.Code, "idx_SysDivision_Code");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);
            });

            modelBuilder.Entity<EfSysErpDal>(entity =>
            {
                entity.ToTable("SysErp");

                entity.HasIndex(e => e.Active, "idx_SysErp_Active");

                entity.HasIndex(e => new { e.ErpType, e.Description, e.ConnectionType }, "uk_SysErp_ErpType")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ApiUrl1).HasMaxLength(200);

                entity.Property(e => e.ApiUrl2).HasMaxLength(200);

                entity.Property(e => e.ApiUrl3).HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.DbName).HasMaxLength(50);

                entity.Property(e => e.DbPassword).HasMaxLength(50);

                entity.Property(e => e.DbUserName).HasMaxLength(50);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.EndpointUrl).HasMaxLength(200);

                entity.Property(e => e.FirmNumber).HasMaxLength(50);

                entity.Property(e => e.Language).HasMaxLength(50);

                entity.Property(e => e.LcnapiUrl)
                    .HasMaxLength(200)
                    .HasColumnName("LCNApiUrl");

                entity.Property(e => e.Lcnport).HasColumnName("LCNPort");

                entity.Property(e => e.Lcnversion)
                    .IsRequired()
                    .HasMaxLength(50)
                    .HasColumnName("LCNVersion");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Password).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<EfSysErpFirmDal>(entity =>
            {
                entity.ToTable("SysErpFirm");

                entity.HasIndex(e => e.Active, "idx_SysErpFirm_Active");

                entity.HasIndex(e => new { e.ErpId, e.ErpFirmNumber, e.ErpBranchNumber }, "uk_SysErpFirm_ErpFirm")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ErpFirmName).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Erp)
                    .WithMany(p => p.SysErpFirms)
                    .HasForeignKey(d => d.ErpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SysErpFirm_ErpId");
            });

            modelBuilder.Entity<EfSysErpIntegrationDal>(entity =>
            {
                entity.ToTable("SysErpIntegration");

                entity.HasIndex(e => new { e.RecordType, e.RecordId, e.ErpFirmId }, "idx_SysErpIntegration1");

                entity.HasIndex(e => new { e.ErpId, e.ErpFirmId }, "idx_SysErpIntegration_Erp");

                entity.HasIndex(e => new { e.RecordType, e.RecordId }, "idx_SysErpIntegration_Record");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ErpModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ErpRecordCode).HasMaxLength(50);

                entity.Property(e => e.ErpRecordParameters).HasMaxLength(200);

                entity.Property(e => e.ErpRecordTrCode).HasMaxLength(50);

                entity.Property(e => e.IntegrationDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ErpFirm)
                    .WithMany(p => p.SysErpIntegrations)
                    .HasForeignKey(d => d.ErpFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SysErpIntegration_FirmId");

                entity.HasOne(d => d.Erp)
                    .WithMany(p => p.SysErpIntegrations)
                    .HasForeignKey(d => d.ErpId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SysErpIntegration_ErpId");
            });

            modelBuilder.Entity<EfSysFactoryDal>(entity =>
            {
                entity.ToTable("SysFactory");

                entity.HasIndex(e => e.Active, "idx_SysFactory_Active");

                entity.HasIndex(e => e.Code, "idx_SysFactory_Code");

                entity.HasIndex(e => e.DivisionId, "idx_SysFactory_Division");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.SysFactories)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("fk_SysFactory_DivisionId");
            });

            modelBuilder.Entity<EfSysLogDal>(entity =>
            {
                entity.ToTable("SysLog");

                entity.HasIndex(e => new { e.Logger, e.LogDate, e.LogLevel }, "idx_SysLog_LoggerDateLevel");

                entity.Property(e => e.Arguments).HasMaxLength(4000);

                entity.Property(e => e.CustomerName).HasMaxLength(200);

                entity.Property(e => e.ErpDescription).HasMaxLength(200);

                entity.Property(e => e.ErpRecordParameters).HasMaxLength(50);

                entity.Property(e => e.ErpRecordType).HasMaxLength(50);

                entity.Property(e => e.Exception).HasMaxLength(4000);

                entity.Property(e => e.IpAddressPort).HasMaxLength(50);

                entity.Property(e => e.LogDate).HasColumnType("datetime");

                entity.Property(e => e.LogLevel)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LogMessage).IsRequired();

                entity.Property(e => e.Logger)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.MethodName).HasMaxLength(50);

                entity.Property(e => e.ProcessGroup).HasMaxLength(50);

                entity.Property(e => e.ProductVersion).HasMaxLength(50);

                entity.Property(e => e.RecordType).HasMaxLength(50);

                entity.Property(e => e.TaskGuid).HasMaxLength(50);

                entity.Property(e => e.UserName).HasMaxLength(50);
            });

            modelBuilder.Entity<EfSysMenuRightDal>(entity =>
            {
                entity.ToTable("SysMenuRight");

                entity.HasIndex(e => new { e.RoleId, e.MenuId, e.OperationType }, "uk_SysMenuRight_RoleOp")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SysMenuRights)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("fk_SysMenuRight_RoleId");
            });

            modelBuilder.Entity<EfSysNetLockDal>(entity =>
            {
                entity.ToTable("SysNetLock");

                entity.HasIndex(e => e.Active, "idx_SysNetLock_Active");

                entity.HasIndex(e => new { e.FormName, e.RecordId }, "idx_SysNetLock_Form");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FormName).HasMaxLength(40);

                entity.Property(e => e.RecordId).HasMaxLength(50);

                entity.Property(e => e.SessionCode).HasMaxLength(100);

                entity.HasOne(d => d.CreatedByNavigation)
                    .WithMany(p => p.SysNetLocks)
                    .HasForeignKey(d => d.CreatedBy)
                    .HasConstraintName("fk_SysNetLock_CreatedBy");
            });

            modelBuilder.Entity<EfSysParameterDal>(entity =>
            {
                entity.ToTable("SysParameter");

                entity.HasIndex(e => e.Active, "idx_SysParameter_Active");

                entity.HasIndex(e => new { e.ParameterType, e.ParameterTypeId, e.ParameterNumber }, "uk_SysParameter_TypeIdNumber")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ParameterTypeId).HasMaxLength(50);
            });

            modelBuilder.Entity<EfSysPasswordHistoryDal>(entity =>
            {
                entity.ToTable("SysPasswordHistory");

                entity.HasIndex(e => new { e.UserId, e.CreatedDate }, "idx_SysPasswordHistory_UserDate");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(200);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SysPasswordHistories)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_SysPasswordHistory_UserId");
            });

            modelBuilder.Entity<EfSysPasswordPolicyDal>(entity =>
            {
                entity.ToTable("SysPasswordPolicy");

                entity.HasIndex(e => e.Active, "idx_SysPasswordPolicy_Active");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PasswordExpression).HasMaxLength(200);
            });

            modelBuilder.Entity<EfSysPrinterDal>(entity =>
            {
                entity.ToTable("SysPrinter");

                entity.HasIndex(e => e.Active, "idx_SysPrinter_Active");

                entity.HasIndex(e => e.Name, "uk_SysPrinter_Name")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.GroupCode).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);
            });

            modelBuilder.Entity<EfSysRoleDal>(entity =>
            {
                entity.ToTable("SysRole");

                entity.HasIndex(e => e.Active, "idx_SysRole_Active");

                entity.HasIndex(e => e.Description, "uk_SysRole_Description")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.PasswordPolicy)
                    .WithMany(p => p.SysRoles)
                    .HasForeignKey(d => d.PasswordPolicyId)
                    .HasConstraintName("fk_SysRole_PolicyId");
            });

            modelBuilder.Entity<EfSysScriptDal>(entity =>
            {
                entity.ToTable("SysScript");

                entity.HasIndex(e => e.Active, "idx_SysScript_Active");

                entity.HasIndex(e => new { e.ScriptType, e.Name }, "uk_SysScript_TypeName")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<EfSysSessionDal>(entity =>
            {
                entity.ToTable("SysSession");

                entity.HasIndex(e => e.UserId, "idx_SysSession_User");

                entity.Property(e => e.SessionCode).HasMaxLength(100);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SysSessions)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_SysSession_UserId");
            });

            modelBuilder.Entity<EfSysUserDal>(entity =>
            {
                entity.ToTable("SysUser");

                entity.HasIndex(e => e.Active, "idx_SysUser_Active");

                entity.HasIndex(e => e.PrinterId, "idx_SysUser_Printer");

                entity.HasIndex(e => e.RoleId, "idx_SysUser_Role");

                entity.HasIndex(e => e.ScriptId, "idx_SysUser_Script");

                entity.HasIndex(e => e.UserName, "uk_SysUser_UserName")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.DisabledMenuCodes).HasMaxLength(500);

                entity.Property(e => e.Email).HasMaxLength(250);

                entity.Property(e => e.EnabledMenuCodes).HasMaxLength(500);

                entity.Property(e => e.Idmusername)
                    .HasMaxLength(50)
                    .HasColumnName("IDMUsername");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Password)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PhoneNumber1).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber2).HasMaxLength(50);

                entity.Property(e => e.Sso).HasColumnName("SSO");

                entity.Property(e => e.Surname)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Boss)
                    .WithMany(p => p.InverseBoss)
                    .HasForeignKey(d => d.BossId)
                    .HasConstraintName("fk_SysUser_BossId");

                entity.HasOne(d => d.DefaultErpFirm)
                    .WithMany(p => p.SysUsers)
                    .HasForeignKey(d => d.DefaultErpFirmId)
                    .HasConstraintName("fk_SysUser_FirmId");

                entity.HasOne(d => d.DefaultErp)
                    .WithMany(p => p.SysUsers)
                    .HasForeignKey(d => d.DefaultErpId)
                    .HasConstraintName("fk_SysUser_ErpId");

                entity.HasOne(d => d.DefaultWarehouse)
                    .WithMany(p => p.SysUsers)
                    .HasForeignKey(d => d.DefaultWarehouseId)
                    .HasConstraintName("fk_SysUser_WarehouseId");

                entity.HasOne(d => d.PasswordPolicy)
                    .WithMany(p => p.SysUsers)
                    .HasForeignKey(d => d.PasswordPolicyId)
                    .HasConstraintName("fk_SysUser_PolicyId");

                entity.HasOne(d => d.Printer)
                    .WithMany(p => p.SysUsers)
                    .HasForeignKey(d => d.PrinterId)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("fk_SysUser_PrinterId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.SysUsers)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SysUser_RoleId");

                entity.HasOne(d => d.Script)
                    .WithMany(p => p.SysUsers)
                    .HasForeignKey(d => d.ScriptId)
                    .HasConstraintName("fk_SysUser_ScriptId");
            });

            modelBuilder.Entity<EfSysUserWarehouseDal>(entity =>
            {
                entity.ToTable("SysUserWarehouse");

                entity.HasIndex(e => new { e.UserId, e.WarehouseId, e.ErpFirmId }, "uk_SysUserWarehouse_UserFirm")
                    .IsUnique();

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ErpFirm)
                    .WithMany(p => p.SysUserWarehouses)
                    .HasForeignKey(d => d.ErpFirmId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SysUserWarehouse_FirmId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.SysUserWarehouses)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("fk_SysUserWarehouse_UserId");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.SysUserWarehouses)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SysUserWarehouse_WarehouseId");
            });

            modelBuilder.Entity<EfSysWarehouseDal>(entity =>
            {
                entity.ToTable("SysWarehouse");

                entity.HasIndex(e => e.Active, "idx_SysWarehouse_Active");

                entity.HasIndex(e => new { e.Code, e.Name }, "idx_SysWarehouse_CodeName");

                entity.HasIndex(e => e.DepartmentId, "idx_SysWarehouse_Department");

                entity.HasIndex(e => e.DivisionId, "idx_SysWarehouse_Division");

                entity.HasIndex(e => e.FactoryId, "idx_SysWarehouse_Factory");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Address).HasMaxLength(100);

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CostGroup).HasMaxLength(16);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.Depth).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Fax).HasMaxLength(50);

                entity.Property(e => e.Height).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PhoneNumber).HasMaxLength(100);

                entity.Property(e => e.Width).HasColumnType("numeric(28, 8)");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.SysWarehouses)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("fk_SysWarehouse_DepartmentId");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.SysWarehouses)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("fk_SysWarehouse_DivisionId");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.SysWarehouses)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("fk_SysWarehouse_FactoryId");
            });

            modelBuilder.Entity<EfSysWarehouseBlockDal>(entity =>
            {
                entity.ToTable("SysWarehouseBlock");

                entity.HasIndex(e => e.Active, "idx_SysWarehouseBlock_Active");

                entity.HasIndex(e => new { e.WarehouseId, e.FloorId, e.Code }, "uk_SysWarehouseBlock_Code")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Depth).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.Height).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Width).HasColumnType("numeric(28, 8)");

                entity.HasOne(d => d.Floor)
                    .WithMany(p => p.SysWarehouseBlocks)
                    .HasForeignKey(d => d.FloorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SysWarehouseBlock_FloorId");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.SysWarehouseBlocks)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SysWarehouseBlock_WarehouseId");
            });

            modelBuilder.Entity<EfSysWarehouseFloorDal>(entity =>
            {
                entity.ToTable("SysWarehouseFloor");

                entity.HasIndex(e => e.Active, "idx_SysWarehouseFloor_Active");

                entity.HasIndex(e => new { e.Code, e.WarehouseId }, "uk_SysWarehouseFloor_CodeId")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.SysWarehouseFloors)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SysWarehouseFloor_WarehouseId");
            });

            modelBuilder.Entity<EfSysWarehouseZoneDal>(entity =>
            {
                entity.ToTable("SysWarehouseZone");

                entity.HasIndex(e => e.Active, "idx_SysWarehouseZone_Active");

                entity.HasIndex(e => new { e.Code, e.WarehouseId, e.FloorId }, "uk_SysWarehouseZone_CodeId")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode)
                    .HasMaxLength(50)
                    .HasDefaultValueSql("('')");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.ModifiedBy).HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.SecurityLevel).HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Floor)
                    .WithMany(p => p.SysWarehouseZones)
                    .HasForeignKey(d => d.FloorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SysWarehouseZone_FloorId");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.SysWarehouseZones)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_SysWarehouseZone_WarehouseId");
            });

            modelBuilder.Entity<EfTransactionDetailDal>(entity =>
            {
                entity.ToTable("TransactionDetail");

                entity.HasIndex(e => new { e.ContainerId, e.LineType, e.Active, e.WarehouseId }, "idx_TransactionDetail1");

                entity.HasIndex(e => new { e.LineType, e.Active, e.ItemId, e.AddressId, e.ContainerId }, "idx_TransactionDetail2");

                entity.HasIndex(e => new { e.WarehouseId, e.ItemId, e.Active, e.LineType }, "idx_TransactionDetail3");

                entity.HasIndex(e => new { e.TrCode, e.WorkOrderId, e.Active }, "idx_TransactionDetail4");

                entity.HasIndex(e => e.Active, "idx_TransactionDetail_Active");

                entity.HasIndex(e => e.AddressId, "idx_TransactionDetail_Address");

                entity.HasIndex(e => e.ChildContainerId, "idx_TransactionDetail_ChildContainer");

                entity.HasIndex(e => e.ContainerId, "idx_TransactionDetail_Container");

                entity.HasIndex(e => e.ItemId, "idx_TransactionDetail_Item");

                entity.HasIndex(e => e.OrderSlipId, "idx_TransactionDetail_Order");

                entity.HasIndex(e => e.OrderSlipLineId, "idx_TransactionDetail_OrderLine");

                entity.HasIndex(e => e.PlanningSlipId, "idx_TransactionDetail_Planning");

                entity.HasIndex(e => e.PlanningSlipLineId, "idx_TransactionDetail_PlanningLine");

                entity.HasIndex(e => e.ProductionOrderId, "idx_TransactionDetail_ProdOrder");

                entity.HasIndex(e => e.ProdOrderLineId, "idx_TransactionDetail_ProdOrderLine");

                entity.HasIndex(e => e.ReservationSlipId, "idx_TransactionDetail_Reservation");

                entity.HasIndex(e => e.ReservationLineId, "idx_TransactionDetail_ReservationLine");

                entity.HasIndex(e => e.SlipId, "idx_TransactionDetail_Slip");

                entity.HasIndex(e => e.SlipLineId, "idx_TransactionDetail_SlipLine");

                entity.HasIndex(e => new { e.IoCode, e.LineType, e.LineDate }, "idx_TransactionDetail_TypeDate");

                entity.HasIndex(e => e.UnitId, "idx_TransactionDetail_Unit");

                entity.HasIndex(e => e.VariantId, "idx_TransactionDetail_Variant");

                entity.HasIndex(e => e.WarehouseId, "idx_TransactionDetail_Warehouse");

                entity.HasIndex(e => e.WorkOrderId, "idx_TransactionDetail_WorkOrder");

                entity.HasIndex(e => e.WorkOrderLineId, "idx_TransactionDetail_WorkOrderLine");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.ConvFactor1)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConvFactor2)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ExpirationDate).HasColumnType("datetime");

                entity.Property(e => e.LineDate).HasColumnType("datetime");

                entity.Property(e => e.LineDay).HasColumnType("datetime");

                entity.Property(e => e.ProductionDate).HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.TrackingNumber).HasMaxLength(100);

                entity.HasOne(d => d.OrderSlipLine)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.OrderSlipLineId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_TransactionDetail_OrderSlipLineId");

                entity.HasOne(d => d.PlanningSlipLine)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.PlanningSlipLineId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_TransactionDetail_PlanningSlipLineId");

                entity.HasOne(d => d.ProdOrderLine)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.ProdOrderLineId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_TransactionDetail_ProdOrderLineId");

                entity.HasOne(d => d.ReservationLine)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.ReservationLineId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_TransactionDetail_ReservationLineId");

                entity.HasOne(d => d.SlipLine)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.SlipLineId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_TransactionDetail_SlipLineId");

                entity.HasOne(d => d.WorkOrderLine)
                    .WithMany(p => p.TransactionDetails)
                    .HasForeignKey(d => d.WorkOrderLineId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("fk_TransactionDetail_WorkOrderLineId");
            });

            modelBuilder.Entity<EfTransactionDetailViewDal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("TransactionDetailView");

                entity.Property(e => e.ActualStock).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.Cnt).HasColumnName("cnt");

                entity.Property(e => e.LineDay).HasColumnType("datetime");

                entity.Property(e => e.PurchaseOrder).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.ReserveStock).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.SalesOrder).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.TotalInboundOrders).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.TotalInboundPlanning).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.TotalOutboundOrders).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.TotalOutboundPlanning).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.TotalProductionOrders).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.TotalProductionPlanning).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.TrackingNumber).HasMaxLength(100);
            });

            modelBuilder.Entity<EfUnitBarcodeDal>(entity =>
            {
                entity.ToTable("UnitBarcode");

                entity.HasIndex(e => e.Active, "idx_UnitBarcode_Active");

                entity.HasIndex(e => new { e.UnitId, e.ItemId }, "idx_UnitBarcode_Unit");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Barcode)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Arp)
                    .WithMany(p => p.UnitBarcodes)
                    .HasForeignKey(d => d.ArpId)
                    .HasConstraintName("fk_UnitBarcode_ArpId");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.UnitBarcodes)
                    .HasForeignKey(d => d.ItemId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_UnitBarcode_ItemId");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.UnitBarcodes)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("fk_UnitBarcode_UnitId");
            });

            modelBuilder.Entity<User>(entity =>
            {
                entity.ToTable("Users");
                entity.Property(s => s.Status)
                      .HasColumnType(SqlDbType.Bit.ToString());

                entity.Property(s => s.FirstName)
                      .HasColumnType(SqlDbType.NVarChar.ToString());

                entity.Property(s => s.UserName)
                      .HasColumnType(SqlDbType.NVarChar.ToString());

                entity.Property(s => s.LastName)
                      .HasColumnType(SqlDbType.NVarChar.ToString());

                entity.Property(s=>s.Id)
                      .HasColumnType(SqlDbType.Int.ToString());

                entity.Property(s => s.PasswordSalt)
                      .HasColumnType(SqlDbType.VarBinary.ToString());

                entity.Property(s => s.PasswordHash)
                     .HasColumnType(SqlDbType.VarBinary.ToString());

                entity.HasKey(s => s.Id);
            });

            modelBuilder.Entity<OperationClaim>(entity =>
            {
                entity.ToTable("OperationClaims");
                
                entity.Property(s => s.Id)
                    .HasColumnType(SqlDbType.Int.ToString());
                
                entity.HasKey(s => s.Id);

                entity.Property(s => s.Name)
                      .HasColumnType(SqlDbType.NVarChar.ToString());
            });

            modelBuilder.Entity<UserOperationClaim>(entity =>
            {
                entity.ToTable("UserOperationClaims");

                entity.Property(s => s.Id)
                      .HasColumnType(SqlDbType.Int.ToString());

                entity.Property(s => s.UserId)
                      .HasColumnType(SqlDbType.Int.ToString());

                entity.Property(s => s.OperationClaimId)
                      .HasColumnType(SqlDbType.Int.ToString());

                entity.HasOne(s => s.User)
                      .WithMany(s => s.OperationClaims)
                      .HasForeignKey(s=>s.UserId);

                entity.HasOne(s => s.OperationClaim)
                      .WithMany(s => s.UserOperationClaims)
                      .HasForeignKey(s=>s.OperationClaimId);
            });

            modelBuilder.Entity<efVariantTotalsViewDal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VariantTotalsView");

                entity.Property(e => e.ActualStock).HasColumnType("numeric(38, 6)");
            });

            modelBuilder.Entity<EfVariantTrackingTotalsViewDal>(entity =>
            {
                entity.HasNoKey();

                entity.ToView("VariantTrackingTotalsView");

                entity.Property(e => e.ActualStock).HasColumnType("numeric(38, 6)");

                entity.Property(e => e.TrackingNumber).HasMaxLength(100);
            });

            modelBuilder.Entity<EfVehicleDal>(entity =>
            {
                entity.ToTable("Vehicle");

                entity.HasIndex(e => e.Active, "idx_Vehicle_Active");

                entity.HasIndex(e => e.Code, "idx_Vehicle_Code");

                entity.HasIndex(e => new { e.Code, e.Name, e.PlateNumber }, "idx_Vehicle_CodeName");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.Area).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Brand).HasMaxLength(50);

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.Depth).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.Height).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Model).HasMaxLength(30);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.Name).HasMaxLength(200);

                entity.Property(e => e.Owner).HasMaxLength(50);

                entity.Property(e => e.PlateNumber).HasMaxLength(30);

                entity.Property(e => e.PlateNumber2).HasMaxLength(30);

                entity.Property(e => e.PlateNumber3).HasMaxLength(30);

                entity.Property(e => e.Volume).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Weight).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Width).HasColumnType("numeric(28, 8)");

                entity.Property(e => e.Year).HasMaxLength(20);

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.Vehicles)
                    .HasForeignKey(d => d.WarehouseId)
                    .HasConstraintName("fk_Vehicle_WarehouseId");
            });

            modelBuilder.Entity<EfWorkOrderDal>(entity =>
            {
                entity.ToTable("WorkOrder");

                entity.HasIndex(e => e.Active, "idx_WorkOrder_Active");

                entity.HasIndex(e => e.ShipmentAddressId, "idx_WorkOrder_Address");

                entity.HasIndex(e => e.ArpId, "idx_WorkOrder_Arp");

                entity.HasIndex(e => e.CustomSlipTypeId, "idx_WorkOrder_CustomType");

                entity.HasIndex(e => e.DeliveryArpId, "idx_WorkOrder_DeliveryArp");

                entity.HasIndex(e => e.DepartmentId, "idx_WorkOrder_Department");

                entity.HasIndex(e => e.DivisionId, "idx_WorkOrder_Division");

                entity.HasIndex(e => e.DriverId, "idx_WorkOrder_Driver");

                entity.HasIndex(e => e.FactoryId, "idx_WorkOrder_Factory");

                entity.HasIndex(e => e.OrderSlipId, "idx_WorkOrder_OrderSlip");

                entity.HasIndex(e => e.PlanningSlipId, "idx_WorkOrder_PlanningSlip");

                entity.HasIndex(e => e.ProdOrderLineId, "idx_WorkOrder_ProdOrderLine");

                entity.HasIndex(e => e.ProductionOrderId, "idx_WorkOrder_ProductionOrder");

                entity.HasIndex(e => e.ProjectId, "idx_WorkOrder_Project");

                entity.HasIndex(e => e.SalesPersonId, "idx_WorkOrder_SalesPerson");

                entity.HasIndex(e => e.StateId, "idx_WorkOrder_State");

                entity.HasIndex(e => new { e.SlipType, e.SlipDate }, "idx_WorkOrder_TypeDate");

                entity.HasIndex(e => e.VehicleId, "idx_WorkOrder_Vehicle");

                entity.HasIndex(e => e.WarehouseId, "idx_WorkOrder_Warehouse");

                entity.HasIndex(e => e.Warehouse2Id, "idx_WorkOrder_Warehouse2");

                entity.HasIndex(e => new { e.SlipType, e.SlipNumber }, "uk_WorkOrder_TypeNumber")
                    .IsUnique();

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.CompletedDate).HasColumnType("datetime");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.DeclarationNumber).HasMaxLength(20);

                entity.Property(e => e.Description1).HasMaxLength(50);

                entity.Property(e => e.Description2).HasMaxLength(50);

                entity.Property(e => e.Description3).HasMaxLength(50);

                entity.Property(e => e.Description4).HasMaxLength(50);

                entity.Property(e => e.DispatchNumber).HasMaxLength(10);

                entity.Property(e => e.DocumentDate).HasColumnType("datetime");

                entity.Property(e => e.DocumentNumber).HasMaxLength(50);

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.ShipmentNumber).HasMaxLength(20);

                entity.Property(e => e.SlipDate).HasColumnType("datetime");

                entity.Property(e => e.SlipNumber)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.HasOne(d => d.Arp)
                    .WithMany(p => p.WorkOrderArps)
                    .HasForeignKey(d => d.ArpId)
                    .HasConstraintName("fk_WorkOrder_ArpId");

                entity.HasOne(d => d.CustomSlipType)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.CustomSlipTypeId)
                    .HasConstraintName("fk_WorkOrder_CustomSlipTypeId");

                entity.HasOne(d => d.DeliveryArp)
                    .WithMany(p => p.WorkOrderDeliveryArps)
                    .HasForeignKey(d => d.DeliveryArpId)
                    .HasConstraintName("fk_WorkOrder_DeliveryArpId");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("fk_WorkOrder_DepartmentId");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("fk_WorkOrder_DivisionId");

                entity.HasOne(d => d.Driver)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.DriverId)
                    .HasConstraintName("fk_WorkOrder_DriverId");

                entity.HasOne(d => d.Factory)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.FactoryId)
                    .HasConstraintName("fk_WorkOrder_FactoryId");

                entity.HasOne(d => d.OrderSlip)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.OrderSlipId)
                    .HasConstraintName("fk_WorkOrder_OrderSlipId");

                entity.HasOne(d => d.PlanningSlip)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.PlanningSlipId)
                    .HasConstraintName("fk_WorkOrder_PlanningSlipId");

                entity.HasOne(d => d.ProdOrderLine)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.ProdOrderLineId)
                    .HasConstraintName("fk_WorkOrder_ProdOrderLineId");

                entity.HasOne(d => d.ProductionOrder)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.ProductionOrderId)
                    .HasConstraintName("fk_WorkOrder_ProductionOrderId");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_WorkOrder_ProjectId");

                entity.HasOne(d => d.SalesPerson)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.SalesPersonId)
                    .HasConstraintName("fk_WorkOrder_SalesPersonId");

                entity.HasOne(d => d.ShipmentAddress)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.ShipmentAddressId)
                    .HasConstraintName("fk_WorkOrder_ShipmentAddressId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_WorkOrder_StateId");

                entity.HasOne(d => d.Vehicle)
                    .WithMany(p => p.WorkOrders)
                    .HasForeignKey(d => d.VehicleId)
                    .HasConstraintName("fk_WorkOrder_VehicleId");

                entity.HasOne(d => d.Warehouse2)
                    .WithMany(p => p.WorkOrderWarehouse2s)
                    .HasForeignKey(d => d.Warehouse2Id)
                    .HasConstraintName("fk_WorkOrder_Warehouse2Id");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.WorkOrderWarehouses)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_WorkOrder_WarehouseId");
            });

            modelBuilder.Entity<EfWorkOrderLineDal>(entity =>
            {
                entity.ToTable("WorkOrderLine");

                entity.HasIndex(e => e.Active, "idx_WorkOrderLine_Active");

                entity.HasIndex(e => e.AddressId, "idx_WorkOrderLine_Address");

                entity.HasIndex(e => e.Address2Id, "idx_WorkOrderLine_Address2");

                entity.HasIndex(e => e.ArpId, "idx_WorkOrderLine_Arp");

                entity.HasIndex(e => e.ChildContainerId, "idx_WorkOrderLine_ChildContainer");

                entity.HasIndex(e => e.ChildContainer2Id, "idx_WorkOrderLine_ChildContainer2");

                entity.HasIndex(e => e.ContainerId, "idx_WorkOrderLine_Container");

                entity.HasIndex(e => e.Container2Id, "idx_WorkOrderLine_Container2");

                entity.HasIndex(e => new { e.LineDate, e.SlipType }, "idx_WorkOrderLine_DateType");

                entity.HasIndex(e => e.ItemId, "idx_WorkOrderLine_Item");

                entity.HasIndex(e => e.OrderSlipLineId, "idx_WorkOrderLine_OrderSlip");

                entity.HasIndex(e => e.PlanningSlipLineId, "idx_WorkOrderLine_PlanningSlip");

                entity.HasIndex(e => e.ProdOrderLineId, "idx_WorkOrderLine_ProdOrder");

                entity.HasIndex(e => e.ProjectId, "idx_WorkOrderLine_Project");

                entity.HasIndex(e => e.SlipId, "idx_WorkOrderLine_SlipId");

                entity.HasIndex(e => e.StateId, "idx_WorkOrderLine_State");

                entity.HasIndex(e => e.UnitId, "idx_WorkOrderLine_Unit");

                entity.HasIndex(e => e.AssignedTo, "idx_WorkOrderLine_User");

                entity.HasIndex(e => e.VariantId, "idx_WorkOrderLine_Variant");

                entity.HasIndex(e => e.WarehouseId, "idx_WorkOrderLine_Warehouse");

                entity.HasIndex(e => e.Warehouse2Id, "idx_WorkOrderLine_Warehouse2");

                entity.Property(e => e.Active).HasDefaultValueSql("((1))");

                entity.Property(e => e.AuthCode).HasMaxLength(50);

                entity.Property(e => e.ConvFactor1)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.ConvFactor2)
                    .HasColumnType("numeric(28, 8)")
                    .HasDefaultValueSql("((1))");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.CustomCode).HasMaxLength(50);

                entity.Property(e => e.Description).HasMaxLength(200);

                entity.Property(e => e.LineDate).HasColumnType("datetime");

                entity.Property(e => e.ModifiedDate).HasColumnType("datetime");

                entity.Property(e => e.PropertyBarcode).HasMaxLength(200);

                entity.Property(e => e.Quantity).HasColumnType("numeric(28, 8)");

                entity.HasOne(d => d.Address2)
                    .WithMany(p => p.WorkOrderLineAddress2s)
                    .HasForeignKey(d => d.Address2Id)
                    .HasConstraintName("fk_WorkOrderLine_Address2Id");

                entity.HasOne(d => d.Address)
                    .WithMany(p => p.WorkOrderLineAddresses)
                    .HasForeignKey(d => d.AddressId)
                    .HasConstraintName("fk_WorkOrderLine_AddressId");

                entity.HasOne(d => d.Arp)
                    .WithMany(p => p.WorkOrderLines)
                    .HasForeignKey(d => d.ArpId)
                    .HasConstraintName("fk_WorkOrderLine_ArpId");

                entity.HasOne(d => d.AssignedToNavigation)
                    .WithMany(p => p.WorkOrderLines)
                    .HasForeignKey(d => d.AssignedTo)
                    .HasConstraintName("fk_WorkOrderLine_AssignedTo");

                entity.HasOne(d => d.ChildContainer2)
                    .WithMany(p => p.WorkOrderLineChildContainer2s)
                    .HasForeignKey(d => d.ChildContainer2Id)
                    .HasConstraintName("fk_WorkOrderLine_ChildContainer2Id");

                entity.HasOne(d => d.ChildContainer)
                    .WithMany(p => p.WorkOrderLineChildContainers)
                    .HasForeignKey(d => d.ChildContainerId)
                    .HasConstraintName("fk_WorkOrderLine_ChildContainerId");

                entity.HasOne(d => d.Container2)
                    .WithMany(p => p.WorkOrderLineContainer2s)
                    .HasForeignKey(d => d.Container2Id)
                    .HasConstraintName("fk_WorkOrderLine_Container2Id");

                entity.HasOne(d => d.Container)
                    .WithMany(p => p.WorkOrderLineContainers)
                    .HasForeignKey(d => d.ContainerId)
                    .HasConstraintName("fk_WorkOrderLine_ContainerId");

                entity.HasOne(d => d.Item)
                    .WithMany(p => p.WorkOrderLineItems)
                    .HasForeignKey(d => d.ItemId)
                    .HasConstraintName("fk_WorkOrderLine_ItemId");

                entity.HasOne(d => d.OrderSlipLine)
                    .WithMany(p => p.WorkOrderLines)
                    .HasForeignKey(d => d.OrderSlipLineId)
                    .HasConstraintName("fk_WorkOrderLine_OrderSlipLineId");

                entity.HasOne(d => d.PlanningSlipLine)
                    .WithMany(p => p.WorkOrderLines)
                    .HasForeignKey(d => d.PlanningSlipLineId)
                    .HasConstraintName("fk_WorkOrderLine_PlanningSlipLineId");

                entity.HasOne(d => d.ProdOrderLine)
                    .WithMany(p => p.WorkOrderLines)
                    .HasForeignKey(d => d.ProdOrderLineId)
                    .HasConstraintName("fk_WorkOrderLine_ProdOrderLineId");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.WorkOrderLines)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("fk_WorkOrderLine_ProjectId");

                entity.HasOne(d => d.Slip)
                    .WithMany(p => p.WorkOrderLines)
                    .HasForeignKey(d => d.SlipId)
                    .HasConstraintName("fk_WorkOrderLine_SlipId");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.WorkOrderLines)
                    .HasForeignKey(d => d.StateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_WorkOrderLine_StateId");

                entity.HasOne(d => d.Unit)
                    .WithMany(p => p.WorkOrderLines)
                    .HasForeignKey(d => d.UnitId)
                    .HasConstraintName("fk_WorkOrderLine_UnitId");

                entity.HasOne(d => d.Variant)
                    .WithMany(p => p.WorkOrderLineVariants)
                    .HasForeignKey(d => d.VariantId)
                    .HasConstraintName("fk_WorkOrderLine_VariantId");

                entity.HasOne(d => d.Warehouse2)
                    .WithMany(p => p.WorkOrderLineWarehouse2s)
                    .HasForeignKey(d => d.Warehouse2Id)
                    .HasConstraintName("fk_WorkOrderLine_Warehouse2Id");

                entity.HasOne(d => d.Warehouse)
                    .WithMany(p => p.WorkOrderLineWarehouses)
                    .HasForeignKey(d => d.WarehouseId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_WorkOrderLine_WarehouseId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
