using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ItemCategory
    {
        public string Code { get; set; }
        public string Description { get; set; }
        public int PresentationOrder { get; set; }
        public byte NotDiscountable { get; set; }
        public string DivisionCode { get; set; }
        public Guid Id { get; set; }
    }
}
