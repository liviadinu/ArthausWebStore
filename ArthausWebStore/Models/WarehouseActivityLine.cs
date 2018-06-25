using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class WarehouseActivityLine
    {
        public byte[] Timestamp { get; set; }
        public int ActivityType { get; set; }
        public string No { get; set; }
        public int LineNo { get; set; }
        public int SourceType { get; set; }
        public int SourceSubtype { get; set; }
        public string SourceNo { get; set; }
        public int SourceLineNo { get; set; }
        public int SourceSublineNo { get; set; }
        public int SourceDocument { get; set; }
        public string LocationCode { get; set; }
        public string ShelfNo { get; set; }
        public int SortingSequenceNo { get; set; }
        public string ItemNo { get; set; }
        public string VariantCode { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public decimal QtyPerUnitOfMeasure { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public decimal Quantity { get; set; }
        public decimal QtyBase { get; set; }
        public decimal QtyOutstanding { get; set; }
        public decimal QtyOutstandingBase { get; set; }
        public decimal QtyToHandle { get; set; }
        public decimal QtyToHandleBase { get; set; }
        public decimal QtyHandled { get; set; }
        public decimal QtyHandledBase { get; set; }
        public int ShippingAdvice { get; set; }
        public DateTime DueDate { get; set; }
        public int DestinationType { get; set; }
        public string DestinationNo { get; set; }
        public string ShippingAgentCode { get; set; }
        public string ShippingAgentServiceCode { get; set; }
        public string ShipmentMethodCode { get; set; }
        public DateTime StartingDate { get; set; }
        public byte AssembleToOrder { get; set; }
        public byte AtoComponent { get; set; }
        public string SerialNo { get; set; }
        public string LotNo { get; set; }
        public DateTime WarrantyDate { get; set; }
        public DateTime ExpirationDate { get; set; }
        public string BinCode { get; set; }
        public string ZoneCode { get; set; }
        public int ActionType { get; set; }
        public int WhseDocumentType { get; set; }
        public string WhseDocumentNo { get; set; }
        public int WhseDocumentLineNo { get; set; }
        public int BinRanking { get; set; }
        public decimal Cubage { get; set; }
        public decimal Weight { get; set; }
        public string SpecialEquipmentCode { get; set; }
        public string BinTypeCode { get; set; }
        public int BreakbulkNo { get; set; }
        public byte OriginalBreakbulk { get; set; }
        public byte Breakbulk { get; set; }
        public int CrossDockInformation { get; set; }
        public byte Dedicated { get; set; }
    }
}
