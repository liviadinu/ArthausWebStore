using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ServiceContractLine
    {
        public byte[] Timestamp { get; set; }
        public int ContractType { get; set; }
        public string ContractNo { get; set; }
        public int LineNo { get; set; }
        public int ContractStatus { get; set; }
        public string ServiceItemNo { get; set; }
        public string Description { get; set; }
        public string SerialNo { get; set; }
        public string ServiceItemGroupCode { get; set; }
        public string CustomerNo { get; set; }
        public string ShipToCode { get; set; }
        public string ItemNo { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public decimal ResponseTimeHours { get; set; }
        public DateTime LastPlannedServiceDate { get; set; }
        public DateTime NextPlannedServiceDate { get; set; }
        public DateTime LastServiceDate { get; set; }
        public DateTime LastPreventiveMaintDate { get; set; }
        public DateTime InvoicedToDate { get; set; }
        public DateTime CreditMemoDate { get; set; }
        public DateTime ContractExpirationDate { get; set; }
        public string ServicePeriod { get; set; }
        public decimal LineValue { get; set; }
        public decimal LineDiscount { get; set; }
        public decimal LineAmount { get; set; }
        public string VariantCode { get; set; }
        public DateTime StartingDate { get; set; }
        public byte NewLine { get; set; }
        public byte Credited { get; set; }
        public decimal LineCost { get; set; }
        public decimal LineDiscountAmount { get; set; }
        public decimal Profit { get; set; }
    }
}
