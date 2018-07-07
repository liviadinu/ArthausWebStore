using System;
using System.Collections.Generic;

namespace ArthausWebStore.Models
{
    public partial class ItemDivisions
    {
        public string DivisionCode { get; set; }
        public string DivisionDescription { get; set; }
        public int BuyableOnline { get; set; }
        public byte Active { get; set; }
        public int Accessory { get; set; }
    }
}
