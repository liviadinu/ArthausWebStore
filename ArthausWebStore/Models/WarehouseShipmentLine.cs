using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class WarehouseShipmentLine
    {
        public byte[] Timestamp { get; set; }
        public string No { get; set; }
        public int LineNo { get; set; }
        public int SourceType { get; set; }
        public int SourceSubtype { get; set; }
        public string SourceNo { get; set; }
        public int SourceLineNo { get; set; }
        public int SourceDocument { get; set; }
        public string LocationCode { get; set; }
        public string ShelfNo { get; set; }
        public string BinCode { get; set; }
        public string ZoneCode { get; set; }
        public string ItemNo { get; set; }
        public decimal Quantity { get; set; }
        public decimal QtyBase { get; set; }
        public decimal QtyOutstanding { get; set; }
        public decimal QtyOutstandingBase { get; set; }
        public decimal QtyToShip { get; set; }
        public decimal QtyToShipBase { get; set; }
        public decimal QtyPicked { get; set; }
        public decimal QtyPickedBase { get; set; }
        public decimal QtyShipped { get; set; }
        public decimal QtyShippedBase { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public decimal QtyPerUnitOfMeasure { get; set; }
        public string VariantCode { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public int Status { get; set; }
        public int SortingSequenceNo { get; set; }
        public DateTime DueDate { get; set; }
        public int DestinationType { get; set; }
        public string DestinationNo { get; set; }
        public decimal Cubage { get; set; }
        public decimal Weight { get; set; }
        public int ShippingAdvice { get; set; }
        public DateTime ShipmentDate { get; set; }
        public byte CompletelyPicked { get; set; }
        public byte NotUpdBySrcDocPost { get; set; }
        public int PostingFromWhseRef { get; set; }
        public byte AssembleToOrder { get; set; }
    }
}
