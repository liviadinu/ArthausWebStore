using ArthausWebStore.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore
{
    public class ArthausBackOfficeContext : DbContext
    {
        public ArthausBackOfficeContext()
        {
        }

        public ArthausBackOfficeContext(DbContextOptions<ArthausBackOfficeContext> options)
            : base(options)
        {
        }
        public virtual DbSet<Customer> Customer { get; set; }
        public virtual DbSet<Item> Item { get; set; }
        public virtual DbSet<ItemAttributes> ItemAttributes { get; set; }
        public virtual DbSet<ItemBrands> ItemBrands { get; set; }
        public virtual DbSet<ItemCategory> ItemCategory { get; set; }
        public virtual DbSet<ItemDivisions> ItemDivisions { get; set; }
        public virtual DbSet<ItemLedgerEntry> ItemLedgerEntry { get; set; }
        public virtual DbSet<ItemMeasurement> ItemMeasurement { get; set; }
        public virtual DbSet<ItemPrices> ItemPrices { get; set; }
        public virtual DbSet<ItemPromotions> ItemPromotions { get; set; }
        public virtual DbSet<ItemStockLevels> ItemStockLevels { get; set; }
        public virtual DbSet<ItemVendor> ItemVendor { get; set; }
        public virtual DbSet<PayableVendorLedgerEntry> PayableVendorLedgerEntry { get; set; }
        public virtual DbSet<ReturnPolicy> ReturnPolicy { get; set; }
        public virtual DbSet<ReturnReason> ReturnReason { get; set; }
        public virtual DbSet<ReturnReceiptHeader> ReturnReceiptHeader { get; set; }
        public virtual DbSet<ReturnReceiptLine> ReturnReceiptLine { get; set; }
        public virtual DbSet<ReturnShipmentHeader> ReturnShipmentHeader { get; set; }
        public virtual DbSet<ReturnShipmentLine> ReturnShipmentLine { get; set; }
        public virtual DbSet<ReturnsRelatedDocument> ReturnsRelatedDocument { get; set; }
        public virtual DbSet<SalesHeader> SalesHeader { get; set; }
        public virtual DbSet<SalesInvoiceHeader> SalesInvoiceHeader { get; set; }
        public virtual DbSet<SalesInvoiceLine> SalesInvoiceLine { get; set; }
        public virtual DbSet<SalesLine> SalesLine { get; set; }
        public virtual DbSet<SalesPrepayment> SalesPrepayment { get; set; }
        public virtual DbSet<SalesShipmentHeader> SalesShipmentHeader { get; set; }
        public virtual DbSet<SalesShipmentLine> SalesShipmentLine { get; set; }
        public virtual DbSet<SalesStatistics> SalesStatistics { get; set; }
        public virtual DbSet<ServiceBookings> ServiceBookings { get; set; }
        public virtual DbSet<ServiceContractHeader> ServiceContractHeader { get; set; }
        public virtual DbSet<ServiceContractLine> ServiceContractLine { get; set; }
        public virtual DbSet<ServiceHeader> ServiceHeader { get; set; }
        public virtual DbSet<ServiceInvoiceHeader> ServiceInvoiceHeader { get; set; }
        public virtual DbSet<ServiceInvoiceLine> ServiceInvoiceLine { get; set; }
        public virtual DbSet<ServiceItem> ServiceItem { get; set; }
        public virtual DbSet<ServiceItemLine> ServiceItemLine { get; set; }
        public virtual DbSet<ServiceLedgerEntry> ServiceLedgerEntry { get; set; }
        public virtual DbSet<ServiceLine> ServiceLine { get; set; }
        public virtual DbSet<ServiceOrder> ServiceOrder { get; set; }
        public virtual DbSet<ServiceOrderAllocation> ServiceOrderAllocation { get; set; }
        public virtual DbSet<ServiceOrderItems> ServiceOrderItems { get; set; }
        public virtual DbSet<ServiceOrderStatus> ServiceOrderStatus { get; set; }
        public virtual DbSet<ServiceOrderType> ServiceOrderType { get; set; }
        public virtual DbSet<ServicePriceGroup> ServicePriceGroup { get; set; }
        public virtual DbSet<ServiceProduct> ServiceProduct { get; set; }
        public virtual DbSet<ServiceProductType> ServiceProductType { get; set; }
        public virtual DbSet<ServiceProvider> ServiceProvider { get; set; }
        public virtual DbSet<ShippingAgent> ShippingAgent { get; set; }
        public virtual DbSet<ShippingAgentServices> ShippingAgentServices { get; set; }
        public virtual DbSet<Vendor> Vendor { get; set; }
        public virtual DbSet<VendorLedgerEntry> VendorLedgerEntry { get; set; }
        public virtual DbSet<Visitors> Visitors { get; set; }
        public virtual DbSet<WarehouseActivityHeader> WarehouseActivityHeader { get; set; }
        public virtual DbSet<WarehouseActivityLine> WarehouseActivityLine { get; set; }
        public virtual DbSet<WarehouseShipmentHeader> WarehouseShipmentHeader { get; set; }
        public virtual DbSet<WarehouseShipmentLine> WarehouseShipmentLine { get; set; }
        public virtual DbSet<WhseInternalPickHeader> WhseInternalPickHeader { get; set; }
        public virtual DbSet<WhseInternalPickLine> WhseInternalPickLine { get; set; }
        public virtual DbSet<ItemVariant> ItemVariants { get; set; }
        public virtual DbSet<ErrorLog> ErrorLog { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustLedgerEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo);

                entity.ToTable("Cust_ Ledger Entry");

                entity.HasIndex(e => new { e.ClosedByEntryNo, e.EntryNo })
                    .HasName("$9")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerPostingGroup, e.EntryNo })
                    .HasName("$19")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentNo, e.EntryNo })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.ExternalDocumentNo, e.EntryNo })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.TransactionNo, e.EntryNo })
                    .HasName("$10")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.PostingDate, e.EntryNo })
                    .HasName("$17")
                    .IsUnique();

                entity.HasIndex(e => new { e.Open, e.DueDate, e.EntryNo })
                    .HasName("$6")
                    .IsUnique();

                entity.HasIndex(e => new { e.SalespersonCode, e.PostingDate, e.EntryNo })
                    .HasName("$8")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerNo, e.PostingDate, e.CurrencyCode, e.EntryNo })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.CustomerNo, e.Open, e.EntryNo })
                    .HasName("$18")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerNo, e.AppliesToId, e.Open, e.Positive, e.DueDate, e.EntryNo })
                    .HasName("$16")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerNo, e.Open, e.Positive, e.DueDate, e.CurrencyCode, e.EntryNo })
                    .HasName("$5")
                    .IsUnique();

                entity.Property(e => e.EntryNo)
                    .HasColumnName("Entry No_")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptedPaymentTolerance)
                    .HasColumnName("Accepted Payment Tolerance")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AcceptedPmtDiscTolerance).HasColumnName("Accepted Pmt_ Disc_ Tolerance");

                entity.Property(e => e.AdjustedCurrencyFactor)
                    .HasColumnName("Adjusted Currency Factor")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AmountToApply)
                    .HasColumnName("Amount to Apply")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AppliesToDocNo)
                    .IsRequired()
                    .HasColumnName("Applies-to Doc_ No_")
                    .HasMaxLength(20);

                entity.Property(e => e.AppliesToDocType).HasColumnName("Applies-to Doc_ Type");

                entity.Property(e => e.AppliesToExtDocNo)
                    .IsRequired()
                    .HasColumnName("Applies-to Ext_ Doc_ No_")
                    .HasMaxLength(35);

                entity.Property(e => e.AppliesToId)
                    .IsRequired()
                    .HasColumnName("Applies-to ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ApplyingEntry).HasColumnName("Applying Entry");

                entity.Property(e => e.BalAccountNo)
                    .IsRequired()
                    .HasColumnName("Bal_ Account No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BalAccountType).HasColumnName("Bal_ Account Type");

                entity.Property(e => e.BatchNo)
                    .IsRequired()
                    .HasColumnName("Batch No_")
                    .HasMaxLength(10);

                entity.Property(e => e.CalculateInterest).HasColumnName("Calculate Interest");

                entity.Property(e => e.ClosedAtDate)
                    .HasColumnName("Closed at Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClosedByAmount)
                    .HasColumnName("Closed by Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ClosedByAmountLcy)
                    .HasColumnName("Closed by Amount (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ClosedByCurrencyAmount)
                    .HasColumnName("Closed by Currency Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ClosedByCurrencyCode)
                    .IsRequired()
                    .HasColumnName("Closed by Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ClosedByEntryNo).HasColumnName("Closed by Entry No_");

                entity.Property(e => e.ClosingInterestCalculated).HasColumnName("Closing Interest Calculated");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CustomerNo)
                    .IsRequired()
                    .HasColumnName("Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPostingGroup)
                    .IsRequired()
                    .HasColumnName("Customer Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.DirectDebitMandateId)
                    .IsRequired()
                    .HasColumnName("Direct Debit Mandate ID")
                    .HasMaxLength(35);

                entity.Property(e => e.DocumentDate)
                    .HasColumnName("Document Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasColumnName("Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.DocumentType).HasColumnName("Document Type");

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExportedToPaymentFile).HasColumnName("Exported to Payment File");

                entity.Property(e => e.ExternalDocumentNo)
                    .IsRequired()
                    .HasColumnName("External Document No_")
                    .HasMaxLength(35);

                entity.Property(e => e.GlobalDimension1Code)
                    .IsRequired()
                    .HasColumnName("Global Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.GlobalDimension2Code)
                    .IsRequired()
                    .HasColumnName("Global Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.IcPartnerCode)
                    .IsRequired()
                    .HasColumnName("IC Partner Code")
                    .HasMaxLength(20);

                entity.Property(e => e.InvDiscountLcy)
                    .HasColumnName("Inv_ Discount (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.JournalBatchName)
                    .IsRequired()
                    .HasColumnName("Journal Batch Name")
                    .HasMaxLength(10);

                entity.Property(e => e.LastIssuedReminderLevel).HasColumnName("Last Issued Reminder Level");

                entity.Property(e => e.MaxPaymentTolerance)
                    .HasColumnName("Max_ Payment Tolerance")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.MessageToRecipient)
                    .IsRequired()
                    .HasColumnName("Message to Recipient")
                    .HasMaxLength(140);

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.OnHold)
                    .IsRequired()
                    .HasColumnName("On Hold")
                    .HasMaxLength(3);

                entity.Property(e => e.OriginalCurrencyFactor)
                    .HasColumnName("Original Currency Factor")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.OriginalPmtDiscPossible)
                    .HasColumnName("Original Pmt_ Disc_ Possible")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PaymentMethodCode)
                    .IsRequired()
                    .HasColumnName("Payment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PmtDiscGivenLcy)
                    .HasColumnName("Pmt_ Disc_ Given (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PmtDiscToleranceDate)
                    .HasColumnName("Pmt_ Disc_ Tolerance Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PmtDiscountDate)
                    .HasColumnName("Pmt_ Discount Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PmtToleranceLcy)
                    .HasColumnName("Pmt_ Tolerance (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProfitLcy)
                    .HasColumnName("Profit (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasColumnName("Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.RecipientBankAccount)
                    .IsRequired()
                    .HasColumnName("Recipient Bank Account")
                    .HasMaxLength(20);

                entity.Property(e => e.RemainingPmtDiscPossible)
                    .HasColumnName("Remaining Pmt_ Disc_ Possible")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReversedByEntryNo).HasColumnName("Reversed by Entry No_");

                entity.Property(e => e.ReversedEntryNo).HasColumnName("Reversed Entry No_");

                entity.Property(e => e.SalesLcy)
                    .HasColumnName("Sales (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.SalespersonCode)
                    .IsRequired()
                    .HasColumnName("Salesperson Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToContactNo)
                    .IsRequired()
                    .HasColumnName("Sell-to Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasColumnName("Source Code")
                    .HasMaxLength(10);

                entity.Property(e => e.StatementNo)
                    .IsRequired()
                    .HasColumnName("Statement No_")
                    .HasMaxLength(20);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionNo).HasColumnName("Transaction No_");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User ID")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Customer>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.HasIndex(e => new { e.City, e.No })
                    .HasName("$9")
                    .IsUnique();

                entity.HasIndex(e => new { e.Contact, e.No })
                    .HasName("$12")
                    .IsUnique();

                entity.HasIndex(e => new { e.CountryRegionCode, e.No })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.CurrencyCode, e.No })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerPostingGroup, e.No })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.GenBusPostingGroup, e.No })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.Name, e.No })
                    .HasName("$8")
                    .IsUnique();

                entity.HasIndex(e => new { e.PhoneNo, e.No })
                    .HasName("$11")
                    .IsUnique();

                entity.HasIndex(e => new { e.RetailCustomerGroup, e.No })
                    .HasName("$14")
                    .IsUnique();

                entity.HasIndex(e => new { e.SearchName, e.No })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.VatRegistrationNo, e.No })
                    .HasName("$7")
                    .IsUnique();

                entity.HasIndex(e => new { e.Address, e.PostCode, e.No })
                    .HasName("$13")
                    .IsUnique();

                entity.HasIndex(e => new { e.PostCode, e.Address, e.No })
                    .HasName("$10")
                    .IsUnique();

                entity.HasIndex(e => new { e.Name, e.Address, e.City, e.No })
                    .HasName("$6")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnName("Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ApplicationMethod).HasColumnName("Application Method");

                entity.Property(e => e.BaseCalendarCode)
                    .IsRequired()
                    .HasColumnName("Base Calendar Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BlockPaymentTolerance).HasColumnName("Block Payment Tolerance");

                entity.Property(e => e.BudgetedAmount)
                    .HasColumnName("Budgeted Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CashFlowPaymentTermsCode)
                    .IsRequired()
                    .HasColumnName("Cash Flow Payment Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ChainName)
                    .IsRequired()
                    .HasColumnName("Chain Name")
                    .HasMaxLength(10);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CollectionMethod)
                    .IsRequired()
                    .HasColumnName("Collection Method")
                    .HasMaxLength(20);

                entity.Property(e => e.CombineShipments).HasColumnName("Combine Shipments");

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ContactGraphId)
                    .IsRequired()
                    .HasColumnName("Contact Graph Id")
                    .HasMaxLength(250);

                entity.Property(e => e.ContactId).HasColumnName("Contact ID");

                entity.Property(e => e.ContactType).HasColumnName("Contact Type");

                entity.Property(e => e.CopySellToAddrToQteFrom).HasColumnName("Copy Sell-to Addr_ to Qte From");

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.County)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CreatedByUser)
                    .IsRequired()
                    .HasColumnName("Created by User")
                    .HasMaxLength(50);

                entity.Property(e => e.CreditLimitLcy)
                    .HasColumnName("Credit Limit (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyId).HasColumnName("Currency Id");

                entity.Property(e => e.CustomerDiscGroup)
                    .IsRequired()
                    .HasColumnName("Customer Disc_ Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerId)
                    .IsRequired()
                    .HasColumnName("Customer ID")
                    .HasMaxLength(10);

                entity.Property(e => e.CustomerPostingGroup)
                    .IsRequired()
                    .HasColumnName("Customer Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPriceGroup)
                    .IsRequired()
                    .HasColumnName("Customer Price Group")
                    .HasMaxLength(10);

                entity.Property(e => e.DateCreated)
                    .HasColumnName("Date Created")
                    .HasColumnType("datetime");

                entity.Property(e => e.DaytimePhoneNo)
                    .IsRequired()
                    .HasColumnName("Daytime Phone No_")
                    .HasMaxLength(30);

                entity.Property(e => e.DefaultWeight)
                    .HasColumnName("Default Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DocumentSendingProfile)
                    .IsRequired()
                    .HasColumnName("Document Sending Profile")
                    .HasMaxLength(20);

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("E-Mail")
                    .HasMaxLength(80);

                entity.Property(e => e.FaxNo)
                    .IsRequired()
                    .HasColumnName("Fax No_")
                    .HasMaxLength(30);

                entity.Property(e => e.FinChargeTermsCode)
                    .IsRequired()
                    .HasColumnName("Fin_ Charge Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.Gln)
                    .IsRequired()
                    .HasColumnName("GLN")
                    .HasMaxLength(13);

                entity.Property(e => e.GlobalDimension1Code)
                    .IsRequired()
                    .HasColumnName("Global Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.GlobalDimension2Code)
                    .IsRequired()
                    .HasColumnName("Global Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.HomePage)
                    .IsRequired()
                    .HasColumnName("Home Page")
                    .HasMaxLength(80);

                entity.Property(e => e.HouseNo)
                    .IsRequired()
                    .HasColumnName("House No_")
                    .HasMaxLength(30);

                entity.Property(e => e.IcPartnerCode)
                    .IsRequired()
                    .HasColumnName("IC Partner Code")
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceCopies).HasColumnName("Invoice Copies");

                entity.Property(e => e.InvoiceDiscCode)
                    .IsRequired()
                    .HasColumnName("Invoice Disc_ Code")
                    .HasMaxLength(20);

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasColumnName("Language Code")
                    .HasMaxLength(10);

                entity.Property(e => e.LastDateModified)
                    .HasColumnName("Last Date Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDateTime)
                    .HasColumnName("Last Modified Date Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastStatementNo).HasColumnName("Last Statement No_");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MobilePhoneNo)
                    .IsRequired()
                    .HasColumnName("Mobile Phone No_")
                    .HasMaxLength(30);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name2)
                    .IsRequired()
                    .HasColumnName("Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.OtherTenderInFinalizing).HasColumnName("Other Tender in Finalizing");

                entity.Property(e => e.OurAccountNo)
                    .IsRequired()
                    .HasColumnName("Our Account No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PartnerType).HasColumnName("Partner Type");

                entity.Property(e => e.PaymentMethodCode)
                    .IsRequired()
                    .HasColumnName("Payment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentMethodId).HasColumnName("Payment Method Id");

                entity.Property(e => e.PaymentTermsCode)
                    .IsRequired()
                    .HasColumnName("Payment Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentTermsId).HasColumnName("Payment Terms Id");

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasColumnName("Phone No_")
                    .HasMaxLength(30);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.PlaceOfExport)
                    .IsRequired()
                    .HasColumnName("Place of Export")
                    .HasMaxLength(20);

                entity.Property(e => e.PostAsShipment).HasColumnName("Post as Shipment");

                entity.Property(e => e.PostCode)
                    .IsRequired()
                    .HasColumnName("Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PreferredBankAccountCode)
                    .IsRequired()
                    .HasColumnName("Preferred Bank Account Code")
                    .HasMaxLength(20);

                entity.Property(e => e.Prepayment)
                    .HasColumnName("Prepayment _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PricesIncludingVat).HasColumnName("Prices Including VAT");

                entity.Property(e => e.PrimaryContactNo)
                    .IsRequired()
                    .HasColumnName("Primary Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PrintDocumentInvoice).HasColumnName("Print Document Invoice");

                entity.Property(e => e.PrintStatements).HasColumnName("Print Statements");

                entity.Property(e => e.PrivacyBlocked).HasColumnName("Privacy Blocked");

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasColumnName("Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ReminderTermsCode)
                    .IsRequired()
                    .HasColumnName("Reminder Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.RestrictionFunctionality).HasColumnName("Restriction Functionality");

                entity.Property(e => e.RetailCustomerGroup)
                    .IsRequired()
                    .HasColumnName("Retail Customer Group")
                    .HasMaxLength(10);

                entity.Property(e => e.SalespersonCode)
                    .IsRequired()
                    .HasColumnName("Salesperson Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SearchName)
                    .IsRequired()
                    .HasColumnName("Search Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceZoneCode)
                    .IsRequired()
                    .HasColumnName("Service Zone Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipmentMethodCode)
                    .IsRequired()
                    .HasColumnName("Shipment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipmentMethodId).HasColumnName("Shipment Method Id");

                entity.Property(e => e.ShippingAdvice).HasColumnName("Shipping Advice");

                entity.Property(e => e.ShippingAgentCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Service Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingTime)
                    .IsRequired()
                    .HasColumnName("Shipping Time")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.StatisticsGroup).HasColumnName("Statistics Group");

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxAreaId).HasColumnName("Tax Area ID");

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.TelexAnswerBack)
                    .IsRequired()
                    .HasColumnName("Telex Answer Back")
                    .HasMaxLength(20);

                entity.Property(e => e.TelexNo)
                    .IsRequired()
                    .HasColumnName("Telex No_")
                    .HasMaxLength(20);

                entity.Property(e => e.TerritoryCode)
                    .IsRequired()
                    .HasColumnName("Territory Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionLimit)
                    .HasColumnName("Transaction Limit")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ValidateEuVatRegNo).HasColumnName("Validate EU Vat Reg_ No_");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatRegistrationNo)
                    .IsRequired()
                    .HasColumnName("VAT Registration No_")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CustomerOrderDiscountLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentId, e.LineNo, e.EntryNo });

                entity.ToTable("Customer Order Discount Line");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("Document Id")
                    .HasMaxLength(40);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.EntryNo).HasColumnName("Entry No_");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DiscountAmount)
                    .HasColumnName("Discount Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DiscountPercent)
                    .HasColumnName("Discount Percent")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DiscountType).HasColumnName("Discount Type");

                entity.Property(e => e.OfferNo)
                    .IsRequired()
                    .HasColumnName("Offer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PeriodicDiscGroup)
                    .IsRequired()
                    .HasColumnName("Periodic Disc_ Group")
                    .HasMaxLength(20);

                entity.Property(e => e.PeriodicDiscType).HasColumnName("Periodic Disc_ Type");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<CustomerOrderHeader>(entity =>
            {
                entity.HasKey(e => e.DocumentId);

                entity.ToTable("Customer Order Header");

                entity.HasIndex(e => new { e.ReceiptNo, e.DocumentId })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.WebTransGuid, e.DocumentId })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.StoreNo, e.Status, e.DocumentId })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.DocumentId)
                    .HasColumnName("Document Id")
                    .HasMaxLength(40)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnName("Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.AnonymousOrder).HasColumnName("Anonymous Order");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ClickAndCollectOrder).HasColumnName("Click And Collect Order");

                entity.Property(e => e.CollectLocation)
                    .IsRequired()
                    .HasColumnName("Collect Location")
                    .HasMaxLength(20);

                entity.Property(e => e.CollectTimeLimit)
                    .HasColumnName("Collect Time Limit")
                    .HasColumnType("datetime");

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Country Region Code")
                    .HasMaxLength(20);

                entity.Property(e => e.County)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CreatedAtStore)
                    .IsRequired()
                    .HasColumnName("Created at Store")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyFactor)
                    .HasColumnName("Currency Factor")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CustDiscGroup)
                    .IsRequired()
                    .HasColumnName("Cust_ Disc_ Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerNo)
                    .IsRequired()
                    .HasColumnName("Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.DaytimePhoneNo)
                    .IsRequired()
                    .HasColumnName("Daytime Phone No_")
                    .HasMaxLength(30);

                entity.Property(e => e.DocumentDateTime)
                    .HasColumnName("Document DateTime")
                    .HasColumnType("datetime");

                entity.Property(e => e.Email)
                    .IsRequired()
                    .HasMaxLength(80);

                entity.Property(e => e.FullName)
                    .IsRequired()
                    .HasColumnName("Full Name")
                    .HasMaxLength(50);

                entity.Property(e => e.HouseApartmentNo)
                    .IsRequired()
                    .HasColumnName("House Apartment No_")
                    .HasMaxLength(30);

                entity.Property(e => e.InventoryTransfer).HasColumnName("Inventory Transfer");

                entity.Property(e => e.MemberCardNo)
                    .IsRequired()
                    .HasColumnName("Member Card No_")
                    .HasMaxLength(100);

                entity.Property(e => e.MemberContactName)
                    .IsRequired()
                    .HasColumnName("Member Contact Name")
                    .HasMaxLength(50);

                entity.Property(e => e.MemberContactNo)
                    .IsRequired()
                    .HasColumnName("Member Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.MobilePhoneNo)
                    .IsRequired()
                    .HasColumnName("Mobile Phone No_")
                    .HasMaxLength(30);

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasColumnName("Phone No_")
                    .HasMaxLength(30);

                entity.Property(e => e.PostCode)
                    .IsRequired()
                    .HasColumnName("Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PriceGroupCode)
                    .IsRequired()
                    .HasColumnName("Price Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ReceiptNo)
                    .IsRequired()
                    .HasColumnName("Receipt No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SalesOrderNo)
                    .IsRequired()
                    .HasColumnName("Sales Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipOrder).HasColumnName("Ship Order");

                entity.Property(e => e.ShipOrderPosFlag)
                    .IsRequired()
                    .HasColumnName("Ship Order POS Flag")
                    .HasMaxLength(100);

                entity.Property(e => e.ShipToAddress)
                    .IsRequired()
                    .HasColumnName("Ship To Address")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToAddress2)
                    .IsRequired()
                    .HasColumnName("Ship To Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCity)
                    .IsRequired()
                    .HasColumnName("Ship To City")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Ship To Country Region Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipToCounty)
                    .IsRequired()
                    .HasColumnName("Ship To County")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToEmail)
                    .IsRequired()
                    .HasColumnName("Ship To Email")
                    .HasMaxLength(80);

                entity.Property(e => e.ShipToFullName)
                    .IsRequired()
                    .HasColumnName("Ship To Full Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToHouseApartmentNo)
                    .IsRequired()
                    .HasColumnName("Ship To House Apartment No_")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToPhoneNo)
                    .IsRequired()
                    .HasColumnName("Ship To Phone No_")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToPostCode)
                    .IsRequired()
                    .HasColumnName("Ship To Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippingAgentCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Service Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SourceType).HasColumnName("Source Type");

                entity.Property(e => e.SourcingLocation)
                    .IsRequired()
                    .HasColumnName("Sourcing Location")
                    .HasMaxLength(10);

                entity.Property(e => e.SourcingOrder).HasColumnName("Sourcing Order");

                entity.Property(e => e.StatusInfo).HasColumnName("Status Info");

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasColumnName("Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.TerminalNo)
                    .IsRequired()
                    .HasColumnName("Terminal No_")
                    .HasMaxLength(10);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransStoreNo)
                    .IsRequired()
                    .HasColumnName("Trans_ Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.TransTerminalNo)
                    .IsRequired()
                    .HasColumnName("Trans_ Terminal No_")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionNo).HasColumnName("Transaction No_");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Vat Bus_ Posting Group")
                    .HasMaxLength(10);

                entity.Property(e => e.WebTransGuid).HasColumnName("Web Trans_ GUID");
            });

            modelBuilder.Entity<CustomerOrderLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentId, e.LineNo });

                entity.ToTable("Customer Order Line");

                entity.HasIndex(e => new { e.SourcingLocation, e.DocumentId, e.LineNo })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentId, e.Number, e.VariantCode, e.UnitOfMeasureCode, e.LineNo })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.DocumentId)
                    .HasColumnName("Document Id")
                    .HasMaxLength(40);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnName("Discount Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DiscountPercent)
                    .HasColumnName("Discount Percent")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.InternalAvailableQty)
                    .HasColumnName("Internal Available Qty_")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.InternalSelection).HasColumnName("Internal Selection");

                entity.Property(e => e.InventoryTransfer).HasColumnName("Inventory Transfer");

                entity.Property(e => e.ItemDescription)
                    .IsRequired()
                    .HasColumnName("Item Description")
                    .HasMaxLength(50);

                entity.Property(e => e.LineType).HasColumnName("Line Type");

                entity.Property(e => e.NetAmount)
                    .HasColumnName("Net Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.NetPrice)
                    .HasColumnName("Net Price")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Number)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.OrderReference)
                    .IsRequired()
                    .HasColumnName("Order Reference")
                    .HasMaxLength(50);

                entity.Property(e => e.OriginalLineNo).HasColumnName("Original Line No_");

                entity.Property(e => e.Price).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.SourcingLocation)
                    .IsRequired()
                    .HasColumnName("Sourcing Location")
                    .HasMaxLength(10);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasColumnName("Unit of Measure Code")
                    .HasMaxLength(10);

                entity.Property(e => e.UoMDescription)
                    .IsRequired()
                    .HasColumnName("UoM Description")
                    .HasMaxLength(50);

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VariantDescription)
                    .IsRequired()
                    .HasColumnName("Variant Description")
                    .HasMaxLength(50);

                entity.Property(e => e.VatAmount)
                    .HasColumnName("Vat Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("Vat Prod_ Posting Group")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<CustomerOrderPayment>(entity =>
            {
                entity.HasKey(e => new { e.DocumentId, e.StoreNo, e.LineNo });

                entity.ToTable("Customer Order Payment");

                entity.Property(e => e.DocumentId)
                    .HasColumnName("Document Id")
                    .HasMaxLength(40);

                entity.Property(e => e.StoreNo)
                    .HasColumnName("Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.AuthorisationCode)
                    .IsRequired()
                    .HasColumnName("Authorisation Code")
                    .HasMaxLength(30);

                entity.Property(e => e.CardOrCustomerNumber)
                    .IsRequired()
                    .HasColumnName("Card or Customer number")
                    .HasMaxLength(100);

                entity.Property(e => e.CardType)
                    .IsRequired()
                    .HasColumnName("Card Type")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyFactor)
                    .HasColumnName("Currency Factor")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.FinalisedAmount)
                    .HasColumnName("Finalised Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.FinalisedAmountLcy)
                    .HasColumnName("Finalised Amount LCY")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.IncomeExpenseAccountNo)
                    .IsRequired()
                    .HasColumnName("Income_Expense Account No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LoyaltyPointPayment).HasColumnName("Loyalty Point payment");

                entity.Property(e => e.PreApprovedAmount)
                    .HasColumnName("Pre Approved Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PreApprovedAmountLcy)
                    .HasColumnName("Pre Approved Amount LCY")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PreApprovedValidDate)
                    .HasColumnName("Pre Approved Valid Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TenderType)
                    .IsRequired()
                    .HasColumnName("Tender Type")
                    .HasMaxLength(10);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<DetailedCustLedgEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo);

                entity.ToTable("Detailed Cust_ Ledg_Entry");

                entity.HasIndex(e => new { e.AppliedCustLedgerEntryNo, e.EntryType, e.EntryNo })
                    .HasName("$7")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustLedgerEntryNo, e.PostingDate, e.EntryNo })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ApplicationNo, e.CustomerNo, e.EntryType, e.EntryNo })
                    .HasName("$9")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentNo, e.DocumentType, e.PostingDate, e.EntryNo })
                    .HasName("$6")
                    .IsUnique();

                entity.HasIndex(e => new { e.TransactionNo, e.CustomerNo, e.EntryType, e.EntryNo })
                    .HasName("$8")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerNo, e.EntryType, e.PostingDate, e.InitialDocumentType, e.EntryNo })
                    .HasName("$10")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerNo, e.CurrencyCode, e.InitialEntryGlobalDim1, e.InitialEntryGlobalDim2, e.InitialEntryDueDate, e.PostingDate, e.EntryNo })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.InitialDocumentType, e.EntryType, e.CustomerNo, e.CurrencyCode, e.InitialEntryGlobalDim1, e.InitialEntryGlobalDim2, e.PostingDate, e.EntryNo })
                    .HasName("$4")
                    .IsUnique();

                entity.Property(e => e.EntryNo)
                    .HasColumnName("Entry No_")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("Amount (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ApplicationNo).HasColumnName("Application No_");

                entity.Property(e => e.AppliedCustLedgerEntryNo).HasColumnName("Applied Cust_ Ledger Entry No_");

                entity.Property(e => e.CreditAmount)
                    .HasColumnName("Credit Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CreditAmountLcy)
                    .HasColumnName("Credit Amount (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CustLedgerEntryNo).HasColumnName("Cust_ Ledger Entry No_");

                entity.Property(e => e.CustomerNo)
                    .IsRequired()
                    .HasColumnName("Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.DebitAmount)
                    .HasColumnName("Debit Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DebitAmountLcy)
                    .HasColumnName("Debit Amount (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasColumnName("Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.DocumentType).HasColumnName("Document Type");

                entity.Property(e => e.EntryType).HasColumnName("Entry Type");

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GenProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.InitialDocumentType).HasColumnName("Initial Document Type");

                entity.Property(e => e.InitialEntryDueDate)
                    .HasColumnName("Initial Entry Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InitialEntryGlobalDim1)
                    .IsRequired()
                    .HasColumnName("Initial Entry Global Dim_ 1")
                    .HasMaxLength(20);

                entity.Property(e => e.InitialEntryGlobalDim2)
                    .IsRequired()
                    .HasColumnName("Initial Entry Global Dim_ 2")
                    .HasMaxLength(20);

                entity.Property(e => e.JournalBatchName)
                    .IsRequired()
                    .HasColumnName("Journal Batch Name")
                    .HasMaxLength(10);

                entity.Property(e => e.LedgerEntryAmount).HasColumnName("Ledger Entry Amount");

                entity.Property(e => e.MaxPaymentTolerance)
                    .HasColumnName("Max_ Payment Tolerance")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasColumnName("Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.RemainingPmtDiscPossible)
                    .HasColumnName("Remaining Pmt_ Disc_ Possible")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasColumnName("Source Code")
                    .HasMaxLength(10);

                entity.Property(e => e.TaxJurisdictionCode)
                    .IsRequired()
                    .HasColumnName("Tax Jurisdiction Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionNo).HasColumnName("Transaction No_");

                entity.Property(e => e.UnappliedByEntryNo).HasColumnName("Unapplied by Entry No_");

                entity.Property(e => e.UseTax).HasColumnName("Use Tax");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User ID")
                    .HasMaxLength(50);

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Prod_ Posting Group")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<DetailedVendorLedgEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo);

                entity.ToTable("Detailed Vendor Ledg_Entry");

                entity.HasIndex(e => new { e.AppliedVendLedgerEntryNo, e.EntryType, e.EntryNo })
                    .HasName("$7")
                    .IsUnique();

                entity.HasIndex(e => new { e.VendorLedgerEntryNo, e.PostingDate, e.EntryNo })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ApplicationNo, e.VendorNo, e.EntryType, e.EntryNo })
                    .HasName("$9")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentNo, e.DocumentType, e.PostingDate, e.EntryNo })
                    .HasName("$6")
                    .IsUnique();

                entity.HasIndex(e => new { e.TransactionNo, e.VendorNo, e.EntryType, e.EntryNo })
                    .HasName("$8")
                    .IsUnique();

                entity.HasIndex(e => new { e.VendorNo, e.CurrencyCode, e.InitialEntryGlobalDim1, e.InitialEntryGlobalDim2, e.InitialEntryDueDate, e.PostingDate, e.EntryNo })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.InitialDocumentType, e.EntryType, e.VendorNo, e.CurrencyCode, e.InitialEntryGlobalDim1, e.InitialEntryGlobalDim2, e.PostingDate, e.EntryNo })
                    .HasName("$4")
                    .IsUnique();

                entity.Property(e => e.EntryNo)
                    .HasColumnName("Entry No_")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("Amount (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ApplicationNo).HasColumnName("Application No_");

                entity.Property(e => e.AppliedVendLedgerEntryNo).HasColumnName("Applied Vend_ Ledger Entry No_");

                entity.Property(e => e.CreditAmount)
                    .HasColumnName("Credit Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CreditAmountLcy)
                    .HasColumnName("Credit Amount (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.DebitAmount)
                    .HasColumnName("Debit Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DebitAmountLcy)
                    .HasColumnName("Debit Amount (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasColumnName("Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.DocumentType).HasColumnName("Document Type");

                entity.Property(e => e.EntryType).HasColumnName("Entry Type");

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GenProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.InitialDocumentType).HasColumnName("Initial Document Type");

                entity.Property(e => e.InitialEntryDueDate)
                    .HasColumnName("Initial Entry Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InitialEntryGlobalDim1)
                    .IsRequired()
                    .HasColumnName("Initial Entry Global Dim_ 1")
                    .HasMaxLength(20);

                entity.Property(e => e.InitialEntryGlobalDim2)
                    .IsRequired()
                    .HasColumnName("Initial Entry Global Dim_ 2")
                    .HasMaxLength(20);

                entity.Property(e => e.JournalBatchName)
                    .IsRequired()
                    .HasColumnName("Journal Batch Name")
                    .HasMaxLength(10);

                entity.Property(e => e.LedgerEntryAmount).HasColumnName("Ledger Entry Amount");

                entity.Property(e => e.MaxPaymentTolerance)
                    .HasColumnName("Max_ Payment Tolerance")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasColumnName("Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.RemainingPmtDiscPossible)
                    .HasColumnName("Remaining Pmt_ Disc_ Possible")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasColumnName("Source Code")
                    .HasMaxLength(10);

                entity.Property(e => e.TaxJurisdictionCode)
                    .IsRequired()
                    .HasColumnName("Tax Jurisdiction Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionNo).HasColumnName("Transaction No_");

                entity.Property(e => e.UnappliedByEntryNo).HasColumnName("Unapplied by Entry No_");

                entity.Property(e => e.UseTax).HasColumnName("Use Tax");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User ID")
                    .HasMaxLength(50);

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VendorLedgerEntryNo).HasColumnName("Vendor Ledger Entry No_");

                entity.Property(e => e.VendorNo)
                    .IsRequired()
                    .HasColumnName("Vendor No_")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Item>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseUnitOfMeasure)
                    .IsRequired()
                    .HasColumnName("Base Unit of Measure")
                    .HasMaxLength(10);

                entity.Property(e => e.CostingMethod).HasColumnName("Costing Method");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.LastDirectCost)
                    .HasColumnName("Last Direct Cost")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LifecycleEndingDate)
                    .HasColumnName("Lifecycle Ending Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LifecycleStartingDate)
                    .HasColumnName("Lifecycle Starting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OriginalVendorItemNo)
                    .IsRequired()
                    .HasColumnName("Original Vendor Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OriginalVendorNo)
                    .IsRequired()
                    .HasColumnName("Original Vendor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ProductGroupCode)
                    .IsRequired()
                    .HasColumnName("Product Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ReorderPoint)
                    .HasColumnName("Reorder Point")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReorderQuantity)
                    .HasColumnName("Reorder Quantity")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ServiceItemGroup)
                    .IsRequired()
                    .HasColumnName("Service Item Group")
                    .HasMaxLength(10);

                entity.Property(e => e.StandardCost)
                    .HasColumnName("Standard Cost")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.StatisticsGroup).HasColumnName("Statistics Group");

                entity.Property(e => e.StockoutWarning).HasColumnName("Stockout Warning");

                entity.Property(e => e.TariffNo)
                    .IsRequired()
                    .HasColumnName("Tariff No_")
                    .HasMaxLength(20);

                entity.Property(e => e.UnitCost)
                    .HasColumnName("Unit Cost")
                    .HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<ItemAttributes>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Item Attributes");

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.AlternativeItemNo)
                    .IsRequired()
                    .HasColumnName("Alternative Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.Brand)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Collection)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CollectionYear).HasColumnName("Collection Year");

                entity.Property(e => e.CountryRegionOfOriginCode)
                    .IsRequired()
                    .HasColumnName("Country_Region of Origin Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("Description 2")
                    .HasMaxLength(50);

                entity.Property(e => e.DivisionCode)
                    .IsRequired()
                    .HasColumnName("Division Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ItemCategoryCode)
                    .IsRequired()
                    .HasColumnName("Item Category Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ItemFamilyCode)
                    .IsRequired()
                    .HasColumnName("Item Family Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PurchUnitOfMeasure)
                    .IsRequired()
                    .HasColumnName("Purch_ Unit of Measure")
                    .HasMaxLength(10);

                entity.Property(e => e.RangeCode).HasColumnName("Range Code");

                entity.Property(e => e.RangeStatus).HasColumnName("Range Status");

                entity.Property(e => e.SalesUnitOfMeasure)
                    .IsRequired()
                    .HasColumnName("Sales Unit of Measure")
                    .HasMaxLength(10);

                entity.Property(e => e.SearchDescription)
                    .IsRequired()
                    .HasColumnName("Search Description")
                    .HasMaxLength(50);

                entity.Property(e => e.SeasonCode)
                    .IsRequired()
                    .HasColumnName("Season Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Style)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ItemBrands>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Item Brands");

                entity.Property(e => e.Code)
                    .HasMaxLength(255)
                    .ValueGeneratedNever();

                entity.Property(e => e.CountryOfOrigin)
                    .HasColumnName("Country of Origin")
                    .HasMaxLength(255);

                entity.Property(e => e.Description).HasMaxLength(255);
            });

            modelBuilder.Entity<ItemCategory>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Item Category");

                entity.HasIndex(e => new { e.DivisionCode, e.Code })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DivisionCode)
                    .IsRequired()
                    .HasColumnName("Division Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NotDiscountable).HasColumnName("Not Discountable");

                entity.Property(e => e.PresentationOrder).HasColumnName("Presentation Order");
            });

            modelBuilder.Entity<ItemDivisions>(entity =>
            {
                entity.HasKey(e => e.DivisionCode);

                entity.ToTable("Item Divisions");

                entity.Property(e => e.DivisionCode)
                    .HasColumnName("Division Code")
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.BuyableOnline).HasColumnName("Buyable Online");

                entity.Property(e => e.DivisionDescription)
                    .IsRequired()
                    .HasColumnName("Division Description")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ItemLedgerEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo);

                entity.ToTable("Item Ledger Entry");

                entity.HasIndex(e => new { e.ItemNo, e.EntryNo })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemNo, e.AppliedEntryToAdjust, e.EntryNo })
                    .HasName("$12")
                    .IsUnique();

                entity.HasIndex(e => new { e.CountryRegionCode, e.EntryType, e.PostingDate, e.EntryNo })
                    .HasName("$7")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentNo, e.DocumentType, e.DocumentLineNo, e.EntryNo })
                    .HasName("$8")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemNo, e.LocationCode, e.PostingDate, e.EntryNo })
                    .HasName("$21")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemNo, e.PostingDate, e.EntryType, e.EntryNo })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemNo, e.Positive, e.LocationCode, e.VariantCode, e.EntryNo })
                    .HasName("$13")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrderType, e.OrderNo, e.OrderLineNo, e.EntryType, e.ProdOrderCompLineNo, e.EntryNo })
                    .HasName("$11")
                    .IsUnique();

                entity.HasIndex(e => new { e.SourceType, e.SourceNo, e.ItemNo, e.VariantCode, e.PostingDate, e.EntryNo })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemNo, e.EntryType, e.VariantCode, e.DropShipment, e.LocationCode, e.PostingDate, e.EntryNo })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemNo, e.Open, e.VariantCode, e.Positive, e.LocationCode, e.PostingDate, e.EntryNo })
                    .HasName("$5")
                    .IsUnique();

                entity.Property(e => e.EntryNo)
                    .HasColumnName("Entry No_")
                    .ValueGeneratedNever();

                entity.Property(e => e.AppliedEntryToAdjust).HasColumnName("Applied Entry to Adjust");

                entity.Property(e => e.AppliesToEntry).HasColumnName("Applies-to Entry");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.AssembleToOrder).HasColumnName("Assemble to Order");

                entity.Property(e => e.BatchNo)
                    .IsRequired()
                    .HasColumnName("Batch No_")
                    .HasMaxLength(10);

                entity.Property(e => e.BiTimestamp)
                    .HasColumnName("BI Timestamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompletelyInvoiced).HasColumnName("Completely Invoiced");

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CrossReferenceNo)
                    .IsRequired()
                    .HasColumnName("Cross-Reference No_")
                    .HasMaxLength(20);

                entity.Property(e => e.DerivedFromBlanketOrder).HasColumnName("Derived from Blanket Order");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.DocumentDate)
                    .HasColumnName("Document Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentLineNo).HasColumnName("Document Line No_");

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasColumnName("Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.DocumentType).HasColumnName("Document Type");

                entity.Property(e => e.DropShipment).HasColumnName("Drop Shipment");

                entity.Property(e => e.EntryExitPoint)
                    .IsRequired()
                    .HasColumnName("Entry_Exit Point")
                    .HasMaxLength(10);

                entity.Property(e => e.EntryType).HasColumnName("Entry Type");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExternalDocumentNo)
                    .IsRequired()
                    .HasColumnName("External Document No_")
                    .HasMaxLength(35);

                entity.Property(e => e.GlobalDimension1Code)
                    .IsRequired()
                    .HasColumnName("Global Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.GlobalDimension2Code)
                    .IsRequired()
                    .HasColumnName("Global Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.InvoicedQuantity)
                    .HasColumnName("Invoiced Quantity")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ItemCategoryCode)
                    .IsRequired()
                    .HasColumnName("Item Category Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ItemNo)
                    .IsRequired()
                    .HasColumnName("Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ItemTracking).HasColumnName("Item Tracking");

                entity.Property(e => e.JobNo)
                    .IsRequired()
                    .HasColumnName("Job No_")
                    .HasMaxLength(20);

                entity.Property(e => e.JobPurchase).HasColumnName("Job Purchase");

                entity.Property(e => e.JobTaskNo)
                    .IsRequired()
                    .HasColumnName("Job Task No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LastInvoiceDate)
                    .HasColumnName("Last Invoice Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.LotNo)
                    .IsRequired()
                    .HasColumnName("Lot No_")
                    .HasMaxLength(20);

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.OfferNo)
                    .IsRequired()
                    .HasColumnName("Offer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderLineNo).HasColumnName("Order Line No_");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasColumnName("Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderType).HasColumnName("Order Type");

                entity.Property(e => e.OriginallyOrderedNo)
                    .IsRequired()
                    .HasColumnName("Originally Ordered No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OriginallyOrderedVarCode)
                    .IsRequired()
                    .HasColumnName("Originally Ordered Var_ Code")
                    .HasMaxLength(10);

                entity.Property(e => e.OutOfStockSubstitution).HasColumnName("Out-of-Stock Substitution");

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProdOrderCompLineNo).HasColumnName("Prod_ Order Comp_ Line No_");

                entity.Property(e => e.ProductGroupCode)
                    .IsRequired()
                    .HasColumnName("Product Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PromotionNo)
                    .IsRequired()
                    .HasColumnName("Promotion No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PurchasingCode)
                    .IsRequired()
                    .HasColumnName("Purchasing Code")
                    .HasMaxLength(10);

                entity.Property(e => e.QtyPerUnitOfMeasure)
                    .HasColumnName("Qty_ per Unit of Measure")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.RemainingQuantity)
                    .HasColumnName("Remaining Quantity")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReturnReasonCode)
                    .IsRequired()
                    .HasColumnName("Return Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SerialNo)
                    .IsRequired()
                    .HasColumnName("Serial No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippedQtyNotReturned)
                    .HasColumnName("Shipped Qty_ Not Returned")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.SourceNo)
                    .IsRequired()
                    .HasColumnName("Source No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SourceType).HasColumnName("Source Type");

                entity.Property(e => e.StatementNo)
                    .IsRequired()
                    .HasColumnName("Statement No_")
                    .HasMaxLength(20);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasColumnName("Transaction Specification")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TransferType).HasColumnName("Transfer Type");

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasColumnName("Transport Method")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasColumnName("Unit of Measure Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.WarrantyDate)
                    .HasColumnName("Warranty Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ItemMeasurement>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Item Measurement");

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.Cubage).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Depth).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.GrossWeight)
                    .HasColumnName("Gross Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Height).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Length).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.NetWeight)
                    .HasColumnName("Net Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPerUnitOfMeasure)
                    .HasColumnName("Qty_ per Unit of Measure")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitVolume)
                    .HasColumnName("Unit Volume")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitsPerParcel)
                    .HasColumnName("Units per Parcel")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Weight).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Width).HasColumnType("decimal(38, 20)");
            });


            modelBuilder.Entity<ItemPrices>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Item Prices");

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description).HasMaxLength(50);

                entity.Property(e => e.DiscountPerc)
                    .HasColumnName("Discount Perc.")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.EndDateSales)
                    .HasColumnName("End Date Sales")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxDiscountAllowed)
                    .HasColumnName("Max. Discount Allowed")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.MinQtyForSpecialPrice)
                    .HasColumnName("Min. Qty. for Special Price")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SalesStartDate)
                    .HasColumnName("Sales Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpecialPrice)
                    .HasColumnName("Special Price")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("Unit Price")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitPriceIncludingVat)
                    .HasColumnName("Unit Price Including VAT")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatPerc)
                    .HasColumnName("VAT Perc.")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<ItemPromotions>(entity =>
            {
                entity.HasKey(e => new { e.ItemNo, e.StoreNo, e.StartDate });

                entity.ToTable("Item Promotions");

                entity.Property(e => e.ItemNo)
                    .HasColumnName("Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.StoreNo)
                    .HasColumnName("Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.StartDate)
                    .HasColumnName("Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndDate)
                    .HasColumnName("End Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PromotionQty)
                    .HasColumnName("Promotion (Qty_)")
                    .HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<ItemStockLevels>(entity =>
            {
                entity.HasKey(e => e.ItemNo);

                entity.ToTable("Item Stock Levels");

                entity.Property(e => e.ItemNo)
                    .HasColumnName("Item No_")
                    .HasMaxLength(50)
                    .ValueGeneratedNever();

                entity.Property(e => e.ExpectedReceiptDate)
                    .HasColumnName("Expected Receipt Date")
                    .HasColumnType("date");

                entity.Property(e => e.ExpectedStock)
                    .HasColumnName("Expected Stock")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.SellableStock)
                    .HasColumnName("Sellable Stock")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StockInPicking)
                    .HasColumnName("Stock in Picking")
                    .HasColumnType("decimal(18, 0)");

                entity.Property(e => e.StockOnSalesOrder)
                    .HasColumnName("Stock on Sales Order")
                    .HasColumnType("decimal(18, 0)");
            });

            modelBuilder.Entity<ItemVendor>(entity =>
            {
                entity.HasKey(e => new { e.VendorNo, e.ItemNo, e.VariantCode });

                entity.ToTable("Item Vendor");

                entity.HasIndex(e => new { e.ItemNo, e.VariantCode, e.VendorNo })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.VendorNo, e.VendorItemNo, e.ItemNo, e.VariantCode })
                    .HasName("$2")
                    .IsUnique();

                entity.Property(e => e.VendorNo)
                    .HasColumnName("Vendor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ItemNo)
                    .HasColumnName("Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.VariantCode)
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.FinancialYear).HasColumnName("Financial Year");

                entity.Property(e => e.LeadTimeCalculation)
                    .IsRequired()
                    .HasColumnName("Lead Time Calculation")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PriceType).HasColumnName("Price Type");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.VendorItemNo)
                    .IsRequired()
                    .HasColumnName("Vendor Item No_")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<PayableVendorLedgerEntry>(entity =>
            {
                entity.HasKey(e => new { e.Priority, e.VendorNo, e.CurrencyCode, e.Positive, e.Future, e.EntryNo });

                entity.ToTable("Payable Vendor Ledger Entry");

                entity.Property(e => e.VendorNo)
                    .HasColumnName("Vendor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrencyCode)
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.EntryNo).HasColumnName("Entry No_");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("Amount (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.VendorLedgEntryNo).HasColumnName("Vendor Ledg_ Entry No_");
            });

            modelBuilder.Entity<ReturnPolicy>(entity =>
            {
                entity.HasKey(e => new { e.StoreNo, e.StoreGroupCode, e.ItemCategoryCode, e.ProductGroupCode, e.ItemNo, e.VariantCode, e.VariantDimension1Code });

                entity.ToTable("Return Policy");

                entity.Property(e => e.StoreNo)
                    .HasColumnName("Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.StoreGroupCode)
                    .HasColumnName("Store Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ItemCategoryCode)
                    .HasColumnName("Item Category Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ProductGroupCode)
                    .HasColumnName("Product Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ItemNo)
                    .HasColumnName("Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.VariantCode)
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VariantDimension1Code)
                    .HasColumnName("Variant Dimension 1 Code")
                    .HasMaxLength(30);

                entity.Property(e => e.ManagerPrivileges).HasColumnName("Manager Privileges");

                entity.Property(e => e.Message1)
                    .IsRequired()
                    .HasColumnName("Message 1")
                    .HasMaxLength(30);

                entity.Property(e => e.Message2)
                    .IsRequired()
                    .HasColumnName("Message 2")
                    .HasMaxLength(30);

                entity.Property(e => e.RefundNotAllowed).HasColumnName("Refund not Allowed");

                entity.Property(e => e.RefundPeriodLength)
                    .IsRequired()
                    .HasColumnName("Refund Period Length")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ReturnReason>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Return Reason");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.DefaultLocationCode)
                    .IsRequired()
                    .HasColumnName("Default Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InventoryValueZero).HasColumnName("Inventory Value Zero");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ReturnReceiptHeader>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Return Receipt Header");

                entity.HasIndex(e => new { e.BillToCustomerNo, e.No })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.PostingDate, e.No })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.RecivingPickingNo, e.No })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.ReturnOrderNo, e.No })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.SellToCustomerNo, e.ExternalDocumentNo, e.No })
                    .HasName("$2")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");

                entity.Property(e => e.AppliesToDocNo)
                    .IsRequired()
                    .HasColumnName("Applies-to Doc_ No_")
                    .HasMaxLength(20);

                entity.Property(e => e.AppliesToDocType).HasColumnName("Applies-to Doc_ Type");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.BalAccountNo)
                    .IsRequired()
                    .HasColumnName("Bal_ Account No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BalAccountType).HasColumnName("Bal_ Account Type");

                entity.Property(e => e.BillToAddress)
                    .IsRequired()
                    .HasColumnName("Bill-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToAddress2)
                    .IsRequired()
                    .HasColumnName("Bill-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToCity)
                    .IsRequired()
                    .HasColumnName("Bill-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.BillToContact)
                    .IsRequired()
                    .HasColumnName("Bill-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToContactNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BillToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Bill-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BillToCounty)
                    .IsRequired()
                    .HasColumnName("Bill-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BillToName)
                    .IsRequired()
                    .HasColumnName("Bill-to Name")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToName2)
                    .IsRequired()
                    .HasColumnName("Bill-to Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToPostCode)
                    .IsRequired()
                    .HasColumnName("Bill-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.CampaignNo)
                    .IsRequired()
                    .HasColumnName("Campaign No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyFactor)
                    .HasColumnName("Currency Factor")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CustomerDiscGroup)
                    .IsRequired()
                    .HasColumnName("Customer Disc_ Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPostingGroup)
                    .IsRequired()
                    .HasColumnName("Customer Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPriceGroup)
                    .IsRequired()
                    .HasColumnName("Customer Price Group")
                    .HasMaxLength(10);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.DocumentDate)
                    .HasColumnName("Document Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eu3PartyTrade).HasColumnName("EU 3-Party Trade");

                entity.Property(e => e.ExitPoint)
                    .IsRequired()
                    .HasColumnName("Exit Point")
                    .HasMaxLength(10);

                entity.Property(e => e.ExternalDocumentNo)
                    .IsRequired()
                    .HasColumnName("External Document No_")
                    .HasMaxLength(35);

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceDiscCode)
                    .IsRequired()
                    .HasColumnName("Invoice Disc_ Code")
                    .HasMaxLength(20);

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasColumnName("Language Code")
                    .HasMaxLength(10);

                entity.Property(e => e.LateOrderShipping).HasColumnName("Late Order Shipping");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MemberCardNo)
                    .IsRequired()
                    .HasColumnName("Member Card No_")
                    .HasMaxLength(100);

                entity.Property(e => e.NoPrinted).HasColumnName("No_ Printed");

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.OnHold)
                    .IsRequired()
                    .HasColumnName("On Hold")
                    .HasMaxLength(3);

                entity.Property(e => e.OpportunityNo)
                    .IsRequired()
                    .HasColumnName("Opportunity No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PackageTrackingNo)
                    .IsRequired()
                    .HasColumnName("Package Tracking No_")
                    .HasMaxLength(30);

                entity.Property(e => e.PaymentDiscount)
                    .HasColumnName("Payment Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PaymentMethodCode)
                    .IsRequired()
                    .HasColumnName("Payment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentTermsCode)
                    .IsRequired()
                    .HasColumnName("Payment Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PmtDiscountDate)
                    .HasColumnName("Pmt_ Discount Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .IsRequired()
                    .HasColumnName("Posting Description")
                    .HasMaxLength(50);

                entity.Property(e => e.PricesIncludingVat).HasColumnName("Prices Including VAT");

                entity.Property(e => e.PromisedDeliveryDate)
                    .HasColumnName("Promised Delivery Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasColumnName("Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.RecivingPickingNo)
                    .IsRequired()
                    .HasColumnName("Reciving_Picking No_")
                    .HasMaxLength(20);

                entity.Property(e => e.RequestedDeliveryDate)
                    .HasColumnName("Requested Delivery Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.RetailStatus).HasColumnName("Retail Status");

                entity.Property(e => e.ReturnOrderNo)
                    .IsRequired()
                    .HasColumnName("Return Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ReturnOrderNoSeries)
                    .IsRequired()
                    .HasColumnName("Return Order No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.SalespersonCode)
                    .IsRequired()
                    .HasColumnName("Salesperson Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToAddress)
                    .IsRequired()
                    .HasColumnName("Sell-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToAddress2)
                    .IsRequired()
                    .HasColumnName("Sell-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToCity)
                    .IsRequired()
                    .HasColumnName("Sell-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.SellToContact)
                    .IsRequired()
                    .HasColumnName("Sell-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToContactNo)
                    .IsRequired()
                    .HasColumnName("Sell-to Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Sell-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SellToCounty)
                    .IsRequired()
                    .HasColumnName("Sell-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.SellToCustomerName)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer Name")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToCustomerName2)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToPostCode)
                    .IsRequired()
                    .HasColumnName("Sell-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipToAddress)
                    .IsRequired()
                    .HasColumnName("Ship-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToAddress2)
                    .IsRequired()
                    .HasColumnName("Ship-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCity)
                    .IsRequired()
                    .HasColumnName("Ship-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToContact)
                    .IsRequired()
                    .HasColumnName("Ship-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToCounty)
                    .IsRequired()
                    .HasColumnName("Ship-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToName)
                    .IsRequired()
                    .HasColumnName("Ship-to Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToName2)
                    .IsRequired()
                    .HasColumnName("Ship-to Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToPostCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipmentDate)
                    .HasColumnName("Shipment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .IsRequired()
                    .HasColumnName("Shipment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAgentCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingTime)
                    .IsRequired()
                    .HasColumnName("Shipping Time")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasColumnName("Source Code")
                    .HasMaxLength(10);

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasColumnName("Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasColumnName("Transaction Specification")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasColumnName("Transport Method")
                    .HasMaxLength(10);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User ID")
                    .HasMaxLength(50);

                entity.Property(e => e.VatBaseDiscount)
                    .HasColumnName("VAT Base Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("VAT Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VatRegistrationNo)
                    .IsRequired()
                    .HasColumnName("VAT Registration No_")
                    .HasMaxLength(20);

                entity.Property(e => e.WarehouseHandlingTime)
                    .IsRequired()
                    .HasColumnName("Warehouse Handling Time")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.YourReference)
                    .IsRequired()
                    .HasColumnName("Your Reference")
                    .HasMaxLength(35);
            });

            modelBuilder.Entity<ReturnReceiptLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.LineNo });

                entity.ToTable("Return Receipt Line");

                entity.HasIndex(e => new { e.BillToCustomerNo, e.DocumentNo, e.LineNo })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemRcptEntryNo, e.DocumentNo, e.LineNo })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.SellToCustomerNo, e.DocumentNo, e.LineNo })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.BlanketOrderNo, e.BlanketOrderLineNo, e.DocumentNo, e.LineNo })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.ReturnOrderNo, e.ReturnOrderLineNo, e.DocumentNo, e.LineNo })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasColumnName("Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.AllowInvoiceDisc).HasColumnName("Allow Invoice Disc_");

                entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");

                entity.Property(e => e.ApplFromItemEntry).HasColumnName("Appl_-from Item Entry");

                entity.Property(e => e.ApplToItemEntry).HasColumnName("Appl_-to Item Entry");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.AttachedToLineNo).HasColumnName("Attached to Line No_");

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BinCode)
                    .IsRequired()
                    .HasColumnName("Bin Code")
                    .HasMaxLength(20);

                entity.Property(e => e.BlanketOrderLineNo).HasColumnName("Blanket Order Line No_");

                entity.Property(e => e.BlanketOrderNo)
                    .IsRequired()
                    .HasColumnName("Blanket Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CrossReferenceNo)
                    .IsRequired()
                    .HasColumnName("Cross-Reference No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CrossReferenceType).HasColumnName("Cross-Reference Type");

                entity.Property(e => e.CrossReferenceTypeNo)
                    .IsRequired()
                    .HasColumnName("Cross-Reference Type No_")
                    .HasMaxLength(30);

                entity.Property(e => e.CustomerDiscGroup)
                    .IsRequired()
                    .HasColumnName("Customer Disc_ Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPriceGroup)
                    .IsRequired()
                    .HasColumnName("Customer Price Group")
                    .HasMaxLength(10);

                entity.Property(e => e.DeprUntilFaPostingDate).HasColumnName("Depr_ until FA Posting Date");

                entity.Property(e => e.DepreciationBookCode)
                    .IsRequired()
                    .HasColumnName("Depreciation Book Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("Description 2")
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.DuplicateInDepreciationBook)
                    .IsRequired()
                    .HasColumnName("Duplicate in Depreciation Book")
                    .HasMaxLength(10);

                entity.Property(e => e.ExitPoint)
                    .IsRequired()
                    .HasColumnName("Exit Point")
                    .HasMaxLength(10);

                entity.Property(e => e.FaPostingDate)
                    .HasColumnName("FA Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GenProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GrossWeight)
                    .HasColumnName("Gross Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ItemCategoryCode)
                    .IsRequired()
                    .HasColumnName("Item Category Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ItemChargeBaseAmount)
                    .HasColumnName("Item Charge Base Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ItemRcptEntryNo).HasColumnName("Item Rcpt_ Entry No_");

                entity.Property(e => e.JobNo)
                    .IsRequired()
                    .HasColumnName("Job No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineDiscount)
                    .HasColumnName("Line Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NetWeight)
                    .HasColumnName("Net Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasColumnName("No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .IsRequired()
                    .HasColumnName("Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.ProductGroupCode)
                    .IsRequired()
                    .HasColumnName("Product Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PurchasingCode)
                    .IsRequired()
                    .HasColumnName("Purchasing Code")
                    .HasMaxLength(10);

                entity.Property(e => e.QtyInvoicedBase)
                    .HasColumnName("Qty_ Invoiced (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPerUnitOfMeasure)
                    .HasColumnName("Qty_ per Unit of Measure")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityBase)
                    .HasColumnName("Quantity (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityInvoiced)
                    .HasColumnName("Quantity Invoiced")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.ReturnOrderLineNo).HasColumnName("Return Order Line No_");

                entity.Property(e => e.ReturnOrderNo)
                    .IsRequired()
                    .HasColumnName("Return Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ReturnQtyRcdNotInvd)
                    .HasColumnName("Return Qty_ Rcd_ Not Invd_")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReturnReasonCode)
                    .IsRequired()
                    .HasColumnName("Return Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SellToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipmentDate)
                    .HasColumnName("Shipment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxGroupCode)
                    .IsRequired()
                    .HasColumnName("Tax Group Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasColumnName("Transaction Specification")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasColumnName("Transport Method")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitCost)
                    .HasColumnName("Unit Cost")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("Unit Cost (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitOfMeasure)
                    .IsRequired()
                    .HasColumnName("Unit of Measure")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasColumnName("Unit of Measure Code")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitOfMeasureCrossRef)
                    .IsRequired()
                    .HasColumnName("Unit of Measure (Cross Ref_)")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("Unit Price")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitVolume)
                    .HasColumnName("Unit Volume")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitsPerParcel)
                    .HasColumnName("Units per Parcel")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UseDuplicationList).HasColumnName("Use Duplication List");

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBaseAmount)
                    .HasColumnName("VAT Base Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatCalculationType).HasColumnName("VAT Calculation Type");

                entity.Property(e => e.VatProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.WorkTypeCode)
                    .IsRequired()
                    .HasColumnName("Work Type Code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ReturnShipmentHeader>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Return Shipment Header");

                entity.HasIndex(e => new { e.BuyFromVendorNo, e.No })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.PayToVendorNo, e.No })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.RecivingPickingNo, e.No })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.ReturnOrderNo, e.No })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.AppliesToDocNo)
                    .IsRequired()
                    .HasColumnName("Applies-to Doc_ No_")
                    .HasMaxLength(20);

                entity.Property(e => e.AppliesToDocType).HasColumnName("Applies-to Doc_ Type");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.BalAccountNo)
                    .IsRequired()
                    .HasColumnName("Bal_ Account No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BalAccountType).HasColumnName("Bal_ Account Type");

                entity.Property(e => e.BuyFromAddress)
                    .IsRequired()
                    .HasColumnName("Buy-from Address")
                    .HasMaxLength(50);

                entity.Property(e => e.BuyFromAddress2)
                    .IsRequired()
                    .HasColumnName("Buy-from Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.BuyFromCity)
                    .IsRequired()
                    .HasColumnName("Buy-from City")
                    .HasMaxLength(30);

                entity.Property(e => e.BuyFromContact)
                    .IsRequired()
                    .HasColumnName("Buy-from Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.BuyFromContactNo)
                    .IsRequired()
                    .HasColumnName("Buy-from Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BuyFromCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Buy-from Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BuyFromCounty)
                    .IsRequired()
                    .HasColumnName("Buy-from County")
                    .HasMaxLength(30);

                entity.Property(e => e.BuyFromPostCode)
                    .IsRequired()
                    .HasColumnName("Buy-from Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.BuyFromVendorName)
                    .IsRequired()
                    .HasColumnName("Buy-from Vendor Name")
                    .HasMaxLength(50);

                entity.Property(e => e.BuyFromVendorName2)
                    .IsRequired()
                    .HasColumnName("Buy-from Vendor Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.BuyFromVendorNo)
                    .IsRequired()
                    .HasColumnName("Buy-from Vendor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CampaignNo)
                    .IsRequired()
                    .HasColumnName("Campaign No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyFactor)
                    .HasColumnName("Currency Factor")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.DocumentDate)
                    .HasColumnName("Document Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EntryPoint)
                    .IsRequired()
                    .HasColumnName("Entry Point")
                    .HasMaxLength(10);

                entity.Property(e => e.ExpectedReceiptDate)
                    .HasColumnName("Expected Receipt Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceDiscCode)
                    .IsRequired()
                    .HasColumnName("Invoice Disc_ Code")
                    .HasMaxLength(20);

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasColumnName("Language Code")
                    .HasMaxLength(10);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NoPrinted).HasColumnName("No_ Printed");

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.OnHold)
                    .IsRequired()
                    .HasColumnName("On Hold")
                    .HasMaxLength(3);

                entity.Property(e => e.OrderAddressCode)
                    .IsRequired()
                    .HasColumnName("Order Address Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PayToAddress)
                    .IsRequired()
                    .HasColumnName("Pay-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.PayToAddress2)
                    .IsRequired()
                    .HasColumnName("Pay-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.PayToCity)
                    .IsRequired()
                    .HasColumnName("Pay-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.PayToContact)
                    .IsRequired()
                    .HasColumnName("Pay-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.PayToContactNo)
                    .IsRequired()
                    .HasColumnName("Pay-to Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PayToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Pay-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PayToCounty)
                    .IsRequired()
                    .HasColumnName("Pay-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.PayToName)
                    .IsRequired()
                    .HasColumnName("Pay-to Name")
                    .HasMaxLength(50);

                entity.Property(e => e.PayToName2)
                    .IsRequired()
                    .HasColumnName("Pay-to Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.PayToPostCode)
                    .IsRequired()
                    .HasColumnName("Pay-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PayToVendorNo)
                    .IsRequired()
                    .HasColumnName("Pay-to Vendor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PaymentDiscount)
                    .HasColumnName("Payment Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PaymentMethodCode)
                    .IsRequired()
                    .HasColumnName("Payment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentTermsCode)
                    .IsRequired()
                    .HasColumnName("Payment Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PmtDiscountDate)
                    .HasColumnName("Pmt_ Discount Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .IsRequired()
                    .HasColumnName("Posting Description")
                    .HasMaxLength(50);

                entity.Property(e => e.PurchaserCode)
                    .IsRequired()
                    .HasColumnName("Purchaser Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasColumnName("Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.RecivingPickingNo)
                    .IsRequired()
                    .HasColumnName("Reciving_Picking No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.RetailStatus).HasColumnName("Retail Status");

                entity.Property(e => e.ReturnOrderNo)
                    .IsRequired()
                    .HasColumnName("Return Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ReturnOrderNoSeries)
                    .IsRequired()
                    .HasColumnName("Return Order No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipToAddress)
                    .IsRequired()
                    .HasColumnName("Ship-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToAddress2)
                    .IsRequired()
                    .HasColumnName("Ship-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCity)
                    .IsRequired()
                    .HasColumnName("Ship-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToContact)
                    .IsRequired()
                    .HasColumnName("Ship-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToCounty)
                    .IsRequired()
                    .HasColumnName("Ship-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToName)
                    .IsRequired()
                    .HasColumnName("Ship-to Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToName2)
                    .IsRequired()
                    .HasColumnName("Ship-to Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToPostCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipmentMethodCode)
                    .IsRequired()
                    .HasColumnName("Shipment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasColumnName("Source Code")
                    .HasMaxLength(10);

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasColumnName("Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasColumnName("Transaction Specification")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasColumnName("Transport Method")
                    .HasMaxLength(10);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User ID")
                    .HasMaxLength(50);

                entity.Property(e => e.VatBaseDiscount)
                    .HasColumnName("VAT Base Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("VAT Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VatRegistrationNo)
                    .IsRequired()
                    .HasColumnName("VAT Registration No_")
                    .HasMaxLength(20);

                entity.Property(e => e.VendorAuthorizationNo)
                    .IsRequired()
                    .HasColumnName("Vendor Authorization No_")
                    .HasMaxLength(35);

                entity.Property(e => e.VendorPostingGroup)
                    .IsRequired()
                    .HasColumnName("Vendor Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.YourReference)
                    .IsRequired()
                    .HasColumnName("Your Reference")
                    .HasMaxLength(35);
            });

            modelBuilder.Entity<ReturnShipmentLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.LineNo });

                entity.ToTable("Return Shipment Line");

                entity.HasIndex(e => new { e.BuyFromVendorNo, e.DocumentNo, e.LineNo })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.PayToVendorNo, e.DocumentNo, e.LineNo })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.BlanketOrderNo, e.BlanketOrderLineNo, e.DocumentNo, e.LineNo })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.ReturnOrderNo, e.ReturnOrderLineNo, e.DocumentNo, e.LineNo })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasColumnName("Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.AllowInvoiceDisc).HasColumnName("Allow Invoice Disc_");

                entity.Property(e => e.ApplToItemEntry).HasColumnName("Appl_-to Item Entry");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.AttachedToLineNo).HasColumnName("Attached to Line No_");

                entity.Property(e => e.BinCode)
                    .IsRequired()
                    .HasColumnName("Bin Code")
                    .HasMaxLength(20);

                entity.Property(e => e.BlanketOrderLineNo).HasColumnName("Blanket Order Line No_");

                entity.Property(e => e.BlanketOrderNo)
                    .IsRequired()
                    .HasColumnName("Blanket Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BudgetedFaNo)
                    .IsRequired()
                    .HasColumnName("Budgeted FA No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BuyFromVendorNo)
                    .IsRequired()
                    .HasColumnName("Buy-from Vendor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CrossReferenceNo)
                    .IsRequired()
                    .HasColumnName("Cross-Reference No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CrossReferenceType).HasColumnName("Cross-Reference Type");

                entity.Property(e => e.CrossReferenceTypeNo)
                    .IsRequired()
                    .HasColumnName("Cross-Reference Type No_")
                    .HasMaxLength(30);

                entity.Property(e => e.DeprAcquisitionCost).HasColumnName("Depr_ Acquisition Cost");

                entity.Property(e => e.DeprUntilFaPostingDate).HasColumnName("Depr_ until FA Posting Date");

                entity.Property(e => e.DepreciationBookCode)
                    .IsRequired()
                    .HasColumnName("Depreciation Book Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("Description 2")
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.DirectUnitCost)
                    .HasColumnName("Direct Unit Cost")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DuplicateInDepreciationBook)
                    .IsRequired()
                    .HasColumnName("Duplicate in Depreciation Book")
                    .HasMaxLength(10);

                entity.Property(e => e.EntryPoint)
                    .IsRequired()
                    .HasColumnName("Entry Point")
                    .HasMaxLength(10);

                entity.Property(e => e.FaPostingDate)
                    .HasColumnName("FA Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FaPostingType).HasColumnName("FA Posting Type");

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GenProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GrossWeight)
                    .HasColumnName("Gross Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.IndirectCost)
                    .HasColumnName("Indirect Cost _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.InsuranceNo)
                    .IsRequired()
                    .HasColumnName("Insurance No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ItemCategoryCode)
                    .IsRequired()
                    .HasColumnName("Item Category Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ItemChargeBaseAmount)
                    .HasColumnName("Item Charge Base Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ItemShptEntryNo).HasColumnName("Item Shpt_ Entry No_");

                entity.Property(e => e.JobNo)
                    .IsRequired()
                    .HasColumnName("Job No_")
                    .HasMaxLength(20);

                entity.Property(e => e.JobTaskNo)
                    .IsRequired()
                    .HasColumnName("Job Task No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineDiscount)
                    .HasColumnName("Line Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MaintenanceCode)
                    .IsRequired()
                    .HasColumnName("Maintenance Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NetWeight)
                    .HasColumnName("Net Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasColumnName("No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PayToVendorNo)
                    .IsRequired()
                    .HasColumnName("Pay-to Vendor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .IsRequired()
                    .HasColumnName("Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.ProdOrderNo)
                    .IsRequired()
                    .HasColumnName("Prod_ Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ProductGroupCode)
                    .IsRequired()
                    .HasColumnName("Product Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PurchasingCode)
                    .IsRequired()
                    .HasColumnName("Purchasing Code")
                    .HasMaxLength(10);

                entity.Property(e => e.QtyInvoicedBase)
                    .HasColumnName("Qty_ Invoiced (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPerUnitOfMeasure)
                    .HasColumnName("Qty_ per Unit of Measure")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityBase)
                    .HasColumnName("Quantity (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityInvoiced)
                    .HasColumnName("Quantity Invoiced")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.RetailBinCode)
                    .IsRequired()
                    .HasColumnName("Retail Bin Code")
                    .HasMaxLength(20);

                entity.Property(e => e.RetailLocationCode)
                    .IsRequired()
                    .HasColumnName("Retail Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ReturnOrderLineNo).HasColumnName("Return Order Line No_");

                entity.Property(e => e.ReturnOrderNo)
                    .IsRequired()
                    .HasColumnName("Return Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ReturnQtyShippedNotInvd)
                    .HasColumnName("Return Qty_ Shipped Not Invd_")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReturnReasonCode)
                    .IsRequired()
                    .HasColumnName("Return Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SalvageValue)
                    .HasColumnName("Salvage Value")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxGroupCode)
                    .IsRequired()
                    .HasColumnName("Tax Group Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasColumnName("Transaction Specification")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasColumnName("Transport Method")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitCost)
                    .HasColumnName("Unit Cost")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("Unit Cost (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitOfMeasure)
                    .IsRequired()
                    .HasColumnName("Unit of Measure")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasColumnName("Unit of Measure Code")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitOfMeasureCrossRef)
                    .IsRequired()
                    .HasColumnName("Unit of Measure (Cross Ref_)")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitPriceLcy)
                    .HasColumnName("Unit Price (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitVolume)
                    .HasColumnName("Unit Volume")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitsPerParcel)
                    .HasColumnName("Units per Parcel")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UseDuplicationList).HasColumnName("Use Duplication List");

                entity.Property(e => e.UseTax).HasColumnName("Use Tax");

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBaseAmount)
                    .HasColumnName("VAT Base Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatCalculationType).HasColumnName("VAT Calculation Type");

                entity.Property(e => e.VatProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VendorItemNo)
                    .IsRequired()
                    .HasColumnName("Vendor Item No_")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ReturnsRelatedDocument>(entity =>
            {
                entity.HasKey(e => e.EntryNo);

                entity.ToTable("Returns-Related Document");

                entity.Property(e => e.EntryNo)
                    .HasColumnName("Entry No_")
                    .ValueGeneratedNever();

                entity.Property(e => e.DocumentType).HasColumnName("Document Type");

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasColumnName("No_")
                    .HasMaxLength(20);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<SalesHeader>(entity =>
            {
                entity.HasKey(e => new { e.DocumentType, e.No });

                entity.ToTable("Sales Header");

                entity.HasIndex(e => new { e.No, e.DocumentType })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.BillToContactNo, e.DocumentType, e.No })
                    .HasName("$7")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentDate, e.DocumentType, e.No })
                    .HasName("$13")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.BillToCustomerNo, e.No })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.SellToContactNo, e.No })
                    .HasName("$6")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.SellToCustomerNo, e.No })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.IncomingDocumentEntryNo, e.DocumentType, e.No })
                    .HasName("$8")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.SellToCustomerNo, e.SellToContactNo, e.No })
                    .HasName("$12")
                    .IsUnique();

                entity.HasIndex(e => new { e.SellToCustomerNo, e.ExternalDocumentNo, e.DocumentType, e.No })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.CombineShipments, e.BillToCustomerNo, e.CurrencyCode, e.Eu3PartyTrade, e.DimensionSetId, e.No })
                    .HasName("$4")
                    .IsUnique();

                entity.Property(e => e.DocumentType).HasColumnName("Document Type");

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20);

                entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");

                entity.Property(e => e.AppliesToDocNo)
                    .IsRequired()
                    .HasColumnName("Applies-to Doc_ No_")
                    .HasMaxLength(20);

                entity.Property(e => e.AppliesToDocType).HasColumnName("Applies-to Doc_ Type");

                entity.Property(e => e.AppliesToId)
                    .IsRequired()
                    .HasColumnName("Applies-to ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.AssignedUserId)
                    .IsRequired()
                    .HasColumnName("Assigned User ID")
                    .HasMaxLength(50);

                entity.Property(e => e.BalAccountNo)
                    .IsRequired()
                    .HasColumnName("Bal_ Account No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BalAccountType).HasColumnName("Bal_ Account Type");

                entity.Property(e => e.BatchNo)
                    .IsRequired()
                    .HasColumnName("Batch No_")
                    .HasMaxLength(10);

                entity.Property(e => e.BillToAddress)
                    .IsRequired()
                    .HasColumnName("Bill-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToAddress2)
                    .IsRequired()
                    .HasColumnName("Bill-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToCity)
                    .IsRequired()
                    .HasColumnName("Bill-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.BillToContact)
                    .IsRequired()
                    .HasColumnName("Bill-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToContactNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BillToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Bill-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BillToCounty)
                    .IsRequired()
                    .HasColumnName("Bill-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BillToCustomerTemplateCode)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer Template Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BillToIcPartnerCode)
                    .IsRequired()
                    .HasColumnName("Bill-to IC Partner Code")
                    .HasMaxLength(20);

                entity.Property(e => e.BillToName)
                    .IsRequired()
                    .HasColumnName("Bill-to Name")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToName2)
                    .IsRequired()
                    .HasColumnName("Bill-to Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToPostCode)
                    .IsRequired()
                    .HasColumnName("Bill-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.CampaignNo)
                    .IsRequired()
                    .HasColumnName("Campaign No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CashierId)
                    .IsRequired()
                    .HasColumnName("Cashier ID")
                    .HasMaxLength(10);

                entity.Property(e => e.CombineShipments).HasColumnName("Combine Shipments");

                entity.Property(e => e.CompressPrepayment).HasColumnName("Compress Prepayment");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyFactor)
                    .HasColumnName("Currency Factor")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CustomerDiscGroup)
                    .IsRequired()
                    .HasColumnName("Customer Disc_ Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPostingGroup)
                    .IsRequired()
                    .HasColumnName("Customer Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPriceGroup)
                    .IsRequired()
                    .HasColumnName("Customer Price Group")
                    .HasMaxLength(10);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.DirectDebitMandateId)
                    .IsRequired()
                    .HasColumnName("Direct Debit Mandate ID")
                    .HasMaxLength(35);

                entity.Property(e => e.DocNoOccurrence).HasColumnName("Doc_ No_ Occurrence");

                entity.Property(e => e.DocumentDate)
                    .HasColumnName("Document Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eu3PartyTrade).HasColumnName("EU 3-Party Trade");

                entity.Property(e => e.ExitPoint)
                    .IsRequired()
                    .HasColumnName("Exit Point")
                    .HasMaxLength(10);

                entity.Property(e => e.ExternalDocumentNo)
                    .IsRequired()
                    .HasColumnName("External Document No_")
                    .HasMaxLength(35);

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GetShipmentUsed).HasColumnName("Get Shipment Used");

                entity.Property(e => e.IcDirection).HasColumnName("IC Direction");

                entity.Property(e => e.IcStatus).HasColumnName("IC Status");

                entity.Property(e => e.IncomingDocumentEntryNo).HasColumnName("Incoming Document Entry No_");

                entity.Property(e => e.InvoiceDiscCode)
                    .IsRequired()
                    .HasColumnName("Invoice Disc_ Code")
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceDiscountCalculation).HasColumnName("Invoice Discount Calculation");

                entity.Property(e => e.InvoiceDiscountValue)
                    .HasColumnName("Invoice Discount Value")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.JobQueueEntryId).HasColumnName("Job Queue Entry ID");

                entity.Property(e => e.JobQueueStatus).HasColumnName("Job Queue Status");

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasColumnName("Language Code")
                    .HasMaxLength(10);

                entity.Property(e => e.LastPostingNo)
                    .IsRequired()
                    .HasColumnName("Last Posting No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LastPrepaymentNo)
                    .IsRequired()
                    .HasColumnName("Last Prepayment No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LastPrepmtCrMemoNo)
                    .IsRequired()
                    .HasColumnName("Last Prepmt_ Cr_ Memo No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LastReturnReceiptNo)
                    .IsRequired()
                    .HasColumnName("Last Return Receipt No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LastShippingNo)
                    .IsRequired()
                    .HasColumnName("Last Shipping No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MemberCardNo)
                    .IsRequired()
                    .HasColumnName("Member Card No_")
                    .HasMaxLength(100);

                entity.Property(e => e.NoPrinted).HasColumnName("No_ Printed");

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.NotShowDialog).HasColumnName("Not Show Dialog");

                entity.Property(e => e.OnHold)
                    .IsRequired()
                    .HasColumnName("On Hold")
                    .HasMaxLength(3);

                entity.Property(e => e.OpportunityNo)
                    .IsRequired()
                    .HasColumnName("Opportunity No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderClass)
                    .IsRequired()
                    .HasColumnName("Order Class")
                    .HasMaxLength(10);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OutboundWhseHandlingTime)
                    .IsRequired()
                    .HasColumnName("Outbound Whse_ Handling Time")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PackageTrackingNo)
                    .IsRequired()
                    .HasColumnName("Package Tracking No_")
                    .HasMaxLength(30);

                entity.Property(e => e.PaymentDiscount)
                    .HasColumnName("Payment Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PaymentMethodCode)
                    .IsRequired()
                    .HasColumnName("Payment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentServiceSetId).HasColumnName("Payment Service Set ID");

                entity.Property(e => e.PaymentTermsCode)
                    .IsRequired()
                    .HasColumnName("Payment Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PmtDiscountDate)
                    .HasColumnName("Pmt_ Discount Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PosComment)
                    .IsRequired()
                    .HasColumnName("POS Comment")
                    .HasMaxLength(30);

                entity.Property(e => e.PosId)
                    .IsRequired()
                    .HasColumnName("POS ID")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .IsRequired()
                    .HasColumnName("Posting Description")
                    .HasMaxLength(50);

                entity.Property(e => e.PostingFromWhseRef).HasColumnName("Posting from Whse_ Ref_");

                entity.Property(e => e.PostingNo)
                    .IsRequired()
                    .HasColumnName("Posting No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingNoSeries)
                    .IsRequired()
                    .HasColumnName("Posting No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingTime)
                    .HasColumnName("Posting Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Prepayment)
                    .HasColumnName("Prepayment _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepaymentDueDate)
                    .HasColumnName("Prepayment Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrepaymentNo)
                    .IsRequired()
                    .HasColumnName("Prepayment No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PrepaymentNoSeries)
                    .IsRequired()
                    .HasColumnName("Prepayment No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.PrepmtCrMemoNo)
                    .IsRequired()
                    .HasColumnName("Prepmt_ Cr_ Memo No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PrepmtCrMemoNoSeries)
                    .IsRequired()
                    .HasColumnName("Prepmt_ Cr_ Memo No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.PrepmtPaymentDiscount)
                    .HasColumnName("Prepmt_ Payment Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepmtPaymentTermsCode)
                    .IsRequired()
                    .HasColumnName("Prepmt_ Payment Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PrepmtPmtDiscountDate)
                    .HasColumnName("Prepmt_ Pmt_ Discount Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PrepmtPostingDescription)
                    .IsRequired()
                    .HasColumnName("Prepmt_ Posting Description")
                    .HasMaxLength(50);

                entity.Property(e => e.PricesIncludingVat).HasColumnName("Prices Including VAT");

                entity.Property(e => e.PrintPostedDocuments).HasColumnName("Print Posted Documents");

                entity.Property(e => e.PromisedDeliveryDate)
                    .HasColumnName("Promised Delivery Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.QuoteAccepted).HasColumnName("Quote Accepted");

                entity.Property(e => e.QuoteAcceptedDate)
                    .HasColumnName("Quote Accepted Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.QuoteNo)
                    .IsRequired()
                    .HasColumnName("Quote No_")
                    .HasMaxLength(20);

                entity.Property(e => e.QuoteSentToCustomer)
                    .HasColumnName("Quote Sent to Customer")
                    .HasColumnType("datetime");

                entity.Property(e => e.QuoteValidUntilDate)
                    .HasColumnName("Quote Valid Until Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasColumnName("Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ReceivingPickingNo)
                    .IsRequired()
                    .HasColumnName("Receiving_Picking No_")
                    .HasMaxLength(20);

                entity.Property(e => e.RequestedDeliveryDate)
                    .HasColumnName("Requested Delivery Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.RetailStatus).HasColumnName("Retail Status");

                entity.Property(e => e.ReturnReceiptNo)
                    .IsRequired()
                    .HasColumnName("Return Receipt No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ReturnReceiptNoSeries)
                    .IsRequired()
                    .HasColumnName("Return Receipt No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.SalesType)
                    .IsRequired()
                    .HasColumnName("Sales Type")
                    .HasMaxLength(20);

                entity.Property(e => e.SalespersonCode)
                    .IsRequired()
                    .HasColumnName("Salesperson Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToAddress)
                    .IsRequired()
                    .HasColumnName("Sell-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToAddress2)
                    .IsRequired()
                    .HasColumnName("Sell-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToCity)
                    .IsRequired()
                    .HasColumnName("Sell-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.SellToContact)
                    .IsRequired()
                    .HasColumnName("Sell-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToContactNo)
                    .IsRequired()
                    .HasColumnName("Sell-to Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Sell-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SellToCounty)
                    .IsRequired()
                    .HasColumnName("Sell-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.SellToCustomerName)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer Name")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToCustomerName2)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToCustomerTemplateCode)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer Template Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SellToIcPartnerCode)
                    .IsRequired()
                    .HasColumnName("Sell-to IC Partner Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToPostCode)
                    .IsRequired()
                    .HasColumnName("Sell-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SendIcDocument).HasColumnName("Send IC Document");

                entity.Property(e => e.ShipToAddress)
                    .IsRequired()
                    .HasColumnName("Ship-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToAddress2)
                    .IsRequired()
                    .HasColumnName("Ship-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCity)
                    .IsRequired()
                    .HasColumnName("Ship-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToContact)
                    .IsRequired()
                    .HasColumnName("Ship-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToCounty)
                    .IsRequired()
                    .HasColumnName("Ship-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToName)
                    .IsRequired()
                    .HasColumnName("Ship-to Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToName2)
                    .IsRequired()
                    .HasColumnName("Ship-to Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToPostCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipmentDate)
                    .HasColumnName("Shipment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .IsRequired()
                    .HasColumnName("Shipment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAdvice).HasColumnName("Shipping Advice");

                entity.Property(e => e.ShippingAgentCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Service Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingNo)
                    .IsRequired()
                    .HasColumnName("Shipping No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippingNoSeries)
                    .IsRequired()
                    .HasColumnName("Shipping No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippingTime)
                    .IsRequired()
                    .HasColumnName("Shipping Time")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.StatementNo)
                    .IsRequired()
                    .HasColumnName("Statement No_")
                    .HasMaxLength(20);

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasColumnName("Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasColumnName("Transaction Specification")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasColumnName("Transport Method")
                    .HasMaxLength(10);

                entity.Property(e => e.VatBaseDiscount)
                    .HasColumnName("VAT Base Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("VAT Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VatRegistrationNo)
                    .IsRequired()
                    .HasColumnName("VAT Registration No_")
                    .HasMaxLength(20);

                entity.Property(e => e.WorkDescription)
                    .HasColumnName("Work Description")
                    .HasColumnType("image");

                entity.Property(e => e.XRetailLocationCode)
                    .IsRequired()
                    .HasColumnName("xRetail Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.YourReference)
                    .IsRequired()
                    .HasColumnName("Your Reference")
                    .HasMaxLength(35);
            });

            modelBuilder.Entity<SalesInvoiceHeader>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Sales Invoice Header");

                entity.HasIndex(e => new { e.BillToCustomerNo, e.No })
                    .HasName("$7")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentExchangeStatus, e.No })
                    .HasName("$10")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrderNo, e.No })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.PostingDate, e.No })
                    .HasName("$9")
                    .IsUnique();

                entity.HasIndex(e => new { e.PreAssignedNo, e.No })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.SellToContactNo, e.No })
                    .HasName("$8")
                    .IsUnique();

                entity.HasIndex(e => new { e.SellToCustomerNo, e.No })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.PrepaymentOrderNo, e.PrepaymentInvoice, e.No })
                    .HasName("$6")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");

                entity.Property(e => e.AppliesToDocNo)
                    .IsRequired()
                    .HasColumnName("Applies-to Doc_ No_")
                    .HasMaxLength(20);

                entity.Property(e => e.AppliesToDocType).HasColumnName("Applies-to Doc_ Type");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.BalAccountNo)
                    .IsRequired()
                    .HasColumnName("Bal_ Account No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BalAccountType).HasColumnName("Bal_ Account Type");

                entity.Property(e => e.BatchNo)
                    .IsRequired()
                    .HasColumnName("Batch No_")
                    .HasMaxLength(10);

                entity.Property(e => e.BiTimestamp)
                    .HasColumnName("BI Timestamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.BillToAddress)
                    .IsRequired()
                    .HasColumnName("Bill-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToAddress2)
                    .IsRequired()
                    .HasColumnName("Bill-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToCity)
                    .IsRequired()
                    .HasColumnName("Bill-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.BillToContact)
                    .IsRequired()
                    .HasColumnName("Bill-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToContactNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BillToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Bill-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BillToCounty)
                    .IsRequired()
                    .HasColumnName("Bill-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BillToName)
                    .IsRequired()
                    .HasColumnName("Bill-to Name")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToName2)
                    .IsRequired()
                    .HasColumnName("Bill-to Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToPostCode)
                    .IsRequired()
                    .HasColumnName("Bill-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.CampaignNo)
                    .IsRequired()
                    .HasColumnName("Campaign No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CashierId)
                    .IsRequired()
                    .HasColumnName("Cashier ID")
                    .HasMaxLength(10);

                entity.Property(e => e.CoupledToCrm).HasColumnName("Coupled to CRM");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyFactor)
                    .HasColumnName("Currency Factor")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CustLedgerEntryNo).HasColumnName("Cust_ Ledger Entry No_");

                entity.Property(e => e.CustomerDiscGroup)
                    .IsRequired()
                    .HasColumnName("Customer Disc_ Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPostingGroup)
                    .IsRequired()
                    .HasColumnName("Customer Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPriceGroup)
                    .IsRequired()
                    .HasColumnName("Customer Price Group")
                    .HasMaxLength(10);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.DirectDebitMandateId)
                    .IsRequired()
                    .HasColumnName("Direct Debit Mandate ID")
                    .HasMaxLength(35);

                entity.Property(e => e.DocExchOriginalIdentifier)
                    .IsRequired()
                    .HasColumnName("Doc_ Exch_ Original Identifier")
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentDate)
                    .HasColumnName("Document Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentExchangeIdentifier)
                    .IsRequired()
                    .HasColumnName("Document Exchange Identifier")
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentExchangeStatus).HasColumnName("Document Exchange Status");

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eu3PartyTrade).HasColumnName("EU 3-Party Trade");

                entity.Property(e => e.ExitPoint)
                    .IsRequired()
                    .HasColumnName("Exit Point")
                    .HasMaxLength(10);

                entity.Property(e => e.ExternalDocumentNo)
                    .IsRequired()
                    .HasColumnName("External Document No_")
                    .HasMaxLength(35);

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GetShipmentUsed).HasColumnName("Get Shipment Used");

                entity.Property(e => e.InvoiceDiscCode)
                    .IsRequired()
                    .HasColumnName("Invoice Disc_ Code")
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceDiscountCalculation).HasColumnName("Invoice Discount Calculation");

                entity.Property(e => e.InvoiceDiscountValue)
                    .HasColumnName("Invoice Discount Value")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasColumnName("Language Code")
                    .HasMaxLength(10);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MemberCardNo)
                    .IsRequired()
                    .HasColumnName("Member Card No_")
                    .HasMaxLength(100);

                entity.Property(e => e.NoPrinted).HasColumnName("No_ Printed");

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.OnHold)
                    .IsRequired()
                    .HasColumnName("On Hold")
                    .HasMaxLength(3);

                entity.Property(e => e.OpportunityNo)
                    .IsRequired()
                    .HasColumnName("Opportunity No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasColumnName("Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderNoSeries)
                    .IsRequired()
                    .HasColumnName("Order No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.PackageTrackingNo)
                    .IsRequired()
                    .HasColumnName("Package Tracking No_")
                    .HasMaxLength(30);

                entity.Property(e => e.PaymentDiscount)
                    .HasColumnName("Payment Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PaymentMethodCode)
                    .IsRequired()
                    .HasColumnName("Payment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentServiceSetId).HasColumnName("Payment Service Set ID");

                entity.Property(e => e.PaymentTermsCode)
                    .IsRequired()
                    .HasColumnName("Payment Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PmtDiscountDate)
                    .HasColumnName("Pmt_ Discount Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PosId)
                    .IsRequired()
                    .HasColumnName("POS ID")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .IsRequired()
                    .HasColumnName("Posting Description")
                    .HasMaxLength(50);

                entity.Property(e => e.PostingTime)
                    .HasColumnName("Posting Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.PreAssignedNo)
                    .IsRequired()
                    .HasColumnName("Pre-Assigned No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PreAssignedNoSeries)
                    .IsRequired()
                    .HasColumnName("Pre-Assigned No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.PrepaymentInvoice).HasColumnName("Prepayment Invoice");

                entity.Property(e => e.PrepaymentNoSeries)
                    .IsRequired()
                    .HasColumnName("Prepayment No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.PrepaymentOrderNo)
                    .IsRequired()
                    .HasColumnName("Prepayment Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PricesIncludingVat).HasColumnName("Prices Including VAT");

                entity.Property(e => e.QuoteNo)
                    .IsRequired()
                    .HasColumnName("Quote No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasColumnName("Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.SalespersonCode)
                    .IsRequired()
                    .HasColumnName("Salesperson Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToAddress)
                    .IsRequired()
                    .HasColumnName("Sell-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToAddress2)
                    .IsRequired()
                    .HasColumnName("Sell-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToCity)
                    .IsRequired()
                    .HasColumnName("Sell-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.SellToContact)
                    .IsRequired()
                    .HasColumnName("Sell-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToContactNo)
                    .IsRequired()
                    .HasColumnName("Sell-to Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Sell-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SellToCounty)
                    .IsRequired()
                    .HasColumnName("Sell-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.SellToCustomerName)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer Name")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToCustomerName2)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToPostCode)
                    .IsRequired()
                    .HasColumnName("Sell-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipToAddress)
                    .IsRequired()
                    .HasColumnName("Ship-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToAddress2)
                    .IsRequired()
                    .HasColumnName("Ship-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCity)
                    .IsRequired()
                    .HasColumnName("Ship-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToContact)
                    .IsRequired()
                    .HasColumnName("Ship-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToCounty)
                    .IsRequired()
                    .HasColumnName("Ship-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToName)
                    .IsRequired()
                    .HasColumnName("Ship-to Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToName2)
                    .IsRequired()
                    .HasColumnName("Ship-to Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToPostCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipmentDate)
                    .HasColumnName("Shipment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .IsRequired()
                    .HasColumnName("Shipment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAgentCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasColumnName("Source Code")
                    .HasMaxLength(10);

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasColumnName("Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasColumnName("Transaction Specification")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasColumnName("Transport Method")
                    .HasMaxLength(10);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User ID")
                    .HasMaxLength(50);

                entity.Property(e => e.VatBaseDiscount)
                    .HasColumnName("VAT Base Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("VAT Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VatRegistrationNo)
                    .IsRequired()
                    .HasColumnName("VAT Registration No_")
                    .HasMaxLength(20);

                entity.Property(e => e.WorkDescription)
                    .HasColumnName("Work Description")
                    .HasColumnType("image");

                entity.Property(e => e.YourReference)
                    .IsRequired()
                    .HasColumnName("Your Reference")
                    .HasMaxLength(35);
            });

            modelBuilder.Entity<SalesInvoiceLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.LineNo });

                entity.ToTable("Sales Invoice Line");

                entity.HasIndex(e => new { e.BillToCustomerNo, e.DocumentNo, e.LineNo })
                    .HasName("$6")
                    .IsUnique();

                entity.HasIndex(e => new { e.JobContractEntryNo, e.DocumentNo, e.LineNo })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.SellToCustomerNo, e.DocumentNo, e.LineNo })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.BlanketOrderNo, e.BlanketOrderLineNo, e.DocumentNo, e.LineNo })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ShipmentNo, e.ShipmentLineNo, e.DocumentNo, e.LineNo })
                    .HasName("$4")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasColumnName("Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.AllowInvoiceDisc).HasColumnName("Allow Invoice Disc_");

                entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnName("Amount Including VAT")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ApplFromItemEntry).HasColumnName("Appl_-from Item Entry");

                entity.Property(e => e.ApplToItemEntry).HasColumnName("Appl_-to Item Entry");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.AttachedToLineNo).HasColumnName("Attached to Line No_");

                entity.Property(e => e.BiTimestamp)
                    .HasColumnName("BI Timestamp")
                    .HasColumnType("datetime");

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BinCode)
                    .IsRequired()
                    .HasColumnName("Bin Code")
                    .HasMaxLength(20);

                entity.Property(e => e.BlanketOrderLineNo).HasColumnName("Blanket Order Line No_");

                entity.Property(e => e.BlanketOrderNo)
                    .IsRequired()
                    .HasColumnName("Blanket Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CrossReferenceNo)
                    .IsRequired()
                    .HasColumnName("Cross-Reference No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CrossReferenceType).HasColumnName("Cross-Reference Type");

                entity.Property(e => e.CrossReferenceTypeNo)
                    .IsRequired()
                    .HasColumnName("Cross-Reference Type No_")
                    .HasMaxLength(30);

                entity.Property(e => e.CustomerDiscGroup)
                    .IsRequired()
                    .HasColumnName("Customer Disc_ Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPriceGroup)
                    .IsRequired()
                    .HasColumnName("Customer Price Group")
                    .HasMaxLength(10);

                entity.Property(e => e.DeferralCode)
                    .IsRequired()
                    .HasColumnName("Deferral Code")
                    .HasMaxLength(10);

                entity.Property(e => e.DeprUntilFaPostingDate).HasColumnName("Depr_ until FA Posting Date");

                entity.Property(e => e.DepreciationBookCode)
                    .IsRequired()
                    .HasColumnName("Depreciation Book Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("Description 2")
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.Division)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DropShipment).HasColumnName("Drop Shipment");

                entity.Property(e => e.DuplicateInDepreciationBook)
                    .IsRequired()
                    .HasColumnName("Duplicate in Depreciation Book")
                    .HasMaxLength(10);

                entity.Property(e => e.ExitPoint)
                    .IsRequired()
                    .HasColumnName("Exit Point")
                    .HasMaxLength(10);

                entity.Property(e => e.FaPostingDate)
                    .HasColumnName("FA Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GenProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GrossWeight)
                    .HasColumnName("Gross Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.IcPartnerCode)
                    .IsRequired()
                    .HasColumnName("IC Partner Code")
                    .HasMaxLength(20);

                entity.Property(e => e.IcPartnerRefType).HasColumnName("IC Partner Ref_ Type");

                entity.Property(e => e.IcPartnerReference)
                    .IsRequired()
                    .HasColumnName("IC Partner Reference")
                    .HasMaxLength(20);

                entity.Property(e => e.InvDiscountAmount)
                    .HasColumnName("Inv_ Discount Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ItemCategoryCode)
                    .IsRequired()
                    .HasColumnName("Item Category Code")
                    .HasMaxLength(20);

                entity.Property(e => e.JobContractEntryNo).HasColumnName("Job Contract Entry No_");

                entity.Property(e => e.JobNo)
                    .IsRequired()
                    .HasColumnName("Job No_")
                    .HasMaxLength(20);

                entity.Property(e => e.JobTaskNo)
                    .IsRequired()
                    .HasColumnName("Job Task No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineAmount)
                    .HasColumnName("Line Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineDiscount)
                    .HasColumnName("Line Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineDiscountAmount)
                    .HasColumnName("Line Discount Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineDiscountCalculation).HasColumnName("Line Discount Calculation");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MemberPoints)
                    .HasColumnName("Member Points")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.MemberPointsType).HasColumnName("Member Points Type");

                entity.Property(e => e.NetWeight)
                    .HasColumnName("Net Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasColumnName("No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OfferNo)
                    .IsRequired()
                    .HasColumnName("Offer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .IsRequired()
                    .HasColumnName("Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.PrepaymentLine).HasColumnName("Prepayment Line");

                entity.Property(e => e.PriceDescription)
                    .IsRequired()
                    .HasColumnName("Price description")
                    .HasMaxLength(80);

                entity.Property(e => e.ProductGroupCode)
                    .IsRequired()
                    .HasColumnName("Product Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PurchasingCode)
                    .IsRequired()
                    .HasColumnName("Purchasing Code")
                    .HasMaxLength(10);

                entity.Property(e => e.QtyPerUnitOfMeasure)
                    .HasColumnName("Qty_ per Unit of Measure")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityBase)
                    .HasColumnName("Quantity (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.ReturnReasonCode)
                    .IsRequired()
                    .HasColumnName("Return Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SellToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipmentDate)
                    .HasColumnName("Shipment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipmentLineNo).HasColumnName("Shipment Line No_");

                entity.Property(e => e.ShipmentNo)
                    .IsRequired()
                    .HasColumnName("Shipment No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SystemCreatedEntry).HasColumnName("System-Created Entry");

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxCategory)
                    .IsRequired()
                    .HasColumnName("Tax Category")
                    .HasMaxLength(10);

                entity.Property(e => e.TaxGroupCode)
                    .IsRequired()
                    .HasColumnName("Tax Group Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasColumnName("Transaction Specification")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasColumnName("Transport Method")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitCost)
                    .HasColumnName("Unit Cost")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("Unit Cost (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitOfMeasure)
                    .IsRequired()
                    .HasColumnName("Unit of Measure")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasColumnName("Unit of Measure Code")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitOfMeasureCrossRef)
                    .IsRequired()
                    .HasColumnName("Unit of Measure (Cross Ref_)")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("Unit Price")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitVolume)
                    .HasColumnName("Unit Volume")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitsPerParcel)
                    .HasColumnName("Units per Parcel")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UseDuplicationList).HasColumnName("Use Duplication List");

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBaseAmount)
                    .HasColumnName("VAT Base Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatCalculationType).HasColumnName("VAT Calculation Type");

                entity.Property(e => e.VatClauseCode)
                    .IsRequired()
                    .HasColumnName("VAT Clause Code")
                    .HasMaxLength(20);

                entity.Property(e => e.VatDifference)
                    .HasColumnName("VAT Difference")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatIdentifier)
                    .IsRequired()
                    .HasColumnName("VAT Identifier")
                    .HasMaxLength(20);

                entity.Property(e => e.VatProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VendorNo)
                    .IsRequired()
                    .HasColumnName("Vendor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.WorkTypeCode)
                    .IsRequired()
                    .HasColumnName("Work Type Code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<SalesLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentType, e.DocumentNo, e.LineNo });

                entity.ToTable("Sales Line");

                entity.HasIndex(e => new { e.JobContractEntryNo, e.DocumentType, e.DocumentNo, e.LineNo })
                    .HasName("$11")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.BillToCustomerNo, e.CurrencyCode, e.DocumentNo, e.LineNo })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.BlanketOrderNo, e.BlanketOrderLineNo, e.DocumentNo, e.LineNo })
                    .HasName("$6")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.SellToCustomerNo, e.ShipmentNo, e.DocumentNo, e.LineNo })
                    .HasName("$10")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.ShipmentNo, e.ShipmentLineNo, e.DocumentNo, e.LineNo })
                    .HasName("$8")
                    .IsUnique();

                entity.HasIndex(e => new { e.AllocPlanPurcOrderNo, e.DocumentType, e.Type, e.No, e.VariantCode, e.DocumentNo, e.LineNo })
                    .HasName("$14")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.Type, e.No, e.VariantCode, e.DropShipment, e.LocationCode, e.ShipmentDate, e.DocumentNo, e.LineNo })
                    .HasName("$2")
                    .IsUnique();

                entity.Property(e => e.DocumentType).HasColumnName("Document Type");

                entity.Property(e => e.DocumentNo)
                    .HasColumnName("Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.AllocPlanPurcOrderNo)
                    .IsRequired()
                    .HasColumnName("Alloc_ Plan Purc_ Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.AllowInvoiceDisc).HasColumnName("Allow Invoice Disc_");

                entity.Property(e => e.AllowItemChargeAssignment).HasColumnName("Allow Item Charge Assignment");

                entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnName("Amount Including VAT")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ApplFromItemEntry).HasColumnName("Appl_-from Item Entry");

                entity.Property(e => e.ApplToItemEntry).HasColumnName("Appl_-to Item Entry");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.AttachedToLineNo).HasColumnName("Attached to Line No_");

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BinCode)
                    .IsRequired()
                    .HasColumnName("Bin Code")
                    .HasMaxLength(20);

                entity.Property(e => e.BlanketOrderLineNo).HasColumnName("Blanket Order Line No_");

                entity.Property(e => e.BlanketOrderNo)
                    .IsRequired()
                    .HasColumnName("Blanket Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BomItemNo)
                    .IsRequired()
                    .HasColumnName("BOM Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CompletelyShipped).HasColumnName("Completely Shipped");

                entity.Property(e => e.CrossReferenceNo)
                    .IsRequired()
                    .HasColumnName("Cross-Reference No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CrossReferenceType).HasColumnName("Cross-Reference Type");

                entity.Property(e => e.CrossReferenceTypeNo)
                    .IsRequired()
                    .HasColumnName("Cross-Reference Type No_")
                    .HasMaxLength(30);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrentCustPriceGroup)
                    .IsRequired()
                    .HasColumnName("Current Cust_ Price Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrentStoreGroup)
                    .IsRequired()
                    .HasColumnName("Current Store Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerDiscGroup)
                    .IsRequired()
                    .HasColumnName("Customer Disc_ Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPriceGroup)
                    .IsRequired()
                    .HasColumnName("Customer Price Group")
                    .HasMaxLength(10);

                entity.Property(e => e.DeferralCode)
                    .IsRequired()
                    .HasColumnName("Deferral Code")
                    .HasMaxLength(10);

                entity.Property(e => e.DeprUntilFaPostingDate).HasColumnName("Depr_ until FA Posting Date");

                entity.Property(e => e.DepreciationBookCode)
                    .IsRequired()
                    .HasColumnName("Depreciation Book Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("Description 2")
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.Division)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.DropShipment).HasColumnName("Drop Shipment");

                entity.Property(e => e.DuplicateInDepreciationBook)
                    .IsRequired()
                    .HasColumnName("Duplicate in Depreciation Book")
                    .HasMaxLength(10);

                entity.Property(e => e.ExitPoint)
                    .IsRequired()
                    .HasColumnName("Exit Point")
                    .HasMaxLength(10);

                entity.Property(e => e.FaPostingDate)
                    .HasColumnName("FA Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GenProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GrossWeight)
                    .HasColumnName("Gross Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.IcPartnerCode)
                    .IsRequired()
                    .HasColumnName("IC Partner Code")
                    .HasMaxLength(20);

                entity.Property(e => e.IcPartnerRefType).HasColumnName("IC Partner Ref_ Type");

                entity.Property(e => e.IcPartnerReference)
                    .IsRequired()
                    .HasColumnName("IC Partner Reference")
                    .HasMaxLength(20);

                entity.Property(e => e.InvDiscAmountToInvoice)
                    .HasColumnName("Inv_ Disc_ Amount to Invoice")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.InvDiscountAmount)
                    .HasColumnName("Inv_ Discount Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ItemCategoryCode)
                    .IsRequired()
                    .HasColumnName("Item Category Code")
                    .HasMaxLength(20);

                entity.Property(e => e.JobContractEntryNo).HasColumnName("Job Contract Entry No_");

                entity.Property(e => e.JobNo)
                    .IsRequired()
                    .HasColumnName("Job No_")
                    .HasMaxLength(20);

                entity.Property(e => e.JobTaskNo)
                    .IsRequired()
                    .HasColumnName("Job Task No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineAmount)
                    .HasColumnName("Line Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineDiscount)
                    .HasColumnName("Line Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineDiscountAmount)
                    .HasColumnName("Line Discount Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineDiscountCalculation).HasColumnName("Line Discount Calculation");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NetWeight)
                    .HasColumnName("Net Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasColumnName("No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OfferNo)
                    .IsRequired()
                    .HasColumnName("Offer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OriginallyOrderedNo)
                    .IsRequired()
                    .HasColumnName("Originally Ordered No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OriginallyOrderedVarCode)
                    .IsRequired()
                    .HasColumnName("Originally Ordered Var_ Code")
                    .HasMaxLength(10);

                entity.Property(e => e.OutOfStockSubstitution).HasColumnName("Out-of-Stock Substitution");

                entity.Property(e => e.OutboundWhseHandlingTime)
                    .IsRequired()
                    .HasColumnName("Outbound Whse_ Handling Time")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.OutstandingAmount)
                    .HasColumnName("Outstanding Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.OutstandingAmountLcy)
                    .HasColumnName("Outstanding Amount (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.OutstandingQtyBase)
                    .HasColumnName("Outstanding Qty_ (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.OutstandingQuantity)
                    .HasColumnName("Outstanding Quantity")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PlannedDeliveryDate)
                    .HasColumnName("Planned Delivery Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlannedShipmentDate)
                    .HasColumnName("Planned Shipment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .IsRequired()
                    .HasColumnName("Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.Prepayment)
                    .HasColumnName("Prepayment _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepaymentAmount)
                    .HasColumnName("Prepayment Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepaymentLine).HasColumnName("Prepayment Line");

                entity.Property(e => e.PrepaymentTaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Prepayment Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PrepaymentTaxGroupCode)
                    .IsRequired()
                    .HasColumnName("Prepayment Tax Group Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PrepaymentTaxLiable).HasColumnName("Prepayment Tax Liable");

                entity.Property(e => e.PrepaymentVat)
                    .HasColumnName("Prepayment VAT _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepaymentVatDifference)
                    .HasColumnName("Prepayment VAT Difference")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepaymentVatIdentifier)
                    .IsRequired()
                    .HasColumnName("Prepayment VAT Identifier")
                    .HasMaxLength(20);

                entity.Property(e => e.PrepmtAmountInvInclVat)
                    .HasColumnName("Prepmt_ Amount Inv_ Incl_ VAT")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepmtAmountInvLcy)
                    .HasColumnName("Prepmt_ Amount Inv_ (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepmtAmtDeducted)
                    .HasColumnName("Prepmt Amt Deducted")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepmtAmtInclVat)
                    .HasColumnName("Prepmt_ Amt_ Incl_ VAT")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepmtAmtInv)
                    .HasColumnName("Prepmt_ Amt_ Inv_")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepmtAmtToDeduct)
                    .HasColumnName("Prepmt Amt to Deduct")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepmtLineAmount)
                    .HasColumnName("Prepmt_ Line Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepmtVatAmountInvLcy)
                    .HasColumnName("Prepmt_ VAT Amount Inv_ (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepmtVatBaseAmt)
                    .HasColumnName("Prepmt_ VAT Base Amt_")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepmtVatCalcType).HasColumnName("Prepmt_ VAT Calc_ Type");

                entity.Property(e => e.PrepmtVatDiffDeducted)
                    .HasColumnName("Prepmt VAT Diff_ Deducted")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PrepmtVatDiffToDeduct)
                    .HasColumnName("Prepmt VAT Diff_ to Deduct")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PriceDescription)
                    .IsRequired()
                    .HasColumnName("Price description")
                    .HasMaxLength(80);

                entity.Property(e => e.ProductGroupCode)
                    .IsRequired()
                    .HasColumnName("Product Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Profit)
                    .HasColumnName("Profit _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PromisedDeliveryDate)
                    .HasColumnName("Promised Delivery Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PromotionNo)
                    .IsRequired()
                    .HasColumnName("Promotion No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PurchOrderLineNo).HasColumnName("Purch_ Order Line No_");

                entity.Property(e => e.PurchaseOrderNo)
                    .IsRequired()
                    .HasColumnName("Purchase Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PurchasingCode)
                    .IsRequired()
                    .HasColumnName("Purchasing Code")
                    .HasMaxLength(10);

                entity.Property(e => e.QtyInvoicedBase)
                    .HasColumnName("Qty_ Invoiced (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPerUnitOfMeasure)
                    .HasColumnName("Qty_ per Unit of Measure")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyShippedBase)
                    .HasColumnName("Qty_ Shipped (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyShippedNotInvdBase)
                    .HasColumnName("Qty_ Shipped Not Invd_ (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyShippedNotInvoiced)
                    .HasColumnName("Qty_ Shipped Not Invoiced")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToAsmToOrderBase)
                    .HasColumnName("Qty_ to Asm_ to Order (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToAssembleToOrder)
                    .HasColumnName("Qty_ to Assemble to Order")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToInvoice)
                    .HasColumnName("Qty_ to Invoice")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToInvoiceBase)
                    .HasColumnName("Qty_ to Invoice (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToShip)
                    .HasColumnName("Qty_ to Ship")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToShipBase)
                    .HasColumnName("Qty_ to Ship (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityBase)
                    .HasColumnName("Quantity (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityInvoiced)
                    .HasColumnName("Quantity Invoiced")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityShipped)
                    .HasColumnName("Quantity Shipped")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.RecalculateInvoiceDisc).HasColumnName("Recalculate Invoice Disc_");

                entity.Property(e => e.RequestedDeliveryDate)
                    .HasColumnName("Requested Delivery Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.RetQtyRcdNotInvdBase)
                    .HasColumnName("Ret_ Qty_ Rcd_ Not Invd_(Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReturnQtyRcdNotInvd)
                    .HasColumnName("Return Qty_ Rcd_ Not Invd_")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReturnQtyReceived)
                    .HasColumnName("Return Qty_ Received")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReturnQtyReceivedBase)
                    .HasColumnName("Return Qty_ Received (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReturnQtyToReceive)
                    .HasColumnName("Return Qty_ to Receive")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReturnQtyToReceiveBase)
                    .HasColumnName("Return Qty_ to Receive (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReturnRcdNotInvd)
                    .HasColumnName("Return Rcd_ Not Invd_")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReturnRcdNotInvdLcy)
                    .HasColumnName("Return Rcd_ Not Invd_ (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReturnReasonCode)
                    .IsRequired()
                    .HasColumnName("Return Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ReturnReceiptLineNo).HasColumnName("Return Receipt Line No_");

                entity.Property(e => e.ReturnReceiptNo)
                    .IsRequired()
                    .HasColumnName("Return Receipt No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ReturnsDeferralStartDate)
                    .HasColumnName("Returns Deferral Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SellToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipmentDate)
                    .HasColumnName("Shipment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipmentLineNo).HasColumnName("Shipment Line No_");

                entity.Property(e => e.ShipmentNo)
                    .IsRequired()
                    .HasColumnName("Shipment No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippedNotInvLcyNoVat)
                    .HasColumnName("Shipped Not Inv_ (LCY) No VAT")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ShippedNotInvoiced)
                    .HasColumnName("Shipped Not Invoiced")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ShippedNotInvoicedLcy)
                    .HasColumnName("Shipped Not Invoiced (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ShippingAgentCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Service Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingTime)
                    .IsRequired()
                    .HasColumnName("Shipping Time")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SpecialOrder).HasColumnName("Special Order");

                entity.Property(e => e.SpecialOrderPurchLineNo).HasColumnName("Special Order Purch_ Line No_");

                entity.Property(e => e.SpecialOrderPurchaseNo)
                    .IsRequired()
                    .HasColumnName("Special Order Purchase No_")
                    .HasMaxLength(20);

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasColumnName("Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.SystemCreatedEntry).HasColumnName("System-Created Entry");

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxCategory)
                    .IsRequired()
                    .HasColumnName("Tax Category")
                    .HasMaxLength(10);

                entity.Property(e => e.TaxGroupCode)
                    .IsRequired()
                    .HasColumnName("Tax Group Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasColumnName("Transaction Specification")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasColumnName("Transport Method")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitCost)
                    .HasColumnName("Unit Cost")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("Unit Cost (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitOfMeasure)
                    .IsRequired()
                    .HasColumnName("Unit of Measure")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasColumnName("Unit of Measure Code")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitOfMeasureCrossRef)
                    .IsRequired()
                    .HasColumnName("Unit of Measure (Cross Ref_)")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("Unit Price")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitVolume)
                    .HasColumnName("Unit Volume")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitsPerParcel)
                    .HasColumnName("Units per Parcel")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UseDuplicationList).HasColumnName("Use Duplication List");

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBaseAmount)
                    .HasColumnName("VAT Base Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatCalculationType).HasColumnName("VAT Calculation Type");

                entity.Property(e => e.VatClauseCode)
                    .IsRequired()
                    .HasColumnName("VAT Clause Code")
                    .HasMaxLength(20);

                entity.Property(e => e.VatDifference)
                    .HasColumnName("VAT Difference")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatIdentifier)
                    .IsRequired()
                    .HasColumnName("VAT Identifier")
                    .HasMaxLength(20);

                entity.Property(e => e.VatProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VendorNo)
                    .IsRequired()
                    .HasColumnName("Vendor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.WorkTypeCode)
                    .IsRequired()
                    .HasColumnName("Work Type Code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<SalesPrepayment>(entity =>
            {
                entity.HasKey(e => new { e.ItemNo, e.SalesType, e.SalesCode, e.StartingDate });

                entity.ToTable("Sales Prepayment ");

                entity.HasIndex(e => new { e.SalesType, e.SalesCode, e.ItemNo, e.StartingDate })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.ItemNo)
                    .HasColumnName("Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SalesType).HasColumnName("Sales Type");

                entity.Property(e => e.SalesCode)
                    .HasColumnName("Sales Code")
                    .HasMaxLength(20);

                entity.Property(e => e.StartingDate)
                    .HasColumnName("Starting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EndingDate)
                    .HasColumnName("Ending Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Prepayment)
                    .HasColumnName("Prepayment _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<SalesShipmentHeader>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Sales Shipment Header");

                entity.HasIndex(e => new { e.BillToCustomerNo, e.No })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrderNo, e.No })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.PostingDate, e.No })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.RecivingPickingNo, e.No })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.SellToCustomerNo, e.No })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.StatementNo, e.No })
                    .HasName("$6")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");

                entity.Property(e => e.AppliesToDocNo)
                    .IsRequired()
                    .HasColumnName("Applies-to Doc_ No_")
                    .HasMaxLength(20);

                entity.Property(e => e.AppliesToDocType).HasColumnName("Applies-to Doc_ Type");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.BalAccountNo)
                    .IsRequired()
                    .HasColumnName("Bal_ Account No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BalAccountType).HasColumnName("Bal_ Account Type");

                entity.Property(e => e.BillToAddress)
                    .IsRequired()
                    .HasColumnName("Bill-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToAddress2)
                    .IsRequired()
                    .HasColumnName("Bill-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToCity)
                    .IsRequired()
                    .HasColumnName("Bill-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.BillToContact)
                    .IsRequired()
                    .HasColumnName("Bill-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToContactNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BillToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Bill-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BillToCounty)
                    .IsRequired()
                    .HasColumnName("Bill-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BillToName)
                    .IsRequired()
                    .HasColumnName("Bill-to Name")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToName2)
                    .IsRequired()
                    .HasColumnName("Bill-to Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToPostCode)
                    .IsRequired()
                    .HasColumnName("Bill-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.CampaignNo)
                    .IsRequired()
                    .HasColumnName("Campaign No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyFactor)
                    .HasColumnName("Currency Factor")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CustomerDiscGroup)
                    .IsRequired()
                    .HasColumnName("Customer Disc_ Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPostingGroup)
                    .IsRequired()
                    .HasColumnName("Customer Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPriceGroup)
                    .IsRequired()
                    .HasColumnName("Customer Price Group")
                    .HasMaxLength(10);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.DocumentDate)
                    .HasColumnName("Document Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Eu3PartyTrade).HasColumnName("EU 3-Party Trade");

                entity.Property(e => e.ExitPoint)
                    .IsRequired()
                    .HasColumnName("Exit Point")
                    .HasMaxLength(10);

                entity.Property(e => e.ExternalDocumentNo)
                    .IsRequired()
                    .HasColumnName("External Document No_")
                    .HasMaxLength(35);

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceDiscCode)
                    .IsRequired()
                    .HasColumnName("Invoice Disc_ Code")
                    .HasMaxLength(20);

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasColumnName("Language Code")
                    .HasMaxLength(10);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MemberCardNo)
                    .IsRequired()
                    .HasColumnName("Member Card No_")
                    .HasMaxLength(100);

                entity.Property(e => e.NoPrinted).HasColumnName("No_ Printed");

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.OnHold)
                    .IsRequired()
                    .HasColumnName("On Hold")
                    .HasMaxLength(3);

                entity.Property(e => e.OpportunityNo)
                    .IsRequired()
                    .HasColumnName("Opportunity No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasColumnName("Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderNoSeries)
                    .IsRequired()
                    .HasColumnName("Order No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.OutboundWhseHandlingTime)
                    .IsRequired()
                    .HasColumnName("Outbound Whse_ Handling Time")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PackageTrackingNo)
                    .IsRequired()
                    .HasColumnName("Package Tracking No_")
                    .HasMaxLength(30);

                entity.Property(e => e.PaymentDiscount)
                    .HasColumnName("Payment Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PaymentMethodCode)
                    .IsRequired()
                    .HasColumnName("Payment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentTermsCode)
                    .IsRequired()
                    .HasColumnName("Payment Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PmtDiscountDate)
                    .HasColumnName("Pmt_ Discount Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .IsRequired()
                    .HasColumnName("Posting Description")
                    .HasMaxLength(50);

                entity.Property(e => e.PricesIncludingVat).HasColumnName("Prices Including VAT");

                entity.Property(e => e.PromisedDeliveryDate)
                    .HasColumnName("Promised Delivery Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.QuoteNo)
                    .IsRequired()
                    .HasColumnName("Quote No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasColumnName("Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.RecivingPickingNo)
                    .IsRequired()
                    .HasColumnName("Reciving_Picking No_")
                    .HasMaxLength(20);

                entity.Property(e => e.RequestedDeliveryDate)
                    .HasColumnName("Requested Delivery Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.RetailStatus).HasColumnName("Retail Status");

                entity.Property(e => e.SalespersonCode)
                    .IsRequired()
                    .HasColumnName("Salesperson Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToAddress)
                    .IsRequired()
                    .HasColumnName("Sell-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToAddress2)
                    .IsRequired()
                    .HasColumnName("Sell-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToCity)
                    .IsRequired()
                    .HasColumnName("Sell-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.SellToContact)
                    .IsRequired()
                    .HasColumnName("Sell-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToContactNo)
                    .IsRequired()
                    .HasColumnName("Sell-to Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Sell-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SellToCounty)
                    .IsRequired()
                    .HasColumnName("Sell-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.SellToCustomerName)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer Name")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToCustomerName2)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.SellToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SellToPostCode)
                    .IsRequired()
                    .HasColumnName("Sell-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipToAddress)
                    .IsRequired()
                    .HasColumnName("Ship-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToAddress2)
                    .IsRequired()
                    .HasColumnName("Ship-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCity)
                    .IsRequired()
                    .HasColumnName("Ship-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToContact)
                    .IsRequired()
                    .HasColumnName("Ship-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToCounty)
                    .IsRequired()
                    .HasColumnName("Ship-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToName)
                    .IsRequired()
                    .HasColumnName("Ship-to Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToName2)
                    .IsRequired()
                    .HasColumnName("Ship-to Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToPostCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipmentDate)
                    .HasColumnName("Shipment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .IsRequired()
                    .HasColumnName("Shipment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAgentCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Service Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingTime)
                    .IsRequired()
                    .HasColumnName("Shipping Time")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasColumnName("Source Code")
                    .HasMaxLength(10);

                entity.Property(e => e.StatementNo)
                    .IsRequired()
                    .HasColumnName("Statement No_")
                    .HasMaxLength(20);

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasColumnName("Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasColumnName("Transaction Specification")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasColumnName("Transport Method")
                    .HasMaxLength(10);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User ID")
                    .HasMaxLength(50);

                entity.Property(e => e.VatBaseDiscount)
                    .HasColumnName("VAT Base Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("VAT Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VatRegistrationNo)
                    .IsRequired()
                    .HasColumnName("VAT Registration No_")
                    .HasMaxLength(20);

                entity.Property(e => e.YourReference)
                    .IsRequired()
                    .HasColumnName("Your Reference")
                    .HasMaxLength(35);
            });

            modelBuilder.Entity<SalesShipmentLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.LineNo });

                entity.ToTable("Sales Shipment Line");

                entity.HasIndex(e => new { e.BillToCustomerNo, e.DocumentNo, e.LineNo })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemShptEntryNo, e.DocumentNo, e.LineNo })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.SellToCustomerNo, e.DocumentNo, e.LineNo })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.BlanketOrderNo, e.BlanketOrderLineNo, e.DocumentNo, e.LineNo })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.OrderNo, e.OrderLineNo, e.DocumentNo, e.LineNo })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasColumnName("Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.AllowInvoiceDisc).HasColumnName("Allow Invoice Disc_");

                entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");

                entity.Property(e => e.ApplFromItemEntry).HasColumnName("Appl_-from Item Entry");

                entity.Property(e => e.ApplToItemEntry).HasColumnName("Appl_-to Item Entry");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.AttachedToLineNo).HasColumnName("Attached to Line No_");

                entity.Property(e => e.AuthorizedForCreditCard).HasColumnName("Authorized for Credit Card");

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BinCode)
                    .IsRequired()
                    .HasColumnName("Bin Code")
                    .HasMaxLength(20);

                entity.Property(e => e.BlanketOrderLineNo).HasColumnName("Blanket Order Line No_");

                entity.Property(e => e.BlanketOrderNo)
                    .IsRequired()
                    .HasColumnName("Blanket Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CrossReferenceNo)
                    .IsRequired()
                    .HasColumnName("Cross-Reference No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CrossReferenceType).HasColumnName("Cross-Reference Type");

                entity.Property(e => e.CrossReferenceTypeNo)
                    .IsRequired()
                    .HasColumnName("Cross-Reference Type No_")
                    .HasMaxLength(30);

                entity.Property(e => e.CustomerDiscGroup)
                    .IsRequired()
                    .HasColumnName("Customer Disc_ Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPriceGroup)
                    .IsRequired()
                    .HasColumnName("Customer Price Group")
                    .HasMaxLength(10);

                entity.Property(e => e.DeprUntilFaPostingDate).HasColumnName("Depr_ until FA Posting Date");

                entity.Property(e => e.DepreciationBookCode)
                    .IsRequired()
                    .HasColumnName("Depreciation Book Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("Description 2")
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.DropShipment).HasColumnName("Drop Shipment");

                entity.Property(e => e.DuplicateInDepreciationBook)
                    .IsRequired()
                    .HasColumnName("Duplicate in Depreciation Book")
                    .HasMaxLength(10);

                entity.Property(e => e.ExitPoint)
                    .IsRequired()
                    .HasColumnName("Exit Point")
                    .HasMaxLength(10);

                entity.Property(e => e.FaPostingDate)
                    .HasColumnName("FA Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GenProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GrossWeight)
                    .HasColumnName("Gross Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ItemCategoryCode)
                    .IsRequired()
                    .HasColumnName("Item Category Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ItemChargeBaseAmount)
                    .HasColumnName("Item Charge Base Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ItemShptEntryNo).HasColumnName("Item Shpt_ Entry No_");

                entity.Property(e => e.JobContractEntryNo).HasColumnName("Job Contract Entry No_");

                entity.Property(e => e.JobNo)
                    .IsRequired()
                    .HasColumnName("Job No_")
                    .HasMaxLength(20);

                entity.Property(e => e.JobTaskNo)
                    .IsRequired()
                    .HasColumnName("Job Task No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineDiscount)
                    .HasColumnName("Line Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NetWeight)
                    .HasColumnName("Net Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasColumnName("No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderLineNo).HasColumnName("Order Line No_");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasColumnName("Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OutboundWhseHandlingTime)
                    .IsRequired()
                    .HasColumnName("Outbound Whse_ Handling Time")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PlannedDeliveryDate)
                    .HasColumnName("Planned Delivery Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PlannedShipmentDate)
                    .HasColumnName("Planned Shipment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .IsRequired()
                    .HasColumnName("Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.ProductGroupCode)
                    .IsRequired()
                    .HasColumnName("Product Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PromisedDeliveryDate)
                    .HasColumnName("Promised Delivery Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchOrderLineNo).HasColumnName("Purch_ Order Line No_");

                entity.Property(e => e.PurchaseOrderNo)
                    .IsRequired()
                    .HasColumnName("Purchase Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PurchasingCode)
                    .IsRequired()
                    .HasColumnName("Purchasing Code")
                    .HasMaxLength(10);

                entity.Property(e => e.QtyInvoicedBase)
                    .HasColumnName("Qty_ Invoiced (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPerUnitOfMeasure)
                    .HasColumnName("Qty_ per Unit of Measure")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyShippedNotInvoiced)
                    .HasColumnName("Qty_ Shipped Not Invoiced")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityBase)
                    .HasColumnName("Quantity (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityInvoiced)
                    .HasColumnName("Quantity Invoiced")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.RequestedDeliveryDate)
                    .HasColumnName("Requested Delivery Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.ReturnReasonCode)
                    .IsRequired()
                    .HasColumnName("Return Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SellToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Sell-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipmentDate)
                    .HasColumnName("Shipment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShippingTime)
                    .IsRequired()
                    .HasColumnName("Shipping Time")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxGroupCode)
                    .IsRequired()
                    .HasColumnName("Tax Group Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasColumnName("Transaction Specification")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasColumnName("Transport Method")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitCost)
                    .HasColumnName("Unit Cost")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("Unit Cost (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitOfMeasure)
                    .IsRequired()
                    .HasColumnName("Unit of Measure")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasColumnName("Unit of Measure Code")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitOfMeasureCrossRef)
                    .IsRequired()
                    .HasColumnName("Unit of Measure (Cross Ref_)")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("Unit Price")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitVolume)
                    .HasColumnName("Unit Volume")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitsPerParcel)
                    .HasColumnName("Units per Parcel")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UseDuplicationList).HasColumnName("Use Duplication List");

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBaseAmount)
                    .HasColumnName("VAT Base Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatCalculationType).HasColumnName("VAT Calculation Type");

                entity.Property(e => e.VatProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VendorNo)
                    .IsRequired()
                    .HasColumnName("Vendor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.WorkTypeCode)
                    .IsRequired()
                    .HasColumnName("Work Type Code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<SalesStatistics>(entity =>
            {
                entity.HasKey(e => new { e.StoreNo, e.EntryNo });

                entity.ToTable("Sales Statistics");

                entity.HasIndex(e => new { e.StoreNo, e.Code, e.Date, e.Time, e.EntryNo })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.StoreNo)
                    .HasColumnName("Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.EntryNo).HasColumnName("Entry No_");

                entity.Property(e => e.AddCurrCostAmount)
                    .HasColumnName("Add_-Curr_ Cost Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AddCurrDiscountAmount)
                    .HasColumnName("Add_-Curr Discount Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AddCurrSalesAmount)
                    .HasColumnName("Add_-Curr_ Sales Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AddCurrTotalDiscount)
                    .HasColumnName("Add_-Curr Total Discount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AddCurrVatAmount)
                    .HasColumnName("Add_-Curr_ Vat Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Code)
                    .IsRequired()
                    .HasMaxLength(20);

                entity.Property(e => e.CostAmount)
                    .HasColumnName("Cost Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnName("Discount Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ItemsScanned)
                    .HasColumnName("Items Scanned")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ItemsSold)
                    .HasColumnName("Items Sold")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.NoOfDepartmentSales)
                    .HasColumnName("No_ of Department Sales")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.NoOfReturns)
                    .HasColumnName("No_ of Returns")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.NoOfSalesTransEntries)
                    .HasColumnName("No_ of Sales Trans_ Entries")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.SalesAmount)
                    .HasColumnName("Sales Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Time).HasColumnType("datetime");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TotalDiscount)
                    .HasColumnName("Total Discount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatAmount)
                    .HasColumnName("VAT Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VoidedAmount)
                    .HasColumnName("Voided Amount")
                    .HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<ServiceBookings>(entity =>
            {
                entity.HasKey(e => e.EntryNo);

                entity.ToTable("Service Bookings");

                entity.HasIndex(e => new { e.ReservationId, e.EntryNo })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.TimeSlotNo, e.Canceled, e.EntryNo })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.EntryNo).HasColumnName("Entry No_");

                entity.Property(e => e.Capacity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EndingTime)
                    .HasColumnName("Ending Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReservationId).HasColumnName("Reservation ID");

                entity.Property(e => e.SalesOrderNo)
                    .IsRequired()
                    .HasColumnName("Sales Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceProductNo)
                    .IsRequired()
                    .HasColumnName("Service Product No_")
                    .HasMaxLength(20);

                entity.Property(e => e.StartingTime)
                    .HasColumnName("Starting Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasColumnName("Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.TimeSlotNo).HasColumnName("Time Slot No_");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.Volume).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Weight).HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<ServiceContractHeader>(entity =>
            {
                entity.HasKey(e => new { e.ContractType, e.ContractNo });

                entity.ToTable("Service Contract Header");

                entity.HasIndex(e => new { e.ContractNo, e.ContractType })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.NextPriceUpdateDate, e.ContractType, e.ContractNo })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.TemplateNo, e.ContractType, e.ContractNo })
                    .HasName("$7")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerNo, e.ShipToCode, e.ContractType, e.ContractNo })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.SalespersonCode, e.Status, e.ContractType, e.ContractNo })
                    .HasName("$6")
                    .IsUnique();

                entity.HasIndex(e => new { e.BillToCustomerNo, e.ContractType, e.CombineInvoices, e.NextInvoiceDate, e.ContractNo })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.ResponsibilityCenter, e.ServiceZoneCode, e.Status, e.ContractGroupCode, e.ContractType, e.ContractNo })
                    .HasName("$5")
                    .IsUnique();

                entity.Property(e => e.ContractType).HasColumnName("Contract Type");

                entity.Property(e => e.ContractNo)
                    .HasColumnName("Contract No_")
                    .HasMaxLength(20);

                entity.Property(e => e.AcceptBefore)
                    .HasColumnName("Accept Before")
                    .HasColumnType("datetime");

                entity.Property(e => e.AllowUnbalancedAmounts).HasColumnName("Allow Unbalanced Amounts");

                entity.Property(e => e.AmountPerPeriod)
                    .HasColumnName("Amount per Period")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AnnualAmount)
                    .HasColumnName("Annual Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AutomaticCreditMemos).HasColumnName("Automatic Credit Memos");

                entity.Property(e => e.BillToContact)
                    .IsRequired()
                    .HasColumnName("Bill-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToContactNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CancelReasonCode)
                    .IsRequired()
                    .HasColumnName("Cancel Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ChangeStatus).HasColumnName("Change Status");

                entity.Property(e => e.CombineInvoices).HasColumnName("Combine Invoices");

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasColumnName("Contact Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactNo)
                    .IsRequired()
                    .HasColumnName("Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ContractGroupCode)
                    .IsRequired()
                    .HasColumnName("Contract Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ContractLinesOnInvoice).HasColumnName("Contract Lines on Invoice");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CustomerNo)
                    .IsRequired()
                    .HasColumnName("Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("Description 2")
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("E-Mail")
                    .HasMaxLength(80);

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FaxNo)
                    .IsRequired()
                    .HasColumnName("Fax No_")
                    .HasMaxLength(30);

                entity.Property(e => e.FirstServiceDate)
                    .HasColumnName("First Service Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InvoiceAfterService).HasColumnName("Invoice after Service");

                entity.Property(e => e.InvoicePeriod).HasColumnName("Invoice Period");

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasColumnName("Language Code")
                    .HasMaxLength(10);

                entity.Property(e => e.LastInvoiceDate)
                    .HasColumnName("Last Invoice Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastInvoicePeriodEnd)
                    .HasColumnName("Last Invoice Period End")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastPriceUpdate)
                    .HasColumnName("Last Price Update _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LastPriceUpdateDate)
                    .HasColumnName("Last Price Update Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.MaxLaborUnitPrice)
                    .HasColumnName("Max_ Labor Unit Price")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.NextInvoiceDate)
                    .HasColumnName("Next Invoice Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NextInvoicePeriod)
                    .IsRequired()
                    .HasColumnName("Next Invoice Period")
                    .HasMaxLength(30);

                entity.Property(e => e.NextInvoicePeriodEnd)
                    .HasColumnName("Next Invoice Period End")
                    .HasColumnType("datetime");

                entity.Property(e => e.NextInvoicePeriodStart)
                    .HasColumnName("Next Invoice Period Start")
                    .HasColumnType("datetime");

                entity.Property(e => e.NextPriceUpdateDate)
                    .HasColumnName("Next Price Update Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.PaymentTermsCode)
                    .IsRequired()
                    .HasColumnName("Payment Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasColumnName("Phone No_")
                    .HasMaxLength(30);

                entity.Property(e => e.PriceInvIncreaseCode)
                    .IsRequired()
                    .HasColumnName("Price Inv_ Increase Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PriceUpdatePeriod)
                    .IsRequired()
                    .HasColumnName("Price Update Period")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.PrintIncreaseText).HasColumnName("Print Increase Text");

                entity.Property(e => e.Probability).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuoteType).HasColumnName("Quote Type");

                entity.Property(e => e.ResponseTimeHours)
                    .HasColumnName("Response Time (Hours)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.SalespersonCode)
                    .IsRequired()
                    .HasColumnName("Salesperson Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ServContractAccGrCode)
                    .IsRequired()
                    .HasColumnName("Serv_ Contract Acc_ Gr_ Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ServiceOrderType)
                    .IsRequired()
                    .HasColumnName("Service Order Type")
                    .HasMaxLength(10);

                entity.Property(e => e.ServicePeriod)
                    .IsRequired()
                    .HasColumnName("Service Period")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceZoneCode)
                    .IsRequired()
                    .HasColumnName("Service Zone Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.StartingDate)
                    .HasColumnName("Starting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TemplateNo)
                    .IsRequired()
                    .HasColumnName("Template No_")
                    .HasMaxLength(20);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.YourReference)
                    .IsRequired()
                    .HasColumnName("Your Reference")
                    .HasMaxLength(35);
            });

            modelBuilder.Entity<ServiceContractLine>(entity =>
            {
                entity.HasKey(e => new { e.ContractType, e.ContractNo, e.LineNo });

                entity.ToTable("Service Contract Line");

                entity.HasIndex(e => new { e.ContractNo, e.LineNo, e.ContractType })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerNo, e.ShipToCode, e.ContractType, e.ContractNo, e.LineNo })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.ServiceItemNo, e.ContractStatus, e.ContractType, e.ContractNo, e.LineNo })
                    .HasName("$2")
                    .IsUnique();

                entity.Property(e => e.ContractType).HasColumnName("Contract Type");

                entity.Property(e => e.ContractNo)
                    .HasColumnName("Contract No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.ContractExpirationDate)
                    .HasColumnName("Contract Expiration Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ContractStatus).HasColumnName("Contract Status");

                entity.Property(e => e.CreditMemoDate)
                    .HasColumnName("Credit Memo Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CustomerNo)
                    .IsRequired()
                    .HasColumnName("Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.InvoicedToDate)
                    .HasColumnName("Invoiced to Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItemNo)
                    .IsRequired()
                    .HasColumnName("Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LastPlannedServiceDate)
                    .HasColumnName("Last Planned Service Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastPreventiveMaintDate)
                    .HasColumnName("Last Preventive Maint_ Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastServiceDate)
                    .HasColumnName("Last Service Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LineAmount)
                    .HasColumnName("Line Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineCost)
                    .HasColumnName("Line Cost")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineDiscount)
                    .HasColumnName("Line Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineDiscountAmount)
                    .HasColumnName("Line Discount Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineValue)
                    .HasColumnName("Line Value")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.NewLine).HasColumnName("New Line");

                entity.Property(e => e.NextPlannedServiceDate)
                    .HasColumnName("Next Planned Service Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Profit).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ResponseTimeHours)
                    .HasColumnName("Response Time (Hours)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.SerialNo)
                    .IsRequired()
                    .HasColumnName("Serial No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceItemGroupCode)
                    .IsRequired()
                    .HasColumnName("Service Item Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ServiceItemNo)
                    .IsRequired()
                    .HasColumnName("Service Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServicePeriod)
                    .IsRequired()
                    .HasColumnName("Service Period")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShipToCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Code")
                    .HasMaxLength(10);

                entity.Property(e => e.StartingDate)
                    .HasColumnName("Starting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasColumnName("Unit of Measure Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ServiceHeader>(entity =>
            {
                entity.HasKey(e => new { e.DocumentType, e.No });

                entity.ToTable("Service Header");

                entity.HasIndex(e => new { e.No, e.DocumentType })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerNo, e.OrderDate, e.DocumentType, e.No })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.ContractNo, e.Status, e.PostingDate, e.DocumentType, e.No })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.Status, e.Priority, e.ResponseDate, e.ResponseTime, e.DocumentType, e.No })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.Status, e.ResponseDate, e.ResponseTime, e.Priority, e.DocumentType, e.No })
                    .HasName("$4")
                    .IsUnique();

                entity.Property(e => e.DocumentType).HasColumnName("Document Type");

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ActualResponseTimeHours)
                    .HasColumnName("Actual Response Time (Hours)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnName("Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");

                entity.Property(e => e.AppliesToDocNo)
                    .IsRequired()
                    .HasColumnName("Applies-to Doc_ No_")
                    .HasMaxLength(20);

                entity.Property(e => e.AppliesToDocType).HasColumnName("Applies-to Doc_ Type");

                entity.Property(e => e.AppliesToId)
                    .IsRequired()
                    .HasColumnName("Applies-to ID")
                    .HasMaxLength(50);

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.AssignedUserId)
                    .IsRequired()
                    .HasColumnName("Assigned User ID")
                    .HasMaxLength(50);

                entity.Property(e => e.BalAccountNo)
                    .IsRequired()
                    .HasColumnName("Bal_ Account No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BalAccountType).HasColumnName("Bal_ Account Type");

                entity.Property(e => e.BillToAddress)
                    .IsRequired()
                    .HasColumnName("Bill-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToAddress2)
                    .IsRequired()
                    .HasColumnName("Bill-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToCity)
                    .IsRequired()
                    .HasColumnName("Bill-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.BillToContact)
                    .IsRequired()
                    .HasColumnName("Bill-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToContactNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BillToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Bill-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BillToCounty)
                    .IsRequired()
                    .HasColumnName("Bill-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BillToName)
                    .IsRequired()
                    .HasColumnName("Bill-to Name")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToName2)
                    .IsRequired()
                    .HasColumnName("Bill-to Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToPostCode)
                    .IsRequired()
                    .HasColumnName("Bill-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasColumnName("Contact Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactNo)
                    .IsRequired()
                    .HasColumnName("Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ContractNo)
                    .IsRequired()
                    .HasColumnName("Contract No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.County)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyFactor)
                    .HasColumnName("Currency Factor")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CustomerDiscGroup)
                    .IsRequired()
                    .HasColumnName("Customer Disc_ Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerNo)
                    .IsRequired()
                    .HasColumnName("Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPostingGroup)
                    .IsRequired()
                    .HasColumnName("Customer Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPriceGroup)
                    .IsRequired()
                    .HasColumnName("Customer Price Group")
                    .HasMaxLength(10);

                entity.Property(e => e.DefaultResponseTimeHours)
                    .HasColumnName("Default Response Time (Hours)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.DocumentDate)
                    .HasColumnName("Document Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("E-Mail")
                    .HasMaxLength(80);

                entity.Property(e => e.Eu3PartyTrade).HasColumnName("EU 3-Party Trade");

                entity.Property(e => e.ExitPoint)
                    .IsRequired()
                    .HasColumnName("Exit Point")
                    .HasMaxLength(10);

                entity.Property(e => e.ExpectedFinishingDate)
                    .HasColumnName("Expected Finishing Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FaxNo)
                    .IsRequired()
                    .HasColumnName("Fax No_")
                    .HasMaxLength(30);

                entity.Property(e => e.FinishingDate)
                    .HasColumnName("Finishing Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinishingTime)
                    .HasColumnName("Finishing Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceDiscCode)
                    .IsRequired()
                    .HasColumnName("Invoice Disc_ Code")
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceDiscountCalculation).HasColumnName("Invoice Discount Calculation");

                entity.Property(e => e.InvoiceDiscountValue)
                    .HasColumnName("Invoice Discount Value")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasColumnName("Language Code")
                    .HasMaxLength(10);

                entity.Property(e => e.LastPostingNo)
                    .IsRequired()
                    .HasColumnName("Last Posting No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LastShippingNo)
                    .IsRequired()
                    .HasColumnName("Last Shipping No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LinkServiceToServiceItem).HasColumnName("Link Service to Service Item");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MaxLaborUnitPrice)
                    .HasColumnName("Max_ Labor Unit Price")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name2)
                    .IsRequired()
                    .HasColumnName("Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.NoPrinted).HasColumnName("No_ Printed");

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.NotifyCustomer).HasColumnName("Notify Customer");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderTime)
                    .HasColumnName("Order Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentDiscount)
                    .HasColumnName("Payment Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PaymentMethodCode)
                    .IsRequired()
                    .HasColumnName("Payment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentTermsCode)
                    .IsRequired()
                    .HasColumnName("Payment Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasColumnName("Phone No_")
                    .HasMaxLength(30);

                entity.Property(e => e.PhoneNo2)
                    .IsRequired()
                    .HasColumnName("Phone No_ 2")
                    .HasMaxLength(30);

                entity.Property(e => e.PmtDiscountDate)
                    .HasColumnName("Pmt_ Discount Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostCode)
                    .IsRequired()
                    .HasColumnName("Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .IsRequired()
                    .HasColumnName("Posting Description")
                    .HasMaxLength(50);

                entity.Property(e => e.PostingNo)
                    .IsRequired()
                    .HasColumnName("Posting No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingNoSeries)
                    .IsRequired()
                    .HasColumnName("Posting No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.PricesIncludingVat).HasColumnName("Prices Including VAT");

                entity.Property(e => e.QuoteNo)
                    .IsRequired()
                    .HasColumnName("Quote No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasColumnName("Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ReleaseStatus).HasColumnName("Release Status");

                entity.Property(e => e.ResponseDate)
                    .HasColumnName("Response Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponseTime)
                    .HasColumnName("Response Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.SalespersonCode)
                    .IsRequired()
                    .HasColumnName("Salesperson Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceOrderType)
                    .IsRequired()
                    .HasColumnName("Service Order Type")
                    .HasMaxLength(10);

                entity.Property(e => e.ServiceTimeHours)
                    .HasColumnName("Service Time (Hours)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ServiceZoneCode)
                    .IsRequired()
                    .HasColumnName("Service Zone Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToAddress)
                    .IsRequired()
                    .HasColumnName("Ship-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToAddress2)
                    .IsRequired()
                    .HasColumnName("Ship-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCity)
                    .IsRequired()
                    .HasColumnName("Ship-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToContact)
                    .IsRequired()
                    .HasColumnName("Ship-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToCounty)
                    .IsRequired()
                    .HasColumnName("Ship-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToEMail)
                    .IsRequired()
                    .HasColumnName("Ship-to E-Mail")
                    .HasMaxLength(80);

                entity.Property(e => e.ShipToFaxNo)
                    .IsRequired()
                    .HasColumnName("Ship-to Fax No_")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToName)
                    .IsRequired()
                    .HasColumnName("Ship-to Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToName2)
                    .IsRequired()
                    .HasColumnName("Ship-to Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToPhone)
                    .IsRequired()
                    .HasColumnName("Ship-to Phone")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToPhone2)
                    .IsRequired()
                    .HasColumnName("Ship-to Phone 2")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToPostCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipmentMethodCode)
                    .IsRequired()
                    .HasColumnName("Shipment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAdvice).HasColumnName("Shipping Advice");

                entity.Property(e => e.ShippingAgentCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Service Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingNo)
                    .IsRequired()
                    .HasColumnName("Shipping No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippingNoSeries)
                    .IsRequired()
                    .HasColumnName("Shipping No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippingTime)
                    .IsRequired()
                    .HasColumnName("Shipping Time")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.StartingDate)
                    .HasColumnName("Starting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartingTime)
                    .HasColumnName("Starting Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasColumnName("Transaction Specification")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasColumnName("Transport Method")
                    .HasMaxLength(10);

                entity.Property(e => e.VatBaseDiscount)
                    .HasColumnName("VAT Base Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("VAT Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VatRegistrationNo)
                    .IsRequired()
                    .HasColumnName("VAT Registration No_")
                    .HasMaxLength(20);

                entity.Property(e => e.WarningStatus).HasColumnName("Warning Status");

                entity.Property(e => e.YourReference)
                    .IsRequired()
                    .HasColumnName("Your Reference")
                    .HasMaxLength(35);
            });

            modelBuilder.Entity<ServiceInvoiceHeader>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Service Invoice Header");

                entity.HasIndex(e => new { e.OrderNo, e.No })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ContractNo, e.PostingDate, e.No })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerNo, e.OrderDate, e.No })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.Priority, e.ResponseDate, e.ResponseTime, e.No })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.ResponseDate, e.ResponseTime, e.Priority, e.No })
                    .HasName("$4")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActualResponseTimeHours)
                    .HasColumnName("Actual Response Time (Hours)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnName("Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");

                entity.Property(e => e.AppliesToDocNo)
                    .IsRequired()
                    .HasColumnName("Applies-to Doc_ No_")
                    .HasMaxLength(20);

                entity.Property(e => e.AppliesToDocType).HasColumnName("Applies-to Doc_ Type");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.BalAccountNo)
                    .IsRequired()
                    .HasColumnName("Bal_ Account No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BalAccountType).HasColumnName("Bal_ Account Type");

                entity.Property(e => e.BillToAddress)
                    .IsRequired()
                    .HasColumnName("Bill-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToAddress2)
                    .IsRequired()
                    .HasColumnName("Bill-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToCity)
                    .IsRequired()
                    .HasColumnName("Bill-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.BillToContact)
                    .IsRequired()
                    .HasColumnName("Bill-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToContactNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BillToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Bill-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BillToCounty)
                    .IsRequired()
                    .HasColumnName("Bill-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BillToName)
                    .IsRequired()
                    .HasColumnName("Bill-to Name")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToName2)
                    .IsRequired()
                    .HasColumnName("Bill-to Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.BillToPostCode)
                    .IsRequired()
                    .HasColumnName("Bill-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.ContactName)
                    .IsRequired()
                    .HasColumnName("Contact Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ContactNo)
                    .IsRequired()
                    .HasColumnName("Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ContractNo)
                    .IsRequired()
                    .HasColumnName("Contract No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.County)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyFactor)
                    .HasColumnName("Currency Factor")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CustomerDiscGroup)
                    .IsRequired()
                    .HasColumnName("Customer Disc_ Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerNo)
                    .IsRequired()
                    .HasColumnName("Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPostingGroup)
                    .IsRequired()
                    .HasColumnName("Customer Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPriceGroup)
                    .IsRequired()
                    .HasColumnName("Customer Price Group")
                    .HasMaxLength(10);

                entity.Property(e => e.DefaultResponseTimeHours)
                    .HasColumnName("Default Response Time (Hours)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.DocExchOriginalIdentifier)
                    .IsRequired()
                    .HasColumnName("Doc_ Exch_ Original Identifier")
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentDate)
                    .HasColumnName("Document Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentExchangeIdentifier)
                    .IsRequired()
                    .HasColumnName("Document Exchange Identifier")
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentExchangeStatus).HasColumnName("Document Exchange Status");

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("E-Mail")
                    .HasMaxLength(80);

                entity.Property(e => e.Eu3PartyTrade).HasColumnName("EU 3-Party Trade");

                entity.Property(e => e.ExitPoint)
                    .IsRequired()
                    .HasColumnName("Exit Point")
                    .HasMaxLength(10);

                entity.Property(e => e.ExpectedFinishingDate)
                    .HasColumnName("Expected Finishing Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FaxNo)
                    .IsRequired()
                    .HasColumnName("Fax No_")
                    .HasMaxLength(30);

                entity.Property(e => e.FinishingDate)
                    .HasColumnName("Finishing Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinishingTime)
                    .HasColumnName("Finishing Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.InvoiceDiscCode)
                    .IsRequired()
                    .HasColumnName("Invoice Disc_ Code")
                    .HasMaxLength(20);

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasColumnName("Language Code")
                    .HasMaxLength(10);

                entity.Property(e => e.LastPostingNo)
                    .IsRequired()
                    .HasColumnName("Last Posting No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LastShippingNo)
                    .IsRequired()
                    .HasColumnName("Last Shipping No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LinkServiceToServiceItem).HasColumnName("Link Service to Service Item");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MaxLaborUnitPrice)
                    .HasColumnName("Max_ Labor Unit Price")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name2)
                    .IsRequired()
                    .HasColumnName("Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.NoPrinted).HasColumnName("No_ Printed");

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.NotifyCustomer).HasColumnName("Notify Customer");

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OrderNo)
                    .IsRequired()
                    .HasColumnName("Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderNoSeries)
                    .IsRequired()
                    .HasColumnName("Order No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderTime)
                    .HasColumnName("Order Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.PaymentDiscount)
                    .HasColumnName("Payment Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PaymentMethodCode)
                    .IsRequired()
                    .HasColumnName("Payment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentTermsCode)
                    .IsRequired()
                    .HasColumnName("Payment Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasColumnName("Phone No_")
                    .HasMaxLength(30);

                entity.Property(e => e.PhoneNo2)
                    .IsRequired()
                    .HasColumnName("Phone No_ 2")
                    .HasMaxLength(30);

                entity.Property(e => e.PmtDiscountDate)
                    .HasColumnName("Pmt_ Discount Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostCode)
                    .IsRequired()
                    .HasColumnName("Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingDescription)
                    .IsRequired()
                    .HasColumnName("Posting Description")
                    .HasMaxLength(50);

                entity.Property(e => e.PostingNo)
                    .IsRequired()
                    .HasColumnName("Posting No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PreAssignedNo)
                    .IsRequired()
                    .HasColumnName("Pre-Assigned No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PreAssignedNoSeries)
                    .IsRequired()
                    .HasColumnName("Pre-Assigned No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.PricesIncludingVat).HasColumnName("Prices Including VAT");

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasColumnName("Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ResponseDate)
                    .HasColumnName("Response Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponseTime)
                    .HasColumnName("Response Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.SalespersonCode)
                    .IsRequired()
                    .HasColumnName("Salesperson Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceOrderType)
                    .IsRequired()
                    .HasColumnName("Service Order Type")
                    .HasMaxLength(10);

                entity.Property(e => e.ServiceTimeHours)
                    .HasColumnName("Service Time (Hours)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ServiceZoneCode)
                    .IsRequired()
                    .HasColumnName("Service Zone Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToAddress)
                    .IsRequired()
                    .HasColumnName("Ship-to Address")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToAddress2)
                    .IsRequired()
                    .HasColumnName("Ship-to Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCity)
                    .IsRequired()
                    .HasColumnName("Ship-to City")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToContact)
                    .IsRequired()
                    .HasColumnName("Ship-to Contact")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToCounty)
                    .IsRequired()
                    .HasColumnName("Ship-to County")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToEMail)
                    .IsRequired()
                    .HasColumnName("Ship-to E-Mail")
                    .HasMaxLength(80);

                entity.Property(e => e.ShipToFaxNo)
                    .IsRequired()
                    .HasColumnName("Ship-to Fax No_")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToName)
                    .IsRequired()
                    .HasColumnName("Ship-to Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToName2)
                    .IsRequired()
                    .HasColumnName("Ship-to Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipToPhone)
                    .IsRequired()
                    .HasColumnName("Ship-to Phone")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToPhone2)
                    .IsRequired()
                    .HasColumnName("Ship-to Phone 2")
                    .HasMaxLength(30);

                entity.Property(e => e.ShipToPostCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippingNo)
                    .IsRequired()
                    .HasColumnName("Shipping No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippingNoSeries)
                    .IsRequired()
                    .HasColumnName("Shipping No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasColumnName("Source Code")
                    .HasMaxLength(10);

                entity.Property(e => e.StartingDate)
                    .HasColumnName("Starting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartingTime)
                    .HasColumnName("Starting Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasColumnName("Transaction Specification")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasColumnName("Transport Method")
                    .HasMaxLength(10);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User ID")
                    .HasMaxLength(50);

                entity.Property(e => e.VatBaseDiscount)
                    .HasColumnName("VAT Base Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatCountryRegionCode)
                    .IsRequired()
                    .HasColumnName("VAT Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VatRegistrationNo)
                    .IsRequired()
                    .HasColumnName("VAT Registration No_")
                    .HasMaxLength(20);

                entity.Property(e => e.WarningStatus).HasColumnName("Warning Status");

                entity.Property(e => e.YourReference)
                    .IsRequired()
                    .HasColumnName("Your Reference")
                    .HasMaxLength(35);
            });

            modelBuilder.Entity<ServiceInvoiceLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentNo, e.LineNo });

                entity.ToTable("Service Invoice Line");

                entity.HasIndex(e => new { e.ApplToServiceEntry, e.DocumentNo, e.LineNo })
                    .HasName("$7")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerNo, e.DocumentNo, e.LineNo })
                    .HasName("$10")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentNo, e.ServiceItemNo, e.LineNo })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.FaultReasonCode, e.DocumentNo, e.LineNo })
                    .HasName("$9")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentNo, e.ServiceItemLineNo, e.ComponentLineNo, e.LineNo })
                    .HasName("$8")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentNo, e.ServiceItemLineNo, e.ServPriceAdjmtGrCode, e.LineNo })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.Type, e.No, e.DocumentNo, e.LineNo })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentNo, e.ServiceItemLineNo, e.Type, e.No, e.LineNo })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.ServiceItemNo, e.Type, e.PostingDate, e.DocumentNo, e.LineNo })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.Type, e.No, e.VariantCode, e.LocationCode, e.PostingDate, e.ShortcutDimension1Code, e.ShortcutDimension2Code, e.DocumentNo, e.LineNo })
                    .HasName("$6")
                    .IsUnique();

                entity.Property(e => e.DocumentNo)
                    .HasColumnName("Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.AllowInvoiceDisc).HasColumnName("Allow Invoice Disc_");

                entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnName("Amount Including VAT")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ApplToItemEntry).HasColumnName("Appl_-to Item Entry");

                entity.Property(e => e.ApplToServiceEntry).HasColumnName("Appl_-to Service Entry");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.AttachedToLineNo).HasColumnName("Attached to Line No_");

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BinCode)
                    .IsRequired()
                    .HasColumnName("Bin Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ComponentLineNo).HasColumnName("Component Line No_");

                entity.Property(e => e.ContractDisc)
                    .HasColumnName("Contract Disc_ _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ContractNo)
                    .IsRequired()
                    .HasColumnName("Contract No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CopyComponentsFrom).HasColumnName("Copy Components From");

                entity.Property(e => e.CustomerDiscGroup)
                    .IsRequired()
                    .HasColumnName("Customer Disc_ Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerNo)
                    .IsRequired()
                    .HasColumnName("Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPriceGroup)
                    .IsRequired()
                    .HasColumnName("Customer Price Group")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("Description 2")
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.ExcludeContractDiscount).HasColumnName("Exclude Contract Discount");

                entity.Property(e => e.ExcludeWarranty).HasColumnName("Exclude Warranty");

                entity.Property(e => e.ExitPoint)
                    .IsRequired()
                    .HasColumnName("Exit Point")
                    .HasMaxLength(10);

                entity.Property(e => e.FaultAreaCode)
                    .IsRequired()
                    .HasColumnName("Fault Area Code")
                    .HasMaxLength(10);

                entity.Property(e => e.FaultCode)
                    .IsRequired()
                    .HasColumnName("Fault Code")
                    .HasMaxLength(10);

                entity.Property(e => e.FaultReasonCode)
                    .IsRequired()
                    .HasColumnName("Fault Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GenProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GrossWeight)
                    .HasColumnName("Gross Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.InvDiscountAmount)
                    .HasColumnName("Inv_ Discount Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ItemCategoryCode)
                    .IsRequired()
                    .HasColumnName("Item Category Code")
                    .HasMaxLength(20);

                entity.Property(e => e.LineAmount)
                    .HasColumnName("Line Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineDiscount)
                    .HasColumnName("Line Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineDiscountAmount)
                    .HasColumnName("Line Discount Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineDiscountType).HasColumnName("Line Discount Type");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NeededByDate)
                    .HasColumnName("Needed by Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NetWeight)
                    .HasColumnName("Net Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasColumnName("No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .IsRequired()
                    .HasColumnName("Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.PriceAdjmtStatus).HasColumnName("Price Adjmt_ Status");

                entity.Property(e => e.ProductGroupCode)
                    .IsRequired()
                    .HasColumnName("Product Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.QtyConsumedBase)
                    .HasColumnName("Qty_ Consumed (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPerUnitOfMeasure)
                    .HasColumnName("Qty_ per Unit of Measure")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityBase)
                    .HasColumnName("Quantity (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityConsumed)
                    .HasColumnName("Quantity Consumed")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReplacedItemNo)
                    .IsRequired()
                    .HasColumnName("Replaced Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ReplacedItemType).HasColumnName("Replaced Item Type");

                entity.Property(e => e.ResolutionCode)
                    .IsRequired()
                    .HasColumnName("Resolution Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.ReturnReasonCode)
                    .IsRequired()
                    .HasColumnName("Return Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ServPriceAdjmtGrCode)
                    .IsRequired()
                    .HasColumnName("Serv_ Price Adjmt_ Gr_ Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ServiceItemLineDescription)
                    .IsRequired()
                    .HasColumnName("Service Item Line Description")
                    .HasMaxLength(50);

                entity.Property(e => e.ServiceItemLineNo).HasColumnName("Service Item Line No_");

                entity.Property(e => e.ServiceItemNo)
                    .IsRequired()
                    .HasColumnName("Service Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceItemSerialNo)
                    .IsRequired()
                    .HasColumnName("Service Item Serial No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServicePriceGroupCode)
                    .IsRequired()
                    .HasColumnName("Service Price Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipmentLineNo).HasColumnName("Shipment Line No_");

                entity.Property(e => e.ShipmentNo)
                    .IsRequired()
                    .HasColumnName("Shipment No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SparePartAction).HasColumnName("Spare Part Action");

                entity.Property(e => e.SubstitutionAvailable).HasColumnName("Substitution Available");

                entity.Property(e => e.SymptomCode)
                    .IsRequired()
                    .HasColumnName("Symptom Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SystemCreatedEntry).HasColumnName("System-Created Entry");

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxGroupCode)
                    .IsRequired()
                    .HasColumnName("Tax Group Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasColumnName("Transaction Specification")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasColumnName("Transport Method")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("Unit Cost (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitOfMeasure)
                    .IsRequired()
                    .HasColumnName("Unit of Measure")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasColumnName("Unit of Measure Code")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("Unit Price")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitVolume)
                    .HasColumnName("Unit Volume")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitsPerParcel)
                    .HasColumnName("Units per Parcel")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBaseAmount)
                    .HasColumnName("VAT Base Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatCalculationType).HasColumnName("VAT Calculation Type");

                entity.Property(e => e.VatClauseCode)
                    .IsRequired()
                    .HasColumnName("VAT Clause Code")
                    .HasMaxLength(20);

                entity.Property(e => e.VatDifference)
                    .HasColumnName("VAT Difference")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatIdentifier)
                    .IsRequired()
                    .HasColumnName("VAT Identifier")
                    .HasMaxLength(20);

                entity.Property(e => e.VatProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.WarrantyDisc)
                    .HasColumnName("Warranty Disc_ _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.WorkTypeCode)
                    .IsRequired()
                    .HasColumnName("Work Type Code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ServiceItem>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Service Item");

                entity.HasIndex(e => new { e.ServiceItemGroupCode, e.No })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemNo, e.SerialNo, e.No })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.SalesServShptDocumentNo, e.SalesServShptLineNo, e.No })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.WarrantyEndingDateParts, e.CustomerNo, e.ShipToCode, e.No })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.CustomerNo, e.ShipToCode, e.ItemNo, e.SerialNo, e.No })
                    .HasName("$2")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.CustomerNo)
                    .IsRequired()
                    .HasColumnName("Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.DefaultContractCost)
                    .HasColumnName("Default Contract Cost")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DefaultContractDiscount)
                    .HasColumnName("Default Contract Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DefaultContractValue)
                    .HasColumnName("Default Contract Value")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("Description 2")
                    .HasMaxLength(50);

                entity.Property(e => e.InstallationDate)
                    .HasColumnName("Installation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItemNo)
                    .IsRequired()
                    .HasColumnName("Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LastServiceDate)
                    .HasColumnName("Last Service Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocationOfServiceItem)
                    .IsRequired()
                    .HasColumnName("Location of Service Item")
                    .HasMaxLength(30);

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.PreferredResource)
                    .IsRequired()
                    .HasColumnName("Preferred Resource")
                    .HasMaxLength(20);

                entity.Property(e => e.ResponseTimeHours)
                    .HasColumnName("Response Time (Hours)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.SalesDate)
                    .HasColumnName("Sales Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SalesServShptDocumentNo)
                    .IsRequired()
                    .HasColumnName("Sales_Serv_ Shpt_ Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SalesServShptLineNo).HasColumnName("Sales_Serv_ Shpt_ Line No_");

                entity.Property(e => e.SalesUnitCost)
                    .HasColumnName("Sales Unit Cost")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.SalesUnitPrice)
                    .HasColumnName("Sales Unit Price")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.SearchDescription)
                    .IsRequired()
                    .HasColumnName("Search Description")
                    .HasMaxLength(50);

                entity.Property(e => e.SerialNo)
                    .IsRequired()
                    .HasColumnName("Serial No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceItemGroupCode)
                    .IsRequired()
                    .HasColumnName("Service Item Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ServicePriceGroupCode)
                    .IsRequired()
                    .HasColumnName("Service Price Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipmentType).HasColumnName("Shipment Type");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasColumnName("Unit of Measure Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VendorItemName)
                    .IsRequired()
                    .HasColumnName("Vendor Item Name")
                    .HasMaxLength(50);

                entity.Property(e => e.VendorItemNo)
                    .IsRequired()
                    .HasColumnName("Vendor Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.VendorNo)
                    .IsRequired()
                    .HasColumnName("Vendor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.WarrantyEndingDateLabor)
                    .HasColumnName("Warranty Ending Date (Labor)")
                    .HasColumnType("datetime");

                entity.Property(e => e.WarrantyEndingDateParts)
                    .HasColumnName("Warranty Ending Date (Parts)")
                    .HasColumnType("datetime");

                entity.Property(e => e.WarrantyLabor)
                    .HasColumnName("Warranty _ (Labor)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.WarrantyParts)
                    .HasColumnName("Warranty _ (Parts)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.WarrantyStartingDateLabor)
                    .HasColumnName("Warranty Starting Date (Labor)")
                    .HasColumnType("datetime");

                entity.Property(e => e.WarrantyStartingDateParts)
                    .HasColumnName("Warranty Starting Date (Parts)")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ServiceItemLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentType, e.DocumentNo, e.LineNo });

                entity.ToTable("Service Item Line");

                entity.HasIndex(e => new { e.DocumentNo, e.LineNo, e.DocumentType })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ContractNo, e.DocumentType, e.DocumentNo, e.LineNo })
                    .HasName("$10")
                    .IsUnique();

                entity.HasIndex(e => new { e.FaultReasonCode, e.DocumentType, e.DocumentNo, e.LineNo })
                    .HasName("$9")
                    .IsUnique();

                entity.HasIndex(e => new { e.LoanerNo, e.DocumentType, e.DocumentNo, e.LineNo })
                    .HasName("$6")
                    .IsUnique();

                entity.HasIndex(e => new { e.ServiceItemNo, e.DocumentType, e.DocumentNo, e.LineNo })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.DocumentNo, e.ResponseDate, e.ResponseTime, e.LineNo })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.ResponseDate, e.ResponseTime, e.Priority, e.DocumentType, e.DocumentNo, e.LineNo })
                    .HasName("$5")
                    .IsUnique();

                entity.Property(e => e.DocumentType).HasColumnName("Document Type");

                entity.Property(e => e.DocumentNo)
                    .HasColumnName("Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.ActualResponseTimeHours)
                    .HasColumnName("Actual Response Time (Hours)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AdjustmentType).HasColumnName("Adjustment Type");

                entity.Property(e => e.BaseAmountToAdjust)
                    .HasColumnName("Base Amount to Adjust")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ContractLineNo).HasColumnName("Contract Line No_");

                entity.Property(e => e.ContractNo)
                    .IsRequired()
                    .HasColumnName("Contract No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerNo)
                    .IsRequired()
                    .HasColumnName("Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("Description 2")
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.FaultAreaCode)
                    .IsRequired()
                    .HasColumnName("Fault Area Code")
                    .HasMaxLength(10);

                entity.Property(e => e.FaultCode)
                    .IsRequired()
                    .HasColumnName("Fault Code")
                    .HasMaxLength(10);

                entity.Property(e => e.FaultReasonCode)
                    .IsRequired()
                    .HasColumnName("Fault Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.FinishingDate)
                    .HasColumnName("Finishing Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FinishingTime)
                    .HasColumnName("Finishing Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItemNo)
                    .IsRequired()
                    .HasColumnName("Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LoanerNo)
                    .IsRequired()
                    .HasColumnName("Loaner No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ReleaseStatus).HasColumnName("Release Status");

                entity.Property(e => e.RepairStatusCode)
                    .IsRequired()
                    .HasColumnName("Repair Status Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ResolutionCode)
                    .IsRequired()
                    .HasColumnName("Resolution Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ResponseDate)
                    .HasColumnName("Response Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponseTime)
                    .HasColumnName("Response Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResponseTimeHours)
                    .HasColumnName("Response Time (Hours)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.SerialNo)
                    .IsRequired()
                    .HasColumnName("Serial No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServPriceAdjmtGrCode)
                    .IsRequired()
                    .HasColumnName("Serv_ Price Adjmt_ Gr_ Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ServiceItemGroupCode)
                    .IsRequired()
                    .HasColumnName("Service Item Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ServiceItemNo)
                    .IsRequired()
                    .HasColumnName("Service Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServicePriceGroupCode)
                    .IsRequired()
                    .HasColumnName("Service Price Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ServiceShelfNo)
                    .IsRequired()
                    .HasColumnName("Service Shelf No_")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.StartingDate)
                    .HasColumnName("Starting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.StartingTime)
                    .HasColumnName("Starting Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.SymptomCode)
                    .IsRequired()
                    .HasColumnName("Symptom Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VendorItemNo)
                    .IsRequired()
                    .HasColumnName("Vendor Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.VendorNo)
                    .IsRequired()
                    .HasColumnName("Vendor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.WarrantyEndingDateLabor)
                    .HasColumnName("Warranty Ending Date (Labor)")
                    .HasColumnType("datetime");

                entity.Property(e => e.WarrantyEndingDateParts)
                    .HasColumnName("Warranty Ending Date (Parts)")
                    .HasColumnType("datetime");

                entity.Property(e => e.WarrantyLabor)
                    .HasColumnName("Warranty _ (Labor)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.WarrantyParts)
                    .HasColumnName("Warranty _ (Parts)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.WarrantyStartingDateLabor)
                    .HasColumnName("Warranty Starting Date (Labor)")
                    .HasColumnType("datetime");

                entity.Property(e => e.WarrantyStartingDateParts)
                    .HasColumnName("Warranty Starting Date (Parts)")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ServiceLedgerEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo);

                entity.ToTable("Service Ledger Entry");

                entity.HasIndex(e => new { e.DocumentNo, e.PostingDate, e.EntryNo })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.EntryType, e.DocumentType, e.DocumentNo, e.DocumentLineNo, e.EntryNo })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.ServiceItemNoServiced, e.EntryType, e.Type, e.ServiceContractNo, e.PostingDate, e.ServiceOrderNo, e.EntryNo })
                    .HasName("$7")
                    .IsUnique();

                entity.HasIndex(e => new { e.Type, e.No, e.EntryType, e.MovedFromPrepaidAcc, e.PostingDate, e.Open, e.Prepaid, e.EntryNo })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.ServiceOrderNo, e.ServiceItemNoServiced, e.EntryType, e.MovedFromPrepaidAcc, e.PostingDate, e.Open, e.Type, e.ServiceContractNo, e.EntryNo })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.ServiceContractNo, e.EntryNo, e.EntryType, e.Type, e.MovedFromPrepaidAcc, e.PostingDate, e.Open, e.Prepaid, e.ServiceItemNoServiced, e.CustomerNo, e.ContractGroupCode, e.ResponsibilityCenter })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.ServiceItemNoServiced, e.EntryType, e.MovedFromPrepaidAcc, e.Type, e.PostingDate, e.Open, e.ServiceContractNo, e.Prepaid, e.CustomerNo, e.ContractGroupCode, e.ResponsibilityCenter, e.EntryNo })
                    .HasName("$6")
                    .IsUnique();

                entity.Property(e => e.EntryNo)
                    .HasColumnName("Entry No_")
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AmountLcy)
                    .HasColumnName("Amount (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AppliesToEntryNo).HasColumnName("Applies-to Entry No_");

                entity.Property(e => e.ApplyUntilEntryNo).HasColumnName("Apply Until Entry No_");

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BinCode)
                    .IsRequired()
                    .HasColumnName("Bin Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ChargedQty)
                    .HasColumnName("Charged Qty_")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ContractDiscAmount)
                    .HasColumnName("Contract Disc_ Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ContractGroupCode)
                    .IsRequired()
                    .HasColumnName("Contract Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ContractInvoicePeriod)
                    .IsRequired()
                    .HasColumnName("Contract Invoice Period")
                    .HasMaxLength(30);

                entity.Property(e => e.CostAmount)
                    .HasColumnName("Cost Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CustomerNo)
                    .IsRequired()
                    .HasColumnName("Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.Discount)
                    .HasColumnName("Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DiscountAmount)
                    .HasColumnName("Discount Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.DocumentLineNo).HasColumnName("Document Line No_");

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasColumnName("Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.DocumentType).HasColumnName("Document Type");

                entity.Property(e => e.EntryType).HasColumnName("Entry Type");

                entity.Property(e => e.FaultReasonCode)
                    .IsRequired()
                    .HasColumnName("Fault Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GenProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GlobalDimension1Code)
                    .IsRequired()
                    .HasColumnName("Global Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.GlobalDimension2Code)
                    .IsRequired()
                    .HasColumnName("Global Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ItemNoServiced)
                    .IsRequired()
                    .HasColumnName("Item No_ (Serviced)")
                    .HasMaxLength(20);

                entity.Property(e => e.JobLineType).HasColumnName("Job Line Type");

                entity.Property(e => e.JobNo)
                    .IsRequired()
                    .HasColumnName("Job No_")
                    .HasMaxLength(20);

                entity.Property(e => e.JobPosted).HasColumnName("Job Posted");

                entity.Property(e => e.JobTaskNo)
                    .IsRequired()
                    .HasColumnName("Job Task No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.MovedFromPrepaidAcc).HasColumnName("Moved from Prepaid Acc_");

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasColumnName("No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.SerialNoServiced)
                    .IsRequired()
                    .HasColumnName("Serial No_ (Serviced)")
                    .HasMaxLength(20);

                entity.Property(e => e.ServContractAccGrCode)
                    .IsRequired()
                    .HasColumnName("Serv_ Contract Acc_ Gr_ Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ServPriceAdjmtGrCode)
                    .IsRequired()
                    .HasColumnName("Serv_ Price Adjmt_ Gr_ Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ServiceContractNo)
                    .IsRequired()
                    .HasColumnName("Service Contract No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceItemNoServiced)
                    .IsRequired()
                    .HasColumnName("Service Item No_ (Serviced)")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceOrderNo)
                    .IsRequired()
                    .HasColumnName("Service Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceOrderType)
                    .IsRequired()
                    .HasColumnName("Service Order Type")
                    .HasMaxLength(10);

                entity.Property(e => e.ServicePriceGroupCode)
                    .IsRequired()
                    .HasColumnName("Service Price Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.UnitCost)
                    .HasColumnName("Unit Cost")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasColumnName("Unit of Measure Code")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("Unit Price")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User ID")
                    .HasMaxLength(50);

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VariantCodeServiced)
                    .IsRequired()
                    .HasColumnName("Variant Code (Serviced)")
                    .HasMaxLength(10);

                entity.Property(e => e.WorkTypeCode)
                    .IsRequired()
                    .HasColumnName("Work Type Code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ServiceLine>(entity =>
            {
                entity.HasKey(e => new { e.DocumentType, e.DocumentNo, e.LineNo });

                entity.ToTable("Service Line");

                entity.HasIndex(e => new { e.ApplToServiceEntry, e.DocumentType, e.DocumentNo, e.LineNo })
                    .HasName("$8")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.DocumentNo, e.LocationCode, e.LineNo })
                    .HasName("$12")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.DocumentNo, e.ServiceItemNo, e.LineNo })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.FaultReasonCode, e.DocumentType, e.DocumentNo, e.LineNo })
                    .HasName("$10")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.BillToCustomerNo, e.CurrencyCode, e.DocumentNo, e.LineNo })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.CustomerNo, e.ShipmentNo, e.DocumentNo, e.LineNo })
                    .HasName("$11")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.DocumentNo, e.ServiceItemLineNo, e.ComponentLineNo, e.LineNo })
                    .HasName("$9")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.DocumentNo, e.ServiceItemLineNo, e.ServPriceAdjmtGrCode, e.LineNo })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.DocumentNo, e.Type, e.No, e.LineNo })
                    .HasName("$13")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.DocumentNo, e.ServiceItemLineNo, e.Type, e.No, e.LineNo })
                    .HasName("$6")
                    .IsUnique();

                entity.HasIndex(e => new { e.ServiceItemNo, e.Type, e.PostingDate, e.DocumentType, e.DocumentNo, e.LineNo })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.Type, e.No, e.OrderDate, e.DocumentType, e.DocumentNo, e.LineNo })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.Type, e.No, e.VariantCode, e.LocationCode, e.NeededByDate, e.DocumentType, e.ShortcutDimension1Code, e.ShortcutDimension2Code, e.DocumentNo, e.LineNo })
                    .HasName("$7")
                    .IsUnique();

                entity.Property(e => e.DocumentType).HasColumnName("Document Type");

                entity.Property(e => e.DocumentNo)
                    .HasColumnName("Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.AllowInvoiceDisc).HasColumnName("Allow Invoice Disc_");

                entity.Property(e => e.AllowLineDisc).HasColumnName("Allow Line Disc_");

                entity.Property(e => e.Amount).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AmountIncludingVat)
                    .HasColumnName("Amount Including VAT")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ApplFromItemEntry).HasColumnName("Appl_-from Item Entry");

                entity.Property(e => e.ApplToItemEntry).HasColumnName("Appl_-to Item Entry");

                entity.Property(e => e.ApplToServiceEntry).HasColumnName("Appl_-to Service Entry");

                entity.Property(e => e.Area)
                    .IsRequired()
                    .HasMaxLength(10);

                entity.Property(e => e.AttachedToLineNo).HasColumnName("Attached to Line No_");

                entity.Property(e => e.BillToCustomerNo)
                    .IsRequired()
                    .HasColumnName("Bill-to Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BinCode)
                    .IsRequired()
                    .HasColumnName("Bin Code")
                    .HasMaxLength(20);

                entity.Property(e => e.CompletelyPicked).HasColumnName("Completely Picked");

                entity.Property(e => e.CompletelyShipped).HasColumnName("Completely Shipped");

                entity.Property(e => e.ComponentLineNo).HasColumnName("Component Line No_");

                entity.Property(e => e.ContractDisc)
                    .HasColumnName("Contract Disc_ _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ContractNo)
                    .IsRequired()
                    .HasColumnName("Contract No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CopyComponentsFrom).HasColumnName("Copy Components From");

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CustomerDiscGroup)
                    .IsRequired()
                    .HasColumnName("Customer Disc_ Group")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerNo)
                    .IsRequired()
                    .HasColumnName("Customer No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CustomerPriceGroup)
                    .IsRequired()
                    .HasColumnName("Customer Price Group")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("Description 2")
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.ExcludeContractDiscount).HasColumnName("Exclude Contract Discount");

                entity.Property(e => e.ExcludeWarranty).HasColumnName("Exclude Warranty");

                entity.Property(e => e.ExitPoint)
                    .IsRequired()
                    .HasColumnName("Exit Point")
                    .HasMaxLength(10);

                entity.Property(e => e.FaultAreaCode)
                    .IsRequired()
                    .HasColumnName("Fault Area Code")
                    .HasMaxLength(10);

                entity.Property(e => e.FaultCode)
                    .IsRequired()
                    .HasColumnName("Fault Code")
                    .HasMaxLength(10);

                entity.Property(e => e.FaultReasonCode)
                    .IsRequired()
                    .HasColumnName("Fault Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GenProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.GrossWeight)
                    .HasColumnName("Gross Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.InvDiscAmountToInvoice)
                    .HasColumnName("Inv_ Disc_ Amount to Invoice")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.InvDiscountAmount)
                    .HasColumnName("Inv_ Discount Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ItemCategoryCode)
                    .IsRequired()
                    .HasColumnName("Item Category Code")
                    .HasMaxLength(20);

                entity.Property(e => e.JobLineType).HasColumnName("Job Line Type");

                entity.Property(e => e.JobNo)
                    .IsRequired()
                    .HasColumnName("Job No_")
                    .HasMaxLength(20);

                entity.Property(e => e.JobPlanningLineNo).HasColumnName("Job Planning Line No_");

                entity.Property(e => e.JobRemainingLineAmount)
                    .HasColumnName("Job Remaining Line Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.JobRemainingQty)
                    .HasColumnName("Job Remaining Qty_")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.JobRemainingQtyBase)
                    .HasColumnName("Job Remaining Qty_ (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.JobRemainingTotalCost)
                    .HasColumnName("Job Remaining Total Cost")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.JobRemainingTotalCostLcy)
                    .HasColumnName("Job Remaining Total Cost (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.JobTaskNo)
                    .IsRequired()
                    .HasColumnName("Job Task No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineAmount)
                    .HasColumnName("Line Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineDiscount)
                    .HasColumnName("Line Discount _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineDiscountAmount)
                    .HasColumnName("Line Discount Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.LineDiscountType).HasColumnName("Line Discount Type");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NeededByDate)
                    .HasColumnName("Needed by Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NetWeight)
                    .HasColumnName("Net Weight")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.No)
                    .IsRequired()
                    .HasColumnName("No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OrderDate)
                    .HasColumnName("Order Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.OutstandingAmount)
                    .HasColumnName("Outstanding Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.OutstandingAmountLcy)
                    .HasColumnName("Outstanding Amount (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.OutstandingQtyBase)
                    .HasColumnName("Outstanding Qty_ (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.OutstandingQuantity)
                    .HasColumnName("Outstanding Quantity")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PickQtyBase)
                    .HasColumnName("Pick Qty_ (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PlannedDeliveryDate)
                    .HasColumnName("Planned Delivery Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PostingGroup)
                    .IsRequired()
                    .HasColumnName("Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.PriceAdjmtStatus).HasColumnName("Price Adjmt_ Status");

                entity.Property(e => e.ProductGroupCode)
                    .IsRequired()
                    .HasColumnName("Product Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PromisedDeliveryDate)
                    .HasColumnName("Promised Delivery Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.QtyConsumedBase)
                    .HasColumnName("Qty_ Consumed (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyInvoicedBase)
                    .HasColumnName("Qty_ Invoiced (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPerUnitOfMeasure)
                    .HasColumnName("Qty_ per Unit of Measure")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPicked)
                    .HasColumnName("Qty_ Picked")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPickedBase)
                    .HasColumnName("Qty_ Picked (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyShippedBase)
                    .HasColumnName("Qty_ Shipped (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyShippedNotInvdBase)
                    .HasColumnName("Qty_ Shipped Not Invd_ (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyShippedNotInvoiced)
                    .HasColumnName("Qty_ Shipped Not Invoiced")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToConsume)
                    .HasColumnName("Qty_ to Consume")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToConsumeBase)
                    .HasColumnName("Qty_ to Consume (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToInvoice)
                    .HasColumnName("Qty_ to Invoice")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToInvoiceBase)
                    .HasColumnName("Qty_ to Invoice (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToShip)
                    .HasColumnName("Qty_ to Ship")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToShipBase)
                    .HasColumnName("Qty_ to Ship (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityBase)
                    .HasColumnName("Quantity (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityConsumed)
                    .HasColumnName("Quantity Consumed")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityInvoiced)
                    .HasColumnName("Quantity Invoiced")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QuantityShipped)
                    .HasColumnName("Quantity Shipped")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReplacedItemNo)
                    .IsRequired()
                    .HasColumnName("Replaced Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ReplacedItemType).HasColumnName("Replaced Item Type");

                entity.Property(e => e.RequestedDeliveryDate)
                    .HasColumnName("Requested Delivery Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ResolutionCode)
                    .IsRequired()
                    .HasColumnName("Resolution Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.ReturnReasonCode)
                    .IsRequired()
                    .HasColumnName("Return Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ServPriceAdjmtGrCode)
                    .IsRequired()
                    .HasColumnName("Serv_ Price Adjmt_ Gr_ Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ServiceItemLineNo).HasColumnName("Service Item Line No_");

                entity.Property(e => e.ServiceItemNo)
                    .IsRequired()
                    .HasColumnName("Service Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceItemSerialNo)
                    .IsRequired()
                    .HasColumnName("Service Item Serial No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServicePriceGroupCode)
                    .IsRequired()
                    .HasColumnName("Service Price Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipToCode)
                    .IsRequired()
                    .HasColumnName("Ship-to Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipmentLineNo).HasColumnName("Shipment Line No_");

                entity.Property(e => e.ShipmentNo)
                    .IsRequired()
                    .HasColumnName("Shipment No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippedNotInvoiced)
                    .HasColumnName("Shipped Not Invoiced")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ShippedNotInvoicedLcy)
                    .HasColumnName("Shipped Not Invoiced (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ShippingAgentCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Service Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingTime)
                    .IsRequired()
                    .HasColumnName("Shipping Time")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.ShortcutDimension1Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ShortcutDimension2Code)
                    .IsRequired()
                    .HasColumnName("Shortcut Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.SparePartAction).HasColumnName("Spare Part Action");

                entity.Property(e => e.SymptomCode)
                    .IsRequired()
                    .HasColumnName("Symptom Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SystemCreatedEntry).HasColumnName("System-Created Entry");

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxGroupCode)
                    .IsRequired()
                    .HasColumnName("Tax Group Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.TimeSheetDate)
                    .HasColumnName("Time Sheet Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TimeSheetLineNo).HasColumnName("Time Sheet Line No_");

                entity.Property(e => e.TimeSheetNo)
                    .IsRequired()
                    .HasColumnName("Time Sheet No_")
                    .HasMaxLength(20);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionSpecification)
                    .IsRequired()
                    .HasColumnName("Transaction Specification")
                    .HasMaxLength(10);

                entity.Property(e => e.TransactionType)
                    .IsRequired()
                    .HasColumnName("Transaction Type")
                    .HasMaxLength(10);

                entity.Property(e => e.TransportMethod)
                    .IsRequired()
                    .HasColumnName("Transport Method")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitCost)
                    .HasColumnName("Unit Cost")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitCostLcy)
                    .HasColumnName("Unit Cost (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitOfMeasure)
                    .IsRequired()
                    .HasColumnName("Unit of Measure")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasColumnName("Unit of Measure Code")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitPrice)
                    .HasColumnName("Unit Price")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitVolume)
                    .HasColumnName("Unit Volume")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.UnitsPerParcel)
                    .HasColumnName("Units per Parcel")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Vat)
                    .HasColumnName("VAT _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBaseAmount)
                    .HasColumnName("VAT Base Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatCalculationType).HasColumnName("VAT Calculation Type");

                entity.Property(e => e.VatClauseCode)
                    .IsRequired()
                    .HasColumnName("VAT Clause Code")
                    .HasMaxLength(20);

                entity.Property(e => e.VatDifference)
                    .HasColumnName("VAT Difference")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.VatIdentifier)
                    .IsRequired()
                    .HasColumnName("VAT Identifier")
                    .HasMaxLength(20);

                entity.Property(e => e.VatProdPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Prod_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.WarrantyDisc)
                    .HasColumnName("Warranty Disc_ _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.WorkTypeCode)
                    .IsRequired()
                    .HasColumnName("Work Type Code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ServiceOrder>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Service Order");

                entity.HasIndex(e => new { e.Date, e.No })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.RelatedDocumentType, e.RelatedDocumentNo, e.No })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.RelatedDocumentType, e.RelatedPostedDocumentNo, e.No })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.ServiceProviderNo, e.Date, e.No })
                    .HasName("$4")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.BookedDays).HasColumnName("Booked Days");

                entity.Property(e => e.Capacity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.CapacityUnit)
                    .IsRequired()
                    .HasColumnName("Capacity Unit")
                    .HasMaxLength(10);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.DeletedField50)
                    .IsRequired()
                    .HasColumnName("Deleted Field 50")
                    .HasMaxLength(20);

                entity.Property(e => e.DeletedField51).HasColumnName("Deleted Field 51");

                entity.Property(e => e.DeletedField52)
                    .IsRequired()
                    .HasColumnName("Deleted Field 52")
                    .HasMaxLength(20);

                entity.Property(e => e.DeletedField53).HasColumnName("Deleted Field 53");

                entity.Property(e => e.EndingTime)
                    .HasColumnName("Ending Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ManualInputForPricing)
                    .HasColumnName("Manual Input for Pricing")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.MultipleTimeSlots).HasColumnName("Multiple Time Slots");

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(10);

                entity.Property(e => e.NumberOfAdjPackages)
                    .HasColumnName("Number of Adj_ Packages")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.OriginalSalesChannel)
                    .IsRequired()
                    .HasColumnName("Original Sales Channel")
                    .HasMaxLength(10);

                entity.Property(e => e.OriginalSalesChannelType).HasColumnName("Original Sales Channel Type");

                entity.Property(e => e.Price).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PriceCalcMethod)
                    .IsRequired()
                    .HasColumnName("Price Calc_ Method")
                    .HasMaxLength(10);

                entity.Property(e => e.PricePeriodNo).HasColumnName("Price Period No_");

                entity.Property(e => e.PricingUnit)
                    .IsRequired()
                    .HasColumnName("Pricing Unit")
                    .HasMaxLength(10);

                entity.Property(e => e.ProcessInStoreNo)
                    .IsRequired()
                    .HasColumnName("Process in Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.ReasonCodeForFailing)
                    .IsRequired()
                    .HasColumnName("Reason Code for Failing")
                    .HasMaxLength(10);

                entity.Property(e => e.RelatedDocumentLineNo).HasColumnName("Related Document Line No_");

                entity.Property(e => e.RelatedDocumentNo)
                    .IsRequired()
                    .HasColumnName("Related Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.RelatedDocumentType).HasColumnName("Related Document Type");

                entity.Property(e => e.RelatedPostedDocLineNo).HasColumnName("Related Posted Doc_ Line No_");

                entity.Property(e => e.RelatedPostedDocumentNo)
                    .IsRequired()
                    .HasColumnName("Related Posted Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ReservationId).HasColumnName("Reservation ID");

                entity.Property(e => e.SalesChannel)
                    .IsRequired()
                    .HasColumnName("Sales Channel")
                    .HasMaxLength(10);

                entity.Property(e => e.SalesChannelType).HasColumnName("Sales Channel Type");

                entity.Property(e => e.SalespersonCode)
                    .IsRequired()
                    .HasColumnName("Salesperson Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ServiceItemNo)
                    .IsRequired()
                    .HasColumnName("Service Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceProductNo)
                    .IsRequired()
                    .HasColumnName("Service Product No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceProviderNo)
                    .IsRequired()
                    .HasColumnName("Service Provider No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SourceDocumentIsPosted).HasColumnName("Source Document is Posted");

                entity.Property(e => e.StartingTime)
                    .HasColumnName("Starting Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.StoreNo)
                    .IsRequired()
                    .HasColumnName("Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.TimeSlotNo).HasColumnName("Time Slot No_");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TriggeringFactorForFailing).HasColumnName("Triggering Factor for Failing");
            });

            modelBuilder.Entity<ServiceOrderAllocation>(entity =>
            {
                entity.HasKey(e => e.EntryNo);

                entity.ToTable("Service Order Allocation");

                entity.HasIndex(e => new { e.ResourceNo, e.DocumentType, e.AllocationDate, e.Status, e.Posted, e.EntryNo })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.DocumentNo, e.ServiceItemLineNo, e.AllocationDate, e.StartingTime, e.Posted, e.EntryNo })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentType, e.DocumentNo, e.Status, e.ResourceGroupNo, e.AllocationDate, e.StartingTime, e.Posted, e.EntryNo })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.Status, e.DocumentType, e.DocumentNo, e.ServiceItemLineNo, e.AllocationDate, e.StartingTime, e.Posted, e.EntryNo })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.Status, e.DocumentType, e.DocumentNo, e.ServiceItemLineNo, e.ResourceNo, e.AllocationDate, e.StartingTime, e.Posted, e.EntryNo })
                    .HasName("$3")
                    .IsUnique();

                entity.Property(e => e.EntryNo)
                    .HasColumnName("Entry No_")
                    .ValueGeneratedNever();

                entity.Property(e => e.AllocatedHours)
                    .HasColumnName("Allocated Hours")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AllocationDate)
                    .HasColumnName("Allocation Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasColumnName("Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.DocumentType).HasColumnName("Document Type");

                entity.Property(e => e.FinishingTime)
                    .HasColumnName("Finishing Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasColumnName("Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ResourceGroupNo)
                    .IsRequired()
                    .HasColumnName("Resource Group No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ResourceNo)
                    .IsRequired()
                    .HasColumnName("Resource No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceItemLineNo).HasColumnName("Service Item Line No_");

                entity.Property(e => e.ServiceItemNo)
                    .IsRequired()
                    .HasColumnName("Service Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceItemSerialNo)
                    .IsRequired()
                    .HasColumnName("Service Item Serial No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ServiceStarted).HasColumnName("Service Started");

                entity.Property(e => e.StartingTime)
                    .HasColumnName("Starting Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ServiceOrderItems>(entity =>
            {
                entity.HasKey(e => new { e.ServiceOrderNo, e.LineNo });

                entity.ToTable("Service Order Items");

                entity.HasIndex(e => new { e.RelatedDocumentNo, e.ItemNo, e.ServiceItemNo, e.ServiceOrderNo, e.LineNo })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.ServiceOrderNo)
                    .HasColumnName("Service Order No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.DeletedField25)
                    .IsRequired()
                    .HasColumnName("Deleted field 25")
                    .HasMaxLength(20);

                entity.Property(e => e.DeletedField26).HasColumnName("Deleted field 26");

                entity.Property(e => e.ItemNo)
                    .IsRequired()
                    .HasColumnName("Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ItemPosTerminalNo)
                    .IsRequired()
                    .HasColumnName("Item POS Terminal No_")
                    .HasMaxLength(10);

                entity.Property(e => e.ItemStoreNo)
                    .IsRequired()
                    .HasColumnName("Item Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.ItemTransLineNo).HasColumnName("Item Trans_ Line No_");

                entity.Property(e => e.ItemTransactionNo).HasColumnName("Item Transaction No_");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.RelatedDocumentLineNo).HasColumnName("Related Document Line No_");

                entity.Property(e => e.RelatedDocumentNo)
                    .IsRequired()
                    .HasColumnName("Related Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.RelatedDocumentType).HasColumnName("Related Document Type");

                entity.Property(e => e.SalesOrderLineNo).HasColumnName("Sales Order Line No_");

                entity.Property(e => e.ServiceItemNo)
                    .IsRequired()
                    .HasColumnName("Service Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TotalNumberOfPackages)
                    .HasColumnName("Total Number of Packages")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.TotalVolume)
                    .HasColumnName("Total Volume")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.TotalWeight)
                    .HasColumnName("Total Weight")
                    .HasColumnType("decimal(38, 20)");
            });

            modelBuilder.Entity<ServiceOrderStatus>(entity =>
            {
                entity.HasKey(e => e.ServiceOrderNo);

                entity.ToTable("Service Order Status");

                entity.HasIndex(e => new { e.Status, e.Exported, e.ServiceOrderNo })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.ServiceOrderNo)
                    .HasColumnName("Service Order No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.PreviousStatus).HasColumnName("Previous Status");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ServiceOrderType>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Service Order Type");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ServicePriceGroup>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Service Price Group");

                entity.HasIndex(e => new { e.Description, e.Code })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ServiceProduct>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Service Product");

                entity.HasIndex(e => new { e.LinkedItemNo, e.No })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.ServiceProductId, e.No })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.BaseCapacityUnitOfMeasure)
                    .IsRequired()
                    .HasColumnName("Base Capacity Unit of Measure")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.EndDateSales)
                    .HasColumnName("End Date Sales")
                    .HasColumnType("datetime");

                entity.Property(e => e.LinkedItemNo)
                    .IsRequired()
                    .HasColumnName("Linked Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.NoItemLink).HasColumnName("No Item Link");

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(10);

                entity.Property(e => e.SalesStartDate)
                    .HasColumnName("Sales Start Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ServiceProductId).HasColumnName("Service Product ID");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TypeCode)
                    .IsRequired()
                    .HasColumnName("Type Code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<ServiceProductType>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Service Product Type");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransportDependent).HasColumnName("Transport Dependent");
            });

            modelBuilder.Entity<ServiceProvider>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Service Provider");

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.AliasServiceProvider)
                    .IsRequired()
                    .HasColumnName("Alias Service Provider")
                    .HasMaxLength(3);

                entity.Property(e => e.CodeunitCreateExportFile).HasColumnName("Codeunit create export file");

                entity.Property(e => e.ExportPath)
                    .IsRequired()
                    .HasColumnName("Export path")
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(10);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.VendorNo)
                    .IsRequired()
                    .HasColumnName("Vendor No_")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<ShippingAgent>(entity =>
            {
                entity.HasKey(e => e.Code);

                entity.ToTable("Shipping Agent");

                entity.Property(e => e.Code)
                    .HasMaxLength(10)
                    .ValueGeneratedNever();

                entity.Property(e => e.AccountNo)
                    .IsRequired()
                    .HasColumnName("Account No_")
                    .HasMaxLength(30);

                entity.Property(e => e.InternetAddress)
                    .IsRequired()
                    .HasColumnName("Internet Address")
                    .HasMaxLength(250);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<ShippingAgentServices>(entity =>
            {
                entity.HasKey(e => new { e.ShippingAgentCode, e.Code });

                entity.ToTable("Shipping Agent Services");

                entity.Property(e => e.ShippingAgentCode)
                    .HasColumnName("Shipping Agent Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Code).HasMaxLength(10);

                entity.Property(e => e.BaseCalendarCode)
                    .IsRequired()
                    .HasColumnName("Base Calendar Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.ShippingTime)
                    .IsRequired()
                    .HasColumnName("Shipping Time")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<Vendor>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.HasIndex(e => new { e.BuyerId, e.No })
                    .HasName("$13")
                    .IsUnique();

                entity.HasIndex(e => new { e.City, e.No })
                    .HasName("$9")
                    .IsUnique();

                entity.HasIndex(e => new { e.Contact, e.No })
                    .HasName("$12")
                    .IsUnique();

                entity.HasIndex(e => new { e.CountryRegionCode, e.No })
                    .HasName("$5")
                    .IsUnique();

                entity.HasIndex(e => new { e.CurrencyCode, e.No })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.GenBusPostingGroup, e.No })
                    .HasName("$6")
                    .IsUnique();

                entity.HasIndex(e => new { e.Name, e.No })
                    .HasName("$8")
                    .IsUnique();

                entity.HasIndex(e => new { e.PhoneNo, e.No })
                    .HasName("$11")
                    .IsUnique();

                entity.HasIndex(e => new { e.PostCode, e.No })
                    .HasName("$10")
                    .IsUnique();

                entity.HasIndex(e => new { e.Priority, e.No })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.SearchName, e.No })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.VatRegistrationNo, e.No })
                    .HasName("$7")
                    .IsUnique();

                entity.HasIndex(e => new { e.VendorPostingGroup, e.No })
                    .HasName("$2")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Address2)
                    .IsRequired()
                    .HasColumnName("Address 2")
                    .HasMaxLength(50);

                entity.Property(e => e.ApplicationMethod).HasColumnName("Application Method");

                entity.Property(e => e.BaseCalendarCode)
                    .IsRequired()
                    .HasColumnName("Base Calendar Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BlockPaymentTolerance).HasColumnName("Block Payment Tolerance");

                entity.Property(e => e.BudgetedAmount)
                    .HasColumnName("Budgeted Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.BuyerGroupCode)
                    .IsRequired()
                    .HasColumnName("Buyer Group Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BuyerId)
                    .IsRequired()
                    .HasColumnName("Buyer ID")
                    .HasMaxLength(50);

                entity.Property(e => e.CashFlowPaymentTermsCode)
                    .IsRequired()
                    .HasColumnName("Cash Flow Payment Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.Contact)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.CountryRegionCode)
                    .IsRequired()
                    .HasColumnName("Country_Region Code")
                    .HasMaxLength(10);

                entity.Property(e => e.County)
                    .IsRequired()
                    .HasMaxLength(30);

                entity.Property(e => e.CreditorNo)
                    .IsRequired()
                    .HasColumnName("Creditor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.CurrencyId).HasColumnName("Currency Id");

                entity.Property(e => e.DocumentApprovalMandatory).HasColumnName("Document Approval Mandatory");

                entity.Property(e => e.DocumentSendingProfile)
                    .IsRequired()
                    .HasColumnName("Document Sending Profile")
                    .HasMaxLength(20);

                entity.Property(e => e.EMail)
                    .IsRequired()
                    .HasColumnName("E-Mail")
                    .HasMaxLength(80);

                entity.Property(e => e.FaxNo)
                    .IsRequired()
                    .HasColumnName("Fax No_")
                    .HasMaxLength(30);

                entity.Property(e => e.FinChargeTermsCode)
                    .IsRequired()
                    .HasColumnName("Fin_ Charge Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.GenBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("Gen_ Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.Gln)
                    .IsRequired()
                    .HasColumnName("GLN")
                    .HasMaxLength(13);

                entity.Property(e => e.GlobalDimension1Code)
                    .IsRequired()
                    .HasColumnName("Global Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.GlobalDimension2Code)
                    .IsRequired()
                    .HasColumnName("Global Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.HomePage)
                    .IsRequired()
                    .HasColumnName("Home Page")
                    .HasMaxLength(80);

                entity.Property(e => e.IcPartnerCode)
                    .IsRequired()
                    .HasColumnName("IC Partner Code")
                    .HasMaxLength(20);

                entity.Property(e => e.IfbVendor).HasColumnName("IFB Vendor");

                entity.Property(e => e.InvoiceDiscCode)
                    .IsRequired()
                    .HasColumnName("Invoice Disc_ Code")
                    .HasMaxLength(20);

                entity.Property(e => e.LanguageCode)
                    .IsRequired()
                    .HasColumnName("Language Code")
                    .HasMaxLength(10);

                entity.Property(e => e.LastDateModified)
                    .HasColumnName("Last Date Modified")
                    .HasColumnType("datetime");

                entity.Property(e => e.LastModifiedDateTime)
                    .HasColumnName("Last Modified Date Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.LeadTimeCalculation)
                    .IsRequired()
                    .HasColumnName("Lead Time Calculation")
                    .HasMaxLength(32)
                    .IsUnicode(false);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Name2)
                    .IsRequired()
                    .HasColumnName("Name 2")
                    .HasMaxLength(50);

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.OurAccountNo)
                    .IsRequired()
                    .HasColumnName("Our Account No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PartnerType).HasColumnName("Partner Type");

                entity.Property(e => e.PayToVendorNo)
                    .IsRequired()
                    .HasColumnName("Pay-to Vendor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PaymentMethodCode)
                    .IsRequired()
                    .HasColumnName("Payment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentMethodId).HasColumnName("Payment Method Id");

                entity.Property(e => e.PaymentTermsCode)
                    .IsRequired()
                    .HasColumnName("Payment Terms Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentTermsId).HasColumnName("Payment Terms Id");

                entity.Property(e => e.PhoneNo)
                    .IsRequired()
                    .HasColumnName("Phone No_")
                    .HasMaxLength(30);

                entity.Property(e => e.Picture).HasColumnType("image");

                entity.Property(e => e.PostCode)
                    .IsRequired()
                    .HasColumnName("Post Code")
                    .HasMaxLength(20);

                entity.Property(e => e.PreferredBankAccountCode)
                    .IsRequired()
                    .HasColumnName("Preferred Bank Account Code")
                    .HasMaxLength(20);

                entity.Property(e => e.Prepayment)
                    .HasColumnName("Prepayment _")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PricesIncludingVat).HasColumnName("Prices Including VAT");

                entity.Property(e => e.PrimaryContactNo)
                    .IsRequired()
                    .HasColumnName("Primary Contact No_")
                    .HasMaxLength(20);

                entity.Property(e => e.PrivacyBlocked).HasColumnName("Privacy Blocked");

                entity.Property(e => e.PurchaserCode)
                    .IsRequired()
                    .HasColumnName("Purchaser Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ResponsibilityCenter)
                    .IsRequired()
                    .HasColumnName("Responsibility Center")
                    .HasMaxLength(10);

                entity.Property(e => e.RtcFilterField).HasColumnName("RTC Filter Field");

                entity.Property(e => e.SearchName)
                    .IsRequired()
                    .HasColumnName("Search Name")
                    .HasMaxLength(50);

                entity.Property(e => e.ShipmentMethodCode)
                    .IsRequired()
                    .HasColumnName("Shipment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAgentCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Code")
                    .HasMaxLength(10);

                entity.Property(e => e.StatisticsGroup).HasColumnName("Statistics Group");

                entity.Property(e => e.TaxAreaCode)
                    .IsRequired()
                    .HasColumnName("Tax Area Code")
                    .HasMaxLength(20);

                entity.Property(e => e.TaxLiable).HasColumnName("Tax Liable");

                entity.Property(e => e.TelexAnswerBack)
                    .IsRequired()
                    .HasColumnName("Telex Answer Back")
                    .HasMaxLength(20);

                entity.Property(e => e.TelexNo)
                    .IsRequired()
                    .HasColumnName("Telex No_")
                    .HasMaxLength(20);

                entity.Property(e => e.TerritoryCode)
                    .IsRequired()
                    .HasColumnName("Territory Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.ValidateEuVatRegNo).HasColumnName("Validate EU Vat Reg_ No_");

                entity.Property(e => e.VatBusPostingGroup)
                    .IsRequired()
                    .HasColumnName("VAT Bus_ Posting Group")
                    .HasMaxLength(20);

                entity.Property(e => e.VatRegistrationNo)
                    .IsRequired()
                    .HasColumnName("VAT Registration No_")
                    .HasMaxLength(20);

                entity.Property(e => e.VendorPostingGroup)
                    .IsRequired()
                    .HasColumnName("Vendor Posting Group")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<VendorLedgerEntry>(entity =>
            {
                entity.HasKey(e => e.EntryNo);

                entity.ToTable("Vendor Ledger Entry");

                entity.HasIndex(e => new { e.ClosedByEntryNo, e.EntryNo })
                    .HasName("$8")
                    .IsUnique();

                entity.HasIndex(e => new { e.DocumentNo, e.EntryNo })
                    .HasName("$3")
                    .IsUnique();

                entity.HasIndex(e => new { e.ExternalDocumentNo, e.EntryNo })
                    .HasName("$4")
                    .IsUnique();

                entity.HasIndex(e => new { e.TransactionNo, e.EntryNo })
                    .HasName("$9")
                    .IsUnique();

                entity.HasIndex(e => new { e.VendorPostingGroup, e.EntryNo })
                    .HasName("$15")
                    .IsUnique();

                entity.HasIndex(e => new { e.Open, e.DueDate, e.EntryNo })
                    .HasName("$6")
                    .IsUnique();

                entity.HasIndex(e => new { e.VendorNo, e.PostingDate, e.CurrencyCode, e.EntryNo })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.VendorNo, e.AppliesToId, e.Open, e.Positive, e.DueDate, e.EntryNo })
                    .HasName("$14")
                    .IsUnique();

                entity.HasIndex(e => new { e.VendorNo, e.Open, e.Positive, e.DueDate, e.CurrencyCode, e.EntryNo })
                    .HasName("$5")
                    .IsUnique();

                entity.Property(e => e.EntryNo)
                    .HasColumnName("Entry No_")
                    .ValueGeneratedNever();

                entity.Property(e => e.AcceptedPaymentTolerance)
                    .HasColumnName("Accepted Payment Tolerance")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AcceptedPmtDiscTolerance).HasColumnName("Accepted Pmt_ Disc_ Tolerance");

                entity.Property(e => e.AdjustedCurrencyFactor)
                    .HasColumnName("Adjusted Currency Factor")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AmountToApply)
                    .HasColumnName("Amount to Apply")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.AppliesToDocNo)
                    .IsRequired()
                    .HasColumnName("Applies-to Doc_ No_")
                    .HasMaxLength(20);

                entity.Property(e => e.AppliesToDocType).HasColumnName("Applies-to Doc_ Type");

                entity.Property(e => e.AppliesToExtDocNo)
                    .IsRequired()
                    .HasColumnName("Applies-to Ext_ Doc_ No_")
                    .HasMaxLength(35);

                entity.Property(e => e.AppliesToId)
                    .IsRequired()
                    .HasColumnName("Applies-to ID")
                    .HasMaxLength(50);

                entity.Property(e => e.ApplyingEntry).HasColumnName("Applying Entry");

                entity.Property(e => e.BalAccountNo)
                    .IsRequired()
                    .HasColumnName("Bal_ Account No_")
                    .HasMaxLength(20);

                entity.Property(e => e.BalAccountType).HasColumnName("Bal_ Account Type");

                entity.Property(e => e.BuyFromVendorNo)
                    .IsRequired()
                    .HasColumnName("Buy-from Vendor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ClosedAtDate)
                    .HasColumnName("Closed at Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ClosedByAmount)
                    .HasColumnName("Closed by Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ClosedByAmountLcy)
                    .HasColumnName("Closed by Amount (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ClosedByCurrencyAmount)
                    .HasColumnName("Closed by Currency Amount")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ClosedByCurrencyCode)
                    .IsRequired()
                    .HasColumnName("Closed by Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ClosedByEntryNo).HasColumnName("Closed by Entry No_");

                entity.Property(e => e.CreditorNo)
                    .IsRequired()
                    .HasColumnName("Creditor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.CurrencyCode)
                    .IsRequired()
                    .HasColumnName("Currency Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.DimensionSetId).HasColumnName("Dimension Set ID");

                entity.Property(e => e.DocumentDate)
                    .HasColumnName("Document Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentNo)
                    .IsRequired()
                    .HasColumnName("Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.DocumentType).HasColumnName("Document Type");

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExportedToPaymentFile).HasColumnName("Exported to Payment File");

                entity.Property(e => e.ExternalDocumentNo)
                    .IsRequired()
                    .HasColumnName("External Document No_")
                    .HasMaxLength(35);

                entity.Property(e => e.GlobalDimension1Code)
                    .IsRequired()
                    .HasColumnName("Global Dimension 1 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.GlobalDimension2Code)
                    .IsRequired()
                    .HasColumnName("Global Dimension 2 Code")
                    .HasMaxLength(20);

                entity.Property(e => e.IcPartnerCode)
                    .IsRequired()
                    .HasColumnName("IC Partner Code")
                    .HasMaxLength(20);

                entity.Property(e => e.InvDiscountLcy)
                    .HasColumnName("Inv_ Discount (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.JournalBatchName)
                    .IsRequired()
                    .HasColumnName("Journal Batch Name")
                    .HasMaxLength(10);

                entity.Property(e => e.MaxPaymentTolerance)
                    .HasColumnName("Max_ Payment Tolerance")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.MessageToRecipient)
                    .IsRequired()
                    .HasColumnName("Message to Recipient")
                    .HasMaxLength(140);

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.OnHold)
                    .IsRequired()
                    .HasColumnName("On Hold")
                    .HasMaxLength(3);

                entity.Property(e => e.OriginalCurrencyFactor)
                    .HasColumnName("Original Currency Factor")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.OriginalPmtDiscPossible)
                    .HasColumnName("Original Pmt_ Disc_ Possible")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PaymentMethodCode)
                    .IsRequired()
                    .HasColumnName("Payment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.PaymentReference)
                    .IsRequired()
                    .HasColumnName("Payment Reference")
                    .HasMaxLength(50);

                entity.Property(e => e.PmtDiscRcdLcy)
                    .HasColumnName("Pmt_ Disc_ Rcd_(LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PmtDiscToleranceDate)
                    .HasColumnName("Pmt_ Disc_ Tolerance Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PmtDiscountDate)
                    .HasColumnName("Pmt_ Discount Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PmtToleranceLcy)
                    .HasColumnName("Pmt_ Tolerance (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PurchaseLcy)
                    .HasColumnName("Purchase (LCY)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.PurchaserCode)
                    .IsRequired()
                    .HasColumnName("Purchaser Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ReasonCode)
                    .IsRequired()
                    .HasColumnName("Reason Code")
                    .HasMaxLength(10);

                entity.Property(e => e.RecipientBankAccount)
                    .IsRequired()
                    .HasColumnName("Recipient Bank Account")
                    .HasMaxLength(20);

                entity.Property(e => e.RemainingPmtDiscPossible)
                    .HasColumnName("Remaining Pmt_ Disc_ Possible")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ReversedByEntryNo).HasColumnName("Reversed by Entry No_");

                entity.Property(e => e.ReversedEntryNo).HasColumnName("Reversed Entry No_");

                entity.Property(e => e.SourceCode)
                    .IsRequired()
                    .HasColumnName("Source Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.TransactionNo).HasColumnName("Transaction No_");

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasColumnName("User ID")
                    .HasMaxLength(50);

                entity.Property(e => e.VendorNo)
                    .IsRequired()
                    .HasColumnName("Vendor No_")
                    .HasMaxLength(20);

                entity.Property(e => e.VendorPostingGroup)
                    .IsRequired()
                    .HasColumnName("Vendor Posting Group")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Visitors>(entity =>
            {
                entity.HasKey(e => new { e.StoreNo, e.Date });

                entity.Property(e => e.StoreNo)
                    .HasColumnName("Store No_")
                    .HasMaxLength(10);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.ExitCafeSales)
                    .HasColumnName("Exit Cafe Sales")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.NumberOfVisitors).HasColumnName("Number of Visitors");

                entity.Property(e => e.RestaurantCustomers).HasColumnName("Restaurant Customers");

                entity.Property(e => e.RestaurantSales)
                    .HasColumnName("Restaurant Sales")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<WarehouseActivityHeader>(entity =>
            {
                entity.HasKey(e => new { e.Type, e.No });

                entity.ToTable("Warehouse Activity Header");

                entity.HasIndex(e => new { e.LocationCode, e.Type, e.No })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.SourceDocument, e.SourceNo, e.LocationCode, e.Type, e.No })
                    .HasName("$2")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20);

                entity.Property(e => e.AssignedUserId)
                    .IsRequired()
                    .HasColumnName("Assigned User ID")
                    .HasMaxLength(50);

                entity.Property(e => e.AssignmentDate)
                    .HasColumnName("Assignment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssignmentTime)
                    .HasColumnName("Assignment Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.BreakbulkFilter).HasColumnName("Breakbulk Filter");

                entity.Property(e => e.DateOfLastPrinting)
                    .HasColumnName("Date of Last Printing")
                    .HasColumnType("datetime");

                entity.Property(e => e.DestinationNo)
                    .IsRequired()
                    .HasColumnName("Destination No_")
                    .HasMaxLength(20);

                entity.Property(e => e.DestinationType).HasColumnName("Destination Type");

                entity.Property(e => e.ExpectedReceiptDate)
                    .HasColumnName("Expected Receipt Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExternalDocumentNo)
                    .IsRequired()
                    .HasColumnName("External Document No_")
                    .HasMaxLength(35);

                entity.Property(e => e.ExternalDocumentNo2)
                    .IsRequired()
                    .HasColumnName("External Document No_2")
                    .HasMaxLength(35);

                entity.Property(e => e.LastRegisteringNo)
                    .IsRequired()
                    .HasColumnName("Last Registering No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NoPrinted).HasColumnName("No_ Printed");

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RegisteringNo)
                    .IsRequired()
                    .HasColumnName("Registering No_")
                    .HasMaxLength(20);

                entity.Property(e => e.RegisteringNoSeries)
                    .IsRequired()
                    .HasColumnName("Registering No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.ShipmentDate)
                    .HasColumnName("Shipment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SortingMethod).HasColumnName("Sorting Method");

                entity.Property(e => e.SourceDocument).HasColumnName("Source Document");

                entity.Property(e => e.SourceNo)
                    .IsRequired()
                    .HasColumnName("Source No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SourceSubtype).HasColumnName("Source Subtype");

                entity.Property(e => e.SourceType).HasColumnName("Source Type");

                entity.Property(e => e.TimeOfLastPrinting)
                    .HasColumnName("Time of Last Printing")
                    .HasColumnType("datetime");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();
            });

            modelBuilder.Entity<WarehouseActivityLine>(entity =>
            {
                entity.HasKey(e => new { e.ActivityType, e.No, e.LineNo });

                entity.ToTable("Warehouse Activity Line");

                entity.HasIndex(e => new { e.No, e.LineNo, e.ActivityType })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.LocationCode, e.ActivityType, e.No, e.LineNo })
                    .HasName("$17")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemNo, e.LocationCode, e.ActivityType, e.BinTypeCode, e.UnitOfMeasureCode, e.VariantCode, e.BreakbulkNo, e.ActionType, e.LotNo, e.SerialNo, e.AssembleToOrder, e.No, e.LineNo })
                    .HasName("$15")
                    .IsUnique();

                entity.HasIndex(e => new { e.SourceType, e.SourceSubtype, e.SourceNo, e.SourceLineNo, e.SourceSublineNo, e.UnitOfMeasureCode, e.ActionType, e.BreakbulkNo, e.OriginalBreakbulk, e.ActivityType, e.AssembleToOrder, e.No, e.LineNo })
                    .HasName("$2")
                    .IsUnique();

                entity.HasIndex(e => new { e.WhseDocumentNo, e.WhseDocumentType, e.ActivityType, e.WhseDocumentLineNo, e.ActionType, e.UnitOfMeasureCode, e.OriginalBreakbulk, e.BreakbulkNo, e.LotNo, e.SerialNo, e.AssembleToOrder, e.No, e.LineNo })
                    .HasName("$13")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemNo, e.BinCode, e.LocationCode, e.ActionType, e.VariantCode, e.UnitOfMeasureCode, e.BreakbulkNo, e.ActivityType, e.LotNo, e.SerialNo, e.OriginalBreakbulk, e.AssembleToOrder, e.AtoComponent, e.No, e.LineNo })
                    .HasName("$14")
                    .IsUnique();

                entity.Property(e => e.ActivityType).HasColumnName("Activity Type");

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.ActionType).HasColumnName("Action Type");

                entity.Property(e => e.AssembleToOrder).HasColumnName("Assemble to Order");

                entity.Property(e => e.AtoComponent).HasColumnName("ATO Component");

                entity.Property(e => e.BinCode)
                    .IsRequired()
                    .HasColumnName("Bin Code")
                    .HasMaxLength(20);

                entity.Property(e => e.BinRanking).HasColumnName("Bin Ranking");

                entity.Property(e => e.BinTypeCode)
                    .IsRequired()
                    .HasColumnName("Bin Type Code")
                    .HasMaxLength(10);

                entity.Property(e => e.BreakbulkNo).HasColumnName("Breakbulk No_");

                entity.Property(e => e.CrossDockInformation).HasColumnName("Cross-Dock Information");

                entity.Property(e => e.Cubage).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("Description 2")
                    .HasMaxLength(50);

                entity.Property(e => e.DestinationNo)
                    .IsRequired()
                    .HasColumnName("Destination No_")
                    .HasMaxLength(20);

                entity.Property(e => e.DestinationType).HasColumnName("Destination Type");

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ExpirationDate)
                    .HasColumnName("Expiration Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItemNo)
                    .IsRequired()
                    .HasColumnName("Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.LotNo)
                    .IsRequired()
                    .HasColumnName("Lot No_")
                    .HasMaxLength(20);

                entity.Property(e => e.OriginalBreakbulk).HasColumnName("Original Breakbulk");

                entity.Property(e => e.QtyBase)
                    .HasColumnName("Qty_ (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyHandled)
                    .HasColumnName("Qty_ Handled")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyHandledBase)
                    .HasColumnName("Qty_ Handled (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyOutstanding)
                    .HasColumnName("Qty_ Outstanding")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyOutstandingBase)
                    .HasColumnName("Qty_ Outstanding (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPerUnitOfMeasure)
                    .HasColumnName("Qty_ per Unit of Measure")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToHandle)
                    .HasColumnName("Qty_ to Handle")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToHandleBase)
                    .HasColumnName("Qty_ to Handle (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.SerialNo)
                    .IsRequired()
                    .HasColumnName("Serial No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShelfNo)
                    .IsRequired()
                    .HasColumnName("Shelf No_")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipmentMethodCode)
                    .IsRequired()
                    .HasColumnName("Shipment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAdvice).HasColumnName("Shipping Advice");

                entity.Property(e => e.ShippingAgentCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Service Code")
                    .HasMaxLength(10);

                entity.Property(e => e.SortingSequenceNo).HasColumnName("Sorting Sequence No_");

                entity.Property(e => e.SourceDocument).HasColumnName("Source Document");

                entity.Property(e => e.SourceLineNo).HasColumnName("Source Line No_");

                entity.Property(e => e.SourceNo)
                    .IsRequired()
                    .HasColumnName("Source No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SourceSublineNo).HasColumnName("Source Subline No_");

                entity.Property(e => e.SourceSubtype).HasColumnName("Source Subtype");

                entity.Property(e => e.SourceType).HasColumnName("Source Type");

                entity.Property(e => e.SpecialEquipmentCode)
                    .IsRequired()
                    .HasColumnName("Special Equipment Code")
                    .HasMaxLength(10);

                entity.Property(e => e.StartingDate)
                    .HasColumnName("Starting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasColumnName("Unit of Measure Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.WarrantyDate)
                    .HasColumnName("Warranty Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Weight).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.WhseDocumentLineNo).HasColumnName("Whse_ Document Line No_");

                entity.Property(e => e.WhseDocumentNo)
                    .IsRequired()
                    .HasColumnName("Whse_ Document No_")
                    .HasMaxLength(20);

                entity.Property(e => e.WhseDocumentType).HasColumnName("Whse_ Document Type");

                entity.Property(e => e.ZoneCode)
                    .IsRequired()
                    .HasColumnName("Zone Code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<WarehouseShipmentHeader>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Warehouse Shipment Header");

                entity.HasIndex(e => new { e.LocationCode, e.No })
                    .HasName("$1")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .IsRequired()
                    .HasColumnName("Assigned User ID")
                    .HasMaxLength(50);

                entity.Property(e => e.AssignmentDate)
                    .HasColumnName("Assignment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssignmentTime)
                    .HasColumnName("Assignment Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.BinCode)
                    .IsRequired()
                    .HasColumnName("Bin Code")
                    .HasMaxLength(20);

                entity.Property(e => e.CreatePostedHeader).HasColumnName("Create Posted Header");

                entity.Property(e => e.DocumentStatus).HasColumnName("Document Status");

                entity.Property(e => e.ExternalDocumentNo)
                    .IsRequired()
                    .HasColumnName("External Document No_")
                    .HasMaxLength(35);

                entity.Property(e => e.LastShippingNo)
                    .IsRequired()
                    .HasColumnName("Last Shipping No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.PostingDate)
                    .HasColumnName("Posting Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipmentDate)
                    .HasColumnName("Shipment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShipmentMethodCode)
                    .IsRequired()
                    .HasColumnName("Shipment Method Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAgentCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingAgentServiceCode)
                    .IsRequired()
                    .HasColumnName("Shipping Agent Service Code")
                    .HasMaxLength(10);

                entity.Property(e => e.ShippingNo)
                    .IsRequired()
                    .HasColumnName("Shipping No_")
                    .HasMaxLength(20);

                entity.Property(e => e.ShippingNoSeries)
                    .IsRequired()
                    .HasColumnName("Shipping No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.SortingMethod).HasColumnName("Sorting Method");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.ZoneCode)
                    .IsRequired()
                    .HasColumnName("Zone Code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<WarehouseShipmentLine>(entity =>
            {
                entity.HasKey(e => new { e.No, e.LineNo });

                entity.ToTable("Warehouse Shipment Line");

                entity.HasIndex(e => new { e.BinCode, e.LocationCode, e.No, e.LineNo })
                    .HasName("$11")
                    .IsUnique();

                entity.HasIndex(e => new { e.ItemNo, e.LocationCode, e.VariantCode, e.DueDate, e.No, e.LineNo })
                    .HasName("$10")
                    .IsUnique();

                entity.HasIndex(e => new { e.SourceType, e.SourceSubtype, e.SourceNo, e.SourceLineNo, e.AssembleToOrder, e.No, e.LineNo })
                    .HasName("$8")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.AssembleToOrder).HasColumnName("Assemble to Order");

                entity.Property(e => e.BinCode)
                    .IsRequired()
                    .HasColumnName("Bin Code")
                    .HasMaxLength(20);

                entity.Property(e => e.CompletelyPicked).HasColumnName("Completely Picked");

                entity.Property(e => e.Cubage).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("Description 2")
                    .HasMaxLength(50);

                entity.Property(e => e.DestinationNo)
                    .IsRequired()
                    .HasColumnName("Destination No_")
                    .HasMaxLength(20);

                entity.Property(e => e.DestinationType).HasColumnName("Destination Type");

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItemNo)
                    .IsRequired()
                    .HasColumnName("Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NotUpdBySrcDocPost).HasColumnName("Not upd_ by Src_ Doc_ Post_");

                entity.Property(e => e.PostingFromWhseRef).HasColumnName("Posting from Whse_ Ref_");

                entity.Property(e => e.QtyBase)
                    .HasColumnName("Qty_ (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyOutstanding)
                    .HasColumnName("Qty_ Outstanding")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyOutstandingBase)
                    .HasColumnName("Qty_ Outstanding (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPerUnitOfMeasure)
                    .HasColumnName("Qty_ per Unit of Measure")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPicked)
                    .HasColumnName("Qty_ Picked")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPickedBase)
                    .HasColumnName("Qty_ Picked (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyShipped)
                    .HasColumnName("Qty_ Shipped")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyShippedBase)
                    .HasColumnName("Qty_ Shipped (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToShip)
                    .HasColumnName("Qty_ to Ship")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyToShipBase)
                    .HasColumnName("Qty_ to Ship (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ShelfNo)
                    .IsRequired()
                    .HasColumnName("Shelf No_")
                    .HasMaxLength(10);

                entity.Property(e => e.ShipmentDate)
                    .HasColumnName("Shipment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ShippingAdvice).HasColumnName("Shipping Advice");

                entity.Property(e => e.SortingSequenceNo).HasColumnName("Sorting Sequence No_");

                entity.Property(e => e.SourceDocument).HasColumnName("Source Document");

                entity.Property(e => e.SourceLineNo).HasColumnName("Source Line No_");

                entity.Property(e => e.SourceNo)
                    .IsRequired()
                    .HasColumnName("Source No_")
                    .HasMaxLength(20);

                entity.Property(e => e.SourceSubtype).HasColumnName("Source Subtype");

                entity.Property(e => e.SourceType).HasColumnName("Source Type");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasColumnName("Unit of Measure Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Weight).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ZoneCode)
                    .IsRequired()
                    .HasColumnName("Zone Code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<WhseInternalPickHeader>(entity =>
            {
                entity.HasKey(e => e.No);

                entity.ToTable("Whse_ Internal Pick Header");

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20)
                    .ValueGeneratedNever();

                entity.Property(e => e.AssignedUserId)
                    .IsRequired()
                    .HasColumnName("Assigned User ID")
                    .HasMaxLength(50);

                entity.Property(e => e.AssignmentDate)
                    .HasColumnName("Assignment Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.AssignmentTime)
                    .HasColumnName("Assignment Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.DocumentStatus).HasColumnName("Document Status");

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.NoSeries)
                    .IsRequired()
                    .HasColumnName("No_ Series")
                    .HasMaxLength(20);

                entity.Property(e => e.SortingMethod).HasColumnName("Sorting Method");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.ToBinCode)
                    .IsRequired()
                    .HasColumnName("To Bin Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ToZoneCode)
                    .IsRequired()
                    .HasColumnName("To Zone Code")
                    .HasMaxLength(10);
            });

            modelBuilder.Entity<WhseInternalPickLine>(entity =>
            {
                entity.HasKey(e => new { e.No, e.LineNo });

                entity.ToTable("Whse_ Internal Pick Line");

                entity.HasIndex(e => new { e.No, e.SortingSequenceNo, e.LineNo })
                    .HasName("$1")
                    .IsUnique();

                entity.HasIndex(e => new { e.ToBinCode, e.LocationCode, e.No, e.LineNo })
                    .HasName("$6")
                    .IsUnique();

                entity.Property(e => e.No)
                    .HasColumnName("No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LineNo).HasColumnName("Line No_");

                entity.Property(e => e.Cubage).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Description2)
                    .IsRequired()
                    .HasColumnName("Description 2")
                    .HasMaxLength(50);

                entity.Property(e => e.DueDate)
                    .HasColumnName("Due Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItemNo)
                    .IsRequired()
                    .HasColumnName("Item No_")
                    .HasMaxLength(20);

                entity.Property(e => e.LocationCode)
                    .IsRequired()
                    .HasColumnName("Location Code")
                    .HasMaxLength(10);

                entity.Property(e => e.QtyBase)
                    .HasColumnName("Qty_ (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyOutstanding)
                    .HasColumnName("Qty_ Outstanding")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyOutstandingBase)
                    .HasColumnName("Qty_ Outstanding (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPerUnitOfMeasure)
                    .HasColumnName("Qty_ per Unit of Measure")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPicked)
                    .HasColumnName("Qty_ Picked")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.QtyPickedBase)
                    .HasColumnName("Qty_ Picked (Base)")
                    .HasColumnType("decimal(38, 20)");

                entity.Property(e => e.Quantity).HasColumnType("decimal(38, 20)");

                entity.Property(e => e.ShelfNo)
                    .IsRequired()
                    .HasColumnName("Shelf No_")
                    .HasMaxLength(10);

                entity.Property(e => e.SortingSequenceNo).HasColumnName("Sorting Sequence No_");

                entity.Property(e => e.Timestamp)
                    .IsRequired()
                    .HasColumnName("timestamp")
                    .IsRowVersion();

                entity.Property(e => e.ToBinCode)
                    .IsRequired()
                    .HasColumnName("To Bin Code")
                    .HasMaxLength(20);

                entity.Property(e => e.ToZoneCode)
                    .IsRequired()
                    .HasColumnName("To Zone Code")
                    .HasMaxLength(10);

                entity.Property(e => e.UnitOfMeasureCode)
                    .IsRequired()
                    .HasColumnName("Unit of Measure Code")
                    .HasMaxLength(10);

                entity.Property(e => e.VariantCode)
                    .IsRequired()
                    .HasColumnName("Variant Code")
                    .HasMaxLength(10);

                entity.Property(e => e.Weight).HasColumnType("decimal(38, 20)");
            });
        }
    }
}
