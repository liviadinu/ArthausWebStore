using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ServiceBookings
    {
        public byte[] Timestamp { get; set; }
        public int EntryNo { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        public decimal Weight { get; set; }
        public decimal Volume { get; set; }
        public decimal Capacity { get; set; }
        public string StoreNo { get; set; }
        public string ServiceProductNo { get; set; }
        public string SalesOrderNo { get; set; }
        public int TimeSlotNo { get; set; }
        public byte Canceled { get; set; }
        public int ReservationId { get; set; }
    }
}
