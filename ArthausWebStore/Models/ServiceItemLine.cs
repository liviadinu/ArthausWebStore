using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ServiceItemLine
    {
        public byte[] Timestamp { get; set; }
        public int DocumentType { get; set; }
        public string DocumentNo { get; set; }
        public int LineNo { get; set; }
        public string ServiceItemNo { get; set; }
        public string ServiceItemGroupCode { get; set; }
        public string ItemNo { get; set; }
        public string SerialNo { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string RepairStatusCode { get; set; }
        public int Priority { get; set; }
        public decimal ResponseTimeHours { get; set; }
        public DateTime ResponseDate { get; set; }
        public DateTime ResponseTime { get; set; }
        public DateTime StartingDate { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime FinishingDate { get; set; }
        public DateTime FinishingTime { get; set; }
        public string ServiceShelfNo { get; set; }
        public DateTime WarrantyStartingDateParts { get; set; }
        public DateTime WarrantyEndingDateParts { get; set; }
        public byte Warranty { get; set; }
        public decimal WarrantyParts { get; set; }
        public decimal WarrantyLabor { get; set; }
        public DateTime WarrantyStartingDateLabor { get; set; }
        public DateTime WarrantyEndingDateLabor { get; set; }
        public string ContractNo { get; set; }
        public string LoanerNo { get; set; }
        public string VendorNo { get; set; }
        public string VendorItemNo { get; set; }
        public string FaultReasonCode { get; set; }
        public string ServicePriceGroupCode { get; set; }
        public string FaultAreaCode { get; set; }
        public string SymptomCode { get; set; }
        public string FaultCode { get; set; }
        public string ResolutionCode { get; set; }
        public string VariantCode { get; set; }
        public decimal ActualResponseTimeHours { get; set; }
        public string ServPriceAdjmtGrCode { get; set; }
        public int AdjustmentType { get; set; }
        public decimal BaseAmountToAdjust { get; set; }
        public int ContractLineNo { get; set; }
        public string ShipToCode { get; set; }
        public string CustomerNo { get; set; }
        public string ResponsibilityCenter { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public int ReleaseStatus { get; set; }
        public int DimensionSetId { get; set; }
    }
}
