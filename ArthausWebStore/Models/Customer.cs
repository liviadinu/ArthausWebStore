using System;
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
        public string TerritoryCode { get; set; }
        public string ChainName { get; set; }
        public decimal CreditLimitLcy { get; set; }
        public string CurrencyCode { get; set; }
        public string LanguageCode { get; set; }
        public int StatisticsGroup { get; set; }
        public string SalespersonCode { get; set; }
        public string ShipmentMethodCode { get; set; }
        public string ShippingAgentCode { get; set; }
        public string CustomerDiscGroup { get; set; }
        public string CountryRegionCode { get; set; }
        public decimal Amount { get; set; }
        public int Blocked { get; set; }
        public string VatRegistrationNo { get; set; }
        public byte CombineShipments { get; set; }
        public string PostCode { get; set; }
        public string County { get; set; }
        public string EMail { get; set; }
        public string HomePage { get; set; }
        public string TaxAreaCode { get; set; }
        public byte TaxLiable { get; set; }
        public string PreferredBankAccountCode { get; set; }
        public string ShippingAgentServiceCode { get; set; }
        public string ServiceZoneCode { get; set; }
        public decimal TransactionLimit { get; set; }
        public string DaytimePhoneNo { get; set; }
        public string MobilePhoneNo { get; set; }
        public string HouseNo { get; set; }
        public int ContactInfoId { get; set; }

    }
}
