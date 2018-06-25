using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class Vendor
    {
        public byte[] Timestamp { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string SearchName { get; set; }
        public string Name2 { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string Contact { get; set; }
        public string PhoneNo { get; set; }
        public string TelexNo { get; set; }
        public string OurAccountNo { get; set; }
        public string TerritoryCode { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public decimal BudgetedAmount { get; set; }
        public string VendorPostingGroup { get; set; }
        public string CurrencyCode { get; set; }
        public string LanguageCode { get; set; }
        public int StatisticsGroup { get; set; }
        public string PaymentTermsCode { get; set; }
        public string FinChargeTermsCode { get; set; }
        public string PurchaserCode { get; set; }
        public string ShipmentMethodCode { get; set; }
        public string ShippingAgentCode { get; set; }
        public string InvoiceDiscCode { get; set; }
        public string CountryRegionCode { get; set; }
        public int Blocked { get; set; }
        public string PayToVendorNo { get; set; }
        public int Priority { get; set; }
        public string PaymentMethodCode { get; set; }
        public DateTime LastDateModified { get; set; }
        public int ApplicationMethod { get; set; }
        public byte PricesIncludingVat { get; set; }
        public string FaxNo { get; set; }
        public string TelexAnswerBack { get; set; }
        public string VatRegistrationNo { get; set; }
        public string GenBusPostingGroup { get; set; }
        public byte[] Picture { get; set; }
        public string Gln { get; set; }
        public string PostCode { get; set; }
        public string County { get; set; }
        public string EMail { get; set; }
        public string HomePage { get; set; }
        public string NoSeries { get; set; }
        public string TaxAreaCode { get; set; }
        public byte TaxLiable { get; set; }
        public string VatBusPostingGroup { get; set; }
        public byte BlockPaymentTolerance { get; set; }
        public string IcPartnerCode { get; set; }
        public decimal Prepayment { get; set; }
        public int PartnerType { get; set; }
        public Guid Image { get; set; }
        public string CreditorNo { get; set; }
        public string PreferredBankAccountCode { get; set; }
        public string CashFlowPaymentTermsCode { get; set; }
        public string PrimaryContactNo { get; set; }
        public string ResponsibilityCenter { get; set; }
        public string LocationCode { get; set; }
        public string LeadTimeCalculation { get; set; }
        public string BaseCalendarCode { get; set; }
        public string DocumentSendingProfile { get; set; }
        public Guid Id { get; set; }
        public byte IfbVendor { get; set; }
        public byte DocumentApprovalMandatory { get; set; }
        public int RtcFilterField { get; set; }
        public string BuyerGroupCode { get; set; }
        public string BuyerId { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
        public byte PrivacyBlocked { get; set; }
        public byte ValidateEuVatRegNo { get; set; }
        public Guid CurrencyId { get; set; }
        public Guid PaymentTermsId { get; set; }
        public Guid PaymentMethodId { get; set; }
    }
}
