using System;
using System.Collections.Generic;
using AgriKingApp.Models;
using Microsoft.EntityFrameworkCore;

namespace AgriKingApp.Data;

public partial class DataContext : DbContext
{
    public DataContext()
    {
    }

    public DataContext(DbContextOptions<DataContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AnalysisCalculationReference> AnalysisCalculationReferences { get; set; }

    public virtual DbSet<AnalysisCategory> AnalysisCategories { get; set; }

    public virtual DbSet<AnalysisCategorySequence> AnalysisCategorySequences { get; set; }

    public virtual DbSet<AnalysisGroup> AnalysisGroups { get; set; }

    public virtual DbSet<AnalysisNonNumericResult> AnalysisNonNumericResults { get; set; }

    public virtual DbSet<AnalysisNonNumericResultOption> AnalysisNonNumericResultOptions { get; set; }

    public virtual DbSet<AnalysisProcessType> AnalysisProcessTypes { get; set; }

    public virtual DbSet<AnalysisSource> AnalysisSources { get; set; }

    public virtual DbSet<AnalysisSourceExclusion> AnalysisSourceExclusions { get; set; }

    public virtual DbSet<AnalysisType> AnalysisTypes { get; set; }

    public virtual DbSet<AnalysisTypeDefaultValuesAne> AnalysisTypeDefaultValuesAnes { get; set; }

    public virtual DbSet<AnalysisTypeSourceSequence> AnalysisTypeSourceSequences { get; set; }

    public virtual DbSet<AnalysisUnitsOfMeasure> AnalysisUnitsOfMeasures { get; set; }

    public virtual DbSet<AnimalBreed> AnimalBreeds { get; set; }

    public virtual DbSet<AnimalType> AnimalTypes { get; set; }

    public virtual DbSet<ApiRequest> ApiRequests { get; set; }

    public virtual DbSet<ApiRequestError> ApiRequestErrors { get; set; }

    public virtual DbSet<Audit> Audits { get; set; }

    public virtual DbSet<Bin> Bins { get; set; }

    public virtual DbSet<Commission> Commissions { get; set; }

    public virtual DbSet<CommissionDetail> CommissionDetails { get; set; }

    public virtual DbSet<CommissionPayment> CommissionPayments { get; set; }

    public virtual DbSet<ControlNumber> ControlNumbers { get; set; }

    public virtual DbSet<Country> Countries { get; set; }

    public virtual DbSet<CreditMemo> CreditMemos { get; set; }

    public virtual DbSet<CreditMemoDetail> CreditMemoDetails { get; set; }

    public virtual DbSet<CreditMemoInvoice> CreditMemoInvoices { get; set; }

    public virtual DbSet<Currency> Currencies { get; set; }

    public virtual DbSet<CurrencyExchangeRate> CurrencyExchangeRates { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerAddress> CustomerAddresses { get; set; }

    public virtual DbSet<CustomerCategory> CustomerCategories { get; set; }

    public virtual DbSet<CustomerContact> CustomerContacts { get; set; }

    public virtual DbSet<CustomerLabCode> CustomerLabCodes { get; set; }

    public virtual DbSet<CustomerLicense> CustomerLicenses { get; set; }

    public virtual DbSet<CustomerLicenseType> CustomerLicenseTypes { get; set; }

    public virtual DbSet<CustomerRationCode> CustomerRationCodes { get; set; }

    public virtual DbSet<CustomerResultDeliveryCode> CustomerResultDeliveryCodes { get; set; }

    public virtual DbSet<CustomerSalesperson> CustomerSalespeople { get; set; }

    public virtual DbSet<CustomerServiceCenter> CustomerServiceCenters { get; set; }

    public virtual DbSet<Department> Departments { get; set; }

    public virtual DbSet<DepartmentManager> DepartmentManagers { get; set; }

    public virtual DbSet<Distribution> Distributions { get; set; }

    public virtual DbSet<DistributionTemp> DistributionTemps { get; set; }

    public virtual DbSet<Division> Divisions { get; set; }

    public virtual DbSet<AgriKingApp.Models.Email> Emails { get; set; }

    public virtual DbSet<EmailLog> EmailLogs { get; set; }

    public virtual DbSet<EmailLogAttachment> EmailLogAttachments { get; set; }

    public virtual DbSet<EmailLogRecipient> EmailLogRecipients { get; set; }

    public virtual DbSet<EmailRecipient> EmailRecipients { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeAddress> EmployeeAddresses { get; set; }

    public virtual DbSet<EmployeeContact> EmployeeContacts { get; set; }

    public virtual DbSet<EmployeeDepartment> EmployeeDepartments { get; set; }

    public virtual DbSet<EmployeeJobTitle> EmployeeJobTitles { get; set; }

    public virtual DbSet<EmployeeSavingsAccount> EmployeeSavingsAccounts { get; set; }

    public virtual DbSet<EmployeeSavingsAccountRate> EmployeeSavingsAccountRates { get; set; }

    public virtual DbSet<EmployeeSavingsAccountStatus> EmployeeSavingsAccountStatuses { get; set; }

    public virtual DbSet<EmployeeSavingsTransaction> EmployeeSavingsTransactions { get; set; }

    public virtual DbSet<EmployeeSavingsTransactionMemo> EmployeeSavingsTransactionMemos { get; set; }

    public virtual DbSet<EmployeeSavingsTransactionType> EmployeeSavingsTransactionTypes { get; set; }

    public virtual DbSet<EmployeeStatus> EmployeeStatuses { get; set; }

    public virtual DbSet<EmployeeTerm> EmployeeTerms { get; set; }

    public virtual DbSet<EmployeeTermEndType> EmployeeTermEndTypes { get; set; }

    public virtual DbSet<EmployeeTermType> EmployeeTermTypes { get; set; }

    public virtual DbSet<EmployeeTimeEntry> EmployeeTimeEntries { get; set; }

    public virtual DbSet<EmployeeType> EmployeeTypes { get; set; }

    public virtual DbSet<EmployeesImport> EmployeesImports { get; set; }

    public virtual DbSet<ExportCreditMemo> ExportCreditMemos { get; set; }

    public virtual DbSet<ExportCreditMemoCommission> ExportCreditMemoCommissions { get; set; }

    public virtual DbSet<ExportCreditMemoDetail> ExportCreditMemoDetails { get; set; }

    public virtual DbSet<ExportCreditMemoInvoiceDetail> ExportCreditMemoInvoiceDetails { get; set; }

    public virtual DbSet<ExportCreditMemoInvoiceHeader> ExportCreditMemoInvoiceHeaders { get; set; }

    public virtual DbSet<ExportCustomer> ExportCustomers { get; set; }

    public virtual DbSet<ExportInvoice> ExportInvoices { get; set; }

    public virtual DbSet<ExportInvoiceCommission> ExportInvoiceCommissions { get; set; }

    public virtual DbSet<ExportInvoiceDetail> ExportInvoiceDetails { get; set; }

    public virtual DbSet<ExportMillAllocation> ExportMillAllocations { get; set; }

    public virtual DbSet<ExportMillAllocationCommission> ExportMillAllocationCommissions { get; set; }

    public virtual DbSet<ExportMillAllocationDetail> ExportMillAllocationDetails { get; set; }

    public virtual DbSet<ExportMillAllocationPayment> ExportMillAllocationPayments { get; set; }

    public virtual DbSet<ExportMillAllocationPaymentDetail> ExportMillAllocationPaymentDetails { get; set; }

    public virtual DbSet<ExportPayment> ExportPayments { get; set; }

    public virtual DbSet<ExportPaymentInvoice> ExportPaymentInvoices { get; set; }

    public virtual DbSet<ExportSample> ExportSamples { get; set; }

    public virtual DbSet<ExportSampleDetail> ExportSampleDetails { get; set; }

    public virtual DbSet<ExportSampleMeta> ExportSampleMetas { get; set; }

    public virtual DbSet<FileUpload> FileUploads { get; set; }

    public virtual DbSet<FileUploadType> FileUploadTypes { get; set; }

    public virtual DbSet<Gender> Genders { get; set; }

    public virtual DbSet<ImportLog> ImportLogs { get; set; }

    public virtual DbSet<ImportTask> ImportTasks { get; set; }

    public virtual DbSet<ImportTaskLog> ImportTaskLogs { get; set; }

    public virtual DbSet<Invoice> Invoices { get; set; }

    public virtual DbSet<InvoiceDetail> InvoiceDetails { get; set; }

    public virtual DbSet<Item> Items { get; set; }

    public virtual DbSet<ItemFormula> ItemFormulas { get; set; }

    public virtual DbSet<ItemFormulaRevision> ItemFormulaRevisions { get; set; }

    public virtual DbSet<ItemFormulaRevisionComponent> ItemFormulaRevisionComponents { get; set; }

    public virtual DbSet<ItemFulfillment> ItemFulfillments { get; set; }

    public virtual DbSet<ItemFulfillmentDetail> ItemFulfillmentDetails { get; set; }

    public virtual DbSet<ItemPrice> ItemPrices { get; set; }

    public virtual DbSet<ItemPricePeriod> ItemPricePeriods { get; set; }

    public virtual DbSet<ItemVolumePrice> ItemVolumePrices { get; set; }

    public virtual DbSet<LabContainer> LabContainers { get; set; }

    public virtual DbSet<LabContainerType> LabContainerTypes { get; set; }

    public virtual DbSet<LabPackage> LabPackages { get; set; }

    public virtual DbSet<LabPackageAnalysis> LabPackageAnalyses { get; set; }

    public virtual DbSet<LabSlopeIntercept> LabSlopeIntercepts { get; set; }

    public virtual DbSet<LabSpecialAnalysisRequest> LabSpecialAnalysisRequests { get; set; }

    public virtual DbSet<LabSpecialAnalysisRequestAnalysis> LabSpecialAnalysisRequestAnalyses { get; set; }

    public virtual DbSet<LabSpecialAnalysisRequestSample> LabSpecialAnalysisRequestSamples { get; set; }

    public virtual DbSet<LabXrayCorrection> LabXrayCorrections { get; set; }

    public virtual DbSet<AgriKingApp.Models.Location> Locations { get; set; }

    public virtual DbSet<MaritalStatus> MaritalStatuses { get; set; }

    public virtual DbSet<MenuIcon> MenuIcons { get; set; }

    public virtual DbSet<AgriKingApp.Models.MenuItem> MenuItems { get; set; }

    public virtual DbSet<MenuItemUserGroup> MenuItemUserGroups { get; set; }

    public virtual DbSet<MenuTarget> MenuTargets { get; set; }

    public virtual DbSet<MillAllocation> MillAllocations { get; set; }

    public virtual DbSet<MillAllocationAssociation> MillAllocationAssociations { get; set; }

    public virtual DbSet<MillAllocationDetail> MillAllocationDetails { get; set; }

    public virtual DbSet<MillAllocationDetailItem> MillAllocationDetailItems { get; set; }

    public virtual DbSet<MillAllocationType> MillAllocationTypes { get; set; }

    public virtual DbSet<NamePrefix> NamePrefixes { get; set; }

    public virtual DbSet<NameSuffix> NameSuffixes { get; set; }

    public virtual DbSet<Note> Notes { get; set; }

    public virtual DbSet<Nstruck> Nstrucks { get; set; }

    public virtual DbSet<NstruckDrop> NstruckDrops { get; set; }

    public virtual DbSet<Payment> Payments { get; set; }

    public virtual DbSet<PaymentInvoice> PaymentInvoices { get; set; }

    public virtual DbSet<PaymentTerm> PaymentTerms { get; set; }

    public virtual DbSet<PriceLevel> PriceLevels { get; set; }

    public virtual DbSet<Ration> Rations { get; set; }

    public virtual DbSet<RationCategory> RationCategories { get; set; }

    public virtual DbSet<RationType> RationTypes { get; set; }

    public virtual DbSet<AgriKingApp.Models.Region> Regions { get; set; }

    public virtual DbSet<Report> Reports { get; set; }

    public virtual DbSet<ReportGroup> ReportGroups { get; set; }

    public virtual DbSet<ReportGroupAssignment> ReportGroupAssignments { get; set; }

    public virtual DbSet<ReportTemplate> ReportTemplates { get; set; }

    public virtual DbSet<ReportTemplateDetail> ReportTemplateDetails { get; set; }

    public virtual DbSet<RestEndpoint> RestEndpoints { get; set; }

    public virtual DbSet<RestQueue> RestQueues { get; set; }

    public virtual DbSet<RestQueueAction> RestQueueActions { get; set; }

    public virtual DbSet<RestQueueEntry> RestQueueEntries { get; set; }

    public virtual DbSet<SalesOrder> SalesOrders { get; set; }

    public virtual DbSet<SalesOrderCommissionDetail> SalesOrderCommissionDetails { get; set; }

    public virtual DbSet<SalesOrderDetail> SalesOrderDetails { get; set; }

    public virtual DbSet<SalesOrderDetailLot> SalesOrderDetailLots { get; set; }

    public virtual DbSet<SalesOrderType> SalesOrderTypes { get; set; }

    public virtual DbSet<Salesperson> Salespeople { get; set; }

    public virtual DbSet<SalespersonExpenseAccount> SalespersonExpenseAccounts { get; set; }

    public virtual DbSet<SalespersonExpenseTransaction> SalespersonExpenseTransactions { get; set; }

    public virtual DbSet<SalespersonExpenseTransactionType> SalespersonExpenseTransactionTypes { get; set; }

    public virtual DbSet<Sample> Samples { get; set; }

    public virtual DbSet<SampleAnalysisFinalValue> SampleAnalysisFinalValues { get; set; }

    public virtual DbSet<SampleAnalysisFinalValueImport> SampleAnalysisFinalValueImports { get; set; }

    public virtual DbSet<SampleAnalysisLimit> SampleAnalysisLimits { get; set; }

    public virtual DbSet<SampleAnalysisReportRange> SampleAnalysisReportRanges { get; set; }

    public virtual DbSet<SampleAnalysisStatistic> SampleAnalysisStatistics { get; set; }

    public virtual DbSet<SampleAnalysisTargetValue> SampleAnalysisTargetValues { get; set; }

    public virtual DbSet<SampleAnalysisWeight> SampleAnalysisWeights { get; set; }

    public virtual DbSet<SampleAnalysisWeightType> SampleAnalysisWeightTypes { get; set; }

    public virtual DbSet<SampleAnalysisWorkingValue> SampleAnalysisWorkingValues { get; set; }

    public virtual DbSet<SampleCategory> SampleCategories { get; set; }

    public virtual DbSet<SampleCategoryAnalysisType> SampleCategoryAnalysisTypes { get; set; }

    public virtual DbSet<SampleMoistureWeight> SampleMoistureWeights { get; set; }

    public virtual DbSet<SampleNotification> SampleNotifications { get; set; }

    public virtual DbSet<SampleParticleSizeAnalysis> SampleParticleSizeAnalyses { get; set; }

    public virtual DbSet<SampleRequest> SampleRequests { get; set; }

    public virtual DbSet<SampleResultExportTemplate> SampleResultExportTemplates { get; set; }

    public virtual DbSet<SampleStatus> SampleStatuses { get; set; }

    public virtual DbSet<SampleType> SampleTypes { get; set; }

    public virtual DbSet<SampleTypeAnalysisType> SampleTypeAnalysisTypes { get; set; }

    public virtual DbSet<SampleTypeAnalysisTypeSourceSequence> SampleTypeAnalysisTypeSourceSequences { get; set; }

    public virtual DbSet<ScheduledTask> ScheduledTasks { get; set; }

    public virtual DbSet<ScheduledTaskJob> ScheduledTaskJobs { get; set; }

    public virtual DbSet<ScheduledTaskJobLog> ScheduledTaskJobLogs { get; set; }

    public virtual DbSet<ScheduledTaskJobParameter> ScheduledTaskJobParameters { get; set; }

    public virtual DbSet<ScheduledTaskParameter> ScheduledTaskParameters { get; set; }

    public virtual DbSet<ScheduledTaskTime> ScheduledTaskTimes { get; set; }

    public virtual DbSet<ServiceCenter> ServiceCenters { get; set; }

    public virtual DbSet<SmartCheck> SmartChecks { get; set; }

    public virtual DbSet<SmartCheckAnalysisType> SmartCheckAnalysisTypes { get; set; }

    public virtual DbSet<SmartCheckEmployee> SmartCheckEmployees { get; set; }

    public virtual DbSet<SmartCheckForage> SmartCheckForages { get; set; }

    public virtual DbSet<SmartCheckForageImage> SmartCheckForageImages { get; set; }

    public virtual DbSet<SmartCheckForageSample> SmartCheckForageSamples { get; set; }

    public virtual DbSet<SmartCheckForageSampleAnalysisValue> SmartCheckForageSampleAnalysisValues { get; set; }

    public virtual DbSet<SmartCheckForageTemperature> SmartCheckForageTemperatures { get; set; }

    public virtual DbSet<State> States { get; set; }

    public virtual DbSet<Subsidiary> Subsidiaries { get; set; }

    public virtual DbSet<SubsidiaryItem> SubsidiaryItems { get; set; }

    public virtual DbSet<SystemKeyValue> SystemKeyValues { get; set; }

    public virtual DbSet<TransferOrder> TransferOrders { get; set; }

    public virtual DbSet<TransferOrdersDetail> TransferOrdersDetails { get; set; }

    public virtual DbSet<Truck> Trucks { get; set; }

    public virtual DbSet<TruckDefault> TruckDefaults { get; set; }

    public virtual DbSet<TruckDrop> TruckDrops { get; set; }

    public virtual DbSet<TruckException> TruckExceptions { get; set; }

    public virtual DbSet<TruckFinal> TruckFinals { get; set; }

    public virtual DbSet<Unit> Units { get; set; }

    public virtual DbSet<UnitType> UnitTypes { get; set; }

    public virtual DbSet<User> Users { get; set; }

    public virtual DbSet<UserGroup> UserGroups { get; set; }

    public virtual DbSet<UserKeyValue> UserKeyValues { get; set; }

    public virtual DbSet<UserMessage> UserMessages { get; set; }

    public virtual DbSet<UserStatus> UserStatuses { get; set; }

    public virtual DbSet<UserType> UserTypes { get; set; }

    public virtual DbSet<WorkOrder> WorkOrders { get; set; }

    public virtual DbSet<WorkOrderBatch> WorkOrderBatches { get; set; }

    public virtual DbSet<WorkOrderBatchAssembly> WorkOrderBatchAssemblies { get; set; }

    public virtual DbSet<WorkOrderBatchAssemblyComponent> WorkOrderBatchAssemblyComponents { get; set; }

    public virtual DbSet<WorkOrderBatchComponent> WorkOrderBatchComponents { get; set; }

    public virtual DbSet<XrayCalibrationCategory> XrayCalibrationCategories { get; set; }

    public virtual DbSet<ZipCode> ZipCodes { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
        //=> optionsBuilder.UseSqlServer("Server=AK-SQL;User ID=AgriKingWeb;Password=AgriKingFulton!!;Database=AgriKingTest;Trusted_Connection=True;encrypt=false");
        => optionsBuilder.UseSqlite(@"DataSource=" + Constants.DatabasePath);
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AnalysisCalculationReference>(entity =>
        {
            entity.HasIndex(e => e.AnalysisTypeId, "IX_AnalysisCalculationReferences_AnalysisTypeId");

            entity.HasIndex(e => e.SampleTypeId, "IX_AnalysisCalculationReferences_SampleTypeId");

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.AnalysisCalculationReferences).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.SampleType).WithMany(p => p.AnalysisCalculationReferences).HasForeignKey(d => d.SampleTypeId);
        });

        modelBuilder.Entity<AnalysisCategorySequence>(entity =>
        {
            entity.HasKey(e => new { e.AnalysisCategoryId, e.AnalysisSourceId });

            entity.HasIndex(e => e.AnalysisSourceId, "IX_AnalysisCategorySequences_AnalysisSourceId");

            entity.HasOne(d => d.AnalysisCategory).WithMany(p => p.AnalysisCategorySequences).HasForeignKey(d => d.AnalysisCategoryId);

            entity.HasOne(d => d.AnalysisSource).WithMany(p => p.AnalysisCategorySequences).HasForeignKey(d => d.AnalysisSourceId);
        });

        modelBuilder.Entity<AnalysisGroup>(entity =>
        {
            entity.HasMany(d => d.AnalysisTypes).WithMany(p => p.AnalysisGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "AnalysisGroupAnalysisType",
                    r => r.HasOne<AnalysisType>().WithMany().HasForeignKey("AnalysisTypeId"),
                    l => l.HasOne<AnalysisGroup>().WithMany().HasForeignKey("AnalysisGroupId"),
                    j =>
                    {
                        j.HasKey("AnalysisGroupId", "AnalysisTypeId");
                        j.ToTable("AnalysisGroupAnalysisTypes");
                        j.HasIndex(new[] { "AnalysisTypeId" }, "IX_AnalysisGroupAnalysisTypes_AnalysisTypeId");
                    });
        });

        modelBuilder.Entity<AnalysisNonNumericResult>(entity =>
        {
            entity.HasIndex(e => e.AnalysisSourceId, "IX_AnalysisNonNumericResults_AnalysisSourceId")
                .IsUnique()
                .HasFilter("([AnalysisSourceId] IS NOT NULL)");

            entity.HasOne(d => d.AnalysisSource).WithOne(p => p.AnalysisNonNumericResult).HasForeignKey<AnalysisNonNumericResult>(d => d.AnalysisSourceId);
        });

        modelBuilder.Entity<AnalysisNonNumericResultOption>(entity =>
        {
            entity.HasIndex(e => e.AnalysisNonNumericResultId, "IX_AnalysisNonNumericResultOptions_AnalysisNonNumericResultId");

            entity.Property(e => e.HighRangeValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.LowRangeValue).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnalysisNonNumericResult).WithMany(p => p.AnalysisNonNumericResultOptions).HasForeignKey(d => d.AnalysisNonNumericResultId);
        });

        modelBuilder.Entity<AnalysisSource>(entity =>
        {
            entity.HasIndex(e => e.ProcessTypeId, "IX_AnalysisSources_ProcessTypeId");

            entity.HasOne(d => d.ProcessType).WithMany(p => p.AnalysisSources).HasForeignKey(d => d.ProcessTypeId);
        });

        modelBuilder.Entity<AnalysisSourceExclusion>(entity =>
        {
            entity.HasIndex(e => e.AnalysisSourceId, "IX_AnalysisSourceExclusions_AnalysisSourceId");

            entity.HasIndex(e => e.AnalysisTypeId, "IX_AnalysisSourceExclusions_AnalysisTypeId");

            entity.HasOne(d => d.AnalysisSource).WithMany(p => p.AnalysisSourceExclusions).HasForeignKey(d => d.AnalysisSourceId);

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.AnalysisSourceExclusions).HasForeignKey(d => d.AnalysisTypeId);
        });

        modelBuilder.Entity<AnalysisType>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_AnalysisTypes_CategoryId");

            entity.HasIndex(e => e.NonNumericResultId, "IX_AnalysisTypes_NonNumericResultId");

            entity.HasIndex(e => e.UnitOfMeasureId, "IX_AnalysisTypes_UnitOfMeasureId");

            entity.Property(e => e.SpecialAnalysisReport)
                .IsRequired();
            //.HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.ToxinReport)
                .IsRequired();
                //.HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.Category).WithMany(p => p.AnalysisTypes).HasForeignKey(d => d.CategoryId);

            entity.HasOne(d => d.NonNumericResult).WithMany(p => p.AnalysisTypes).HasForeignKey(d => d.NonNumericResultId);

            entity.HasOne(d => d.UnitOfMeasure).WithMany(p => p.AnalysisTypes).HasForeignKey(d => d.UnitOfMeasureId);
        });

        modelBuilder.Entity<AnalysisTypeDefaultValuesAne>(entity =>
        {
            entity.ToTable("AnalysisTypeDefaultValuesANE");

            entity.Property(e => e.DefaultValue).HasColumnType("decimal(18, 2)");
        });

        modelBuilder.Entity<AnalysisTypeSourceSequence>(entity =>
        {
            entity.HasKey(e => new { e.AnalysisTypeId, e.AnalysisSourceId });

            entity.HasIndex(e => e.AnalysisSourceId, "IX_AnalysisTypeSourceSequences_AnalysisSourceId");

            entity.Property(e => e.WetLabCost).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnalysisSource).WithMany(p => p.AnalysisTypeSourceSequences).HasForeignKey(d => d.AnalysisSourceId);

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.AnalysisTypeSourceSequences).HasForeignKey(d => d.AnalysisTypeId);
        });

        modelBuilder.Entity<AnalysisUnitsOfMeasure>(entity =>
        {
            entity.ToTable("AnalysisUnitsOfMeasure");
        });

        modelBuilder.Entity<AnimalBreed>(entity =>
        {
            entity.HasKey(e => new { e.AnimalTypeId, e.AnimalBreedId });

            entity.HasOne(d => d.AnimalType).WithMany(p => p.AnimalBreeds).HasForeignKey(d => d.AnimalTypeId);
        });

        modelBuilder.Entity<ApiRequest>(entity =>
        {
            entity.Property(e => e.RequestBody)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.RequestStatus)
                .HasMaxLength(1000)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ApiRequestError>(entity =>
        {
            entity.HasIndex(e => e.ApiRequestId, "IX_ApiRequestErrors_ApiRequestId");

            entity.HasOne(d => d.ApiRequest).WithMany(p => p.ApiRequestErrors).HasForeignKey(d => d.ApiRequestId);
        });

        modelBuilder.Entity<Audit>(entity =>
        {
            entity.HasIndex(e => e.AuditUserId, "IX_Audits_AuditUserId");

            //entity.Property(e => e.AuditGuid).HasDefaultValueSql("(N'')");
            //entity.Property(e => e.EntityField).HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.AuditUser).WithMany(p => p.Audits).HasForeignKey(d => d.AuditUserId);
        });

        modelBuilder.Entity<Bin>(entity =>
        {
            entity.HasIndex(e => e.LocationId, "IX_Bins_LocationId");

            entity.HasIndex(e => e.SalespersonId, "IX_Bins_SalespersonId");

            entity.HasOne(d => d.Location).WithMany(p => p.Bins).HasForeignKey(d => d.LocationId);

            entity.HasOne(d => d.Salesperson).WithMany(p => p.Bins).HasForeignKey(d => d.SalespersonId);
        });

        modelBuilder.Entity<Commission>(entity =>
        {
            entity.HasIndex(e => e.InvoiceId, "IX_Commissions_InvoiceId");

            entity.HasIndex(e => e.SalespersonId, "IX_Commissions_SalespersonId");

            entity.Property(e => e.PresidentsClubRate).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.SplitCommissionRate).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.Invoice).WithMany(p => p.Commissions).HasForeignKey(d => d.InvoiceId);

            entity.HasOne(d => d.Salesperson).WithMany(p => p.Commissions).HasForeignKey(d => d.SalespersonId);
        });

        modelBuilder.Entity<CommissionDetail>(entity =>
        {
            entity.HasIndex(e => e.CurrencyId, "IX_CommissionDetails_CurrencyId");

            entity.HasIndex(e => e.InvoiceId, "IX_CommissionDetails_InvoiceId");

            entity.HasIndex(e => e.ItemId, "IX_CommissionDetails_ItemId");

            entity.HasIndex(e => e.SalespersonId, "IX_CommissionDetails_SalespersonId");

            entity.Property(e => e.CommissionAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.CommissionSplitAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.CommissionSplitPercent).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.PresidentsClubAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.PresidentsClubDollarAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.PresidentsClubSplitAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.PresidentsClubSplitDollarAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.PresidentsClubSplitPercent).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.Currency).WithMany(p => p.CommissionDetails).HasForeignKey(d => d.CurrencyId);

            entity.HasOne(d => d.Invoice).WithMany(p => p.CommissionDetails).HasForeignKey(d => d.InvoiceId);

            entity.HasOne(d => d.Item).WithMany(p => p.CommissionDetails).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Salesperson).WithMany(p => p.CommissionDetails).HasForeignKey(d => d.SalespersonId);
        });

        modelBuilder.Entity<CommissionPayment>(entity =>
        {
            entity.HasIndex(e => e.InvoiceId, "IX_CommissionPayments_InvoiceId");

            entity.HasIndex(e => e.InvoiceItemId, "IX_CommissionPayments_InvoiceItemId");

            entity.HasIndex(e => e.SalespersonId, "IX_CommissionPayments_SalespersonId");

            entity.Property(e => e.PaidCommissionAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.PaidSplitCommissionAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.Invoice).WithMany(p => p.CommissionPayments).HasForeignKey(d => d.InvoiceId);

            entity.HasOne(d => d.InvoiceItem).WithMany(p => p.CommissionPayments).HasForeignKey(d => d.InvoiceItemId);

            entity.HasOne(d => d.Salesperson).WithMany(p => p.CommissionPayments).HasForeignKey(d => d.SalespersonId);
        });

        modelBuilder.Entity<ControlNumber>(entity =>
        {
            entity.HasIndex(e => new { e.Type, e.Id }, "IX_ControlNumbers_Type_Id");
        });

        modelBuilder.Entity<Country>(entity =>
        {
            entity.HasIndex(e => e.CurrencyCode, "IX_Countries_CurrencyCode");

            entity.HasOne(d => d.CurrencyCodeNavigation).WithMany(p => p.Countries).HasForeignKey(d => d.CurrencyCode);
        });

        modelBuilder.Entity<CreditMemo>(entity =>
        {
            entity.HasIndex(e => e.CurrencyId, "IX_CreditMemos_CurrencyId");

            entity.HasIndex(e => e.CustomerId, "IX_CreditMemos_CustomerId");

            entity.HasIndex(e => e.SalesOrderTypeId, "IX_CreditMemos_SalesOrderTypeId");

            entity.HasOne(d => d.Currency).WithMany(p => p.CreditMemos).HasForeignKey(d => d.CurrencyId);

            entity.HasOne(d => d.Customer).WithMany(p => p.CreditMemos).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.SalesOrderType).WithMany(p => p.CreditMemos).HasForeignKey(d => d.SalesOrderTypeId);
        });

        modelBuilder.Entity<CreditMemoDetail>(entity =>
        {
            entity.HasIndex(e => e.CreditMemoId, "IX_CreditMemoDetails_CreditMemoId");

            entity.HasIndex(e => e.ItemId, "IX_CreditMemoDetails_ItemId");

            entity.HasIndex(e => e.UnitId, "IX_CreditMemoDetails_UnitId");

            entity.Property(e => e.GrossAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.ItemDollarPrice).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.ItemPrice).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.TaxRate).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.CreditMemo).WithMany(p => p.CreditMemoDetails).HasForeignKey(d => d.CreditMemoId);

            entity.HasOne(d => d.Item).WithMany(p => p.CreditMemoDetails).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Unit).WithMany(p => p.CreditMemoDetails).HasForeignKey(d => d.UnitId);
        });

        modelBuilder.Entity<CreditMemoInvoice>(entity =>
        {
            entity.HasIndex(e => e.CreditMemoId, "IX_CreditMemoInvoices_CreditMemoId");

            entity.HasIndex(e => e.InvoiceId, "IX_CreditMemoInvoices_InvoiceId");

            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.RemainingBalance).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.CreditMemo).WithMany(p => p.CreditMemoInvoices).HasForeignKey(d => d.CreditMemoId);

            entity.HasOne(d => d.Invoice).WithMany(p => p.CreditMemoInvoices).HasForeignKey(d => d.InvoiceId);
        });

        modelBuilder.Entity<CurrencyExchangeRate>(entity =>
        {
            entity.HasIndex(e => e.BaseCurrencyId, "IX_CurrencyExchangeRates_BaseCurrencyId");

            entity.HasIndex(e => e.TransactionCurrencyId, "IX_CurrencyExchangeRates_TransactionCurrencyId");

            entity.Property(e => e.ExchangeRate).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.BaseCurrency).WithMany(p => p.CurrencyExchangeRateBaseCurrencies).HasForeignKey(d => d.BaseCurrencyId);

            entity.HasOne(d => d.TransactionCurrency).WithMany(p => p.CurrencyExchangeRateTransactionCurrencies).HasForeignKey(d => d.TransactionCurrencyId);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_Customers_CategoryId");

            entity.HasIndex(e => new { e.Collections, e.Id }, "IX_Customers_Collections_Id");

            entity.HasIndex(e => e.CurrencyId, "IX_Customers_CurrencyId");

            entity.HasIndex(e => e.CustomerLabCodeId, "IX_Customers_CustomerLabCodeId");

            entity.HasIndex(e => e.CustomerRationCodeId, "IX_Customers_CustomerRationCodeId");

            entity.HasIndex(e => e.CustomerResultDeliveryCodeId, "IX_Customers_CustomerResultDeliveryCodeId");

            entity.HasIndex(e => new { e.DisplayName, e.Id }, "IX_Customers_DisplayName_Id");

            entity.HasIndex(e => e.DivisionId, "IX_Customers_DivisionId");

            entity.HasIndex(e => new { e.FirstName, e.LastName, e.Id }, "IX_Customers_FirstName_LastName_Id");

            entity.HasIndex(e => new { e.Inactive, e.Id }, "IX_Customers_Inactive_Id");

            entity.HasIndex(e => e.LandlordId, "IX_Customers_LandlordId");

            entity.HasIndex(e => e.LocationId, "IX_Customers_LocationId");

            entity.HasIndex(e => new { e.Locked, e.Id }, "IX_Customers_Locked_Id");

            entity.HasIndex(e => e.NstruckDropId, "IX_Customers_NSTruckDropId");

            entity.HasIndex(e => e.NstruckId, "IX_Customers_NSTruckId");

            entity.HasIndex(e => e.PaymentTermId, "IX_Customers_PaymentTermId");

            entity.HasIndex(e => e.PriceLevelId, "IX_Customers_PriceLevelId");

            entity.HasIndex(e => e.RegionId, "IX_Customers_RegionId");

            entity.HasIndex(e => e.SalespersonId, "IX_Customers_SalespersonId");

            entity.HasIndex(e => e.SubsidiaryId, "IX_Customers_SubsidiaryId");

            entity.HasIndex(e => e.TruckDropId, "IX_Customers_TruckDropId");

            entity.HasIndex(e => e.TruckId, "IX_Customers_TruckId");

            entity.Property(e => e.Balance).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Current).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Deposit).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.LabQc).HasColumnName("LabQC");
            entity.Property(e => e.NinetyDay).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.NstruckDropId).HasColumnName("NSTruckDropId");
            entity.Property(e => e.NstruckId).HasColumnName("NSTruckId");
            entity.Property(e => e.OverNinety).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Overdue).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.SixtyDay).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TenantRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.ThirtyDay).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Unbilled).HasColumnType("decimal(12, 2)");

            entity.HasOne(d => d.Category).WithMany(p => p.Customers).HasForeignKey(d => d.CategoryId);

            entity.HasOne(d => d.Currency).WithMany(p => p.Customers).HasForeignKey(d => d.CurrencyId);

            entity.HasOne(d => d.CustomerLabCode).WithMany(p => p.Customers).HasForeignKey(d => d.CustomerLabCodeId);

            entity.HasOne(d => d.CustomerRationCode).WithMany(p => p.Customers).HasForeignKey(d => d.CustomerRationCodeId);

            entity.HasOne(d => d.CustomerResultDeliveryCode).WithMany(p => p.Customers).HasForeignKey(d => d.CustomerResultDeliveryCodeId);

            entity.HasOne(d => d.Division).WithMany(p => p.Customers).HasForeignKey(d => d.DivisionId);

            entity.HasOne(d => d.Landlord).WithMany(p => p.InverseLandlord).HasForeignKey(d => d.LandlordId);

            entity.HasOne(d => d.Location).WithMany(p => p.Customers).HasForeignKey(d => d.LocationId);

            entity.HasOne(d => d.NstruckDrop).WithMany(p => p.Customers).HasForeignKey(d => d.NstruckDropId);

            entity.HasOne(d => d.Nstruck).WithMany(p => p.Customers).HasForeignKey(d => d.NstruckId);

            entity.HasOne(d => d.PaymentTerm).WithMany(p => p.Customers).HasForeignKey(d => d.PaymentTermId);

            entity.HasOne(d => d.PriceLevel).WithMany(p => p.Customers).HasForeignKey(d => d.PriceLevelId);

            entity.HasOne(d => d.Region).WithMany(p => p.Customers).HasForeignKey(d => d.RegionId);

            entity.HasOne(d => d.Salesperson).WithMany(p => p.Customers).HasForeignKey(d => d.SalespersonId);

            entity.HasOne(d => d.Subsidiary).WithMany(p => p.Customers).HasForeignKey(d => d.SubsidiaryId);

            entity.HasOne(d => d.TruckDrop).WithMany(p => p.Customers).HasForeignKey(d => d.TruckDropId);

            entity.HasOne(d => d.Truck).WithMany(p => p.Customers).HasForeignKey(d => d.TruckId);
        });

        modelBuilder.Entity<CustomerAddress>(entity =>
        {
            entity.HasIndex(e => e.CountryId, "IX_CustomerAddresses_CountryId");

            entity.HasIndex(e => e.CustomerId, "IX_CustomerAddresses_CustomerId");

            entity.HasIndex(e => e.StateId, "IX_CustomerAddresses_StateId");

            entity.HasOne(d => d.Country).WithMany(p => p.CustomerAddresses).HasForeignKey(d => d.CountryId);

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerAddresses).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.State).WithMany(p => p.CustomerAddresses).HasForeignKey(d => d.StateId);
        });

        modelBuilder.Entity<CustomerContact>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_CustomerContacts_CustomerId");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerContacts).HasForeignKey(d => d.CustomerId);
        });

        modelBuilder.Entity<CustomerLicense>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_CustomerLicenses_CustomerId");

            entity.HasIndex(e => e.LicenseTypeId, "IX_CustomerLicenses_LicenseTypeId");

            entity.Property(e => e.ExpirationDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.IssueDate).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerLicenses).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.LicenseType).WithMany(p => p.CustomerLicenses).HasForeignKey(d => d.LicenseTypeId);
        });

        modelBuilder.Entity<CustomerSalesperson>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK__Customer__3214EC07E1EF40BF");

            entity.HasIndex(e => e.CustomerId, "IX_CustomerSalespeople_CustomerId");

            entity.HasIndex(e => e.SalespersonId, "IX_CustomerSalespeople_SalespersonId");

            entity.Property(e => e.CommissionPercent).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.SalesPercent).HasColumnType("decimal(12, 2)");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerSalespeople)
                .HasForeignKey(d => d.CustomerId)
                .OnDelete(DeleteBehavior.ClientSetNull);

            entity.HasOne(d => d.Salesperson).WithMany(p => p.CustomerSalespeople)
                .HasForeignKey(d => d.SalespersonId)
                .OnDelete(DeleteBehavior.ClientSetNull);
        });

        modelBuilder.Entity<CustomerServiceCenter>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_CustomerServiceCenters_CustomerId");

            entity.HasIndex(e => e.ServiceCenterId, "IX_CustomerServiceCenters_ServiceCenterId");

            entity.HasOne(d => d.Customer).WithMany(p => p.CustomerServiceCenters).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.ServiceCenter).WithMany(p => p.CustomerServiceCenters).HasForeignKey(d => d.ServiceCenterId);
        });

        modelBuilder.Entity<DepartmentManager>(entity =>
        {
            entity.HasIndex(e => e.DepartmentId, "IX_DepartmentManagers_DepartmentId");

            entity.HasIndex(e => e.EmployeeNumber, "IX_DepartmentManagers_EmployeeNumber");

            entity.HasOne(d => d.Department).WithMany(p => p.DepartmentManagers).HasForeignKey(d => d.DepartmentId);

            entity.HasOne(d => d.EmployeeNumberNavigation).WithMany(p => p.DepartmentManagers).HasForeignKey(d => d.EmployeeNumber);
        });

        modelBuilder.Entity<Distribution>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_Distributions_CustomerId");

            entity.HasIndex(e => e.ReportId, "IX_Distributions_ReportId");

            entity.HasOne(d => d.Customer).WithMany(p => p.Distributions).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.Report).WithMany(p => p.Distributions).HasForeignKey(d => d.ReportId);
        });

        modelBuilder.Entity<DistributionTemp>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_DistributionTemps_CustomerId");

            entity.HasIndex(e => e.ReportId, "IX_DistributionTemps_ReportId");

            entity.HasOne(d => d.Customer).WithMany(p => p.DistributionTemps).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.Report).WithMany(p => p.DistributionTemps).HasForeignKey(d => d.ReportId);
        });

        modelBuilder.Entity<Division>(entity =>
        {
            entity.HasIndex(e => new { e.DisplayName, e.Id }, "IX_Divisions_DisplayName_Id");
        });

        modelBuilder.Entity<EmailLog>(entity =>
        {
            entity.Property(e => e.SentDateTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
        });

        modelBuilder.Entity<EmailLogAttachment>(entity =>
        {
            entity.HasIndex(e => e.EmailLogId, "IX_EmailLogAttachments_EmailLogId");

            entity.HasOne(d => d.EmailLog).WithMany(p => p.EmailLogAttachments).HasForeignKey(d => d.EmailLogId);
        });

        modelBuilder.Entity<EmailLogRecipient>(entity =>
        {
            entity.HasIndex(e => e.EmailLogId, "IX_EmailLogRecipients_EmailLogId");

            entity.HasOne(d => d.EmailLog).WithMany(p => p.EmailLogRecipients).HasForeignKey(d => d.EmailLogId);
        });

        modelBuilder.Entity<EmailRecipient>(entity =>
        {
            entity.HasIndex(e => e.EmailId, "IX_EmailRecipients_EmailId");

            entity.HasOne(d => d.Email).WithMany(p => p.EmailRecipients).HasForeignKey(d => d.EmailId);
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasIndex(e => e.DepartmentId, "IX_Employees_DepartmentId");

            entity.HasIndex(e => e.GenderId, "IX_Employees_GenderId");

            entity.HasIndex(e => e.MaritalStatusId, "IX_Employees_MaritalStatusId");

            entity.HasIndex(e => e.StatusId, "IX_Employees_StatusId");

            entity.HasIndex(e => e.SubsidiaryId, "IX_Employees_SubsidiaryId");

            entity.HasIndex(e => e.TypeId, "IX_Employees_TypeId");

            entity.HasIndex(e => e.UserId, "IX_Employees_UserId");

            entity.HasOne(d => d.Department).WithMany(p => p.Employees).HasForeignKey(d => d.DepartmentId);

            entity.HasOne(d => d.Gender).WithMany(p => p.Employees).HasForeignKey(d => d.GenderId);

            entity.HasOne(d => d.MaritalStatus).WithMany(p => p.Employees).HasForeignKey(d => d.MaritalStatusId);

            entity.HasOne(d => d.Status).WithMany(p => p.Employees).HasForeignKey(d => d.StatusId);

            entity.HasOne(d => d.Subsidiary).WithMany(p => p.Employees).HasForeignKey(d => d.SubsidiaryId);

            entity.HasOne(d => d.Type).WithMany(p => p.Employees).HasForeignKey(d => d.TypeId);

            entity.HasOne(d => d.User).WithMany(p => p.Employees).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<EmployeeAddress>(entity =>
        {
            entity.HasIndex(e => e.CountryId, "IX_EmployeeAddresses_CountryId");

            entity.HasIndex(e => e.EmployeeId, "IX_EmployeeAddresses_EmployeeId");

            entity.HasIndex(e => e.StateId, "IX_EmployeeAddresses_StateId");

            entity.HasOne(d => d.Country).WithMany(p => p.EmployeeAddresses).HasForeignKey(d => d.CountryId);

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeAddresses).HasForeignKey(d => d.EmployeeId);

            entity.HasOne(d => d.State).WithMany(p => p.EmployeeAddresses).HasForeignKey(d => d.StateId);
        });

        modelBuilder.Entity<EmployeeContact>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId, "IX_EmployeeContacts_EmployeeId");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeContacts).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<EmployeeDepartment>(entity =>
        {
            entity.HasIndex(e => e.DepartmentId, "IX_EmployeeDepartments_DepartmentId");

            entity.HasIndex(e => e.EmployeeId, "IX_EmployeeDepartments_EmployeeId");

            entity.HasOne(d => d.Department).WithMany(p => p.EmployeeDepartments).HasForeignKey(d => d.DepartmentId);

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeDepartments).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<EmployeeJobTitle>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId, "IX_EmployeeJobTitles_EmployeeId");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeJobTitles).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<EmployeeSavingsAccount>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId, "IX_EmployeeSavingsAccounts_EmployeeId");

            entity.HasIndex(e => e.StatusId, "IX_EmployeeSavingsAccounts_StatusId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Balance).HasColumnType("decimal(20, 2)");
            entity.Property(e => e.Deduction).HasColumnType("decimal(20, 2)");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeSavingsAccounts).HasForeignKey(d => d.EmployeeId);

            entity.HasOne(d => d.Status).WithMany(p => p.EmployeeSavingsAccounts).HasForeignKey(d => d.StatusId);
        });

        modelBuilder.Entity<EmployeeSavingsAccountRate>(entity =>
        {
            entity.Property(e => e.Rate).HasColumnType("decimal(10, 4)");
        });

        modelBuilder.Entity<EmployeeSavingsTransaction>(entity =>
        {
            entity.HasIndex(e => e.AccountId, "IX_EmployeeSavingsTransactions_AccountId");

            entity.HasIndex(e => e.TypeId, "IX_EmployeeSavingsTransactions_TypeId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.Amount).HasColumnType("decimal(20, 2)");
            entity.Property(e => e.Balance).HasColumnType("decimal(20, 2)");

            entity.HasOne(d => d.Account).WithMany(p => p.EmployeeSavingsTransactions).HasForeignKey(d => d.AccountId);

            entity.HasOne(d => d.Type).WithMany(p => p.EmployeeSavingsTransactions).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<EmployeeSavingsTransactionMemo>(entity =>
        {
            entity.HasIndex(e => e.TransactionId, "IX_EmployeeSavingsTransactionMemos_TransactionId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Transaction).WithMany(p => p.EmployeeSavingsTransactionMemos).HasForeignKey(d => d.TransactionId);
        });

        modelBuilder.Entity<EmployeeTerm>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId, "IX_EmployeeTerms_EmployeeId");

            entity.HasIndex(e => e.EmployeeTermEndTypeId, "IX_EmployeeTerms_EmployeeTermEndTypeId");

            entity.HasIndex(e => e.EmployeeTermTypeId, "IX_EmployeeTerms_EmployeeTermTypeId");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeTerms).HasForeignKey(d => d.EmployeeId);

            entity.HasOne(d => d.EmployeeTermEndType).WithMany(p => p.EmployeeTerms).HasForeignKey(d => d.EmployeeTermEndTypeId);

            entity.HasOne(d => d.EmployeeTermType).WithMany(p => p.EmployeeTerms).HasForeignKey(d => d.EmployeeTermTypeId);
        });

        modelBuilder.Entity<EmployeeTimeEntry>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId, "IX_EmployeeTimeEntries_EmployeeId");

            entity.Property(e => e.Id).ValueGeneratedNever();
            entity.Property(e => e.TimeWorked).HasColumnType("decimal(24, 2)");

            entity.HasOne(d => d.Employee).WithMany(p => p.EmployeeTimeEntries).HasForeignKey(d => d.EmployeeId);
        });

        modelBuilder.Entity<EmployeesImport>(entity =>
        {
            entity.ToTable("EmployeesImport");
        });

        modelBuilder.Entity<ExportCreditMemo>(entity =>
        {
            entity.Property(e => e.Gbprate).HasColumnName("GBPRate");
        });

        modelBuilder.Entity<ExportCreditMemoCommission>(entity =>
        {
            entity.Property(e => e.Split1CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split1PresidentsClubRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split2CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split2PresidentsClubRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split3CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split3PresidentsClubRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split4CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split4PresidentsClubRate).HasColumnType("decimal(12, 2)");
        });

        modelBuilder.Entity<ExportCustomer>(entity =>
        {
            entity.Property(e => e.Balance).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Current).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Deposit).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.NinetyDay).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.OverNinety).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Overdue).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Robotic)
                .IsRequired();
                //.HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.SixtyDay).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split1CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split1PresidentsClubRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split2CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split2PresidentsClubRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split3CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split3PresidentsClubRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split4CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split4PresidentsClubRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.TenantRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.ThirtyDay).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Unbilled).HasColumnType("decimal(12, 2)");
        });

        modelBuilder.Entity<ExportInvoice>(entity =>
        {
            entity.Property(e => e.Gbprate).HasColumnName("GBPRate");
        });

        modelBuilder.Entity<ExportInvoiceCommission>(entity =>
        {
            entity.Property(e => e.Split1CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split1PresidentsClubRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split2CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split2PresidentsClubRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split3CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split3PresidentsClubRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split4CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split4PresidentsClubRate).HasColumnType("decimal(12, 2)");
        });

        modelBuilder.Entity<ExportMillAllocation>(entity =>
        {
            entity.Property(e => e.Gbprate).HasColumnName("GBPRate");
        });

        modelBuilder.Entity<ExportMillAllocationCommission>(entity =>
        {
            entity.Property(e => e.Split1CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split1PresidentsClubRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split2CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split2PresidentsClubRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split3CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split3PresidentsClubRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split4CommissionRate).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.Split4PresidentsClubRate).HasColumnType("decimal(12, 2)");
        });

        modelBuilder.Entity<ExportSampleDetail>(entity =>
        {
            entity.Property(e => e.AsAnalyzedValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.FinalValue).HasColumnType("decimal(24, 8)");
        });

        modelBuilder.Entity<FileUpload>(entity =>
        {
            entity.HasIndex(e => e.FileUploadTypeId, "IX_FileUploads_FileUploadTypeId");

            entity.HasOne(d => d.FileUploadType).WithMany(p => p.FileUploads).HasForeignKey(d => d.FileUploadTypeId);
        });

        modelBuilder.Entity<ImportTaskLog>(entity =>
        {
            entity.HasIndex(e => e.ImportTaskId, "IX_ImportTaskLogs_ImportTaskId");

            entity.HasOne(d => d.ImportTask).WithMany(p => p.ImportTaskLogs).HasForeignKey(d => d.ImportTaskId);
        });

        modelBuilder.Entity<Invoice>(entity =>
        {
            entity.HasIndex(e => e.CurrencyId, "IX_Invoices_CurrencyId");

            entity.HasIndex(e => e.CustomerId, "IX_Invoices_CustomerId");

            entity.HasIndex(e => e.SalesOrderId, "IX_Invoices_SalesOrderId");

            entity.HasOne(d => d.Currency).WithMany(p => p.Invoices).HasForeignKey(d => d.CurrencyId);

            entity.HasOne(d => d.Customer).WithMany(p => p.Invoices).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.Invoices).HasForeignKey(d => d.SalesOrderId);
        });

        modelBuilder.Entity<InvoiceDetail>(entity =>
        {
            entity.HasIndex(e => e.InvoiceId, "IX_InvoiceDetails_InvoiceId");

            entity.HasIndex(e => e.ItemId, "IX_InvoiceDetails_ItemId");

            entity.HasIndex(e => e.UnitId, "IX_InvoiceDetails_UnitId");

            entity.Property(e => e.GrossAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.ItemDollarPrice).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.ItemPrice).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.TaxAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.TaxRate).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.UnitPrice).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.Invoice).WithMany(p => p.InvoiceDetails).HasForeignKey(d => d.InvoiceId);

            entity.HasOne(d => d.Item).WithMany(p => p.InvoiceDetails).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Unit).WithMany(p => p.InvoiceDetails).HasForeignKey(d => d.UnitId);
        });

        modelBuilder.Entity<Item>(entity =>
        {
            entity.HasIndex(e => e.BaseUnitId, "IX_Items_BaseUnitId");

            entity.HasIndex(e => new { e.Inactive, e.Orderable, e.AppOrderable, e.Id }, "IX_Items_Inactive_Orderable_AppOrderable_Id");

            entity.HasIndex(e => new { e.Name, e.Id }, "IX_Items_Name_Id");

            entity.HasIndex(e => new { e.NetSuiteId, e.Id }, "IX_Items_NetSuiteId_Id");

            entity.HasIndex(e => new { e.NetSuiteType, e.Id }, "IX_Items_NetSuiteType_Id");

            entity.HasIndex(e => e.PurchaseUnitId, "IX_Items_PurchaseUnitId");

            entity.HasIndex(e => e.SaleUnitId, "IX_Items_SaleUnitId");

            entity.HasIndex(e => e.StockUnitId, "IX_Items_StockUnitId");

            entity.HasIndex(e => e.UnitTypeId, "IX_Items_UnitTypeId");

            entity.Property(e => e.DealerDiscountRate).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.ItemWeight).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.PremixCommissionRate).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.WaterSoluble)
                .IsRequired();
                //.HasDefaultValueSql("(CONVERT([bit],(0)))");

            entity.HasOne(d => d.BaseUnit).WithMany(p => p.ItemBaseUnits).HasForeignKey(d => d.BaseUnitId);

            entity.HasOne(d => d.PurchaseUnit).WithMany(p => p.ItemPurchaseUnits).HasForeignKey(d => d.PurchaseUnitId);

            entity.HasOne(d => d.SaleUnit).WithMany(p => p.ItemSaleUnits).HasForeignKey(d => d.SaleUnitId);

            entity.HasOne(d => d.StockUnit).WithMany(p => p.ItemStockUnits).HasForeignKey(d => d.StockUnitId);
        });

        modelBuilder.Entity<ItemFormulaRevision>(entity =>
        {
            entity.HasIndex(e => e.ItemFormulaId, "IX_ItemFormulaRevisions_ItemFormulaId");

            entity.HasOne(d => d.ItemFormula).WithMany(p => p.ItemFormulaRevisions).HasForeignKey(d => d.ItemFormulaId);
        });

        modelBuilder.Entity<ItemFormulaRevisionComponent>(entity =>
        {
            entity.HasIndex(e => e.ItemFormulaRevisionId, "IX_ItemFormulaRevisionComponents_ItemFormulaRevisionId");

            entity.HasIndex(e => e.ItemId, "IX_ItemFormulaRevisionComponents_ItemId");

            entity.Property(e => e.Bomquantity)
                .HasColumnType("decimal(16, 8)")
                .HasColumnName("BOMQuantity");
            entity.Property(e => e.ComponentYield).HasColumnType("decimal(16, 4)");
            entity.Property(e => e.Quantity).HasColumnType("decimal(16, 8)");

            entity.HasOne(d => d.ItemFormulaRevision).WithMany(p => p.ItemFormulaRevisionComponents).HasForeignKey(d => d.ItemFormulaRevisionId);
        });

        modelBuilder.Entity<ItemFulfillment>(entity =>
        {
            entity.HasIndex(e => e.NstruckDropId, "IX_ItemFulfillments_NSTruckDropId");

            entity.HasIndex(e => e.NstruckId, "IX_ItemFulfillments_NSTruckId");

            entity.HasIndex(e => e.SalesOrderId, "IX_ItemFulfillments_SalesOrderId");

            entity.HasIndex(e => e.SalespersonId, "IX_ItemFulfillments_SalespersonId");

            entity.HasIndex(e => e.TruckDropId, "IX_ItemFulfillments_TruckDropId");

            entity.HasIndex(e => e.TruckId, "IX_ItemFulfillments_TruckId");

            entity.Property(e => e.NstruckDropId).HasColumnName("NSTruckDropId");
            entity.Property(e => e.NstruckId).HasColumnName("NSTruckId");

            entity.HasOne(d => d.NstruckDrop).WithMany(p => p.ItemFulfillments).HasForeignKey(d => d.NstruckDropId);

            entity.HasOne(d => d.Nstruck).WithMany(p => p.ItemFulfillments).HasForeignKey(d => d.NstruckId);

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.ItemFulfillments).HasForeignKey(d => d.SalesOrderId);

            entity.HasOne(d => d.Salesperson).WithMany(p => p.ItemFulfillments).HasForeignKey(d => d.SalespersonId);

            entity.HasOne(d => d.TruckDrop).WithMany(p => p.ItemFulfillments).HasForeignKey(d => d.TruckDropId);

            entity.HasOne(d => d.Truck).WithMany(p => p.ItemFulfillments).HasForeignKey(d => d.TruckId);
        });

        modelBuilder.Entity<ItemFulfillmentDetail>(entity =>
        {
            entity.HasIndex(e => e.ItemFulfillmentId, "IX_ItemFulfillmentDetails_ItemFulfillmentId");

            entity.HasIndex(e => e.ItemId, "IX_ItemFulfillmentDetails_ItemId");

            entity.HasIndex(e => e.NstruckDropId, "IX_ItemFulfillmentDetails_NSTruckDropId");

            entity.HasIndex(e => e.NstruckId, "IX_ItemFulfillmentDetails_NSTruckId");

            entity.HasIndex(e => e.SalespersonId, "IX_ItemFulfillmentDetails_SalespersonId");

            entity.HasIndex(e => e.TruckDropId, "IX_ItemFulfillmentDetails_TruckDropId");

            entity.HasIndex(e => e.TruckId, "IX_ItemFulfillmentDetails_TruckId");

            entity.HasIndex(e => e.UnitId, "IX_ItemFulfillmentDetails_UnitId");

            entity.HasIndex(e => e.UnitTypeId, "IX_ItemFulfillmentDetails_UnitTypeId");

            entity.Property(e => e.NstruckDropId).HasColumnName("NSTruckDropId");
            entity.Property(e => e.NstruckId).HasColumnName("NSTruckId");

            entity.HasOne(d => d.ItemFulfillment).WithMany(p => p.ItemFulfillmentDetails).HasForeignKey(d => d.ItemFulfillmentId);

            entity.HasOne(d => d.Item).WithMany(p => p.ItemFulfillmentDetails).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.NstruckDrop).WithMany(p => p.ItemFulfillmentDetails).HasForeignKey(d => d.NstruckDropId);

            entity.HasOne(d => d.Nstruck).WithMany(p => p.ItemFulfillmentDetails).HasForeignKey(d => d.NstruckId);

            entity.HasOne(d => d.Salesperson).WithMany(p => p.ItemFulfillmentDetails).HasForeignKey(d => d.SalespersonId);

            entity.HasOne(d => d.TruckDrop).WithMany(p => p.ItemFulfillmentDetails).HasForeignKey(d => d.TruckDropId);

            entity.HasOne(d => d.Truck).WithMany(p => p.ItemFulfillmentDetails).HasForeignKey(d => d.TruckId);

            entity.HasOne(d => d.Unit).WithMany(p => p.ItemFulfillmentDetails).HasForeignKey(d => d.UnitId);

            entity.HasOne(d => d.UnitType).WithMany(p => p.ItemFulfillmentDetails).HasForeignKey(d => d.UnitTypeId);
        });

        modelBuilder.Entity<ItemPrice>(entity =>
        {
            entity.HasIndex(e => e.CurrencyId, "IX_ItemPrices_CurrencyId");

            entity.HasIndex(e => e.ItemId, "IX_ItemPrices_ItemId");

            entity.HasIndex(e => e.PriceLevelId, "IX_ItemPrices_PriceLevelId");

            entity.Property(e => e.Price).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.Currency).WithMany(p => p.ItemPrices).HasForeignKey(d => d.CurrencyId);

            entity.HasOne(d => d.Item).WithMany(p => p.ItemPrices).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.PriceLevel).WithMany(p => p.ItemPrices).HasForeignKey(d => d.PriceLevelId);
        });

        modelBuilder.Entity<ItemPricePeriod>(entity =>
        {
            entity.HasIndex(e => e.ItemId, "IX_ItemPricePeriods_ItemId");

            entity.HasIndex(e => e.PriceLevelId, "IX_ItemPricePeriods_PriceLevelId");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemPricePeriods).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.PriceLevel).WithMany(p => p.ItemPricePeriods).HasForeignKey(d => d.PriceLevelId);
        });

        modelBuilder.Entity<ItemVolumePrice>(entity =>
        {
            entity.HasIndex(e => e.ItemId, "IX_ItemVolumePrices_ItemId");

            entity.HasIndex(e => e.ItemPricePeriodId, "IX_ItemVolumePrices_ItemPricePeriodId");

            entity.Property(e => e.MaximumQuantity).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.MinimumQuantity).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.Price).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.Item).WithMany(p => p.ItemVolumePrices).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.ItemPricePeriod).WithMany(p => p.ItemVolumePrices).HasForeignKey(d => d.ItemPricePeriodId);
        });

        modelBuilder.Entity<LabContainer>(entity =>
        {
            entity.HasKey(e => new { e.LabContainerTypeId, e.Number });

            entity.Property(e => e.Weight).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.LabContainerType).WithMany(p => p.LabContainers).HasForeignKey(d => d.LabContainerTypeId);
        });

        modelBuilder.Entity<LabPackage>(entity =>
        {
            entity.Property(e => e.Cost).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.Price).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.ReportOnly)
                .IsRequired();
                //.HasDefaultValueSql("(CONVERT([bit],(0)))");
        });

        modelBuilder.Entity<LabPackageAnalysis>(entity =>
        {
            entity.HasKey(e => new { e.LabPackageId, e.AnalysisTypeId });

            entity.HasIndex(e => e.AnalysisTypeId, "IX_LabPackageAnalyses_AnalysisTypeId");

            entity.HasIndex(e => e.ProcessTypeId, "IX_LabPackageAnalyses_ProcessTypeId");

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.LabPackageAnalyses).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.LabPackage).WithMany(p => p.LabPackageAnalyses).HasForeignKey(d => d.LabPackageId);

            entity.HasOne(d => d.ProcessType).WithMany(p => p.LabPackageAnalyses).HasForeignKey(d => d.ProcessTypeId);
        });

        modelBuilder.Entity<LabSlopeIntercept>(entity =>
        {
            entity.HasIndex(e => e.AnalysisTypeId, "IX_LabSlopeIntercepts_AnalysisTypeId");

            entity.HasIndex(e => e.SampleTypeId, "IX_LabSlopeIntercepts_SampleTypeId");

            entity.Property(e => e.Intercept).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.Slope).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.LabSlopeIntercepts).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.SampleType).WithMany(p => p.LabSlopeIntercepts).HasForeignKey(d => d.SampleTypeId);
        });

        modelBuilder.Entity<LabSpecialAnalysisRequest>(entity =>
        {
            entity.HasIndex(e => e.SampleId, "IX_LabSpecialAnalysisRequests_SampleId");

            entity.HasIndex(e => e.SampleRequestId, "IX_LabSpecialAnalysisRequests_SampleRequestId");

            entity.HasIndex(e => e.UserId, "IX_LabSpecialAnalysisRequests_UserId");

            //entity.Property(e => e.CustomerId).HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.User).WithMany(p => p.LabSpecialAnalysisRequests).HasForeignKey(d => d.UserId);

            entity.HasMany(d => d.SampleTypes).WithMany(p => p.LabSpecialAnalysisRequests)
                .UsingEntity<Dictionary<string, object>>(
                    "LabSpecialAnalysisRequestSampleType",
                    r => r.HasOne<SampleType>().WithMany().HasForeignKey("SampleTypeId"),
                    l => l.HasOne<LabSpecialAnalysisRequest>().WithMany().HasForeignKey("LabSpecialAnalysisRequestId"),
                    j =>
                    {
                        j.HasKey("LabSpecialAnalysisRequestId", "SampleTypeId");
                        j.ToTable("LabSpecialAnalysisRequestSampleTypes");
                        j.HasIndex(new[] { "SampleTypeId" }, "IX_LabSpecialAnalysisRequestSampleTypes_SampleTypeId");
                    });
        });

        modelBuilder.Entity<LabSpecialAnalysisRequestAnalysis>(entity =>
        {
            entity.HasKey(e => new { e.LabSpecialAnalysisRequestId, e.AnalysisTypeId });

            entity.HasIndex(e => e.AnalysisTypeId, "IX_LabSpecialAnalysisRequestAnalyses_AnalysisTypeId");

            entity.HasIndex(e => e.ProcessTypeId, "IX_LabSpecialAnalysisRequestAnalyses_ProcessTypeId");

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.LabSpecialAnalysisRequestAnalyses).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.LabSpecialAnalysisRequest).WithMany(p => p.LabSpecialAnalysisRequestAnalyses).HasForeignKey(d => d.LabSpecialAnalysisRequestId);

            entity.HasOne(d => d.ProcessType).WithMany(p => p.LabSpecialAnalysisRequestAnalyses).HasForeignKey(d => d.ProcessTypeId);
        });

        modelBuilder.Entity<LabSpecialAnalysisRequestSample>(entity =>
        {
            entity.HasKey(e => new { e.LabSpecialAnalysisRequestId, e.SampleId });

            entity.HasIndex(e => e.SampleId, "IX_LabSpecialAnalysisRequestSamples_SampleId");

            entity.HasOne(d => d.LabSpecialAnalysisRequest).WithMany(p => p.LabSpecialAnalysisRequestSamples).HasForeignKey(d => d.LabSpecialAnalysisRequestId);

            entity.HasOne(d => d.Sample).WithMany(p => p.LabSpecialAnalysisRequestSamples).HasForeignKey(d => d.SampleId);
        });

        modelBuilder.Entity<LabXrayCorrection>(entity =>
        {
            entity.ToTable("LabXRayCorrections");

            entity.HasIndex(e => e.AnalysisTypeId, "IX_LabXRayCorrections_AnalysisTypeId");

            entity.HasIndex(e => e.CorrectionAnalysisTypeId, "IX_LabXRayCorrections_CorrectionAnalysisTypeId");

            entity.HasIndex(e => e.SampleTypeId, "IX_LabXRayCorrections_SampleTypeId");

            entity.Property(e => e.CorrectionFactor).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.LabXrayCorrectionAnalysisTypes).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.CorrectionAnalysisType).WithMany(p => p.LabXrayCorrectionCorrectionAnalysisTypes).HasForeignKey(d => d.CorrectionAnalysisTypeId);

            entity.HasOne(d => d.SampleType).WithMany(p => p.LabXrayCorrections).HasForeignKey(d => d.SampleTypeId);
        });

        modelBuilder.Entity<AgriKingApp.Models.Location>(entity =>
        {
            entity.HasIndex(e => e.NstruckDropId, "IX_Locations_NSTruckDropId");

            entity.HasIndex(e => e.NstruckId, "IX_Locations_NSTruckId");

            entity.HasIndex(e => e.SubsidiaryId, "IX_Locations_SubsidiaryId");

            entity.HasIndex(e => e.TruckDropId, "IX_Locations_TruckDropId");

            entity.HasIndex(e => e.TruckId, "IX_Locations_TruckId");

            entity.Property(e => e.NstruckDropId).HasColumnName("NSTruckDropId");
            entity.Property(e => e.NstruckId).HasColumnName("NSTruckId");

            entity.HasOne(d => d.NstruckDrop).WithMany(p => p.Locations).HasForeignKey(d => d.NstruckDropId);

            entity.HasOne(d => d.Nstruck).WithMany(p => p.Locations).HasForeignKey(d => d.NstruckId);

            entity.HasOne(d => d.Subsidiary).WithMany(p => p.Locations).HasForeignKey(d => d.SubsidiaryId);

            entity.HasOne(d => d.TruckDrop).WithMany(p => p.Locations).HasForeignKey(d => d.TruckDropId);

            entity.HasOne(d => d.Truck).WithMany(p => p.Locations).HasForeignKey(d => d.TruckId);
        });

        modelBuilder.Entity<AgriKingApp.Models.MenuItem>(entity =>
        {
            entity.HasIndex(e => e.IconId, "IX_MenuItems_IconId");

            entity.HasIndex(e => e.ParentId, "IX_MenuItems_ParentId");

            entity.HasIndex(e => e.TargetId, "IX_MenuItems_TargetId");

            entity.HasOne(d => d.Icon).WithMany(p => p.MenuItems).HasForeignKey(d => d.IconId);

            entity.HasOne(d => d.Parent).WithMany(p => p.InverseParent).HasForeignKey(d => d.ParentId);

            entity.HasOne(d => d.Target).WithMany(p => p.MenuItems).HasForeignKey(d => d.TargetId);
        });

        modelBuilder.Entity<MenuItemUserGroup>(entity =>
        {
            entity.HasKey(e => new { e.MenuItemId, e.UserGroupId });

            entity.HasIndex(e => e.UserGroupId, "IX_MenuItemUserGroups_UserGroupId");

            entity.HasOne(d => d.MenuItem).WithMany(p => p.MenuItemUserGroups).HasForeignKey(d => d.MenuItemId);

            entity.HasOne(d => d.UserGroup).WithMany(p => p.MenuItemUserGroups).HasForeignKey(d => d.UserGroupId);
        });

        modelBuilder.Entity<MillAllocation>(entity =>
        {
            entity.HasIndex(e => e.CurrencyId, "IX_MillAllocations_CurrencyId");

            entity.HasIndex(e => e.MillId, "IX_MillAllocations_MillId");

            entity.HasIndex(e => e.PriceLevelId, "IX_MillAllocations_PriceLevelId");

            entity.HasOne(d => d.Currency).WithMany(p => p.MillAllocations).HasForeignKey(d => d.CurrencyId);

            entity.HasOne(d => d.Mill).WithMany(p => p.MillAllocations).HasForeignKey(d => d.MillId);

            entity.HasOne(d => d.PriceLevel).WithMany(p => p.MillAllocations).HasForeignKey(d => d.PriceLevelId);
        });

        modelBuilder.Entity<MillAllocationAssociation>(entity =>
        {
            entity.HasIndex(e => e.MillAllocationTypeId, "IX_MillAllocationAssociations_MillAllocationTypeId");

            entity.HasOne(d => d.MillAllocationType).WithMany(p => p.MillAllocationAssociations).HasForeignKey(d => d.MillAllocationTypeId);
        });

        modelBuilder.Entity<MillAllocationDetail>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_MillAllocationDetails_CustomerId");

            entity.HasIndex(e => e.Maid, "IX_MillAllocationDetails_MAId");

            entity.Property(e => e.Maid).HasColumnName("MAId");

            entity.HasOne(d => d.Customer).WithMany(p => p.MillAllocationDetails).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.Ma).WithMany(p => p.MillAllocationDetails).HasForeignKey(d => d.Maid);
        });

        modelBuilder.Entity<MillAllocationDetailItem>(entity =>
        {
            entity.HasIndex(e => e.ItemId, "IX_MillAllocationDetailItems_ItemId");

            entity.HasIndex(e => e.MadetailId, "IX_MillAllocationDetailItems_MADetailId");

            entity.HasIndex(e => e.PriceLevelId, "IX_MillAllocationDetailItems_PriceLevelId");

            entity.HasIndex(e => e.UnitId, "IX_MillAllocationDetailItems_UnitId");

            entity.HasIndex(e => e.UnitTypeId, "IX_MillAllocationDetailItems_UnitTypeId");

            entity.Property(e => e.MadetailId).HasColumnName("MADetailId");
            entity.Property(e => e.Quantity).HasColumnType("decimal(18, 2)");

            entity.HasOne(d => d.Item).WithMany(p => p.MillAllocationDetailItems).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Madetail).WithMany(p => p.MillAllocationDetailItems).HasForeignKey(d => d.MadetailId);

            entity.HasOne(d => d.PriceLevel).WithMany(p => p.MillAllocationDetailItems).HasForeignKey(d => d.PriceLevelId);

            entity.HasOne(d => d.Unit).WithMany(p => p.MillAllocationDetailItems).HasForeignKey(d => d.UnitId);

            entity.HasOne(d => d.UnitType).WithMany(p => p.MillAllocationDetailItems).HasForeignKey(d => d.UnitTypeId);
        });

        modelBuilder.Entity<Note>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_Notes_UserId");

            entity.Property(e => e.NoteDateTime).HasDefaultValueSql("('0001-01-01T00:00:00.0000000')");
            entity.Property(e => e.NoteText)
                .HasMaxLength(8000)
                .IsUnicode(false);

            entity.HasOne(d => d.User).WithMany(p => p.Notes).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<Nstruck>(entity =>
        {
            entity.ToTable("NSTrucks");
        });

        modelBuilder.Entity<NstruckDrop>(entity =>
        {
            entity.ToTable("NSTruckDrops");

            entity.HasIndex(e => e.TruckId, "IX_NSTruckDrops_TruckId");

            entity.HasOne(d => d.Truck).WithMany(p => p.NstruckDrops).HasForeignKey(d => d.TruckId);
        });

        modelBuilder.Entity<Payment>(entity =>
        {
            entity.HasIndex(e => e.CurrencyId, "IX_Payments_CurrencyId");

            entity.HasIndex(e => e.CustomerId, "IX_Payments_CustomerId");

            entity.HasIndex(e => e.SubsidiaryId, "IX_Payments_SubsidiaryId");

            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.Currency).WithMany(p => p.Payments).HasForeignKey(d => d.CurrencyId);

            entity.HasOne(d => d.Customer).WithMany(p => p.Payments).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.Subsidiary).WithMany(p => p.Payments).HasForeignKey(d => d.SubsidiaryId);
        });

        modelBuilder.Entity<PaymentInvoice>(entity =>
        {
            entity.HasIndex(e => e.InvoiceId, "IX_PaymentInvoices_InvoiceId");

            entity.HasIndex(e => e.PaymentId, "IX_PaymentInvoices_PaymentId");

            entity.Property(e => e.DiscountAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.PaymentAmount).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.RemainingBalance).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.TotalAmount).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.Invoice).WithMany(p => p.PaymentInvoices).HasForeignKey(d => d.InvoiceId);

            entity.HasOne(d => d.Payment).WithMany(p => p.PaymentInvoices).HasForeignKey(d => d.PaymentId);
        });

        modelBuilder.Entity<Ration>(entity =>
        {
            entity.HasKey(e => e.Id).HasName("PK_Ration");

            entity.HasIndex(e => new { e.AnimalTypeId, e.AnimalBreedId }, "IX_Rations_AnimalTypeId_AnimalBreedId");

            entity.HasIndex(e => e.RationCategoryId, "IX_Rations_RationCategoryId");

            entity.HasIndex(e => e.RationTypeId, "IX_Rations_RationTypeId");

            entity.Property(e => e.AnimalBreedAnimalTypeId).HasMaxLength(450);
            entity.Property(e => e.AnimalBreedId1).HasMaxLength(450);
            entity.Property(e => e.AnimalProduction).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.AnimalWeight).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnimalType).WithMany(p => p.Rations).HasForeignKey(d => d.AnimalTypeId);

            entity.HasOne(d => d.RationCategory).WithMany(p => p.Rations).HasForeignKey(d => d.RationCategoryId);

            entity.HasOne(d => d.RationType).WithMany(p => p.Rations).HasForeignKey(d => d.RationTypeId);

            entity.HasOne(d => d.Animal).WithMany(p => p.Rations).HasForeignKey(d => new { d.AnimalTypeId, d.AnimalBreedId });
        });

        modelBuilder.Entity<RationType>(entity =>
        {
            entity.HasIndex(e => e.AnimalTypeId, "IX_RationTypes_AnimalTypeId");

            entity.HasOne(d => d.AnimalType).WithMany(p => p.RationTypes).HasForeignKey(d => d.AnimalTypeId);
        });

        modelBuilder.Entity<AgriKingApp.Models.Region>(entity =>
        {
            entity.HasIndex(e => new { e.DisplayName, e.Id }, "IX_Regions_DisplayName_Id");
        });

        modelBuilder.Entity<ReportGroupAssignment>(entity =>
        {
            entity.HasIndex(e => e.ReportGroupId, "IX_ReportGroupAssignments_ReportGroupId");

            entity.HasIndex(e => e.UserGroupId, "IX_ReportGroupAssignments_UserGroupId");

            entity.HasIndex(e => e.UserId, "IX_ReportGroupAssignments_UserId");

            entity.HasOne(d => d.ReportGroup).WithMany(p => p.ReportGroupAssignments).HasForeignKey(d => d.ReportGroupId);

            entity.HasOne(d => d.UserGroup).WithMany(p => p.ReportGroupAssignments).HasForeignKey(d => d.UserGroupId);

            entity.HasOne(d => d.User).WithMany(p => p.ReportGroupAssignments).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<ReportTemplateDetail>(entity =>
        {
            entity.HasIndex(e => e.LabPackageId, "IX_ReportTemplateDetails_LabPackageId");

            entity.HasIndex(e => e.ReportTemplateId, "IX_ReportTemplateDetails_ReportTemplateId");

            entity.HasOne(d => d.LabPackage).WithMany(p => p.ReportTemplateDetails).HasForeignKey(d => d.LabPackageId);

            entity.HasOne(d => d.ReportTemplate).WithMany(p => p.ReportTemplateDetails).HasForeignKey(d => d.ReportTemplateId);
        });

        modelBuilder.Entity<RestQueueAction>(entity =>
        {
            entity.HasIndex(e => e.RestQueueEntryId, "IX_RestQueueActions_RestQueueEntryId");

            entity.HasOne(d => d.RestQueueEntry).WithMany(p => p.RestQueueActions).HasForeignKey(d => d.RestQueueEntryId);
        });

        modelBuilder.Entity<RestQueueEntry>(entity =>
        {
            entity.HasIndex(e => e.RestEndpointId, "IX_RestQueueEntries_RestEndpointId");

            entity.HasIndex(e => e.RestQueueId, "IX_RestQueueEntries_RestQueueId");

            entity.HasOne(d => d.RestEndpoint).WithMany(p => p.RestQueueEntries).HasForeignKey(d => d.RestEndpointId);

            entity.HasOne(d => d.RestQueue).WithMany(p => p.RestQueueEntries).HasForeignKey(d => d.RestQueueId);
        });

        modelBuilder.Entity<SalesOrder>(entity =>
        {
            entity.HasIndex(e => e.CurrencyId, "IX_SalesOrders_CurrencyId");

            entity.HasIndex(e => e.CustomerId, "IX_SalesOrders_CustomerId");

            entity.HasIndex(e => e.LocationId, "IX_SalesOrders_LocationId");

            entity.HasIndex(e => e.NstruckDropId, "IX_SalesOrders_NSTruckDropId");

            entity.HasIndex(e => e.NstruckId, "IX_SalesOrders_NSTruckId");

            entity.HasIndex(e => e.SalesOrderTypeId, "IX_SalesOrders_SalesOrderTypeId");

            entity.HasIndex(e => e.SalespersonId, "IX_SalesOrders_SalespersonId");

            entity.HasIndex(e => e.ShipToStateId, "IX_SalesOrders_ShipToStateId");

            entity.HasIndex(e => e.SubsidiaryId, "IX_SalesOrders_SubsidiaryId");

            entity.HasIndex(e => e.TruckDropId, "IX_SalesOrders_TruckDropId");

            entity.HasIndex(e => e.TruckId, "IX_SalesOrders_TruckId");

            entity.HasIndex(e => e.UserId, "IX_SalesOrders_UserId");

            //entity.Property(e => e.Id).HasDefaultValueSql("(N'')");
            entity.Property(e => e.NstruckDropId).HasColumnName("NSTruckDropId");
            entity.Property(e => e.NstruckId).HasColumnName("NSTruckId");

            entity.HasOne(d => d.Currency).WithMany(p => p.SalesOrders).HasForeignKey(d => d.CurrencyId);

            entity.HasOne(d => d.Customer).WithMany(p => p.SalesOrders).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.Location).WithMany(p => p.SalesOrders).HasForeignKey(d => d.LocationId);

            entity.HasOne(d => d.NstruckDrop).WithMany(p => p.SalesOrders).HasForeignKey(d => d.NstruckDropId);

            entity.HasOne(d => d.Nstruck).WithMany(p => p.SalesOrders).HasForeignKey(d => d.NstruckId);

            entity.HasOne(d => d.SalesOrderType).WithMany(p => p.SalesOrders).HasForeignKey(d => d.SalesOrderTypeId);

            entity.HasOne(d => d.Salesperson).WithMany(p => p.SalesOrders).HasForeignKey(d => d.SalespersonId);

            entity.HasOne(d => d.ShipToState).WithMany(p => p.SalesOrders).HasForeignKey(d => d.ShipToStateId);

            entity.HasOne(d => d.Subsidiary).WithMany(p => p.SalesOrders).HasForeignKey(d => d.SubsidiaryId);

            entity.HasOne(d => d.TruckDrop).WithMany(p => p.SalesOrders).HasForeignKey(d => d.TruckDropId);

            entity.HasOne(d => d.Truck).WithMany(p => p.SalesOrders).HasForeignKey(d => d.TruckId);

            entity.HasOne(d => d.User).WithMany(p => p.SalesOrders).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<SalesOrderCommissionDetail>(entity =>
        {
            entity.HasIndex(e => e.ItemId, "IX_SalesOrderCommissionDetails_ItemId");

            entity.HasIndex(e => e.SalesOrderId, "IX_SalesOrderCommissionDetails_SalesOrderId");

            entity.HasIndex(e => e.SalespersonId, "IX_SalesOrderCommissionDetails_SalespersonId");

            entity.Property(e => e.CommissionPercent).HasColumnType("decimal(5, 2)");
            entity.Property(e => e.SalesPercent).HasColumnType("decimal(5, 2)");

            entity.HasOne(d => d.Item).WithMany(p => p.SalesOrderCommissionDetails).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.SalesOrderCommissionDetails).HasForeignKey(d => d.SalesOrderId);

            entity.HasOne(d => d.Salesperson).WithMany(p => p.SalesOrderCommissionDetails).HasForeignKey(d => d.SalespersonId);
        });

        modelBuilder.Entity<SalesOrderDetail>(entity =>
        {
            entity.HasIndex(e => e.ItemId, "IX_SalesOrderDetails_ItemId");

            entity.HasIndex(e => e.PriceLevelId, "IX_SalesOrderDetails_PriceLevelId");

            entity.HasIndex(e => e.SalesOrderId, "IX_SalesOrderDetails_SalesOrderId");

            entity.HasIndex(e => e.UnitId, "IX_SalesOrderDetails_UnitId");

            entity.HasIndex(e => e.UnitTypeId, "IX_SalesOrderDetails_UnitTypeId");

            entity.HasOne(d => d.Item).WithMany(p => p.SalesOrderDetails).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.PriceLevel).WithMany(p => p.SalesOrderDetails).HasForeignKey(d => d.PriceLevelId);

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.SalesOrderDetails).HasForeignKey(d => d.SalesOrderId);

            entity.HasOne(d => d.Unit).WithMany(p => p.SalesOrderDetails).HasForeignKey(d => d.UnitId);

            entity.HasOne(d => d.UnitType).WithMany(p => p.SalesOrderDetails).HasForeignKey(d => d.UnitTypeId);
        });

        modelBuilder.Entity<SalesOrderDetailLot>(entity =>
        {
            entity.HasIndex(e => e.ItemId, "IX_SalesOrderDetailLots_ItemId");

            entity.HasIndex(e => e.SalesOrderId, "IX_SalesOrderDetailLots_SalesOrderId");

            entity.HasOne(d => d.Item).WithMany(p => p.SalesOrderDetailLots).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.SalesOrder).WithMany(p => p.SalesOrderDetailLots).HasForeignKey(d => d.SalesOrderId);
        });

        modelBuilder.Entity<Salesperson>(entity =>
        {
            entity.HasIndex(e => e.CurrencyId, "IX_Salespeople_CurrencyId");

            entity.HasIndex(e => new { e.DisplayName, e.Id }, "IX_Salespeople_DisplayName_Id");

            entity.HasIndex(e => e.DivisionId, "IX_Salespeople_DivisionId");

            entity.HasIndex(e => e.EmployeeId, "IX_Salespeople_EmployeeId");

            entity.HasIndex(e => e.NstruckDropId, "IX_Salespeople_NSTruckDropId");

            entity.HasIndex(e => e.NstruckId, "IX_Salespeople_NSTruckId");

            entity.HasIndex(e => e.PriceLevelId, "IX_Salespeople_PriceLevelId");

            entity.HasIndex(e => e.RegionId, "IX_Salespeople_RegionId");

            entity.HasIndex(e => e.ServiceCenterId, "IX_Salespeople_ServiceCenterId");

            entity.HasIndex(e => e.SubsidiaryId, "IX_Salespeople_SubsidiaryId");

            entity.HasIndex(e => e.TruckDropId, "IX_Salespeople_TruckDropId");

            entity.HasIndex(e => e.TruckId, "IX_Salespeople_TruckId");

            entity.Property(e => e.NstruckDropId).HasColumnName("NSTruckDropId");
            entity.Property(e => e.NstruckId).HasColumnName("NSTruckId");

            entity.HasOne(d => d.Currency).WithMany(p => p.Salespeople).HasForeignKey(d => d.CurrencyId);

            entity.HasOne(d => d.Division).WithMany(p => p.Salespeople).HasForeignKey(d => d.DivisionId);

            entity.HasOne(d => d.Employee).WithMany(p => p.Salespeople).HasForeignKey(d => d.EmployeeId);

            entity.HasOne(d => d.NstruckDrop).WithMany(p => p.Salespeople).HasForeignKey(d => d.NstruckDropId);

            entity.HasOne(d => d.Nstruck).WithMany(p => p.Salespeople).HasForeignKey(d => d.NstruckId);

            entity.HasOne(d => d.PriceLevel).WithMany(p => p.Salespeople).HasForeignKey(d => d.PriceLevelId);

            entity.HasOne(d => d.Region).WithMany(p => p.Salespeople).HasForeignKey(d => d.RegionId);

            entity.HasOne(d => d.ServiceCenter).WithMany(p => p.Salespeople).HasForeignKey(d => d.ServiceCenterId);

            entity.HasOne(d => d.Subsidiary).WithMany(p => p.Salespeople).HasForeignKey(d => d.SubsidiaryId);

            entity.HasOne(d => d.TruckDrop).WithMany(p => p.Salespeople).HasForeignKey(d => d.TruckDropId);

            entity.HasOne(d => d.Truck).WithMany(p => p.Salespeople).HasForeignKey(d => d.TruckId);
        });

        modelBuilder.Entity<SalespersonExpenseAccount>(entity =>
        {
            entity.HasIndex(e => e.SalespersonId, "IX_SalespersonExpenseAccounts_SalespersonId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Salesperson).WithMany(p => p.SalespersonExpenseAccounts).HasForeignKey(d => d.SalespersonId);
        });

        modelBuilder.Entity<SalespersonExpenseTransaction>(entity =>
        {
            entity.HasIndex(e => e.AccountId, "IX_SalespersonExpenseTransactions_AccountId");

            entity.HasIndex(e => e.TypeId, "IX_SalespersonExpenseTransactions_TypeId");

            entity.Property(e => e.Id).ValueGeneratedNever();

            entity.HasOne(d => d.Account).WithMany(p => p.SalespersonExpenseTransactions).HasForeignKey(d => d.AccountId);

            entity.HasOne(d => d.Type).WithMany(p => p.SalespersonExpenseTransactions).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<Sample>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_Samples_CustomerId");

            entity.HasIndex(e => e.LabPackageId, "IX_Samples_LabPackageId");

            entity.HasIndex(e => e.SampleStatusId, "IX_Samples_SampleStatusId");

            entity.HasIndex(e => e.SampleTypeId, "IX_Samples_SampleTypeId");

            entity.Property(e => e.Icphold).HasColumnName("ICPHold");
            entity.Property(e => e.NirfinalizedDateTime).HasColumnName("NIRFinalizedDateTime");
            entity.Property(e => e.XryfinalizedDateTime).HasColumnName("XRYFinalizedDateTime");

            entity.HasOne(d => d.Customer).WithMany(p => p.Samples).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.LabPackage).WithMany(p => p.Samples).HasForeignKey(d => d.LabPackageId);

            entity.HasOne(d => d.SampleStatus).WithMany(p => p.Samples).HasForeignKey(d => d.SampleStatusId);

            entity.HasOne(d => d.SampleType).WithMany(p => p.Samples).HasForeignKey(d => d.SampleTypeId);
        });

        modelBuilder.Entity<SampleAnalysisFinalValue>(entity =>
        {
            entity.HasKey(e => new { e.SampleId, e.AnalysisTypeId });

            entity.HasIndex(e => e.AnalysisSourceId, "IX_SampleAnalysisFinalValues_AnalysisSourceId");

            entity.HasIndex(e => e.AnalysisTypeId, "IX_SampleAnalysisFinalValues_AnalysisTypeId");

            entity.Property(e => e.AnalyzedValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.FinalValue).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnalysisSource).WithMany(p => p.SampleAnalysisFinalValues).HasForeignKey(d => d.AnalysisSourceId);

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.SampleAnalysisFinalValues).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.Sample).WithMany(p => p.SampleAnalysisFinalValues).HasForeignKey(d => d.SampleId);
        });

        modelBuilder.Entity<SampleAnalysisFinalValueImport>(entity =>
        {
            entity.HasIndex(e => e.AnalysisSourceId, "IX_SampleAnalysisFinalValueImports_AnalysisSourceId");

            entity.HasIndex(e => e.AnalysisTypeId, "IX_SampleAnalysisFinalValueImports_AnalysisTypeId");

            entity.HasIndex(e => e.SampleId, "IX_SampleAnalysisFinalValueImports_SampleId");

            entity.Property(e => e.AnalyzedValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.FinalValue).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnalysisSource).WithMany(p => p.SampleAnalysisFinalValueImports).HasForeignKey(d => d.AnalysisSourceId);

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.SampleAnalysisFinalValueImports).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.Sample).WithMany(p => p.SampleAnalysisFinalValueImports).HasForeignKey(d => d.SampleId);
        });

        modelBuilder.Entity<SampleAnalysisLimit>(entity =>
        {
            entity.HasIndex(e => e.AnalysisSourceId, "IX_SampleAnalysisLimits_AnalysisSourceId");

            entity.HasIndex(e => e.AnalysisTypeId, "IX_SampleAnalysisLimits_AnalysisTypeId");

            entity.HasIndex(e => e.SampleTypeId, "IX_SampleAnalysisLimits_SampleTypeId");

            entity.Property(e => e.HighLimit).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.LowLimit).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnalysisSource).WithMany(p => p.SampleAnalysisLimits).HasForeignKey(d => d.AnalysisSourceId);

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.SampleAnalysisLimits).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.SampleType).WithMany(p => p.SampleAnalysisLimits).HasForeignKey(d => d.SampleTypeId);
        });

        modelBuilder.Entity<SampleAnalysisReportRange>(entity =>
        {
            entity.HasIndex(e => e.AnalysisTypeId, "IX_SampleAnalysisReportRanges_AnalysisTypeId");

            entity.HasIndex(e => e.CountryId, "IX_SampleAnalysisReportRanges_CountryId");

            entity.HasIndex(e => e.SampleTypeId, "IX_SampleAnalysisReportRanges_SampleTypeId");

            entity.Property(e => e.HighValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.LowValue).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.SampleAnalysisReportRanges).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.Country).WithMany(p => p.SampleAnalysisReportRanges).HasForeignKey(d => d.CountryId);

            entity.HasOne(d => d.SampleType).WithMany(p => p.SampleAnalysisReportRanges).HasForeignKey(d => d.SampleTypeId);
        });

        modelBuilder.Entity<SampleAnalysisStatistic>(entity =>
        {
            entity.HasIndex(e => e.AnalysisTypeId, "IX_SampleAnalysisStatistics_AnalysisTypeId");

            entity.HasIndex(e => e.CountryId, "IX_SampleAnalysisStatistics_CountryId");

            entity.HasIndex(e => e.RegionId, "IX_SampleAnalysisStatistics_RegionId");

            entity.HasIndex(e => e.SampleTypeId, "IX_SampleAnalysisStatistics_SampleTypeId");

            entity.HasIndex(e => e.StateId, "IX_SampleAnalysisStatistics_StateId");

            entity.Property(e => e.Maximum).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.Mean).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.Minimum).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.Range).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.StandardDeviation).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.Variance).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.SampleAnalysisStatistics).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.Country).WithMany(p => p.SampleAnalysisStatistics).HasForeignKey(d => d.CountryId);

            entity.HasOne(d => d.Region).WithMany(p => p.SampleAnalysisStatistics).HasForeignKey(d => d.RegionId);

            entity.HasOne(d => d.SampleType).WithMany(p => p.SampleAnalysisStatistics).HasForeignKey(d => d.SampleTypeId);

            entity.HasOne(d => d.State).WithMany(p => p.SampleAnalysisStatistics).HasForeignKey(d => d.StateId);
        });

        modelBuilder.Entity<SampleAnalysisTargetValue>(entity =>
        {
            entity.HasIndex(e => e.AnalysisTypeId, "IX_SampleAnalysisTargetValues_AnalysisTypeId");

            entity.HasIndex(e => e.AnimalTypeId, "IX_SampleAnalysisTargetValues_AnimalTypeId");

            entity.HasIndex(e => e.CountryId, "IX_SampleAnalysisTargetValues_CountryId");

            entity.HasIndex(e => e.RationTypeId, "IX_SampleAnalysisTargetValues_RationTypeId");

            entity.HasIndex(e => e.SampleTypeId, "IX_SampleAnalysisTargetValues_SampleTypeId");

            entity.Property(e => e.HighValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.LowValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.TargetValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.VeryHighValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.VeryLowValue).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.SampleAnalysisTargetValues).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.AnimalType).WithMany(p => p.SampleAnalysisTargetValues).HasForeignKey(d => d.AnimalTypeId);

            entity.HasOne(d => d.Country).WithMany(p => p.SampleAnalysisTargetValues).HasForeignKey(d => d.CountryId);

            entity.HasOne(d => d.RationType).WithMany(p => p.SampleAnalysisTargetValues).HasForeignKey(d => d.RationTypeId);

            entity.HasOne(d => d.SampleType).WithMany(p => p.SampleAnalysisTargetValues).HasForeignKey(d => d.SampleTypeId);
        });

        modelBuilder.Entity<SampleAnalysisWeight>(entity =>
        {
            entity.HasKey(e => new { e.SampleId, e.SampleAnalysisWeightTypeId });

            entity.HasIndex(e => new { e.LabContainerTypeId, e.LabContainerNumber }, "IX_SampleAnalysisWeights_LabContainerTypeId_LabContainerNumber");

            entity.HasIndex(e => e.SampleAnalysisWeightTypeId, "IX_SampleAnalysisWeights_SampleAnalysisWeightTypeId");

            entity.Property(e => e.BaseCalc).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.ContainerWeight).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.SampleWeight).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.LabContainerType).WithMany(p => p.SampleAnalysisWeights).HasForeignKey(d => d.LabContainerTypeId);

            entity.HasOne(d => d.SampleAnalysisWeightType).WithMany(p => p.SampleAnalysisWeights).HasForeignKey(d => d.SampleAnalysisWeightTypeId);

            entity.HasOne(d => d.LabContainer).WithMany(p => p.SampleAnalysisWeights).HasForeignKey(d => new { d.LabContainerTypeId, d.LabContainerNumber });
        });

        modelBuilder.Entity<SampleAnalysisWeightType>(entity =>
        {
            entity.HasIndex(e => e.AnalysisTypeId, "IX_SampleAnalysisWeightTypes_AnalysisTypeId");

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.SampleAnalysisWeightTypes).HasForeignKey(d => d.AnalysisTypeId);
        });

        modelBuilder.Entity<SampleAnalysisWorkingValue>(entity =>
        {
            entity.HasKey(e => new { e.SampleId, e.AnalysisTypeId, e.AnalysisSourceId });

            entity.HasIndex(e => e.AnalysisSourceId, "IX_SampleAnalysisWorkingValues_AnalysisSourceId");

            entity.HasIndex(e => e.AnalysisTypeId, "IX_SampleAnalysisWorkingValues_AnalysisTypeId");

            entity.Property(e => e.AnalyzedValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.CorrectedValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.GlobalHvalue)
                .HasColumnType("decimal(24, 8)")
                .HasColumnName("GlobalHValue");
            entity.Property(e => e.NeighborhoodValue).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnalysisSource).WithMany(p => p.SampleAnalysisWorkingValues).HasForeignKey(d => d.AnalysisSourceId);

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.SampleAnalysisWorkingValues).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.Sample).WithMany(p => p.SampleAnalysisWorkingValues).HasForeignKey(d => d.SampleId);
        });

        modelBuilder.Entity<SampleCategoryAnalysisType>(entity =>
        {
            entity.HasKey(e => new { e.SampleCategoryId, e.AnalysisTypeId });

            entity.HasIndex(e => e.AnalysisTypeId, "IX_SampleCategoryAnalysisTypes_AnalysisTypeId");

            entity.Property(e => e.HighLimitValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.LowLimitValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.StandardValue).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.SampleCategoryAnalysisTypes).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.SampleCategory).WithMany(p => p.SampleCategoryAnalysisTypes).HasForeignKey(d => d.SampleCategoryId);
        });

        modelBuilder.Entity<SampleMoistureWeight>(entity =>
        {
            entity.HasKey(e => e.SampleId);

            entity.Property(e => e.ContainerWeight).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.LabContainerNumber).HasMaxLength(450);
            entity.Property(e => e.LabContainerTypeId).HasMaxLength(450);
            entity.Property(e => e.PercentMoisture).HasColumnType("decimal(12, 2)");
            entity.Property(e => e.SampleDryWeight).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.SampleWetWeight).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.LabContainerType).WithMany(p => p.SampleMoistureWeights).HasForeignKey(d => d.LabContainerTypeId);

            entity.HasOne(d => d.LabContainer).WithMany(p => p.SampleMoistureWeights).HasForeignKey(d => new { d.LabContainerTypeId, d.LabContainerNumber });
        });

        modelBuilder.Entity<SampleNotification>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_SampleNotifications_CustomerId");

            entity.HasIndex(e => e.SalespersonId, "IX_SampleNotifications_SalespersonId");

            entity.Property(e => e.SendToAreaManager)
                .IsRequired();
                //.HasDefaultValueSql("(CONVERT([bit],(1)))");

            entity.HasOne(d => d.Customer).WithMany(p => p.SampleNotifications).HasForeignKey(d => d.CustomerId);

            entity.HasOne(d => d.Salesperson).WithMany(p => p.SampleNotifications).HasForeignKey(d => d.SalespersonId);
        });

        modelBuilder.Entity<SampleParticleSizeAnalysis>(entity =>
        {
            entity.HasKey(e => new { e.SampleId, e.AnalysisTypeId });

            entity.HasIndex(e => e.AnalysisTypeId, "IX_SampleParticleSizeAnalyses_AnalysisTypeId");

            entity.Property(e => e.AfterWeight).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.BeforeWeight).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.SampleParticleSizeAnalyses).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.Sample).WithMany(p => p.SampleParticleSizeAnalyses).HasForeignKey(d => d.SampleId);
        });

        modelBuilder.Entity<SampleRequest>(entity =>
        {
            entity.HasIndex(e => e.AnimalTypeId, "IX_SampleRequests_AnimalTypeId");

            entity.HasIndex(e => e.RationId, "IX_SampleRequests_RationId");

            entity.HasIndex(e => e.RationTypeId, "IX_SampleRequests_RationTypeId");

            entity.HasIndex(e => e.SalespersonId, "IX_SampleRequests_SalespersonId");

            entity.HasIndex(e => e.SampleTypeId, "IX_SampleRequests_SampleTypeId");

            entity.Property(e => e.ProspectFlag)
                .IsRequired();
                //.HasDefaultValueSql("(CONVERT([bit],(0)))");
            entity.Property(e => e.SampleId).HasMaxLength(450);

            entity.HasOne(d => d.AnimalType).WithMany(p => p.SampleRequests).HasForeignKey(d => d.AnimalTypeId);

            entity.HasOne(d => d.RationType).WithMany(p => p.SampleRequests).HasForeignKey(d => d.RationTypeId);

            entity.HasOne(d => d.Salesperson).WithMany(p => p.SampleRequests).HasForeignKey(d => d.SalespersonId);

            entity.HasOne(d => d.SampleType).WithMany(p => p.SampleRequests).HasForeignKey(d => d.SampleTypeId);
        });

        modelBuilder.Entity<SampleResultExportTemplate>(entity =>
        {
            entity.HasIndex(e => e.UserId, "IX_SampleResultExportTemplates_UserId");

            entity.HasOne(d => d.User).WithMany(p => p.SampleResultExportTemplates).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<SampleType>(entity =>
        {
            entity.HasIndex(e => e.CategoryId, "IX_SampleTypes_CategoryId");

            entity.HasIndex(e => e.XrayCalibrationCategoryId, "IX_SampleTypes_XrayCalibrationCategoryId");

            entity.HasOne(d => d.Category).WithMany(p => p.SampleTypes).HasForeignKey(d => d.CategoryId);

            entity.HasOne(d => d.XrayCalibrationCategory).WithMany(p => p.SampleTypes).HasForeignKey(d => d.XrayCalibrationCategoryId);
        });

        modelBuilder.Entity<SampleTypeAnalysisType>(entity =>
        {
            entity.HasKey(e => new { e.SampleTypeId, e.AnalysisTypeId });

            entity.HasIndex(e => e.AnalysisTypeId, "IX_SampleTypeAnalysisTypes_AnalysisTypeId");

            entity.Property(e => e.DefaultHighValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.DefaultLowValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.HighLimitValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.HighLimitValueQc)
                .HasColumnType("decimal(24, 8)")
                .HasColumnName("HighLimitValueQC");
            entity.Property(e => e.LowLimitValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.LowLimitValueQc)
                .HasColumnType("decimal(24, 8)")
                .HasColumnName("LowLimitValueQC");
            entity.Property(e => e.StandardValue).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.SampleTypeAnalysisTypes).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.SampleType).WithMany(p => p.SampleTypeAnalysisTypes).HasForeignKey(d => d.SampleTypeId);
        });

        modelBuilder.Entity<SampleTypeAnalysisTypeSourceSequence>(entity =>
        {
            entity.HasKey(e => new { e.SampleTypeId, e.AnalysisTypeId, e.AnalysisSourceId });

            entity.HasIndex(e => e.AnalysisSourceId, "IX_SampleTypeAnalysisTypeSourceSequences_AnalysisSourceId");

            entity.HasIndex(e => e.AnalysisTypeId, "IX_SampleTypeAnalysisTypeSourceSequences_AnalysisTypeId");

            entity.HasOne(d => d.AnalysisSource).WithMany(p => p.SampleTypeAnalysisTypeSourceSequences).HasForeignKey(d => d.AnalysisSourceId);

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.SampleTypeAnalysisTypeSourceSequences).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.SampleType).WithMany(p => p.SampleTypeAnalysisTypeSourceSequences).HasForeignKey(d => d.SampleTypeId);
        });

        modelBuilder.Entity<ScheduledTask>(entity =>
        {
            entity.HasIndex(e => e.ScheduleTimeId, "IX_ScheduledTasks_ScheduleTimeId");

            entity.HasOne(d => d.ScheduleTime).WithMany(p => p.ScheduledTasks).HasForeignKey(d => d.ScheduleTimeId);
        });

        modelBuilder.Entity<ScheduledTaskJob>(entity =>
        {
            entity.HasIndex(e => e.ScheduledTaskId, "IX_ScheduledTaskJobs_ScheduledTaskId");

            entity.HasOne(d => d.ScheduledTask).WithMany(p => p.ScheduledTaskJobs).HasForeignKey(d => d.ScheduledTaskId);
        });

        modelBuilder.Entity<ScheduledTaskJobLog>(entity =>
        {
            entity.HasIndex(e => e.ScheduledTaskJobId, "IX_ScheduledTaskJobLogs_ScheduledTaskJobId");

            entity.HasOne(d => d.ScheduledTaskJob).WithMany(p => p.ScheduledTaskJobLogs).HasForeignKey(d => d.ScheduledTaskJobId);
        });

        modelBuilder.Entity<ScheduledTaskJobParameter>(entity =>
        {
            entity.HasIndex(e => e.ScheduledTaskJobId, "IX_ScheduledTaskJobParameters_ScheduledTaskJobId");

            entity.HasOne(d => d.ScheduledTaskJob).WithMany(p => p.ScheduledTaskJobParameters).HasForeignKey(d => d.ScheduledTaskJobId);
        });

        modelBuilder.Entity<ScheduledTaskParameter>(entity =>
        {
            entity.HasIndex(e => e.ScheduledTaskId, "IX_ScheduledTaskParameters_ScheduledTaskId");

            entity.HasOne(d => d.ScheduledTask).WithMany(p => p.ScheduledTaskParameters).HasForeignKey(d => d.ScheduledTaskId);
        });

        modelBuilder.Entity<ServiceCenter>(entity =>
        {
            entity.HasIndex(e => e.CountryId, "IX_ServiceCenters_CountryId");

            entity.HasIndex(e => new { e.DisplayName, e.Id }, "IX_ServiceCenters_DisplayName_Id");

            entity.HasIndex(e => e.StateId, "IX_ServiceCenters_StateId");

            entity.HasOne(d => d.Country).WithMany(p => p.ServiceCenters).HasForeignKey(d => d.CountryId);

            entity.HasOne(d => d.State).WithMany(p => p.ServiceCenters).HasForeignKey(d => d.StateId);
        });

        modelBuilder.Entity<SmartCheck>(entity =>
        {
            entity.HasIndex(e => e.CustomerId, "IX_SmartChecks_CustomerId");

            entity.HasOne(d => d.Customer).WithMany(p => p.SmartChecks).HasForeignKey(d => d.CustomerId);
        });

        modelBuilder.Entity<SmartCheckAnalysisType>(entity =>
        {
            entity.HasIndex(e => e.AnalysisTypeId, "IX_SmartCheckAnalysisTypes_AnalysisTypeId");

            entity.HasIndex(e => e.SampleTypeId, "IX_SmartCheckAnalysisTypes_SampleTypeId");

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.SmartCheckAnalysisTypes).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.SampleType).WithMany(p => p.SmartCheckAnalysisTypes).HasForeignKey(d => d.SampleTypeId);
        });

        modelBuilder.Entity<SmartCheckEmployee>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId, "IX_SmartCheckEmployees_EmployeeId");

            entity.HasIndex(e => e.SmartCheckId, "IX_SmartCheckEmployees_SmartCheckId");

            entity.HasOne(d => d.Employee).WithMany(p => p.SmartCheckEmployees).HasForeignKey(d => d.EmployeeId);

            entity.HasOne(d => d.SmartCheck).WithMany(p => p.SmartCheckEmployees).HasForeignKey(d => d.SmartCheckId);
        });

        modelBuilder.Entity<SmartCheckForage>(entity =>
        {
            entity.HasIndex(e => e.SmartCheckId, "IX_SmartCheckForages_SmartCheckId");

            entity.Property(e => e.CalculatedDensityA).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.CalculatedDensityB).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.CalculatedDensityC).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.CalculatedDensityD).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.SmartCheck).WithMany(p => p.SmartCheckForages).HasForeignKey(d => d.SmartCheckId);
        });

        modelBuilder.Entity<SmartCheckForageImage>(entity =>
        {
            entity.HasIndex(e => e.SmartCheckForageId, "IX_SmartCheckForageImages_SmartCheckForageId");

            entity.HasOne(d => d.SmartCheckForage).WithMany(p => p.SmartCheckForageImages).HasForeignKey(d => d.SmartCheckForageId);
        });

        modelBuilder.Entity<SmartCheckForageSample>(entity =>
        {
            entity.HasIndex(e => e.SampleId, "IX_SmartCheckForageSamples_SampleId");

            entity.HasIndex(e => e.SmartCheckForageId, "IX_SmartCheckForageSamples_SmartCheckForageId");

            entity.HasIndex(e => e.SmartCheckId, "IX_SmartCheckForageSamples_SmartCheckId");

            entity.HasOne(d => d.Sample).WithMany(p => p.SmartCheckForageSamples).HasForeignKey(d => d.SampleId);

            entity.HasOne(d => d.SmartCheckForage).WithMany(p => p.SmartCheckForageSamples).HasForeignKey(d => d.SmartCheckForageId);

            entity.HasOne(d => d.SmartCheck).WithMany(p => p.SmartCheckForageSamples).HasForeignKey(d => d.SmartCheckId);
        });

        modelBuilder.Entity<SmartCheckForageSampleAnalysisValue>(entity =>
        {
            entity.HasIndex(e => e.AnalysisSourceId, "IX_SmartCheckForageSampleAnalysisValues_AnalysisSourceId");

            entity.HasIndex(e => e.AnalysisTypeId, "IX_SmartCheckForageSampleAnalysisValues_AnalysisTypeId");

            entity.HasIndex(e => e.SampleId, "IX_SmartCheckForageSampleAnalysisValues_SampleId");

            entity.HasIndex(e => e.SmartCheckForageSampleId, "IX_SmartCheckForageSampleAnalysisValues_SmartCheckForageSampleId");

            entity.Property(e => e.AnalyzedValue).HasColumnType("decimal(24, 8)");
            entity.Property(e => e.FinalValue).HasColumnType("decimal(24, 8)");

            entity.HasOne(d => d.AnalysisSource).WithMany(p => p.SmartCheckForageSampleAnalysisValues).HasForeignKey(d => d.AnalysisSourceId);

            entity.HasOne(d => d.AnalysisType).WithMany(p => p.SmartCheckForageSampleAnalysisValues).HasForeignKey(d => d.AnalysisTypeId);

            entity.HasOne(d => d.Sample).WithMany(p => p.SmartCheckForageSampleAnalysisValues).HasForeignKey(d => d.SampleId);

            entity.HasOne(d => d.SmartCheckForageSample).WithMany(p => p.SmartCheckForageSampleAnalysisValues).HasForeignKey(d => d.SmartCheckForageSampleId);
        });

        modelBuilder.Entity<SmartCheckForageTemperature>(entity =>
        {
            entity.HasIndex(e => e.SmartCheckForageId, "IX_SmartCheckForageTemperatures_SmartCheckForageId");

            entity.HasOne(d => d.SmartCheckForage).WithMany(p => p.SmartCheckForageTemperatures).HasForeignKey(d => d.SmartCheckForageId);
        });

        modelBuilder.Entity<State>(entity =>
        {
            entity.HasIndex(e => e.CountryId, "IX_States_CountryId");

            entity.HasOne(d => d.Country).WithMany(p => p.States).HasForeignKey(d => d.CountryId);
        });

        modelBuilder.Entity<Subsidiary>(entity =>
        {
            entity.Property(e => e.AknetSuiteId).HasColumnName("AKNetSuiteId");
        });

        modelBuilder.Entity<SubsidiaryItem>(entity =>
        {
            entity.HasIndex(e => e.ItemId, "IX_SubsidiaryItems_ItemId");

            entity.HasIndex(e => e.SubsidiaryId, "IX_SubsidiaryItems_SubsidiaryId");

            entity.HasOne(d => d.Item).WithMany(p => p.SubsidiaryItems).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Subsidiary).WithMany(p => p.SubsidiaryItems).HasForeignKey(d => d.SubsidiaryId);
        });

        modelBuilder.Entity<TransferOrder>(entity =>
        {
            entity.HasIndex(e => e.FromBinId, "IX_TransferOrders_FromBinId");

            entity.HasIndex(e => e.FromLocationId, "IX_TransferOrders_FromLocationId");

            entity.HasIndex(e => e.NstruckDropId, "IX_TransferOrders_NSTruckDropId");

            entity.HasIndex(e => e.NstruckId, "IX_TransferOrders_NSTruckId");

            entity.HasIndex(e => e.SalespersonId, "IX_TransferOrders_SalespersonId");

            entity.HasIndex(e => e.ShipToStateId, "IX_TransferOrders_ShipToStateId");

            entity.HasIndex(e => e.SubsidiaryId, "IX_TransferOrders_SubsidiaryId");

            entity.HasIndex(e => e.ToBinId, "IX_TransferOrders_ToBinId");

            entity.HasIndex(e => e.ToLocationId, "IX_TransferOrders_ToLocationId");

            entity.HasIndex(e => e.TruckDropId, "IX_TransferOrders_TruckDropId");

            entity.HasIndex(e => e.TruckId, "IX_TransferOrders_TruckId");

            entity.Property(e => e.NstruckDropId).HasColumnName("NSTruckDropId");
            entity.Property(e => e.NstruckId).HasColumnName("NSTruckId");

            entity.HasOne(d => d.FromBin).WithMany(p => p.TransferOrderFromBins).HasForeignKey(d => d.FromBinId);

            entity.HasOne(d => d.FromLocation).WithMany(p => p.TransferOrderFromLocations).HasForeignKey(d => d.FromLocationId);

            entity.HasOne(d => d.NstruckDrop).WithMany(p => p.TransferOrders).HasForeignKey(d => d.NstruckDropId);

            entity.HasOne(d => d.Nstruck).WithMany(p => p.TransferOrders).HasForeignKey(d => d.NstruckId);

            entity.HasOne(d => d.Salesperson).WithMany(p => p.TransferOrders).HasForeignKey(d => d.SalespersonId);

            entity.HasOne(d => d.ShipToState).WithMany(p => p.TransferOrders).HasForeignKey(d => d.ShipToStateId);

            entity.HasOne(d => d.Subsidiary).WithMany(p => p.TransferOrders).HasForeignKey(d => d.SubsidiaryId);

            entity.HasOne(d => d.ToBin).WithMany(p => p.TransferOrderToBins).HasForeignKey(d => d.ToBinId);

            entity.HasOne(d => d.ToLocation).WithMany(p => p.TransferOrderToLocations).HasForeignKey(d => d.ToLocationId);

            entity.HasOne(d => d.TruckDrop).WithMany(p => p.TransferOrders).HasForeignKey(d => d.TruckDropId);

            entity.HasOne(d => d.Truck).WithMany(p => p.TransferOrders).HasForeignKey(d => d.TruckId);
        });

        modelBuilder.Entity<TransferOrdersDetail>(entity =>
        {
            entity.HasIndex(e => e.ItemId, "IX_TransferOrdersDetails_ItemId");

            entity.HasIndex(e => e.TransferOrderId, "IX_TransferOrdersDetails_TransferOrderId");

            entity.HasIndex(e => e.UnitId, "IX_TransferOrdersDetails_UnitId");

            entity.HasIndex(e => e.UnitTypeId, "IX_TransferOrdersDetails_UnitTypeId");

            entity.HasOne(d => d.Item).WithMany(p => p.TransferOrdersDetails).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.TransferOrder).WithMany(p => p.TransferOrdersDetails).HasForeignKey(d => d.TransferOrderId);

            entity.HasOne(d => d.Unit).WithMany(p => p.TransferOrdersDetails).HasForeignKey(d => d.UnitId);

            entity.HasOne(d => d.UnitType).WithMany(p => p.TransferOrdersDetails).HasForeignKey(d => d.UnitTypeId);
        });

        modelBuilder.Entity<Truck>(entity =>
        {
            entity.HasIndex(e => new { e.DisplayName, e.Id }, "IX_Trucks_DisplayName_Id");
        });

        modelBuilder.Entity<TruckDefault>(entity =>
        {
            entity.HasIndex(e => e.NstruckId, "IX_TruckDefaults_NSTruckId");

            entity.HasIndex(e => e.TruckId, "IX_TruckDefaults_TruckId");

            entity.Property(e => e.NstruckId).HasColumnName("NSTruckId");

            entity.HasOne(d => d.Nstruck).WithMany(p => p.TruckDefaults).HasForeignKey(d => d.NstruckId);

            entity.HasOne(d => d.Truck).WithMany(p => p.TruckDefaults).HasForeignKey(d => d.TruckId);
        });

        modelBuilder.Entity<TruckDrop>(entity =>
        {
            entity.HasIndex(e => new { e.DisplayName, e.Id }, "IX_TruckDrops_DisplayName_Id");

            entity.HasIndex(e => e.TruckId, "IX_TruckDrops_TruckId");

            //entity.Property(e => e.Id).HasDefaultValueSql("(N'')");

            entity.HasOne(d => d.Truck).WithMany(p => p.TruckDrops).HasForeignKey(d => d.TruckId);
        });

        modelBuilder.Entity<TruckException>(entity =>
        {
            entity.HasIndex(e => e.NstruckId, "IX_TruckExceptions_NSTruckId");

            entity.HasIndex(e => e.TruckId, "IX_TruckExceptions_TruckId");

            entity.Property(e => e.NstruckId).HasColumnName("NSTruckId");

            entity.HasOne(d => d.Nstruck).WithMany(p => p.TruckExceptions).HasForeignKey(d => d.NstruckId);

            entity.HasOne(d => d.Truck).WithMany(p => p.TruckExceptions).HasForeignKey(d => d.TruckId);
        });

        modelBuilder.Entity<TruckFinal>(entity =>
        {
            entity.ToTable("TruckFinal");

            entity.HasIndex(e => e.NstruckId, "IX_TruckFinal_NSTruckId");

            entity.HasIndex(e => new { e.TruckId, e.TruckShipDateTime }, "IX_TruckFinal_TruckId_TruckShipDateTime");

            entity.Property(e => e.NstruckId).HasColumnName("NSTruckId");

            entity.HasOne(d => d.Nstruck).WithMany(p => p.TruckFinals).HasForeignKey(d => d.NstruckId);

            entity.HasOne(d => d.Truck).WithMany(p => p.TruckFinals).HasForeignKey(d => d.TruckId);
        });

        modelBuilder.Entity<Unit>(entity =>
        {
            entity.HasIndex(e => e.UnitTypeId, "IX_Units_UnitTypeId");

            entity.HasOne(d => d.UnitType).WithMany(p => p.Units).HasForeignKey(d => d.UnitTypeId);
        });

        modelBuilder.Entity<User>(entity =>
        {
            entity.HasIndex(e => e.EmployeeId, "IX_Users_EmployeeId");

            entity.HasIndex(e => e.StatusId, "IX_Users_StatusId");

            entity.HasIndex(e => e.TypeId, "IX_Users_TypeId");

            entity.HasOne(d => d.Employee).WithMany(p => p.Users).HasForeignKey(d => d.EmployeeId);

            entity.HasOne(d => d.Status).WithMany(p => p.Users).HasForeignKey(d => d.StatusId);

            entity.HasOne(d => d.Type).WithMany(p => p.Users).HasForeignKey(d => d.TypeId);
        });

        modelBuilder.Entity<UserGroup>(entity =>
        {
            entity.HasMany(d => d.Users).WithMany(p => p.UserGroups)
                .UsingEntity<Dictionary<string, object>>(
                    "UserGroupUser",
                    r => r.HasOne<User>().WithMany().HasForeignKey("UserId"),
                    l => l.HasOne<UserGroup>().WithMany().HasForeignKey("UserGroupId"),
                    j =>
                    {
                        j.HasKey("UserGroupId", "UserId");
                        j.ToTable("UserGroupUsers");
                        j.HasIndex(new[] { "UserId" }, "IX_UserGroupUsers_UserId");
                    });
        });

        modelBuilder.Entity<UserKeyValue>(entity =>
        {
            entity.HasKey(e => new { e.UserId, e.Key });

            entity.HasOne(d => d.User).WithMany(p => p.UserKeyValues).HasForeignKey(d => d.UserId);
        });

        modelBuilder.Entity<UserMessage>(entity =>
        {
            entity.HasIndex(e => e.SentFrom, "IX_UserMessages_SentFrom");

            entity.HasOne(d => d.SentFromNavigation).WithMany(p => p.UserMessages).HasForeignKey(d => d.SentFrom);
        });

        modelBuilder.Entity<WorkOrder>(entity =>
        {
            entity.HasIndex(e => e.ItemFormulaId, "IX_WorkOrders_ItemFormulaId");

            entity.HasIndex(e => e.ItemFormulaRevisionId, "IX_WorkOrders_ItemFormulaRevisionId");

            entity.HasIndex(e => new { e.ItemId, e.ScheduledDateTime }, "IX_WorkOrders_ItemId_ScheduledDateTime");

            entity.HasIndex(e => e.LocationId, "IX_WorkOrders_LocationId");

            entity.HasIndex(e => new { e.SterlingRunKey, e.ScheduledDateTime }, "IX_WorkOrders_SterlingRunKey_ScheduledDateTime");

            entity.HasIndex(e => e.SubsidiaryId, "IX_WorkOrders_SubsidiaryId");

            entity.HasIndex(e => e.UnitId, "IX_WorkOrders_UnitId");

            entity.HasIndex(e => e.UnitTypeId, "IX_WorkOrders_UnitTypeId");

            entity.HasOne(d => d.ItemFormula).WithMany(p => p.WorkOrders).HasForeignKey(d => d.ItemFormulaId);

            entity.HasOne(d => d.ItemFormulaRevision).WithMany(p => p.WorkOrders).HasForeignKey(d => d.ItemFormulaRevisionId);

            entity.HasOne(d => d.Item).WithMany(p => p.WorkOrders).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Location).WithMany(p => p.WorkOrders).HasForeignKey(d => d.LocationId);

            entity.HasOne(d => d.Subsidiary).WithMany(p => p.WorkOrders).HasForeignKey(d => d.SubsidiaryId);

            entity.HasOne(d => d.Unit).WithMany(p => p.WorkOrders).HasForeignKey(d => d.UnitId);

            entity.HasOne(d => d.UnitType).WithMany(p => p.WorkOrders).HasForeignKey(d => d.UnitTypeId);
        });

        modelBuilder.Entity<WorkOrderBatch>(entity =>
        {
            entity.HasIndex(e => e.ItemFormulaId, "IX_WorkOrderBatches_ItemFormulaId");

            entity.HasIndex(e => e.ItemFormulaRevisionId, "IX_WorkOrderBatches_ItemFormulaRevisionId");

            entity.HasIndex(e => new { e.ItemId, e.StartedDateTime, e.CompletedDateTime }, "IX_WorkOrderBatches_ItemId_StartedDateTime_CompletedDateTime");

            entity.HasIndex(e => e.LocationId, "IX_WorkOrderBatches_LocationId");

            entity.HasIndex(e => new { e.SterlingRunKey, e.SterlingBatchNumber }, "IX_WorkOrderBatches_SterlingRunKey_SterlingBatchNumber");

            entity.HasIndex(e => e.SubsidiaryId, "IX_WorkOrderBatches_SubsidiaryId");

            entity.HasIndex(e => e.UnitId, "IX_WorkOrderBatches_UnitId");

            entity.HasIndex(e => e.UnitTypeId, "IX_WorkOrderBatches_UnitTypeId");

            entity.HasIndex(e => e.WorkOrderId, "IX_WorkOrderBatches_WorkOrderId");

            entity.HasOne(d => d.ItemFormula).WithMany(p => p.WorkOrderBatches).HasForeignKey(d => d.ItemFormulaId);

            entity.HasOne(d => d.ItemFormulaRevision).WithMany(p => p.WorkOrderBatches).HasForeignKey(d => d.ItemFormulaRevisionId);

            entity.HasOne(d => d.Item).WithMany(p => p.WorkOrderBatches).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Location).WithMany(p => p.WorkOrderBatches).HasForeignKey(d => d.LocationId);

            entity.HasOne(d => d.Subsidiary).WithMany(p => p.WorkOrderBatches).HasForeignKey(d => d.SubsidiaryId);

            entity.HasOne(d => d.Unit).WithMany(p => p.WorkOrderBatches).HasForeignKey(d => d.UnitId);

            entity.HasOne(d => d.UnitType).WithMany(p => p.WorkOrderBatches).HasForeignKey(d => d.UnitTypeId);

            entity.HasOne(d => d.WorkOrder).WithMany(p => p.WorkOrderBatches).HasForeignKey(d => d.WorkOrderId);
        });

        modelBuilder.Entity<WorkOrderBatchAssembly>(entity =>
        {
            entity.HasIndex(e => e.ItemFormulaId, "IX_WorkOrderBatchAssemblies_ItemFormulaId");

            entity.HasIndex(e => e.ItemFormulaRevisionId, "IX_WorkOrderBatchAssemblies_ItemFormulaRevisionId");

            entity.HasIndex(e => e.ItemId, "IX_WorkOrderBatchAssemblies_ItemId");

            entity.HasIndex(e => e.LocationId, "IX_WorkOrderBatchAssemblies_LocationId");

            entity.HasIndex(e => e.SubsidiaryId, "IX_WorkOrderBatchAssemblies_SubsidiaryId");

            entity.HasIndex(e => e.UnitId, "IX_WorkOrderBatchAssemblies_UnitId");

            entity.HasIndex(e => e.UnitTypeId, "IX_WorkOrderBatchAssemblies_UnitTypeId");

            entity.HasIndex(e => e.WorkOrderBatchId, "IX_WorkOrderBatchAssemblies_WorkOrderBatchId");

            entity.HasOne(d => d.ItemFormula).WithMany(p => p.WorkOrderBatchAssemblies).HasForeignKey(d => d.ItemFormulaId);

            entity.HasOne(d => d.ItemFormulaRevision).WithMany(p => p.WorkOrderBatchAssemblies).HasForeignKey(d => d.ItemFormulaRevisionId);

            entity.HasOne(d => d.Item).WithMany(p => p.WorkOrderBatchAssemblies).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.Location).WithMany(p => p.WorkOrderBatchAssemblies).HasForeignKey(d => d.LocationId);

            entity.HasOne(d => d.Subsidiary).WithMany(p => p.WorkOrderBatchAssemblies).HasForeignKey(d => d.SubsidiaryId);

            entity.HasOne(d => d.Unit).WithMany(p => p.WorkOrderBatchAssemblies).HasForeignKey(d => d.UnitId);

            entity.HasOne(d => d.UnitType).WithMany(p => p.WorkOrderBatchAssemblies).HasForeignKey(d => d.UnitTypeId);

            entity.HasOne(d => d.WorkOrderBatch).WithMany(p => p.WorkOrderBatchAssemblies).HasForeignKey(d => d.WorkOrderBatchId);
        });

        modelBuilder.Entity<WorkOrderBatchAssemblyComponent>(entity =>
        {
            entity.HasIndex(e => e.BinId, "IX_WorkOrderBatchAssemblyComponents_BinId");

            entity.HasIndex(e => e.ItemId, "IX_WorkOrderBatchAssemblyComponents_ItemId");

            entity.HasIndex(e => e.WorkOrderBatchAssemblyId, "IX_WorkOrderBatchAssemblyComponents_WorkOrderBatchAssemblyId");

            entity.HasOne(d => d.Bin).WithMany(p => p.WorkOrderBatchAssemblyComponents).HasForeignKey(d => d.BinId);

            entity.HasOne(d => d.Item).WithMany(p => p.WorkOrderBatchAssemblyComponents).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.WorkOrderBatchAssembly).WithMany(p => p.WorkOrderBatchAssemblyComponents).HasForeignKey(d => d.WorkOrderBatchAssemblyId);
        });

        modelBuilder.Entity<WorkOrderBatchComponent>(entity =>
        {
            entity.HasIndex(e => e.BinId, "IX_WorkOrderBatchComponents_BinId");

            entity.HasIndex(e => e.ItemId, "IX_WorkOrderBatchComponents_ItemId");

            entity.HasIndex(e => e.WorkOrderBatchId, "IX_WorkOrderBatchComponents_WorkOrderBatchId");

            entity.HasOne(d => d.Bin).WithMany(p => p.WorkOrderBatchComponents).HasForeignKey(d => d.BinId);

            entity.HasOne(d => d.Item).WithMany(p => p.WorkOrderBatchComponents).HasForeignKey(d => d.ItemId);

            entity.HasOne(d => d.WorkOrderBatch).WithMany(p => p.WorkOrderBatchComponents).HasForeignKey(d => d.WorkOrderBatchId);
        });

        modelBuilder.Entity<ZipCode>(entity =>
        {
            entity.HasIndex(e => e.StateId, "IX_ZipCodes_StateId");

            entity.HasOne(d => d.State).WithMany(p => p.ZipCodes).HasForeignKey(d => d.StateId);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
