﻿using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ReturnReceiptLine
    {
        public byte[] Timestamp { get; set; }
        public string DocumentNo { get; set; }
        public int LineNo { get; set; }
        public string SellToCustomerNo { get; set; }
        public int Type { get; set; }
        public string No { get; set; }
        public string LocationCode { get; set; }
        public string PostingGroup { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public string UnitOfMeasure { get; set; }
        public decimal Quantity { get; set; }
        public decimal UnitPrice { get; set; }
        public decimal UnitCostLcy { get; set; }
        public decimal Vat { get; set; }
        public decimal LineDiscount { get; set; }
        public byte AllowInvoiceDisc { get; set; }
        public decimal GrossWeight { get; set; }
        public decimal NetWeight { get; set; }
        public decimal UnitsPerParcel { get; set; }
        public decimal UnitVolume { get; set; }
        public int ApplToItemEntry { get; set; }
        public int ItemRcptEntryNo { get; set; }
        public string ShortcutDimension1Code { get; set; }
        public string ShortcutDimension2Code { get; set; }
        public string CustomerPriceGroup { get; set; }
        public string JobNo { get; set; }
        public string WorkTypeCode { get; set; }
        public decimal QuantityInvoiced { get; set; }
        public string BillToCustomerNo { get; set; }
        public string GenBusPostingGroup { get; set; }
        public string GenProdPostingGroup { get; set; }
        public int VatCalculationType { get; set; }
        public string TransactionType { get; set; }
        public string TransportMethod { get; set; }
        public int AttachedToLineNo { get; set; }
        public string ExitPoint { get; set; }
        public string Area { get; set; }
        public string TransactionSpecification { get; set; }
        public string TaxAreaCode { get; set; }
        public byte TaxLiable { get; set; }
        public string TaxGroupCode { get; set; }
        public string VatBusPostingGroup { get; set; }
        public string VatProdPostingGroup { get; set; }
        public string BlanketOrderNo { get; set; }
        public int BlanketOrderLineNo { get; set; }
        public decimal VatBaseAmount { get; set; }
        public decimal UnitCost { get; set; }
        public DateTime PostingDate { get; set; }
        public int DimensionSetId { get; set; }
        public string VariantCode { get; set; }
        public string BinCode { get; set; }
        public decimal QtyPerUnitOfMeasure { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public decimal QuantityBase { get; set; }
        public decimal QtyInvoicedBase { get; set; }
        public DateTime FaPostingDate { get; set; }
        public string DepreciationBookCode { get; set; }
        public byte DeprUntilFaPostingDate { get; set; }
        public string DuplicateInDepreciationBook { get; set; }
        public byte UseDuplicationList { get; set; }
        public string ResponsibilityCenter { get; set; }
        public string CrossReferenceNo { get; set; }
        public string UnitOfMeasureCrossRef { get; set; }
        public int CrossReferenceType { get; set; }
        public string CrossReferenceTypeNo { get; set; }
        public string ItemCategoryCode { get; set; }
        public byte Nonstock { get; set; }
        public string PurchasingCode { get; set; }
        public string ProductGroupCode { get; set; }
        public decimal ReturnQtyRcdNotInvd { get; set; }
        public int ApplFromItemEntry { get; set; }
        public decimal ItemChargeBaseAmount { get; set; }
        public byte Correction { get; set; }
        public string ReturnOrderNo { get; set; }
        public int ReturnOrderLineNo { get; set; }
        public string ReturnReasonCode { get; set; }
        public byte AllowLineDisc { get; set; }
        public string CustomerDiscGroup { get; set; }
    }
}
