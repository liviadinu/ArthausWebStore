using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class WarehouseActivityHeader
    {
        public byte[] Timestamp { get; set; }
        public int Type { get; set; }
        public string No { get; set; }
        public string LocationCode { get; set; }
        public string AssignedUserId { get; set; }
        public DateTime AssignmentDate { get; set; }
        public DateTime AssignmentTime { get; set; }
        public int SortingMethod { get; set; }
        public string NoSeries { get; set; }
        public int NoPrinted { get; set; }
        public DateTime PostingDate { get; set; }
        public string RegisteringNo { get; set; }
        public string LastRegisteringNo { get; set; }
        public string RegisteringNoSeries { get; set; }
        public DateTime DateOfLastPrinting { get; set; }
        public DateTime TimeOfLastPrinting { get; set; }
        public byte BreakbulkFilter { get; set; }
        public string SourceNo { get; set; }
        public int SourceDocument { get; set; }
        public int SourceType { get; set; }
        public int SourceSubtype { get; set; }
        public int DestinationType { get; set; }
        public string DestinationNo { get; set; }
        public string ExternalDocumentNo { get; set; }
        public DateTime ExpectedReceiptDate { get; set; }
        public DateTime ShipmentDate { get; set; }
        public string ExternalDocumentNo2 { get; set; }
    }
}
