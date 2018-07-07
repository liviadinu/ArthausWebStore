using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArthausWebStore.Models
{
    public partial class ServiceProductPrices
    {
        public int Id { get; set; }
        public string MyProperty { get; set; }
        public string ServiceNo { get; set; }
        public string Description { get; set; }
        public string BaseCapacityUnitOfMeasure { get; set; }
        public string PricingMethod { get; set; }
        public decimal PricePerUnit { get; set; }
        public decimal MinAmountToOrder { get; set; }
        public decimal FreeAfterPoint { get; set; }
    }
}
