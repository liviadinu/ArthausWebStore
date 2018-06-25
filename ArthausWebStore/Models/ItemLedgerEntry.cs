using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ItemLedgerEntry
    {
        public byte[] Timestamp { get; set; }
        public int EntryNo { get; set; }
        public string ItemNo { get; set; }
        public DateTime PostingDate { get; set; }
        public int EntryType { get; set; }
        public string SourceNo { get; set; }
        public string DocumentNo { get; set; }
        public string Description { get; set; }
        public string LocationCode { get; set; }
        public decimal Quantity { get; set; }
        public decimal RemainingQuantity { get; set; }
        public decimal InvoicedQuantity { get; set; }
        public int AppliesToEntry { get; set; }
        public byte Open { get; set; }
        public string GlobalDimension1Code { get; set; }
        public string GlobalDimension2Code { get; set; }
        public byte Positive { get; set; }
        public int SourceType { get; set; }
        public byte DropShipment { get; set; }
        public string TransactionType { get; set; }
        public string TransportMethod { get; set; }
        public string CountryRegionCode { get; set; }
        public string EntryExitPoint { get; set; }
        public DateTime DocumentDate { get; set; }
        public string ExternalDocumentNo { get; set; }
        public string Area { get; set; }
        public string TransactionSpecification { get; set; }
        public string NoSeries { get; set; }
        public int DocumentType { get; set; }
        public int DocumentLineNo { get; set; }
        public int OrderType { get; set; }
        public string OrderNo { get; set; }
        public int OrderLineNo { get; set; }
        public int DimensionSetId { get; set; }
        public byte AssembleToOrder { get; set; }
        public string JobNo { get; set; }
        public string JobTaskNo { get; set; }
        public byte JobPurchase { get; set; }
        public string VariantCode { get; set; }
        public decimal QtyPerUnitOfMeasure { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public byte DerivedFromBlanketOrder { get; set; }
        public string CrossReferenceNo { get; set; }
        public string OriginallyOrderedNo { get; set; }
        public string OriginallyOrderedVarCode { get; set; }
        public byte OutOfStockSubstitution { get; set; }
        public string ItemCategoryCode { get; set; }
        public byte Nonstock { get; set; }
        public string PurchasingCode { get; set; }
        public string ProductGroupCode { get; set; }
        public byte CompletelyInvoiced { get; set; }
        public DateTime LastInvoiceDate { get; set; }
        public byte AppliedEntryToAdjust { get; set; }
        public byte Correction { get; set; }
        public decimal ShippedQtyNotReturned { get; set; }
        public int ProdOrderCompLineNo { get; set; }
        public string SerialNo { get; set; }
        public string LotNo { get; set; }
        public DateTime WarrantyDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public int ItemTracking { get; set; }
        public string ReturnReasonCode { get; set; }
        public string OfferNo { get; set; }
        public string BatchNo { get; set; }
        public string PromotionNo { get; set; }
        public int TransferType { get; set; }
        public DateTime BiTimestamp { get; set; }
        public string StatementNo { get; set; }
    }
}
