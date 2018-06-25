using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ItemAttributes
    {
        public byte[] Timestamp { get; set; }
        public string No { get; set; }
        public string Description { get; set; }
        public string SearchDescription { get; set; }
        public string Description2 { get; set; }
        public string AlternativeItemNo { get; set; }
        public byte Blocked { get; set; }
        public string CountryRegionOfOriginCode { get; set; }
        public int Reserve { get; set; }
        public string SalesUnitOfMeasure { get; set; }
        public string PurchUnitOfMeasure { get; set; }
        public string ItemCategoryCode { get; set; }
        public int Assembled { get; set; }
        public int RangeCode { get; set; }
        public int CollectionYear { get; set; }
        public int RangeStatus { get; set; }
        public string DivisionCode { get; set; }
        public string SeasonCode { get; set; }
        public string Collection { get; set; }
        public string Color { get; set; }
        public string Style { get; set; }
        public string Brand { get; set; }
        public string ItemFamilyCode { get; set; }
        public bool Featured { get; set; }
        public bool MostViewed { get; set; }
        public bool BestSeller { get; set; }
    }
}
