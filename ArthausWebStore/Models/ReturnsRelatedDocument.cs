using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ReturnsRelatedDocument
    {
        public byte[] Timestamp { get; set; }
        public int EntryNo { get; set; }
        public int DocumentType { get; set; }
        public string No { get; set; }
    }
}
