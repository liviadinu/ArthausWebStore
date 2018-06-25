using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class WhseInternalPickHeader
    {
        public byte[] Timestamp { get; set; }
        public string No { get; set; }
        public string LocationCode { get; set; }
        public string AssignedUserId { get; set; }
        public DateTime AssignmentDate { get; set; }
        public DateTime AssignmentTime { get; set; }
        public int SortingMethod { get; set; }
        public string NoSeries { get; set; }
        public string ToBinCode { get; set; }
        public string ToZoneCode { get; set; }
        public int DocumentStatus { get; set; }
        public DateTime DueDate { get; set; }
        public int Status { get; set; }
    }
}
