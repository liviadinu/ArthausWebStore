using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ServiceItem
    {
        public byte[] Timestamp { get; set; }
        public string No { get; set; }
        public string SerialNo { get; set; }
        public string ServiceItemGroupCode { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public int Status { get; set; }
        public int Priority { get; set; }
        public string CustomerNo { get; set; }
        public string ShipToCode { get; set; }
        public string ItemNo { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public string LocationOfServiceItem { get; set; }
        public decimal SalesUnitPrice { get; set; }
        public decimal SalesUnitCost { get; set; }
        public DateTime WarrantyStartingDateLabor { get; set; }
        public DateTime WarrantyEndingDateLabor { get; set; }
        public DateTime WarrantyStartingDateParts { get; set; }
        public DateTime WarrantyEndingDateParts { get; set; }
        public decimal WarrantyParts { get; set; }
        public decimal WarrantyLabor { get; set; }
        public decimal ResponseTimeHours { get; set; }
        public DateTime InstallationDate { get; set; }
        public DateTime SalesDate { get; set; }
        public DateTime LastServiceDate { get; set; }
        public decimal DefaultContractValue { get; set; }
        public decimal DefaultContractDiscount { get; set; }
        public string VendorNo { get; set; }
        public string VendorItemNo { get; set; }
        public string NoSeries { get; set; }
        public string VendorItemName { get; set; }
        public string PreferredResource { get; set; }
        public string VariantCode { get; set; }
        public string ServicePriceGroupCode { get; set; }
        public decimal DefaultContractCost { get; set; }
        public string SearchDescription { get; set; }
        public string SalesServShptDocumentNo { get; set; }
        public int SalesServShptLineNo { get; set; }
        public int ShipmentType { get; set; }
    }
}
