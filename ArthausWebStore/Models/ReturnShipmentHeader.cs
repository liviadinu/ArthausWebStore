using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ReturnShipmentHeader
    {
        public byte[] Timestamp { get; set; }
        public string No { get; set; }
        public string BuyFromVendorNo { get; set; }
        public string PayToVendorNo { get; set; }
        public string PayToName { get; set; }
        public string PayToName2 { get; set; }
        public string PayToAddress { get; set; }
        public string PayToAddress2 { get; set; }
        public string PayToCity { get; set; }
        public string PayToContact { get; set; }
        public string YourReference { get; set; }
        public string ShipToCode { get; set; }
        public string ShipToName { get; set; }
        public string ShipToName2 { get; set; }
        public string ShipToAddress { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToContact { get; set; }
        public DateTime PostingDate { get; set; }
        public DateTime ExpectedReceiptDate { get; set; }
        public string PostingDescription { get; set; }
        public string PaymentTermsCode { get; set; }
        public DateTime DueDate { get; set; }
        public decimal PaymentDiscount { get; set; }
        public DateTime PmtDiscountDate { get; set; }
        public string ShipmentMethodCode { get; set; }
        public string LocationCode { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string VendorPostingGroup { get; set; }
        public string CurrencyCode { get; set; }
        public decimal CurrencyFactor { get; set; }
        public string InvoiceDiscCode { get; set; }
        public string LanguageCode { get; set; }
        public string PurchaserCode { get; set; }
        public int NoPrinted { get; set; }
        public string OnHold { get; set; }
        public int AppliesToDocType { get; set; }
        public string AppliesToDocNo { get; set; }
        public string BalAccountNo { get; set; }
        public string VatRegistrationNo { get; set; }
        public string SellToCustomerNo { get; set; }
        public string ReasonCode { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string TransactionType { get; set; }
        public string TransportMethod { get; set; }
        public string VatCountryRegionCode { get; set; }
        public string BuyFromVendorName { get; set; }
        public string BuyFromVendorName2 { get; set; }
        public string BuyFromAddress { get; set; }
        public string BuyFromAddress2 { get; set; }
        public string BuyFromCity { get; set; }
        public string BuyFromContact { get; set; }
        public string PayToPostCode { get; set; }
        public string PayToCounty { get; set; }
        public string PayToCountryRegionCode { get; set; }
        public string BuyFromPostCode { get; set; }
        public string BuyFromCounty { get; set; }
        public string BuyFromCountryRegionCode { get; set; }
        public string ShipToPostCode { get; set; }
        public string ShipToCounty { get; set; }
        public string ShipToCountryRegionCode { get; set; }
        public int BalAccountType { get; set; }
        public string OrderAddressCode { get; set; }
        public string EntryPoint { get; set; }
        public byte Correction { get; set; }
        public DateTime DocumentDate { get; set; }
        public string Area { get; set; }
        public string TransactionSpecification { get; set; }
        public string PaymentMethodCode { get; set; }
        public string NoSeries { get; set; }
        public string UserId { get; set; }
        public string SourceCode { get; set; }
        public string TaxAreaCode { get; set; }
        public byte TaxLiable { get; set; }
        public string VatBusPostingGroup { get; set; }
        public decimal VatBaseDiscount { get; set; }
        public int DimensionSetId { get; set; }
        public string CampaignNo { get; set; }
        public string BuyFromContactNo { get; set; }
        public string PayToContactNo { get; set; }
        public string ResponsibilityCenter { get; set; }
        public string VendorAuthorizationNo { get; set; }
        public string ReturnOrderNo { get; set; }
        public string ReturnOrderNoSeries { get; set; }
        public string StoreNo { get; set; }
        public int RetailStatus { get; set; }
        public string RecivingPickingNo { get; set; }
    }
}
