using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ItemPromotions
    {
        public string ItemNo { get; set; }
        public string StoreNo { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal PromotionQty { get; set; }
    }
}
