using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class WhseInternalPickLine
    {
        public byte[] Timestamp { get; set; }
        public string No { get; set; }
        public int LineNo { get; set; }
        public string LocationCode { get; set; }
        public string ShelfNo { get; set; }
        public string ToBinCode { get; set; }
        public string ToZoneCode { get; set; }
        public string ItemNo { get; set; }
        public decimal Quantity { get; set; }
        public decimal QtyBase { get; set; }
        public decimal QtyOutstanding { get; set; }
        public decimal QtyOutstandingBase { get; set; }
        public decimal QtyPicked { get; set; }
        public decimal QtyPickedBase { get; set; }
        public string UnitOfMeasureCode { get; set; }
        public decimal QtyPerUnitOfMeasure { get; set; }
        public string VariantCode { get; set; }
        public string Description { get; set; }
        public string Description2 { get; set; }
        public int Status { get; set; }
        public int SortingSequenceNo { get; set; }
        public DateTime DueDate { get; set; }
        public decimal Cubage { get; set; }
        public decimal Weight { get; set; }
    }
}
