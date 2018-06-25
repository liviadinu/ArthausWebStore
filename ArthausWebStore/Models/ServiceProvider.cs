using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ServiceProvider
    {
        public byte[] Timestamp { get; set; }
        public string No { get; set; }
        public string Name { get; set; }
        public string VendorNo { get; set; }
        public string NoSeries { get; set; }
        public int CodeunitCreateExportFile { get; set; }
        public string ExportPath { get; set; }
        public string AliasServiceProvider { get; set; }
    }
}
