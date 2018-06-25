using System;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ArthausWebStore.Migrations
{
    public partial class InitialMigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cust_ Ledger Entry",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    EntryNo_ = table.Column<int>(name: "Entry No_", nullable: false),
                    CustomerNo_ = table.Column<string>(name: "Customer No_", maxLength: 20, nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    DocumentType = table.Column<int>(name: "Document Type", nullable: false),
                    DocumentNo_ = table.Column<string>(name: "Document No_", maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    SalesLCY = table.Column<decimal>(name: "Sales (LCY)", type: "decimal(38, 20)", nullable: false),
                    ProfitLCY = table.Column<decimal>(name: "Profit (LCY)", type: "decimal(38, 20)", nullable: false),
                    Inv_DiscountLCY = table.Column<decimal>(name: "Inv_ Discount (LCY)", type: "decimal(38, 20)", nullable: false),
                    SelltoCustomerNo_ = table.Column<string>(name: "Sell-to Customer No_", maxLength: 20, nullable: false),
                    CustomerPostingGroup = table.Column<string>(name: "Customer Posting Group", maxLength: 20, nullable: false),
                    GlobalDimension1Code = table.Column<string>(name: "Global Dimension 1 Code", maxLength: 20, nullable: false),
                    GlobalDimension2Code = table.Column<string>(name: "Global Dimension 2 Code", maxLength: 20, nullable: false),
                    SalespersonCode = table.Column<string>(name: "Salesperson Code", maxLength: 20, nullable: false),
                    UserID = table.Column<string>(name: "User ID", maxLength: 50, nullable: false),
                    SourceCode = table.Column<string>(name: "Source Code", maxLength: 10, nullable: false),
                    OnHold = table.Column<string>(name: "On Hold", maxLength: 3, nullable: false),
                    AppliestoDoc_Type = table.Column<int>(name: "Applies-to Doc_ Type", nullable: false),
                    AppliestoDoc_No_ = table.Column<string>(name: "Applies-to Doc_ No_", maxLength: 20, nullable: false),
                    Open = table.Column<byte>(nullable: false),
                    DueDate = table.Column<DateTime>(name: "Due Date", type: "datetime", nullable: false),
                    Pmt_DiscountDate = table.Column<DateTime>(name: "Pmt_ Discount Date", type: "datetime", nullable: false),
                    OriginalPmt_Disc_Possible = table.Column<decimal>(name: "Original Pmt_ Disc_ Possible", type: "decimal(38, 20)", nullable: false),
                    Pmt_Disc_GivenLCY = table.Column<decimal>(name: "Pmt_ Disc_ Given (LCY)", type: "decimal(38, 20)", nullable: false),
                    Positive = table.Column<byte>(nullable: false),
                    ClosedbyEntryNo_ = table.Column<int>(name: "Closed by Entry No_", nullable: false),
                    ClosedatDate = table.Column<DateTime>(name: "Closed at Date", type: "datetime", nullable: false),
                    ClosedbyAmount = table.Column<decimal>(name: "Closed by Amount", type: "decimal(38, 20)", nullable: false),
                    AppliestoID = table.Column<string>(name: "Applies-to ID", maxLength: 50, nullable: false),
                    JournalBatchName = table.Column<string>(name: "Journal Batch Name", maxLength: 10, nullable: false),
                    ReasonCode = table.Column<string>(name: "Reason Code", maxLength: 10, nullable: false),
                    Bal_AccountType = table.Column<int>(name: "Bal_ Account Type", nullable: false),
                    Bal_AccountNo_ = table.Column<string>(name: "Bal_ Account No_", maxLength: 20, nullable: false),
                    TransactionNo_ = table.Column<int>(name: "Transaction No_", nullable: false),
                    ClosedbyAmountLCY = table.Column<decimal>(name: "Closed by Amount (LCY)", type: "decimal(38, 20)", nullable: false),
                    DocumentDate = table.Column<DateTime>(name: "Document Date", type: "datetime", nullable: false),
                    ExternalDocumentNo_ = table.Column<string>(name: "External Document No_", maxLength: 35, nullable: false),
                    CalculateInterest = table.Column<byte>(name: "Calculate Interest", nullable: false),
                    ClosingInterestCalculated = table.Column<byte>(name: "Closing Interest Calculated", nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    ClosedbyCurrencyCode = table.Column<string>(name: "Closed by Currency Code", maxLength: 10, nullable: false),
                    ClosedbyCurrencyAmount = table.Column<decimal>(name: "Closed by Currency Amount", type: "decimal(38, 20)", nullable: false),
                    AdjustedCurrencyFactor = table.Column<decimal>(name: "Adjusted Currency Factor", type: "decimal(38, 20)", nullable: false),
                    OriginalCurrencyFactor = table.Column<decimal>(name: "Original Currency Factor", type: "decimal(38, 20)", nullable: false),
                    RemainingPmt_Disc_Possible = table.Column<decimal>(name: "Remaining Pmt_ Disc_ Possible", type: "decimal(38, 20)", nullable: false),
                    Pmt_Disc_ToleranceDate = table.Column<DateTime>(name: "Pmt_ Disc_ Tolerance Date", type: "datetime", nullable: false),
                    Max_PaymentTolerance = table.Column<decimal>(name: "Max_ Payment Tolerance", type: "decimal(38, 20)", nullable: false),
                    LastIssuedReminderLevel = table.Column<int>(name: "Last Issued Reminder Level", nullable: false),
                    AcceptedPaymentTolerance = table.Column<decimal>(name: "Accepted Payment Tolerance", type: "decimal(38, 20)", nullable: false),
                    AcceptedPmt_Disc_Tolerance = table.Column<byte>(name: "Accepted Pmt_ Disc_ Tolerance", nullable: false),
                    Pmt_ToleranceLCY = table.Column<decimal>(name: "Pmt_ Tolerance (LCY)", type: "decimal(38, 20)", nullable: false),
                    AmounttoApply = table.Column<decimal>(name: "Amount to Apply", type: "decimal(38, 20)", nullable: false),
                    ICPartnerCode = table.Column<string>(name: "IC Partner Code", maxLength: 20, nullable: false),
                    ApplyingEntry = table.Column<byte>(name: "Applying Entry", nullable: false),
                    Reversed = table.Column<byte>(nullable: false),
                    ReversedbyEntryNo_ = table.Column<int>(name: "Reversed by Entry No_", nullable: false),
                    ReversedEntryNo_ = table.Column<int>(name: "Reversed Entry No_", nullable: false),
                    Prepayment = table.Column<byte>(nullable: false),
                    PaymentMethodCode = table.Column<string>(name: "Payment Method Code", maxLength: 10, nullable: false),
                    AppliestoExt_Doc_No_ = table.Column<string>(name: "Applies-to Ext_ Doc_ No_", maxLength: 35, nullable: false),
                    RecipientBankAccount = table.Column<string>(name: "Recipient Bank Account", maxLength: 20, nullable: false),
                    MessagetoRecipient = table.Column<string>(name: "Message to Recipient", maxLength: 140, nullable: false),
                    ExportedtoPaymentFile = table.Column<byte>(name: "Exported to Payment File", nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    DirectDebitMandateID = table.Column<string>(name: "Direct Debit Mandate ID", maxLength: 35, nullable: false),
                    BatchNo_ = table.Column<string>(name: "Batch No_", maxLength: 10, nullable: false),
                    StatementNo_ = table.Column<string>(name: "Statement No_", maxLength: 20, nullable: false),
                    SelltoContactNo_ = table.Column<string>(name: "Sell-to Contact No_", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cust_ Ledger Entry", x => x.EntryNo_);
                });

            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    SearchName = table.Column<string>(name: "Search Name", maxLength: 50, nullable: false),
                    Name2 = table.Column<string>(name: "Name 2", maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    Address2 = table.Column<string>(name: "Address 2", maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 30, nullable: false),
                    Contact = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNo_ = table.Column<string>(name: "Phone No_", maxLength: 30, nullable: false),
                    TelexNo_ = table.Column<string>(name: "Telex No_", maxLength: 20, nullable: false),
                    DocumentSendingProfile = table.Column<string>(name: "Document Sending Profile", maxLength: 20, nullable: false),
                    OurAccountNo_ = table.Column<string>(name: "Our Account No_", maxLength: 20, nullable: false),
                    TerritoryCode = table.Column<string>(name: "Territory Code", maxLength: 10, nullable: false),
                    GlobalDimension1Code = table.Column<string>(name: "Global Dimension 1 Code", maxLength: 20, nullable: false),
                    GlobalDimension2Code = table.Column<string>(name: "Global Dimension 2 Code", maxLength: 20, nullable: false),
                    ChainName = table.Column<string>(name: "Chain Name", maxLength: 10, nullable: false),
                    BudgetedAmount = table.Column<decimal>(name: "Budgeted Amount", type: "decimal(38, 20)", nullable: false),
                    CreditLimitLCY = table.Column<decimal>(name: "Credit Limit (LCY)", type: "decimal(38, 20)", nullable: false),
                    CustomerPostingGroup = table.Column<string>(name: "Customer Posting Group", maxLength: 20, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    CustomerPriceGroup = table.Column<string>(name: "Customer Price Group", maxLength: 10, nullable: false),
                    LanguageCode = table.Column<string>(name: "Language Code", maxLength: 10, nullable: false),
                    StatisticsGroup = table.Column<int>(name: "Statistics Group", nullable: false),
                    PaymentTermsCode = table.Column<string>(name: "Payment Terms Code", maxLength: 10, nullable: false),
                    Fin_ChargeTermsCode = table.Column<string>(name: "Fin_ Charge Terms Code", maxLength: 10, nullable: false),
                    SalespersonCode = table.Column<string>(name: "Salesperson Code", maxLength: 20, nullable: false),
                    ShipmentMethodCode = table.Column<string>(name: "Shipment Method Code", maxLength: 10, nullable: false),
                    ShippingAgentCode = table.Column<string>(name: "Shipping Agent Code", maxLength: 10, nullable: false),
                    PlaceofExport = table.Column<string>(name: "Place of Export", maxLength: 20, nullable: false),
                    InvoiceDisc_Code = table.Column<string>(name: "Invoice Disc_ Code", maxLength: 20, nullable: false),
                    CustomerDisc_Group = table.Column<string>(name: "Customer Disc_ Group", maxLength: 20, nullable: false),
                    Country_RegionCode = table.Column<string>(name: "Country_Region Code", maxLength: 10, nullable: false),
                    CollectionMethod = table.Column<string>(name: "Collection Method", maxLength: 20, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    Blocked = table.Column<int>(nullable: false),
                    InvoiceCopies = table.Column<int>(name: "Invoice Copies", nullable: false),
                    LastStatementNo_ = table.Column<int>(name: "Last Statement No_", nullable: false),
                    PrintStatements = table.Column<byte>(name: "Print Statements", nullable: false),
                    BilltoCustomerNo_ = table.Column<string>(name: "Bill-to Customer No_", maxLength: 20, nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    PaymentMethodCode = table.Column<string>(name: "Payment Method Code", maxLength: 10, nullable: false),
                    LastDateModified = table.Column<DateTime>(name: "Last Date Modified", type: "datetime", nullable: false),
                    ApplicationMethod = table.Column<int>(name: "Application Method", nullable: false),
                    PricesIncludingVAT = table.Column<byte>(name: "Prices Including VAT", nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    FaxNo_ = table.Column<string>(name: "Fax No_", maxLength: 30, nullable: false),
                    TelexAnswerBack = table.Column<string>(name: "Telex Answer Back", maxLength: 20, nullable: false),
                    VATRegistrationNo_ = table.Column<string>(name: "VAT Registration No_", maxLength: 20, nullable: false),
                    CombineShipments = table.Column<byte>(name: "Combine Shipments", nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    Picture = table.Column<byte[]>(type: "image", nullable: true),
                    GLN = table.Column<string>(maxLength: 13, nullable: false),
                    PostCode = table.Column<string>(name: "Post Code", maxLength: 20, nullable: false),
                    County = table.Column<string>(maxLength: 30, nullable: false),
                    EMail = table.Column<string>(name: "E-Mail", maxLength: 80, nullable: false),
                    HomePage = table.Column<string>(name: "Home Page", maxLength: 80, nullable: false),
                    ReminderTermsCode = table.Column<string>(name: "Reminder Terms Code", maxLength: 10, nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    Reserve = table.Column<int>(nullable: false),
                    BlockPaymentTolerance = table.Column<byte>(name: "Block Payment Tolerance", nullable: false),
                    ICPartnerCode = table.Column<string>(name: "IC Partner Code", maxLength: 20, nullable: false),
                    Prepayment_ = table.Column<decimal>(name: "Prepayment _", type: "decimal(38, 20)", nullable: false),
                    PartnerType = table.Column<int>(name: "Partner Type", nullable: false),
                    Image = table.Column<Guid>(nullable: false),
                    PreferredBankAccountCode = table.Column<string>(name: "Preferred Bank Account Code", maxLength: 20, nullable: false),
                    CashFlowPaymentTermsCode = table.Column<string>(name: "Cash Flow Payment Terms Code", maxLength: 10, nullable: false),
                    PrimaryContactNo_ = table.Column<string>(name: "Primary Contact No_", maxLength: 20, nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    ShippingAdvice = table.Column<int>(name: "Shipping Advice", nullable: false),
                    ShippingTime = table.Column<string>(name: "Shipping Time", unicode: false, maxLength: 32, nullable: false),
                    ShippingAgentServiceCode = table.Column<string>(name: "Shipping Agent Service Code", maxLength: 10, nullable: false),
                    ServiceZoneCode = table.Column<string>(name: "Service Zone Code", maxLength: 10, nullable: false),
                    AllowLineDisc_ = table.Column<byte>(name: "Allow Line Disc_", nullable: false),
                    BaseCalendarCode = table.Column<string>(name: "Base Calendar Code", maxLength: 10, nullable: false),
                    CopySelltoAddr_toQteFrom = table.Column<int>(name: "Copy Sell-to Addr_ to Qte From", nullable: false),
                    DateCreated = table.Column<DateTime>(name: "Date Created", type: "datetime", nullable: false),
                    CreatedbyUser = table.Column<string>(name: "Created by User", maxLength: 50, nullable: false),
                    CustomerID = table.Column<string>(name: "Customer ID", maxLength: 10, nullable: false),
                    ReasonCode = table.Column<string>(name: "Reason Code", maxLength: 10, nullable: false),
                    RestrictionFunctionality = table.Column<int>(name: "Restriction Functionality", nullable: false),
                    PrintDocumentInvoice = table.Column<byte>(name: "Print Document Invoice", nullable: false),
                    TransactionLimit = table.Column<decimal>(name: "Transaction Limit", type: "decimal(38, 20)", nullable: false),
                    DaytimePhoneNo_ = table.Column<string>(name: "Daytime Phone No_", maxLength: 30, nullable: false),
                    MobilePhoneNo_ = table.Column<string>(name: "Mobile Phone No_", maxLength: 30, nullable: false),
                    HouseNo_ = table.Column<string>(name: "House No_", maxLength: 30, nullable: false),
                    RetailCustomerGroup = table.Column<string>(name: "Retail Customer Group", maxLength: 10, nullable: false),
                    DefaultWeight = table.Column<decimal>(name: "Default Weight", type: "decimal(38, 20)", nullable: false),
                    OtherTenderinFinalizing = table.Column<byte>(name: "Other Tender in Finalizing", nullable: false),
                    PostasShipment = table.Column<byte>(name: "Post as Shipment", nullable: false),
                    LastModifiedDateTime = table.Column<DateTime>(name: "Last Modified Date Time", type: "datetime", nullable: false),
                    PrivacyBlocked = table.Column<byte>(name: "Privacy Blocked", nullable: false),
                    ContactType = table.Column<int>(name: "Contact Type", nullable: false),
                    ValidateEUVatReg_No_ = table.Column<byte>(name: "Validate EU Vat Reg_ No_", nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    CurrencyId = table.Column<Guid>(name: "Currency Id", nullable: false),
                    PaymentTermsId = table.Column<Guid>(name: "Payment Terms Id", nullable: false),
                    ShipmentMethodId = table.Column<Guid>(name: "Shipment Method Id", nullable: false),
                    PaymentMethodId = table.Column<Guid>(name: "Payment Method Id", nullable: false),
                    TaxAreaID = table.Column<Guid>(name: "Tax Area ID", nullable: false),
                    ContactID = table.Column<Guid>(name: "Contact ID", nullable: false),
                    ContactGraphId = table.Column<string>(name: "Contact Graph Id", maxLength: 250, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Customer Order Discount Line",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DocumentId = table.Column<string>(name: "Document Id", maxLength: 40, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    EntryNo_ = table.Column<int>(name: "Entry No_", nullable: false),
                    DiscountType = table.Column<int>(name: "Discount Type", nullable: false),
                    OfferNo_ = table.Column<string>(name: "Offer No_", maxLength: 20, nullable: false),
                    PeriodicDisc_Type = table.Column<int>(name: "Periodic Disc_ Type", nullable: false),
                    PeriodicDisc_Group = table.Column<string>(name: "Periodic Disc_ Group", maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    DiscountPercent = table.Column<decimal>(name: "Discount Percent", type: "decimal(38, 20)", nullable: false),
                    DiscountAmount = table.Column<decimal>(name: "Discount Amount", type: "decimal(38, 20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer Order Discount Line", x => new { x.DocumentId, x.LineNo_, x.EntryNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Customer Order Header",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DocumentId = table.Column<string>(name: "Document Id", maxLength: 40, nullable: false),
                    StoreNo_ = table.Column<string>(name: "Store No_", maxLength: 10, nullable: false),
                    CollectLocation = table.Column<string>(name: "Collect Location", maxLength: 20, nullable: false),
                    WebTrans_GUID = table.Column<Guid>(name: "Web Trans_ GUID", nullable: false),
                    DocumentDateTime = table.Column<DateTime>(name: "Document DateTime", type: "datetime", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    TerminalNo_ = table.Column<string>(name: "Terminal No_", maxLength: 10, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    CurrencyFactor = table.Column<decimal>(name: "Currency Factor", type: "decimal(38, 20)", nullable: false),
                    VatBus_PostingGroup = table.Column<string>(name: "Vat Bus_ Posting Group", maxLength: 10, nullable: false),
                    PriceGroupCode = table.Column<string>(name: "Price Group Code", maxLength: 10, nullable: false),
                    CustomerNo_ = table.Column<string>(name: "Customer No_", maxLength: 20, nullable: false),
                    Cust_Disc_Group = table.Column<string>(name: "Cust_ Disc_ Group", maxLength: 20, nullable: false),
                    MemberCardNo_ = table.Column<string>(name: "Member Card No_", maxLength: 100, nullable: false),
                    MemberContactNo_ = table.Column<string>(name: "Member Contact No_", maxLength: 20, nullable: false),
                    MemberContactName = table.Column<string>(name: "Member Contact Name", maxLength: 50, nullable: false),
                    CollectTimeLimit = table.Column<DateTime>(name: "Collect Time Limit", type: "datetime", nullable: false),
                    SourceType = table.Column<int>(name: "Source Type", nullable: false),
                    ReceiptNo_ = table.Column<string>(name: "Receipt No_", maxLength: 20, nullable: false),
                    Trans_StoreNo_ = table.Column<string>(name: "Trans_ Store No_", maxLength: 10, nullable: false),
                    Trans_TerminalNo_ = table.Column<string>(name: "Trans_ Terminal No_", maxLength: 10, nullable: false),
                    TransactionNo_ = table.Column<int>(name: "Transaction No_", nullable: false),
                    FullName = table.Column<string>(name: "Full Name", maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    Address2 = table.Column<string>(name: "Address 2", maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 30, nullable: false),
                    County = table.Column<string>(maxLength: 30, nullable: false),
                    PostCode = table.Column<string>(name: "Post Code", maxLength: 20, nullable: false),
                    CountryRegionCode = table.Column<string>(name: "Country Region Code", maxLength: 20, nullable: false),
                    PhoneNo_ = table.Column<string>(name: "Phone No_", maxLength: 30, nullable: false),
                    Email = table.Column<string>(maxLength: 80, nullable: false),
                    HouseApartmentNo_ = table.Column<string>(name: "House Apartment No_", maxLength: 30, nullable: false),
                    MobilePhoneNo_ = table.Column<string>(name: "Mobile Phone No_", maxLength: 30, nullable: false),
                    DaytimePhoneNo_ = table.Column<string>(name: "Daytime Phone No_", maxLength: 30, nullable: false),
                    ShipToFullName = table.Column<string>(name: "Ship To Full Name", maxLength: 50, nullable: false),
                    ShipToAddress = table.Column<string>(name: "Ship To Address", maxLength: 50, nullable: false),
                    ShipToAddress2 = table.Column<string>(name: "Ship To Address 2", maxLength: 50, nullable: false),
                    ShipToCity = table.Column<string>(name: "Ship To City", maxLength: 30, nullable: false),
                    ShipToCounty = table.Column<string>(name: "Ship To County", maxLength: 30, nullable: false),
                    ShipToPostCode = table.Column<string>(name: "Ship To Post Code", maxLength: 20, nullable: false),
                    ShipToCountryRegionCode = table.Column<string>(name: "Ship To Country Region Code", maxLength: 20, nullable: false),
                    ShipToPhoneNo_ = table.Column<string>(name: "Ship To Phone No_", maxLength: 30, nullable: false),
                    ShipToEmail = table.Column<string>(name: "Ship To Email", maxLength: 80, nullable: false),
                    ShipToHouseApartmentNo_ = table.Column<string>(name: "Ship To House Apartment No_", maxLength: 30, nullable: false),
                    ClickAndCollectOrder = table.Column<byte>(name: "Click And Collect Order", nullable: false),
                    AnonymousOrder = table.Column<byte>(name: "Anonymous Order", nullable: false),
                    ShippingAgentCode = table.Column<string>(name: "Shipping Agent Code", maxLength: 10, nullable: false),
                    ShippingAgentServiceCode = table.Column<string>(name: "Shipping Agent Service Code", maxLength: 10, nullable: false),
                    SalesOrderNo_ = table.Column<string>(name: "Sales Order No_", maxLength: 20, nullable: false),
                    SourcingLocation = table.Column<string>(name: "Sourcing Location", maxLength: 10, nullable: false),
                    SourcingOrder = table.Column<int>(name: "Sourcing Order", nullable: false),
                    CreatedatStore = table.Column<string>(name: "Created at Store", maxLength: 10, nullable: false),
                    InventoryTransfer = table.Column<byte>(name: "Inventory Transfer", nullable: false),
                    ShipOrderPOSFlag = table.Column<string>(name: "Ship Order POS Flag", maxLength: 100, nullable: false),
                    ShipOrder = table.Column<byte>(name: "Ship Order", nullable: false),
                    StatusInfo = table.Column<int>(name: "Status Info", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer Order Header", x => x.DocumentId);
                });

            migrationBuilder.CreateTable(
                name: "Customer Order Line",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DocumentId = table.Column<string>(name: "Document Id", maxLength: 40, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    LineType = table.Column<int>(name: "Line Type", nullable: false),
                    Number = table.Column<string>(maxLength: 20, nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    UnitofMeasureCode = table.Column<string>(name: "Unit of Measure Code", maxLength: 10, nullable: false),
                    NetPrice = table.Column<decimal>(name: "Net Price", type: "decimal(38, 20)", nullable: false),
                    Price = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    DiscountAmount = table.Column<decimal>(name: "Discount Amount", type: "decimal(38, 20)", nullable: false),
                    DiscountPercent = table.Column<decimal>(name: "Discount Percent", type: "decimal(38, 20)", nullable: false),
                    NetAmount = table.Column<decimal>(name: "Net Amount", type: "decimal(38, 20)", nullable: false),
                    VatAmount = table.Column<decimal>(name: "Vat Amount", type: "decimal(38, 20)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    VatProd_PostingGroup = table.Column<string>(name: "Vat Prod_ Posting Group", maxLength: 20, nullable: false),
                    ItemDescription = table.Column<string>(name: "Item Description", maxLength: 50, nullable: false),
                    VariantDescription = table.Column<string>(name: "Variant Description", maxLength: 50, nullable: false),
                    UoMDescription = table.Column<string>(name: "UoM Description", maxLength: 50, nullable: false),
                    OriginalLineNo_ = table.Column<int>(name: "Original Line No_", nullable: false),
                    InternalSelection = table.Column<byte>(name: "Internal Selection", nullable: false),
                    InternalAvailableQty_ = table.Column<decimal>(name: "Internal Available Qty_", type: "decimal(38, 20)", nullable: false),
                    SourcingLocation = table.Column<string>(name: "Sourcing Location", maxLength: 10, nullable: false),
                    OrderReference = table.Column<string>(name: "Order Reference", maxLength: 50, nullable: false),
                    InventoryTransfer = table.Column<byte>(name: "Inventory Transfer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer Order Line", x => new { x.DocumentId, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Customer Order Payment",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DocumentId = table.Column<string>(name: "Document Id", maxLength: 40, nullable: false),
                    StoreNo_ = table.Column<string>(name: "Store No_", maxLength: 10, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    PreApprovedAmount = table.Column<decimal>(name: "Pre Approved Amount", type: "decimal(38, 20)", nullable: false),
                    FinalisedAmount = table.Column<decimal>(name: "Finalised Amount", type: "decimal(38, 20)", nullable: false),
                    TenderType = table.Column<string>(name: "Tender Type", maxLength: 10, nullable: false),
                    CardType = table.Column<string>(name: "Card Type", maxLength: 10, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    CurrencyFactor = table.Column<decimal>(name: "Currency Factor", type: "decimal(38, 20)", nullable: false),
                    AuthorisationCode = table.Column<string>(name: "Authorisation Code", maxLength: 30, nullable: false),
                    PreApprovedValidDate = table.Column<DateTime>(name: "Pre Approved Valid Date", type: "datetime", nullable: false),
                    CardorCustomernumber = table.Column<string>(name: "Card or Customer number", maxLength: 100, nullable: false),
                    Income_ExpenseAccountNo_ = table.Column<string>(name: "Income_Expense Account No_", maxLength: 20, nullable: false),
                    PreApprovedAmountLCY = table.Column<decimal>(name: "Pre Approved Amount LCY", type: "decimal(38, 20)", nullable: false),
                    FinalisedAmountLCY = table.Column<decimal>(name: "Finalised Amount LCY", type: "decimal(38, 20)", nullable: false),
                    LoyaltyPointpayment = table.Column<byte>(name: "Loyalty Point payment", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customer Order Payment", x => new { x.DocumentId, x.StoreNo_, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Detailed Cust_ Ledg_Entry",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    EntryNo_ = table.Column<int>(name: "Entry No_", nullable: false),
                    Cust_LedgerEntryNo_ = table.Column<int>(name: "Cust_ Ledger Entry No_", nullable: false),
                    EntryType = table.Column<int>(name: "Entry Type", nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    DocumentType = table.Column<int>(name: "Document Type", nullable: false),
                    DocumentNo_ = table.Column<string>(name: "Document No_", maxLength: 20, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    AmountLCY = table.Column<decimal>(name: "Amount (LCY)", type: "decimal(38, 20)", nullable: false),
                    CustomerNo_ = table.Column<string>(name: "Customer No_", maxLength: 20, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    UserID = table.Column<string>(name: "User ID", maxLength: 50, nullable: false),
                    SourceCode = table.Column<string>(name: "Source Code", maxLength: 10, nullable: false),
                    TransactionNo_ = table.Column<int>(name: "Transaction No_", nullable: false),
                    JournalBatchName = table.Column<string>(name: "Journal Batch Name", maxLength: 10, nullable: false),
                    ReasonCode = table.Column<string>(name: "Reason Code", maxLength: 10, nullable: false),
                    DebitAmount = table.Column<decimal>(name: "Debit Amount", type: "decimal(38, 20)", nullable: false),
                    CreditAmount = table.Column<decimal>(name: "Credit Amount", type: "decimal(38, 20)", nullable: false),
                    DebitAmountLCY = table.Column<decimal>(name: "Debit Amount (LCY)", type: "decimal(38, 20)", nullable: false),
                    CreditAmountLCY = table.Column<decimal>(name: "Credit Amount (LCY)", type: "decimal(38, 20)", nullable: false),
                    InitialEntryDueDate = table.Column<DateTime>(name: "Initial Entry Due Date", type: "datetime", nullable: false),
                    InitialEntryGlobalDim_1 = table.Column<string>(name: "Initial Entry Global Dim_ 1", maxLength: 20, nullable: false),
                    InitialEntryGlobalDim_2 = table.Column<string>(name: "Initial Entry Global Dim_ 2", maxLength: 20, nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    Gen_Prod_PostingGroup = table.Column<string>(name: "Gen_ Prod_ Posting Group", maxLength: 20, nullable: false),
                    UseTax = table.Column<byte>(name: "Use Tax", nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    VATProd_PostingGroup = table.Column<string>(name: "VAT Prod_ Posting Group", maxLength: 20, nullable: false),
                    InitialDocumentType = table.Column<int>(name: "Initial Document Type", nullable: false),
                    AppliedCust_LedgerEntryNo_ = table.Column<int>(name: "Applied Cust_ Ledger Entry No_", nullable: false),
                    Unapplied = table.Column<byte>(nullable: false),
                    UnappliedbyEntryNo_ = table.Column<int>(name: "Unapplied by Entry No_", nullable: false),
                    RemainingPmt_Disc_Possible = table.Column<decimal>(name: "Remaining Pmt_ Disc_ Possible", type: "decimal(38, 20)", nullable: false),
                    Max_PaymentTolerance = table.Column<decimal>(name: "Max_ Payment Tolerance", type: "decimal(38, 20)", nullable: false),
                    TaxJurisdictionCode = table.Column<string>(name: "Tax Jurisdiction Code", maxLength: 10, nullable: false),
                    ApplicationNo_ = table.Column<int>(name: "Application No_", nullable: false),
                    LedgerEntryAmount = table.Column<byte>(name: "Ledger Entry Amount", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detailed Cust_ Ledg_Entry", x => x.EntryNo_);
                });

            migrationBuilder.CreateTable(
                name: "Detailed Vendor Ledg_Entry",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    EntryNo_ = table.Column<int>(name: "Entry No_", nullable: false),
                    VendorLedgerEntryNo_ = table.Column<int>(name: "Vendor Ledger Entry No_", nullable: false),
                    EntryType = table.Column<int>(name: "Entry Type", nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    DocumentType = table.Column<int>(name: "Document Type", nullable: false),
                    DocumentNo_ = table.Column<string>(name: "Document No_", maxLength: 20, nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    AmountLCY = table.Column<decimal>(name: "Amount (LCY)", type: "decimal(38, 20)", nullable: false),
                    VendorNo_ = table.Column<string>(name: "Vendor No_", maxLength: 20, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    UserID = table.Column<string>(name: "User ID", maxLength: 50, nullable: false),
                    SourceCode = table.Column<string>(name: "Source Code", maxLength: 10, nullable: false),
                    TransactionNo_ = table.Column<int>(name: "Transaction No_", nullable: false),
                    JournalBatchName = table.Column<string>(name: "Journal Batch Name", maxLength: 10, nullable: false),
                    ReasonCode = table.Column<string>(name: "Reason Code", maxLength: 10, nullable: false),
                    DebitAmount = table.Column<decimal>(name: "Debit Amount", type: "decimal(38, 20)", nullable: false),
                    CreditAmount = table.Column<decimal>(name: "Credit Amount", type: "decimal(38, 20)", nullable: false),
                    DebitAmountLCY = table.Column<decimal>(name: "Debit Amount (LCY)", type: "decimal(38, 20)", nullable: false),
                    CreditAmountLCY = table.Column<decimal>(name: "Credit Amount (LCY)", type: "decimal(38, 20)", nullable: false),
                    InitialEntryDueDate = table.Column<DateTime>(name: "Initial Entry Due Date", type: "datetime", nullable: false),
                    InitialEntryGlobalDim_1 = table.Column<string>(name: "Initial Entry Global Dim_ 1", maxLength: 20, nullable: false),
                    InitialEntryGlobalDim_2 = table.Column<string>(name: "Initial Entry Global Dim_ 2", maxLength: 20, nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    Gen_Prod_PostingGroup = table.Column<string>(name: "Gen_ Prod_ Posting Group", maxLength: 20, nullable: false),
                    UseTax = table.Column<byte>(name: "Use Tax", nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    VATProd_PostingGroup = table.Column<string>(name: "VAT Prod_ Posting Group", maxLength: 20, nullable: false),
                    InitialDocumentType = table.Column<int>(name: "Initial Document Type", nullable: false),
                    AppliedVend_LedgerEntryNo_ = table.Column<int>(name: "Applied Vend_ Ledger Entry No_", nullable: false),
                    Unapplied = table.Column<byte>(nullable: false),
                    UnappliedbyEntryNo_ = table.Column<int>(name: "Unapplied by Entry No_", nullable: false),
                    RemainingPmt_Disc_Possible = table.Column<decimal>(name: "Remaining Pmt_ Disc_ Possible", type: "decimal(38, 20)", nullable: false),
                    Max_PaymentTolerance = table.Column<decimal>(name: "Max_ Payment Tolerance", type: "decimal(38, 20)", nullable: false),
                    TaxJurisdictionCode = table.Column<string>(name: "Tax Jurisdiction Code", maxLength: 10, nullable: false),
                    ApplicationNo_ = table.Column<int>(name: "Application No_", nullable: false),
                    LedgerEntryAmount = table.Column<byte>(name: "Ledger Entry Amount", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Detailed Vendor Ledg_Entry", x => x.EntryNo_);
                });

            migrationBuilder.CreateTable(
                name: "Item",
                columns: table => new
                {
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    BaseUnitofMeasure = table.Column<string>(name: "Base Unit of Measure", maxLength: 10, nullable: false),
                    StatisticsGroup = table.Column<int>(name: "Statistics Group", nullable: false),
                    CostingMethod = table.Column<int>(name: "Costing Method", nullable: false),
                    UnitCost = table.Column<decimal>(name: "Unit Cost", type: "decimal(38, 20)", nullable: false),
                    StandardCost = table.Column<decimal>(name: "Standard Cost", type: "decimal(38, 20)", nullable: false),
                    LastDirectCost = table.Column<decimal>(name: "Last Direct Cost", type: "decimal(38, 20)", nullable: false),
                    ReorderPoint = table.Column<decimal>(name: "Reorder Point", type: "decimal(38, 20)", nullable: false),
                    ReorderQuantity = table.Column<decimal>(name: "Reorder Quantity", type: "decimal(38, 20)", nullable: false),
                    TariffNo_ = table.Column<string>(name: "Tariff No_", maxLength: 20, nullable: false),
                    StockoutWarning = table.Column<int>(name: "Stockout Warning", nullable: false),
                    ProductGroupCode = table.Column<string>(name: "Product Group Code", maxLength: 10, nullable: false),
                    ServiceItemGroup = table.Column<string>(name: "Service Item Group", maxLength: 10, nullable: false),
                    OriginalVendorNo_ = table.Column<string>(name: "Original Vendor No_", maxLength: 20, nullable: false),
                    OriginalVendorItemNo_ = table.Column<string>(name: "Original Vendor Item No_", maxLength: 20, nullable: false),
                    LifecycleStartingDate = table.Column<DateTime>(name: "Lifecycle Starting Date", type: "datetime", nullable: false),
                    LifecycleEndingDate = table.Column<DateTime>(name: "Lifecycle Ending Date", type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Item Attributes",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    SearchDescription = table.Column<string>(name: "Search Description", maxLength: 50, nullable: false),
                    Description2 = table.Column<string>(name: "Description 2", maxLength: 50, nullable: false),
                    AlternativeItemNo_ = table.Column<string>(name: "Alternative Item No_", maxLength: 20, nullable: false),
                    Blocked = table.Column<byte>(nullable: false),
                    Country_RegionofOriginCode = table.Column<string>(name: "Country_Region of Origin Code", maxLength: 10, nullable: false),
                    Reserve = table.Column<int>(nullable: false),
                    SalesUnitofMeasure = table.Column<string>(name: "Sales Unit of Measure", maxLength: 10, nullable: false),
                    Purch_UnitofMeasure = table.Column<string>(name: "Purch_ Unit of Measure", maxLength: 10, nullable: false),
                    ItemCategoryCode = table.Column<string>(name: "Item Category Code", maxLength: 20, nullable: false),
                    Assembled = table.Column<int>(nullable: false),
                    RangeCode = table.Column<int>(name: "Range Code", nullable: false),
                    CollectionYear = table.Column<int>(name: "Collection Year", nullable: false),
                    RangeStatus = table.Column<int>(name: "Range Status", nullable: false),
                    DivisionCode = table.Column<string>(name: "Division Code", maxLength: 10, nullable: false),
                    SeasonCode = table.Column<string>(name: "Season Code", maxLength: 10, nullable: false),
                    Collection = table.Column<string>(maxLength: 30, nullable: false),
                    Color = table.Column<string>(maxLength: 30, nullable: false),
                    Style = table.Column<string>(maxLength: 30, nullable: false),
                    Brand = table.Column<string>(maxLength: 30, nullable: false),
                    ItemFamilyCode = table.Column<string>(name: "Item Family Code", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item Attributes", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Item Brands",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 255, nullable: false),
                    Description = table.Column<string>(maxLength: 255, nullable: true),
                    CountryofOrigin = table.Column<string>(name: "Country of Origin", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item Brands", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Item Category",
                columns: table => new
                {
                    Code = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    PresentationOrder = table.Column<int>(name: "Presentation Order", nullable: false),
                    NotDiscountable = table.Column<byte>(name: "Not Discountable", nullable: false),
                    DivisionCode = table.Column<string>(name: "Division Code", maxLength: 10, nullable: false),
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item Category", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Item Divisions",
                columns: table => new
                {
                    DivisionCode = table.Column<string>(name: "Division Code", maxLength: 10, nullable: false),
                    DivisionDescription = table.Column<string>(name: "Division Description", maxLength: 50, nullable: false),
                    BuyableOnline = table.Column<int>(name: "Buyable Online", nullable: false),
                    Active = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item Divisions", x => x.DivisionCode);
                });

            migrationBuilder.CreateTable(
                name: "Item Ledger Entry",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    EntryNo_ = table.Column<int>(name: "Entry No_", nullable: false),
                    ItemNo_ = table.Column<string>(name: "Item No_", maxLength: 20, nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    EntryType = table.Column<int>(name: "Entry Type", nullable: false),
                    SourceNo_ = table.Column<string>(name: "Source No_", maxLength: 20, nullable: false),
                    DocumentNo_ = table.Column<string>(name: "Document No_", maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    RemainingQuantity = table.Column<decimal>(name: "Remaining Quantity", type: "decimal(38, 20)", nullable: false),
                    InvoicedQuantity = table.Column<decimal>(name: "Invoiced Quantity", type: "decimal(38, 20)", nullable: false),
                    AppliestoEntry = table.Column<int>(name: "Applies-to Entry", nullable: false),
                    Open = table.Column<byte>(nullable: false),
                    GlobalDimension1Code = table.Column<string>(name: "Global Dimension 1 Code", maxLength: 20, nullable: false),
                    GlobalDimension2Code = table.Column<string>(name: "Global Dimension 2 Code", maxLength: 20, nullable: false),
                    Positive = table.Column<byte>(nullable: false),
                    SourceType = table.Column<int>(name: "Source Type", nullable: false),
                    DropShipment = table.Column<byte>(name: "Drop Shipment", nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", maxLength: 10, nullable: false),
                    TransportMethod = table.Column<string>(name: "Transport Method", maxLength: 10, nullable: false),
                    Country_RegionCode = table.Column<string>(name: "Country_Region Code", maxLength: 10, nullable: false),
                    Entry_ExitPoint = table.Column<string>(name: "Entry_Exit Point", maxLength: 10, nullable: false),
                    DocumentDate = table.Column<DateTime>(name: "Document Date", type: "datetime", nullable: false),
                    ExternalDocumentNo_ = table.Column<string>(name: "External Document No_", maxLength: 35, nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: false),
                    TransactionSpecification = table.Column<string>(name: "Transaction Specification", maxLength: 10, nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    DocumentType = table.Column<int>(name: "Document Type", nullable: false),
                    DocumentLineNo_ = table.Column<int>(name: "Document Line No_", nullable: false),
                    OrderType = table.Column<int>(name: "Order Type", nullable: false),
                    OrderNo_ = table.Column<string>(name: "Order No_", maxLength: 20, nullable: false),
                    OrderLineNo_ = table.Column<int>(name: "Order Line No_", nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    AssembletoOrder = table.Column<byte>(name: "Assemble to Order", nullable: false),
                    JobNo_ = table.Column<string>(name: "Job No_", maxLength: 20, nullable: false),
                    JobTaskNo_ = table.Column<string>(name: "Job Task No_", maxLength: 20, nullable: false),
                    JobPurchase = table.Column<byte>(name: "Job Purchase", nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    Qty_perUnitofMeasure = table.Column<decimal>(name: "Qty_ per Unit of Measure", type: "decimal(38, 20)", nullable: false),
                    UnitofMeasureCode = table.Column<string>(name: "Unit of Measure Code", maxLength: 10, nullable: false),
                    DerivedfromBlanketOrder = table.Column<byte>(name: "Derived from Blanket Order", nullable: false),
                    CrossReferenceNo_ = table.Column<string>(name: "Cross-Reference No_", maxLength: 20, nullable: false),
                    OriginallyOrderedNo_ = table.Column<string>(name: "Originally Ordered No_", maxLength: 20, nullable: false),
                    OriginallyOrderedVar_Code = table.Column<string>(name: "Originally Ordered Var_ Code", maxLength: 10, nullable: false),
                    OutofStockSubstitution = table.Column<byte>(name: "Out-of-Stock Substitution", nullable: false),
                    ItemCategoryCode = table.Column<string>(name: "Item Category Code", maxLength: 20, nullable: false),
                    Nonstock = table.Column<byte>(nullable: false),
                    PurchasingCode = table.Column<string>(name: "Purchasing Code", maxLength: 10, nullable: false),
                    ProductGroupCode = table.Column<string>(name: "Product Group Code", maxLength: 10, nullable: false),
                    CompletelyInvoiced = table.Column<byte>(name: "Completely Invoiced", nullable: false),
                    LastInvoiceDate = table.Column<DateTime>(name: "Last Invoice Date", type: "datetime", nullable: false),
                    AppliedEntrytoAdjust = table.Column<byte>(name: "Applied Entry to Adjust", nullable: false),
                    Correction = table.Column<byte>(nullable: false),
                    ShippedQty_NotReturned = table.Column<decimal>(name: "Shipped Qty_ Not Returned", type: "decimal(38, 20)", nullable: false),
                    Prod_OrderComp_LineNo_ = table.Column<int>(name: "Prod_ Order Comp_ Line No_", nullable: false),
                    SerialNo_ = table.Column<string>(name: "Serial No_", maxLength: 20, nullable: false),
                    LotNo_ = table.Column<string>(name: "Lot No_", maxLength: 20, nullable: false),
                    WarrantyDate = table.Column<DateTime>(name: "Warranty Date", type: "datetime", nullable: false),
                    ExpirationDate = table.Column<DateTime>(name: "Expiration Date", type: "datetime", nullable: false),
                    ItemTracking = table.Column<int>(name: "Item Tracking", nullable: false),
                    ReturnReasonCode = table.Column<string>(name: "Return Reason Code", maxLength: 10, nullable: false),
                    OfferNo_ = table.Column<string>(name: "Offer No_", maxLength: 20, nullable: false),
                    BatchNo_ = table.Column<string>(name: "Batch No_", maxLength: 10, nullable: false),
                    PromotionNo_ = table.Column<string>(name: "Promotion No_", maxLength: 20, nullable: false),
                    TransferType = table.Column<int>(name: "Transfer Type", nullable: false),
                    BITimestamp = table.Column<DateTime>(name: "BI Timestamp", type: "datetime", nullable: false),
                    StatementNo_ = table.Column<string>(name: "Statement No_", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item Ledger Entry", x => x.EntryNo_);
                });

            migrationBuilder.CreateTable(
                name: "Item Measurement",
                columns: table => new
                {
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    GrossWeight = table.Column<decimal>(name: "Gross Weight", type: "decimal(38, 20)", nullable: false),
                    NetWeight = table.Column<decimal>(name: "Net Weight", type: "decimal(38, 20)", nullable: false),
                    UnitsperParcel = table.Column<decimal>(name: "Units per Parcel", type: "decimal(38, 20)", nullable: false),
                    UnitVolume = table.Column<decimal>(name: "Unit Volume", type: "decimal(38, 20)", nullable: false),
                    Depth = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    Width = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    Height = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: true),
                    Qty_perUnitofMeasure = table.Column<decimal>(name: "Qty_ per Unit of Measure", type: "decimal(38, 20)", nullable: true),
                    Length = table.Column<decimal>(type: "decimal(38, 20)", nullable: true),
                    Cubage = table.Column<decimal>(type: "decimal(38, 20)", nullable: true),
                    Weight = table.Column<decimal>(type: "decimal(38, 20)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item Measurement", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Item Picture",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: true),
                    WebsiteNo_ = table.Column<string>(name: "Website No_", maxLength: 20, nullable: true),
                    ItemNo_ = table.Column<string>(name: "Item No_", maxLength: 20, nullable: false),
                    Picture = table.Column<byte[]>(type: "image", nullable: false),
                    ID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item Picture", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Item Prices",
                columns: table => new
                {
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: true),
                    UnitPrice = table.Column<decimal>(name: "Unit Price", type: "decimal(38, 20)", nullable: false),
                    EndDateSales = table.Column<DateTime>(name: "End Date Sales", type: "datetime", nullable: true),
                    SalesStartDate = table.Column<DateTime>(name: "Sales Start Date", type: "datetime", nullable: true),
                    UnitPriceIncludingVAT = table.Column<decimal>(name: "Unit Price Including VAT", type: "decimal(38, 20)", nullable: true),
                    MaxDiscountAllowed = table.Column<decimal>(name: "Max. Discount Allowed", type: "decimal(18, 0)", nullable: true),
                    DiscountPerc = table.Column<decimal>(name: "Discount Perc.", type: "decimal(18, 0)", nullable: true),
                    SpecialPrice = table.Column<decimal>(name: "Special Price", type: "decimal(18, 0)", nullable: true),
                    MinQtyforSpecialPrice = table.Column<decimal>(name: "Min. Qty. for Special Price", type: "decimal(18, 0)", nullable: true),
                    VATPerc = table.Column<decimal>(name: "VAT Perc.", type: "decimal(18, 0)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item Prices", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Item Promotions",
                columns: table => new
                {
                    ItemNo_ = table.Column<string>(name: "Item No_", maxLength: 20, nullable: false),
                    StoreNo_ = table.Column<string>(name: "Store No_", maxLength: 10, nullable: false),
                    StartDate = table.Column<DateTime>(name: "Start Date", type: "datetime", nullable: false),
                    EndDate = table.Column<DateTime>(name: "End Date", type: "datetime", nullable: false),
                    PromotionQty_ = table.Column<decimal>(name: "Promotion (Qty_)", type: "decimal(38, 20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item Promotions", x => new { x.ItemNo_, x.StoreNo_, x.StartDate });
                });

            migrationBuilder.CreateTable(
                name: "Item Stock Levels",
                columns: table => new
                {
                    ItemNo_ = table.Column<string>(name: "Item No_", maxLength: 50, nullable: false),
                    SellableStock = table.Column<decimal>(name: "Sellable Stock", type: "decimal(18, 0)", nullable: false),
                    StockonSalesOrder = table.Column<decimal>(name: "Stock on Sales Order", type: "decimal(18, 0)", nullable: true),
                    StockinPicking = table.Column<decimal>(name: "Stock in Picking", type: "decimal(18, 0)", nullable: true),
                    ExpectedStock = table.Column<decimal>(name: "Expected Stock", type: "decimal(18, 0)", nullable: true),
                    ExpectedReceiptDate = table.Column<DateTime>(name: "Expected Receipt Date", type: "date", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item Stock Levels", x => x.ItemNo_);
                });

            migrationBuilder.CreateTable(
                name: "Item Vendor",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    VendorNo_ = table.Column<string>(name: "Vendor No_", maxLength: 20, nullable: false),
                    ItemNo_ = table.Column<string>(name: "Item No_", maxLength: 20, nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    LeadTimeCalculation = table.Column<string>(name: "Lead Time Calculation", unicode: false, maxLength: 32, nullable: false),
                    VendorItemNo_ = table.Column<string>(name: "Vendor Item No_", maxLength: 20, nullable: false),
                    PriceType = table.Column<int>(name: "Price Type", nullable: false),
                    FinancialYear = table.Column<int>(name: "Financial Year", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Item Vendor", x => new { x.VendorNo_, x.ItemNo_, x.VariantCode });
                });

            migrationBuilder.CreateTable(
                name: "Payable Vendor Ledger Entry",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    VendorNo_ = table.Column<string>(name: "Vendor No_", maxLength: 20, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    Positive = table.Column<byte>(nullable: false),
                    Future = table.Column<byte>(nullable: false),
                    EntryNo_ = table.Column<int>(name: "Entry No_", nullable: false),
                    VendorLedg_EntryNo_ = table.Column<int>(name: "Vendor Ledg_ Entry No_", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    AmountLCY = table.Column<decimal>(name: "Amount (LCY)", type: "decimal(38, 20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Payable Vendor Ledger Entry", x => new { x.Priority, x.VendorNo_, x.CurrencyCode, x.Positive, x.Future, x.EntryNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Return Policy",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    StoreNo_ = table.Column<string>(name: "Store No_", maxLength: 10, nullable: false),
                    StoreGroupCode = table.Column<string>(name: "Store Group Code", maxLength: 10, nullable: false),
                    ItemCategoryCode = table.Column<string>(name: "Item Category Code", maxLength: 10, nullable: false),
                    ProductGroupCode = table.Column<string>(name: "Product Group Code", maxLength: 10, nullable: false),
                    ItemNo_ = table.Column<string>(name: "Item No_", maxLength: 20, nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    VariantDimension1Code = table.Column<string>(name: "Variant Dimension 1 Code", maxLength: 30, nullable: false),
                    RefundnotAllowed = table.Column<byte>(name: "Refund not Allowed", nullable: false),
                    ManagerPrivileges = table.Column<byte>(name: "Manager Privileges", nullable: false),
                    RefundPeriodLength = table.Column<string>(name: "Refund Period Length", unicode: false, maxLength: 32, nullable: false),
                    Message1 = table.Column<string>(name: "Message 1", maxLength: 30, nullable: false),
                    Message2 = table.Column<string>(name: "Message 2", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Return Policy", x => new { x.StoreNo_, x.StoreGroupCode, x.ItemCategoryCode, x.ProductGroupCode, x.ItemNo_, x.VariantCode, x.VariantDimension1Code });
                });

            migrationBuilder.CreateTable(
                name: "Return Reason",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    DefaultLocationCode = table.Column<string>(name: "Default Location Code", maxLength: 10, nullable: false),
                    InventoryValueZero = table.Column<byte>(name: "Inventory Value Zero", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Return Reason", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Return Receipt Header",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    SelltoCustomerNo_ = table.Column<string>(name: "Sell-to Customer No_", maxLength: 20, nullable: false),
                    BilltoCustomerNo_ = table.Column<string>(name: "Bill-to Customer No_", maxLength: 20, nullable: false),
                    BilltoName = table.Column<string>(name: "Bill-to Name", maxLength: 50, nullable: false),
                    BilltoName2 = table.Column<string>(name: "Bill-to Name 2", maxLength: 50, nullable: false),
                    BilltoAddress = table.Column<string>(name: "Bill-to Address", maxLength: 50, nullable: false),
                    BilltoAddress2 = table.Column<string>(name: "Bill-to Address 2", maxLength: 50, nullable: false),
                    BilltoCity = table.Column<string>(name: "Bill-to City", maxLength: 30, nullable: false),
                    BilltoContact = table.Column<string>(name: "Bill-to Contact", maxLength: 50, nullable: false),
                    YourReference = table.Column<string>(name: "Your Reference", maxLength: 35, nullable: false),
                    ShiptoCode = table.Column<string>(name: "Ship-to Code", maxLength: 10, nullable: false),
                    ShiptoName = table.Column<string>(name: "Ship-to Name", maxLength: 50, nullable: false),
                    ShiptoName2 = table.Column<string>(name: "Ship-to Name 2", maxLength: 50, nullable: false),
                    ShiptoAddress = table.Column<string>(name: "Ship-to Address", maxLength: 50, nullable: false),
                    ShiptoAddress2 = table.Column<string>(name: "Ship-to Address 2", maxLength: 50, nullable: false),
                    ShiptoCity = table.Column<string>(name: "Ship-to City", maxLength: 30, nullable: false),
                    ShiptoContact = table.Column<string>(name: "Ship-to Contact", maxLength: 50, nullable: false),
                    OrderDate = table.Column<DateTime>(name: "Order Date", type: "datetime", nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    ShipmentDate = table.Column<DateTime>(name: "Shipment Date", type: "datetime", nullable: false),
                    PostingDescription = table.Column<string>(name: "Posting Description", maxLength: 50, nullable: false),
                    PaymentTermsCode = table.Column<string>(name: "Payment Terms Code", maxLength: 10, nullable: false),
                    DueDate = table.Column<DateTime>(name: "Due Date", type: "datetime", nullable: false),
                    PaymentDiscount_ = table.Column<decimal>(name: "Payment Discount _", type: "decimal(38, 20)", nullable: false),
                    Pmt_DiscountDate = table.Column<DateTime>(name: "Pmt_ Discount Date", type: "datetime", nullable: false),
                    ShipmentMethodCode = table.Column<string>(name: "Shipment Method Code", maxLength: 10, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    CustomerPostingGroup = table.Column<string>(name: "Customer Posting Group", maxLength: 20, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    CurrencyFactor = table.Column<decimal>(name: "Currency Factor", type: "decimal(38, 20)", nullable: false),
                    CustomerPriceGroup = table.Column<string>(name: "Customer Price Group", maxLength: 10, nullable: false),
                    PricesIncludingVAT = table.Column<byte>(name: "Prices Including VAT", nullable: false),
                    InvoiceDisc_Code = table.Column<string>(name: "Invoice Disc_ Code", maxLength: 20, nullable: false),
                    CustomerDisc_Group = table.Column<string>(name: "Customer Disc_ Group", maxLength: 20, nullable: false),
                    LanguageCode = table.Column<string>(name: "Language Code", maxLength: 10, nullable: false),
                    SalespersonCode = table.Column<string>(name: "Salesperson Code", maxLength: 20, nullable: false),
                    No_Printed = table.Column<int>(name: "No_ Printed", nullable: false),
                    OnHold = table.Column<string>(name: "On Hold", maxLength: 3, nullable: false),
                    AppliestoDoc_Type = table.Column<int>(name: "Applies-to Doc_ Type", nullable: false),
                    AppliestoDoc_No_ = table.Column<string>(name: "Applies-to Doc_ No_", maxLength: 20, nullable: false),
                    Bal_AccountNo_ = table.Column<string>(name: "Bal_ Account No_", maxLength: 20, nullable: false),
                    VATRegistrationNo_ = table.Column<string>(name: "VAT Registration No_", maxLength: 20, nullable: false),
                    ReasonCode = table.Column<string>(name: "Reason Code", maxLength: 10, nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    EU3PartyTrade = table.Column<byte>(name: "EU 3-Party Trade", nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", maxLength: 10, nullable: false),
                    TransportMethod = table.Column<string>(name: "Transport Method", maxLength: 10, nullable: false),
                    VATCountry_RegionCode = table.Column<string>(name: "VAT Country_Region Code", maxLength: 10, nullable: false),
                    SelltoCustomerName = table.Column<string>(name: "Sell-to Customer Name", maxLength: 50, nullable: false),
                    SelltoCustomerName2 = table.Column<string>(name: "Sell-to Customer Name 2", maxLength: 50, nullable: false),
                    SelltoAddress = table.Column<string>(name: "Sell-to Address", maxLength: 50, nullable: false),
                    SelltoAddress2 = table.Column<string>(name: "Sell-to Address 2", maxLength: 50, nullable: false),
                    SelltoCity = table.Column<string>(name: "Sell-to City", maxLength: 30, nullable: false),
                    SelltoContact = table.Column<string>(name: "Sell-to Contact", maxLength: 50, nullable: false),
                    BilltoPostCode = table.Column<string>(name: "Bill-to Post Code", maxLength: 20, nullable: false),
                    BilltoCounty = table.Column<string>(name: "Bill-to County", maxLength: 30, nullable: false),
                    BilltoCountry_RegionCode = table.Column<string>(name: "Bill-to Country_Region Code", maxLength: 10, nullable: false),
                    SelltoPostCode = table.Column<string>(name: "Sell-to Post Code", maxLength: 20, nullable: false),
                    SelltoCounty = table.Column<string>(name: "Sell-to County", maxLength: 30, nullable: false),
                    SelltoCountry_RegionCode = table.Column<string>(name: "Sell-to Country_Region Code", maxLength: 10, nullable: false),
                    ShiptoPostCode = table.Column<string>(name: "Ship-to Post Code", maxLength: 20, nullable: false),
                    ShiptoCounty = table.Column<string>(name: "Ship-to County", maxLength: 30, nullable: false),
                    ShiptoCountry_RegionCode = table.Column<string>(name: "Ship-to Country_Region Code", maxLength: 10, nullable: false),
                    Bal_AccountType = table.Column<int>(name: "Bal_ Account Type", nullable: false),
                    ExitPoint = table.Column<string>(name: "Exit Point", maxLength: 10, nullable: false),
                    Correction = table.Column<byte>(nullable: false),
                    DocumentDate = table.Column<DateTime>(name: "Document Date", type: "datetime", nullable: false),
                    ExternalDocumentNo_ = table.Column<string>(name: "External Document No_", maxLength: 35, nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: false),
                    TransactionSpecification = table.Column<string>(name: "Transaction Specification", maxLength: 10, nullable: false),
                    PaymentMethodCode = table.Column<string>(name: "Payment Method Code", maxLength: 10, nullable: false),
                    ShippingAgentCode = table.Column<string>(name: "Shipping Agent Code", maxLength: 10, nullable: false),
                    PackageTrackingNo_ = table.Column<string>(name: "Package Tracking No_", maxLength: 30, nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    UserID = table.Column<string>(name: "User ID", maxLength: 50, nullable: false),
                    SourceCode = table.Column<string>(name: "Source Code", maxLength: 10, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    VATBaseDiscount_ = table.Column<decimal>(name: "VAT Base Discount _", type: "decimal(38, 20)", nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    CampaignNo_ = table.Column<string>(name: "Campaign No_", maxLength: 20, nullable: false),
                    SelltoContactNo_ = table.Column<string>(name: "Sell-to Contact No_", maxLength: 20, nullable: false),
                    BilltoContactNo_ = table.Column<string>(name: "Bill-to Contact No_", maxLength: 20, nullable: false),
                    OpportunityNo_ = table.Column<string>(name: "Opportunity No_", maxLength: 20, nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    RequestedDeliveryDate = table.Column<DateTime>(name: "Requested Delivery Date", type: "datetime", nullable: false),
                    PromisedDeliveryDate = table.Column<DateTime>(name: "Promised Delivery Date", type: "datetime", nullable: false),
                    ShippingTime = table.Column<string>(name: "Shipping Time", unicode: false, maxLength: 32, nullable: false),
                    WarehouseHandlingTime = table.Column<string>(name: "Warehouse Handling Time", unicode: false, maxLength: 32, nullable: false),
                    LateOrderShipping = table.Column<byte>(name: "Late Order Shipping", nullable: false),
                    ReturnOrderNo_ = table.Column<string>(name: "Return Order No_", maxLength: 20, nullable: false),
                    ReturnOrderNo_Series = table.Column<string>(name: "Return Order No_ Series", maxLength: 20, nullable: false),
                    AllowLineDisc_ = table.Column<byte>(name: "Allow Line Disc_", nullable: false),
                    StoreNo_ = table.Column<string>(name: "Store No_", maxLength: 10, nullable: false),
                    RetailStatus = table.Column<int>(name: "Retail Status", nullable: false),
                    Reciving_PickingNo_ = table.Column<string>(name: "Reciving_Picking No_", maxLength: 20, nullable: false),
                    MemberCardNo_ = table.Column<string>(name: "Member Card No_", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Return Receipt Header", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Return Receipt Line",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DocumentNo_ = table.Column<string>(name: "Document No_", maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    SelltoCustomerNo_ = table.Column<string>(name: "Sell-to Customer No_", maxLength: 20, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    PostingGroup = table.Column<string>(name: "Posting Group", maxLength: 20, nullable: false),
                    ShipmentDate = table.Column<DateTime>(name: "Shipment Date", type: "datetime", nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Description2 = table.Column<string>(name: "Description 2", maxLength: 50, nullable: false),
                    UnitofMeasure = table.Column<string>(name: "Unit of Measure", maxLength: 10, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    UnitPrice = table.Column<decimal>(name: "Unit Price", type: "decimal(38, 20)", nullable: false),
                    UnitCostLCY = table.Column<decimal>(name: "Unit Cost (LCY)", type: "decimal(38, 20)", nullable: false),
                    VAT_ = table.Column<decimal>(name: "VAT _", type: "decimal(38, 20)", nullable: false),
                    LineDiscount_ = table.Column<decimal>(name: "Line Discount _", type: "decimal(38, 20)", nullable: false),
                    AllowInvoiceDisc_ = table.Column<byte>(name: "Allow Invoice Disc_", nullable: false),
                    GrossWeight = table.Column<decimal>(name: "Gross Weight", type: "decimal(38, 20)", nullable: false),
                    NetWeight = table.Column<decimal>(name: "Net Weight", type: "decimal(38, 20)", nullable: false),
                    UnitsperParcel = table.Column<decimal>(name: "Units per Parcel", type: "decimal(38, 20)", nullable: false),
                    UnitVolume = table.Column<decimal>(name: "Unit Volume", type: "decimal(38, 20)", nullable: false),
                    Appl_toItemEntry = table.Column<int>(name: "Appl_-to Item Entry", nullable: false),
                    ItemRcpt_EntryNo_ = table.Column<int>(name: "Item Rcpt_ Entry No_", nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    CustomerPriceGroup = table.Column<string>(name: "Customer Price Group", maxLength: 10, nullable: false),
                    JobNo_ = table.Column<string>(name: "Job No_", maxLength: 20, nullable: false),
                    WorkTypeCode = table.Column<string>(name: "Work Type Code", maxLength: 10, nullable: false),
                    QuantityInvoiced = table.Column<decimal>(name: "Quantity Invoiced", type: "decimal(38, 20)", nullable: false),
                    BilltoCustomerNo_ = table.Column<string>(name: "Bill-to Customer No_", maxLength: 20, nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    Gen_Prod_PostingGroup = table.Column<string>(name: "Gen_ Prod_ Posting Group", maxLength: 20, nullable: false),
                    VATCalculationType = table.Column<int>(name: "VAT Calculation Type", nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", maxLength: 10, nullable: false),
                    TransportMethod = table.Column<string>(name: "Transport Method", maxLength: 10, nullable: false),
                    AttachedtoLineNo_ = table.Column<int>(name: "Attached to Line No_", nullable: false),
                    ExitPoint = table.Column<string>(name: "Exit Point", maxLength: 10, nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: false),
                    TransactionSpecification = table.Column<string>(name: "Transaction Specification", maxLength: 10, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    TaxGroupCode = table.Column<string>(name: "Tax Group Code", maxLength: 20, nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    VATProd_PostingGroup = table.Column<string>(name: "VAT Prod_ Posting Group", maxLength: 20, nullable: false),
                    BlanketOrderNo_ = table.Column<string>(name: "Blanket Order No_", maxLength: 20, nullable: false),
                    BlanketOrderLineNo_ = table.Column<int>(name: "Blanket Order Line No_", nullable: false),
                    VATBaseAmount = table.Column<decimal>(name: "VAT Base Amount", type: "decimal(38, 20)", nullable: false),
                    UnitCost = table.Column<decimal>(name: "Unit Cost", type: "decimal(38, 20)", nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    BinCode = table.Column<string>(name: "Bin Code", maxLength: 20, nullable: false),
                    Qty_perUnitofMeasure = table.Column<decimal>(name: "Qty_ per Unit of Measure", type: "decimal(38, 20)", nullable: false),
                    UnitofMeasureCode = table.Column<string>(name: "Unit of Measure Code", maxLength: 10, nullable: false),
                    QuantityBase = table.Column<decimal>(name: "Quantity (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_InvoicedBase = table.Column<decimal>(name: "Qty_ Invoiced (Base)", type: "decimal(38, 20)", nullable: false),
                    FAPostingDate = table.Column<DateTime>(name: "FA Posting Date", type: "datetime", nullable: false),
                    DepreciationBookCode = table.Column<string>(name: "Depreciation Book Code", maxLength: 10, nullable: false),
                    Depr_untilFAPostingDate = table.Column<byte>(name: "Depr_ until FA Posting Date", nullable: false),
                    DuplicateinDepreciationBook = table.Column<string>(name: "Duplicate in Depreciation Book", maxLength: 10, nullable: false),
                    UseDuplicationList = table.Column<byte>(name: "Use Duplication List", nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    CrossReferenceNo_ = table.Column<string>(name: "Cross-Reference No_", maxLength: 20, nullable: false),
                    UnitofMeasureCrossRef_ = table.Column<string>(name: "Unit of Measure (Cross Ref_)", maxLength: 10, nullable: false),
                    CrossReferenceType = table.Column<int>(name: "Cross-Reference Type", nullable: false),
                    CrossReferenceTypeNo_ = table.Column<string>(name: "Cross-Reference Type No_", maxLength: 30, nullable: false),
                    ItemCategoryCode = table.Column<string>(name: "Item Category Code", maxLength: 20, nullable: false),
                    Nonstock = table.Column<byte>(nullable: false),
                    PurchasingCode = table.Column<string>(name: "Purchasing Code", maxLength: 10, nullable: false),
                    ProductGroupCode = table.Column<string>(name: "Product Group Code", maxLength: 10, nullable: false),
                    ReturnQty_Rcd_NotInvd_ = table.Column<decimal>(name: "Return Qty_ Rcd_ Not Invd_", type: "decimal(38, 20)", nullable: false),
                    Appl_fromItemEntry = table.Column<int>(name: "Appl_-from Item Entry", nullable: false),
                    ItemChargeBaseAmount = table.Column<decimal>(name: "Item Charge Base Amount", type: "decimal(38, 20)", nullable: false),
                    Correction = table.Column<byte>(nullable: false),
                    ReturnOrderNo_ = table.Column<string>(name: "Return Order No_", maxLength: 20, nullable: false),
                    ReturnOrderLineNo_ = table.Column<int>(name: "Return Order Line No_", nullable: false),
                    ReturnReasonCode = table.Column<string>(name: "Return Reason Code", maxLength: 10, nullable: false),
                    AllowLineDisc_ = table.Column<byte>(name: "Allow Line Disc_", nullable: false),
                    CustomerDisc_Group = table.Column<string>(name: "Customer Disc_ Group", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Return Receipt Line", x => new { x.DocumentNo_, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Return Shipment Header",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    BuyfromVendorNo_ = table.Column<string>(name: "Buy-from Vendor No_", maxLength: 20, nullable: false),
                    PaytoVendorNo_ = table.Column<string>(name: "Pay-to Vendor No_", maxLength: 20, nullable: false),
                    PaytoName = table.Column<string>(name: "Pay-to Name", maxLength: 50, nullable: false),
                    PaytoName2 = table.Column<string>(name: "Pay-to Name 2", maxLength: 50, nullable: false),
                    PaytoAddress = table.Column<string>(name: "Pay-to Address", maxLength: 50, nullable: false),
                    PaytoAddress2 = table.Column<string>(name: "Pay-to Address 2", maxLength: 50, nullable: false),
                    PaytoCity = table.Column<string>(name: "Pay-to City", maxLength: 30, nullable: false),
                    PaytoContact = table.Column<string>(name: "Pay-to Contact", maxLength: 50, nullable: false),
                    YourReference = table.Column<string>(name: "Your Reference", maxLength: 35, nullable: false),
                    ShiptoCode = table.Column<string>(name: "Ship-to Code", maxLength: 10, nullable: false),
                    ShiptoName = table.Column<string>(name: "Ship-to Name", maxLength: 50, nullable: false),
                    ShiptoName2 = table.Column<string>(name: "Ship-to Name 2", maxLength: 50, nullable: false),
                    ShiptoAddress = table.Column<string>(name: "Ship-to Address", maxLength: 50, nullable: false),
                    ShiptoAddress2 = table.Column<string>(name: "Ship-to Address 2", maxLength: 50, nullable: false),
                    ShiptoCity = table.Column<string>(name: "Ship-to City", maxLength: 30, nullable: false),
                    ShiptoContact = table.Column<string>(name: "Ship-to Contact", maxLength: 50, nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    ExpectedReceiptDate = table.Column<DateTime>(name: "Expected Receipt Date", type: "datetime", nullable: false),
                    PostingDescription = table.Column<string>(name: "Posting Description", maxLength: 50, nullable: false),
                    PaymentTermsCode = table.Column<string>(name: "Payment Terms Code", maxLength: 10, nullable: false),
                    DueDate = table.Column<DateTime>(name: "Due Date", type: "datetime", nullable: false),
                    PaymentDiscount_ = table.Column<decimal>(name: "Payment Discount _", type: "decimal(38, 20)", nullable: false),
                    Pmt_DiscountDate = table.Column<DateTime>(name: "Pmt_ Discount Date", type: "datetime", nullable: false),
                    ShipmentMethodCode = table.Column<string>(name: "Shipment Method Code", maxLength: 10, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    VendorPostingGroup = table.Column<string>(name: "Vendor Posting Group", maxLength: 20, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    CurrencyFactor = table.Column<decimal>(name: "Currency Factor", type: "decimal(38, 20)", nullable: false),
                    InvoiceDisc_Code = table.Column<string>(name: "Invoice Disc_ Code", maxLength: 20, nullable: false),
                    LanguageCode = table.Column<string>(name: "Language Code", maxLength: 10, nullable: false),
                    PurchaserCode = table.Column<string>(name: "Purchaser Code", maxLength: 20, nullable: false),
                    No_Printed = table.Column<int>(name: "No_ Printed", nullable: false),
                    OnHold = table.Column<string>(name: "On Hold", maxLength: 3, nullable: false),
                    AppliestoDoc_Type = table.Column<int>(name: "Applies-to Doc_ Type", nullable: false),
                    AppliestoDoc_No_ = table.Column<string>(name: "Applies-to Doc_ No_", maxLength: 20, nullable: false),
                    Bal_AccountNo_ = table.Column<string>(name: "Bal_ Account No_", maxLength: 20, nullable: false),
                    VATRegistrationNo_ = table.Column<string>(name: "VAT Registration No_", maxLength: 20, nullable: false),
                    SelltoCustomerNo_ = table.Column<string>(name: "Sell-to Customer No_", maxLength: 20, nullable: false),
                    ReasonCode = table.Column<string>(name: "Reason Code", maxLength: 10, nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", maxLength: 10, nullable: false),
                    TransportMethod = table.Column<string>(name: "Transport Method", maxLength: 10, nullable: false),
                    VATCountry_RegionCode = table.Column<string>(name: "VAT Country_Region Code", maxLength: 10, nullable: false),
                    BuyfromVendorName = table.Column<string>(name: "Buy-from Vendor Name", maxLength: 50, nullable: false),
                    BuyfromVendorName2 = table.Column<string>(name: "Buy-from Vendor Name 2", maxLength: 50, nullable: false),
                    BuyfromAddress = table.Column<string>(name: "Buy-from Address", maxLength: 50, nullable: false),
                    BuyfromAddress2 = table.Column<string>(name: "Buy-from Address 2", maxLength: 50, nullable: false),
                    BuyfromCity = table.Column<string>(name: "Buy-from City", maxLength: 30, nullable: false),
                    BuyfromContact = table.Column<string>(name: "Buy-from Contact", maxLength: 50, nullable: false),
                    PaytoPostCode = table.Column<string>(name: "Pay-to Post Code", maxLength: 20, nullable: false),
                    PaytoCounty = table.Column<string>(name: "Pay-to County", maxLength: 30, nullable: false),
                    PaytoCountry_RegionCode = table.Column<string>(name: "Pay-to Country_Region Code", maxLength: 10, nullable: false),
                    BuyfromPostCode = table.Column<string>(name: "Buy-from Post Code", maxLength: 20, nullable: false),
                    BuyfromCounty = table.Column<string>(name: "Buy-from County", maxLength: 30, nullable: false),
                    BuyfromCountry_RegionCode = table.Column<string>(name: "Buy-from Country_Region Code", maxLength: 10, nullable: false),
                    ShiptoPostCode = table.Column<string>(name: "Ship-to Post Code", maxLength: 20, nullable: false),
                    ShiptoCounty = table.Column<string>(name: "Ship-to County", maxLength: 30, nullable: false),
                    ShiptoCountry_RegionCode = table.Column<string>(name: "Ship-to Country_Region Code", maxLength: 10, nullable: false),
                    Bal_AccountType = table.Column<int>(name: "Bal_ Account Type", nullable: false),
                    OrderAddressCode = table.Column<string>(name: "Order Address Code", maxLength: 10, nullable: false),
                    EntryPoint = table.Column<string>(name: "Entry Point", maxLength: 10, nullable: false),
                    Correction = table.Column<byte>(nullable: false),
                    DocumentDate = table.Column<DateTime>(name: "Document Date", type: "datetime", nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: false),
                    TransactionSpecification = table.Column<string>(name: "Transaction Specification", maxLength: 10, nullable: false),
                    PaymentMethodCode = table.Column<string>(name: "Payment Method Code", maxLength: 10, nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    UserID = table.Column<string>(name: "User ID", maxLength: 50, nullable: false),
                    SourceCode = table.Column<string>(name: "Source Code", maxLength: 10, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    VATBaseDiscount_ = table.Column<decimal>(name: "VAT Base Discount _", type: "decimal(38, 20)", nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    CampaignNo_ = table.Column<string>(name: "Campaign No_", maxLength: 20, nullable: false),
                    BuyfromContactNo_ = table.Column<string>(name: "Buy-from Contact No_", maxLength: 20, nullable: false),
                    PaytoContactNo_ = table.Column<string>(name: "Pay-to Contact No_", maxLength: 20, nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    VendorAuthorizationNo_ = table.Column<string>(name: "Vendor Authorization No_", maxLength: 35, nullable: false),
                    ReturnOrderNo_ = table.Column<string>(name: "Return Order No_", maxLength: 20, nullable: false),
                    ReturnOrderNo_Series = table.Column<string>(name: "Return Order No_ Series", maxLength: 20, nullable: false),
                    StoreNo_ = table.Column<string>(name: "Store No_", maxLength: 10, nullable: false),
                    RetailStatus = table.Column<int>(name: "Retail Status", nullable: false),
                    Reciving_PickingNo_ = table.Column<string>(name: "Reciving_Picking No_", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Return Shipment Header", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Return Shipment Line",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DocumentNo_ = table.Column<string>(name: "Document No_", maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    BuyfromVendorNo_ = table.Column<string>(name: "Buy-from Vendor No_", maxLength: 20, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    PostingGroup = table.Column<string>(name: "Posting Group", maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Description2 = table.Column<string>(name: "Description 2", maxLength: 50, nullable: false),
                    UnitofMeasure = table.Column<string>(name: "Unit of Measure", maxLength: 10, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    DirectUnitCost = table.Column<decimal>(name: "Direct Unit Cost", type: "decimal(38, 20)", nullable: false),
                    UnitCostLCY = table.Column<decimal>(name: "Unit Cost (LCY)", type: "decimal(38, 20)", nullable: false),
                    VAT_ = table.Column<decimal>(name: "VAT _", type: "decimal(38, 20)", nullable: false),
                    LineDiscount_ = table.Column<decimal>(name: "Line Discount _", type: "decimal(38, 20)", nullable: false),
                    UnitPriceLCY = table.Column<decimal>(name: "Unit Price (LCY)", type: "decimal(38, 20)", nullable: false),
                    AllowInvoiceDisc_ = table.Column<byte>(name: "Allow Invoice Disc_", nullable: false),
                    GrossWeight = table.Column<decimal>(name: "Gross Weight", type: "decimal(38, 20)", nullable: false),
                    NetWeight = table.Column<decimal>(name: "Net Weight", type: "decimal(38, 20)", nullable: false),
                    UnitsperParcel = table.Column<decimal>(name: "Units per Parcel", type: "decimal(38, 20)", nullable: false),
                    UnitVolume = table.Column<decimal>(name: "Unit Volume", type: "decimal(38, 20)", nullable: false),
                    Appl_toItemEntry = table.Column<int>(name: "Appl_-to Item Entry", nullable: false),
                    ItemShpt_EntryNo_ = table.Column<int>(name: "Item Shpt_ Entry No_", nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    JobNo_ = table.Column<string>(name: "Job No_", maxLength: 20, nullable: false),
                    IndirectCost_ = table.Column<decimal>(name: "Indirect Cost _", type: "decimal(38, 20)", nullable: false),
                    QuantityInvoiced = table.Column<decimal>(name: "Quantity Invoiced", type: "decimal(38, 20)", nullable: false),
                    PaytoVendorNo_ = table.Column<string>(name: "Pay-to Vendor No_", maxLength: 20, nullable: false),
                    VendorItemNo_ = table.Column<string>(name: "Vendor Item No_", maxLength: 20, nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    Gen_Prod_PostingGroup = table.Column<string>(name: "Gen_ Prod_ Posting Group", maxLength: 20, nullable: false),
                    VATCalculationType = table.Column<int>(name: "VAT Calculation Type", nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", maxLength: 10, nullable: false),
                    TransportMethod = table.Column<string>(name: "Transport Method", maxLength: 10, nullable: false),
                    AttachedtoLineNo_ = table.Column<int>(name: "Attached to Line No_", nullable: false),
                    EntryPoint = table.Column<string>(name: "Entry Point", maxLength: 10, nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: false),
                    TransactionSpecification = table.Column<string>(name: "Transaction Specification", maxLength: 10, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    TaxGroupCode = table.Column<string>(name: "Tax Group Code", maxLength: 20, nullable: false),
                    UseTax = table.Column<byte>(name: "Use Tax", nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    VATProd_PostingGroup = table.Column<string>(name: "VAT Prod_ Posting Group", maxLength: 20, nullable: false),
                    BlanketOrderNo_ = table.Column<string>(name: "Blanket Order No_", maxLength: 20, nullable: false),
                    BlanketOrderLineNo_ = table.Column<int>(name: "Blanket Order Line No_", nullable: false),
                    VATBaseAmount = table.Column<decimal>(name: "VAT Base Amount", type: "decimal(38, 20)", nullable: false),
                    UnitCost = table.Column<decimal>(name: "Unit Cost", type: "decimal(38, 20)", nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    JobTaskNo_ = table.Column<string>(name: "Job Task No_", maxLength: 20, nullable: false),
                    Prod_OrderNo_ = table.Column<string>(name: "Prod_ Order No_", maxLength: 20, nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    BinCode = table.Column<string>(name: "Bin Code", maxLength: 20, nullable: false),
                    Qty_perUnitofMeasure = table.Column<decimal>(name: "Qty_ per Unit of Measure", type: "decimal(38, 20)", nullable: false),
                    UnitofMeasureCode = table.Column<string>(name: "Unit of Measure Code", maxLength: 10, nullable: false),
                    QuantityBase = table.Column<decimal>(name: "Quantity (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_InvoicedBase = table.Column<decimal>(name: "Qty_ Invoiced (Base)", type: "decimal(38, 20)", nullable: false),
                    FAPostingDate = table.Column<DateTime>(name: "FA Posting Date", type: "datetime", nullable: false),
                    FAPostingType = table.Column<int>(name: "FA Posting Type", nullable: false),
                    DepreciationBookCode = table.Column<string>(name: "Depreciation Book Code", maxLength: 10, nullable: false),
                    SalvageValue = table.Column<decimal>(name: "Salvage Value", type: "decimal(38, 20)", nullable: false),
                    Depr_untilFAPostingDate = table.Column<byte>(name: "Depr_ until FA Posting Date", nullable: false),
                    Depr_AcquisitionCost = table.Column<byte>(name: "Depr_ Acquisition Cost", nullable: false),
                    MaintenanceCode = table.Column<string>(name: "Maintenance Code", maxLength: 10, nullable: false),
                    InsuranceNo_ = table.Column<string>(name: "Insurance No_", maxLength: 20, nullable: false),
                    BudgetedFANo_ = table.Column<string>(name: "Budgeted FA No_", maxLength: 20, nullable: false),
                    DuplicateinDepreciationBook = table.Column<string>(name: "Duplicate in Depreciation Book", maxLength: 10, nullable: false),
                    UseDuplicationList = table.Column<byte>(name: "Use Duplication List", nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    CrossReferenceNo_ = table.Column<string>(name: "Cross-Reference No_", maxLength: 20, nullable: false),
                    UnitofMeasureCrossRef_ = table.Column<string>(name: "Unit of Measure (Cross Ref_)", maxLength: 10, nullable: false),
                    CrossReferenceType = table.Column<int>(name: "Cross-Reference Type", nullable: false),
                    CrossReferenceTypeNo_ = table.Column<string>(name: "Cross-Reference Type No_", maxLength: 30, nullable: false),
                    ItemCategoryCode = table.Column<string>(name: "Item Category Code", maxLength: 20, nullable: false),
                    Nonstock = table.Column<byte>(nullable: false),
                    PurchasingCode = table.Column<string>(name: "Purchasing Code", maxLength: 10, nullable: false),
                    ProductGroupCode = table.Column<string>(name: "Product Group Code", maxLength: 10, nullable: false),
                    ReturnQty_ShippedNotInvd_ = table.Column<decimal>(name: "Return Qty_ Shipped Not Invd_", type: "decimal(38, 20)", nullable: false),
                    ItemChargeBaseAmount = table.Column<decimal>(name: "Item Charge Base Amount", type: "decimal(38, 20)", nullable: false),
                    Correction = table.Column<byte>(nullable: false),
                    ReturnOrderNo_ = table.Column<string>(name: "Return Order No_", maxLength: 20, nullable: false),
                    ReturnOrderLineNo_ = table.Column<int>(name: "Return Order Line No_", nullable: false),
                    ReturnReasonCode = table.Column<string>(name: "Return Reason Code", maxLength: 10, nullable: false),
                    RetailLocationCode = table.Column<string>(name: "Retail Location Code", maxLength: 10, nullable: false),
                    RetailBinCode = table.Column<string>(name: "Retail Bin Code", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Return Shipment Line", x => new { x.DocumentNo_, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Returns-Related Document",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    EntryNo_ = table.Column<int>(name: "Entry No_", nullable: false),
                    DocumentType = table.Column<int>(name: "Document Type", nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Returns-Related Document", x => x.EntryNo_);
                });

            migrationBuilder.CreateTable(
                name: "Sales Header",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DocumentType = table.Column<int>(name: "Document Type", nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    SelltoCustomerNo_ = table.Column<string>(name: "Sell-to Customer No_", maxLength: 20, nullable: false),
                    BilltoCustomerNo_ = table.Column<string>(name: "Bill-to Customer No_", maxLength: 20, nullable: false),
                    BilltoName = table.Column<string>(name: "Bill-to Name", maxLength: 50, nullable: false),
                    BilltoName2 = table.Column<string>(name: "Bill-to Name 2", maxLength: 50, nullable: false),
                    BilltoAddress = table.Column<string>(name: "Bill-to Address", maxLength: 50, nullable: false),
                    BilltoAddress2 = table.Column<string>(name: "Bill-to Address 2", maxLength: 50, nullable: false),
                    BilltoCity = table.Column<string>(name: "Bill-to City", maxLength: 30, nullable: false),
                    BilltoContact = table.Column<string>(name: "Bill-to Contact", maxLength: 50, nullable: false),
                    YourReference = table.Column<string>(name: "Your Reference", maxLength: 35, nullable: false),
                    ShiptoCode = table.Column<string>(name: "Ship-to Code", maxLength: 10, nullable: false),
                    ShiptoName = table.Column<string>(name: "Ship-to Name", maxLength: 50, nullable: false),
                    ShiptoName2 = table.Column<string>(name: "Ship-to Name 2", maxLength: 50, nullable: false),
                    ShiptoAddress = table.Column<string>(name: "Ship-to Address", maxLength: 50, nullable: false),
                    ShiptoAddress2 = table.Column<string>(name: "Ship-to Address 2", maxLength: 50, nullable: false),
                    ShiptoCity = table.Column<string>(name: "Ship-to City", maxLength: 30, nullable: false),
                    ShiptoContact = table.Column<string>(name: "Ship-to Contact", maxLength: 50, nullable: false),
                    OrderDate = table.Column<DateTime>(name: "Order Date", type: "datetime", nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    ShipmentDate = table.Column<DateTime>(name: "Shipment Date", type: "datetime", nullable: false),
                    PostingDescription = table.Column<string>(name: "Posting Description", maxLength: 50, nullable: false),
                    PaymentTermsCode = table.Column<string>(name: "Payment Terms Code", maxLength: 10, nullable: false),
                    DueDate = table.Column<DateTime>(name: "Due Date", type: "datetime", nullable: false),
                    PaymentDiscount_ = table.Column<decimal>(name: "Payment Discount _", type: "decimal(38, 20)", nullable: false),
                    Pmt_DiscountDate = table.Column<DateTime>(name: "Pmt_ Discount Date", type: "datetime", nullable: false),
                    ShipmentMethodCode = table.Column<string>(name: "Shipment Method Code", maxLength: 10, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    CustomerPostingGroup = table.Column<string>(name: "Customer Posting Group", maxLength: 20, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    CurrencyFactor = table.Column<decimal>(name: "Currency Factor", type: "decimal(38, 20)", nullable: false),
                    CustomerPriceGroup = table.Column<string>(name: "Customer Price Group", maxLength: 10, nullable: false),
                    PricesIncludingVAT = table.Column<byte>(name: "Prices Including VAT", nullable: false),
                    InvoiceDisc_Code = table.Column<string>(name: "Invoice Disc_ Code", maxLength: 20, nullable: false),
                    CustomerDisc_Group = table.Column<string>(name: "Customer Disc_ Group", maxLength: 20, nullable: false),
                    LanguageCode = table.Column<string>(name: "Language Code", maxLength: 10, nullable: false),
                    SalespersonCode = table.Column<string>(name: "Salesperson Code", maxLength: 20, nullable: false),
                    OrderClass = table.Column<string>(name: "Order Class", maxLength: 10, nullable: false),
                    No_Printed = table.Column<int>(name: "No_ Printed", nullable: false),
                    OnHold = table.Column<string>(name: "On Hold", maxLength: 3, nullable: false),
                    AppliestoDoc_Type = table.Column<int>(name: "Applies-to Doc_ Type", nullable: false),
                    AppliestoDoc_No_ = table.Column<string>(name: "Applies-to Doc_ No_", maxLength: 20, nullable: false),
                    Bal_AccountNo_ = table.Column<string>(name: "Bal_ Account No_", maxLength: 20, nullable: false),
                    Ship = table.Column<byte>(nullable: false),
                    Invoice = table.Column<byte>(nullable: false),
                    PrintPostedDocuments = table.Column<byte>(name: "Print Posted Documents", nullable: false),
                    ShippingNo_ = table.Column<string>(name: "Shipping No_", maxLength: 20, nullable: false),
                    PostingNo_ = table.Column<string>(name: "Posting No_", maxLength: 20, nullable: false),
                    LastShippingNo_ = table.Column<string>(name: "Last Shipping No_", maxLength: 20, nullable: false),
                    LastPostingNo_ = table.Column<string>(name: "Last Posting No_", maxLength: 20, nullable: false),
                    PrepaymentNo_ = table.Column<string>(name: "Prepayment No_", maxLength: 20, nullable: false),
                    LastPrepaymentNo_ = table.Column<string>(name: "Last Prepayment No_", maxLength: 20, nullable: false),
                    Prepmt_Cr_MemoNo_ = table.Column<string>(name: "Prepmt_ Cr_ Memo No_", maxLength: 20, nullable: false),
                    LastPrepmt_Cr_MemoNo_ = table.Column<string>(name: "Last Prepmt_ Cr_ Memo No_", maxLength: 20, nullable: false),
                    VATRegistrationNo_ = table.Column<string>(name: "VAT Registration No_", maxLength: 20, nullable: false),
                    CombineShipments = table.Column<byte>(name: "Combine Shipments", nullable: false),
                    ReasonCode = table.Column<string>(name: "Reason Code", maxLength: 10, nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    EU3PartyTrade = table.Column<byte>(name: "EU 3-Party Trade", nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", maxLength: 10, nullable: false),
                    TransportMethod = table.Column<string>(name: "Transport Method", maxLength: 10, nullable: false),
                    VATCountry_RegionCode = table.Column<string>(name: "VAT Country_Region Code", maxLength: 10, nullable: false),
                    SelltoCustomerName = table.Column<string>(name: "Sell-to Customer Name", maxLength: 50, nullable: false),
                    SelltoCustomerName2 = table.Column<string>(name: "Sell-to Customer Name 2", maxLength: 50, nullable: false),
                    SelltoAddress = table.Column<string>(name: "Sell-to Address", maxLength: 50, nullable: false),
                    SelltoAddress2 = table.Column<string>(name: "Sell-to Address 2", maxLength: 50, nullable: false),
                    SelltoCity = table.Column<string>(name: "Sell-to City", maxLength: 30, nullable: false),
                    SelltoContact = table.Column<string>(name: "Sell-to Contact", maxLength: 50, nullable: false),
                    BilltoPostCode = table.Column<string>(name: "Bill-to Post Code", maxLength: 20, nullable: false),
                    BilltoCounty = table.Column<string>(name: "Bill-to County", maxLength: 30, nullable: false),
                    BilltoCountry_RegionCode = table.Column<string>(name: "Bill-to Country_Region Code", maxLength: 10, nullable: false),
                    SelltoPostCode = table.Column<string>(name: "Sell-to Post Code", maxLength: 20, nullable: false),
                    SelltoCounty = table.Column<string>(name: "Sell-to County", maxLength: 30, nullable: false),
                    SelltoCountry_RegionCode = table.Column<string>(name: "Sell-to Country_Region Code", maxLength: 10, nullable: false),
                    ShiptoPostCode = table.Column<string>(name: "Ship-to Post Code", maxLength: 20, nullable: false),
                    ShiptoCounty = table.Column<string>(name: "Ship-to County", maxLength: 30, nullable: false),
                    ShiptoCountry_RegionCode = table.Column<string>(name: "Ship-to Country_Region Code", maxLength: 10, nullable: false),
                    Bal_AccountType = table.Column<int>(name: "Bal_ Account Type", nullable: false),
                    ExitPoint = table.Column<string>(name: "Exit Point", maxLength: 10, nullable: false),
                    Correction = table.Column<byte>(nullable: false),
                    DocumentDate = table.Column<DateTime>(name: "Document Date", type: "datetime", nullable: false),
                    ExternalDocumentNo_ = table.Column<string>(name: "External Document No_", maxLength: 35, nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: false),
                    TransactionSpecification = table.Column<string>(name: "Transaction Specification", maxLength: 10, nullable: false),
                    PaymentMethodCode = table.Column<string>(name: "Payment Method Code", maxLength: 10, nullable: false),
                    ShippingAgentCode = table.Column<string>(name: "Shipping Agent Code", maxLength: 10, nullable: false),
                    PackageTrackingNo_ = table.Column<string>(name: "Package Tracking No_", maxLength: 30, nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    PostingNo_Series = table.Column<string>(name: "Posting No_ Series", maxLength: 20, nullable: false),
                    ShippingNo_Series = table.Column<string>(name: "Shipping No_ Series", maxLength: 20, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    Reserve = table.Column<int>(nullable: false),
                    AppliestoID = table.Column<string>(name: "Applies-to ID", maxLength: 50, nullable: false),
                    VATBaseDiscount_ = table.Column<decimal>(name: "VAT Base Discount _", type: "decimal(38, 20)", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    InvoiceDiscountCalculation = table.Column<int>(name: "Invoice Discount Calculation", nullable: false),
                    InvoiceDiscountValue = table.Column<decimal>(name: "Invoice Discount Value", type: "decimal(38, 20)", nullable: false),
                    SendICDocument = table.Column<byte>(name: "Send IC Document", nullable: false),
                    ICStatus = table.Column<int>(name: "IC Status", nullable: false),
                    SelltoICPartnerCode = table.Column<string>(name: "Sell-to IC Partner Code", maxLength: 20, nullable: false),
                    BilltoICPartnerCode = table.Column<string>(name: "Bill-to IC Partner Code", maxLength: 20, nullable: false),
                    ICDirection = table.Column<int>(name: "IC Direction", nullable: false),
                    Prepayment_ = table.Column<decimal>(name: "Prepayment _", type: "decimal(38, 20)", nullable: false),
                    PrepaymentNo_Series = table.Column<string>(name: "Prepayment No_ Series", maxLength: 20, nullable: false),
                    CompressPrepayment = table.Column<byte>(name: "Compress Prepayment", nullable: false),
                    PrepaymentDueDate = table.Column<DateTime>(name: "Prepayment Due Date", type: "datetime", nullable: false),
                    Prepmt_Cr_MemoNo_Series = table.Column<string>(name: "Prepmt_ Cr_ Memo No_ Series", maxLength: 20, nullable: false),
                    Prepmt_PostingDescription = table.Column<string>(name: "Prepmt_ Posting Description", maxLength: 50, nullable: false),
                    Prepmt_Pmt_DiscountDate = table.Column<DateTime>(name: "Prepmt_ Pmt_ Discount Date", type: "datetime", nullable: false),
                    Prepmt_PaymentTermsCode = table.Column<string>(name: "Prepmt_ Payment Terms Code", maxLength: 10, nullable: false),
                    Prepmt_PaymentDiscount_ = table.Column<decimal>(name: "Prepmt_ Payment Discount _", type: "decimal(38, 20)", nullable: false),
                    QuoteNo_ = table.Column<string>(name: "Quote No_", maxLength: 20, nullable: false),
                    JobQueueStatus = table.Column<int>(name: "Job Queue Status", nullable: false),
                    JobQueueEntryID = table.Column<Guid>(name: "Job Queue Entry ID", nullable: false),
                    IncomingDocumentEntryNo_ = table.Column<int>(name: "Incoming Document Entry No_", nullable: false),
                    WorkDescription = table.Column<byte[]>(name: "Work Description", type: "image", nullable: true),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    PaymentServiceSetID = table.Column<int>(name: "Payment Service Set ID", nullable: false),
                    DirectDebitMandateID = table.Column<string>(name: "Direct Debit Mandate ID", maxLength: 35, nullable: false),
                    Doc_No_Occurrence = table.Column<int>(name: "Doc_ No_ Occurrence", nullable: false),
                    CampaignNo_ = table.Column<string>(name: "Campaign No_", maxLength: 20, nullable: false),
                    SelltoCustomerTemplateCode = table.Column<string>(name: "Sell-to Customer Template Code", maxLength: 10, nullable: false),
                    SelltoContactNo_ = table.Column<string>(name: "Sell-to Contact No_", maxLength: 20, nullable: false),
                    BilltoContactNo_ = table.Column<string>(name: "Bill-to Contact No_", maxLength: 20, nullable: false),
                    BilltoCustomerTemplateCode = table.Column<string>(name: "Bill-to Customer Template Code", maxLength: 10, nullable: false),
                    OpportunityNo_ = table.Column<string>(name: "Opportunity No_", maxLength: 20, nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    ShippingAdvice = table.Column<int>(name: "Shipping Advice", nullable: false),
                    PostingfromWhse_Ref_ = table.Column<int>(name: "Posting from Whse_ Ref_", nullable: false),
                    RequestedDeliveryDate = table.Column<DateTime>(name: "Requested Delivery Date", type: "datetime", nullable: false),
                    PromisedDeliveryDate = table.Column<DateTime>(name: "Promised Delivery Date", type: "datetime", nullable: false),
                    ShippingTime = table.Column<string>(name: "Shipping Time", unicode: false, maxLength: 32, nullable: false),
                    OutboundWhse_HandlingTime = table.Column<string>(name: "Outbound Whse_ Handling Time", unicode: false, maxLength: 32, nullable: false),
                    ShippingAgentServiceCode = table.Column<string>(name: "Shipping Agent Service Code", maxLength: 10, nullable: false),
                    Receive = table.Column<byte>(nullable: false),
                    ReturnReceiptNo_ = table.Column<string>(name: "Return Receipt No_", maxLength: 20, nullable: false),
                    ReturnReceiptNo_Series = table.Column<string>(name: "Return Receipt No_ Series", maxLength: 20, nullable: false),
                    LastReturnReceiptNo_ = table.Column<string>(name: "Last Return Receipt No_", maxLength: 20, nullable: false),
                    AllowLineDisc_ = table.Column<byte>(name: "Allow Line Disc_", nullable: false),
                    GetShipmentUsed = table.Column<byte>(name: "Get Shipment Used", nullable: false),
                    AssignedUserID = table.Column<string>(name: "Assigned User ID", maxLength: 50, nullable: false),
                    BatchNo_ = table.Column<string>(name: "Batch No_", maxLength: 10, nullable: false),
                    StoreNo_ = table.Column<string>(name: "Store No_", maxLength: 10, nullable: false),
                    POSID = table.Column<string>(name: "POS ID", maxLength: 20, nullable: false),
                    PostingTime = table.Column<DateTime>(name: "Posting Time", type: "datetime", nullable: false),
                    CashierID = table.Column<string>(name: "Cashier ID", maxLength: 10, nullable: false),
                    NotShowDialog = table.Column<byte>(name: "Not Show Dialog", nullable: false),
                    SalesType = table.Column<string>(name: "Sales Type", maxLength: 20, nullable: false),
                    POSComment = table.Column<string>(name: "POS Comment", maxLength: 30, nullable: false),
                    RetailStatus = table.Column<int>(name: "Retail Status", nullable: false),
                    Receiving_PickingNo_ = table.Column<string>(name: "Receiving_Picking No_", maxLength: 20, nullable: false),
                    xRetailLocationCode = table.Column<string>(name: "xRetail Location Code", maxLength: 10, nullable: false),
                    StatementNo_ = table.Column<string>(name: "Statement No_", maxLength: 20, nullable: false),
                    MemberCardNo_ = table.Column<string>(name: "Member Card No_", maxLength: 100, nullable: false),
                    QuoteValidUntilDate = table.Column<DateTime>(name: "Quote Valid Until Date", type: "datetime", nullable: false),
                    QuoteSenttoCustomer = table.Column<DateTime>(name: "Quote Sent to Customer", type: "datetime", nullable: false),
                    QuoteAccepted = table.Column<byte>(name: "Quote Accepted", nullable: false),
                    QuoteAcceptedDate = table.Column<DateTime>(name: "Quote Accepted Date", type: "datetime", nullable: false),
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales Header", x => new { x.DocumentType, x.No_ });
                });

            migrationBuilder.CreateTable(
                name: "Sales Invoice Header",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    SelltoCustomerNo_ = table.Column<string>(name: "Sell-to Customer No_", maxLength: 20, nullable: false),
                    BilltoCustomerNo_ = table.Column<string>(name: "Bill-to Customer No_", maxLength: 20, nullable: false),
                    BilltoName = table.Column<string>(name: "Bill-to Name", maxLength: 50, nullable: false),
                    BilltoName2 = table.Column<string>(name: "Bill-to Name 2", maxLength: 50, nullable: false),
                    BilltoAddress = table.Column<string>(name: "Bill-to Address", maxLength: 50, nullable: false),
                    BilltoAddress2 = table.Column<string>(name: "Bill-to Address 2", maxLength: 50, nullable: false),
                    BilltoCity = table.Column<string>(name: "Bill-to City", maxLength: 30, nullable: false),
                    BilltoContact = table.Column<string>(name: "Bill-to Contact", maxLength: 50, nullable: false),
                    YourReference = table.Column<string>(name: "Your Reference", maxLength: 35, nullable: false),
                    ShiptoCode = table.Column<string>(name: "Ship-to Code", maxLength: 10, nullable: false),
                    ShiptoName = table.Column<string>(name: "Ship-to Name", maxLength: 50, nullable: false),
                    ShiptoName2 = table.Column<string>(name: "Ship-to Name 2", maxLength: 50, nullable: false),
                    ShiptoAddress = table.Column<string>(name: "Ship-to Address", maxLength: 50, nullable: false),
                    ShiptoAddress2 = table.Column<string>(name: "Ship-to Address 2", maxLength: 50, nullable: false),
                    ShiptoCity = table.Column<string>(name: "Ship-to City", maxLength: 30, nullable: false),
                    ShiptoContact = table.Column<string>(name: "Ship-to Contact", maxLength: 50, nullable: false),
                    OrderDate = table.Column<DateTime>(name: "Order Date", type: "datetime", nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    ShipmentDate = table.Column<DateTime>(name: "Shipment Date", type: "datetime", nullable: false),
                    PostingDescription = table.Column<string>(name: "Posting Description", maxLength: 50, nullable: false),
                    PaymentTermsCode = table.Column<string>(name: "Payment Terms Code", maxLength: 10, nullable: false),
                    DueDate = table.Column<DateTime>(name: "Due Date", type: "datetime", nullable: false),
                    PaymentDiscount_ = table.Column<decimal>(name: "Payment Discount _", type: "decimal(38, 20)", nullable: false),
                    Pmt_DiscountDate = table.Column<DateTime>(name: "Pmt_ Discount Date", type: "datetime", nullable: false),
                    ShipmentMethodCode = table.Column<string>(name: "Shipment Method Code", maxLength: 10, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    CustomerPostingGroup = table.Column<string>(name: "Customer Posting Group", maxLength: 20, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    CurrencyFactor = table.Column<decimal>(name: "Currency Factor", type: "decimal(38, 20)", nullable: false),
                    CustomerPriceGroup = table.Column<string>(name: "Customer Price Group", maxLength: 10, nullable: false),
                    PricesIncludingVAT = table.Column<byte>(name: "Prices Including VAT", nullable: false),
                    InvoiceDisc_Code = table.Column<string>(name: "Invoice Disc_ Code", maxLength: 20, nullable: false),
                    CustomerDisc_Group = table.Column<string>(name: "Customer Disc_ Group", maxLength: 20, nullable: false),
                    LanguageCode = table.Column<string>(name: "Language Code", maxLength: 10, nullable: false),
                    SalespersonCode = table.Column<string>(name: "Salesperson Code", maxLength: 20, nullable: false),
                    OrderNo_ = table.Column<string>(name: "Order No_", maxLength: 20, nullable: false),
                    No_Printed = table.Column<int>(name: "No_ Printed", nullable: false),
                    OnHold = table.Column<string>(name: "On Hold", maxLength: 3, nullable: false),
                    AppliestoDoc_Type = table.Column<int>(name: "Applies-to Doc_ Type", nullable: false),
                    AppliestoDoc_No_ = table.Column<string>(name: "Applies-to Doc_ No_", maxLength: 20, nullable: false),
                    Bal_AccountNo_ = table.Column<string>(name: "Bal_ Account No_", maxLength: 20, nullable: false),
                    VATRegistrationNo_ = table.Column<string>(name: "VAT Registration No_", maxLength: 20, nullable: false),
                    ReasonCode = table.Column<string>(name: "Reason Code", maxLength: 10, nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    EU3PartyTrade = table.Column<byte>(name: "EU 3-Party Trade", nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", maxLength: 10, nullable: false),
                    TransportMethod = table.Column<string>(name: "Transport Method", maxLength: 10, nullable: false),
                    VATCountry_RegionCode = table.Column<string>(name: "VAT Country_Region Code", maxLength: 10, nullable: false),
                    SelltoCustomerName = table.Column<string>(name: "Sell-to Customer Name", maxLength: 50, nullable: false),
                    SelltoCustomerName2 = table.Column<string>(name: "Sell-to Customer Name 2", maxLength: 50, nullable: false),
                    SelltoAddress = table.Column<string>(name: "Sell-to Address", maxLength: 50, nullable: false),
                    SelltoAddress2 = table.Column<string>(name: "Sell-to Address 2", maxLength: 50, nullable: false),
                    SelltoCity = table.Column<string>(name: "Sell-to City", maxLength: 30, nullable: false),
                    SelltoContact = table.Column<string>(name: "Sell-to Contact", maxLength: 50, nullable: false),
                    BilltoPostCode = table.Column<string>(name: "Bill-to Post Code", maxLength: 20, nullable: false),
                    BilltoCounty = table.Column<string>(name: "Bill-to County", maxLength: 30, nullable: false),
                    BilltoCountry_RegionCode = table.Column<string>(name: "Bill-to Country_Region Code", maxLength: 10, nullable: false),
                    SelltoPostCode = table.Column<string>(name: "Sell-to Post Code", maxLength: 20, nullable: false),
                    SelltoCounty = table.Column<string>(name: "Sell-to County", maxLength: 30, nullable: false),
                    SelltoCountry_RegionCode = table.Column<string>(name: "Sell-to Country_Region Code", maxLength: 10, nullable: false),
                    ShiptoPostCode = table.Column<string>(name: "Ship-to Post Code", maxLength: 20, nullable: false),
                    ShiptoCounty = table.Column<string>(name: "Ship-to County", maxLength: 30, nullable: false),
                    ShiptoCountry_RegionCode = table.Column<string>(name: "Ship-to Country_Region Code", maxLength: 10, nullable: false),
                    Bal_AccountType = table.Column<int>(name: "Bal_ Account Type", nullable: false),
                    ExitPoint = table.Column<string>(name: "Exit Point", maxLength: 10, nullable: false),
                    Correction = table.Column<byte>(nullable: false),
                    DocumentDate = table.Column<DateTime>(name: "Document Date", type: "datetime", nullable: false),
                    ExternalDocumentNo_ = table.Column<string>(name: "External Document No_", maxLength: 35, nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: false),
                    TransactionSpecification = table.Column<string>(name: "Transaction Specification", maxLength: 10, nullable: false),
                    PaymentMethodCode = table.Column<string>(name: "Payment Method Code", maxLength: 10, nullable: false),
                    ShippingAgentCode = table.Column<string>(name: "Shipping Agent Code", maxLength: 10, nullable: false),
                    PackageTrackingNo_ = table.Column<string>(name: "Package Tracking No_", maxLength: 30, nullable: false),
                    PreAssignedNo_Series = table.Column<string>(name: "Pre-Assigned No_ Series", maxLength: 20, nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    OrderNo_Series = table.Column<string>(name: "Order No_ Series", maxLength: 20, nullable: false),
                    PreAssignedNo_ = table.Column<string>(name: "Pre-Assigned No_", maxLength: 20, nullable: false),
                    UserID = table.Column<string>(name: "User ID", maxLength: 50, nullable: false),
                    SourceCode = table.Column<string>(name: "Source Code", maxLength: 10, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    VATBaseDiscount_ = table.Column<decimal>(name: "VAT Base Discount _", type: "decimal(38, 20)", nullable: false),
                    PrepaymentNo_Series = table.Column<string>(name: "Prepayment No_ Series", maxLength: 20, nullable: false),
                    PrepaymentInvoice = table.Column<byte>(name: "Prepayment Invoice", nullable: false),
                    PrepaymentOrderNo_ = table.Column<string>(name: "Prepayment Order No_", maxLength: 20, nullable: false),
                    QuoteNo_ = table.Column<string>(name: "Quote No_", maxLength: 20, nullable: false),
                    WorkDescription = table.Column<byte[]>(name: "Work Description", type: "image", nullable: true),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    PaymentServiceSetID = table.Column<int>(name: "Payment Service Set ID", nullable: false),
                    DocumentExchangeIdentifier = table.Column<string>(name: "Document Exchange Identifier", maxLength: 50, nullable: false),
                    DocumentExchangeStatus = table.Column<int>(name: "Document Exchange Status", nullable: false),
                    Doc_Exch_OriginalIdentifier = table.Column<string>(name: "Doc_ Exch_ Original Identifier", maxLength: 50, nullable: false),
                    CoupledtoCRM = table.Column<byte>(name: "Coupled to CRM", nullable: false),
                    DirectDebitMandateID = table.Column<string>(name: "Direct Debit Mandate ID", maxLength: 35, nullable: false),
                    Cust_LedgerEntryNo_ = table.Column<int>(name: "Cust_ Ledger Entry No_", nullable: false),
                    CampaignNo_ = table.Column<string>(name: "Campaign No_", maxLength: 20, nullable: false),
                    SelltoContactNo_ = table.Column<string>(name: "Sell-to Contact No_", maxLength: 20, nullable: false),
                    BilltoContactNo_ = table.Column<string>(name: "Bill-to Contact No_", maxLength: 20, nullable: false),
                    OpportunityNo_ = table.Column<string>(name: "Opportunity No_", maxLength: 20, nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    AllowLineDisc_ = table.Column<byte>(name: "Allow Line Disc_", nullable: false),
                    GetShipmentUsed = table.Column<byte>(name: "Get Shipment Used", nullable: false),
                    BatchNo_ = table.Column<string>(name: "Batch No_", maxLength: 10, nullable: false),
                    StoreNo_ = table.Column<string>(name: "Store No_", maxLength: 10, nullable: false),
                    POSID = table.Column<string>(name: "POS ID", maxLength: 20, nullable: false),
                    PostingTime = table.Column<DateTime>(name: "Posting Time", type: "datetime", nullable: false),
                    CashierID = table.Column<string>(name: "Cashier ID", maxLength: 10, nullable: false),
                    BITimestamp = table.Column<DateTime>(name: "BI Timestamp", type: "datetime", nullable: false),
                    MemberCardNo_ = table.Column<string>(name: "Member Card No_", maxLength: 100, nullable: false),
                    InvoiceDiscountCalculation = table.Column<int>(name: "Invoice Discount Calculation", nullable: false),
                    InvoiceDiscountValue = table.Column<decimal>(name: "Invoice Discount Value", type: "decimal(38, 20)", nullable: false),
                    Id = table.Column<Guid>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales Invoice Header", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Sales Invoice Line",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DocumentNo_ = table.Column<string>(name: "Document No_", maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    SelltoCustomerNo_ = table.Column<string>(name: "Sell-to Customer No_", maxLength: 20, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    PostingGroup = table.Column<string>(name: "Posting Group", maxLength: 20, nullable: false),
                    ShipmentDate = table.Column<DateTime>(name: "Shipment Date", type: "datetime", nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Description2 = table.Column<string>(name: "Description 2", maxLength: 50, nullable: false),
                    UnitofMeasure = table.Column<string>(name: "Unit of Measure", maxLength: 10, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    UnitPrice = table.Column<decimal>(name: "Unit Price", type: "decimal(38, 20)", nullable: false),
                    UnitCostLCY = table.Column<decimal>(name: "Unit Cost (LCY)", type: "decimal(38, 20)", nullable: false),
                    VAT_ = table.Column<decimal>(name: "VAT _", type: "decimal(38, 20)", nullable: false),
                    LineDiscount_ = table.Column<decimal>(name: "Line Discount _", type: "decimal(38, 20)", nullable: false),
                    LineDiscountAmount = table.Column<decimal>(name: "Line Discount Amount", type: "decimal(38, 20)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    AmountIncludingVAT = table.Column<decimal>(name: "Amount Including VAT", type: "decimal(38, 20)", nullable: false),
                    AllowInvoiceDisc_ = table.Column<byte>(name: "Allow Invoice Disc_", nullable: false),
                    GrossWeight = table.Column<decimal>(name: "Gross Weight", type: "decimal(38, 20)", nullable: false),
                    NetWeight = table.Column<decimal>(name: "Net Weight", type: "decimal(38, 20)", nullable: false),
                    UnitsperParcel = table.Column<decimal>(name: "Units per Parcel", type: "decimal(38, 20)", nullable: false),
                    UnitVolume = table.Column<decimal>(name: "Unit Volume", type: "decimal(38, 20)", nullable: false),
                    Appl_toItemEntry = table.Column<int>(name: "Appl_-to Item Entry", nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    CustomerPriceGroup = table.Column<string>(name: "Customer Price Group", maxLength: 10, nullable: false),
                    JobNo_ = table.Column<string>(name: "Job No_", maxLength: 20, nullable: false),
                    WorkTypeCode = table.Column<string>(name: "Work Type Code", maxLength: 10, nullable: false),
                    ShipmentNo_ = table.Column<string>(name: "Shipment No_", maxLength: 20, nullable: false),
                    ShipmentLineNo_ = table.Column<int>(name: "Shipment Line No_", nullable: false),
                    BilltoCustomerNo_ = table.Column<string>(name: "Bill-to Customer No_", maxLength: 20, nullable: false),
                    Inv_DiscountAmount = table.Column<decimal>(name: "Inv_ Discount Amount", type: "decimal(38, 20)", nullable: false),
                    DropShipment = table.Column<byte>(name: "Drop Shipment", nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    Gen_Prod_PostingGroup = table.Column<string>(name: "Gen_ Prod_ Posting Group", maxLength: 20, nullable: false),
                    VATCalculationType = table.Column<int>(name: "VAT Calculation Type", nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", maxLength: 10, nullable: false),
                    TransportMethod = table.Column<string>(name: "Transport Method", maxLength: 10, nullable: false),
                    AttachedtoLineNo_ = table.Column<int>(name: "Attached to Line No_", nullable: false),
                    ExitPoint = table.Column<string>(name: "Exit Point", maxLength: 10, nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: false),
                    TransactionSpecification = table.Column<string>(name: "Transaction Specification", maxLength: 10, nullable: false),
                    TaxCategory = table.Column<string>(name: "Tax Category", maxLength: 10, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    TaxGroupCode = table.Column<string>(name: "Tax Group Code", maxLength: 20, nullable: false),
                    VATClauseCode = table.Column<string>(name: "VAT Clause Code", maxLength: 20, nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    VATProd_PostingGroup = table.Column<string>(name: "VAT Prod_ Posting Group", maxLength: 20, nullable: false),
                    BlanketOrderNo_ = table.Column<string>(name: "Blanket Order No_", maxLength: 20, nullable: false),
                    BlanketOrderLineNo_ = table.Column<int>(name: "Blanket Order Line No_", nullable: false),
                    VATBaseAmount = table.Column<decimal>(name: "VAT Base Amount", type: "decimal(38, 20)", nullable: false),
                    UnitCost = table.Column<decimal>(name: "Unit Cost", type: "decimal(38, 20)", nullable: false),
                    SystemCreatedEntry = table.Column<byte>(name: "System-Created Entry", nullable: false),
                    LineAmount = table.Column<decimal>(name: "Line Amount", type: "decimal(38, 20)", nullable: false),
                    VATDifference = table.Column<decimal>(name: "VAT Difference", type: "decimal(38, 20)", nullable: false),
                    VATIdentifier = table.Column<string>(name: "VAT Identifier", maxLength: 20, nullable: false),
                    ICPartnerRef_Type = table.Column<int>(name: "IC Partner Ref_ Type", nullable: false),
                    ICPartnerReference = table.Column<string>(name: "IC Partner Reference", maxLength: 20, nullable: false),
                    PrepaymentLine = table.Column<byte>(name: "Prepayment Line", nullable: false),
                    ICPartnerCode = table.Column<string>(name: "IC Partner Code", maxLength: 20, nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    JobTaskNo_ = table.Column<string>(name: "Job Task No_", maxLength: 20, nullable: false),
                    JobContractEntryNo_ = table.Column<int>(name: "Job Contract Entry No_", nullable: false),
                    DeferralCode = table.Column<string>(name: "Deferral Code", maxLength: 10, nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    BinCode = table.Column<string>(name: "Bin Code", maxLength: 20, nullable: false),
                    Qty_perUnitofMeasure = table.Column<decimal>(name: "Qty_ per Unit of Measure", type: "decimal(38, 20)", nullable: false),
                    UnitofMeasureCode = table.Column<string>(name: "Unit of Measure Code", maxLength: 10, nullable: false),
                    QuantityBase = table.Column<decimal>(name: "Quantity (Base)", type: "decimal(38, 20)", nullable: false),
                    FAPostingDate = table.Column<DateTime>(name: "FA Posting Date", type: "datetime", nullable: false),
                    DepreciationBookCode = table.Column<string>(name: "Depreciation Book Code", maxLength: 10, nullable: false),
                    Depr_untilFAPostingDate = table.Column<byte>(name: "Depr_ until FA Posting Date", nullable: false),
                    DuplicateinDepreciationBook = table.Column<string>(name: "Duplicate in Depreciation Book", maxLength: 10, nullable: false),
                    UseDuplicationList = table.Column<byte>(name: "Use Duplication List", nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    CrossReferenceNo_ = table.Column<string>(name: "Cross-Reference No_", maxLength: 20, nullable: false),
                    UnitofMeasureCrossRef_ = table.Column<string>(name: "Unit of Measure (Cross Ref_)", maxLength: 10, nullable: false),
                    CrossReferenceType = table.Column<int>(name: "Cross-Reference Type", nullable: false),
                    CrossReferenceTypeNo_ = table.Column<string>(name: "Cross-Reference Type No_", maxLength: 30, nullable: false),
                    ItemCategoryCode = table.Column<string>(name: "Item Category Code", maxLength: 20, nullable: false),
                    Nonstock = table.Column<byte>(nullable: false),
                    PurchasingCode = table.Column<string>(name: "Purchasing Code", maxLength: 10, nullable: false),
                    ProductGroupCode = table.Column<string>(name: "Product Group Code", maxLength: 10, nullable: false),
                    Appl_fromItemEntry = table.Column<int>(name: "Appl_-from Item Entry", nullable: false),
                    ReturnReasonCode = table.Column<string>(name: "Return Reason Code", maxLength: 10, nullable: false),
                    AllowLineDisc_ = table.Column<byte>(name: "Allow Line Disc_", nullable: false),
                    CustomerDisc_Group = table.Column<string>(name: "Customer Disc_ Group", maxLength: 20, nullable: false),
                    Division = table.Column<string>(maxLength: 10, nullable: false),
                    OfferNo_ = table.Column<string>(name: "Offer No_", maxLength: 20, nullable: false),
                    VendorNo_ = table.Column<string>(name: "Vendor No_", maxLength: 20, nullable: false),
                    BITimestamp = table.Column<DateTime>(name: "BI Timestamp", type: "datetime", nullable: false),
                    MemberPointsType = table.Column<int>(name: "Member Points Type", nullable: false),
                    MemberPoints = table.Column<decimal>(name: "Member Points", type: "decimal(38, 20)", nullable: false),
                    LineDiscountCalculation = table.Column<int>(name: "Line Discount Calculation", nullable: false),
                    Pricedescription = table.Column<string>(name: "Price description", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales Invoice Line", x => new { x.DocumentNo_, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Sales Line",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DocumentType = table.Column<int>(name: "Document Type", nullable: false),
                    DocumentNo_ = table.Column<string>(name: "Document No_", maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    SelltoCustomerNo_ = table.Column<string>(name: "Sell-to Customer No_", maxLength: 20, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    PostingGroup = table.Column<string>(name: "Posting Group", maxLength: 20, nullable: false),
                    ShipmentDate = table.Column<DateTime>(name: "Shipment Date", type: "datetime", nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Description2 = table.Column<string>(name: "Description 2", maxLength: 50, nullable: false),
                    UnitofMeasure = table.Column<string>(name: "Unit of Measure", maxLength: 10, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    OutstandingQuantity = table.Column<decimal>(name: "Outstanding Quantity", type: "decimal(38, 20)", nullable: false),
                    Qty_toInvoice = table.Column<decimal>(name: "Qty_ to Invoice", type: "decimal(38, 20)", nullable: false),
                    Qty_toShip = table.Column<decimal>(name: "Qty_ to Ship", type: "decimal(38, 20)", nullable: false),
                    UnitPrice = table.Column<decimal>(name: "Unit Price", type: "decimal(38, 20)", nullable: false),
                    UnitCostLCY = table.Column<decimal>(name: "Unit Cost (LCY)", type: "decimal(38, 20)", nullable: false),
                    VAT_ = table.Column<decimal>(name: "VAT _", type: "decimal(38, 20)", nullable: false),
                    LineDiscount_ = table.Column<decimal>(name: "Line Discount _", type: "decimal(38, 20)", nullable: false),
                    LineDiscountAmount = table.Column<decimal>(name: "Line Discount Amount", type: "decimal(38, 20)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    AmountIncludingVAT = table.Column<decimal>(name: "Amount Including VAT", type: "decimal(38, 20)", nullable: false),
                    AllowInvoiceDisc_ = table.Column<byte>(name: "Allow Invoice Disc_", nullable: false),
                    GrossWeight = table.Column<decimal>(name: "Gross Weight", type: "decimal(38, 20)", nullable: false),
                    NetWeight = table.Column<decimal>(name: "Net Weight", type: "decimal(38, 20)", nullable: false),
                    UnitsperParcel = table.Column<decimal>(name: "Units per Parcel", type: "decimal(38, 20)", nullable: false),
                    UnitVolume = table.Column<decimal>(name: "Unit Volume", type: "decimal(38, 20)", nullable: false),
                    Appl_toItemEntry = table.Column<int>(name: "Appl_-to Item Entry", nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    CustomerPriceGroup = table.Column<string>(name: "Customer Price Group", maxLength: 10, nullable: false),
                    JobNo_ = table.Column<string>(name: "Job No_", maxLength: 20, nullable: false),
                    WorkTypeCode = table.Column<string>(name: "Work Type Code", maxLength: 10, nullable: false),
                    RecalculateInvoiceDisc_ = table.Column<byte>(name: "Recalculate Invoice Disc_", nullable: false),
                    OutstandingAmount = table.Column<decimal>(name: "Outstanding Amount", type: "decimal(38, 20)", nullable: false),
                    Qty_ShippedNotInvoiced = table.Column<decimal>(name: "Qty_ Shipped Not Invoiced", type: "decimal(38, 20)", nullable: false),
                    ShippedNotInvoiced = table.Column<decimal>(name: "Shipped Not Invoiced", type: "decimal(38, 20)", nullable: false),
                    QuantityShipped = table.Column<decimal>(name: "Quantity Shipped", type: "decimal(38, 20)", nullable: false),
                    QuantityInvoiced = table.Column<decimal>(name: "Quantity Invoiced", type: "decimal(38, 20)", nullable: false),
                    ShipmentNo_ = table.Column<string>(name: "Shipment No_", maxLength: 20, nullable: false),
                    ShipmentLineNo_ = table.Column<int>(name: "Shipment Line No_", nullable: false),
                    Profit_ = table.Column<decimal>(name: "Profit _", type: "decimal(38, 20)", nullable: false),
                    BilltoCustomerNo_ = table.Column<string>(name: "Bill-to Customer No_", maxLength: 20, nullable: false),
                    Inv_DiscountAmount = table.Column<decimal>(name: "Inv_ Discount Amount", type: "decimal(38, 20)", nullable: false),
                    PurchaseOrderNo_ = table.Column<string>(name: "Purchase Order No_", maxLength: 20, nullable: false),
                    Purch_OrderLineNo_ = table.Column<int>(name: "Purch_ Order Line No_", nullable: false),
                    DropShipment = table.Column<byte>(name: "Drop Shipment", nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    Gen_Prod_PostingGroup = table.Column<string>(name: "Gen_ Prod_ Posting Group", maxLength: 20, nullable: false),
                    VATCalculationType = table.Column<int>(name: "VAT Calculation Type", nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", maxLength: 10, nullable: false),
                    TransportMethod = table.Column<string>(name: "Transport Method", maxLength: 10, nullable: false),
                    AttachedtoLineNo_ = table.Column<int>(name: "Attached to Line No_", nullable: false),
                    ExitPoint = table.Column<string>(name: "Exit Point", maxLength: 10, nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: false),
                    TransactionSpecification = table.Column<string>(name: "Transaction Specification", maxLength: 10, nullable: false),
                    TaxCategory = table.Column<string>(name: "Tax Category", maxLength: 10, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    TaxGroupCode = table.Column<string>(name: "Tax Group Code", maxLength: 20, nullable: false),
                    VATClauseCode = table.Column<string>(name: "VAT Clause Code", maxLength: 20, nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    VATProd_PostingGroup = table.Column<string>(name: "VAT Prod_ Posting Group", maxLength: 20, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    OutstandingAmountLCY = table.Column<decimal>(name: "Outstanding Amount (LCY)", type: "decimal(38, 20)", nullable: false),
                    ShippedNotInvoicedLCY = table.Column<decimal>(name: "Shipped Not Invoiced (LCY)", type: "decimal(38, 20)", nullable: false),
                    Reserve = table.Column<int>(nullable: false),
                    BlanketOrderNo_ = table.Column<string>(name: "Blanket Order No_", maxLength: 20, nullable: false),
                    BlanketOrderLineNo_ = table.Column<int>(name: "Blanket Order Line No_", nullable: false),
                    VATBaseAmount = table.Column<decimal>(name: "VAT Base Amount", type: "decimal(38, 20)", nullable: false),
                    UnitCost = table.Column<decimal>(name: "Unit Cost", type: "decimal(38, 20)", nullable: false),
                    SystemCreatedEntry = table.Column<byte>(name: "System-Created Entry", nullable: false),
                    LineAmount = table.Column<decimal>(name: "Line Amount", type: "decimal(38, 20)", nullable: false),
                    VATDifference = table.Column<decimal>(name: "VAT Difference", type: "decimal(38, 20)", nullable: false),
                    Inv_Disc_AmounttoInvoice = table.Column<decimal>(name: "Inv_ Disc_ Amount to Invoice", type: "decimal(38, 20)", nullable: false),
                    VATIdentifier = table.Column<string>(name: "VAT Identifier", maxLength: 20, nullable: false),
                    ICPartnerRef_Type = table.Column<int>(name: "IC Partner Ref_ Type", nullable: false),
                    ICPartnerReference = table.Column<string>(name: "IC Partner Reference", maxLength: 20, nullable: false),
                    Prepayment_ = table.Column<decimal>(name: "Prepayment _", type: "decimal(38, 20)", nullable: false),
                    Prepmt_LineAmount = table.Column<decimal>(name: "Prepmt_ Line Amount", type: "decimal(38, 20)", nullable: false),
                    Prepmt_Amt_Inv_ = table.Column<decimal>(name: "Prepmt_ Amt_ Inv_", type: "decimal(38, 20)", nullable: false),
                    Prepmt_Amt_Incl_VAT = table.Column<decimal>(name: "Prepmt_ Amt_ Incl_ VAT", type: "decimal(38, 20)", nullable: false),
                    PrepaymentAmount = table.Column<decimal>(name: "Prepayment Amount", type: "decimal(38, 20)", nullable: false),
                    Prepmt_VATBaseAmt_ = table.Column<decimal>(name: "Prepmt_ VAT Base Amt_", type: "decimal(38, 20)", nullable: false),
                    PrepaymentVAT_ = table.Column<decimal>(name: "Prepayment VAT _", type: "decimal(38, 20)", nullable: false),
                    Prepmt_VATCalc_Type = table.Column<int>(name: "Prepmt_ VAT Calc_ Type", nullable: false),
                    PrepaymentVATIdentifier = table.Column<string>(name: "Prepayment VAT Identifier", maxLength: 20, nullable: false),
                    PrepaymentTaxAreaCode = table.Column<string>(name: "Prepayment Tax Area Code", maxLength: 20, nullable: false),
                    PrepaymentTaxLiable = table.Column<byte>(name: "Prepayment Tax Liable", nullable: false),
                    PrepaymentTaxGroupCode = table.Column<string>(name: "Prepayment Tax Group Code", maxLength: 20, nullable: false),
                    PrepmtAmttoDeduct = table.Column<decimal>(name: "Prepmt Amt to Deduct", type: "decimal(38, 20)", nullable: false),
                    PrepmtAmtDeducted = table.Column<decimal>(name: "Prepmt Amt Deducted", type: "decimal(38, 20)", nullable: false),
                    PrepaymentLine = table.Column<byte>(name: "Prepayment Line", nullable: false),
                    Prepmt_AmountInv_Incl_VAT = table.Column<decimal>(name: "Prepmt_ Amount Inv_ Incl_ VAT", type: "decimal(38, 20)", nullable: false),
                    Prepmt_AmountInv_LCY = table.Column<decimal>(name: "Prepmt_ Amount Inv_ (LCY)", type: "decimal(38, 20)", nullable: false),
                    ICPartnerCode = table.Column<string>(name: "IC Partner Code", maxLength: 20, nullable: false),
                    Prepmt_VATAmountInv_LCY = table.Column<decimal>(name: "Prepmt_ VAT Amount Inv_ (LCY)", type: "decimal(38, 20)", nullable: false),
                    PrepaymentVATDifference = table.Column<decimal>(name: "Prepayment VAT Difference", type: "decimal(38, 20)", nullable: false),
                    PrepmtVATDiff_toDeduct = table.Column<decimal>(name: "Prepmt VAT Diff_ to Deduct", type: "decimal(38, 20)", nullable: false),
                    PrepmtVATDiff_Deducted = table.Column<decimal>(name: "Prepmt VAT Diff_ Deducted", type: "decimal(38, 20)", nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    Qty_toAssembletoOrder = table.Column<decimal>(name: "Qty_ to Assemble to Order", type: "decimal(38, 20)", nullable: false),
                    Qty_toAsm_toOrderBase = table.Column<decimal>(name: "Qty_ to Asm_ to Order (Base)", type: "decimal(38, 20)", nullable: false),
                    JobTaskNo_ = table.Column<string>(name: "Job Task No_", maxLength: 20, nullable: false),
                    JobContractEntryNo_ = table.Column<int>(name: "Job Contract Entry No_", nullable: false),
                    DeferralCode = table.Column<string>(name: "Deferral Code", maxLength: 10, nullable: false),
                    ReturnsDeferralStartDate = table.Column<DateTime>(name: "Returns Deferral Start Date", type: "datetime", nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    BinCode = table.Column<string>(name: "Bin Code", maxLength: 20, nullable: false),
                    Qty_perUnitofMeasure = table.Column<decimal>(name: "Qty_ per Unit of Measure", type: "decimal(38, 20)", nullable: false),
                    Planned = table.Column<byte>(nullable: false),
                    UnitofMeasureCode = table.Column<string>(name: "Unit of Measure Code", maxLength: 10, nullable: false),
                    QuantityBase = table.Column<decimal>(name: "Quantity (Base)", type: "decimal(38, 20)", nullable: false),
                    OutstandingQty_Base = table.Column<decimal>(name: "Outstanding Qty_ (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_toInvoiceBase = table.Column<decimal>(name: "Qty_ to Invoice (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_toShipBase = table.Column<decimal>(name: "Qty_ to Ship (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_ShippedNotInvd_Base = table.Column<decimal>(name: "Qty_ Shipped Not Invd_ (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_ShippedBase = table.Column<decimal>(name: "Qty_ Shipped (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_InvoicedBase = table.Column<decimal>(name: "Qty_ Invoiced (Base)", type: "decimal(38, 20)", nullable: false),
                    FAPostingDate = table.Column<DateTime>(name: "FA Posting Date", type: "datetime", nullable: false),
                    DepreciationBookCode = table.Column<string>(name: "Depreciation Book Code", maxLength: 10, nullable: false),
                    Depr_untilFAPostingDate = table.Column<byte>(name: "Depr_ until FA Posting Date", nullable: false),
                    DuplicateinDepreciationBook = table.Column<string>(name: "Duplicate in Depreciation Book", maxLength: 10, nullable: false),
                    UseDuplicationList = table.Column<byte>(name: "Use Duplication List", nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    OutofStockSubstitution = table.Column<byte>(name: "Out-of-Stock Substitution", nullable: false),
                    OriginallyOrderedNo_ = table.Column<string>(name: "Originally Ordered No_", maxLength: 20, nullable: false),
                    OriginallyOrderedVar_Code = table.Column<string>(name: "Originally Ordered Var_ Code", maxLength: 10, nullable: false),
                    CrossReferenceNo_ = table.Column<string>(name: "Cross-Reference No_", maxLength: 20, nullable: false),
                    UnitofMeasureCrossRef_ = table.Column<string>(name: "Unit of Measure (Cross Ref_)", maxLength: 10, nullable: false),
                    CrossReferenceType = table.Column<int>(name: "Cross-Reference Type", nullable: false),
                    CrossReferenceTypeNo_ = table.Column<string>(name: "Cross-Reference Type No_", maxLength: 30, nullable: false),
                    ItemCategoryCode = table.Column<string>(name: "Item Category Code", maxLength: 20, nullable: false),
                    Nonstock = table.Column<byte>(nullable: false),
                    PurchasingCode = table.Column<string>(name: "Purchasing Code", maxLength: 10, nullable: false),
                    ProductGroupCode = table.Column<string>(name: "Product Group Code", maxLength: 10, nullable: false),
                    SpecialOrder = table.Column<byte>(name: "Special Order", nullable: false),
                    SpecialOrderPurchaseNo_ = table.Column<string>(name: "Special Order Purchase No_", maxLength: 20, nullable: false),
                    SpecialOrderPurch_LineNo_ = table.Column<int>(name: "Special Order Purch_ Line No_", nullable: false),
                    CompletelyShipped = table.Column<byte>(name: "Completely Shipped", nullable: false),
                    RequestedDeliveryDate = table.Column<DateTime>(name: "Requested Delivery Date", type: "datetime", nullable: false),
                    PromisedDeliveryDate = table.Column<DateTime>(name: "Promised Delivery Date", type: "datetime", nullable: false),
                    ShippingTime = table.Column<string>(name: "Shipping Time", unicode: false, maxLength: 32, nullable: false),
                    OutboundWhse_HandlingTime = table.Column<string>(name: "Outbound Whse_ Handling Time", unicode: false, maxLength: 32, nullable: false),
                    PlannedDeliveryDate = table.Column<DateTime>(name: "Planned Delivery Date", type: "datetime", nullable: false),
                    PlannedShipmentDate = table.Column<DateTime>(name: "Planned Shipment Date", type: "datetime", nullable: false),
                    ShippingAgentCode = table.Column<string>(name: "Shipping Agent Code", maxLength: 10, nullable: false),
                    ShippingAgentServiceCode = table.Column<string>(name: "Shipping Agent Service Code", maxLength: 10, nullable: false),
                    AllowItemChargeAssignment = table.Column<byte>(name: "Allow Item Charge Assignment", nullable: false),
                    ReturnQty_toReceive = table.Column<decimal>(name: "Return Qty_ to Receive", type: "decimal(38, 20)", nullable: false),
                    ReturnQty_toReceiveBase = table.Column<decimal>(name: "Return Qty_ to Receive (Base)", type: "decimal(38, 20)", nullable: false),
                    ReturnQty_Rcd_NotInvd_ = table.Column<decimal>(name: "Return Qty_ Rcd_ Not Invd_", type: "decimal(38, 20)", nullable: false),
                    Ret_Qty_Rcd_NotInvd_Base = table.Column<decimal>(name: "Ret_ Qty_ Rcd_ Not Invd_(Base)", type: "decimal(38, 20)", nullable: false),
                    ReturnRcd_NotInvd_ = table.Column<decimal>(name: "Return Rcd_ Not Invd_", type: "decimal(38, 20)", nullable: false),
                    ReturnRcd_NotInvd_LCY = table.Column<decimal>(name: "Return Rcd_ Not Invd_ (LCY)", type: "decimal(38, 20)", nullable: false),
                    ReturnQty_Received = table.Column<decimal>(name: "Return Qty_ Received", type: "decimal(38, 20)", nullable: false),
                    ReturnQty_ReceivedBase = table.Column<decimal>(name: "Return Qty_ Received (Base)", type: "decimal(38, 20)", nullable: false),
                    Appl_fromItemEntry = table.Column<int>(name: "Appl_-from Item Entry", nullable: false),
                    BOMItemNo_ = table.Column<string>(name: "BOM Item No_", maxLength: 20, nullable: false),
                    ReturnReceiptNo_ = table.Column<string>(name: "Return Receipt No_", maxLength: 20, nullable: false),
                    ReturnReceiptLineNo_ = table.Column<int>(name: "Return Receipt Line No_", nullable: false),
                    ReturnReasonCode = table.Column<string>(name: "Return Reason Code", maxLength: 10, nullable: false),
                    AllowLineDisc_ = table.Column<byte>(name: "Allow Line Disc_", nullable: false),
                    CustomerDisc_Group = table.Column<string>(name: "Customer Disc_ Group", maxLength: 20, nullable: false),
                    StoreNo_ = table.Column<string>(name: "Store No_", maxLength: 10, nullable: false),
                    CurrentCust_PriceGroup = table.Column<string>(name: "Current Cust_ Price Group", maxLength: 20, nullable: false),
                    CurrentStoreGroup = table.Column<string>(name: "Current Store Group", maxLength: 20, nullable: false),
                    Division = table.Column<string>(maxLength: 10, nullable: false),
                    OfferNo_ = table.Column<string>(name: "Offer No_", maxLength: 20, nullable: false),
                    PromotionNo_ = table.Column<string>(name: "Promotion No_", maxLength: 20, nullable: false),
                    Alloc_PlanPurc_OrderNo_ = table.Column<string>(name: "Alloc_ Plan Purc_ Order No_", maxLength: 20, nullable: false),
                    VendorNo_ = table.Column<string>(name: "Vendor No_", maxLength: 20, nullable: false),
                    ShippedNotInv_LCYNoVAT = table.Column<decimal>(name: "Shipped Not Inv_ (LCY) No VAT", type: "decimal(38, 20)", nullable: false),
                    LineDiscountCalculation = table.Column<int>(name: "Line Discount Calculation", nullable: false),
                    Subtype = table.Column<int>(nullable: false),
                    Pricedescription = table.Column<string>(name: "Price description", maxLength: 80, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales Line", x => new { x.DocumentType, x.DocumentNo_, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Sales Prepayment ",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    ItemNo_ = table.Column<string>(name: "Item No_", maxLength: 20, nullable: false),
                    SalesType = table.Column<int>(name: "Sales Type", nullable: false),
                    SalesCode = table.Column<string>(name: "Sales Code", maxLength: 20, nullable: false),
                    StartingDate = table.Column<DateTime>(name: "Starting Date", type: "datetime", nullable: false),
                    EndingDate = table.Column<DateTime>(name: "Ending Date", type: "datetime", nullable: false),
                    Prepayment_ = table.Column<decimal>(name: "Prepayment _", type: "decimal(38, 20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales Prepayment ", x => new { x.ItemNo_, x.SalesType, x.SalesCode, x.StartingDate });
                });

            migrationBuilder.CreateTable(
                name: "Sales Shipment Header",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    SelltoCustomerNo_ = table.Column<string>(name: "Sell-to Customer No_", maxLength: 20, nullable: false),
                    BilltoCustomerNo_ = table.Column<string>(name: "Bill-to Customer No_", maxLength: 20, nullable: false),
                    BilltoName = table.Column<string>(name: "Bill-to Name", maxLength: 50, nullable: false),
                    BilltoName2 = table.Column<string>(name: "Bill-to Name 2", maxLength: 50, nullable: false),
                    BilltoAddress = table.Column<string>(name: "Bill-to Address", maxLength: 50, nullable: false),
                    BilltoAddress2 = table.Column<string>(name: "Bill-to Address 2", maxLength: 50, nullable: false),
                    BilltoCity = table.Column<string>(name: "Bill-to City", maxLength: 30, nullable: false),
                    BilltoContact = table.Column<string>(name: "Bill-to Contact", maxLength: 50, nullable: false),
                    YourReference = table.Column<string>(name: "Your Reference", maxLength: 35, nullable: false),
                    ShiptoCode = table.Column<string>(name: "Ship-to Code", maxLength: 10, nullable: false),
                    ShiptoName = table.Column<string>(name: "Ship-to Name", maxLength: 50, nullable: false),
                    ShiptoName2 = table.Column<string>(name: "Ship-to Name 2", maxLength: 50, nullable: false),
                    ShiptoAddress = table.Column<string>(name: "Ship-to Address", maxLength: 50, nullable: false),
                    ShiptoAddress2 = table.Column<string>(name: "Ship-to Address 2", maxLength: 50, nullable: false),
                    ShiptoCity = table.Column<string>(name: "Ship-to City", maxLength: 30, nullable: false),
                    ShiptoContact = table.Column<string>(name: "Ship-to Contact", maxLength: 50, nullable: false),
                    OrderDate = table.Column<DateTime>(name: "Order Date", type: "datetime", nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    ShipmentDate = table.Column<DateTime>(name: "Shipment Date", type: "datetime", nullable: false),
                    PostingDescription = table.Column<string>(name: "Posting Description", maxLength: 50, nullable: false),
                    PaymentTermsCode = table.Column<string>(name: "Payment Terms Code", maxLength: 10, nullable: false),
                    DueDate = table.Column<DateTime>(name: "Due Date", type: "datetime", nullable: false),
                    PaymentDiscount_ = table.Column<decimal>(name: "Payment Discount _", type: "decimal(38, 20)", nullable: false),
                    Pmt_DiscountDate = table.Column<DateTime>(name: "Pmt_ Discount Date", type: "datetime", nullable: false),
                    ShipmentMethodCode = table.Column<string>(name: "Shipment Method Code", maxLength: 10, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    CustomerPostingGroup = table.Column<string>(name: "Customer Posting Group", maxLength: 20, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    CurrencyFactor = table.Column<decimal>(name: "Currency Factor", type: "decimal(38, 20)", nullable: false),
                    CustomerPriceGroup = table.Column<string>(name: "Customer Price Group", maxLength: 10, nullable: false),
                    PricesIncludingVAT = table.Column<byte>(name: "Prices Including VAT", nullable: false),
                    InvoiceDisc_Code = table.Column<string>(name: "Invoice Disc_ Code", maxLength: 20, nullable: false),
                    CustomerDisc_Group = table.Column<string>(name: "Customer Disc_ Group", maxLength: 20, nullable: false),
                    LanguageCode = table.Column<string>(name: "Language Code", maxLength: 10, nullable: false),
                    SalespersonCode = table.Column<string>(name: "Salesperson Code", maxLength: 20, nullable: false),
                    OrderNo_ = table.Column<string>(name: "Order No_", maxLength: 20, nullable: false),
                    No_Printed = table.Column<int>(name: "No_ Printed", nullable: false),
                    OnHold = table.Column<string>(name: "On Hold", maxLength: 3, nullable: false),
                    AppliestoDoc_Type = table.Column<int>(name: "Applies-to Doc_ Type", nullable: false),
                    AppliestoDoc_No_ = table.Column<string>(name: "Applies-to Doc_ No_", maxLength: 20, nullable: false),
                    Bal_AccountNo_ = table.Column<string>(name: "Bal_ Account No_", maxLength: 20, nullable: false),
                    VATRegistrationNo_ = table.Column<string>(name: "VAT Registration No_", maxLength: 20, nullable: false),
                    ReasonCode = table.Column<string>(name: "Reason Code", maxLength: 10, nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    EU3PartyTrade = table.Column<byte>(name: "EU 3-Party Trade", nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", maxLength: 10, nullable: false),
                    TransportMethod = table.Column<string>(name: "Transport Method", maxLength: 10, nullable: false),
                    VATCountry_RegionCode = table.Column<string>(name: "VAT Country_Region Code", maxLength: 10, nullable: false),
                    SelltoCustomerName = table.Column<string>(name: "Sell-to Customer Name", maxLength: 50, nullable: false),
                    SelltoCustomerName2 = table.Column<string>(name: "Sell-to Customer Name 2", maxLength: 50, nullable: false),
                    SelltoAddress = table.Column<string>(name: "Sell-to Address", maxLength: 50, nullable: false),
                    SelltoAddress2 = table.Column<string>(name: "Sell-to Address 2", maxLength: 50, nullable: false),
                    SelltoCity = table.Column<string>(name: "Sell-to City", maxLength: 30, nullable: false),
                    SelltoContact = table.Column<string>(name: "Sell-to Contact", maxLength: 50, nullable: false),
                    BilltoPostCode = table.Column<string>(name: "Bill-to Post Code", maxLength: 20, nullable: false),
                    BilltoCounty = table.Column<string>(name: "Bill-to County", maxLength: 30, nullable: false),
                    BilltoCountry_RegionCode = table.Column<string>(name: "Bill-to Country_Region Code", maxLength: 10, nullable: false),
                    SelltoPostCode = table.Column<string>(name: "Sell-to Post Code", maxLength: 20, nullable: false),
                    SelltoCounty = table.Column<string>(name: "Sell-to County", maxLength: 30, nullable: false),
                    SelltoCountry_RegionCode = table.Column<string>(name: "Sell-to Country_Region Code", maxLength: 10, nullable: false),
                    ShiptoPostCode = table.Column<string>(name: "Ship-to Post Code", maxLength: 20, nullable: false),
                    ShiptoCounty = table.Column<string>(name: "Ship-to County", maxLength: 30, nullable: false),
                    ShiptoCountry_RegionCode = table.Column<string>(name: "Ship-to Country_Region Code", maxLength: 10, nullable: false),
                    Bal_AccountType = table.Column<int>(name: "Bal_ Account Type", nullable: false),
                    ExitPoint = table.Column<string>(name: "Exit Point", maxLength: 10, nullable: false),
                    Correction = table.Column<byte>(nullable: false),
                    DocumentDate = table.Column<DateTime>(name: "Document Date", type: "datetime", nullable: false),
                    ExternalDocumentNo_ = table.Column<string>(name: "External Document No_", maxLength: 35, nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: false),
                    TransactionSpecification = table.Column<string>(name: "Transaction Specification", maxLength: 10, nullable: false),
                    PaymentMethodCode = table.Column<string>(name: "Payment Method Code", maxLength: 10, nullable: false),
                    ShippingAgentCode = table.Column<string>(name: "Shipping Agent Code", maxLength: 10, nullable: false),
                    PackageTrackingNo_ = table.Column<string>(name: "Package Tracking No_", maxLength: 30, nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    OrderNo_Series = table.Column<string>(name: "Order No_ Series", maxLength: 20, nullable: false),
                    UserID = table.Column<string>(name: "User ID", maxLength: 50, nullable: false),
                    SourceCode = table.Column<string>(name: "Source Code", maxLength: 10, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    VATBaseDiscount_ = table.Column<decimal>(name: "VAT Base Discount _", type: "decimal(38, 20)", nullable: false),
                    QuoteNo_ = table.Column<string>(name: "Quote No_", maxLength: 20, nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    CampaignNo_ = table.Column<string>(name: "Campaign No_", maxLength: 20, nullable: false),
                    SelltoContactNo_ = table.Column<string>(name: "Sell-to Contact No_", maxLength: 20, nullable: false),
                    BilltoContactNo_ = table.Column<string>(name: "Bill-to Contact No_", maxLength: 20, nullable: false),
                    OpportunityNo_ = table.Column<string>(name: "Opportunity No_", maxLength: 20, nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    RequestedDeliveryDate = table.Column<DateTime>(name: "Requested Delivery Date", type: "datetime", nullable: false),
                    PromisedDeliveryDate = table.Column<DateTime>(name: "Promised Delivery Date", type: "datetime", nullable: false),
                    ShippingTime = table.Column<string>(name: "Shipping Time", unicode: false, maxLength: 32, nullable: false),
                    OutboundWhse_HandlingTime = table.Column<string>(name: "Outbound Whse_ Handling Time", unicode: false, maxLength: 32, nullable: false),
                    ShippingAgentServiceCode = table.Column<string>(name: "Shipping Agent Service Code", maxLength: 10, nullable: false),
                    AllowLineDisc_ = table.Column<byte>(name: "Allow Line Disc_", nullable: false),
                    StoreNo_ = table.Column<string>(name: "Store No_", maxLength: 10, nullable: false),
                    RetailStatus = table.Column<int>(name: "Retail Status", nullable: false),
                    Reciving_PickingNo_ = table.Column<string>(name: "Reciving_Picking No_", maxLength: 20, nullable: false),
                    StatementNo_ = table.Column<string>(name: "Statement No_", maxLength: 20, nullable: false),
                    MemberCardNo_ = table.Column<string>(name: "Member Card No_", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales Shipment Header", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Sales Shipment Line",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DocumentNo_ = table.Column<string>(name: "Document No_", maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    SelltoCustomerNo_ = table.Column<string>(name: "Sell-to Customer No_", maxLength: 20, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    PostingGroup = table.Column<string>(name: "Posting Group", maxLength: 20, nullable: false),
                    ShipmentDate = table.Column<DateTime>(name: "Shipment Date", type: "datetime", nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Description2 = table.Column<string>(name: "Description 2", maxLength: 50, nullable: false),
                    UnitofMeasure = table.Column<string>(name: "Unit of Measure", maxLength: 10, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    UnitPrice = table.Column<decimal>(name: "Unit Price", type: "decimal(38, 20)", nullable: false),
                    UnitCostLCY = table.Column<decimal>(name: "Unit Cost (LCY)", type: "decimal(38, 20)", nullable: false),
                    VAT_ = table.Column<decimal>(name: "VAT _", type: "decimal(38, 20)", nullable: false),
                    LineDiscount_ = table.Column<decimal>(name: "Line Discount _", type: "decimal(38, 20)", nullable: false),
                    AllowInvoiceDisc_ = table.Column<byte>(name: "Allow Invoice Disc_", nullable: false),
                    GrossWeight = table.Column<decimal>(name: "Gross Weight", type: "decimal(38, 20)", nullable: false),
                    NetWeight = table.Column<decimal>(name: "Net Weight", type: "decimal(38, 20)", nullable: false),
                    UnitsperParcel = table.Column<decimal>(name: "Units per Parcel", type: "decimal(38, 20)", nullable: false),
                    UnitVolume = table.Column<decimal>(name: "Unit Volume", type: "decimal(38, 20)", nullable: false),
                    Appl_toItemEntry = table.Column<int>(name: "Appl_-to Item Entry", nullable: false),
                    ItemShpt_EntryNo_ = table.Column<int>(name: "Item Shpt_ Entry No_", nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    CustomerPriceGroup = table.Column<string>(name: "Customer Price Group", maxLength: 10, nullable: false),
                    JobNo_ = table.Column<string>(name: "Job No_", maxLength: 20, nullable: false),
                    WorkTypeCode = table.Column<string>(name: "Work Type Code", maxLength: 10, nullable: false),
                    Qty_ShippedNotInvoiced = table.Column<decimal>(name: "Qty_ Shipped Not Invoiced", type: "decimal(38, 20)", nullable: false),
                    QuantityInvoiced = table.Column<decimal>(name: "Quantity Invoiced", type: "decimal(38, 20)", nullable: false),
                    OrderNo_ = table.Column<string>(name: "Order No_", maxLength: 20, nullable: false),
                    OrderLineNo_ = table.Column<int>(name: "Order Line No_", nullable: false),
                    BilltoCustomerNo_ = table.Column<string>(name: "Bill-to Customer No_", maxLength: 20, nullable: false),
                    PurchaseOrderNo_ = table.Column<string>(name: "Purchase Order No_", maxLength: 20, nullable: false),
                    Purch_OrderLineNo_ = table.Column<int>(name: "Purch_ Order Line No_", nullable: false),
                    DropShipment = table.Column<byte>(name: "Drop Shipment", nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    Gen_Prod_PostingGroup = table.Column<string>(name: "Gen_ Prod_ Posting Group", maxLength: 20, nullable: false),
                    VATCalculationType = table.Column<int>(name: "VAT Calculation Type", nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", maxLength: 10, nullable: false),
                    TransportMethod = table.Column<string>(name: "Transport Method", maxLength: 10, nullable: false),
                    AttachedtoLineNo_ = table.Column<int>(name: "Attached to Line No_", nullable: false),
                    ExitPoint = table.Column<string>(name: "Exit Point", maxLength: 10, nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: false),
                    TransactionSpecification = table.Column<string>(name: "Transaction Specification", maxLength: 10, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    TaxGroupCode = table.Column<string>(name: "Tax Group Code", maxLength: 20, nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    VATProd_PostingGroup = table.Column<string>(name: "VAT Prod_ Posting Group", maxLength: 20, nullable: false),
                    BlanketOrderNo_ = table.Column<string>(name: "Blanket Order No_", maxLength: 20, nullable: false),
                    BlanketOrderLineNo_ = table.Column<int>(name: "Blanket Order Line No_", nullable: false),
                    VATBaseAmount = table.Column<decimal>(name: "VAT Base Amount", type: "decimal(38, 20)", nullable: false),
                    UnitCost = table.Column<decimal>(name: "Unit Cost", type: "decimal(38, 20)", nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    AuthorizedforCreditCard = table.Column<byte>(name: "Authorized for Credit Card", nullable: false),
                    JobTaskNo_ = table.Column<string>(name: "Job Task No_", maxLength: 20, nullable: false),
                    JobContractEntryNo_ = table.Column<int>(name: "Job Contract Entry No_", nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    BinCode = table.Column<string>(name: "Bin Code", maxLength: 20, nullable: false),
                    Qty_perUnitofMeasure = table.Column<decimal>(name: "Qty_ per Unit of Measure", type: "decimal(38, 20)", nullable: false),
                    UnitofMeasureCode = table.Column<string>(name: "Unit of Measure Code", maxLength: 10, nullable: false),
                    QuantityBase = table.Column<decimal>(name: "Quantity (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_InvoicedBase = table.Column<decimal>(name: "Qty_ Invoiced (Base)", type: "decimal(38, 20)", nullable: false),
                    FAPostingDate = table.Column<DateTime>(name: "FA Posting Date", type: "datetime", nullable: false),
                    DepreciationBookCode = table.Column<string>(name: "Depreciation Book Code", maxLength: 10, nullable: false),
                    Depr_untilFAPostingDate = table.Column<byte>(name: "Depr_ until FA Posting Date", nullable: false),
                    DuplicateinDepreciationBook = table.Column<string>(name: "Duplicate in Depreciation Book", maxLength: 10, nullable: false),
                    UseDuplicationList = table.Column<byte>(name: "Use Duplication List", nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    CrossReferenceNo_ = table.Column<string>(name: "Cross-Reference No_", maxLength: 20, nullable: false),
                    UnitofMeasureCrossRef_ = table.Column<string>(name: "Unit of Measure (Cross Ref_)", maxLength: 10, nullable: false),
                    CrossReferenceType = table.Column<int>(name: "Cross-Reference Type", nullable: false),
                    CrossReferenceTypeNo_ = table.Column<string>(name: "Cross-Reference Type No_", maxLength: 30, nullable: false),
                    ItemCategoryCode = table.Column<string>(name: "Item Category Code", maxLength: 20, nullable: false),
                    Nonstock = table.Column<byte>(nullable: false),
                    PurchasingCode = table.Column<string>(name: "Purchasing Code", maxLength: 10, nullable: false),
                    ProductGroupCode = table.Column<string>(name: "Product Group Code", maxLength: 10, nullable: false),
                    RequestedDeliveryDate = table.Column<DateTime>(name: "Requested Delivery Date", type: "datetime", nullable: false),
                    PromisedDeliveryDate = table.Column<DateTime>(name: "Promised Delivery Date", type: "datetime", nullable: false),
                    ShippingTime = table.Column<string>(name: "Shipping Time", unicode: false, maxLength: 32, nullable: false),
                    OutboundWhse_HandlingTime = table.Column<string>(name: "Outbound Whse_ Handling Time", unicode: false, maxLength: 32, nullable: false),
                    PlannedDeliveryDate = table.Column<DateTime>(name: "Planned Delivery Date", type: "datetime", nullable: false),
                    PlannedShipmentDate = table.Column<DateTime>(name: "Planned Shipment Date", type: "datetime", nullable: false),
                    Appl_fromItemEntry = table.Column<int>(name: "Appl_-from Item Entry", nullable: false),
                    ItemChargeBaseAmount = table.Column<decimal>(name: "Item Charge Base Amount", type: "decimal(38, 20)", nullable: false),
                    Correction = table.Column<byte>(nullable: false),
                    ReturnReasonCode = table.Column<string>(name: "Return Reason Code", maxLength: 10, nullable: false),
                    AllowLineDisc_ = table.Column<byte>(name: "Allow Line Disc_", nullable: false),
                    CustomerDisc_Group = table.Column<string>(name: "Customer Disc_ Group", maxLength: 20, nullable: false),
                    VendorNo_ = table.Column<string>(name: "Vendor No_", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales Shipment Line", x => new { x.DocumentNo_, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Sales Statistics",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    StoreNo_ = table.Column<string>(name: "Store No_", maxLength: 10, nullable: false),
                    EntryNo_ = table.Column<int>(name: "Entry No_", nullable: false),
                    Code = table.Column<string>(maxLength: 20, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    Time = table.Column<DateTime>(type: "datetime", nullable: false),
                    ItemsSold = table.Column<decimal>(name: "Items Sold", type: "decimal(38, 20)", nullable: false),
                    ItemsScanned = table.Column<decimal>(name: "Items Scanned", type: "decimal(38, 20)", nullable: false),
                    No_ofDepartmentSales = table.Column<decimal>(name: "No_ of Department Sales", type: "decimal(38, 20)", nullable: false),
                    No_ofReturns = table.Column<decimal>(name: "No_ of Returns", type: "decimal(38, 20)", nullable: false),
                    VoidedAmount = table.Column<decimal>(name: "Voided Amount", type: "decimal(38, 20)", nullable: false),
                    SalesAmount = table.Column<decimal>(name: "Sales Amount", type: "decimal(38, 20)", nullable: false),
                    VATAmount = table.Column<decimal>(name: "VAT Amount", type: "decimal(38, 20)", nullable: false),
                    CostAmount = table.Column<decimal>(name: "Cost Amount", type: "decimal(38, 20)", nullable: false),
                    DiscountAmount = table.Column<decimal>(name: "Discount Amount", type: "decimal(38, 20)", nullable: false),
                    No_ofSalesTrans_Entries = table.Column<decimal>(name: "No_ of Sales Trans_ Entries", type: "decimal(38, 20)", nullable: false),
                    TotalDiscount = table.Column<decimal>(name: "Total Discount", type: "decimal(38, 20)", nullable: false),
                    Add_Curr_SalesAmount = table.Column<decimal>(name: "Add_-Curr_ Sales Amount", type: "decimal(38, 20)", nullable: false),
                    Add_Curr_VatAmount = table.Column<decimal>(name: "Add_-Curr_ Vat Amount", type: "decimal(38, 20)", nullable: false),
                    Add_Curr_CostAmount = table.Column<decimal>(name: "Add_-Curr_ Cost Amount", type: "decimal(38, 20)", nullable: false),
                    Add_CurrDiscountAmount = table.Column<decimal>(name: "Add_-Curr Discount Amount", type: "decimal(38, 20)", nullable: false),
                    Add_CurrTotalDiscount = table.Column<decimal>(name: "Add_-Curr Total Discount", type: "decimal(38, 20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Sales Statistics", x => new { x.StoreNo_, x.EntryNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Service Bookings",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    EntryNo_ = table.Column<int>(name: "Entry No_", nullable: false)
                        .Annotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    StartingTime = table.Column<DateTime>(name: "Starting Time", type: "datetime", nullable: false),
                    EndingTime = table.Column<DateTime>(name: "Ending Time", type: "datetime", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    Volume = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    Capacity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    StoreNo_ = table.Column<string>(name: "Store No_", maxLength: 10, nullable: false),
                    ServiceProductNo_ = table.Column<string>(name: "Service Product No_", maxLength: 20, nullable: false),
                    SalesOrderNo_ = table.Column<string>(name: "Sales Order No_", maxLength: 20, nullable: false),
                    TimeSlotNo_ = table.Column<int>(name: "Time Slot No_", nullable: false),
                    Canceled = table.Column<byte>(nullable: false),
                    ReservationID = table.Column<int>(name: "Reservation ID", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Bookings", x => x.EntryNo_);
                });

            migrationBuilder.CreateTable(
                name: "Service Contract Header",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    ContractType = table.Column<int>(name: "Contract Type", nullable: false),
                    ContractNo_ = table.Column<string>(name: "Contract No_", maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Description2 = table.Column<string>(name: "Description 2", maxLength: 50, nullable: false),
                    Status = table.Column<int>(nullable: false),
                    ChangeStatus = table.Column<int>(name: "Change Status", nullable: false),
                    CustomerNo_ = table.Column<string>(name: "Customer No_", maxLength: 20, nullable: false),
                    ContactName = table.Column<string>(name: "Contact Name", maxLength: 50, nullable: false),
                    YourReference = table.Column<string>(name: "Your Reference", maxLength: 35, nullable: false),
                    SalespersonCode = table.Column<string>(name: "Salesperson Code", maxLength: 20, nullable: false),
                    BilltoCustomerNo_ = table.Column<string>(name: "Bill-to Customer No_", maxLength: 20, nullable: false),
                    ShiptoCode = table.Column<string>(name: "Ship-to Code", maxLength: 10, nullable: false),
                    Serv_ContractAcc_Gr_Code = table.Column<string>(name: "Serv_ Contract Acc_ Gr_ Code", maxLength: 10, nullable: false),
                    InvoicePeriod = table.Column<int>(name: "Invoice Period", nullable: false),
                    LastInvoiceDate = table.Column<DateTime>(name: "Last Invoice Date", type: "datetime", nullable: false),
                    NextInvoiceDate = table.Column<DateTime>(name: "Next Invoice Date", type: "datetime", nullable: false),
                    StartingDate = table.Column<DateTime>(name: "Starting Date", type: "datetime", nullable: false),
                    ExpirationDate = table.Column<DateTime>(name: "Expiration Date", type: "datetime", nullable: false),
                    FirstServiceDate = table.Column<DateTime>(name: "First Service Date", type: "datetime", nullable: false),
                    Max_LaborUnitPrice = table.Column<decimal>(name: "Max_ Labor Unit Price", type: "decimal(38, 20)", nullable: false),
                    AnnualAmount = table.Column<decimal>(name: "Annual Amount", type: "decimal(38, 20)", nullable: false),
                    AmountperPeriod = table.Column<decimal>(name: "Amount per Period", type: "decimal(38, 20)", nullable: false),
                    CombineInvoices = table.Column<byte>(name: "Combine Invoices", nullable: false),
                    Prepaid = table.Column<byte>(nullable: false),
                    NextInvoicePeriod = table.Column<string>(name: "Next Invoice Period", maxLength: 30, nullable: false),
                    ServiceZoneCode = table.Column<string>(name: "Service Zone Code", maxLength: 10, nullable: false),
                    LanguageCode = table.Column<string>(name: "Language Code", maxLength: 10, nullable: false),
                    CancelReasonCode = table.Column<string>(name: "Cancel Reason Code", maxLength: 10, nullable: false),
                    LastPriceUpdateDate = table.Column<DateTime>(name: "Last Price Update Date", type: "datetime", nullable: false),
                    NextPriceUpdateDate = table.Column<DateTime>(name: "Next Price Update Date", type: "datetime", nullable: false),
                    LastPriceUpdate_ = table.Column<decimal>(name: "Last Price Update _", type: "decimal(38, 20)", nullable: false),
                    ResponseTimeHours = table.Column<decimal>(name: "Response Time (Hours)", type: "decimal(38, 20)", nullable: false),
                    ContractLinesonInvoice = table.Column<byte>(name: "Contract Lines on Invoice", nullable: false),
                    ServicePeriod = table.Column<string>(name: "Service Period", unicode: false, maxLength: 32, nullable: false),
                    PaymentTermsCode = table.Column<string>(name: "Payment Terms Code", maxLength: 10, nullable: false),
                    InvoiceafterService = table.Column<byte>(name: "Invoice after Service", nullable: false),
                    QuoteType = table.Column<int>(name: "Quote Type", nullable: false),
                    AllowUnbalancedAmounts = table.Column<byte>(name: "Allow Unbalanced Amounts", nullable: false),
                    ContractGroupCode = table.Column<string>(name: "Contract Group Code", maxLength: 10, nullable: false),
                    ServiceOrderType = table.Column<string>(name: "Service Order Type", maxLength: 10, nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    AcceptBefore = table.Column<DateTime>(name: "Accept Before", type: "datetime", nullable: false),
                    AutomaticCreditMemos = table.Column<byte>(name: "Automatic Credit Memos", nullable: false),
                    TemplateNo_ = table.Column<string>(name: "Template No_", maxLength: 20, nullable: false),
                    PriceUpdatePeriod = table.Column<string>(name: "Price Update Period", unicode: false, maxLength: 32, nullable: false),
                    PriceInv_IncreaseCode = table.Column<string>(name: "Price Inv_ Increase Code", maxLength: 20, nullable: false),
                    PrintIncreaseText = table.Column<byte>(name: "Print Increase Text", nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    Probability = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    PhoneNo_ = table.Column<string>(name: "Phone No_", maxLength: 30, nullable: false),
                    FaxNo_ = table.Column<string>(name: "Fax No_", maxLength: 30, nullable: false),
                    EMail = table.Column<string>(name: "E-Mail", maxLength: 80, nullable: false),
                    NextInvoicePeriodStart = table.Column<DateTime>(name: "Next Invoice Period Start", type: "datetime", nullable: false),
                    NextInvoicePeriodEnd = table.Column<DateTime>(name: "Next Invoice Period End", type: "datetime", nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    ContactNo_ = table.Column<string>(name: "Contact No_", maxLength: 20, nullable: false),
                    BilltoContactNo_ = table.Column<string>(name: "Bill-to Contact No_", maxLength: 20, nullable: false),
                    BilltoContact = table.Column<string>(name: "Bill-to Contact", maxLength: 50, nullable: false),
                    LastInvoicePeriodEnd = table.Column<DateTime>(name: "Last Invoice Period End", type: "datetime", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Contract Header", x => new { x.ContractType, x.ContractNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Service Contract Line",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    ContractType = table.Column<int>(name: "Contract Type", nullable: false),
                    ContractNo_ = table.Column<string>(name: "Contract No_", maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    ContractStatus = table.Column<int>(name: "Contract Status", nullable: false),
                    ServiceItemNo_ = table.Column<string>(name: "Service Item No_", maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    SerialNo_ = table.Column<string>(name: "Serial No_", maxLength: 20, nullable: false),
                    ServiceItemGroupCode = table.Column<string>(name: "Service Item Group Code", maxLength: 10, nullable: false),
                    CustomerNo_ = table.Column<string>(name: "Customer No_", maxLength: 20, nullable: false),
                    ShiptoCode = table.Column<string>(name: "Ship-to Code", maxLength: 10, nullable: false),
                    ItemNo_ = table.Column<string>(name: "Item No_", maxLength: 20, nullable: false),
                    UnitofMeasureCode = table.Column<string>(name: "Unit of Measure Code", maxLength: 10, nullable: false),
                    ResponseTimeHours = table.Column<decimal>(name: "Response Time (Hours)", type: "decimal(38, 20)", nullable: false),
                    LastPlannedServiceDate = table.Column<DateTime>(name: "Last Planned Service Date", type: "datetime", nullable: false),
                    NextPlannedServiceDate = table.Column<DateTime>(name: "Next Planned Service Date", type: "datetime", nullable: false),
                    LastServiceDate = table.Column<DateTime>(name: "Last Service Date", type: "datetime", nullable: false),
                    LastPreventiveMaint_Date = table.Column<DateTime>(name: "Last Preventive Maint_ Date", type: "datetime", nullable: false),
                    InvoicedtoDate = table.Column<DateTime>(name: "Invoiced to Date", type: "datetime", nullable: false),
                    CreditMemoDate = table.Column<DateTime>(name: "Credit Memo Date", type: "datetime", nullable: false),
                    ContractExpirationDate = table.Column<DateTime>(name: "Contract Expiration Date", type: "datetime", nullable: false),
                    ServicePeriod = table.Column<string>(name: "Service Period", unicode: false, maxLength: 32, nullable: false),
                    LineValue = table.Column<decimal>(name: "Line Value", type: "decimal(38, 20)", nullable: false),
                    LineDiscount_ = table.Column<decimal>(name: "Line Discount _", type: "decimal(38, 20)", nullable: false),
                    LineAmount = table.Column<decimal>(name: "Line Amount", type: "decimal(38, 20)", nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    StartingDate = table.Column<DateTime>(name: "Starting Date", type: "datetime", nullable: false),
                    NewLine = table.Column<byte>(name: "New Line", nullable: false),
                    Credited = table.Column<byte>(nullable: false),
                    LineCost = table.Column<decimal>(name: "Line Cost", type: "decimal(38, 20)", nullable: false),
                    LineDiscountAmount = table.Column<decimal>(name: "Line Discount Amount", type: "decimal(38, 20)", nullable: false),
                    Profit = table.Column<decimal>(type: "decimal(38, 20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Contract Line", x => new { x.ContractType, x.ContractNo_, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Service Header",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DocumentType = table.Column<int>(name: "Document Type", nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    CustomerNo_ = table.Column<string>(name: "Customer No_", maxLength: 20, nullable: false),
                    BilltoCustomerNo_ = table.Column<string>(name: "Bill-to Customer No_", maxLength: 20, nullable: false),
                    BilltoName = table.Column<string>(name: "Bill-to Name", maxLength: 50, nullable: false),
                    BilltoName2 = table.Column<string>(name: "Bill-to Name 2", maxLength: 50, nullable: false),
                    BilltoAddress = table.Column<string>(name: "Bill-to Address", maxLength: 50, nullable: false),
                    BilltoAddress2 = table.Column<string>(name: "Bill-to Address 2", maxLength: 50, nullable: false),
                    BilltoCity = table.Column<string>(name: "Bill-to City", maxLength: 30, nullable: false),
                    BilltoContact = table.Column<string>(name: "Bill-to Contact", maxLength: 50, nullable: false),
                    YourReference = table.Column<string>(name: "Your Reference", maxLength: 35, nullable: false),
                    ShiptoCode = table.Column<string>(name: "Ship-to Code", maxLength: 10, nullable: false),
                    ShiptoName = table.Column<string>(name: "Ship-to Name", maxLength: 50, nullable: false),
                    ShiptoName2 = table.Column<string>(name: "Ship-to Name 2", maxLength: 50, nullable: false),
                    ShiptoAddress = table.Column<string>(name: "Ship-to Address", maxLength: 50, nullable: false),
                    ShiptoAddress2 = table.Column<string>(name: "Ship-to Address 2", maxLength: 50, nullable: false),
                    ShiptoCity = table.Column<string>(name: "Ship-to City", maxLength: 30, nullable: false),
                    ShiptoContact = table.Column<string>(name: "Ship-to Contact", maxLength: 50, nullable: false),
                    OrderDate = table.Column<DateTime>(name: "Order Date", type: "datetime", nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    PostingDescription = table.Column<string>(name: "Posting Description", maxLength: 50, nullable: false),
                    PaymentTermsCode = table.Column<string>(name: "Payment Terms Code", maxLength: 10, nullable: false),
                    DueDate = table.Column<DateTime>(name: "Due Date", type: "datetime", nullable: false),
                    PaymentDiscount_ = table.Column<decimal>(name: "Payment Discount _", type: "decimal(38, 20)", nullable: false),
                    Pmt_DiscountDate = table.Column<DateTime>(name: "Pmt_ Discount Date", type: "datetime", nullable: false),
                    ShipmentMethodCode = table.Column<string>(name: "Shipment Method Code", maxLength: 10, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    CustomerPostingGroup = table.Column<string>(name: "Customer Posting Group", maxLength: 20, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    CurrencyFactor = table.Column<decimal>(name: "Currency Factor", type: "decimal(38, 20)", nullable: false),
                    CustomerPriceGroup = table.Column<string>(name: "Customer Price Group", maxLength: 10, nullable: false),
                    PricesIncludingVAT = table.Column<byte>(name: "Prices Including VAT", nullable: false),
                    InvoiceDisc_Code = table.Column<string>(name: "Invoice Disc_ Code", maxLength: 20, nullable: false),
                    CustomerDisc_Group = table.Column<string>(name: "Customer Disc_ Group", maxLength: 20, nullable: false),
                    LanguageCode = table.Column<string>(name: "Language Code", maxLength: 10, nullable: false),
                    SalespersonCode = table.Column<string>(name: "Salesperson Code", maxLength: 20, nullable: false),
                    No_Printed = table.Column<int>(name: "No_ Printed", nullable: false),
                    AppliestoDoc_Type = table.Column<int>(name: "Applies-to Doc_ Type", nullable: false),
                    AppliestoDoc_No_ = table.Column<string>(name: "Applies-to Doc_ No_", maxLength: 20, nullable: false),
                    Bal_AccountNo_ = table.Column<string>(name: "Bal_ Account No_", maxLength: 20, nullable: false),
                    ShippingNo_ = table.Column<string>(name: "Shipping No_", maxLength: 20, nullable: false),
                    PostingNo_ = table.Column<string>(name: "Posting No_", maxLength: 20, nullable: false),
                    LastShippingNo_ = table.Column<string>(name: "Last Shipping No_", maxLength: 20, nullable: false),
                    LastPostingNo_ = table.Column<string>(name: "Last Posting No_", maxLength: 20, nullable: false),
                    VATRegistrationNo_ = table.Column<string>(name: "VAT Registration No_", maxLength: 20, nullable: false),
                    ReasonCode = table.Column<string>(name: "Reason Code", maxLength: 10, nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    EU3PartyTrade = table.Column<byte>(name: "EU 3-Party Trade", nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", maxLength: 10, nullable: false),
                    TransportMethod = table.Column<string>(name: "Transport Method", maxLength: 10, nullable: false),
                    VATCountry_RegionCode = table.Column<string>(name: "VAT Country_Region Code", maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Name2 = table.Column<string>(name: "Name 2", maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    Address2 = table.Column<string>(name: "Address 2", maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 30, nullable: false),
                    ContactName = table.Column<string>(name: "Contact Name", maxLength: 50, nullable: false),
                    BilltoPostCode = table.Column<string>(name: "Bill-to Post Code", maxLength: 20, nullable: false),
                    BilltoCounty = table.Column<string>(name: "Bill-to County", maxLength: 30, nullable: false),
                    BilltoCountry_RegionCode = table.Column<string>(name: "Bill-to Country_Region Code", maxLength: 10, nullable: false),
                    PostCode = table.Column<string>(name: "Post Code", maxLength: 20, nullable: false),
                    County = table.Column<string>(maxLength: 30, nullable: false),
                    Country_RegionCode = table.Column<string>(name: "Country_Region Code", maxLength: 10, nullable: false),
                    ShiptoPostCode = table.Column<string>(name: "Ship-to Post Code", maxLength: 20, nullable: false),
                    ShiptoCounty = table.Column<string>(name: "Ship-to County", maxLength: 30, nullable: false),
                    ShiptoCountry_RegionCode = table.Column<string>(name: "Ship-to Country_Region Code", maxLength: 10, nullable: false),
                    Bal_AccountType = table.Column<int>(name: "Bal_ Account Type", nullable: false),
                    ExitPoint = table.Column<string>(name: "Exit Point", maxLength: 10, nullable: false),
                    Correction = table.Column<byte>(nullable: false),
                    DocumentDate = table.Column<DateTime>(name: "Document Date", type: "datetime", nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: false),
                    TransactionSpecification = table.Column<string>(name: "Transaction Specification", maxLength: 10, nullable: false),
                    PaymentMethodCode = table.Column<string>(name: "Payment Method Code", maxLength: 10, nullable: false),
                    ShippingAgentCode = table.Column<string>(name: "Shipping Agent Code", maxLength: 10, nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    PostingNo_Series = table.Column<string>(name: "Posting No_ Series", maxLength: 20, nullable: false),
                    ShippingNo_Series = table.Column<string>(name: "Shipping No_ Series", maxLength: 20, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    Reserve = table.Column<int>(nullable: false),
                    AppliestoID = table.Column<string>(name: "Applies-to ID", maxLength: 50, nullable: false),
                    VATBaseDiscount_ = table.Column<decimal>(name: "VAT Base Discount _", type: "decimal(38, 20)", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    InvoiceDiscountCalculation = table.Column<int>(name: "Invoice Discount Calculation", nullable: false),
                    InvoiceDiscountValue = table.Column<decimal>(name: "Invoice Discount Value", type: "decimal(38, 20)", nullable: false),
                    ReleaseStatus = table.Column<int>(name: "Release Status", nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    ContactNo_ = table.Column<string>(name: "Contact No_", maxLength: 20, nullable: false),
                    BilltoContactNo_ = table.Column<string>(name: "Bill-to Contact No_", maxLength: 20, nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    ShippingAdvice = table.Column<int>(name: "Shipping Advice", nullable: false),
                    ShippingTime = table.Column<string>(name: "Shipping Time", unicode: false, maxLength: 32, nullable: false),
                    ShippingAgentServiceCode = table.Column<string>(name: "Shipping Agent Service Code", maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    ServiceOrderType = table.Column<string>(name: "Service Order Type", maxLength: 10, nullable: false),
                    LinkServicetoServiceItem = table.Column<byte>(name: "Link Service to Service Item", nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    PhoneNo_ = table.Column<string>(name: "Phone No_", maxLength: 30, nullable: false),
                    EMail = table.Column<string>(name: "E-Mail", maxLength: 80, nullable: false),
                    PhoneNo_2 = table.Column<string>(name: "Phone No_ 2", maxLength: 30, nullable: false),
                    FaxNo_ = table.Column<string>(name: "Fax No_", maxLength: 30, nullable: false),
                    OrderTime = table.Column<DateTime>(name: "Order Time", type: "datetime", nullable: false),
                    DefaultResponseTimeHours = table.Column<decimal>(name: "Default Response Time (Hours)", type: "decimal(38, 20)", nullable: false),
                    ActualResponseTimeHours = table.Column<decimal>(name: "Actual Response Time (Hours)", type: "decimal(38, 20)", nullable: false),
                    ServiceTimeHours = table.Column<decimal>(name: "Service Time (Hours)", type: "decimal(38, 20)", nullable: false),
                    ResponseDate = table.Column<DateTime>(name: "Response Date", type: "datetime", nullable: false),
                    ResponseTime = table.Column<DateTime>(name: "Response Time", type: "datetime", nullable: false),
                    StartingDate = table.Column<DateTime>(name: "Starting Date", type: "datetime", nullable: false),
                    StartingTime = table.Column<DateTime>(name: "Starting Time", type: "datetime", nullable: false),
                    FinishingDate = table.Column<DateTime>(name: "Finishing Date", type: "datetime", nullable: false),
                    FinishingTime = table.Column<DateTime>(name: "Finishing Time", type: "datetime", nullable: false),
                    NotifyCustomer = table.Column<int>(name: "Notify Customer", nullable: false),
                    Max_LaborUnitPrice = table.Column<decimal>(name: "Max_ Labor Unit Price", type: "decimal(38, 20)", nullable: false),
                    WarningStatus = table.Column<int>(name: "Warning Status", nullable: false),
                    ContractNo_ = table.Column<string>(name: "Contract No_", maxLength: 20, nullable: false),
                    ShiptoFaxNo_ = table.Column<string>(name: "Ship-to Fax No_", maxLength: 30, nullable: false),
                    ShiptoEMail = table.Column<string>(name: "Ship-to E-Mail", maxLength: 80, nullable: false),
                    ShiptoPhone = table.Column<string>(name: "Ship-to Phone", maxLength: 30, nullable: false),
                    ShiptoPhone2 = table.Column<string>(name: "Ship-to Phone 2", maxLength: 30, nullable: false),
                    ServiceZoneCode = table.Column<string>(name: "Service Zone Code", maxLength: 10, nullable: false),
                    ExpectedFinishingDate = table.Column<DateTime>(name: "Expected Finishing Date", type: "datetime", nullable: false),
                    AllowLineDisc_ = table.Column<byte>(name: "Allow Line Disc_", nullable: false),
                    AssignedUserID = table.Column<string>(name: "Assigned User ID", maxLength: 50, nullable: false),
                    QuoteNo_ = table.Column<string>(name: "Quote No_", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Header", x => new { x.DocumentType, x.No_ });
                });

            migrationBuilder.CreateTable(
                name: "Service Invoice Header",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    CustomerNo_ = table.Column<string>(name: "Customer No_", maxLength: 20, nullable: false),
                    BilltoCustomerNo_ = table.Column<string>(name: "Bill-to Customer No_", maxLength: 20, nullable: false),
                    BilltoName = table.Column<string>(name: "Bill-to Name", maxLength: 50, nullable: false),
                    BilltoName2 = table.Column<string>(name: "Bill-to Name 2", maxLength: 50, nullable: false),
                    BilltoAddress = table.Column<string>(name: "Bill-to Address", maxLength: 50, nullable: false),
                    BilltoAddress2 = table.Column<string>(name: "Bill-to Address 2", maxLength: 50, nullable: false),
                    BilltoCity = table.Column<string>(name: "Bill-to City", maxLength: 30, nullable: false),
                    BilltoContact = table.Column<string>(name: "Bill-to Contact", maxLength: 50, nullable: false),
                    YourReference = table.Column<string>(name: "Your Reference", maxLength: 35, nullable: false),
                    ShiptoCode = table.Column<string>(name: "Ship-to Code", maxLength: 10, nullable: false),
                    ShiptoName = table.Column<string>(name: "Ship-to Name", maxLength: 50, nullable: false),
                    ShiptoName2 = table.Column<string>(name: "Ship-to Name 2", maxLength: 50, nullable: false),
                    ShiptoAddress = table.Column<string>(name: "Ship-to Address", maxLength: 50, nullable: false),
                    ShiptoAddress2 = table.Column<string>(name: "Ship-to Address 2", maxLength: 50, nullable: false),
                    ShiptoCity = table.Column<string>(name: "Ship-to City", maxLength: 30, nullable: false),
                    ShiptoContact = table.Column<string>(name: "Ship-to Contact", maxLength: 50, nullable: false),
                    OrderDate = table.Column<DateTime>(name: "Order Date", type: "datetime", nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    PostingDescription = table.Column<string>(name: "Posting Description", maxLength: 50, nullable: false),
                    PaymentTermsCode = table.Column<string>(name: "Payment Terms Code", maxLength: 10, nullable: false),
                    DueDate = table.Column<DateTime>(name: "Due Date", type: "datetime", nullable: false),
                    PaymentDiscount_ = table.Column<decimal>(name: "Payment Discount _", type: "decimal(38, 20)", nullable: false),
                    Pmt_DiscountDate = table.Column<DateTime>(name: "Pmt_ Discount Date", type: "datetime", nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    CustomerPostingGroup = table.Column<string>(name: "Customer Posting Group", maxLength: 20, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    CurrencyFactor = table.Column<decimal>(name: "Currency Factor", type: "decimal(38, 20)", nullable: false),
                    CustomerPriceGroup = table.Column<string>(name: "Customer Price Group", maxLength: 10, nullable: false),
                    PricesIncludingVAT = table.Column<byte>(name: "Prices Including VAT", nullable: false),
                    InvoiceDisc_Code = table.Column<string>(name: "Invoice Disc_ Code", maxLength: 20, nullable: false),
                    CustomerDisc_Group = table.Column<string>(name: "Customer Disc_ Group", maxLength: 20, nullable: false),
                    LanguageCode = table.Column<string>(name: "Language Code", maxLength: 10, nullable: false),
                    SalespersonCode = table.Column<string>(name: "Salesperson Code", maxLength: 20, nullable: false),
                    OrderNo_ = table.Column<string>(name: "Order No_", maxLength: 20, nullable: false),
                    No_Printed = table.Column<int>(name: "No_ Printed", nullable: false),
                    AppliestoDoc_Type = table.Column<int>(name: "Applies-to Doc_ Type", nullable: false),
                    AppliestoDoc_No_ = table.Column<string>(name: "Applies-to Doc_ No_", maxLength: 20, nullable: false),
                    Bal_AccountNo_ = table.Column<string>(name: "Bal_ Account No_", maxLength: 20, nullable: false),
                    ShippingNo_ = table.Column<string>(name: "Shipping No_", maxLength: 20, nullable: false),
                    PostingNo_ = table.Column<string>(name: "Posting No_", maxLength: 20, nullable: false),
                    LastShippingNo_ = table.Column<string>(name: "Last Shipping No_", maxLength: 20, nullable: false),
                    LastPostingNo_ = table.Column<string>(name: "Last Posting No_", maxLength: 20, nullable: false),
                    VATRegistrationNo_ = table.Column<string>(name: "VAT Registration No_", maxLength: 20, nullable: false),
                    ReasonCode = table.Column<string>(name: "Reason Code", maxLength: 10, nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    EU3PartyTrade = table.Column<byte>(name: "EU 3-Party Trade", nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", maxLength: 10, nullable: false),
                    TransportMethod = table.Column<string>(name: "Transport Method", maxLength: 10, nullable: false),
                    VATCountry_RegionCode = table.Column<string>(name: "VAT Country_Region Code", maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    Name2 = table.Column<string>(name: "Name 2", maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    Address2 = table.Column<string>(name: "Address 2", maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 30, nullable: false),
                    ContactName = table.Column<string>(name: "Contact Name", maxLength: 50, nullable: false),
                    BilltoPostCode = table.Column<string>(name: "Bill-to Post Code", maxLength: 20, nullable: false),
                    BilltoCounty = table.Column<string>(name: "Bill-to County", maxLength: 30, nullable: false),
                    BilltoCountry_RegionCode = table.Column<string>(name: "Bill-to Country_Region Code", maxLength: 10, nullable: false),
                    PostCode = table.Column<string>(name: "Post Code", maxLength: 20, nullable: false),
                    County = table.Column<string>(maxLength: 30, nullable: false),
                    Country_RegionCode = table.Column<string>(name: "Country_Region Code", maxLength: 10, nullable: false),
                    ShiptoPostCode = table.Column<string>(name: "Ship-to Post Code", maxLength: 20, nullable: false),
                    ShiptoCounty = table.Column<string>(name: "Ship-to County", maxLength: 30, nullable: false),
                    ShiptoCountry_RegionCode = table.Column<string>(name: "Ship-to Country_Region Code", maxLength: 10, nullable: false),
                    Bal_AccountType = table.Column<int>(name: "Bal_ Account Type", nullable: false),
                    ExitPoint = table.Column<string>(name: "Exit Point", maxLength: 10, nullable: false),
                    Correction = table.Column<byte>(nullable: false),
                    DocumentDate = table.Column<DateTime>(name: "Document Date", type: "datetime", nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: false),
                    TransactionSpecification = table.Column<string>(name: "Transaction Specification", maxLength: 10, nullable: false),
                    PaymentMethodCode = table.Column<string>(name: "Payment Method Code", maxLength: 10, nullable: false),
                    PreAssignedNo_Series = table.Column<string>(name: "Pre-Assigned No_ Series", maxLength: 20, nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    ShippingNo_Series = table.Column<string>(name: "Shipping No_ Series", maxLength: 20, nullable: false),
                    OrderNo_Series = table.Column<string>(name: "Order No_ Series", maxLength: 20, nullable: false),
                    PreAssignedNo_ = table.Column<string>(name: "Pre-Assigned No_", maxLength: 20, nullable: false),
                    UserID = table.Column<string>(name: "User ID", maxLength: 50, nullable: false),
                    SourceCode = table.Column<string>(name: "Source Code", maxLength: 10, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    VATBaseDiscount_ = table.Column<decimal>(name: "VAT Base Discount _", type: "decimal(38, 20)", nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    DocumentExchangeIdentifier = table.Column<string>(name: "Document Exchange Identifier", maxLength: 50, nullable: false),
                    DocumentExchangeStatus = table.Column<int>(name: "Document Exchange Status", nullable: false),
                    Doc_Exch_OriginalIdentifier = table.Column<string>(name: "Doc_ Exch_ Original Identifier", maxLength: 50, nullable: false),
                    ContactNo_ = table.Column<string>(name: "Contact No_", maxLength: 20, nullable: false),
                    BilltoContactNo_ = table.Column<string>(name: "Bill-to Contact No_", maxLength: 20, nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    ServiceOrderType = table.Column<string>(name: "Service Order Type", maxLength: 10, nullable: false),
                    LinkServicetoServiceItem = table.Column<byte>(name: "Link Service to Service Item", nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    PhoneNo_ = table.Column<string>(name: "Phone No_", maxLength: 30, nullable: false),
                    EMail = table.Column<string>(name: "E-Mail", maxLength: 80, nullable: false),
                    PhoneNo_2 = table.Column<string>(name: "Phone No_ 2", maxLength: 30, nullable: false),
                    FaxNo_ = table.Column<string>(name: "Fax No_", maxLength: 30, nullable: false),
                    OrderTime = table.Column<DateTime>(name: "Order Time", type: "datetime", nullable: false),
                    DefaultResponseTimeHours = table.Column<decimal>(name: "Default Response Time (Hours)", type: "decimal(38, 20)", nullable: false),
                    ActualResponseTimeHours = table.Column<decimal>(name: "Actual Response Time (Hours)", type: "decimal(38, 20)", nullable: false),
                    ServiceTimeHours = table.Column<decimal>(name: "Service Time (Hours)", type: "decimal(38, 20)", nullable: false),
                    ResponseDate = table.Column<DateTime>(name: "Response Date", type: "datetime", nullable: false),
                    ResponseTime = table.Column<DateTime>(name: "Response Time", type: "datetime", nullable: false),
                    StartingDate = table.Column<DateTime>(name: "Starting Date", type: "datetime", nullable: false),
                    StartingTime = table.Column<DateTime>(name: "Starting Time", type: "datetime", nullable: false),
                    FinishingDate = table.Column<DateTime>(name: "Finishing Date", type: "datetime", nullable: false),
                    FinishingTime = table.Column<DateTime>(name: "Finishing Time", type: "datetime", nullable: false),
                    NotifyCustomer = table.Column<int>(name: "Notify Customer", nullable: false),
                    Max_LaborUnitPrice = table.Column<decimal>(name: "Max_ Labor Unit Price", type: "decimal(38, 20)", nullable: false),
                    WarningStatus = table.Column<int>(name: "Warning Status", nullable: false),
                    ContractNo_ = table.Column<string>(name: "Contract No_", maxLength: 20, nullable: false),
                    ShiptoFaxNo_ = table.Column<string>(name: "Ship-to Fax No_", maxLength: 30, nullable: false),
                    ShiptoEMail = table.Column<string>(name: "Ship-to E-Mail", maxLength: 80, nullable: false),
                    ShiptoPhone = table.Column<string>(name: "Ship-to Phone", maxLength: 30, nullable: false),
                    ShiptoPhone2 = table.Column<string>(name: "Ship-to Phone 2", maxLength: 30, nullable: false),
                    ServiceZoneCode = table.Column<string>(name: "Service Zone Code", maxLength: 10, nullable: false),
                    ExpectedFinishingDate = table.Column<DateTime>(name: "Expected Finishing Date", type: "datetime", nullable: false),
                    AllowLineDisc_ = table.Column<byte>(name: "Allow Line Disc_", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Invoice Header", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Service Invoice Line",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DocumentNo_ = table.Column<string>(name: "Document No_", maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    CustomerNo_ = table.Column<string>(name: "Customer No_", maxLength: 20, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    PostingGroup = table.Column<string>(name: "Posting Group", maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Description2 = table.Column<string>(name: "Description 2", maxLength: 50, nullable: false),
                    UnitofMeasure = table.Column<string>(name: "Unit of Measure", maxLength: 10, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    UnitPrice = table.Column<decimal>(name: "Unit Price", type: "decimal(38, 20)", nullable: false),
                    UnitCostLCY = table.Column<decimal>(name: "Unit Cost (LCY)", type: "decimal(38, 20)", nullable: false),
                    VAT_ = table.Column<decimal>(name: "VAT _", type: "decimal(38, 20)", nullable: false),
                    LineDiscount_ = table.Column<decimal>(name: "Line Discount _", type: "decimal(38, 20)", nullable: false),
                    LineDiscountAmount = table.Column<decimal>(name: "Line Discount Amount", type: "decimal(38, 20)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    AmountIncludingVAT = table.Column<decimal>(name: "Amount Including VAT", type: "decimal(38, 20)", nullable: false),
                    AllowInvoiceDisc_ = table.Column<byte>(name: "Allow Invoice Disc_", nullable: false),
                    GrossWeight = table.Column<decimal>(name: "Gross Weight", type: "decimal(38, 20)", nullable: false),
                    NetWeight = table.Column<decimal>(name: "Net Weight", type: "decimal(38, 20)", nullable: false),
                    UnitsperParcel = table.Column<decimal>(name: "Units per Parcel", type: "decimal(38, 20)", nullable: false),
                    UnitVolume = table.Column<decimal>(name: "Unit Volume", type: "decimal(38, 20)", nullable: false),
                    Appl_toItemEntry = table.Column<int>(name: "Appl_-to Item Entry", nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    CustomerPriceGroup = table.Column<string>(name: "Customer Price Group", maxLength: 10, nullable: false),
                    WorkTypeCode = table.Column<string>(name: "Work Type Code", maxLength: 10, nullable: false),
                    ShipmentNo_ = table.Column<string>(name: "Shipment No_", maxLength: 20, nullable: false),
                    ShipmentLineNo_ = table.Column<int>(name: "Shipment Line No_", nullable: false),
                    BilltoCustomerNo_ = table.Column<string>(name: "Bill-to Customer No_", maxLength: 20, nullable: false),
                    Inv_DiscountAmount = table.Column<decimal>(name: "Inv_ Discount Amount", type: "decimal(38, 20)", nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    Gen_Prod_PostingGroup = table.Column<string>(name: "Gen_ Prod_ Posting Group", maxLength: 20, nullable: false),
                    VATCalculationType = table.Column<int>(name: "VAT Calculation Type", nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", maxLength: 10, nullable: false),
                    TransportMethod = table.Column<string>(name: "Transport Method", maxLength: 10, nullable: false),
                    AttachedtoLineNo_ = table.Column<int>(name: "Attached to Line No_", nullable: false),
                    ExitPoint = table.Column<string>(name: "Exit Point", maxLength: 10, nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: false),
                    TransactionSpecification = table.Column<string>(name: "Transaction Specification", maxLength: 10, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    TaxGroupCode = table.Column<string>(name: "Tax Group Code", maxLength: 20, nullable: false),
                    VATClauseCode = table.Column<string>(name: "VAT Clause Code", maxLength: 20, nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    VATProd_PostingGroup = table.Column<string>(name: "VAT Prod_ Posting Group", maxLength: 20, nullable: false),
                    VATBaseAmount = table.Column<decimal>(name: "VAT Base Amount", type: "decimal(38, 20)", nullable: false),
                    SystemCreatedEntry = table.Column<byte>(name: "System-Created Entry", nullable: false),
                    LineAmount = table.Column<decimal>(name: "Line Amount", type: "decimal(38, 20)", nullable: false),
                    VATDifference = table.Column<decimal>(name: "VAT Difference", type: "decimal(38, 20)", nullable: false),
                    VATIdentifier = table.Column<string>(name: "VAT Identifier", maxLength: 20, nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    BinCode = table.Column<string>(name: "Bin Code", maxLength: 20, nullable: false),
                    Qty_perUnitofMeasure = table.Column<decimal>(name: "Qty_ per Unit of Measure", type: "decimal(38, 20)", nullable: false),
                    UnitofMeasureCode = table.Column<string>(name: "Unit of Measure Code", maxLength: 10, nullable: false),
                    QuantityBase = table.Column<decimal>(name: "Quantity (Base)", type: "decimal(38, 20)", nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    SubstitutionAvailable = table.Column<byte>(name: "Substitution Available", nullable: false),
                    ItemCategoryCode = table.Column<string>(name: "Item Category Code", maxLength: 20, nullable: false),
                    Nonstock = table.Column<byte>(nullable: false),
                    ProductGroupCode = table.Column<string>(name: "Product Group Code", maxLength: 10, nullable: false),
                    ServiceItemNo_ = table.Column<string>(name: "Service Item No_", maxLength: 20, nullable: false),
                    Appl_toServiceEntry = table.Column<int>(name: "Appl_-to Service Entry", nullable: false),
                    ServiceItemLineNo_ = table.Column<int>(name: "Service Item Line No_", nullable: false),
                    ServiceItemSerialNo_ = table.Column<string>(name: "Service Item Serial No_", maxLength: 20, nullable: false),
                    ServiceItemLineDescription = table.Column<string>(name: "Service Item Line Description", maxLength: 50, nullable: false),
                    Serv_PriceAdjmt_Gr_Code = table.Column<string>(name: "Serv_ Price Adjmt_ Gr_ Code", maxLength: 10, nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    NeededbyDate = table.Column<DateTime>(name: "Needed by Date", type: "datetime", nullable: false),
                    ShiptoCode = table.Column<string>(name: "Ship-to Code", maxLength: 10, nullable: false),
                    QuantityConsumed = table.Column<decimal>(name: "Quantity Consumed", type: "decimal(38, 20)", nullable: false),
                    Qty_ConsumedBase = table.Column<decimal>(name: "Qty_ Consumed (Base)", type: "decimal(38, 20)", nullable: false),
                    ServicePriceGroupCode = table.Column<string>(name: "Service Price Group Code", maxLength: 10, nullable: false),
                    FaultAreaCode = table.Column<string>(name: "Fault Area Code", maxLength: 10, nullable: false),
                    SymptomCode = table.Column<string>(name: "Symptom Code", maxLength: 10, nullable: false),
                    FaultCode = table.Column<string>(name: "Fault Code", maxLength: 10, nullable: false),
                    ResolutionCode = table.Column<string>(name: "Resolution Code", maxLength: 10, nullable: false),
                    ExcludeWarranty = table.Column<byte>(name: "Exclude Warranty", nullable: false),
                    Warranty = table.Column<byte>(nullable: false),
                    ContractNo_ = table.Column<string>(name: "Contract No_", maxLength: 20, nullable: false),
                    ContractDisc__ = table.Column<decimal>(name: "Contract Disc_ _", type: "decimal(38, 20)", nullable: false),
                    WarrantyDisc__ = table.Column<decimal>(name: "Warranty Disc_ _", type: "decimal(38, 20)", nullable: false),
                    ComponentLineNo_ = table.Column<int>(name: "Component Line No_", nullable: false),
                    SparePartAction = table.Column<int>(name: "Spare Part Action", nullable: false),
                    FaultReasonCode = table.Column<string>(name: "Fault Reason Code", maxLength: 10, nullable: false),
                    ReplacedItemNo_ = table.Column<string>(name: "Replaced Item No_", maxLength: 20, nullable: false),
                    ExcludeContractDiscount = table.Column<byte>(name: "Exclude Contract Discount", nullable: false),
                    ReplacedItemType = table.Column<int>(name: "Replaced Item Type", nullable: false),
                    PriceAdjmt_Status = table.Column<int>(name: "Price Adjmt_ Status", nullable: false),
                    LineDiscountType = table.Column<int>(name: "Line Discount Type", nullable: false),
                    CopyComponentsFrom = table.Column<int>(name: "Copy Components From", nullable: false),
                    ReturnReasonCode = table.Column<string>(name: "Return Reason Code", maxLength: 10, nullable: false),
                    AllowLineDisc_ = table.Column<byte>(name: "Allow Line Disc_", nullable: false),
                    CustomerDisc_Group = table.Column<string>(name: "Customer Disc_ Group", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Invoice Line", x => new { x.DocumentNo_, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Service Item",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    SerialNo_ = table.Column<string>(name: "Serial No_", maxLength: 20, nullable: false),
                    ServiceItemGroupCode = table.Column<string>(name: "Service Item Group Code", maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Description2 = table.Column<string>(name: "Description 2", maxLength: 50, nullable: false),
                    Status = table.Column<int>(nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    CustomerNo_ = table.Column<string>(name: "Customer No_", maxLength: 20, nullable: false),
                    ShiptoCode = table.Column<string>(name: "Ship-to Code", maxLength: 10, nullable: false),
                    ItemNo_ = table.Column<string>(name: "Item No_", maxLength: 20, nullable: false),
                    UnitofMeasureCode = table.Column<string>(name: "Unit of Measure Code", maxLength: 10, nullable: false),
                    LocationofServiceItem = table.Column<string>(name: "Location of Service Item", maxLength: 30, nullable: false),
                    SalesUnitPrice = table.Column<decimal>(name: "Sales Unit Price", type: "decimal(38, 20)", nullable: false),
                    SalesUnitCost = table.Column<decimal>(name: "Sales Unit Cost", type: "decimal(38, 20)", nullable: false),
                    WarrantyStartingDateLabor = table.Column<DateTime>(name: "Warranty Starting Date (Labor)", type: "datetime", nullable: false),
                    WarrantyEndingDateLabor = table.Column<DateTime>(name: "Warranty Ending Date (Labor)", type: "datetime", nullable: false),
                    WarrantyStartingDateParts = table.Column<DateTime>(name: "Warranty Starting Date (Parts)", type: "datetime", nullable: false),
                    WarrantyEndingDateParts = table.Column<DateTime>(name: "Warranty Ending Date (Parts)", type: "datetime", nullable: false),
                    Warranty_Parts = table.Column<decimal>(name: "Warranty _ (Parts)", type: "decimal(38, 20)", nullable: false),
                    Warranty_Labor = table.Column<decimal>(name: "Warranty _ (Labor)", type: "decimal(38, 20)", nullable: false),
                    ResponseTimeHours = table.Column<decimal>(name: "Response Time (Hours)", type: "decimal(38, 20)", nullable: false),
                    InstallationDate = table.Column<DateTime>(name: "Installation Date", type: "datetime", nullable: false),
                    SalesDate = table.Column<DateTime>(name: "Sales Date", type: "datetime", nullable: false),
                    LastServiceDate = table.Column<DateTime>(name: "Last Service Date", type: "datetime", nullable: false),
                    DefaultContractValue = table.Column<decimal>(name: "Default Contract Value", type: "decimal(38, 20)", nullable: false),
                    DefaultContractDiscount_ = table.Column<decimal>(name: "Default Contract Discount _", type: "decimal(38, 20)", nullable: false),
                    VendorNo_ = table.Column<string>(name: "Vendor No_", maxLength: 20, nullable: false),
                    VendorItemNo_ = table.Column<string>(name: "Vendor Item No_", maxLength: 20, nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    VendorItemName = table.Column<string>(name: "Vendor Item Name", maxLength: 50, nullable: false),
                    PreferredResource = table.Column<string>(name: "Preferred Resource", maxLength: 20, nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    ServicePriceGroupCode = table.Column<string>(name: "Service Price Group Code", maxLength: 10, nullable: false),
                    DefaultContractCost = table.Column<decimal>(name: "Default Contract Cost", type: "decimal(38, 20)", nullable: false),
                    SearchDescription = table.Column<string>(name: "Search Description", maxLength: 50, nullable: false),
                    Sales_Serv_Shpt_DocumentNo_ = table.Column<string>(name: "Sales_Serv_ Shpt_ Document No_", maxLength: 20, nullable: false),
                    Sales_Serv_Shpt_LineNo_ = table.Column<int>(name: "Sales_Serv_ Shpt_ Line No_", nullable: false),
                    ShipmentType = table.Column<int>(name: "Shipment Type", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Item", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Service Item Line",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DocumentType = table.Column<int>(name: "Document Type", nullable: false),
                    DocumentNo_ = table.Column<string>(name: "Document No_", maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    ServiceItemNo_ = table.Column<string>(name: "Service Item No_", maxLength: 20, nullable: false),
                    ServiceItemGroupCode = table.Column<string>(name: "Service Item Group Code", maxLength: 10, nullable: false),
                    ItemNo_ = table.Column<string>(name: "Item No_", maxLength: 20, nullable: false),
                    SerialNo_ = table.Column<string>(name: "Serial No_", maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Description2 = table.Column<string>(name: "Description 2", maxLength: 50, nullable: false),
                    RepairStatusCode = table.Column<string>(name: "Repair Status Code", maxLength: 10, nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    ResponseTimeHours = table.Column<decimal>(name: "Response Time (Hours)", type: "decimal(38, 20)", nullable: false),
                    ResponseDate = table.Column<DateTime>(name: "Response Date", type: "datetime", nullable: false),
                    ResponseTime = table.Column<DateTime>(name: "Response Time", type: "datetime", nullable: false),
                    StartingDate = table.Column<DateTime>(name: "Starting Date", type: "datetime", nullable: false),
                    StartingTime = table.Column<DateTime>(name: "Starting Time", type: "datetime", nullable: false),
                    FinishingDate = table.Column<DateTime>(name: "Finishing Date", type: "datetime", nullable: false),
                    FinishingTime = table.Column<DateTime>(name: "Finishing Time", type: "datetime", nullable: false),
                    ServiceShelfNo_ = table.Column<string>(name: "Service Shelf No_", maxLength: 10, nullable: false),
                    WarrantyStartingDateParts = table.Column<DateTime>(name: "Warranty Starting Date (Parts)", type: "datetime", nullable: false),
                    WarrantyEndingDateParts = table.Column<DateTime>(name: "Warranty Ending Date (Parts)", type: "datetime", nullable: false),
                    Warranty = table.Column<byte>(nullable: false),
                    Warranty_Parts = table.Column<decimal>(name: "Warranty _ (Parts)", type: "decimal(38, 20)", nullable: false),
                    Warranty_Labor = table.Column<decimal>(name: "Warranty _ (Labor)", type: "decimal(38, 20)", nullable: false),
                    WarrantyStartingDateLabor = table.Column<DateTime>(name: "Warranty Starting Date (Labor)", type: "datetime", nullable: false),
                    WarrantyEndingDateLabor = table.Column<DateTime>(name: "Warranty Ending Date (Labor)", type: "datetime", nullable: false),
                    ContractNo_ = table.Column<string>(name: "Contract No_", maxLength: 20, nullable: false),
                    LoanerNo_ = table.Column<string>(name: "Loaner No_", maxLength: 20, nullable: false),
                    VendorNo_ = table.Column<string>(name: "Vendor No_", maxLength: 20, nullable: false),
                    VendorItemNo_ = table.Column<string>(name: "Vendor Item No_", maxLength: 20, nullable: false),
                    FaultReasonCode = table.Column<string>(name: "Fault Reason Code", maxLength: 10, nullable: false),
                    ServicePriceGroupCode = table.Column<string>(name: "Service Price Group Code", maxLength: 10, nullable: false),
                    FaultAreaCode = table.Column<string>(name: "Fault Area Code", maxLength: 10, nullable: false),
                    SymptomCode = table.Column<string>(name: "Symptom Code", maxLength: 10, nullable: false),
                    FaultCode = table.Column<string>(name: "Fault Code", maxLength: 10, nullable: false),
                    ResolutionCode = table.Column<string>(name: "Resolution Code", maxLength: 10, nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    ActualResponseTimeHours = table.Column<decimal>(name: "Actual Response Time (Hours)", type: "decimal(38, 20)", nullable: false),
                    Serv_PriceAdjmt_Gr_Code = table.Column<string>(name: "Serv_ Price Adjmt_ Gr_ Code", maxLength: 10, nullable: false),
                    AdjustmentType = table.Column<int>(name: "Adjustment Type", nullable: false),
                    BaseAmounttoAdjust = table.Column<decimal>(name: "Base Amount to Adjust", type: "decimal(38, 20)", nullable: false),
                    ContractLineNo_ = table.Column<int>(name: "Contract Line No_", nullable: false),
                    ShiptoCode = table.Column<string>(name: "Ship-to Code", maxLength: 10, nullable: false),
                    CustomerNo_ = table.Column<string>(name: "Customer No_", maxLength: 20, nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    ReleaseStatus = table.Column<int>(name: "Release Status", nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Item Line", x => new { x.DocumentType, x.DocumentNo_, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Service Ledger Entry",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    EntryNo_ = table.Column<int>(name: "Entry No_", nullable: false),
                    ServiceContractNo_ = table.Column<string>(name: "Service Contract No_", maxLength: 20, nullable: false),
                    DocumentType = table.Column<int>(name: "Document Type", nullable: false),
                    DocumentNo_ = table.Column<string>(name: "Document No_", maxLength: 20, nullable: false),
                    Serv_ContractAcc_Gr_Code = table.Column<string>(name: "Serv_ Contract Acc_ Gr_ Code", maxLength: 10, nullable: false),
                    DocumentLineNo_ = table.Column<int>(name: "Document Line No_", nullable: false),
                    MovedfromPrepaidAcc_ = table.Column<byte>(name: "Moved from Prepaid Acc_", nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    AmountLCY = table.Column<decimal>(name: "Amount (LCY)", type: "decimal(38, 20)", nullable: false),
                    CustomerNo_ = table.Column<string>(name: "Customer No_", maxLength: 20, nullable: false),
                    ShiptoCode = table.Column<string>(name: "Ship-to Code", maxLength: 10, nullable: false),
                    ItemNo_Serviced = table.Column<string>(name: "Item No_ (Serviced)", maxLength: 20, nullable: false),
                    SerialNo_Serviced = table.Column<string>(name: "Serial No_ (Serviced)", maxLength: 20, nullable: false),
                    UserID = table.Column<string>(name: "User ID", maxLength: 50, nullable: false),
                    ContractInvoicePeriod = table.Column<string>(name: "Contract Invoice Period", maxLength: 30, nullable: false),
                    GlobalDimension1Code = table.Column<string>(name: "Global Dimension 1 Code", maxLength: 20, nullable: false),
                    GlobalDimension2Code = table.Column<string>(name: "Global Dimension 2 Code", maxLength: 20, nullable: false),
                    ServiceItemNo_Serviced = table.Column<string>(name: "Service Item No_ (Serviced)", maxLength: 20, nullable: false),
                    VariantCodeServiced = table.Column<string>(name: "Variant Code (Serviced)", maxLength: 10, nullable: false),
                    ContractGroupCode = table.Column<string>(name: "Contract Group Code", maxLength: 10, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    CostAmount = table.Column<decimal>(name: "Cost Amount", type: "decimal(38, 20)", nullable: false),
                    DiscountAmount = table.Column<decimal>(name: "Discount Amount", type: "decimal(38, 20)", nullable: false),
                    UnitCost = table.Column<decimal>(name: "Unit Cost", type: "decimal(38, 20)", nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    ChargedQty_ = table.Column<decimal>(name: "Charged Qty_", type: "decimal(38, 20)", nullable: false),
                    UnitPrice = table.Column<decimal>(name: "Unit Price", type: "decimal(38, 20)", nullable: false),
                    Discount_ = table.Column<decimal>(name: "Discount _", type: "decimal(38, 20)", nullable: false),
                    ContractDisc_Amount = table.Column<decimal>(name: "Contract Disc_ Amount", type: "decimal(38, 20)", nullable: false),
                    BilltoCustomerNo_ = table.Column<string>(name: "Bill-to Customer No_", maxLength: 20, nullable: false),
                    FaultReasonCode = table.Column<string>(name: "Fault Reason Code", maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    ServiceOrderType = table.Column<string>(name: "Service Order Type", maxLength: 10, nullable: false),
                    ServiceOrderNo_ = table.Column<string>(name: "Service Order No_", maxLength: 20, nullable: false),
                    JobNo_ = table.Column<string>(name: "Job No_", maxLength: 20, nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    Gen_Prod_PostingGroup = table.Column<string>(name: "Gen_ Prod_ Posting Group", maxLength: 20, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    UnitofMeasureCode = table.Column<string>(name: "Unit of Measure Code", maxLength: 10, nullable: false),
                    WorkTypeCode = table.Column<string>(name: "Work Type Code", maxLength: 10, nullable: false),
                    BinCode = table.Column<string>(name: "Bin Code", maxLength: 20, nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    EntryType = table.Column<int>(name: "Entry Type", nullable: false),
                    Open = table.Column<byte>(nullable: false),
                    Serv_PriceAdjmt_Gr_Code = table.Column<string>(name: "Serv_ Price Adjmt_ Gr_ Code", maxLength: 10, nullable: false),
                    ServicePriceGroupCode = table.Column<string>(name: "Service Price Group Code", maxLength: 10, nullable: false),
                    Prepaid = table.Column<byte>(nullable: false),
                    ApplyUntilEntryNo_ = table.Column<int>(name: "Apply Until Entry No_", nullable: false),
                    AppliestoEntryNo_ = table.Column<int>(name: "Applies-to Entry No_", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    JobTaskNo_ = table.Column<string>(name: "Job Task No_", maxLength: 20, nullable: false),
                    JobLineType = table.Column<int>(name: "Job Line Type", nullable: false),
                    JobPosted = table.Column<byte>(name: "Job Posted", nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Ledger Entry", x => x.EntryNo_);
                });

            migrationBuilder.CreateTable(
                name: "Service Line",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    DocumentType = table.Column<int>(name: "Document Type", nullable: false),
                    DocumentNo_ = table.Column<string>(name: "Document No_", maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    CustomerNo_ = table.Column<string>(name: "Customer No_", maxLength: 20, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    PostingGroup = table.Column<string>(name: "Posting Group", maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Description2 = table.Column<string>(name: "Description 2", maxLength: 50, nullable: false),
                    UnitofMeasure = table.Column<string>(name: "Unit of Measure", maxLength: 10, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    OutstandingQuantity = table.Column<decimal>(name: "Outstanding Quantity", type: "decimal(38, 20)", nullable: false),
                    Qty_toInvoice = table.Column<decimal>(name: "Qty_ to Invoice", type: "decimal(38, 20)", nullable: false),
                    Qty_toShip = table.Column<decimal>(name: "Qty_ to Ship", type: "decimal(38, 20)", nullable: false),
                    UnitPrice = table.Column<decimal>(name: "Unit Price", type: "decimal(38, 20)", nullable: false),
                    UnitCostLCY = table.Column<decimal>(name: "Unit Cost (LCY)", type: "decimal(38, 20)", nullable: false),
                    VAT_ = table.Column<decimal>(name: "VAT _", type: "decimal(38, 20)", nullable: false),
                    LineDiscount_ = table.Column<decimal>(name: "Line Discount _", type: "decimal(38, 20)", nullable: false),
                    LineDiscountAmount = table.Column<decimal>(name: "Line Discount Amount", type: "decimal(38, 20)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    AmountIncludingVAT = table.Column<decimal>(name: "Amount Including VAT", type: "decimal(38, 20)", nullable: false),
                    AllowInvoiceDisc_ = table.Column<byte>(name: "Allow Invoice Disc_", nullable: false),
                    GrossWeight = table.Column<decimal>(name: "Gross Weight", type: "decimal(38, 20)", nullable: false),
                    NetWeight = table.Column<decimal>(name: "Net Weight", type: "decimal(38, 20)", nullable: false),
                    UnitsperParcel = table.Column<decimal>(name: "Units per Parcel", type: "decimal(38, 20)", nullable: false),
                    UnitVolume = table.Column<decimal>(name: "Unit Volume", type: "decimal(38, 20)", nullable: false),
                    Appl_toItemEntry = table.Column<int>(name: "Appl_-to Item Entry", nullable: false),
                    ShortcutDimension1Code = table.Column<string>(name: "Shortcut Dimension 1 Code", maxLength: 20, nullable: false),
                    ShortcutDimension2Code = table.Column<string>(name: "Shortcut Dimension 2 Code", maxLength: 20, nullable: false),
                    CustomerPriceGroup = table.Column<string>(name: "Customer Price Group", maxLength: 10, nullable: false),
                    JobNo_ = table.Column<string>(name: "Job No_", maxLength: 20, nullable: false),
                    JobTaskNo_ = table.Column<string>(name: "Job Task No_", maxLength: 20, nullable: false),
                    JobLineType = table.Column<int>(name: "Job Line Type", nullable: false),
                    WorkTypeCode = table.Column<string>(name: "Work Type Code", maxLength: 10, nullable: false),
                    OutstandingAmount = table.Column<decimal>(name: "Outstanding Amount", type: "decimal(38, 20)", nullable: false),
                    Qty_ShippedNotInvoiced = table.Column<decimal>(name: "Qty_ Shipped Not Invoiced", type: "decimal(38, 20)", nullable: false),
                    ShippedNotInvoiced = table.Column<decimal>(name: "Shipped Not Invoiced", type: "decimal(38, 20)", nullable: false),
                    QuantityShipped = table.Column<decimal>(name: "Quantity Shipped", type: "decimal(38, 20)", nullable: false),
                    QuantityInvoiced = table.Column<decimal>(name: "Quantity Invoiced", type: "decimal(38, 20)", nullable: false),
                    ShipmentNo_ = table.Column<string>(name: "Shipment No_", maxLength: 20, nullable: false),
                    ShipmentLineNo_ = table.Column<int>(name: "Shipment Line No_", nullable: false),
                    BilltoCustomerNo_ = table.Column<string>(name: "Bill-to Customer No_", maxLength: 20, nullable: false),
                    Inv_DiscountAmount = table.Column<decimal>(name: "Inv_ Discount Amount", type: "decimal(38, 20)", nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    Gen_Prod_PostingGroup = table.Column<string>(name: "Gen_ Prod_ Posting Group", maxLength: 20, nullable: false),
                    VATCalculationType = table.Column<int>(name: "VAT Calculation Type", nullable: false),
                    TransactionType = table.Column<string>(name: "Transaction Type", maxLength: 10, nullable: false),
                    TransportMethod = table.Column<string>(name: "Transport Method", maxLength: 10, nullable: false),
                    AttachedtoLineNo_ = table.Column<int>(name: "Attached to Line No_", nullable: false),
                    ExitPoint = table.Column<string>(name: "Exit Point", maxLength: 10, nullable: false),
                    Area = table.Column<string>(maxLength: 10, nullable: false),
                    TransactionSpecification = table.Column<string>(name: "Transaction Specification", maxLength: 10, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    TaxGroupCode = table.Column<string>(name: "Tax Group Code", maxLength: 20, nullable: false),
                    VATClauseCode = table.Column<string>(name: "VAT Clause Code", maxLength: 20, nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    VATProd_PostingGroup = table.Column<string>(name: "VAT Prod_ Posting Group", maxLength: 20, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    OutstandingAmountLCY = table.Column<decimal>(name: "Outstanding Amount (LCY)", type: "decimal(38, 20)", nullable: false),
                    ShippedNotInvoicedLCY = table.Column<decimal>(name: "Shipped Not Invoiced (LCY)", type: "decimal(38, 20)", nullable: false),
                    Reserve = table.Column<int>(nullable: false),
                    VATBaseAmount = table.Column<decimal>(name: "VAT Base Amount", type: "decimal(38, 20)", nullable: false),
                    UnitCost = table.Column<decimal>(name: "Unit Cost", type: "decimal(38, 20)", nullable: false),
                    SystemCreatedEntry = table.Column<byte>(name: "System-Created Entry", nullable: false),
                    LineAmount = table.Column<decimal>(name: "Line Amount", type: "decimal(38, 20)", nullable: false),
                    VATDifference = table.Column<decimal>(name: "VAT Difference", type: "decimal(38, 20)", nullable: false),
                    Inv_Disc_AmounttoInvoice = table.Column<decimal>(name: "Inv_ Disc_ Amount to Invoice", type: "decimal(38, 20)", nullable: false),
                    VATIdentifier = table.Column<string>(name: "VAT Identifier", maxLength: 20, nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false),
                    TimeSheetNo_ = table.Column<string>(name: "Time Sheet No_", maxLength: 20, nullable: false),
                    TimeSheetLineNo_ = table.Column<int>(name: "Time Sheet Line No_", nullable: false),
                    TimeSheetDate = table.Column<DateTime>(name: "Time Sheet Date", type: "datetime", nullable: false),
                    JobPlanningLineNo_ = table.Column<int>(name: "Job Planning Line No_", nullable: false),
                    JobRemainingQty_ = table.Column<decimal>(name: "Job Remaining Qty_", type: "decimal(38, 20)", nullable: false),
                    JobRemainingQty_Base = table.Column<decimal>(name: "Job Remaining Qty_ (Base)", type: "decimal(38, 20)", nullable: false),
                    JobRemainingTotalCost = table.Column<decimal>(name: "Job Remaining Total Cost", type: "decimal(38, 20)", nullable: false),
                    JobRemainingTotalCostLCY = table.Column<decimal>(name: "Job Remaining Total Cost (LCY)", type: "decimal(38, 20)", nullable: false),
                    JobRemainingLineAmount = table.Column<decimal>(name: "Job Remaining Line Amount", type: "decimal(38, 20)", nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    BinCode = table.Column<string>(name: "Bin Code", maxLength: 20, nullable: false),
                    Qty_perUnitofMeasure = table.Column<decimal>(name: "Qty_ per Unit of Measure", type: "decimal(38, 20)", nullable: false),
                    Planned = table.Column<byte>(nullable: false),
                    UnitofMeasureCode = table.Column<string>(name: "Unit of Measure Code", maxLength: 10, nullable: false),
                    QuantityBase = table.Column<decimal>(name: "Quantity (Base)", type: "decimal(38, 20)", nullable: false),
                    OutstandingQty_Base = table.Column<decimal>(name: "Outstanding Qty_ (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_toInvoiceBase = table.Column<decimal>(name: "Qty_ to Invoice (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_toShipBase = table.Column<decimal>(name: "Qty_ to Ship (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_ShippedNotInvd_Base = table.Column<decimal>(name: "Qty_ Shipped Not Invd_ (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_ShippedBase = table.Column<decimal>(name: "Qty_ Shipped (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_InvoicedBase = table.Column<decimal>(name: "Qty_ Invoiced (Base)", type: "decimal(38, 20)", nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    ItemCategoryCode = table.Column<string>(name: "Item Category Code", maxLength: 20, nullable: false),
                    Nonstock = table.Column<byte>(nullable: false),
                    ProductGroupCode = table.Column<string>(name: "Product Group Code", maxLength: 10, nullable: false),
                    CompletelyShipped = table.Column<byte>(name: "Completely Shipped", nullable: false),
                    RequestedDeliveryDate = table.Column<DateTime>(name: "Requested Delivery Date", type: "datetime", nullable: false),
                    PromisedDeliveryDate = table.Column<DateTime>(name: "Promised Delivery Date", type: "datetime", nullable: false),
                    ShippingTime = table.Column<string>(name: "Shipping Time", unicode: false, maxLength: 32, nullable: false),
                    PlannedDeliveryDate = table.Column<DateTime>(name: "Planned Delivery Date", type: "datetime", nullable: false),
                    ShippingAgentCode = table.Column<string>(name: "Shipping Agent Code", maxLength: 10, nullable: false),
                    ShippingAgentServiceCode = table.Column<string>(name: "Shipping Agent Service Code", maxLength: 10, nullable: false),
                    Appl_fromItemEntry = table.Column<int>(name: "Appl_-from Item Entry", nullable: false),
                    ServiceItemNo_ = table.Column<string>(name: "Service Item No_", maxLength: 20, nullable: false),
                    Appl_toServiceEntry = table.Column<int>(name: "Appl_-to Service Entry", nullable: false),
                    ServiceItemLineNo_ = table.Column<int>(name: "Service Item Line No_", nullable: false),
                    ServiceItemSerialNo_ = table.Column<string>(name: "Service Item Serial No_", maxLength: 20, nullable: false),
                    Serv_PriceAdjmt_Gr_Code = table.Column<string>(name: "Serv_ Price Adjmt_ Gr_ Code", maxLength: 10, nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    OrderDate = table.Column<DateTime>(name: "Order Date", type: "datetime", nullable: false),
                    NeededbyDate = table.Column<DateTime>(name: "Needed by Date", type: "datetime", nullable: false),
                    ShiptoCode = table.Column<string>(name: "Ship-to Code", maxLength: 10, nullable: false),
                    Qty_toConsume = table.Column<decimal>(name: "Qty_ to Consume", type: "decimal(38, 20)", nullable: false),
                    QuantityConsumed = table.Column<decimal>(name: "Quantity Consumed", type: "decimal(38, 20)", nullable: false),
                    Qty_toConsumeBase = table.Column<decimal>(name: "Qty_ to Consume (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_ConsumedBase = table.Column<decimal>(name: "Qty_ Consumed (Base)", type: "decimal(38, 20)", nullable: false),
                    ServicePriceGroupCode = table.Column<string>(name: "Service Price Group Code", maxLength: 10, nullable: false),
                    FaultAreaCode = table.Column<string>(name: "Fault Area Code", maxLength: 10, nullable: false),
                    SymptomCode = table.Column<string>(name: "Symptom Code", maxLength: 10, nullable: false),
                    FaultCode = table.Column<string>(name: "Fault Code", maxLength: 10, nullable: false),
                    ResolutionCode = table.Column<string>(name: "Resolution Code", maxLength: 10, nullable: false),
                    ExcludeWarranty = table.Column<byte>(name: "Exclude Warranty", nullable: false),
                    Warranty = table.Column<byte>(nullable: false),
                    ContractNo_ = table.Column<string>(name: "Contract No_", maxLength: 20, nullable: false),
                    ContractDisc__ = table.Column<decimal>(name: "Contract Disc_ _", type: "decimal(38, 20)", nullable: false),
                    WarrantyDisc__ = table.Column<decimal>(name: "Warranty Disc_ _", type: "decimal(38, 20)", nullable: false),
                    ComponentLineNo_ = table.Column<int>(name: "Component Line No_", nullable: false),
                    SparePartAction = table.Column<int>(name: "Spare Part Action", nullable: false),
                    FaultReasonCode = table.Column<string>(name: "Fault Reason Code", maxLength: 10, nullable: false),
                    ReplacedItemNo_ = table.Column<string>(name: "Replaced Item No_", maxLength: 20, nullable: false),
                    ExcludeContractDiscount = table.Column<byte>(name: "Exclude Contract Discount", nullable: false),
                    ReplacedItemType = table.Column<int>(name: "Replaced Item Type", nullable: false),
                    PriceAdjmt_Status = table.Column<int>(name: "Price Adjmt_ Status", nullable: false),
                    LineDiscountType = table.Column<int>(name: "Line Discount Type", nullable: false),
                    CopyComponentsFrom = table.Column<int>(name: "Copy Components From", nullable: false),
                    ReturnReasonCode = table.Column<string>(name: "Return Reason Code", maxLength: 10, nullable: false),
                    AllowLineDisc_ = table.Column<byte>(name: "Allow Line Disc_", nullable: false),
                    CustomerDisc_Group = table.Column<string>(name: "Customer Disc_ Group", maxLength: 20, nullable: false),
                    Qty_Picked = table.Column<decimal>(name: "Qty_ Picked", type: "decimal(38, 20)", nullable: false),
                    Qty_PickedBase = table.Column<decimal>(name: "Qty_ Picked (Base)", type: "decimal(38, 20)", nullable: false),
                    CompletelyPicked = table.Column<byte>(name: "Completely Picked", nullable: false),
                    PickQty_Base = table.Column<decimal>(name: "Pick Qty_ (Base)", type: "decimal(38, 20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Line", x => new { x.DocumentType, x.DocumentNo_, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Service Order",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    ServiceItemNo_ = table.Column<string>(name: "Service Item No_", maxLength: 20, nullable: false),
                    TimeSlotNo_ = table.Column<int>(name: "Time Slot No_", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    StartingTime = table.Column<DateTime>(name: "Starting Time", type: "datetime", nullable: false),
                    EndingTime = table.Column<DateTime>(name: "Ending Time", type: "datetime", nullable: false),
                    ServiceProviderNo_ = table.Column<string>(name: "Service Provider No_", maxLength: 20, nullable: false),
                    ReservationID = table.Column<int>(name: "Reservation ID", nullable: false),
                    ServiceProductNo_ = table.Column<string>(name: "Service Product No_", maxLength: 20, nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 10, nullable: false),
                    RelatedDocumentNo_ = table.Column<string>(name: "Related Document No_", maxLength: 20, nullable: false),
                    RelatedDocumentLineNo_ = table.Column<int>(name: "Related Document Line No_", nullable: false),
                    RelatedPostedDocumentNo_ = table.Column<string>(name: "Related Posted Document No_", maxLength: 20, nullable: false),
                    RelatedPostedDoc_LineNo_ = table.Column<int>(name: "Related Posted Doc_ Line No_", nullable: false),
                    StoreNo_ = table.Column<string>(name: "Store No_", maxLength: 10, nullable: false),
                    ProcessinStoreNo_ = table.Column<string>(name: "Process in Store No_", maxLength: 10, nullable: false),
                    CapacityUnit = table.Column<string>(name: "Capacity Unit", maxLength: 10, nullable: false),
                    Capacity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    PriceCalc_Method = table.Column<string>(name: "Price Calc_ Method", maxLength: 10, nullable: false),
                    Price = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    PricePeriodNo_ = table.Column<int>(name: "Price Period No_", nullable: false),
                    ManualInputforPricing = table.Column<decimal>(name: "Manual Input for Pricing", type: "decimal(38, 20)", nullable: false),
                    PricingUnit = table.Column<string>(name: "Pricing Unit", maxLength: 10, nullable: false),
                    DeletedField50 = table.Column<string>(name: "Deleted Field 50", maxLength: 20, nullable: false),
                    DeletedField51 = table.Column<int>(name: "Deleted Field 51", nullable: false),
                    DeletedField52 = table.Column<string>(name: "Deleted Field 52", maxLength: 20, nullable: false),
                    DeletedField53 = table.Column<int>(name: "Deleted Field 53", nullable: false),
                    SourceDocumentisPosted = table.Column<byte>(name: "Source Document is Posted", nullable: false),
                    BookedDays = table.Column<int>(name: "Booked Days", nullable: false),
                    MultipleTimeSlots = table.Column<byte>(name: "Multiple Time Slots", nullable: false),
                    NumberofAdj_Packages = table.Column<decimal>(name: "Number of Adj_ Packages", type: "decimal(38, 20)", nullable: false),
                    RelatedDocumentType = table.Column<int>(name: "Related Document Type", nullable: false),
                    SalespersonCode = table.Column<string>(name: "Salesperson Code", maxLength: 10, nullable: false),
                    SalesChannel = table.Column<string>(name: "Sales Channel", maxLength: 10, nullable: false),
                    SalesChannelType = table.Column<int>(name: "Sales Channel Type", nullable: false),
                    OriginalSalesChannel = table.Column<string>(name: "Original Sales Channel", maxLength: 10, nullable: false),
                    OriginalSalesChannelType = table.Column<int>(name: "Original Sales Channel Type", nullable: false),
                    TriggeringFactorforFailing = table.Column<int>(name: "Triggering Factor for Failing", nullable: false),
                    ReasonCodeforFailing = table.Column<string>(name: "Reason Code for Failing", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Order", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Service Order Allocation",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    EntryNo_ = table.Column<int>(name: "Entry No_", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    DocumentNo_ = table.Column<string>(name: "Document No_", maxLength: 20, nullable: false),
                    AllocationDate = table.Column<DateTime>(name: "Allocation Date", type: "datetime", nullable: false),
                    ResourceNo_ = table.Column<string>(name: "Resource No_", maxLength: 20, nullable: false),
                    ResourceGroupNo_ = table.Column<string>(name: "Resource Group No_", maxLength: 20, nullable: false),
                    ServiceItemLineNo_ = table.Column<int>(name: "Service Item Line No_", nullable: false),
                    AllocatedHours = table.Column<decimal>(name: "Allocated Hours", type: "decimal(38, 20)", nullable: false),
                    StartingTime = table.Column<DateTime>(name: "Starting Time", type: "datetime", nullable: false),
                    FinishingTime = table.Column<DateTime>(name: "Finishing Time", type: "datetime", nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    ReasonCode = table.Column<string>(name: "Reason Code", maxLength: 10, nullable: false),
                    ServiceItemNo_ = table.Column<string>(name: "Service Item No_", maxLength: 20, nullable: false),
                    Posted = table.Column<byte>(nullable: false),
                    ServiceItemSerialNo_ = table.Column<string>(name: "Service Item Serial No_", maxLength: 20, nullable: false),
                    ServiceStarted = table.Column<byte>(name: "Service Started", nullable: false),
                    DocumentType = table.Column<int>(name: "Document Type", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Order Allocation", x => x.EntryNo_);
                });

            migrationBuilder.CreateTable(
                name: "Service Order Items",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    ServiceOrderNo_ = table.Column<string>(name: "Service Order No_", maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    ServiceItemNo_ = table.Column<string>(name: "Service Item No_", maxLength: 20, nullable: false),
                    ItemNo_ = table.Column<string>(name: "Item No_", maxLength: 20, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    RelatedDocumentLineNo_ = table.Column<int>(name: "Related Document Line No_", nullable: false),
                    TotalWeight = table.Column<decimal>(name: "Total Weight", type: "decimal(38, 20)", nullable: false),
                    TotalVolume = table.Column<decimal>(name: "Total Volume", type: "decimal(38, 20)", nullable: false),
                    TotalNumberofPackages = table.Column<decimal>(name: "Total Number of Packages", type: "decimal(38, 20)", nullable: false),
                    RelatedDocumentNo_ = table.Column<string>(name: "Related Document No_", maxLength: 20, nullable: false),
                    SalesOrderLineNo_ = table.Column<int>(name: "Sales Order Line No_", nullable: false),
                    Deletedfield25 = table.Column<string>(name: "Deleted field 25", maxLength: 20, nullable: false),
                    Deletedfield26 = table.Column<int>(name: "Deleted field 26", nullable: false),
                    ItemTransactionNo_ = table.Column<int>(name: "Item Transaction No_", nullable: false),
                    RelatedDocumentType = table.Column<int>(name: "Related Document Type", nullable: false),
                    ItemStoreNo_ = table.Column<string>(name: "Item Store No_", maxLength: 10, nullable: false),
                    ItemPOSTerminalNo_ = table.Column<string>(name: "Item POS Terminal No_", maxLength: 10, nullable: false),
                    ItemTrans_LineNo_ = table.Column<int>(name: "Item Trans_ Line No_", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Order Items", x => new { x.ServiceOrderNo_, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Service Order Status",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    ServiceOrderNo_ = table.Column<string>(name: "Service Order No_", maxLength: 20, nullable: false),
                    Status = table.Column<int>(nullable: false),
                    PreviousStatus = table.Column<int>(name: "Previous Status", nullable: false),
                    Exported = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Order Status", x => x.ServiceOrderNo_);
                });

            migrationBuilder.CreateTable(
                name: "Service Order Type",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Order Type", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Service Price Group",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Price Group", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Service Product",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    LinkedItemNo_ = table.Column<string>(name: "Linked Item No_", maxLength: 20, nullable: false),
                    TypeCode = table.Column<string>(name: "Type Code", maxLength: 10, nullable: false),
                    SalesStartDate = table.Column<DateTime>(name: "Sales Start Date", type: "datetime", nullable: false),
                    EndDateSales = table.Column<DateTime>(name: "End Date Sales", type: "datetime", nullable: false),
                    Enabled = table.Column<byte>(nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 10, nullable: false),
                    NoItemLink = table.Column<byte>(name: "No Item Link", nullable: false),
                    ServiceProductID = table.Column<int>(name: "Service Product ID", nullable: false),
                    BaseCapacityUnitofMeasure = table.Column<string>(name: "Base Capacity Unit of Measure", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Product", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Service Product Type",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 30, nullable: false),
                    TransportDependent = table.Column<byte>(name: "Transport Dependent", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Product Type", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Service Provider",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 30, nullable: false),
                    VendorNo_ = table.Column<string>(name: "Vendor No_", maxLength: 20, nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 10, nullable: false),
                    Codeunitcreateexportfile = table.Column<int>(name: "Codeunit create export file", nullable: false),
                    Exportpath = table.Column<string>(name: "Export path", maxLength: 250, nullable: false),
                    AliasServiceProvider = table.Column<string>(name: "Alias Service Provider", maxLength: 3, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Service Provider", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Shipping Agent",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    InternetAddress = table.Column<string>(name: "Internet Address", maxLength: 250, nullable: false),
                    AccountNo_ = table.Column<string>(name: "Account No_", maxLength: 30, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping Agent", x => x.Code);
                });

            migrationBuilder.CreateTable(
                name: "Shipping Agent Services",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    ShippingAgentCode = table.Column<string>(name: "Shipping Agent Code", maxLength: 10, nullable: false),
                    Code = table.Column<string>(maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    ShippingTime = table.Column<string>(name: "Shipping Time", unicode: false, maxLength: 32, nullable: false),
                    BaseCalendarCode = table.Column<string>(name: "Base Calendar Code", maxLength: 10, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Shipping Agent Services", x => new { x.ShippingAgentCode, x.Code });
                });

            migrationBuilder.CreateTable(
                name: "Vendor",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    Name = table.Column<string>(maxLength: 50, nullable: false),
                    SearchName = table.Column<string>(name: "Search Name", maxLength: 50, nullable: false),
                    Name2 = table.Column<string>(name: "Name 2", maxLength: 50, nullable: false),
                    Address = table.Column<string>(maxLength: 50, nullable: false),
                    Address2 = table.Column<string>(name: "Address 2", maxLength: 50, nullable: false),
                    City = table.Column<string>(maxLength: 30, nullable: false),
                    Contact = table.Column<string>(maxLength: 50, nullable: false),
                    PhoneNo_ = table.Column<string>(name: "Phone No_", maxLength: 30, nullable: false),
                    TelexNo_ = table.Column<string>(name: "Telex No_", maxLength: 20, nullable: false),
                    OurAccountNo_ = table.Column<string>(name: "Our Account No_", maxLength: 20, nullable: false),
                    TerritoryCode = table.Column<string>(name: "Territory Code", maxLength: 10, nullable: false),
                    GlobalDimension1Code = table.Column<string>(name: "Global Dimension 1 Code", maxLength: 20, nullable: false),
                    GlobalDimension2Code = table.Column<string>(name: "Global Dimension 2 Code", maxLength: 20, nullable: false),
                    BudgetedAmount = table.Column<decimal>(name: "Budgeted Amount", type: "decimal(38, 20)", nullable: false),
                    VendorPostingGroup = table.Column<string>(name: "Vendor Posting Group", maxLength: 20, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    LanguageCode = table.Column<string>(name: "Language Code", maxLength: 10, nullable: false),
                    StatisticsGroup = table.Column<int>(name: "Statistics Group", nullable: false),
                    PaymentTermsCode = table.Column<string>(name: "Payment Terms Code", maxLength: 10, nullable: false),
                    Fin_ChargeTermsCode = table.Column<string>(name: "Fin_ Charge Terms Code", maxLength: 10, nullable: false),
                    PurchaserCode = table.Column<string>(name: "Purchaser Code", maxLength: 20, nullable: false),
                    ShipmentMethodCode = table.Column<string>(name: "Shipment Method Code", maxLength: 10, nullable: false),
                    ShippingAgentCode = table.Column<string>(name: "Shipping Agent Code", maxLength: 10, nullable: false),
                    InvoiceDisc_Code = table.Column<string>(name: "Invoice Disc_ Code", maxLength: 20, nullable: false),
                    Country_RegionCode = table.Column<string>(name: "Country_Region Code", maxLength: 10, nullable: false),
                    Blocked = table.Column<int>(nullable: false),
                    PaytoVendorNo_ = table.Column<string>(name: "Pay-to Vendor No_", maxLength: 20, nullable: false),
                    Priority = table.Column<int>(nullable: false),
                    PaymentMethodCode = table.Column<string>(name: "Payment Method Code", maxLength: 10, nullable: false),
                    LastDateModified = table.Column<DateTime>(name: "Last Date Modified", type: "datetime", nullable: false),
                    ApplicationMethod = table.Column<int>(name: "Application Method", nullable: false),
                    PricesIncludingVAT = table.Column<byte>(name: "Prices Including VAT", nullable: false),
                    FaxNo_ = table.Column<string>(name: "Fax No_", maxLength: 30, nullable: false),
                    TelexAnswerBack = table.Column<string>(name: "Telex Answer Back", maxLength: 20, nullable: false),
                    VATRegistrationNo_ = table.Column<string>(name: "VAT Registration No_", maxLength: 20, nullable: false),
                    Gen_Bus_PostingGroup = table.Column<string>(name: "Gen_ Bus_ Posting Group", maxLength: 20, nullable: false),
                    Picture = table.Column<byte[]>(type: "image", nullable: true),
                    GLN = table.Column<string>(maxLength: 13, nullable: false),
                    PostCode = table.Column<string>(name: "Post Code", maxLength: 20, nullable: false),
                    County = table.Column<string>(maxLength: 30, nullable: false),
                    EMail = table.Column<string>(name: "E-Mail", maxLength: 80, nullable: false),
                    HomePage = table.Column<string>(name: "Home Page", maxLength: 80, nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    TaxAreaCode = table.Column<string>(name: "Tax Area Code", maxLength: 20, nullable: false),
                    TaxLiable = table.Column<byte>(name: "Tax Liable", nullable: false),
                    VATBus_PostingGroup = table.Column<string>(name: "VAT Bus_ Posting Group", maxLength: 20, nullable: false),
                    BlockPaymentTolerance = table.Column<byte>(name: "Block Payment Tolerance", nullable: false),
                    ICPartnerCode = table.Column<string>(name: "IC Partner Code", maxLength: 20, nullable: false),
                    Prepayment_ = table.Column<decimal>(name: "Prepayment _", type: "decimal(38, 20)", nullable: false),
                    PartnerType = table.Column<int>(name: "Partner Type", nullable: false),
                    Image = table.Column<Guid>(nullable: false),
                    CreditorNo_ = table.Column<string>(name: "Creditor No_", maxLength: 20, nullable: false),
                    PreferredBankAccountCode = table.Column<string>(name: "Preferred Bank Account Code", maxLength: 20, nullable: false),
                    CashFlowPaymentTermsCode = table.Column<string>(name: "Cash Flow Payment Terms Code", maxLength: 10, nullable: false),
                    PrimaryContactNo_ = table.Column<string>(name: "Primary Contact No_", maxLength: 20, nullable: false),
                    ResponsibilityCenter = table.Column<string>(name: "Responsibility Center", maxLength: 10, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    LeadTimeCalculation = table.Column<string>(name: "Lead Time Calculation", unicode: false, maxLength: 32, nullable: false),
                    BaseCalendarCode = table.Column<string>(name: "Base Calendar Code", maxLength: 10, nullable: false),
                    DocumentSendingProfile = table.Column<string>(name: "Document Sending Profile", maxLength: 20, nullable: false),
                    Id = table.Column<Guid>(nullable: false),
                    IFBVendor = table.Column<byte>(name: "IFB Vendor", nullable: false),
                    DocumentApprovalMandatory = table.Column<byte>(name: "Document Approval Mandatory", nullable: false),
                    RTCFilterField = table.Column<int>(name: "RTC Filter Field", nullable: false),
                    BuyerGroupCode = table.Column<string>(name: "Buyer Group Code", maxLength: 10, nullable: false),
                    BuyerID = table.Column<string>(name: "Buyer ID", maxLength: 50, nullable: false),
                    LastModifiedDateTime = table.Column<DateTime>(name: "Last Modified Date Time", type: "datetime", nullable: false),
                    PrivacyBlocked = table.Column<byte>(name: "Privacy Blocked", nullable: false),
                    ValidateEUVatReg_No_ = table.Column<byte>(name: "Validate EU Vat Reg_ No_", nullable: false),
                    CurrencyId = table.Column<Guid>(name: "Currency Id", nullable: false),
                    PaymentTermsId = table.Column<Guid>(name: "Payment Terms Id", nullable: false),
                    PaymentMethodId = table.Column<Guid>(name: "Payment Method Id", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Vendor Ledger Entry",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    EntryNo_ = table.Column<int>(name: "Entry No_", nullable: false),
                    VendorNo_ = table.Column<string>(name: "Vendor No_", maxLength: 20, nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    DocumentType = table.Column<int>(name: "Document Type", nullable: false),
                    DocumentNo_ = table.Column<string>(name: "Document No_", maxLength: 20, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    CurrencyCode = table.Column<string>(name: "Currency Code", maxLength: 10, nullable: false),
                    PurchaseLCY = table.Column<decimal>(name: "Purchase (LCY)", type: "decimal(38, 20)", nullable: false),
                    Inv_DiscountLCY = table.Column<decimal>(name: "Inv_ Discount (LCY)", type: "decimal(38, 20)", nullable: false),
                    BuyfromVendorNo_ = table.Column<string>(name: "Buy-from Vendor No_", maxLength: 20, nullable: false),
                    VendorPostingGroup = table.Column<string>(name: "Vendor Posting Group", maxLength: 20, nullable: false),
                    GlobalDimension1Code = table.Column<string>(name: "Global Dimension 1 Code", maxLength: 20, nullable: false),
                    GlobalDimension2Code = table.Column<string>(name: "Global Dimension 2 Code", maxLength: 20, nullable: false),
                    PurchaserCode = table.Column<string>(name: "Purchaser Code", maxLength: 20, nullable: false),
                    UserID = table.Column<string>(name: "User ID", maxLength: 50, nullable: false),
                    SourceCode = table.Column<string>(name: "Source Code", maxLength: 10, nullable: false),
                    OnHold = table.Column<string>(name: "On Hold", maxLength: 3, nullable: false),
                    AppliestoDoc_Type = table.Column<int>(name: "Applies-to Doc_ Type", nullable: false),
                    AppliestoDoc_No_ = table.Column<string>(name: "Applies-to Doc_ No_", maxLength: 20, nullable: false),
                    Open = table.Column<byte>(nullable: false),
                    DueDate = table.Column<DateTime>(name: "Due Date", type: "datetime", nullable: false),
                    Pmt_DiscountDate = table.Column<DateTime>(name: "Pmt_ Discount Date", type: "datetime", nullable: false),
                    OriginalPmt_Disc_Possible = table.Column<decimal>(name: "Original Pmt_ Disc_ Possible", type: "decimal(38, 20)", nullable: false),
                    Pmt_Disc_Rcd_LCY = table.Column<decimal>(name: "Pmt_ Disc_ Rcd_(LCY)", type: "decimal(38, 20)", nullable: false),
                    Positive = table.Column<byte>(nullable: false),
                    ClosedbyEntryNo_ = table.Column<int>(name: "Closed by Entry No_", nullable: false),
                    ClosedatDate = table.Column<DateTime>(name: "Closed at Date", type: "datetime", nullable: false),
                    ClosedbyAmount = table.Column<decimal>(name: "Closed by Amount", type: "decimal(38, 20)", nullable: false),
                    AppliestoID = table.Column<string>(name: "Applies-to ID", maxLength: 50, nullable: false),
                    JournalBatchName = table.Column<string>(name: "Journal Batch Name", maxLength: 10, nullable: false),
                    ReasonCode = table.Column<string>(name: "Reason Code", maxLength: 10, nullable: false),
                    Bal_AccountType = table.Column<int>(name: "Bal_ Account Type", nullable: false),
                    Bal_AccountNo_ = table.Column<string>(name: "Bal_ Account No_", maxLength: 20, nullable: false),
                    TransactionNo_ = table.Column<int>(name: "Transaction No_", nullable: false),
                    ClosedbyAmountLCY = table.Column<decimal>(name: "Closed by Amount (LCY)", type: "decimal(38, 20)", nullable: false),
                    DocumentDate = table.Column<DateTime>(name: "Document Date", type: "datetime", nullable: false),
                    ExternalDocumentNo_ = table.Column<string>(name: "External Document No_", maxLength: 35, nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    ClosedbyCurrencyCode = table.Column<string>(name: "Closed by Currency Code", maxLength: 10, nullable: false),
                    ClosedbyCurrencyAmount = table.Column<decimal>(name: "Closed by Currency Amount", type: "decimal(38, 20)", nullable: false),
                    AdjustedCurrencyFactor = table.Column<decimal>(name: "Adjusted Currency Factor", type: "decimal(38, 20)", nullable: false),
                    OriginalCurrencyFactor = table.Column<decimal>(name: "Original Currency Factor", type: "decimal(38, 20)", nullable: false),
                    RemainingPmt_Disc_Possible = table.Column<decimal>(name: "Remaining Pmt_ Disc_ Possible", type: "decimal(38, 20)", nullable: false),
                    Pmt_Disc_ToleranceDate = table.Column<DateTime>(name: "Pmt_ Disc_ Tolerance Date", type: "datetime", nullable: false),
                    Max_PaymentTolerance = table.Column<decimal>(name: "Max_ Payment Tolerance", type: "decimal(38, 20)", nullable: false),
                    AcceptedPaymentTolerance = table.Column<decimal>(name: "Accepted Payment Tolerance", type: "decimal(38, 20)", nullable: false),
                    AcceptedPmt_Disc_Tolerance = table.Column<byte>(name: "Accepted Pmt_ Disc_ Tolerance", nullable: false),
                    Pmt_ToleranceLCY = table.Column<decimal>(name: "Pmt_ Tolerance (LCY)", type: "decimal(38, 20)", nullable: false),
                    AmounttoApply = table.Column<decimal>(name: "Amount to Apply", type: "decimal(38, 20)", nullable: false),
                    ICPartnerCode = table.Column<string>(name: "IC Partner Code", maxLength: 20, nullable: false),
                    ApplyingEntry = table.Column<byte>(name: "Applying Entry", nullable: false),
                    Reversed = table.Column<byte>(nullable: false),
                    ReversedbyEntryNo_ = table.Column<int>(name: "Reversed by Entry No_", nullable: false),
                    ReversedEntryNo_ = table.Column<int>(name: "Reversed Entry No_", nullable: false),
                    Prepayment = table.Column<byte>(nullable: false),
                    CreditorNo_ = table.Column<string>(name: "Creditor No_", maxLength: 20, nullable: false),
                    PaymentReference = table.Column<string>(name: "Payment Reference", maxLength: 50, nullable: false),
                    PaymentMethodCode = table.Column<string>(name: "Payment Method Code", maxLength: 10, nullable: false),
                    AppliestoExt_Doc_No_ = table.Column<string>(name: "Applies-to Ext_ Doc_ No_", maxLength: 35, nullable: false),
                    RecipientBankAccount = table.Column<string>(name: "Recipient Bank Account", maxLength: 20, nullable: false),
                    MessagetoRecipient = table.Column<string>(name: "Message to Recipient", maxLength: 140, nullable: false),
                    ExportedtoPaymentFile = table.Column<byte>(name: "Exported to Payment File", nullable: false),
                    DimensionSetID = table.Column<int>(name: "Dimension Set ID", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vendor Ledger Entry", x => x.EntryNo_);
                });

            migrationBuilder.CreateTable(
                name: "Visitors",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    StoreNo_ = table.Column<string>(name: "Store No_", maxLength: 10, nullable: false),
                    Date = table.Column<DateTime>(type: "datetime", nullable: false),
                    NumberofVisitors = table.Column<int>(name: "Number of Visitors", nullable: false),
                    RestaurantSales = table.Column<decimal>(name: "Restaurant Sales", type: "decimal(38, 20)", nullable: false),
                    ExitCafeSales = table.Column<decimal>(name: "Exit Cafe Sales", type: "decimal(38, 20)", nullable: false),
                    RestaurantCustomers = table.Column<int>(name: "Restaurant Customers", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Visitors", x => new { x.StoreNo_, x.Date });
                });

            migrationBuilder.CreateTable(
                name: "Warehouse Activity Header",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    Type = table.Column<int>(nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    AssignedUserID = table.Column<string>(name: "Assigned User ID", maxLength: 50, nullable: false),
                    AssignmentDate = table.Column<DateTime>(name: "Assignment Date", type: "datetime", nullable: false),
                    AssignmentTime = table.Column<DateTime>(name: "Assignment Time", type: "datetime", nullable: false),
                    SortingMethod = table.Column<int>(name: "Sorting Method", nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    No_Printed = table.Column<int>(name: "No_ Printed", nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    RegisteringNo_ = table.Column<string>(name: "Registering No_", maxLength: 20, nullable: false),
                    LastRegisteringNo_ = table.Column<string>(name: "Last Registering No_", maxLength: 20, nullable: false),
                    RegisteringNo_Series = table.Column<string>(name: "Registering No_ Series", maxLength: 20, nullable: false),
                    DateofLastPrinting = table.Column<DateTime>(name: "Date of Last Printing", type: "datetime", nullable: false),
                    TimeofLastPrinting = table.Column<DateTime>(name: "Time of Last Printing", type: "datetime", nullable: false),
                    BreakbulkFilter = table.Column<byte>(name: "Breakbulk Filter", nullable: false),
                    SourceNo_ = table.Column<string>(name: "Source No_", maxLength: 20, nullable: false),
                    SourceDocument = table.Column<int>(name: "Source Document", nullable: false),
                    SourceType = table.Column<int>(name: "Source Type", nullable: false),
                    SourceSubtype = table.Column<int>(name: "Source Subtype", nullable: false),
                    DestinationType = table.Column<int>(name: "Destination Type", nullable: false),
                    DestinationNo_ = table.Column<string>(name: "Destination No_", maxLength: 20, nullable: false),
                    ExternalDocumentNo_ = table.Column<string>(name: "External Document No_", maxLength: 35, nullable: false),
                    ExpectedReceiptDate = table.Column<DateTime>(name: "Expected Receipt Date", type: "datetime", nullable: false),
                    ShipmentDate = table.Column<DateTime>(name: "Shipment Date", type: "datetime", nullable: false),
                    ExternalDocumentNo_2 = table.Column<string>(name: "External Document No_2", maxLength: 35, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse Activity Header", x => new { x.Type, x.No_ });
                });

            migrationBuilder.CreateTable(
                name: "Warehouse Activity Line",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    ActivityType = table.Column<int>(name: "Activity Type", nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    SourceType = table.Column<int>(name: "Source Type", nullable: false),
                    SourceSubtype = table.Column<int>(name: "Source Subtype", nullable: false),
                    SourceNo_ = table.Column<string>(name: "Source No_", maxLength: 20, nullable: false),
                    SourceLineNo_ = table.Column<int>(name: "Source Line No_", nullable: false),
                    SourceSublineNo_ = table.Column<int>(name: "Source Subline No_", nullable: false),
                    SourceDocument = table.Column<int>(name: "Source Document", nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    ShelfNo_ = table.Column<string>(name: "Shelf No_", maxLength: 10, nullable: false),
                    SortingSequenceNo_ = table.Column<int>(name: "Sorting Sequence No_", nullable: false),
                    ItemNo_ = table.Column<string>(name: "Item No_", maxLength: 20, nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    UnitofMeasureCode = table.Column<string>(name: "Unit of Measure Code", maxLength: 10, nullable: false),
                    Qty_perUnitofMeasure = table.Column<decimal>(name: "Qty_ per Unit of Measure", type: "decimal(38, 20)", nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Description2 = table.Column<string>(name: "Description 2", maxLength: 50, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    Qty_Base = table.Column<decimal>(name: "Qty_ (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_Outstanding = table.Column<decimal>(name: "Qty_ Outstanding", type: "decimal(38, 20)", nullable: false),
                    Qty_OutstandingBase = table.Column<decimal>(name: "Qty_ Outstanding (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_toHandle = table.Column<decimal>(name: "Qty_ to Handle", type: "decimal(38, 20)", nullable: false),
                    Qty_toHandleBase = table.Column<decimal>(name: "Qty_ to Handle (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_Handled = table.Column<decimal>(name: "Qty_ Handled", type: "decimal(38, 20)", nullable: false),
                    Qty_HandledBase = table.Column<decimal>(name: "Qty_ Handled (Base)", type: "decimal(38, 20)", nullable: false),
                    ShippingAdvice = table.Column<int>(name: "Shipping Advice", nullable: false),
                    DueDate = table.Column<DateTime>(name: "Due Date", type: "datetime", nullable: false),
                    DestinationType = table.Column<int>(name: "Destination Type", nullable: false),
                    DestinationNo_ = table.Column<string>(name: "Destination No_", maxLength: 20, nullable: false),
                    ShippingAgentCode = table.Column<string>(name: "Shipping Agent Code", maxLength: 10, nullable: false),
                    ShippingAgentServiceCode = table.Column<string>(name: "Shipping Agent Service Code", maxLength: 10, nullable: false),
                    ShipmentMethodCode = table.Column<string>(name: "Shipment Method Code", maxLength: 10, nullable: false),
                    StartingDate = table.Column<DateTime>(name: "Starting Date", type: "datetime", nullable: false),
                    AssembletoOrder = table.Column<byte>(name: "Assemble to Order", nullable: false),
                    ATOComponent = table.Column<byte>(name: "ATO Component", nullable: false),
                    SerialNo_ = table.Column<string>(name: "Serial No_", maxLength: 20, nullable: false),
                    LotNo_ = table.Column<string>(name: "Lot No_", maxLength: 20, nullable: false),
                    WarrantyDate = table.Column<DateTime>(name: "Warranty Date", type: "datetime", nullable: false),
                    ExpirationDate = table.Column<DateTime>(name: "Expiration Date", type: "datetime", nullable: false),
                    BinCode = table.Column<string>(name: "Bin Code", maxLength: 20, nullable: false),
                    ZoneCode = table.Column<string>(name: "Zone Code", maxLength: 10, nullable: false),
                    ActionType = table.Column<int>(name: "Action Type", nullable: false),
                    Whse_DocumentType = table.Column<int>(name: "Whse_ Document Type", nullable: false),
                    Whse_DocumentNo_ = table.Column<string>(name: "Whse_ Document No_", maxLength: 20, nullable: false),
                    Whse_DocumentLineNo_ = table.Column<int>(name: "Whse_ Document Line No_", nullable: false),
                    BinRanking = table.Column<int>(name: "Bin Ranking", nullable: false),
                    Cubage = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    SpecialEquipmentCode = table.Column<string>(name: "Special Equipment Code", maxLength: 10, nullable: false),
                    BinTypeCode = table.Column<string>(name: "Bin Type Code", maxLength: 10, nullable: false),
                    BreakbulkNo_ = table.Column<int>(name: "Breakbulk No_", nullable: false),
                    OriginalBreakbulk = table.Column<byte>(name: "Original Breakbulk", nullable: false),
                    Breakbulk = table.Column<byte>(nullable: false),
                    CrossDockInformation = table.Column<int>(name: "Cross-Dock Information", nullable: false),
                    Dedicated = table.Column<byte>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse Activity Line", x => new { x.ActivityType, x.No_, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Warehouse Shipment Header",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    AssignedUserID = table.Column<string>(name: "Assigned User ID", maxLength: 50, nullable: false),
                    AssignmentDate = table.Column<DateTime>(name: "Assignment Date", type: "datetime", nullable: false),
                    AssignmentTime = table.Column<DateTime>(name: "Assignment Time", type: "datetime", nullable: false),
                    SortingMethod = table.Column<int>(name: "Sorting Method", nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    BinCode = table.Column<string>(name: "Bin Code", maxLength: 20, nullable: false),
                    ZoneCode = table.Column<string>(name: "Zone Code", maxLength: 10, nullable: false),
                    DocumentStatus = table.Column<int>(name: "Document Status", nullable: false),
                    PostingDate = table.Column<DateTime>(name: "Posting Date", type: "datetime", nullable: false),
                    ShippingAgentCode = table.Column<string>(name: "Shipping Agent Code", maxLength: 10, nullable: false),
                    ShippingAgentServiceCode = table.Column<string>(name: "Shipping Agent Service Code", maxLength: 10, nullable: false),
                    ShipmentMethodCode = table.Column<string>(name: "Shipment Method Code", maxLength: 10, nullable: false),
                    ShipmentDate = table.Column<DateTime>(name: "Shipment Date", type: "datetime", nullable: false),
                    Status = table.Column<int>(nullable: false),
                    ExternalDocumentNo_ = table.Column<string>(name: "External Document No_", maxLength: 35, nullable: false),
                    CreatePostedHeader = table.Column<byte>(name: "Create Posted Header", nullable: false),
                    ShippingNo_ = table.Column<string>(name: "Shipping No_", maxLength: 20, nullable: false),
                    LastShippingNo_ = table.Column<string>(name: "Last Shipping No_", maxLength: 20, nullable: false),
                    ShippingNo_Series = table.Column<string>(name: "Shipping No_ Series", maxLength: 20, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse Shipment Header", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Warehouse Shipment Line",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    SourceType = table.Column<int>(name: "Source Type", nullable: false),
                    SourceSubtype = table.Column<int>(name: "Source Subtype", nullable: false),
                    SourceNo_ = table.Column<string>(name: "Source No_", maxLength: 20, nullable: false),
                    SourceLineNo_ = table.Column<int>(name: "Source Line No_", nullable: false),
                    SourceDocument = table.Column<int>(name: "Source Document", nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    ShelfNo_ = table.Column<string>(name: "Shelf No_", maxLength: 10, nullable: false),
                    BinCode = table.Column<string>(name: "Bin Code", maxLength: 20, nullable: false),
                    ZoneCode = table.Column<string>(name: "Zone Code", maxLength: 10, nullable: false),
                    ItemNo_ = table.Column<string>(name: "Item No_", maxLength: 20, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    Qty_Base = table.Column<decimal>(name: "Qty_ (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_Outstanding = table.Column<decimal>(name: "Qty_ Outstanding", type: "decimal(38, 20)", nullable: false),
                    Qty_OutstandingBase = table.Column<decimal>(name: "Qty_ Outstanding (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_toShip = table.Column<decimal>(name: "Qty_ to Ship", type: "decimal(38, 20)", nullable: false),
                    Qty_toShipBase = table.Column<decimal>(name: "Qty_ to Ship (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_Picked = table.Column<decimal>(name: "Qty_ Picked", type: "decimal(38, 20)", nullable: false),
                    Qty_PickedBase = table.Column<decimal>(name: "Qty_ Picked (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_Shipped = table.Column<decimal>(name: "Qty_ Shipped", type: "decimal(38, 20)", nullable: false),
                    Qty_ShippedBase = table.Column<decimal>(name: "Qty_ Shipped (Base)", type: "decimal(38, 20)", nullable: false),
                    UnitofMeasureCode = table.Column<string>(name: "Unit of Measure Code", maxLength: 10, nullable: false),
                    Qty_perUnitofMeasure = table.Column<decimal>(name: "Qty_ per Unit of Measure", type: "decimal(38, 20)", nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Description2 = table.Column<string>(name: "Description 2", maxLength: 50, nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SortingSequenceNo_ = table.Column<int>(name: "Sorting Sequence No_", nullable: false),
                    DueDate = table.Column<DateTime>(name: "Due Date", type: "datetime", nullable: false),
                    DestinationType = table.Column<int>(name: "Destination Type", nullable: false),
                    DestinationNo_ = table.Column<string>(name: "Destination No_", maxLength: 20, nullable: false),
                    Cubage = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    ShippingAdvice = table.Column<int>(name: "Shipping Advice", nullable: false),
                    ShipmentDate = table.Column<DateTime>(name: "Shipment Date", type: "datetime", nullable: false),
                    CompletelyPicked = table.Column<byte>(name: "Completely Picked", nullable: false),
                    Notupd_bySrc_Doc_Post_ = table.Column<byte>(name: "Not upd_ by Src_ Doc_ Post_", nullable: false),
                    PostingfromWhse_Ref_ = table.Column<int>(name: "Posting from Whse_ Ref_", nullable: false),
                    AssembletoOrder = table.Column<byte>(name: "Assemble to Order", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Warehouse Shipment Line", x => new { x.No_, x.LineNo_ });
                });

            migrationBuilder.CreateTable(
                name: "Whse_ Internal Pick Header",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    AssignedUserID = table.Column<string>(name: "Assigned User ID", maxLength: 50, nullable: false),
                    AssignmentDate = table.Column<DateTime>(name: "Assignment Date", type: "datetime", nullable: false),
                    AssignmentTime = table.Column<DateTime>(name: "Assignment Time", type: "datetime", nullable: false),
                    SortingMethod = table.Column<int>(name: "Sorting Method", nullable: false),
                    No_Series = table.Column<string>(name: "No_ Series", maxLength: 20, nullable: false),
                    ToBinCode = table.Column<string>(name: "To Bin Code", maxLength: 20, nullable: false),
                    ToZoneCode = table.Column<string>(name: "To Zone Code", maxLength: 10, nullable: false),
                    DocumentStatus = table.Column<int>(name: "Document Status", nullable: false),
                    DueDate = table.Column<DateTime>(name: "Due Date", type: "datetime", nullable: false),
                    Status = table.Column<int>(nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Whse_ Internal Pick Header", x => x.No_);
                });

            migrationBuilder.CreateTable(
                name: "Whse_ Internal Pick Line",
                columns: table => new
                {
                    timestamp = table.Column<byte[]>(rowVersion: true, nullable: false),
                    No_ = table.Column<string>(maxLength: 20, nullable: false),
                    LineNo_ = table.Column<int>(name: "Line No_", nullable: false),
                    LocationCode = table.Column<string>(name: "Location Code", maxLength: 10, nullable: false),
                    ShelfNo_ = table.Column<string>(name: "Shelf No_", maxLength: 10, nullable: false),
                    ToBinCode = table.Column<string>(name: "To Bin Code", maxLength: 20, nullable: false),
                    ToZoneCode = table.Column<string>(name: "To Zone Code", maxLength: 10, nullable: false),
                    ItemNo_ = table.Column<string>(name: "Item No_", maxLength: 20, nullable: false),
                    Quantity = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    Qty_Base = table.Column<decimal>(name: "Qty_ (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_Outstanding = table.Column<decimal>(name: "Qty_ Outstanding", type: "decimal(38, 20)", nullable: false),
                    Qty_OutstandingBase = table.Column<decimal>(name: "Qty_ Outstanding (Base)", type: "decimal(38, 20)", nullable: false),
                    Qty_Picked = table.Column<decimal>(name: "Qty_ Picked", type: "decimal(38, 20)", nullable: false),
                    Qty_PickedBase = table.Column<decimal>(name: "Qty_ Picked (Base)", type: "decimal(38, 20)", nullable: false),
                    UnitofMeasureCode = table.Column<string>(name: "Unit of Measure Code", maxLength: 10, nullable: false),
                    Qty_perUnitofMeasure = table.Column<decimal>(name: "Qty_ per Unit of Measure", type: "decimal(38, 20)", nullable: false),
                    VariantCode = table.Column<string>(name: "Variant Code", maxLength: 10, nullable: false),
                    Description = table.Column<string>(maxLength: 50, nullable: false),
                    Description2 = table.Column<string>(name: "Description 2", maxLength: 50, nullable: false),
                    Status = table.Column<int>(nullable: false),
                    SortingSequenceNo_ = table.Column<int>(name: "Sorting Sequence No_", nullable: false),
                    DueDate = table.Column<DateTime>(name: "Due Date", type: "datetime", nullable: false),
                    Cubage = table.Column<decimal>(type: "decimal(38, 20)", nullable: false),
                    Weight = table.Column<decimal>(type: "decimal(38, 20)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Whse_ Internal Pick Line", x => new { x.No_, x.LineNo_ });
                });

            migrationBuilder.CreateIndex(
                name: "$9",
                table: "Cust_ Ledger Entry",
                columns: new[] { "Closed by Entry No_", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$19",
                table: "Cust_ Ledger Entry",
                columns: new[] { "Customer Posting Group", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Cust_ Ledger Entry",
                columns: new[] { "Document No_", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Cust_ Ledger Entry",
                columns: new[] { "External Document No_", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$10",
                table: "Cust_ Ledger Entry",
                columns: new[] { "Transaction No_", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$17",
                table: "Cust_ Ledger Entry",
                columns: new[] { "Document Type", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Cust_ Ledger Entry",
                columns: new[] { "Open", "Due Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$8",
                table: "Cust_ Ledger Entry",
                columns: new[] { "Salesperson Code", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Cust_ Ledger Entry",
                columns: new[] { "Customer No_", "Posting Date", "Currency Code", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$18",
                table: "Cust_ Ledger Entry",
                columns: new[] { "Document Type", "Customer No_", "Open", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$16",
                table: "Cust_ Ledger Entry",
                columns: new[] { "Customer No_", "Applies-to ID", "Open", "Positive", "Due Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Cust_ Ledger Entry",
                columns: new[] { "Customer No_", "Open", "Positive", "Due Date", "Currency Code", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$9",
                table: "Customer",
                columns: new[] { "City", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$12",
                table: "Customer",
                columns: new[] { "Contact", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Customer",
                columns: new[] { "Country_Region Code", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Customer",
                columns: new[] { "Currency Code", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Customer",
                columns: new[] { "Customer Posting Group", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Customer",
                columns: new[] { "Gen_ Bus_ Posting Group", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$8",
                table: "Customer",
                columns: new[] { "Name", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$11",
                table: "Customer",
                columns: new[] { "Phone No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$14",
                table: "Customer",
                columns: new[] { "Retail Customer Group", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Customer",
                columns: new[] { "Search Name", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$7",
                table: "Customer",
                columns: new[] { "VAT Registration No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$13",
                table: "Customer",
                columns: new[] { "Address", "Post Code", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$10",
                table: "Customer",
                columns: new[] { "Post Code", "Address", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Customer",
                columns: new[] { "Name", "Address", "City", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Customer Order Header",
                columns: new[] { "Receipt No_", "Document Id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Customer Order Header",
                columns: new[] { "Web Trans_ GUID", "Document Id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Customer Order Header",
                columns: new[] { "Store No_", "Status", "Document Id" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Customer Order Line",
                columns: new[] { "Sourcing Location", "Document Id", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Customer Order Line",
                columns: new[] { "Document Id", "Number", "Variant Code", "Unit of Measure Code", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$7",
                table: "Detailed Cust_ Ledg_Entry",
                columns: new[] { "Applied Cust_ Ledger Entry No_", "Entry Type", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Detailed Cust_ Ledg_Entry",
                columns: new[] { "Cust_ Ledger Entry No_", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$9",
                table: "Detailed Cust_ Ledg_Entry",
                columns: new[] { "Application No_", "Customer No_", "Entry Type", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Detailed Cust_ Ledg_Entry",
                columns: new[] { "Document No_", "Document Type", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$8",
                table: "Detailed Cust_ Ledg_Entry",
                columns: new[] { "Transaction No_", "Customer No_", "Entry Type", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$10",
                table: "Detailed Cust_ Ledg_Entry",
                columns: new[] { "Customer No_", "Entry Type", "Posting Date", "Initial Document Type", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Detailed Cust_ Ledg_Entry",
                columns: new[] { "Customer No_", "Currency Code", "Initial Entry Global Dim_ 1", "Initial Entry Global Dim_ 2", "Initial Entry Due Date", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Detailed Cust_ Ledg_Entry",
                columns: new[] { "Initial Document Type", "Entry Type", "Customer No_", "Currency Code", "Initial Entry Global Dim_ 1", "Initial Entry Global Dim_ 2", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$7",
                table: "Detailed Vendor Ledg_Entry",
                columns: new[] { "Applied Vend_ Ledger Entry No_", "Entry Type", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Detailed Vendor Ledg_Entry",
                columns: new[] { "Vendor Ledger Entry No_", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$9",
                table: "Detailed Vendor Ledg_Entry",
                columns: new[] { "Application No_", "Vendor No_", "Entry Type", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Detailed Vendor Ledg_Entry",
                columns: new[] { "Document No_", "Document Type", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$8",
                table: "Detailed Vendor Ledg_Entry",
                columns: new[] { "Transaction No_", "Vendor No_", "Entry Type", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Detailed Vendor Ledg_Entry",
                columns: new[] { "Vendor No_", "Currency Code", "Initial Entry Global Dim_ 1", "Initial Entry Global Dim_ 2", "Initial Entry Due Date", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Detailed Vendor Ledg_Entry",
                columns: new[] { "Initial Document Type", "Entry Type", "Vendor No_", "Currency Code", "Initial Entry Global Dim_ 1", "Initial Entry Global Dim_ 2", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Item Category",
                columns: new[] { "Division Code", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Item Ledger Entry",
                columns: new[] { "Item No_", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$12",
                table: "Item Ledger Entry",
                columns: new[] { "Item No_", "Applied Entry to Adjust", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$7",
                table: "Item Ledger Entry",
                columns: new[] { "Country_Region Code", "Entry Type", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$8",
                table: "Item Ledger Entry",
                columns: new[] { "Document No_", "Document Type", "Document Line No_", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$21",
                table: "Item Ledger Entry",
                columns: new[] { "Item No_", "Location Code", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Item Ledger Entry",
                columns: new[] { "Item No_", "Posting Date", "Entry Type", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$13",
                table: "Item Ledger Entry",
                columns: new[] { "Item No_", "Positive", "Location Code", "Variant Code", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$11",
                table: "Item Ledger Entry",
                columns: new[] { "Order Type", "Order No_", "Order Line No_", "Entry Type", "Prod_ Order Comp_ Line No_", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Item Ledger Entry",
                columns: new[] { "Source Type", "Source No_", "Item No_", "Variant Code", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Item Ledger Entry",
                columns: new[] { "Item No_", "Entry Type", "Variant Code", "Drop Shipment", "Location Code", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Item Ledger Entry",
                columns: new[] { "Item No_", "Open", "Variant Code", "Positive", "Location Code", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Item Vendor",
                columns: new[] { "Item No_", "Variant Code", "Vendor No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Item Vendor",
                columns: new[] { "Vendor No_", "Vendor Item No_", "Item No_", "Variant Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Return Receipt Header",
                columns: new[] { "Bill-to Customer No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Return Receipt Header",
                columns: new[] { "Posting Date", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Return Receipt Header",
                columns: new[] { "Reciving_Picking No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Return Receipt Header",
                columns: new[] { "Return Order No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Return Receipt Header",
                columns: new[] { "Sell-to Customer No_", "External Document No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Return Receipt Line",
                columns: new[] { "Bill-to Customer No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Return Receipt Line",
                columns: new[] { "Item Rcpt_ Entry No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Return Receipt Line",
                columns: new[] { "Sell-to Customer No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Return Receipt Line",
                columns: new[] { "Blanket Order No_", "Blanket Order Line No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Return Receipt Line",
                columns: new[] { "Return Order No_", "Return Order Line No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Return Shipment Header",
                columns: new[] { "Buy-from Vendor No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Return Shipment Header",
                columns: new[] { "Pay-to Vendor No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Return Shipment Header",
                columns: new[] { "Reciving_Picking No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Return Shipment Header",
                columns: new[] { "Return Order No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Return Shipment Line",
                columns: new[] { "Buy-from Vendor No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Return Shipment Line",
                columns: new[] { "Pay-to Vendor No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Return Shipment Line",
                columns: new[] { "Blanket Order No_", "Blanket Order Line No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Return Shipment Line",
                columns: new[] { "Return Order No_", "Return Order Line No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Sales Header",
                columns: new[] { "No_", "Document Type" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$7",
                table: "Sales Header",
                columns: new[] { "Bill-to Contact No_", "Document Type", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$13",
                table: "Sales Header",
                columns: new[] { "Document Date", "Document Type", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Sales Header",
                columns: new[] { "Document Type", "Bill-to Customer No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Sales Header",
                columns: new[] { "Document Type", "Sell-to Contact No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Sales Header",
                columns: new[] { "Document Type", "Sell-to Customer No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$8",
                table: "Sales Header",
                columns: new[] { "Incoming Document Entry No_", "Document Type", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$12",
                table: "Sales Header",
                columns: new[] { "Document Type", "Sell-to Customer No_", "Sell-to Contact No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Sales Header",
                columns: new[] { "Sell-to Customer No_", "External Document No_", "Document Type", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Sales Header",
                columns: new[] { "Document Type", "Combine Shipments", "Bill-to Customer No_", "Currency Code", "EU 3-Party Trade", "Dimension Set ID", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$7",
                table: "Sales Invoice Header",
                columns: new[] { "Bill-to Customer No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$10",
                table: "Sales Invoice Header",
                columns: new[] { "Document Exchange Status", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Sales Invoice Header",
                columns: new[] { "Order No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$9",
                table: "Sales Invoice Header",
                columns: new[] { "Posting Date", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Sales Invoice Header",
                columns: new[] { "Pre-Assigned No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$8",
                table: "Sales Invoice Header",
                columns: new[] { "Sell-to Contact No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Sales Invoice Header",
                columns: new[] { "Sell-to Customer No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Sales Invoice Header",
                columns: new[] { "Prepayment Order No_", "Prepayment Invoice", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Sales Invoice Line",
                columns: new[] { "Bill-to Customer No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Sales Invoice Line",
                columns: new[] { "Job Contract Entry No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Sales Invoice Line",
                columns: new[] { "Sell-to Customer No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Sales Invoice Line",
                columns: new[] { "Blanket Order No_", "Blanket Order Line No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Sales Invoice Line",
                columns: new[] { "Shipment No_", "Shipment Line No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$11",
                table: "Sales Line",
                columns: new[] { "Job Contract Entry No_", "Document Type", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Sales Line",
                columns: new[] { "Document Type", "Bill-to Customer No_", "Currency Code", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Sales Line",
                columns: new[] { "Document Type", "Blanket Order No_", "Blanket Order Line No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$10",
                table: "Sales Line",
                columns: new[] { "Document Type", "Sell-to Customer No_", "Shipment No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$8",
                table: "Sales Line",
                columns: new[] { "Document Type", "Shipment No_", "Shipment Line No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$14",
                table: "Sales Line",
                columns: new[] { "Alloc_ Plan Purc_ Order No_", "Document Type", "Type", "No_", "Variant Code", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Sales Line",
                columns: new[] { "Document Type", "Type", "No_", "Variant Code", "Drop Shipment", "Location Code", "Shipment Date", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Sales Prepayment ",
                columns: new[] { "Sales Type", "Sales Code", "Item No_", "Starting Date" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Sales Shipment Header",
                columns: new[] { "Bill-to Customer No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Sales Shipment Header",
                columns: new[] { "Order No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Sales Shipment Header",
                columns: new[] { "Posting Date", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Sales Shipment Header",
                columns: new[] { "Reciving_Picking No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Sales Shipment Header",
                columns: new[] { "Sell-to Customer No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Sales Shipment Header",
                columns: new[] { "Statement No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Sales Shipment Line",
                columns: new[] { "Bill-to Customer No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Sales Shipment Line",
                columns: new[] { "Item Shpt_ Entry No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Sales Shipment Line",
                columns: new[] { "Sell-to Customer No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Sales Shipment Line",
                columns: new[] { "Blanket Order No_", "Blanket Order Line No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Sales Shipment Line",
                columns: new[] { "Order No_", "Order Line No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Sales Statistics",
                columns: new[] { "Store No_", "Code", "Date", "Time", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Service Bookings",
                columns: new[] { "Reservation ID", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Bookings",
                columns: new[] { "Time Slot No_", "Canceled", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Contract Header",
                columns: new[] { "Contract No_", "Contract Type" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Service Contract Header",
                columns: new[] { "Next Price Update Date", "Contract Type", "Contract No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$7",
                table: "Service Contract Header",
                columns: new[] { "Template No_", "Contract Type", "Contract No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Service Contract Header",
                columns: new[] { "Customer No_", "Ship-to Code", "Contract Type", "Contract No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Service Contract Header",
                columns: new[] { "Salesperson Code", "Status", "Contract Type", "Contract No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Service Contract Header",
                columns: new[] { "Bill-to Customer No_", "Contract Type", "Combine Invoices", "Next Invoice Date", "Contract No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Service Contract Header",
                columns: new[] { "Responsibility Center", "Service Zone Code", "Status", "Contract Group Code", "Contract Type", "Contract No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Contract Line",
                columns: new[] { "Contract No_", "Line No_", "Contract Type" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Service Contract Line",
                columns: new[] { "Customer No_", "Ship-to Code", "Contract Type", "Contract No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Service Contract Line",
                columns: new[] { "Service Item No_", "Contract Status", "Contract Type", "Contract No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Header",
                columns: new[] { "No_", "Document Type" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Service Header",
                columns: new[] { "Customer No_", "Order Date", "Document Type", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Service Header",
                columns: new[] { "Contract No_", "Status", "Posting Date", "Document Type", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Service Header",
                columns: new[] { "Status", "Priority", "Response Date", "Response Time", "Document Type", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Service Header",
                columns: new[] { "Status", "Response Date", "Response Time", "Priority", "Document Type", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Invoice Header",
                columns: new[] { "Order No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Service Invoice Header",
                columns: new[] { "Contract No_", "Posting Date", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Service Invoice Header",
                columns: new[] { "Customer No_", "Order Date", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Service Invoice Header",
                columns: new[] { "Priority", "Response Date", "Response Time", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Service Invoice Header",
                columns: new[] { "Response Date", "Response Time", "Priority", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$7",
                table: "Service Invoice Line",
                columns: new[] { "Appl_-to Service Entry", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$10",
                table: "Service Invoice Line",
                columns: new[] { "Customer No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Service Invoice Line",
                columns: new[] { "Document No_", "Service Item No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$9",
                table: "Service Invoice Line",
                columns: new[] { "Fault Reason Code", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$8",
                table: "Service Invoice Line",
                columns: new[] { "Document No_", "Service Item Line No_", "Component Line No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Service Invoice Line",
                columns: new[] { "Document No_", "Service Item Line No_", "Serv_ Price Adjmt_ Gr_ Code", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Invoice Line",
                columns: new[] { "Type", "No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Service Invoice Line",
                columns: new[] { "Document No_", "Service Item Line No_", "Type", "No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Service Invoice Line",
                columns: new[] { "Service Item No_", "Type", "Posting Date", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Service Invoice Line",
                columns: new[] { "Type", "No_", "Variant Code", "Location Code", "Posting Date", "Shortcut Dimension 1 Code", "Shortcut Dimension 2 Code", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Service Item",
                columns: new[] { "Service Item Group Code", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Item",
                columns: new[] { "Item No_", "Serial No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Service Item",
                columns: new[] { "Sales_Serv_ Shpt_ Document No_", "Sales_Serv_ Shpt_ Line No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Service Item",
                columns: new[] { "Warranty Ending Date (Parts)", "Customer No_", "Ship-to Code", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Service Item",
                columns: new[] { "Customer No_", "Ship-to Code", "Item No_", "Serial No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Item Line",
                columns: new[] { "Document No_", "Line No_", "Document Type" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$10",
                table: "Service Item Line",
                columns: new[] { "Contract No_", "Document Type", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$9",
                table: "Service Item Line",
                columns: new[] { "Fault Reason Code", "Document Type", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Service Item Line",
                columns: new[] { "Loaner No_", "Document Type", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Service Item Line",
                columns: new[] { "Service Item No_", "Document Type", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Service Item Line",
                columns: new[] { "Document Type", "Document No_", "Response Date", "Response Time", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Service Item Line",
                columns: new[] { "Response Date", "Response Time", "Priority", "Document Type", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Ledger Entry",
                columns: new[] { "Document No_", "Posting Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Service Ledger Entry",
                columns: new[] { "Entry Type", "Document Type", "Document No_", "Document Line No_", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$7",
                table: "Service Ledger Entry",
                columns: new[] { "Service Item No_ (Serviced)", "Entry Type", "Type", "Service Contract No_", "Posting Date", "Service Order No_", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Service Ledger Entry",
                columns: new[] { "Type", "No_", "Entry Type", "Moved from Prepaid Acc_", "Posting Date", "Open", "Prepaid", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Service Ledger Entry",
                columns: new[] { "Service Order No_", "Service Item No_ (Serviced)", "Entry Type", "Moved from Prepaid Acc_", "Posting Date", "Open", "Type", "Service Contract No_", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Service Ledger Entry",
                columns: new[] { "Service Contract No_", "Entry No_", "Entry Type", "Type", "Moved from Prepaid Acc_", "Posting Date", "Open", "Prepaid", "Service Item No_ (Serviced)", "Customer No_", "Contract Group Code", "Responsibility Center" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Service Ledger Entry",
                columns: new[] { "Service Item No_ (Serviced)", "Entry Type", "Moved from Prepaid Acc_", "Type", "Posting Date", "Open", "Service Contract No_", "Prepaid", "Customer No_", "Contract Group Code", "Responsibility Center", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$8",
                table: "Service Line",
                columns: new[] { "Appl_-to Service Entry", "Document Type", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$12",
                table: "Service Line",
                columns: new[] { "Document Type", "Document No_", "Location Code", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Service Line",
                columns: new[] { "Document Type", "Document No_", "Service Item No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$10",
                table: "Service Line",
                columns: new[] { "Fault Reason Code", "Document Type", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Service Line",
                columns: new[] { "Document Type", "Bill-to Customer No_", "Currency Code", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$11",
                table: "Service Line",
                columns: new[] { "Document Type", "Customer No_", "Shipment No_", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$9",
                table: "Service Line",
                columns: new[] { "Document Type", "Document No_", "Service Item Line No_", "Component Line No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Service Line",
                columns: new[] { "Document Type", "Document No_", "Service Item Line No_", "Serv_ Price Adjmt_ Gr_ Code", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$13",
                table: "Service Line",
                columns: new[] { "Document Type", "Document No_", "Type", "No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Service Line",
                columns: new[] { "Document Type", "Document No_", "Service Item Line No_", "Type", "No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Service Line",
                columns: new[] { "Service Item No_", "Type", "Posting Date", "Document Type", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Line",
                columns: new[] { "Type", "No_", "Order Date", "Document Type", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$7",
                table: "Service Line",
                columns: new[] { "Type", "No_", "Variant Code", "Location Code", "Needed by Date", "Document Type", "Shortcut Dimension 1 Code", "Shortcut Dimension 2 Code", "Document No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Service Order",
                columns: new[] { "Date", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Order",
                columns: new[] { "Related Document Type", "Related Document No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Service Order",
                columns: new[] { "Related Document Type", "Related Posted Document No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Service Order",
                columns: new[] { "Service Provider No_", "Date", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Service Order Allocation",
                columns: new[] { "Resource No_", "Document Type", "Allocation Date", "Status", "Posted", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Service Order Allocation",
                columns: new[] { "Document Type", "Document No_", "Service Item Line No_", "Allocation Date", "Starting Time", "Posted", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Service Order Allocation",
                columns: new[] { "Document Type", "Document No_", "Status", "Resource Group No_", "Allocation Date", "Starting Time", "Posted", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Order Allocation",
                columns: new[] { "Status", "Document Type", "Document No_", "Service Item Line No_", "Allocation Date", "Starting Time", "Posted", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Service Order Allocation",
                columns: new[] { "Status", "Document Type", "Document No_", "Service Item Line No_", "Resource No_", "Allocation Date", "Starting Time", "Posted", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Order Items",
                columns: new[] { "Related Document No_", "Item No_", "Service Item No_", "Service Order No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Order Status",
                columns: new[] { "Status", "Exported", "Service Order No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Price Group",
                columns: new[] { "Description", "Code" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Service Product",
                columns: new[] { "Linked Item No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Service Product",
                columns: new[] { "Service Product ID", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$13",
                table: "Vendor",
                columns: new[] { "Buyer ID", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$9",
                table: "Vendor",
                columns: new[] { "City", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$12",
                table: "Vendor",
                columns: new[] { "Contact", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Vendor",
                columns: new[] { "Country_Region Code", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Vendor",
                columns: new[] { "Currency Code", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Vendor",
                columns: new[] { "Gen_ Bus_ Posting Group", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$8",
                table: "Vendor",
                columns: new[] { "Name", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$11",
                table: "Vendor",
                columns: new[] { "Phone No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$10",
                table: "Vendor",
                columns: new[] { "Post Code", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Vendor",
                columns: new[] { "Priority", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Vendor",
                columns: new[] { "Search Name", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$7",
                table: "Vendor",
                columns: new[] { "VAT Registration No_", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Vendor",
                columns: new[] { "Vendor Posting Group", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$8",
                table: "Vendor Ledger Entry",
                columns: new[] { "Closed by Entry No_", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$3",
                table: "Vendor Ledger Entry",
                columns: new[] { "Document No_", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$4",
                table: "Vendor Ledger Entry",
                columns: new[] { "External Document No_", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$9",
                table: "Vendor Ledger Entry",
                columns: new[] { "Transaction No_", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$15",
                table: "Vendor Ledger Entry",
                columns: new[] { "Vendor Posting Group", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Vendor Ledger Entry",
                columns: new[] { "Open", "Due Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Vendor Ledger Entry",
                columns: new[] { "Vendor No_", "Posting Date", "Currency Code", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$14",
                table: "Vendor Ledger Entry",
                columns: new[] { "Vendor No_", "Applies-to ID", "Open", "Positive", "Due Date", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$5",
                table: "Vendor Ledger Entry",
                columns: new[] { "Vendor No_", "Open", "Positive", "Due Date", "Currency Code", "Entry No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Warehouse Activity Header",
                columns: new[] { "Location Code", "Type", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Warehouse Activity Header",
                columns: new[] { "Source Document", "Source No_", "Location Code", "Type", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Warehouse Activity Line",
                columns: new[] { "No_", "Line No_", "Activity Type" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$17",
                table: "Warehouse Activity Line",
                columns: new[] { "Location Code", "Activity Type", "No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$15",
                table: "Warehouse Activity Line",
                columns: new[] { "Item No_", "Location Code", "Activity Type", "Bin Type Code", "Unit of Measure Code", "Variant Code", "Breakbulk No_", "Action Type", "Lot No_", "Serial No_", "Assemble to Order", "No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$2",
                table: "Warehouse Activity Line",
                columns: new[] { "Source Type", "Source Subtype", "Source No_", "Source Line No_", "Source Subline No_", "Unit of Measure Code", "Action Type", "Breakbulk No_", "Original Breakbulk", "Activity Type", "Assemble to Order", "No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$13",
                table: "Warehouse Activity Line",
                columns: new[] { "Whse_ Document No_", "Whse_ Document Type", "Activity Type", "Whse_ Document Line No_", "Action Type", "Unit of Measure Code", "Original Breakbulk", "Breakbulk No_", "Lot No_", "Serial No_", "Assemble to Order", "No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$14",
                table: "Warehouse Activity Line",
                columns: new[] { "Item No_", "Bin Code", "Location Code", "Action Type", "Variant Code", "Unit of Measure Code", "Breakbulk No_", "Activity Type", "Lot No_", "Serial No_", "Original Breakbulk", "Assemble to Order", "ATO Component", "No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Warehouse Shipment Header",
                columns: new[] { "Location Code", "No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$11",
                table: "Warehouse Shipment Line",
                columns: new[] { "Bin Code", "Location Code", "No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$10",
                table: "Warehouse Shipment Line",
                columns: new[] { "Item No_", "Location Code", "Variant Code", "Due Date", "No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$8",
                table: "Warehouse Shipment Line",
                columns: new[] { "Source Type", "Source Subtype", "Source No_", "Source Line No_", "Assemble to Order", "No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$1",
                table: "Whse_ Internal Pick Line",
                columns: new[] { "No_", "Sorting Sequence No_", "Line No_" },
                unique: true);

            migrationBuilder.CreateIndex(
                name: "$6",
                table: "Whse_ Internal Pick Line",
                columns: new[] { "To Bin Code", "Location Code", "No_", "Line No_" },
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cust_ Ledger Entry");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "Customer Order Discount Line");

            migrationBuilder.DropTable(
                name: "Customer Order Header");

            migrationBuilder.DropTable(
                name: "Customer Order Line");

            migrationBuilder.DropTable(
                name: "Customer Order Payment");

            migrationBuilder.DropTable(
                name: "Detailed Cust_ Ledg_Entry");

            migrationBuilder.DropTable(
                name: "Detailed Vendor Ledg_Entry");

            migrationBuilder.DropTable(
                name: "Item");

            migrationBuilder.DropTable(
                name: "Item Attributes");

            migrationBuilder.DropTable(
                name: "Item Brands");

            migrationBuilder.DropTable(
                name: "Item Category");

            migrationBuilder.DropTable(
                name: "Item Divisions");

            migrationBuilder.DropTable(
                name: "Item Ledger Entry");

            migrationBuilder.DropTable(
                name: "Item Measurement");

            migrationBuilder.DropTable(
                name: "Item Picture");

            migrationBuilder.DropTable(
                name: "Item Prices");

            migrationBuilder.DropTable(
                name: "Item Promotions");

            migrationBuilder.DropTable(
                name: "Item Stock Levels");

            migrationBuilder.DropTable(
                name: "Item Vendor");

            migrationBuilder.DropTable(
                name: "Payable Vendor Ledger Entry");

            migrationBuilder.DropTable(
                name: "Return Policy");

            migrationBuilder.DropTable(
                name: "Return Reason");

            migrationBuilder.DropTable(
                name: "Return Receipt Header");

            migrationBuilder.DropTable(
                name: "Return Receipt Line");

            migrationBuilder.DropTable(
                name: "Return Shipment Header");

            migrationBuilder.DropTable(
                name: "Return Shipment Line");

            migrationBuilder.DropTable(
                name: "Returns-Related Document");

            migrationBuilder.DropTable(
                name: "Sales Header");

            migrationBuilder.DropTable(
                name: "Sales Invoice Header");

            migrationBuilder.DropTable(
                name: "Sales Invoice Line");

            migrationBuilder.DropTable(
                name: "Sales Line");

            migrationBuilder.DropTable(
                name: "Sales Prepayment ");

            migrationBuilder.DropTable(
                name: "Sales Shipment Header");

            migrationBuilder.DropTable(
                name: "Sales Shipment Line");

            migrationBuilder.DropTable(
                name: "Sales Statistics");

            migrationBuilder.DropTable(
                name: "Service Bookings");

            migrationBuilder.DropTable(
                name: "Service Contract Header");

            migrationBuilder.DropTable(
                name: "Service Contract Line");

            migrationBuilder.DropTable(
                name: "Service Header");

            migrationBuilder.DropTable(
                name: "Service Invoice Header");

            migrationBuilder.DropTable(
                name: "Service Invoice Line");

            migrationBuilder.DropTable(
                name: "Service Item");

            migrationBuilder.DropTable(
                name: "Service Item Line");

            migrationBuilder.DropTable(
                name: "Service Ledger Entry");

            migrationBuilder.DropTable(
                name: "Service Line");

            migrationBuilder.DropTable(
                name: "Service Order");

            migrationBuilder.DropTable(
                name: "Service Order Allocation");

            migrationBuilder.DropTable(
                name: "Service Order Items");

            migrationBuilder.DropTable(
                name: "Service Order Status");

            migrationBuilder.DropTable(
                name: "Service Order Type");

            migrationBuilder.DropTable(
                name: "Service Price Group");

            migrationBuilder.DropTable(
                name: "Service Product");

            migrationBuilder.DropTable(
                name: "Service Product Type");

            migrationBuilder.DropTable(
                name: "Service Provider");

            migrationBuilder.DropTable(
                name: "Shipping Agent");

            migrationBuilder.DropTable(
                name: "Shipping Agent Services");

            migrationBuilder.DropTable(
                name: "Vendor");

            migrationBuilder.DropTable(
                name: "Vendor Ledger Entry");

            migrationBuilder.DropTable(
                name: "Visitors");

            migrationBuilder.DropTable(
                name: "Warehouse Activity Header");

            migrationBuilder.DropTable(
                name: "Warehouse Activity Line");

            migrationBuilder.DropTable(
                name: "Warehouse Shipment Header");

            migrationBuilder.DropTable(
                name: "Warehouse Shipment Line");

            migrationBuilder.DropTable(
                name: "Whse_ Internal Pick Header");

            migrationBuilder.DropTable(
                name: "Whse_ Internal Pick Line");
        }
    }
}
