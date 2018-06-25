﻿using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class Customer
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
        public string DocumentSendingProfile { get; set; }
        public string OurAccountNo { get; set; }
        public string TerritoryCode { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string ChainName { get; set; }
        public decimal BudgetedAmount { get; set; }
        public decimal CreditLimitLcy { get; set; }
        public string CustomerPostingGroup { get; set; }
        public string CurrencyCode { get; set; }
        public string CustomerPriceGroup { get; set; }
        public string LanguageCode { get; set; }
        public int StatisticsGroup { get; set; }
        public string PaymentTermsCode { get; set; }
        public string FinChargeTermsCode { get; set; }
        public string SalespersonCode { get; set; }
        public string ShipmentMethodCode { get; set; }
        public string ShippingAgentCode { get; set; }
        public string PlaceOfExport { get; set; }
        public string InvoiceDiscCode { get; set; }
        public string CustomerDiscGroup { get; set; }
        public string CountryRegionCode { get; set; }
        public string CollectionMethod { get; set; }
        public decimal Amount { get; set; }
        public int Blocked { get; set; }
        public int InvoiceCopies { get; set; }
        public int LastStatementNo { get; set; }
        public byte PrintStatements { get; set; }
        public string BillToCustomerNo { get; set; }
        public int Priority { get; set; }
        public string PaymentMethodCode { get; set; }
        public DateTime LastDateModified { get; set; }
        public int ApplicationMethod { get; set; }
        public byte PricesIncludingVat { get; set; }
        public string LocationCode { get; set; }
        public string FaxNo { get; set; }
        public string TelexAnswerBack { get; set; }
        public string VatRegistrationNo { get; set; }
        public byte CombineShipments { get; set; }
        public string GenBusPostingGroup { get; set; }
        public byte[] Picture { get; set; }
        public string Gln { get; set; }
        public string PostCode { get; set; }
        public string County { get; set; }
        public string EMail { get; set; }
        public string HomePage { get; set; }
        public string ReminderTermsCode { get; set; }
        public string NoSeries { get; set; }
        public string TaxAreaCode { get; set; }
        public byte TaxLiable { get; set; }
        public string VatBusPostingGroup { get; set; }
        public int Reserve { get; set; }
        public byte BlockPaymentTolerance { get; set; }
        public string IcPartnerCode { get; set; }
        public decimal Prepayment { get; set; }
        public int PartnerType { get; set; }
        public Guid Image { get; set; }
        public string PreferredBankAccountCode { get; set; }
        public string CashFlowPaymentTermsCode { get; set; }
        public string PrimaryContactNo { get; set; }
        public string ResponsibilityCenter { get; set; }
        public int ShippingAdvice { get; set; }
        public string ShippingTime { get; set; }
        public string ShippingAgentServiceCode { get; set; }
        public string ServiceZoneCode { get; set; }
        public byte AllowLineDisc { get; set; }
        public string BaseCalendarCode { get; set; }
        public int CopySellToAddrToQteFrom { get; set; }
        public DateTime DateCreated { get; set; }
        public string CreatedByUser { get; set; }
        public string CustomerId { get; set; }
        public string ReasonCode { get; set; }
        public int RestrictionFunctionality { get; set; }
        public byte PrintDocumentInvoice { get; set; }
        public decimal TransactionLimit { get; set; }
        public string DaytimePhoneNo { get; set; }
        public string MobilePhoneNo { get; set; }
        public string HouseNo { get; set; }
        public string RetailCustomerGroup { get; set; }
        public decimal DefaultWeight { get; set; }
        public byte OtherTenderInFinalizing { get; set; }
        public byte PostAsShipment { get; set; }
        public DateTime LastModifiedDateTime { get; set; }
        public byte PrivacyBlocked { get; set; }
        public int ContactType { get; set; }
        public byte ValidateEuVatRegNo { get; set; }
        public Guid Id { get; set; }
        public Guid CurrencyId { get; set; }
        public Guid PaymentTermsId { get; set; }
        public Guid ShipmentMethodId { get; set; }
        public Guid PaymentMethodId { get; set; }
        public Guid TaxAreaId { get; set; }
        public Guid ContactId { get; set; }
        public string ContactGraphId { get; set; }
    }
}
