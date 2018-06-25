﻿using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ServiceInvoiceHeader
    {
        public byte[] Timestamp { get; set; }
        public string No { get; set; }
        public string CustomerNo { get; set; }
        public string BillToCustomerNo { get; set; }
        public string BillToName { get; set; }
        public string BillToName2 { get; set; }
        public string BillToAddress { get; set; }
        public string BillToAddress2 { get; set; }
        public string BillToCity { get; set; }
        public string BillToContact { get; set; }
        public string YourReference { get; set; }
        public string ShipToCode { get; set; }
        public string ShipToName { get; set; }
        public string ShipToName2 { get; set; }
        public string ShipToAddress { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToContact { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime PostingDate { get; set; }
        public string PostingDescription { get; set; }
        public string PaymentTermsCode { get; set; }
        public DateTime DueDate { get; set; }
        public decimal PaymentDiscount { get; set; }
        public DateTime PmtDiscountDate { get; set; }
        public string LocationCode { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string CustomerPostingGroup { get; set; }
        public string CurrencyCode { get; set; }
        public decimal CurrencyFactor { get; set; }
        public string CustomerPriceGroup { get; set; }
        public byte PricesIncludingVat { get; set; }
        public string InvoiceDiscCode { get; set; }
        public string CustomerDiscGroup { get; set; }
        public string LanguageCode { get; set; }
        public string SalespersonCode { get; set; }
        public string OrderNo { get; set; }
        public int NoPrinted { get; set; }
        public int AppliesToDocType { get; set; }
        public string AppliesToDocNo { get; set; }
        public string BalAccountNo { get; set; }
        public string ShippingNo { get; set; }
        public string PostingNo { get; set; }
        public string LastShippingNo { get; set; }
        public string LastPostingNo { get; set; }
        public string VatRegistrationNo { get; set; }
        public string ReasonCode { get; set; }
        public string GenBusPostingGroup { get; set; }
        public byte Eu3PartyTrade { get; set; }
        public string TransactionType { get; set; }
        public string TransportMethod { get; set; }
        public string VatCountryRegionCode { get; set; }
        public string Name { get; set; }
        public string Name2 { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string ContactName { get; set; }
        public string BillToPostCode { get; set; }
        public string BillToCounty { get; set; }
        public string BillToCountryRegionCode { get; set; }
        public string PostCode { get; set; }
        public string County { get; set; }
        public string CountryRegionCode { get; set; }
        public string ShipToPostCode { get; set; }
        public string ShipToCounty { get; set; }
        public string ShipToCountryRegionCode { get; set; }
        public int BalAccountType { get; set; }
        public string ExitPoint { get; set; }
        public byte Correction { get; set; }
        public DateTime DocumentDate { get; set; }
        public string Area { get; set; }
        public string TransactionSpecification { get; set; }
        public string PaymentMethodCode { get; set; }
        public string PreAssignedNoSeries { get; set; }
        public string NoSeries { get; set; }
        public string ShippingNoSeries { get; set; }
        public string OrderNoSeries { get; set; }
        public string PreAssignedNo { get; set; }
        public string UserId { get; set; }
        public string SourceCode { get; set; }
        public string TaxAreaCode { get; set; }
        public byte TaxLiable { get; set; }
        public string VatBusPostingGroup { get; set; }
        public decimal VatBaseDiscount { get; set; }
        public int DimensionSetId { get; set; }
        public string DocumentExchangeIdentifier { get; set; }
        public int DocumentExchangeStatus { get; set; }
        public string DocExchOriginalIdentifier { get; set; }
        public string ContactNo { get; set; }
        public string BillToContactNo { get; set; }
        public string ResponsibilityCenter { get; set; }
        public string Description { get; set; }
        public string ServiceOrderType { get; set; }
        public byte LinkServiceToServiceItem { get; set; }
        public int Priority { get; set; }
        public string PhoneNo { get; set; }
        public string EMail { get; set; }
        public string PhoneNo2 { get; set; }
        public string FaxNo { get; set; }
        public DateTime OrderTime { get; set; }
        public decimal DefaultResponseTimeHours { get; set; }
        public decimal ActualResponseTimeHours { get; set; }
        public decimal ServiceTimeHours { get; set; }
        public DateTime ResponseDate { get; set; }
        public DateTime ResponseTime { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime FinishingDate { get; set; }
        public DateTime FinishingTime { get; set; }
        public int NotifyCustomer { get; set; }
        public decimal MaxLaborUnitPrice { get; set; }
        public int WarningStatus { get; set; }
        public string ContractNo { get; set; }
        public string ShipToFaxNo { get; set; }
        public string ShipToEMail { get; set; }
        public string ShipToPhone { get; set; }
        public string ShipToPhone2 { get; set; }
        public string ServiceZoneCode { get; set; }
        public DateTime ExpectedFinishingDate { get; set; }
        public byte AllowLineDisc { get; set; }
    }
}
