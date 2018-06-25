using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class CustomerOrderHeader
    {
        public byte[] Timestamp { get; set; }
        public string DocumentId { get; set; }
        public string StoreNo { get; set; }
        public string CollectLocation { get; set; }
        public Guid WebTransGuid { get; set; }
        public DateTime DocumentDateTime { get; set; }
        public int Status { get; set; }
        public string TerminalNo { get; set; }
        public string CurrencyCode { get; set; }
        public decimal CurrencyFactor { get; set; }
        public string VatBusPostingGroup { get; set; }
        public string PriceGroupCode { get; set; }
        public string CustomerNo { get; set; }
        public string CustDiscGroup { get; set; }
        public string MemberCardNo { get; set; }
        public string MemberContactNo { get; set; }
        public string MemberContactName { get; set; }
        public DateTime CollectTimeLimit { get; set; }
        public int SourceType { get; set; }
        public string ReceiptNo { get; set; }
        public string TransStoreNo { get; set; }
        public string TransTerminalNo { get; set; }
        public int TransactionNo { get; set; }
        public string FullName { get; set; }
        public string Address { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public string CountryRegionCode { get; set; }
        public string PhoneNo { get; set; }
        public string Email { get; set; }
        public string HouseApartmentNo { get; set; }
        public string MobilePhoneNo { get; set; }
        public string DaytimePhoneNo { get; set; }
        public string ShipToFullName { get; set; }
        public string ShipToAddress { get; set; }
        public string ShipToAddress2 { get; set; }
        public string ShipToCity { get; set; }
        public string ShipToCounty { get; set; }
        public string ShipToPostCode { get; set; }
        public string ShipToCountryRegionCode { get; set; }
        public string ShipToPhoneNo { get; set; }
        public string ShipToEmail { get; set; }
        public string ShipToHouseApartmentNo { get; set; }
        public byte ClickAndCollectOrder { get; set; }
        public byte AnonymousOrder { get; set; }
        public string ShippingAgentCode { get; set; }
        public string ShippingAgentServiceCode { get; set; }
        public string SalesOrderNo { get; set; }
        public string SourcingLocation { get; set; }
        public int SourcingOrder { get; set; }
        public string CreatedAtStore { get; set; }
        public byte InventoryTransfer { get; set; }
        public string ShipOrderPosFlag { get; set; }
        public byte ShipOrder { get; set; }
        public int StatusInfo { get; set; }
    }
}
