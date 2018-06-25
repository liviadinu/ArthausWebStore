using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ServiceOrder
    {
        public byte[] Timestamp { get; set; }
        public string No { get; set; }
        public string ServiceItemNo { get; set; }
        public int TimeSlotNo { get; set; }
        public DateTime Date { get; set; }
        public DateTime StartingTime { get; set; }
        public DateTime EndingTime { get; set; }
        public string ServiceProviderNo { get; set; }
        public int ReservationId { get; set; }
        public string ServiceProductNo { get; set; }
        public string NoSeries { get; set; }
        public string RelatedDocumentNo { get; set; }
        public int RelatedDocumentLineNo { get; set; }
        public string RelatedPostedDocumentNo { get; set; }
        public int RelatedPostedDocLineNo { get; set; }
        public string StoreNo { get; set; }
        public string ProcessInStoreNo { get; set; }
        public string CapacityUnit { get; set; }
        public decimal Capacity { get; set; }
        public string PriceCalcMethod { get; set; }
        public decimal Price { get; set; }
        public int PricePeriodNo { get; set; }
        public decimal ManualInputForPricing { get; set; }
        public string PricingUnit { get; set; }
        public string DeletedField50 { get; set; }
        public int DeletedField51 { get; set; }
        public string DeletedField52 { get; set; }
        public int DeletedField53 { get; set; }
        public byte SourceDocumentIsPosted { get; set; }
        public int BookedDays { get; set; }
        public byte MultipleTimeSlots { get; set; }
        public decimal NumberOfAdjPackages { get; set; }
        public int RelatedDocumentType { get; set; }
        public string SalespersonCode { get; set; }
        public string SalesChannel { get; set; }
        public int SalesChannelType { get; set; }
        public string OriginalSalesChannel { get; set; }
        public int OriginalSalesChannelType { get; set; }
        public int TriggeringFactorForFailing { get; set; }
        public string ReasonCodeForFailing { get; set; }
    }
}
