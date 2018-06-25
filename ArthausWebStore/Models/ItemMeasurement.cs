using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ItemMeasurement
    {
        public string No { get; set; }
        public string Description { get; set; }
        public decimal GrossWeight { get; set; }
        public decimal NetWeight { get; set; }
        public decimal UnitsPerParcel { get; set; }
        public decimal UnitVolume { get; set; }
        public decimal Depth { get; set; }
        public decimal Width { get; set; }
        public decimal Height { get; set; }
        public string Code { get; set; }
        public decimal? QtyPerUnitOfMeasure { get; set; }
        public decimal? Length { get; set; }
        public decimal? Cubage { get; set; }
        public decimal? Weight { get; set; }
    }
}
