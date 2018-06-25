using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ServiceLedgerEntry
    {
        public byte[] Timestamp { get; set; }
        public int EntryNo { get; set; }
        public string ServiceContractNo { get; set; }
        public int DocumentType { get; set; }
        public string DocumentNo { get; set; }
        public string ServContractAccGrCode { get; set; }
        public int DocumentLineNo { get; set; }
        public byte MovedFromPrepaidAcc { get; set; }
        public DateTime PostingDate { get; set; }
        public decimal AmountLcy { get; set; }
        public string CustomerNo { get; set; }
        public string ShipToCode { get; set; }
        public string ItemNoServiced { get; set; }
        public string SerialNoServiced { get; set; }
        public string UserId { get; set; }
        public string ContractInvoicePeriod { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public string ServiceItemNoServiced { get; set; }
        public string VariantCodeServiced { get; set; }
        public string ContractGroupCode { get; set; }
        public int Type { get; set; }
        public string No { get; set; }
        public decimal CostAmount { get; set; }
        public decimal DiscountAmount { get; set; }
        public decimal UnitCost { get; set; }
        public decimal Quantity { get; set; }
        public decimal ChargedQty { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal Discount { get; set; }
        public decimal ContractDiscAmount { get; set; }
        public string BillToCustomerNo { get; set; }
        public string FaultReasonCode { get; set; }
        public string Description { get; set; }
        public string ServiceOrderType { get; set; }
        public string ServiceOrderNo { get; set; }
        public string JobNo { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public string LocationCode { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public string WorkTypeCode { get; set; }
        public string BinCode { get; set; }
        public string ResponsibilityCenter { get; set; }
        public string VariantCode { get; set; }
        public int EntryType { get; set; }
        public byte Open { get; set; }
        public string ServPriceAdjmtGrCode { get; set; }
        public string ServicePriceGroupCode { get; set; }
        public byte Prepaid { get; set; }
        public int ApplyUntilEntryNo { get; set; }
        public int AppliesToEntryNo { get; set; }
        public decimal Amount { get; set; }
        public string JobTaskNo { get; set; }
        public int JobLineType { get; set; }
        public byte JobPosted { get; set; }
        public int DimensionSetId { get; set; }
    }
}
