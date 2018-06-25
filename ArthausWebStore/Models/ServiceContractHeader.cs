using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ServiceContractHeader
    {
        public byte[] Timestamp { get; set; }
        public int ContractType { get; set; }
        public string ContractNo { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public int Status { get; set; }
        public int ChangeStatus { get; set; }
        public string CustomerNo { get; set; }
        public string ContactName { get; set; }
        public string YourReference { get; set; }
        public string SalespersonCode { get; set; }
        public string BillToCustomerNo { get; set; }
        public string ShipToCode { get; set; }
        public string ServContractAccGrCode { get; set; }
        public int InvoicePeriod { get; set; }
        public DateTime LastInvoiceDate { get; set; }
        public DateTime NextInvoiceDate { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public DateTime FirstServiceDate { get; set; }
        public decimal MaxLaborUnitPrice { get; set; }
        public decimal AnnualAmount { get; set; }
        public decimal AmountPerPeriod { get; set; }
        public byte CombineInvoices { get; set; }
        public byte Prepaid { get; set; }
        public string NextInvoicePeriod { get; set; }
        public string ServiceZoneCode { get; set; }
        public string LanguageCode { get; set; }
        public string CancelReasonCode { get; set; }
        public DateTime LastPriceUpdateDate { get; set; }
        public DateTime NextPriceUpdateDate { get; set; }
        public decimal LastPriceUpdate { get; set; }
        public decimal ResponseTimeHours { get; set; }
        public byte ContractLinesOnInvoice { get; set; }
        public string ServicePeriod { get; set; }
        public string PaymentTermsCode { get; set; }
        public byte InvoiceAfterService { get; set; }
        public int QuoteType { get; set; }
        public byte AllowUnbalancedAmounts { get; set; }
        public string ContractGroupCode { get; set; }
        public string ServiceOrderType { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public DateTime AcceptBefore { get; set; }
        public byte AutomaticCreditMemos { get; set; }
        public string TemplateNo { get; set; }
        public string PriceUpdatePeriod { get; set; }
        public string PriceInvIncreaseCode { get; set; }
        public byte PrintIncreaseText { get; set; }
        public string CurrencyCode { get; set; }
        public string NoSeries { get; set; }
        public decimal Probability { get; set; }
        public string ResponsibilityCenter { get; set; }
        public string PhoneNo { get; set; }
        public string FaxNo { get; set; }
        public string EMail { get; set; }
        public DateTime NextInvoicePeriodStart { get; set; }
        public DateTime NextInvoicePeriodEnd { get; set; }
        public int DimensionSetId { get; set; }
        public string ContactNo { get; set; }
        public string BillToContactNo { get; set; }
        public string BillToContact { get; set; }
        public DateTime LastInvoicePeriodEnd { get; set; }
    }
}
